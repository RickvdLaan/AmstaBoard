using AmstaJanBonga.Business.Security;
using System;

namespace AmstaJanBonga.Business.EntityClasses
{
    public partial class LivingRoomChoreEventEntity
    {
        #region Properties

        public override bool Equals(object obj)
        {
            if (this.PatientId == (obj as LivingRoomChoreEventEntity).PatientId &&
                this.LivingRoomId == (obj as LivingRoomChoreEventEntity).LivingRoomId &&
                this.Date == (obj as LivingRoomChoreEventEntity).Date &&
                this.TimeOfDayTypeEnum == (obj as LivingRoomChoreEventEntity).TimeOfDayTypeEnum)
            {
                return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #endregion

        #region Overrides

        protected override void OnSave()
        {
            if (this.IsDirty && Authentication.IsAuthenticated)
            {
                this.DateLastModifiedByUserId = Authentication.AuthenticatedUser.Id;
                this.DateLastModified = DateTime.Now;
            }

            base.OnSave();
        }

        #endregion
    }
}
