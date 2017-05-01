using AmstaJanBonga.Business.CollectionClasses;
using AmstaJanBonga.Business.DaoClasses;
using AmstaJanBonga.Business.EntityClasses;
using AmstaJanBonga.Business.Enums;
using AmstaJanBonga.Business.HelperClasses;
using Rlaan.Toolkit.Extensions;
using SD.LLBLGen.Pro.ORMSupportClasses;
using System;
using System.Collections.Generic;
using System.Data;

namespace AmstaJanBonga.Business.Database.Readers
{
    public abstract class LivingroomChoreEventReader
    {
        public static LivingroomChoreEventEntity GetChoreByIds(int patientId, int livingroomId, DateTime date, TimeOfDayTypeEnum timeOfDay, bool throwExceptionWhenNotFound)
        {
            var chore = new LivingroomChoreEventEntity(date, livingroomId, patientId, (byte)timeOfDay);

            // The hidden field is set to -1 if a '+' was clicked.
            if (patientId != -1 && chore.IsNew && throwExceptionWhenNotFound)
            {
                throw new Exception("Chore not found by PatientId: {0}, LivingroomId: {1}, Date: {2} and TimeOfDay: {3}.".FormatString(patientId, livingroomId, date, timeOfDay));
            }
            else if (chore.IsNew)
            {
                chore.DateCreated = DateTime.Now;
            }

            return chore;
        }

        public static LivingroomChoreEventCollection GetAllChoresFilteredByLivingroomAndDate(int livingroomId, DateTime date)
        {
            var chores = new LivingroomChoreEventCollection();

            // Sorter
            var sorter = new SortExpression
            {
                LivingroomChoreEventFields.Date | SortOperator.Ascending
            };

            // Predicate
            var predicate = new PredicateExpression
            {
                LivingroomChoreEventFields.LivingroomId == livingroomId,
                LivingroomChoreEventFields.Date == date
            };

            chores.GetMulti(predicate, 0, sorter);

            return chores;
        }

        public static DataTable GetAllChoresDistinctByLivingroomId(int livingroomId)
        {
            // Result fields.
            var fields = new ResultsetFields(3)
            {
                LivingroomChoreEventFields.LivingroomId,
                LivingroomFields.Name,
                LivingroomChoreEventFields.Date
            };

            // Sorter
            var sorter = new SortExpression
            {
                LivingroomChoreEventFields.Date | SortOperator.Ascending
            };

            // Adds the JOIN clause from the relation collection.
            var relations = new RelationCollection
            {
                LivingroomChoreEventEntity.Relations.LivingroomEntityUsingLivingroomId
            };

            // Predicate
            var predicate = new PredicateExpression
            {
                LivingroomChoreEventFields.LivingroomId == livingroomId,
                LivingroomChoreEventFields.Date >= DateTime.Now
            };

            // Create the DataTable, DAO and fill the DataTable with the above query definition/parameters.
            var dt = new DataTable();
            var dao = new TypedListDAO();
            dao.GetMultiAsDataTable(fields, dt, 0, sorter, predicate, relations, false, null, null, 0, 0);

            // Returns the dataset.
            return dt;
        }

        public static List<DateTime> GetAllUsedDatesByLivingroomId(int livingroomId)
        {
            // Result fields.
            var fields = new ResultsetFields(1)
            {
                LivingroomChoreEventFields.Date
            };

            // Sorting
            var sorter = new SortExpression
            {
                LivingroomChoreEventFields.Date | SortOperator.Ascending
            };

            // Predicate
            var predicate = new PredicateExpression
            {
                LivingroomChoreEventFields.LivingroomId == livingroomId
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
