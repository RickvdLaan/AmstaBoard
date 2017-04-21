using AmstaJanBonga.Business.Security;
using System;

namespace AmstaJanBonga.Business.EntityClasses
{
    public partial class ChoreEntity
    {
        #region Properties

        public override bool Equals(object obj)
        {
            if (this.PatientId == (obj as ChoreEntity).PatientId &&
                this.LivingroomId == (obj as ChoreEntity).LivingroomId &&
                this.Date == (obj as ChoreEntity).Date &&
                this.TimeOfDayTypeEnum == (obj as ChoreEntity).TimeOfDayTypeEnum)
            {
                return true;
            }

            return false;
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
