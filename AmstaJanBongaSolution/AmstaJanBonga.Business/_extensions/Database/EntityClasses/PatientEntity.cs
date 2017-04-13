using AmstaJanBonga.Business.Security;
using System;

namespace AmstaJanBonga.Business.EntityClasses
{
    public partial class PatientEntity
    {
        #region Properties

        /// <summary>
        /// Gets the ToString() varient of the bool IsActive, translated in Dutch.
        /// </summary>
        public string IsActiveToString
        {
            get { return ((IsActive == true) ? "Ja" : "Nee"); }
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
