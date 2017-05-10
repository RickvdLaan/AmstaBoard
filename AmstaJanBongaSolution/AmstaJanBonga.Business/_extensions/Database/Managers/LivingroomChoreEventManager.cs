using AmstaJanBonga.Business.CollectionClasses;
using AmstaJanBonga.Business.EntityClasses;
using AmstaJanBonga.Business.Enums;
using System;

namespace AmstaJanBonga.Business.Database.Managers
{
    public abstract class LivingroomChoreEventManager
    {
        public static void UpdateChore(LivingroomChoreEventEntity oldChore, LivingroomChoreEventEntity newChore)
        {
            if (oldChore.PatientId         == newChore.PatientId         &&
                oldChore.LivingroomId      == newChore.LivingroomId      &&
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
        public static LivingroomChoreEventEntity CreateLivingroomChoreEventEntity(int patientId, int livingroomId, DateTime date, TimeOfDayTypeEnum timeOfDay)
        {
            var chore = new LivingroomChoreEventEntity()
            {
                PatientId = patientId,
                LivingroomId = livingroomId,
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
        public static void InsertMulti(LivingroomChoreEventCollection chores)
        {
            chores.SaveMulti();
        }

        public static void UpdateMulti(LivingroomChoreEventCollection originalCollection, LivingroomChoreEventCollection newCollection)
        {
            var tracker = new LivingroomChoreEventCollection();
            originalCollection.RemovedEntitiesTracker = tracker;

            originalCollection.RemovedEntitiesTracker.AddRange(originalCollection);
            originalCollection.AddRange(newCollection);

            originalCollection.RemovedEntitiesTracker.DeleteMulti();
            originalCollection.SaveMulti();
        }
    }
}
