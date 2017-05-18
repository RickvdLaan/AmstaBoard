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
    public abstract class LivingRoomShiftEventReader
    {
        public static LivingRoomShiftEventEntity GetShiftByIds(int employeeId, int livingRoomId, DateTime date, ShiftTypeEnum shiftType, bool throwExceptionWhenNotFound)
        {
            Authentication.AuthenticateActivity("ReadLivingRoomShiftEvent");

            var shift = new LivingRoomShiftEventEntity(date, employeeId, livingRoomId, (byte)shiftType);

            // The hidden field is set to -1 if a '+' was clicked.
            if (employeeId != -1 && shift.IsNew && throwExceptionWhenNotFound)
            {
                throw new Exception("Shift not found by EmployeeId: {0}, LivingRoomId: {1}, Date: {2} and ShiftTypeEnum: {3}.".FormatString(employeeId, livingRoomId, date, shiftType));
            }
            else if (shift.IsNew)
            {
                shift.EmployeeId = employeeId;
                shift.Date = date;
                shift.ShiftTypeEnum = (byte)shiftType;
                shift.LivingRoomId = livingRoomId;
                shift.DateCreated = DateTime.Now;
            }

            return shift;
        }

        public static DataTable GetAllShiftsDistinctByLivingRoomId(int livingRoomId)
        {
            Authentication.AuthenticateActivity("ReadLivingRoomShiftEvent");

            // Result fields.
            var fields = new ResultsetFields(3)
            {
                LivingRoomShiftEventFields.LivingRoomId,
                LivingRoomFields.Name,
                LivingRoomShiftEventFields.Date
            };

            // Sorter
            var sorter = new SortExpression
            {
                LivingRoomShiftEventFields.Date | SortOperator.Ascending
            };

            // Adds the JOIN clause from the relation collection.
            var relations = new RelationCollection
            {
                LivingRoomShiftEventEntity.Relations.LivingRoomEntityUsingLivingRoomId,
                LivingRoomShiftEventEntity.Relations.EmployeeEntityUsingEmployeeId
            };

            // Predicate
            var predicate = new PredicateExpression
            {
                LivingRoomShiftEventFields.LivingRoomId == livingRoomId,
                LivingRoomShiftEventFields.Date >= DateTime.Now,
                EmployeeFields.IsMarkedAsDeleted == false
            };

            // Create the DataTable, DAO and fill the DataTable with the above query definition/parameters.
            var dt = new DataTable();
            var dao = new TypedListDAO();
            dao.GetMultiAsDataTable(fields, dt, 0, sorter, predicate, relations, false, null, null, 0, 0);

            // Returns the dataset.
            return dt;
        }

        public static LivingRoomShiftEventCollection GetAllShiftsFilteredByLivingroomAndDate(int livingRoomId, DateTime date)
        {
            Authentication.AuthenticateActivity("ReadLivingRoomShiftEvent");

            var shifts = new LivingRoomShiftEventCollection();

            // Sorter
            var sorter = new SortExpression
            {
                LivingRoomShiftEventFields.Date | SortOperator.Descending,
                LivingRoomShiftEventFields.ShiftTypeEnum | SortOperator.Descending,
                LivingRoomShiftEventFields.DateCreated | SortOperator.Descending
            };

            // Predicate
            var predicate = new PredicateExpression();
            predicate.Add(LivingRoomShiftEventFields.LivingRoomId == livingRoomId);
            predicate.AddWithAnd(LivingRoomShiftEventFields.Date == date);
            predicate.AddWithAnd(EmployeeFields.IsMarkedAsDeleted == false);

            // Adds the JOIN clause from the relation collection.
            var relations = new RelationCollection
            {
                LivingRoomShiftEventEntity.Relations.EmployeeEntityUsingEmployeeId
            };

            shifts.GetMulti(predicate, 0, sorter, relations);

            return shifts;
        }

        public static List<DateTime> GetAllUsedDatesByLivingRoomId(int livingRoomId)
        {
            Authentication.AuthenticateActivity("ReadLivingRoomShiftEvent");

            // Result fields.
            var fields = new ResultsetFields(1)
            {
                LivingRoomShiftEventFields.Date
            };

            // Sorting
            var sorter = new SortExpression
            {
                LivingRoomShiftEventFields.Date | SortOperator.Ascending
            };

            // Predicate
            var predicate = new PredicateExpression
            {
                LivingRoomShiftEventFields.LivingRoomId == livingRoomId
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
