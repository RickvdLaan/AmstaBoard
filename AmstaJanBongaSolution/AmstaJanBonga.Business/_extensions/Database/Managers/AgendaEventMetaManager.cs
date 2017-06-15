using AmstaJanBonga.Business.EntityClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmstaJanBonga.Business.Database.Managers
{
    public abstract class AgendaEventMetaManager
    {
        public static void InsertAgendaEventMeta(int agendaEventId, int patientId, int unixTimeStamp, int repeatInterval)
        {
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
