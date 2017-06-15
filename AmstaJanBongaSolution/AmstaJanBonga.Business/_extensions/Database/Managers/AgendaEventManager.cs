using AmstaJanBonga.Business.EntityClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmstaJanBonga.Business.Database.Managers
{
    public abstract class AgendaEventManager
    {
        public static int InsertAgendaEvent(string title, int timeStart, int timeEnd, string location, string description)
        {
            var agendaEvent = new AgendaEventEntity()
            {
                Title = title,
                TimeStart = timeStart,
                TimeEnd = timeEnd,
                Location = location,
                Description = description
            };

            agendaEvent.Save();

            return agendaEvent.Id;
        }
    }
}
