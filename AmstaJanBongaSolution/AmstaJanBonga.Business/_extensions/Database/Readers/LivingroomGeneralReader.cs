using AmstaJanBonga.Business.EntityClasses;
using AmstaJanBonga.Business.Security;
using Rlaan.Toolkit.Extensions;
using System;

namespace AmstaJanBonga.Business.Database.Readers
{
    public abstract class LivingRoomGeneralReader
    {
        public static LivingRoomGeneralEntity GetLivingRoomGeneralById(int livingRoomId, bool throwExceptionWhenNotFound)
        {
            Authentication.AuthenticateActivity("ReadLivingRoomGeneral");

            var livingRoomGeneral = new LivingRoomGeneralEntity(livingRoomId);

            if (throwExceptionWhenNotFound && livingRoomGeneral.IsNew)
                throw new Exception("Nothing found for living room {0}.".FormatString(livingRoomId));
            else if (!throwExceptionWhenNotFound && livingRoomGeneral.IsNew)
                return null;

            return livingRoomGeneral;
        }
    }
}
