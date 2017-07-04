using AmstaJanBonga.Business.EntityClasses;
using AmstaJanBonga.Business.Security;
using Rlaan.Toolkit.Extensions;
using System;

namespace AmstaJanBonga.Business.Database.Readers
{
    public abstract class AgendaEventMetaReader
    {
        public static AgendaEventMetaEntity GetAgendaEventMetaById(int agendaEventMetaId)
        {
            Authentication.AuthenticateActivity("ReadAgendaEventMeta");

            return new AgendaEventMetaEntity(agendaEventMetaId);
        }

        public static AgendaEventMetaEntity GetAgendaEventMetaById(int agendaEventMetaId, bool throwExceptionWhenNotFound)
        {
            // Uses the Authentication.AuthenticateActivity from GetAgendaEventMetaById(agendaEventMetaId).

            var agendaEventMeta = GetAgendaEventMetaById(agendaEventMetaId);

            if (agendaEventMeta.IsNew && throwExceptionWhenNotFound)
                throw new Exception("AgendaEventMeta not found for id {0}.".FormatString(agendaEventMetaId));

            return agendaEventMeta;
        }
    }
}
