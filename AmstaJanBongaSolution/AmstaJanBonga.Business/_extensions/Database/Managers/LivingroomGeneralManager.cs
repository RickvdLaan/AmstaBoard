using AmstaJanBonga.Business.Database.Readers;
using AmstaJanBonga.Business.EntityClasses;
using System;

namespace AmstaJanBonga.Business.Database.Managers
{
    public abstract class LivingroomGeneralManager
    {
        public static void InsertOrUpdate(int livingroomId, string description)
        {
            var livingroomGeneral = new LivingroomGeneralEntity(livingroomId);

            if (livingroomGeneral.IsNew)
            {
                livingroomGeneral.LivingroomId = livingroomId;
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
