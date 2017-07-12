using AmstaJanBonga.Business.CollectionClasses;
using AmstaJanBonga.Business.EntityClasses;
using AmstaJanBonga.Business.Enums;
using AmstaJanBonga.Business.HelperClasses;
using AmstaJanBonga.Business.Security;
using SD.LLBLGen.Pro.ORMSupportClasses;
using System;

namespace AmstaJanBonga.Business.Database.Managers
{
    public abstract class LivingRoomChoreEventManager
    {
        public static void UpdateChore(LivingRoomChoreEventEntity oldChore, LivingRoomChoreEventEntity newChore)
        {
            Authentication.AuthenticateActivity("UpdateLivingRoomChoreEvent");

            if (oldChore.PatientId == newChore.PatientId &&
                oldChore.LivingRoomId == newChore.LivingRoomId &&
                oldChore.TimeOfDayTypeEnum == newChore.TimeOfDayTypeEnum &&
                oldChore.Date == newChore.Date ||
                !newChore.IsNew)
            {
                return;
            }

            if (!oldChore.IsNew)
                oldChore.Delete();

            newChore.Save();
        }

        /// <summary>
        /// Creates a LivingRoomChoreEventEntity and returns it.
        /// </summary>
        /// <param name="patientId"></param>
        /// <param name="livingRoomId"></param>
        /// <param name="date"></param>
        /// <param name="timeOfDay"></param>
        /// <returns></returns>
        public static LivingRoomChoreEventEntity CreateLivingRoomChoreEventEntity(int patientId, int livingRoomId, DateTime date, TimeOfDayTypeEnum timeOfDay)
        {
            // Doesn't require a permission because it only creates an entity.

            var chore = new LivingRoomChoreEventEntity()
            {
                PatientId = patientId,
                LivingRoomId = livingRoomId,
                Date = date,
                TimeOfDayTypeEnum = (byte)timeOfDay,
                DateCreated = DateTime.Now
            };

            return chore;
        }

        /// <summary>
        /// Inserts multiple chores.
        /// </summary>
        /// <param name="chore"></param>
        public static void InsertMulti(LivingRoomChoreEventCollection chores)
        {
            Authentication.AuthenticateActivity("CreateLivingRoomChoreEvent");

            chores.SaveMulti();
        }

        public static void UpdateMulti(LivingRoomChoreEventCollection originalCollection, LivingRoomChoreEventCollection newCollection)
        {
            Authentication.AuthenticateActivity("UpdateLivingRoomChoreEvent");

            var tracker = new LivingRoomChoreEventCollection();
            originalCollection.RemovedEntitiesTracker = tracker;

            originalCollection.RemovedEntitiesTracker.AddRange(originalCollection);
            originalCollection.AddRange(newCollection);

            // @bug: for some reason DeleteMulti doesn't work here? It does work everywhere else,
            // but can't find a difference anywhere in how the data is being used.
            // single deletes do work, maybe this is enough for the future?
            foreach (var chore in originalCollection.RemovedEntitiesTracker)
            {
                (chore as LivingRoomChoreEventEntity).Delete();
            }

            originalCollection.SaveMulti();
        }


        public static void DeleteLivingRoomChoreEvent(int livingRoomId, DateTime date)
        {
            Authentication.AuthenticateActivity("DeleteLivingRoomChoreEvent");

            var livingRoomChoreEvent = new LivingRoomChoreEventCollection();

            var filter = new PredicateExpression
            {
                LivingRoomChoreEventFields.LivingRoomId == livingRoomId
            };

            filter.AddWithAnd(LivingRoomChoreEventFields.Date == date.Date);

            livingRoomChoreEvent.DeleteMulti(filter);
        }
    }
}
