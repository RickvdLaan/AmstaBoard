﻿using AmstaJanBonga.Business.Database.EntityClasses;
using System.Security.Principal;

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
            return this.Password.Equals(SHA512.HashValue(password, this.Salt));
        }

        #endregion

        #region Overrides

        protected override void OnSave()
        {
            if (this.IsDirty && Authentication.IsAuthenticated)
            {
                this.DateLastModified = DateTime.Now;
            }

            base.OnSave();
        }

        #endregion
    }
}