using AmstaJanBonga.Business.CollectionClasses;
using AmstaJanBonga.Business.EntityClasses;
using AmstaJanBonga.Business.Enums;
using AmstaJanBonga.Business.Security;
using System;

namespace AmstaJanBonga.Business.Database.Managers
{
    public abstract class LivingRoomShiftEventManager
    {
        public static void UpdateShift(LivingRoomShiftEventEntity oldShift, LivingRoomShiftEventEntity newShift)
        {
            Authentication.AuthenticateActivity("UpdateLivingRoomShiftEvent");

            if  (oldShift.EmployeeId    == newShift.EmployeeId   &&
                oldShift.LivingRoomId  == newShift.LivingRoomId  &&
                oldShift.ShiftTypeEnum == newShift.ShiftTypeEnum &&
                oldShift.Date          == newShift.Date          ||
                !newShift.IsNew)
            {
                return;
            }

            if (!oldShift.IsNew)
                oldShift.Delete();

            newShift.Save();
        }

        /// <summary>
        /// Creates a LivingroomShiftEventEntity and returns it.
        /// </summary>
        /// <param name="employeeId"></param>
        /// <param name="livingroomId"></param>
        /// <param name="date"></param>
        /// <param name="shiftType"></param>
        /// <returns></returns>
        public static LivingRoomShiftEventEntity CreateLivingroomShiftEventEntity(int employeeId, int livingroomId, DateTime date, ShiftTypeEnum shiftType)
        {
            // Doesn't require a permission because it only creates an entity.

            var shift = new LivingRoomShiftEventEntity()
            {
                EmployeeId = employeeId,
                LivingRoomId = livingroomId,
                Date = date,
                ShiftTypeEnum = (byte)shiftType,
                DateCreated = DateTime.Now
            };

            return shift;
        }

        /// <summary>
        /// Inserts multiple 
        /// </summary>
        /// <param name="shifts"></param>
        public static void InsertMulti(LivingRoomShiftEventCollection shifts)
        {
            Authentication.AuthenticateActivity("CreateLivingRoomShiftEvent");

            shifts.SaveMulti();
        }

        public static void UpdateMulti(LivingRoomShiftEventCollection originalCollection, LivingRoomShiftEventCollection newCollection)
        {
            Authentication.AuthenticateActivity("UpdateLivingRoomShiftEvent");

            var tracker = new LivingRoomShiftEventCollection();
            originalCollection.RemovedEntitiesTracker = tracker;

            originalCollection.RemovedEntitiesTracker.AddRange(originalCollection);
            originalCollection.AddRange(newCollection);

            foreach (var item in originalCollection.RemovedEntitiesTracker)
            {
                (item as LivingRoomShiftEventEntity).Delete();
            }

            newCollection.SaveMulti();
        }
    }
}
