using AmstaJanBonga.Business.CollectionClasses;
using AmstaJanBonga.Business.EntityClasses;
using AmstaJanBonga.Business.Enums;
using System;

namespace AmstaJanBonga.Business.Database.Managers
{
    public abstract class LivingroomShiftEventManager
    {
        public static void UpdateShift(LivingroomShiftEventEntity oldShift, LivingroomShiftEventEntity newShift)
        {
            if  (oldShift.EmployeeId    == newShift.EmployeeId   &&
                oldShift.LivingroomId  == newShift.LivingroomId  &&
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
        public static LivingroomShiftEventEntity CreateLivingroomShiftEventEntity(int employeeId, int livingroomId, DateTime date, ShiftTypeEnum shiftType)
        {
            var shift = new LivingroomShiftEventEntity()
            {
                EmployeeId = employeeId,
                LivingroomId = livingroomId,
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
        public static void InsertMulti(LivingroomShiftEventCollection shifts)
        {
            shifts.SaveMulti();
        }

        public static void UpdateMulti(LivingroomShiftEventCollection originalCollection, LivingroomShiftEventCollection newCollection)
        {
            var tracker = new LivingroomShiftEventCollection();
            originalCollection.RemovedEntitiesTracker = tracker;

            originalCollection.RemovedEntitiesTracker.AddRange(originalCollection);
            originalCollection.AddRange(newCollection);

            originalCollection.RemovedEntitiesTracker.DeleteMulti();
            originalCollection.SaveMulti();
        }
    }
}
