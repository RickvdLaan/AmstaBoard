using AmstaJanBonga.Business.Database.Readers;
using AmstaJanBonga.Business.EntityClasses;
using AmstaJanBonga.Business.Security;
using Rlaan.Toolkit.Extensions;
using System;
using System.Web;

namespace AmstaJanBonga.Web
{
    /// <summary>
    /// Class with security rules for the web page.
    /// </summary>
    public abstract class SecurePage : DefaultPage
    {
        #region Variables & Objects

        private int _livingRoomId = -1;

        #endregion

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

        public int CurrentLivingRoomId
        {
            get
            {
                if (this._livingRoomId == -1)
                {
                    if (Request.Cookies["LivingRoomId"] == null)
                    {
                        var livingRoomId = EmployeeReader.GetEmployeeByUserId(Authentication.AuthenticatedUser.Id, true).LivingRoomId;

                        // Creates a cookie which has an expire time of the current session..
                        var cookie = new HttpCookie("LivingRoomId")
                        {
                            Value = livingRoomId.ToString(),
                            Expires = DateTime.MinValue
                        };

                        Response.Cookies.Add(cookie);

                        this._livingRoomId = livingRoomId;
                    }
                    else
                    {
                        this._livingRoomId = Request.Cookies["LivingRoomId"].Value.ToInt();
                    }
                }

                return this._livingRoomId;
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