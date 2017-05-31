using AmstaJanBonga.Business.CollectionClasses;
using AmstaJanBonga.Business.DaoClasses;
using AmstaJanBonga.Business.EntityClasses;
using AmstaJanBonga.Business.HelperClasses;
using AmstaJanBonga.Business.Security;
using Rlaan.Toolkit.Extensions;
using SD.LLBLGen.Pro.ORMSupportClasses;
using System;
using System.Collections.Generic;
using System.Data;

namespace AmstaJanBonga.Business.Database.Readers
{
    public abstract class LivingRoomGeneralEventReader
    {
        public static LivingRoomGeneralEventCollection GetAllLivingRoomGeneralEventsByLivingRoomId(int livingRoomId)
        {
            Authentication.AuthenticateActivity("ReadLivingRoomGeneralEvent");

            var livingroomGeneralEvents = new LivingRoomGeneralEventCollection();

            var predicate = new PredicateExpression();
            predicate.Add(LivingRoomGeneralEventFields.LivingRoomId == livingRoomId);
            predicate.Add(LivingRoomGeneralEventFields.Date >= DateTime.Now);

            // Adds the JOIN clause from the relation collection.
            var relations = new RelationCollection
            {
                LivingRoomGeneralEventEntity.Relations.LivingRoomEntityUsingLivingRoomId,
                LivingRoomGeneralEntity.Relations.LivingRoomEntityUsingLivingRoomId
            };

            livingroomGeneralEvents.GetMulti(predicate, 0, null, relations);

            return livingroomGeneralEvents;
        }

        public static List<DateTime> GetAllUsedDatesByLivingRoomId(int livingroomId)
        {
            Authentication.AuthenticateActivity("ReadLivingRoomGeneralEvent");

            // Result fields.
            var fields = new ResultsetFields(1)
            {
                LivingRoomGeneralEventFields.Date
            };

            // Sorting
            var sorter = new SortExpression
            {
                LivingRoomGeneralEventFields.Date | SortOperator.Ascending
            };

            // Predicate
            var predicate = new PredicateExpression
            {
                LivingRoomGeneralEventFields.LivingRoomId == livingroomId
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

        public static LivingRoomGeneralEventEntity GetLivingRoomGeneralByLivingRoomIdAndDate(int livingRoomId, DateTime date, bool throwExceptionWhenNotFound)
        {
            Authentication.AuthenticateActivity("ReadLivingRoomGeneralEvent");

            var livingRoomGeneralEvent = new LivingRoomGeneralEventEntity(date, livingRoomId);

            if (throwExceptionWhenNotFound && livingRoomGeneralEvent.IsNew)
                throw new Exception("Nothing found for living room {0} and date {1}.".FormatString(livingRoomId, date));
            else if (livingRoomGeneralEvent.IsNew)
                return null;

            return livingRoomGeneralEvent;
        }
    }
}
