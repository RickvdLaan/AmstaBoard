using AmstaJanBonga.Business.Security;
using System;

namespace AmstaJanBonga.Business.EntityClasses
{
    public partial class EmployeeEntity
    {
        public void DeleteUserFromEmployee()
        {
            this.UserId = null;
            this.Save();
        }

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
