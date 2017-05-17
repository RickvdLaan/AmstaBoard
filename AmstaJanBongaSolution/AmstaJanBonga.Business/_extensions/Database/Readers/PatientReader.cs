using AmstaJanBonga.Business.CollectionClasses;
using AmstaJanBonga.Business.DaoClasses;
using AmstaJanBonga.Business.EntityClasses;
using AmstaJanBonga.Business.HelperClasses;
using AmstaJanBonga.Business.Security;
using Rlaan.Toolkit.Extensions;
using SD.LLBLGen.Pro.ORMSupportClasses;
using System;
using System.Data;

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
        public static PatientEntity GetPatientById(int patientId)
        {
            Authentication.AuthenticateActivity("");

            return new PatientEntity(patientId);
        }

        /// <summary>
        /// Gets the patient with the corresponding patient id or null. 
        /// </summary>
        /// <param name="patientId">The patients unique id.</param>
        /// <param name="throwExceptionWhenNotFound"></param>
        /// <returns></returns>
        public static PatientEntity GetPatientById(int patientId, bool throwExceptionWhenNotFound)
        {
            var patient = GetPatientById(patientId);

            if (patient.IsNew && throwExceptionWhenNotFound)
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
            Authentication.AuthenticateActivity("");

            var patients = new PatientCollection();
            patients.GetMulti(null, 0);

            return patients;
        }

        public static PatientCollection GetAllPatientsByLivingRoomId(int livingroomId)
        {
            Authentication.AuthenticateActivity("");

            // Collection
            var patients = new PatientCollection();

            // Predicate
            var predicate = new PredicateExpression();
            predicate.Add(PatientFields.LivingRoomId == livingroomId);

            // Sorting
            var sorter = new SortExpression();
            sorter.Add(PatientFields.FirstName | SortOperator.Ascending);

            // Get
            patients.GetMulti(predicate, 0, sorter);

            // Return
            return patients;
        }

        /// <summary>
        /// Returns a collection of all the patients joined with the livingroom relation.
        /// </summary>
        /// <returns></returns>
        public static DataTable GetAllPatientsJoinedWithLivingroom()
        {
            Authentication.AuthenticateActivity("");

            // The fields in the result.
            var fields = new ResultsetFields(3);
            fields.DefineField(PatientFields.Id, 0);
            fields.DefineField(PatientFields.FirstName, 1);
            fields.DefineField(LivingRoomFields.Name, 2);

            // Add all JOIN clauses from the relation collection.
            var relations = new RelationCollection
            {
                PatientEntity.Relations.LivingRoomEntityUsingLivingRoomId
            };

            // Create the DataTable, DAO and fill the DataTable with the above query definition/parameters.
            var dt = new DataTable();
            var dao = new TypedListDAO();
            dao.GetMultiAsDataTable(fields, dt, 0, null, null, relations, false, null, null, 0, 0);
            
            // Returns the dataset.
            return dt;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Returns a database count for all the patients.
        /// </summary>
        /// <returns></returns>
        public static int GetAllPatientsDBCount()
        {
            Authentication.AuthenticateActivity("");

            return new PatientCollection().GetDbCount();
        }

        #endregion
    }
}
