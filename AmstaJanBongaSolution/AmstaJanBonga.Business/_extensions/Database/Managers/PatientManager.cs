using AmstaJanBonga.Business.EntityClasses;
using Rlaan.Toolkit.Configuration;
using System;
using System.IO;
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
        public static PatientEntity InsertPatient(int livingroomId, string firstName, FileUpload fileUpload, bool isActive)
        {
            // Saving the patient wihtout an image, image is mandetory.
            var patient = new PatientEntity()
            {
                LivingroomId = livingroomId,
                FirstName = firstName,
                ImagePath = string.Empty,
                IsActive = isActive,
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
                path = Helper.FileManager.SaveFileToVirtualDirectory(fileUpload, virtualDirectory, patient.Id);
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
        public static PatientEntity UpdatePatient(PatientEntity patient, int livingroomId, string firstName, FileUpload fileUpload, bool isActive)
        {
            // Deleting the existing file.
            if (File.Exists(patient.ImagePath) && fileUpload.HasFiles)
            {
                File.Delete(patient.ImagePath);

                // Setting variables
                var virtualDirectory = WebConfig.GetSetting("Upload.PatientImage", false);
                var filename = Helper.FileManager.ReplaceIllegalChars(fileUpload.FileName);

                // Saving the file to the virtual directory and setting the path on the entity.
                var path = Helper.FileManager.SaveFileToVirtualDirectory(fileUpload, virtualDirectory, patient.Id);
                patient.ImagePath = path.Substring(path.IndexOf(@"\_uploads\"));
            }

            patient.LivingroomId = livingroomId;
            patient.FirstName = firstName;
            patient.IsActive = isActive;

            // Saving the patient.
            patient.Save();

            return patient;
        }

        public static void MarkUserAsDeleted()
        {
            // Won't be implemented untill the entire database is done.
            throw new NotImplementedException();
        }
    }
}
