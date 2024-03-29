﻿using AmstaJanBonga.Business.Database.Readers;
using AmstaJanBonga.Business.EntityClasses;
using AmstaJanBonga.Business.Security;
using Rlaan.Toolkit.Configuration;
using Rlaan.Toolkit.Extensions;
using System;
using System.IO;
using System.Web;
using System.Web.UI.WebControls;

namespace AmstaJanBonga.Business.Database.Managers
{
    public abstract class EmployeeManager
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="livingroomId"></param>
        /// <param name="firstName"></param>
        /// <param name="imagePath"></param>
        /// <param name="isActive"></param>
        /// <returns></returns>
        public static EmployeeEntity InsertEmployee(int livingroomId, int? userId, string firstName, FileUpload fileUpload)
        {
            Authentication.AuthenticateActivity("CreateEmployee");

            if (userId.HasValue)
            {
                // Multiple people might be working in the CMS at the same time, attempting to connect the same user.
                if (EmployeeReader.GetEmployeeByUserId(userId.Value, false) != null)
                {
                    throw new Exception("There already exists a user with userId: {0}.".FormatString(userId.Value));
                }
            }

            // Saving the employee wihtout an image, image is mandetory.
            var employee = new EmployeeEntity()
            {
                LivingRoomId = livingroomId,
                UserId = userId,
                FirstName = firstName,
                ImagePath = null,
                DateCreated = DateTime.Now
            };

            // Saves the employee.
            employee.Save();

            if (fileUpload.HasFiles)
            {
                // Setting variables.
                var path = string.Empty;
                var virtualDirectory = WebConfig.GetSetting("Upload.EmployeeImage", false);
                var filename = Helper.FileManager.ReplaceIllegalChars(fileUpload.FileName);

                // Checks whether the filename or virtual directory is legal, if not: abort action and revert changes.
                if (!Helper.FileManager.IsValidImage(filename) || string.IsNullOrEmpty(virtualDirectory))
                {
                    employee.Delete();
                    employee = null;
                }
                // Filename and the virtual directory are valid, saving the image to the virtual directory.
                else
                {
                    path = Helper.FileManager.SaveImageToVirtualDirectory(fileUpload, virtualDirectory, employee.Id);
                    employee.ImagePath = path.Substring(path.IndexOf(@"\_uploads\"));

                    if (File.Exists(path))
                    {
                        employee.Save();
                    }
                    // Image was not saved, abort action and revert changes.
                    else
                    {
                        employee.Delete();
                        employee = null;
                    }
                }
            }

            return employee;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="employee"></param>
        /// <param name="firstName"></param>
        /// <param name="imagePath"></param>
        /// <param name="isActive"></param>
        /// <returns></returns>
        public static EmployeeEntity UpdateEmployee(EmployeeEntity employee, int livingroomId, int? userId, string firstName, FileUpload fileUpload)
        {
            Authentication.AuthenticateActivity("UpdateEmployee");

            if (userId.HasValue)
            {
                if (employee.UserId.HasValue)
                {
                    if (employee.UserId.Value != userId.Value)
                    {
                        // Multiple people might be working in the CMS at the same time, attempting to connect the same user.
                        if (EmployeeReader.GetEmployeeByUserId(userId.Value, false) != null)
                        {
                            throw new Exception("There already exists a user with userId: {0}.".FormatString(userId.Value));
                        }
                    }
                }
            }

            // The path without the filename
            var path = HttpContext.Current.Server.MapPath(
                   string.Format("{0}{1}",
                   HttpContext.Current.Request.ApplicationPath,
                   employee.ImagePath));

            // Deleting the existing file.
            if (fileUpload.HasFiles)
            {
                if (File.Exists(path))
                    File.Delete(path);

                // Setting variables
                var virtualDirectory = WebConfig.GetSetting("Upload.EmployeeImage", false);
                var filename = Helper.FileManager.ReplaceIllegalChars(fileUpload.FileName);

                // Saving the file to the virtual directory and setting the path on the entity.
                var newPath = Helper.FileManager.SaveImageToVirtualDirectory(fileUpload, virtualDirectory, employee.Id);
                employee.ImagePath = newPath.Substring(newPath.IndexOf(@"\_uploads\"));
            }

            employee.LivingRoomId = livingroomId;
            employee.UserId = userId;
            employee.FirstName = firstName;

            // Saving the employee.
            employee.Save();

            return employee;
        }

        public static void DeleteEmployeeImage(EmployeeEntity employee)
        {
            Authentication.AuthenticateActivity("DeleteEmployee");

            if (employee.IsNew || string.IsNullOrEmpty(employee.ImagePath))
                return;

            DeleteImage(employee);

            employee.ImagePath = null;
            employee.Save();
        }

        public static void DeleteEmployeeImage(int employeeId, bool throwExceptionIfNotFound)
        {
            Authentication.AuthenticateActivity("DeleteEmployee");

            var employee = EmployeeReader.GetEmployeeById(employeeId, throwExceptionIfNotFound);

            DeleteEmployeeImage(employee);
        }

        private static void DeleteImage(EmployeeEntity employee)
        {
            // The path without the filename
            var path = HttpContext.Current.Server.MapPath(
                   string.Format("{0}{1}",
                   HttpContext.Current.Request.ApplicationPath,
                   employee.ImagePath));

            if (File.Exists(path))
                File.Delete(path);
        }

        public static void MarkEmployeeAsDeleted(EmployeeEntity employee)
        {
            Authentication.AuthenticateActivity("DeleteEmployee");

            employee.UserId = null;
            employee.IsMarkedAsDeleted = true;
            employee.DateDeleted = DateTime.Now;

            // Deleting the employees image.
            DeleteEmployeeImage(employee);

            // Deleting the shifts of the employee that are today and in the future, but not in the past.
            // The reason the future records are being deleted, is so it can't get any conflicts or end up with
            // corrupted data in the future. In the cleanup for deleting all records permenantly older than an x
            // amount of time all other records, including the old ones from this table will be deleted.
            LivingRoomShiftEventReader.GetAllFutureShiftsByEmployeeId(employee.Id).DeleteMulti();

            // Marking the employee as deleted, may be deleted permenantly in the future, but can be recovered.
            employee.Save();
        }

        public static void MarkEmployeeAsDeleted(int employeeId)
        {
            Authentication.AuthenticateActivity("DeleteEmployee");

            var employee = new EmployeeEntity(employeeId)
            {
                UserId = null,
                IsMarkedAsDeleted = true,
                DateDeleted = DateTime.Now
            };

            // Deleting the employees image.
            DeleteEmployeeImage(employeeId, false);

            // Deleting the shifts of the employee that are today and in the future, but not in the past.
            // The reason the future records are being deleted, is so it can't get any conflicts or end up with
            // corrupted data in the future. In the cleanup for deleting all records permenantly older than an x
            // amount of time all other records, including the old ones from this table will be deleted.
            LivingRoomShiftEventReader.GetAllFutureShiftsByEmployeeId(employee.Id).DeleteMulti();

            // Marking the employee as deleted, may be deleted permenantly in the future, but can be recovered.
            employee.Save();
        }
    }
}