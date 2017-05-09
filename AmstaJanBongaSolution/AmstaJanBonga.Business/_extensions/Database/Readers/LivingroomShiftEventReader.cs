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
    public abstract class LivingroomShiftEventReader
    {
        public static LivingroomShiftEventEntity GetShiftByIds(int employeeId, int livingroomId, DateTime date, ShiftTypeEnum shiftType, bool throwExceptionWhenNotFound)
        {
            var shift = new LivingroomShiftEventEntity(date, employeeId, livingroomId, (byte)shiftType);

            // The hidden field is set to -1 if a '+' was clicked.
            if (employeeId != -1 && shift.IsNew && throwExceptionWhenNotFound)
            {
                throw new Exception("Shift not found by EmployeeId: {0}, LivingroomId: {1}, Date: {2} and ShiftTypeEnum: {3}.".FormatString(employeeId, livingroomId, date, shiftType));
            }
            else if (shift.IsNew)
            {
                shift.DateCreated = DateTime.Now;
            }

            return shift;
        }

        public static DataTable GetAllShiftsDistinctByLivingroomId(int livingroomId)
        {
            // Result fields.
            var fields = new ResultsetFields(3)
            {
                LivingroomShiftEventFields.LivingroomId,
                LivingroomFields.Name,
                LivingroomShiftEventFields.Date
            };

            // Sorter
            var sorter = new SortExpression
            {
                LivingroomShiftEventFields.Date | SortOperator.Ascending
            };

            // Adds the JOIN clause from the relation collection.
            var relations = new RelationCollection
            {
                LivingroomShiftEventEntity.Relations.LivingroomEntityUsingLivingroomId
            };

            // Predicate
            var predicate = new PredicateExpression
            {
                LivingroomShiftEventFields.LivingroomId == livingroomId,
                LivingroomShiftEventFields.Date >= DateTime.Now
            };

            // Create the DataTable, DAO and fill the DataTable with the above query definition/parameters.
            var dt = new DataTable();
            var dao = new TypedListDAO();
            dao.GetMultiAsDataTable(fields, dt, 0, sorter, predicate, relations, false, null, null, 0, 0);

            // Returns the dataset.
            return dt;
        }

        public static LivingroomShiftEventCollection GetAllShiftsFilteredByLivingroomAndDate(int livingroomId, DateTime date)
        {
            var shifts = new LivingroomShiftEventCollection();

            // Sorter
            var sorter = new SortExpression
            {
                LivingroomShiftEventFields.Date | SortOperator.Ascending,
                LivingroomShiftEventFields.ShiftTypeEnum | SortOperator.Ascending
            };

            // Predicate
            var predicate = new PredicateExpression
            {
                LivingroomShiftEventFields.LivingroomId == livingroomId,
                LivingroomShiftEventFields.Date == date
            };

            shifts.GetMulti(predicate, -1, sorter);

            return shifts;
        }

        public static List<DateTime> GetAllUsedDatesByLivingroomId(int livingroomId)
        {
            // Result fields.
            var fields = new ResultsetFields(1)
            {
                LivingroomShiftEventFields.Date
            };

            // Sorting
            var sorter = new SortExpression
            {
                LivingroomShiftEventFields.Date | SortOperator.Ascending
            };

            // Predicate
            var predicate = new PredicateExpression
            {
                LivingroomShiftEventFields.LivingroomId == livingroomId
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
