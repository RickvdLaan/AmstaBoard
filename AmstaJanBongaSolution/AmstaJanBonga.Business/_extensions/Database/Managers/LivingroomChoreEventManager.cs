using AmstaJanBonga.Business.CollectionClasses;
using AmstaJanBonga.Business.EntityClasses;
using AmstaJanBonga.Business.Enums;
using System;

namespace AmstaJanBonga.Business.Database.Managers
{
    public abstract class LivingroomChoreEventManager
    {
        public static void UpdateChore(LivingRoomChoreEventEntity oldChore, LivingRoomChoreEventEntity newChore)
        {
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
        /// Creates a LivingroomChoreEventEntity and returns it.
        /// </summary>
        /// <param name="patientId"></param>
        /// <param name="livingroomId"></param>
        /// <param name="date"></param>
        /// <param name="timeOfDay"></param>
        /// <returns></returns>
        public static LivingRoomChoreEventEntity CreateLivingroomChoreEventEntity(int patientId, int livingroomId, DateTime date, TimeOfDayTypeEnum timeOfDay)
        {
            var chore = new LivingRoomChoreEventEntity()
            {
                PatientId = patientId,
                LivingRoomId = livingroomId,
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
            chores.SaveMulti();
        }

        public static void UpdateMulti(LivingRoomChoreEventCollection originalCollection, LivingRoomChoreEventCollection newCollection)
        {
            var tracker = new LivingRoomChoreEventCollection();
            originalCollection.RemovedEntitiesTracker = tracker;

            originalCollection.RemovedEntitiesTracker.AddRange(originalCollection);
            originalCollection.AddRange(newCollection);

            originalCollection.RemovedEntitiesTracker.DeleteMulti();
            originalCollection.SaveMulti();
        }
    }
}
