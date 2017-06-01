using AmstaJanBonga.Business.CollectionClasses;
using AmstaJanBonga.Business.EntityClasses;
using AmstaJanBonga.Business.StoredProcedureCallerClasses;
using Rlaan.Toolkit.Extensions;
using System;
using System.Collections.Generic;

namespace AmstaJanBonga.Business.Database.Readers
{
    public abstract class AgendaEventReader
    {
        public static List<List<AgendaEventCollection>> GetAllEventsForWeekByPatientId(int patientId)
        {
            //get unix times of monday & sunday of the current bweek based on the current day.



            return null;
        }

        public static AgendaEventCollection GetAllEventsForTodayByPatientId(int patientId)
        {
            // Hopefully temp code, need to figure out a way to create this where clause:
            // WHERE  (( @Unix - RepeatStart) % RepeatInterval = 0 ) AND AEM.PatientId = @PatientId;
            // with the low level api of llblgen, but for now it'll be done through a
            // stored procedure. 

            using (var dataSet = RetrievalProcedures.GetAllEventsForTodayByPatientId(Time.UnixTime.Today, patientId))
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