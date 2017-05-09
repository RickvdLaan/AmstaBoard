using AmstaJanBonga.Business.EntityClasses;
using Rlaan.Toolkit.Configuration;
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
        public static EmployeeEntity InsertEmployee(int livingroomId, int? userId, string firstName, FileUpload fileUpload, bool isActive)
        {
            // Saving the employee wihtout an image, image is mandetory.
            var employee = new EmployeeEntity()
            {
                LivingroomId = livingroomId,
                UserId = userId,
                FirstName = firstName,
                ImagePath = string.Empty,
                IsActive = isActive,
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
        public static EmployeeEntity UpdateEmployee(EmployeeEntity employee, int livingroomId, int? userId, string firstName, FileUpload fileUpload, bool isActive)
        {
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
                employee.ImagePath = newPath.Substring(path.IndexOf(@"\_uploads\"));
            }

            employee.LivingroomId = livingroomId;
            employee.UserId = userId;
            employee.FirstName = firstName;
            employee.IsActive = isActive;

            // Saving the employee.
            employee.Save();

            return employee;
        }
    }
}