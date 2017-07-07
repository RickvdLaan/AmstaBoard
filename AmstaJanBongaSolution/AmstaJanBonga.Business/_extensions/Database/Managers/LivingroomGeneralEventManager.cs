using AmstaJanBonga.Business.CollectionClasses;
using AmstaJanBonga.Business.Database.Readers;
using AmstaJanBonga.Business.EntityClasses;
using AmstaJanBonga.Business.HelperClasses;
using AmstaJanBonga.Business.Security;
using SD.LLBLGen.Pro.ORMSupportClasses;
using System;

namespace AmstaJanBonga.Business.Database.Managers
{
    public abstract class LivingRoomGeneralEventManager
    {
        public static void Insert(int livingRoomId, DateTime date, string description)
        {
            Authentication.AuthenticateActivity("CreateLivingRoomGeneralEvent");

            var livingroomGeneralEvent = new LivingRoomGeneralEventEntity()
            {
                LivingRoomId = livingRoomId,
                Date = date,
                Description = description,
                DateCreated = DateTime.Now
            };

            livingroomGeneralEvent.Save();
        }

        public static void Update(int livingRoomId, DateTime date, string description)
        {
            Authentication.AuthenticateActivity("UpdateLivingRoomGeneralEvent");

            var livingRoomGeneralEvent = LivingRoomGeneralEventReader.GetLivingRoomGeneralByLivingRoomIdAndDate(livingRoomId, date, true);

            livingRoomGeneralEvent.Description = description;
            livingRoomGeneralEvent.Save();
        }

        public static void DeleteGeneralEvent(int livingRoomId, DateTime date)
        {
            Authentication.AuthenticateActivity("DeleteLivingRoomGeneralEvent");

            var livingRoomGeneralEvent = new LivingRoomGeneralEventCollection();

            var filter = new PredicateExpression
            {
                LivingRoomGeneralEventFields.LivingRoomId == livingRoomId
            };

            filter.AddWithAnd(LivingRoomGeneralEventFields.Date == date.Date);

            livingRoomGeneralEvent.GetMulti(filter, 0);

            livingRoomGeneralEvent.DeleteMulti();
        }
    }
}
