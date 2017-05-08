using AmstaJanBonga.Business.CollectionClasses;
using AmstaJanBonga.Business.EntityClasses;
using AmstaJanBonga.Business.Enums;
using System;
using System.Collections.Generic;

namespace AmstaJanBonga.Business.Database.Managers
{
    public abstract class LivingroomShiftEventManager
    {
        public static void UpdateShift(LivingroomShiftEventEntity oldShift, LivingroomShiftEventEntity newShift)
        {
            if (oldShift == newShift || !newShift.IsNew)
                return;

            // This code has to be done this way.
            var shift = new LivingroomShiftEventEntity()
            {
                EmployeeId = newShift.EmployeeId,
                LivingroomId = newShift.LivingroomId,
                Date = newShift.Date,
                ShiftTypeEnum = newShift.ShiftTypeEnum,
                DateCreated = DateTime.Now
            }.Save();

            if (!oldShift.IsNew)
                oldShift.Delete();
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
        public static void InsertMulti(List<LivingroomShiftEventEntity> shifts)
        {
            var livingroomShiftEventCollection = new LivingroomShiftEventCollection();
            livingroomShiftEventCollection.AddRange(shifts);

            livingroomShiftEventCollection.SaveMulti();
        }

        /// <summary>
        /// Inserts multiple 
        /// </summary>
        /// <param name="shift"></param>
        public static void InsertMulti(params LivingroomShiftEventEntity[] shift)
        {
            var livingroomShiftEventCollection = new LivingroomShiftEventCollection();
            livingroomShiftEventCollection.AddRange(shift);

            livingroomShiftEventCollection.SaveMulti();
        }

        public static void UpdateMulti(LivingroomShiftEventCollection originalCollection, List<LivingroomShiftEventEntity> shifts)
        {
            // The new shift collection, could be identical to the existing originalCollection,
            // but could also be completely different.
            var newCollection = new LivingroomShiftEventCollection();
            newCollection.AddRange(shifts);

            var shiftsToDelete = new LivingroomShiftEventCollection();

            foreach (var shift in originalCollection)
            {
                // The shift doesn't exist in the new collection, thus should be removed.
                if (!newCollection.Contains(shift))
                {
                    shiftsToDelete.Add(shift);
                }
            }

            foreach (var shift in newCollection)
            {
                // There was a new shift added, thus it should be added.
                if (!originalCollection.Contains(shift))
                {
                    shift.Save();
                }
            }

            foreach (var shift in shiftsToDelete)
            {
                shift.Delete();
            }
        }
    }
}
