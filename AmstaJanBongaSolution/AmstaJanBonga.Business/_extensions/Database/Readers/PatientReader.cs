using AmstaJanBonga.Business.CollectionClasses;
using AmstaJanBonga.Business.EntityClasses;
using Rlaan.Toolkit.Extensions;
using System;

namespace AmstaJanBonga.Business.Database.Readers
{
    public abstract class PatientReader
    {
        #region Entities

        /// <summary>
        /// Gets the patient with the corresponding patient id or null. 
        /// </summary>
        /// <param name="patientId">The patients unique id.</param>
        /// <returns></returns>
        public static PatientEntity GetPatientById(int patientId, int livingroomId)
        {
            return new PatientEntity(patientId, livingroomId);
        }

        /// <summary>
        /// Gets the patient with the corresponding patient id or null. 
        /// </summary>
        /// <param name="patientId">The patients unique id.</param>
        /// <param name="throwExceptionWhenNotFound"></param>
        /// <returns></returns>
        public static PatientEntity GetPatientById(int patientId, int livingroomId, bool throwExceptionWhenNotFound)
        {
            var patient = GetPatientById(patientId, livingroomId);

            if (patient == null && throwExceptionWhenNotFound)
                throw new Exception("Patient not found for id {0}.".FormatString(patientId));

            return patient;
        }

        #endregion

        #region Collections

        /// <summary>
        /// Returns a collection of all the patients.
        /// </summary>
        /// <returns></returns>
        public static PatientCollection GetAllPatients()
        {
            var patients = new PatientCollection();
            patients.GetMulti(null, 0);

            return patients;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Returns a database count for all the patients.
        /// </summary>
        /// <returns></returns>
        public static int GetAllPatientsDBCount()
        {
            return new PatientCollection().GetDbCount();
        }

        #endregion
    }
}
