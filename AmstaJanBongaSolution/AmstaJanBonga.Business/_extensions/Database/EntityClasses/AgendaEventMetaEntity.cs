using System;
using System.Collections.Generic;
using AmstaJanBonga.Business.Security;

namespace AmstaJanBonga.Business.EntityClasses
{
    public partial class AgendaEventMetaEntity
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
