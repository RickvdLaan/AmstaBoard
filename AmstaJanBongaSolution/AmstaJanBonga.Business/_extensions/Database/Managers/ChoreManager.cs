using AmstaJanBonga.Business.CollectionClasses;
using AmstaJanBonga.Business.EntityClasses;
using AmstaJanBonga.Business.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public static void InsertMulti(params ChoreEntity[] chore)
        {
            var choreCollection = new ChoreCollection();
            choreCollection.AddRange(chore);

            choreCollection.SaveMulti();
        }
    }
}
