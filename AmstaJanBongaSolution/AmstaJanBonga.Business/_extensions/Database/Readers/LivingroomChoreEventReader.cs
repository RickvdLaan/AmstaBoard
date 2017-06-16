using AmstaJanBonga.Business.CollectionClasses;
using AmstaJanBonga.Business.DaoClasses;
using AmstaJanBonga.Business.EntityClasses;
using AmstaJanBonga.Business.Enums;
using AmstaJanBonga.Business.HelperClasses;
using AmstaJanBonga.Business.Security;
using Rlaan.Toolkit.Extensions;
using SD.LLBLGen.Pro.ORMSupportClasses;
using System;
using System.Collections.Generic;
using System.Data;

namespace AmstaJanBonga.Business.Database.Readers
{
    public abstract class LivingRoomChoreEventReader
    {
        public static LivingRoomChoreEventEntity GetChoreByIds(int patientId, int livingroomId, DateTime date, TimeOfDayTypeEnum timeOfDay, bool throwExceptionWhenNotFound)
        {
            Authentication.AuthenticateActivity("ReadLivingRoomChoreEvent");

            var chore = new LivingRoomChoreEventEntity(date, livingroomId, patientId, (byte)timeOfDay);

            // The hidden field is set to -1 if a '+' was clicked.
            if (patientId != -1 && chore.IsNew && throwExceptionWhenNotFound)
            {
                // Can occur if the application did not refresh after midnight? For example, the first minute after midnight.
                throw new Exception("Chore not found by PatientId: {0}, LivingRoomId: {1}, Date: {2} and TimeOfDay: {3}.".FormatString(patientId, livingroomId, date, timeOfDay));
            }
            else if (chore.IsNew)
            {
                chore.PatientId = patientId;
                chore.LivingRoomId = livingroomId;
                chore.Date = date;
                chore.TimeOfDayTypeEnum = (byte)timeOfDay;
                chore.DateCreated = DateTime.Now;
            }

            return chore;
        }

        public static LivingRoomChoreEventCollection GetAllChoresFilteredByLivingroomAndDate(int livingroomId, DateTime date)
        {
            Authentication.AuthenticateActivity("ReadLivingRoomChoreEvent");

            var chores = new LivingRoomChoreEventCollection();

            // Sorter
            var sorter = new SortExpression
            {
                LivingRoomChoreEventFields.Date | SortOperator.Ascending
            };

            // Predicate
            var predicate = new PredicateExpression
            {
                LivingRoomChoreEventFields.LivingRoomId == livingroomId,
                LivingRoomChoreEventFields.Date == date
            };

            chores.GetMulti(predicate, 0, sorter);

            return chores;
        }

        public static DataTable GetAllChoresDistinctByLivingRoomId(int livingroomId)
        {
            Authentication.AuthenticateActivity("ReadLivingRoomChoreEvent");

            // Result fields.
            var fields = new ResultsetFields(3)
            {
                LivingRoomChoreEventFields.LivingRoomId,
                LivingRoomFields.Name,
                LivingRoomChoreEventFields.Date
            };

            // Sorter
            var sorter = new SortExpression
            {
                LivingRoomChoreEventFields.Date | SortOperator.Ascending
            };

            // Adds the JOIN clause from the relation collection.
            var relations = new RelationCollection
            {
                LivingRoomChoreEventEntity.Relations.LivingRoomEntityUsingLivingRoomId
            };

            // Predicate
            var predicate = new PredicateExpression
            {
                LivingRoomChoreEventFields.LivingRoomId == livingroomId,
                LivingRoomChoreEventFields.Date >= DateTime.Now
            };

            // Create the DataTable, DAO and fill the DataTable with the above query definition/parameters.
            var dt = new DataTable();
            var dao = new TypedListDAO();
            dao.GetMultiAsDataTable(fields, dt, 0, sorter, predicate, relations, false, null, null, 0, 0);

            // Returns the dataset.
            return dt;
        }

        public static List<DateTime> GetAllUsedDatesByLivingRoomId(int livingroomId)
        {
            Authentication.AuthenticateActivity("ReadLivingRoomChoreEvent");

            // Result fields.
            var fields = new ResultsetFields(1)
            {
                LivingRoomChoreEventFields.Date
            };

            // Sorting
            var sorter = new SortExpression
            {
                LivingRoomChoreEventFields.Date | SortOperator.Ascending
            };

            // Predicate
            var predicate = new PredicateExpression
            {
                LivingRoomChoreEventFields.LivingRoomId == livingroomId
            };

            // Create the DataTable, DAO and fill the DataTable with the above query definition/parameters.
            var dt = new DataTable();
            var dao = new TypedListDAO();
            dao.GetMultiAsDataTable(fields, dt, 0, sorter, predicate, null, false, null, null, 0, 0);

            var dates = new List<DateTime>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dates.Add(Convert.ToDateTime(dt.Rows[i]["Date"]));
            }

            return dates;
        }
    }
}
