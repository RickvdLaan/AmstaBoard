using AmstaJanBonga.Business.Security;
using System;
using System.Security.Principal;
using System.Web.Security;

namespace AmstaJanBonga.Business.EntityClasses
{
    public partial class UserEntity : IIdentity
    {
        #region Security

        private FormsAuthenticationTicket _authenticationTicket;

        public FormsAuthenticationTicket AuthenticationTicket
        {
            get { return this._authenticationTicket; }
            set { this._authenticationTicket = value; }
        }

        public string AuthenticationType
        {
            get { return "Forms"; }
        }

        public bool IsAuthenticated
        {
            get { return this._authenticationTicket != null; }
        }

        public string Name
        {
            get { return this._authenticationTicket != null ? this._authenticationTicket.Name : string.Empty; }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Determines whether the given password (plain text) equals the stored database password for the current user.
        /// </summary>
        /// <param name="password">Provide the plain text password.</param>
        /// <returns></returns>
        public bool IsValidPassword(string password)
        {
            return PasswordHash.ValidatePassword(password, this.Salt, this.Password, this.Iterations);
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
