using AmstaJanBonga.Business.CollectionClasses;
using AmstaJanBonga.Business.EntityClasses;
using AmstaJanBonga.Business.Enums;
using System;

namespace AmstaJanBonga.Business.Database.Managers
{
    public abstract class LivingroomShiftEventManager
    {
        public static void UpdateShift(LivingRoomShiftEventEntity oldShift, LivingRoomShiftEventEntity newShift)
        {
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
            shifts.SaveMulti();
        }

        public static void UpdateMulti(LivingRoomShiftEventCollection originalCollection, LivingRoomShiftEventCollection newCollection)
        {
            var tracker = new LivingRoomShiftEventCollection();
            originalCollection.RemovedEntitiesTracker = tracker;

            originalCollection.RemovedEntitiesTracker.AddRange(originalCollection);
            originalCollection.AddRange(newCollection);

            originalCollection.RemovedEntitiesTracker.DeleteMulti();
            originalCollection.SaveMulti();
        }
    }
}
