using AmstaJanBonga.Business.EntityClasses;
using AmstaJanBonga.Business.Security;

namespace AmstaJanBonga.Business.Database.Managers
{
    public abstract class AgendaEventManager
    {
        public static int InsertAgendaEvent(string title, int timeStart, int timeEnd, string location, string description)
        {
            Authentication.AuthenticateActivity("CreateAgendaEvent");

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
