using AmstaJanBonga.Business.CollectionClasses;
using AmstaJanBonga.Business.DaoClasses;
using AmstaJanBonga.Business.EntityClasses;
using AmstaJanBonga.Business.FactoryClasses;
using AmstaJanBonga.Business.HelperClasses;
using Rlaan.Toolkit.Configuration;
using Rlaan.Toolkit.Extensions;
using SD.LLBLGen.Pro.ORMSupportClasses;
using SD.LLBLGen.Pro.QuerySpec;
using SD.LLBLGen.Pro.QuerySpec.SelfServicing;
using System;
using System.Collections.Generic;
using System.Data;

namespace AmstaJanBonga.Business.Database.Readers
{
    /*
     * Query examples
     * 
        SELECT AE.*
        FROM AgendaEvent AE
        RIGHT JOIN AgendaEventMeta AEM ON AEM.AgendaEventId = AE.Id
        WHERE  (( 1496188800 - RepeatStart) % RepeatInterval = 0 ) AND AEM.PatientId = 16;

        // 1496188800 = Helper.UnixTime.Today
        // 16         = patientId
     * 
     */

    public abstract class AgendaEventMetaReader
    {
        public static AgendaEventCollection GetAllEventsForTodayByPatientId(int patientId)
        {
            //var collection = new AgendaEventMetaCollection();

            //var firstExpression = new Expression(Helper.UnixTime.Today, ExOp.Sub, AgendaEventMetaFields.RepeatStart);
            //var secondExpression = new Expression(firstExpression, ExOp.Mod, AgendaEventMetaFields.RepeatInterval);
            //var thirdExpression = new Expression(secondExpression, ExOp.Equal, 0);

            //var filter = new PredicateExpression((IPredicate)thirdExpression);
            //filter.Add()
            //collection.GetMulti();

            //return collection;

            //var qf = new QueryFactory();
            //var q = qf.Create()
            //    .Select()
            //    .From(qf.AgendaEventMeta
            //        .RightJoin(qf.AgendaEvent)
            //            .On(AgendaEventMetaFields.AgendaEventId == AgendaEventFields.Id))
            //    .Where((IPredicate)thirdExpression)
            //    .AndWhere(AgendaEventMetaFields.PatientId == patientId);

            var agendaEventCollection = new AgendaEventCollection();

            var filter = new PredicateExpression();
            filter.Add(AgendaEventMetaFields.PatientId == patientId);

            var relations = new RelationCollection();
            relations.Add(AgendaEventEntity.Relations.AgendaEventMetaEntityUsingAgendaEventId);

            if (Project.Environment.IsStagingEnvironment || Project.Environment.IsLiveEnvironment)
                throw new NotImplementedException();

            agendaEventCollection.GetMulti(filter, 0, null, relations);

            return agendaEventCollection;
        }

        public AgendaEventMetaCollection GetAllEventsByDateAndPatientId(int unixTime, int patientId)
        { 
            return null;
        }
    }
}
