using AmstaJanBonga.Business.Database.Readers;
using AmstaJanBonga.Business.EntityClasses;
using AmstaJanBonga.Business.Security;
using Rlaan.Toolkit.Configuration;
using System;
using System.IO;
using System.Web;
using System.Web.UI.WebControls;

namespace AmstaJanBonga.Business.Database.Managers
{
    public abstract class PatientManager
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="livingroomId"></param>
        /// <param name="firstName"></param>
        /// <param name="imagePath"></param>
        /// <param name="isActive"></param>
        /// <returns></returns>
        public static PatientEntity InsertPatient(int livingroomId, string firstName, FileUpload fileUpload)
        {
            Authentication.AuthenticateActivity("CreatePatient");

            // Saving the patient wihtout an image, image is mandetory.
            var patient = new PatientEntity()
            {
                LivingRoomId = livingroomId,
                FirstName = firstName,
                ImagePath = string.Empty,
                DateCreated = DateTime.Now
            };

            // Saves the patient.
            patient.Save();

            // Setting variables.
            var path = string.Empty;
            var virtualDirectory = WebConfig.GetSetting("Upload.PatientImage", false);
            var filename = Helper.FileManager.ReplaceIllegalChars(fileUpload.FileName);

            // Checks whether the filename or virtual directory is legal, if not: abort action and revert changes.
            if (!Helper.FileManager.IsValidImage(filename) || string.IsNullOrEmpty(virtualDirectory))
            {
                patient.Delete();
                patient = null;
            }
            // Filename and the virtual directory are valid, saving the image to the virtual directory.
            else
            {
                path = Helper.FileManager.SaveImageToVirtualDirectory(fileUpload, virtualDirectory, patient.Id);
                patient.ImagePath = path.Substring(path.IndexOf(@"\_uploads\"));

                if (File.Exists(path))
                {
                    patient.Save();
                }
                // Image was not saved, abort action and revert changes.
                else
                {
                    patient.Delete();
                    patient = null;
                }
            }

            return patient;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="patient"></param>
        /// <param name="firstName"></param>
        /// <param name="imagePath"></param>
        /// <param name="isActive"></param>
        /// <returns></returns>
        public static PatientEntity UpdatePatient(PatientEntity patient, int livingroomId, string firstName, FileUpload fileUpload)
        {
            Authentication.AuthenticateActivity("UpdatePatient");

            // The path without the filename
            var path = HttpContext.Current.Server.MapPath(
                   string.Format("{0}{1}",
                   HttpContext.Current.Request.ApplicationPath,
                   patient.ImagePath));

            // Deleting the existing file.
            if (fileUpload.HasFiles)
            {
                if (File.Exists(path))
                    File.Delete(path);

                // Setting variables
                var virtualDirectory = WebConfig.GetSetting("Upload.PatientImage", false);
                var filename = Helper.FileManager.ReplaceIllegalChars(fileUpload.FileName);

                // Saving the file to the virtual directory and setting the path on the entity.
                var newPath = Helper.FileManager.SaveImageToVirtualDirectory(fileUpload, virtualDirectory, patient.Id);
                patient.ImagePath = newPath.Substring(path.IndexOf(@"\_uploads\"));
            }

            patient.LivingRoomId = livingroomId;
            patient.FirstName = firstName;

            // Saving the patient.
            patient.Save();

            return patient;
        }

        public static void DeletePatientImage(PatientEntity patient)
        {
            Authentication.AuthenticateActivity("DeletePatient");

            if (patient.IsNew || string.IsNullOrEmpty(patient.ImagePath))
                return;

            DeleteImage(patient);

            patient.ImagePath = null;
            patient.Save();
        }

        public static void DeletePatientImage(int patientId, bool throwExceptionIfNotFound)
        {
            Authentication.AuthenticateActivity("DeletePatient");

            var patient = PatientReader.GetPatientById(patientId, throwExceptionIfNotFound);

            DeletePatientImage(patient);
        }

        private static void DeleteImage(PatientEntity patient)
        {
            // The path without the filename
            var path = HttpContext.Current.Server.MapPath(
                   string.Format("{0}{1}",
                   HttpContext.Current.Request.ApplicationPath,
                   patient.ImagePath));

            if (File.Exists(path))
                File.Delete(path);
        }

        public static void MarkPatientAsDeleted(PatientEntity patient)
        {
            Authentication.AuthenticateActivity("DeletePatient");

            patient.IsMarkedAsDeleted = true;
            patient.DateDeleted = DateTime.Now;

            DeletePatientImage(patient);

            patient.Save();
        }

        public static void MarkPatientAsDeleted(int patientId)
        {
            Authentication.AuthenticateActivity("DeletePatient");

            var employee = new PatientEntity(patientId)
            {
                IsMarkedAsDeleted = true,
                DateDeleted = DateTime.Now
            };

            DeletePatientImage(patientId, false);

            employee.Save();
        }
    }
}
