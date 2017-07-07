using AmstaJanBonga.Business.Database.Readers;
using AmstaJanBonga.Business.EntityClasses;
using AmstaJanBonga.Business.Security;
using System;

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

        public static void UpdateAgendaEvent(int id, string title, int timeStart, int timeEnd, string location, string description)
        {
            Authentication.AuthenticateActivity("UpdateAgendaEvent");

            var agendaEvent = new AgendaEventEntity(id);

            agendaEvent.Title = title;
            agendaEvent.TimeStart = timeStart;
            agendaEvent.TimeEnd = timeEnd;
            agendaEvent.Location = location;
            agendaEvent.Description = description;

            agendaEvent.Save();
        }

        public static void MarkAgendaEventAsDeleted(int id)
        {
            var agendaEvent = AgendaEventReader.GetAgendaEventById(id, true);

            agendaEvent.IsMarkedAsDeleted = true;
            agendaEvent.DateDeleted = DateTime.Now;

            agendaEvent.Save();
        }
    }
}
