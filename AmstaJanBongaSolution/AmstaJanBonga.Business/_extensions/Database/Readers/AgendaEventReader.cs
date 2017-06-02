using AmstaJanBonga.Business.CollectionClasses;
using AmstaJanBonga.Business.EntityClasses;
using AmstaJanBonga.Business.HelperClasses;
using AmstaJanBonga.Business.StoredProcedureCallerClasses;
using Rlaan.Toolkit.Extensions;
using SD.LLBLGen.Pro.ORMSupportClasses;
using System;
using System.Collections.Generic;

namespace AmstaJanBonga.Business.Database.Readers
{
    public abstract class AgendaEventReader
    {
        /// <summary>
        /// Returns a list of AgendaEventCollections with a size of 7, set up from Monday to Sunday.
        /// </summary>
        /// <param name="patientId">Provide the patients id.</param>
        /// <returns></returns>
        public static List<AgendaEventCollection> GetAllEventsForWeekByPatientId(int patientId)
        {
            var appointments = new List<AgendaEventCollection>(7)
            {
                // Monday
                GetAllEventsByDateAndPatientId(Time.UnixTime.FirstDayOfWeek + (Time.UnixTime.UNIX_TIMESTAMP_DAY * 0), patientId),

                // Tuesday
                GetAllEventsByDateAndPatientId(Time.UnixTime.FirstDayOfWeek + (Time.UnixTime.UNIX_TIMESTAMP_DAY * 1), patientId),

                // Wednesday
                GetAllEventsByDateAndPatientId(Time.UnixTime.FirstDayOfWeek + (Time.UnixTime.UNIX_TIMESTAMP_DAY * 2), patientId),

                // Thursday
                GetAllEventsByDateAndPatientId(Time.UnixTime.FirstDayOfWeek + (Time.UnixTime.UNIX_TIMESTAMP_DAY * 3), patientId),

                // Friday
                GetAllEventsByDateAndPatientId(Time.UnixTime.FirstDayOfWeek + (Time.UnixTime.UNIX_TIMESTAMP_DAY * 4), patientId),

                // Saturday
                GetAllEventsByDateAndPatientId(Time.UnixTime.FirstDayOfWeek + (Time.UnixTime.UNIX_TIMESTAMP_DAY * 5), patientId),

                // Sunday
                GetAllEventsByDateAndPatientId(Time.UnixTime.FirstDayOfWeek + (Time.UnixTime.UNIX_TIMESTAMP_DAY * 6), patientId)
            };

            return appointments;
        }

        /// <summary>
        /// Returns a collection of agenda events for the current day based on the provided patient id.
        /// </summary>
        /// <param name="patientId">Provide the patients id.</param>
        /// <returns></returns>
        public static AgendaEventCollection GetAllEventsForTodayByPatientId(int patientId)
        {
            return GetAllEventsByDateAndPatientId(Time.UnixTime.Today, patientId);
        }

        /// <summary>
        /// Returns a collection of agenda events.
        /// </summary>
        /// <param name="unixTimeStamp">Provide the unix timestamp for a specific date with time set on 00:00:00.</param>
        /// <param name="patientId">Provide the patients id.</param>
        /// <returns></returns>
        public static AgendaEventCollection GetAllEventsByDateAndPatientId(int unixTimeStamp, int patientId)
        {
            var subExpression = new Expression(unixTimeStamp, ExOp.Sub, AgendaEventMetaFields.EventUnixTimeStamp);
            var modExpression = new Expression(subExpression, ExOp.Mod, AgendaEventMetaFields.RepeatInterval);

            var filter = new PredicateExpression();
            filter.Add(AgendaEventMetaFields.Id.SetExpression(modExpression) == 0); 
            filter.AddWithAnd(AgendaEventMetaFields.PatientId == patientId);
            filter.AddWithOr(AgendaEventMetaFields.Id.SetExpression(subExpression) == 0);
            filter.AddWithAnd(AgendaEventMetaFields.PatientId == patientId);

            var relations = new RelationCollection();
            relations.Add(AgendaEventMetaEntity.Relations.AgendaEventEntityUsingAgendaEventId);

            var agendaEventCollection = new AgendaEventCollection();
            agendaEventCollection.GetMulti(filter, 0, null, relations);

            return agendaEventCollection;
        }

        /// <summary>
        /// Returns a collection of agenda events.
        /// </summary>
        /// <param name="unixTimeStamp">Provide the unix timestamp for a specific date with time set on 00:00:00.</param>
        /// <param name="patientId">Provide the patients id.</param>
        /// <returns></returns>
        public static AgendaEventCollection GetAllEventsByDateAndPatientIdWithStoredProcedure(int unixTimeStamp, int patientId)
        {
            using (var dataSet = RetrievalProcedures.GetAllEventsByDateAndByPatientId(unixTimeStamp, patientId))
            {
                var collection = new AgendaEventCollection();

                for (int i = 0; i < dataSet.Rows.Count; i++)
                {
                    var entity = new AgendaEventEntity();

                    for (int j = 0; j < dataSet.Columns.Count; j++)
                    {
                        var value = dataSet.Rows[i][j].ToString();

                        switch (dataSet.Columns[j].ColumnName)
                        {
                            case "Id":
                                entity.Id = int.Parse(dataSet.Rows[i][j].ToString());
                                break;
                            case "Title":
                                entity.Title = dataSet.Rows[i][j].ToString();
                                break;
                            case "Location":
                                entity.Location = dataSet.Rows[i][j].ToString();
                                break;
                            case "TimeStart":
                                entity.TimeStart = int.Parse(dataSet.Rows[i][j].ToString());
                                break;
                            case "TimeEnd":
                                entity.TimeEnd = int.Parse(dataSet.Rows[i][j].ToString());
                                break;
                            case "Description":
                                entity.Description = dataSet.Rows[i][j].ToString();
                                break;
                            default:
                                throw new NotImplementedException("Column {0} has not been implemented."
                                    .FormatString(dataSet.Columns[j].ColumnName));
                        }
                    }

                    collection.Add(entity);
                }

                return collection;
            };
        }
    }
}