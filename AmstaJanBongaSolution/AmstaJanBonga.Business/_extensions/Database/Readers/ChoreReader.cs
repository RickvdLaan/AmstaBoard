using AmstaJanBonga.Business.CollectionClasses;
using AmstaJanBonga.Business.DaoClasses;
using AmstaJanBonga.Business.EntityClasses;
using AmstaJanBonga.Business.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using System;
using System.Collections.Generic;
using System.Data;

namespace AmstaJanBonga.Business.Database.Readers
{
    public abstract class ChoreReader
    {
        public static DataTable GetAllChoresDistinctByLivingroomId(int livingroomId)
        {
            // Result fields.
            var fields = new ResultsetFields(3)
            {
                ChoreFields.LivingroomId,
                LivingroomFields.Name,
                ChoreFields.Date
            };

            // Sorting
            var sorter = new SortExpression();
            sorter.Add(ChoreFields.Date | SortOperator.Ascending);

            // Adds the JOIN clause from the relation collection.
            var relations = new RelationCollection
            {
                ChoreEntity.Relations.LivingroomEntityUsingLivingroomId
            };

            // Predicate
            var predicate = new PredicateExpression();
            predicate.Add(ChoreFields.LivingroomId == livingroomId);

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
                ChoreFields.Date
            };

            // Sorting
            var sorter = new SortExpression();
            sorter.Add(ChoreFields.Date | SortOperator.Ascending);

            // Predicate
            var predicate = new PredicateExpression();
            predicate.Add(ChoreFields.LivingroomId == livingroomId);

            // Create the DataTable, DAO and fill the DataTable with the above query definition/parameters.
            var dt = new DataTable();
            var dao = new TypedListDAO();
            dao.GetMultiAsDataTable(fields, dt, 0, sorter, predicate, null, false, null, null, 0, 0);

            List<DateTime> dates = new List<DateTime>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dates.Add(Convert.ToDateTime(dt.Rows[i]["Date"]));
            }

            return dates;
        }
    }
}
