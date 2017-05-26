using AmstaJanBonga.Business.Database.Readers;
using AmstaJanBonga.Business.EntityClasses;
using AmstaJanBonga.Business.Security;
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
    }
}
