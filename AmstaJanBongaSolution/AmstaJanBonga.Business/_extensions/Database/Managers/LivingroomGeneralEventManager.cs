using AmstaJanBonga.Business.Database.Readers;
using AmstaJanBonga.Business.EntityClasses;
using AmstaJanBonga.Business.Security;
using System;

namespace AmstaJanBonga.Business.Database.Managers
{
    public abstract class LivingroomGeneralEventManager
    {
        public static void Insert(int livingroomId, DateTime date, string description)
        {
            Authentication.AuthenticateActivity("");

            var livingroomGeneralEvent = new LivingRoomGeneralEventEntity()
            {
                LivingRoomId = livingroomId,
                Date = date,
                Description = description,
                DateCreated = DateTime.Now
            };

            livingroomGeneralEvent.Save();
        }

        public static void Update(int livingroomId, DateTime date, string description)
        {
            Authentication.AuthenticateActivity("");

            var livingroomGeneralEvent = LivingRoomGeneralEventReader.GetLivingroomGeneralByIdAndDate(livingroomId, date, true);

            livingroomGeneralEvent.Description = description;
            livingroomGeneralEvent.Save();
        }
    }
}
