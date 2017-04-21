using AmstaJanBonga.Business.CollectionClasses;
using AmstaJanBonga.Business.EntityClasses;
using AmstaJanBonga.Business.Enums;
using System;
using System.Collections.Generic;

namespace AmstaJanBonga.Business.Database.Managers
{
    public abstract class ChoreManager
    {
        /// <summary>
        /// Creates a ChoreEntity and returns it.
        /// </summary>
        /// <param name="patientId"></param>
        /// <param name="livingroomId"></param>
        /// <param name="date"></param>
        /// <param name="timeOfDay"></param>
        /// <returns></returns>
        public static ChoreEntity CreateChoreEntity(int patientId, int livingroomId, DateTime date, TimeOfDayTypeEnum timeOfDay)
        {
            var chore = new ChoreEntity()
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
        public static void InsertMulti(List<ChoreEntity> chores)
        {
            var choreCollection = new ChoreCollection();
            choreCollection.AddRange(chores);

            choreCollection.SaveMulti();
        }

        /// <summary>
        /// Inserts multiple 
        /// </summary>
        /// <param name="chore"></param>
        public static void InsertMulti(params ChoreEntity[] chore)
        {
            var choreCollection = new ChoreCollection();
            choreCollection.AddRange(chore);

            choreCollection.SaveMulti();
        }

        public static void UpdateMulti(ChoreCollection originalCollection, List<ChoreEntity> chores)
        {
            // The new chore collection, could be identical to the existing originalCollection,
            // but could also be completely different.
            var newCollection = new ChoreCollection();
            newCollection.AddRange(chores);

            var choresToDelete = new ChoreCollection();

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

            // @Fix-me: Temp code, needs to be done properly!
            //originalCollection.DeleteMulti();
            //newCollection.SaveMulti();
        }

        public static void UpdateMulti(params ChoreEntity[] chore)
        {
            throw new NotImplementedException();
        }
    }
}
