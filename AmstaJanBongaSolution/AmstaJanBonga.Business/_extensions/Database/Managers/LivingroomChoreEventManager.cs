using AmstaJanBonga.Business.CollectionClasses;
using AmstaJanBonga.Business.EntityClasses;
using AmstaJanBonga.Business.Enums;
using System;
using System.Collections.Generic;

namespace AmstaJanBonga.Business.Database.Managers
{
    public abstract class LivingroomChoreEventManager
    {
        public static void UpdateChore(LivingroomChoreEventEntity oldChore, LivingroomChoreEventEntity newChore)
        {
            if (oldChore == newChore || !newChore.IsNew)
                return;

            // This code has to be done this way.
            var chore = new LivingroomChoreEventEntity()
            {
                PatientId = newChore.PatientId,
                LivingroomId = newChore.LivingroomId,
                Date = newChore.Date,
                TimeOfDayTypeEnum = newChore.TimeOfDayTypeEnum,
                DateCreated = DateTime.Now
            }.Save();

            if (!oldChore.IsNew)
                oldChore.Delete();
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
        public static void InsertMulti(List<LivingroomChoreEventEntity> chores)
        {
            var LivingroomChoreEventCollection = new LivingroomChoreEventCollection();
            LivingroomChoreEventCollection.AddRange(chores);

            LivingroomChoreEventCollection.SaveMulti();
        }

        /// <summary>
        /// Inserts multiple 
        /// </summary>
        /// <param name="chore"></param>
        public static void InsertMulti(params LivingroomChoreEventEntity[] chore)
        {
            var LivingroomChoreEventCollection = new LivingroomChoreEventCollection();
            LivingroomChoreEventCollection.AddRange(chore);

            LivingroomChoreEventCollection.SaveMulti();
        }

        public static void UpdateMulti(LivingroomChoreEventCollection originalCollection, List<LivingroomChoreEventEntity> chores)
        {
            // The new chore collection, could be identical to the existing originalCollection,
            // but could also be completely different.
            var newCollection = new LivingroomChoreEventCollection();
            newCollection.AddRange(chores);

            var choresToDelete = new LivingroomChoreEventCollection();

            foreach (var chore in originalCollection)
            {
                // The chore doesn't exist in the new collection, thus should be removed.
                if (!newCollection.Contains(chore))
                {
                    choresToDelete.Add(chore);
                }
            }

            foreach (var chore in newCollection)
            {
                // There was a new chore added, thus it should be added.
                if (!originalCollection.Contains(chore))
                {
                    chore.Save();
                }
            }

            foreach (var chore in choresToDelete)
            {
                chore.Delete();
            }
        }
    }
}
