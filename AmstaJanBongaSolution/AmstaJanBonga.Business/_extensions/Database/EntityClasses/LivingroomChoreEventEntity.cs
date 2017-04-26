using AmstaJanBonga.Business.Security;
using System;

namespace AmstaJanBonga.Business.EntityClasses
{
    public partial class LivingroomChoreEventEntity
    {
        #region Properties

        public override bool Equals(object obj)
        {
            if (this.PatientId == (obj as LivingroomChoreEventEntity).PatientId &&
                this.LivingroomId == (obj as LivingroomChoreEventEntity).LivingroomId &&
                this.Date == (obj as LivingroomChoreEventEntity).Date &&
                this.TimeOfDayTypeEnum == (obj as LivingroomChoreEventEntity).TimeOfDayTypeEnum)
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
