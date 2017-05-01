﻿using AmstaJanBonga.Business.EntityClasses;
using Rlaan.Toolkit.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmstaJanBonga.Business.Database.Readers
{
    public abstract class LivingroomGeneralReader
    {
        public static LivingroomGeneralEntity GetLivingroomGeneralById(int livingroomId, bool throwExceptionWhenNotFound)
        {
            var livingroomGeneral = new LivingroomGeneralEntity(livingroomId);

            if (throwExceptionWhenNotFound && livingroomGeneral.IsNew)
                throw new Exception("Nothing found for livingroom {0}.".FormatString(livingroomId));

            return livingroomGeneral;
        }
    }
}