﻿using AmstaJanBonga.Business.Database.Readers;
using AmstaJanBonga.Business.EntityClasses;
using AmstaJanBonga.Business.Security;
using System;

namespace AmstaJanBonga.Business.Database.Managers
{
    public abstract class AgendaEventMetaManager
    {
        public static void InsertAgendaEventMeta(int agendaEventId, int patientId, int unixTimeStamp, int? repeatInterval)
        {
            Authentication.AuthenticateActivity("CreateAgendaEventMeta");

            var agendaEventMeta = new AgendaEventMetaEntity()
            {
                AgendaEventId = agendaEventId,
                PatientId = patientId,
                EventUnixTimeStamp = unixTimeStamp,
                RepeatInterval = repeatInterval.HasValue ? (int?)repeatInterval.Value * Time.UnixTime.UNIX_TIMESTAMP_WEEK : null,
                DateCreated = DateTime.Now
            };

            agendaEventMeta.Save();
        }

        public static void UpdateAgendaEventMeta(int id, int unixTimeStamp, int? repeatInterval)
        {
            Authentication.AuthenticateActivity("UpdateAgendaEventMeta");

            var agendaEventMeta = new AgendaEventMetaEntity(id)
            {
                EventUnixTimeStamp = unixTimeStamp,
                RepeatInterval = repeatInterval.HasValue ? (int?)repeatInterval.Value * Time.UnixTime.UNIX_TIMESTAMP_WEEK : null
            };

            agendaEventMeta.Save();
        }

        /// <summary>
        /// Marks the agenda event meta data as deleted so it won't show up in any of the results anymore. 
        /// </summary>
        /// <param name="agendaEventMetaId">The unique agenda event meta id.</param>
        public static void MarkAgendaEventMetaAsDeleted(int agendaEventMetaId)
        {
            var agendaEventMeta = AgendaEventMetaReader.GetAgendaEventMetaById(agendaEventMetaId);

            agendaEventMeta.IsMarkedAsDeleted = true;
            agendaEventMeta.DateDeleted = DateTime.Now;

            agendaEventMeta.Save();

            // Validating whether there is one, or more appointments connected to the current meta data.
            if (AgendaEventMetaReader.AgendaEventCountInAgendaEventMetaByAgendaEventId(agendaEventMeta.AgendaEventId) == 1)
            {
                // If there's only one, then it means it's not connected to any other patients appointment, so it can be deleted.
                // Because in the future we might make it possible to assign multiple patients to the same agenda event.
                // The database is already made to support it, but it depends on time/demand. 
                AgendaEventManager.MarkAgendaEventAsDeleted(agendaEventMeta.AgendaEventId);
            }
        }
    }
}
