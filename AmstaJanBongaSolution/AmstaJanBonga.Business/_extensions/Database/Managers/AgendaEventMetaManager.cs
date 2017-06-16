using AmstaJanBonga.Business.EntityClasses;
using AmstaJanBonga.Business.Security;

namespace AmstaJanBonga.Business.Database.Managers
{
    public abstract class AgendaEventMetaManager
    {
        public static void InsertAgendaEventMeta(int agendaEventId, int patientId, int unixTimeStamp, int repeatInterval)
        {
            Authentication.AuthenticateActivity("CreateAgendaEventMeta");

            var agendaEventMeta = new AgendaEventMetaEntity()
            {
                AgendaEventId = agendaEventId,
                PatientId = patientId,
                EventUnixTimeStamp = unixTimeStamp,
                RepeatInterval = repeatInterval == -1 ? null : (int?)repeatInterval
            };

            agendaEventMeta.Save();
        }
    }
}
