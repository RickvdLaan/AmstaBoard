using AmstaJanBonga.Business.Database.Readers;
using AmstaJanBonga.Business.EntityClasses;
using AmstaJanBonga.Business.Security;
using System;

namespace AmstaJanBonga.Business.Database.Managers
{
    public abstract class LivingroomGeneralManager
    {
        public static void InsertOrUpdate(int livingroomId, string description)
        {
            Authentication.AuthenticateActivity("");

            var livingroomGeneral = new LivingRoomGeneralEntity(livingroomId);

            if (livingroomGeneral.IsNew)
            {
                livingroomGeneral.LivingRoomId = livingroomId;
                livingroomGeneral.Description = description;
                livingroomGeneral.DateCreated = DateTime.Now;
            }
            else
            {
                livingroomGeneral.Description = description;
            }

            livingroomGeneral.Save();
        }
    }
}
