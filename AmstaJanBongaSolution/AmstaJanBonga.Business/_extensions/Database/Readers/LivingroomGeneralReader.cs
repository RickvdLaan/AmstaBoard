using AmstaJanBonga.Business.EntityClasses;
using AmstaJanBonga.Business.Security;
using Rlaan.Toolkit.Extensions;
using System;

namespace AmstaJanBonga.Business.Database.Readers
{
    public abstract class LivingRoomGeneralReader
    {
        public static LivingRoomGeneralEntity GetLivingroomGeneralById(int livingroomId, bool throwExceptionWhenNotFound)
        {
            Authentication.AuthenticateActivity("");

            var livingroomGeneral = new LivingRoomGeneralEntity(livingroomId);

            if (throwExceptionWhenNotFound && livingroomGeneral.IsNew)
                throw new Exception("Nothing found for livingroom {0}.".FormatString(livingroomId));
            else if (!throwExceptionWhenNotFound && livingroomGeneral.IsNew)
                return null;

            return livingroomGeneral;
        }
    }
}
