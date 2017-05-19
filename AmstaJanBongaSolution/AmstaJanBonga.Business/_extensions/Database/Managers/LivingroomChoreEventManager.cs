using AmstaJanBonga.Business.CollectionClasses;
using AmstaJanBonga.Business.EntityClasses;
using AmstaJanBonga.Business.Enums;
using AmstaJanBonga.Business.Security;
using System;

namespace AmstaJanBonga.Business.Database.Managers
{
    public abstract class LivingRoomChoreEventManager
    {
        public static void UpdateChore(LivingRoomChoreEventEntity oldChore, LivingRoomChoreEventEntity newChore)
        {
            Authentication.AuthenticateActivity("UpdateLivingRoomChoreEvent");

            if (oldChore.PatientId         == newChore.PatientId         &&
                oldChore.LivingRoomId      == newChore.LivingRoomId      &&
                oldChore.TimeOfDayTypeEnum == newChore.TimeOfDayTypeEnum &&
                oldChore.Date              == newChore.Date              ||
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
            Authentication.AuthenticateActivity("CreateLivingRoomChoreEvent");

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
        /// Inserts multiple 
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

            foreach (var item in originalCollection.RemovedEntitiesTracker)
            {
                (item as LivingRoomChoreEventEntity).Delete();
            }

            newCollection.SaveMulti();
        }
    }
}
