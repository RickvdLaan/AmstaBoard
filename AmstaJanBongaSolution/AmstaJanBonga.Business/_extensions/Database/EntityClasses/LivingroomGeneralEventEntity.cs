using AmstaJanBonga.Business.Security;
using System;

namespace AmstaJanBonga.Business.EntityClasses
{
    public partial class LivingroomGeneralEventEntity
    {

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