using AmstaJanBonga.Business.EntityClasses;
using AmstaJanBonga.Business.Security;
using System;

namespace AmstaJanBonga.Business.Database.Managers
{
    public abstract class LivingRoomGeneralManager
    {
        public static void InsertOrUpdate(int livingRoomGeneralId, string description)
        {
            Authentication.AuthenticateActivity("CreateLivingRoomGeneral");

            var livingroomGeneral = new LivingRoomGeneralEntity(livingRoomGeneralId);

            if (livingroomGeneral.IsNew)
            {
                livingroomGeneral.LivingRoomId = livingRoomGeneralId;
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
