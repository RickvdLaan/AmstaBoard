using AmstaJanBonga.Business.CollectionClasses;
using AmstaJanBonga.Business.EntityClasses;
using AmstaJanBonga.Business.HelperClasses;
using AmstaJanBonga.Business.Security;
using Rlaan.Toolkit.Extensions;
using SD.LLBLGen.Pro.ORMSupportClasses;
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
                throw new Exception("AgendaEventMeta not found for id {0} or has been removed.".FormatString(agendaEventMetaId));

            return agendaEventMeta;
        }

        public static int AgendaEventCountInAgendaEventMetaByAgendaEventId(int agendaEventId)
        {
            var agendaEventMeta = new AgendaEventMetaCollection();

            var filter = new PredicateExpression()
            {
                AgendaEventMetaFields.AgendaEventId == agendaEventId
            };

            return agendaEventMeta.GetDbCount(filter);
        }
    }
}
