using AmstaJanBonga.Business.EntityClasses;
using AmstaJanBonga.Business.Security;
using System;

namespace AmstaJanBonga.Admin
{
    /// <summary>
    /// Class with security rules for the web page.
    /// </summary>
    public abstract class SecurePage : DefaultPage
    {
        #region Properties

        /// <summary>
        /// Provides the user entity of the current logged in user.
        /// </summary>
        public UserEntity CurrentUser
        {
            get
            {
                if (Authentication.IsAuthenticated)
                    return Authentication.AuthenticatedUser;

                // Should only be able to occur during development stages.
                throw new SecurityException("Seems like nobody is logged on, the SecurePage utility might be used incorrectly.");
            }
        }

        #endregion

        #region Overrides

        protected override void OnInit(EventArgs e)
        {
            PerformSecurityCheck();

            base.OnInit(e);
        }

        #endregion

        #region Security

        /// <summary>
        /// Checks if the current user is authenticated.
        /// </summary>
        private void PerformSecurityCheck()
        {
            // The property either returns the authenticated user or throws a SecurityException, so calling the property is enough.
            var currentUser = this.CurrentUser;
        }

        #endregion
    }
}