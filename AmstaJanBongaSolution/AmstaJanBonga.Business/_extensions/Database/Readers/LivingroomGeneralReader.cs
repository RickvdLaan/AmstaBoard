using AmstaJanBonga.Business.EntityClasses;
using Rlaan.Toolkit.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmstaJanBonga.Business.Database.Readers
{
    public abstract class LivingRoomGeneralReader
    {
        public static LivingRoomGeneralEntity GetLivingroomGeneralById(int livingroomId, bool throwExceptionWhenNotFound)
        {
            var livingroomGeneral = new LivingRoomGeneralEntity(livingroomId);

            if (throwExceptionWhenNotFound && livingroomGeneral.IsNew)
                throw new Exception("Nothing found for livingroom {0}.".FormatString(livingroomId));
            else if (!throwExceptionWhenNotFound && livingroomGeneral.IsNew)
                return null;

            return livingroomGeneral;
        }
    }
}
