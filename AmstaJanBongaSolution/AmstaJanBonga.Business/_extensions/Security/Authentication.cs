﻿using AmstaJanBonga.Business.EntityClasses;
using System;
using System.Threading;
using System.Web;
using System.Web.Security;

namespace AmstaJanBonga.Business.Security
{
    /// <summary>
    /// Class which contains some addons for the security layer.
    /// </summary>
    public abstract class Authentication
    {
        #region Properties

        /// <summary>
        /// Determines whether the current user is authenticated.
        /// </summary>
        public static bool IsAuthenticated
        {
            get { return (AuthenticatedUser != null); }
        }

        #endregion

        #region Properties

        /// <summary>
        /// Returns the authenticated user or null.
        /// </summary>
        /// <returns></returns>
        public static UserEntity AuthenticatedUser
        {
            get
            {
                if (HttpContext.Current != null)
                {
                    if (HttpContext.Current.User is CustomPrincipal principle && principle.Identity is UserEntity)
                        return principle.Identity as UserEntity;
                }

                return null;
            }
        }

        #endregion

        #region Methods

        public static void AuthenticateActivity(string activity)
        {
            
        }

        #endregion

        /// <summary>
        /// Utility class for the security.
        /// </summary>
        public abstract class Utility
        {
            /// <summary>
            /// Signs out the current user and then returns them to the login page.
            /// </summary>
            public static void SignOut()
            {
                FormsAuthentication.SignOut();
                HttpContext.Current.Session.Abandon();
                HttpContext.Current.Session.Clear();

                // Redirects the user to the login page.
                HttpContext.Current.Response.Redirect("~/Login");
            }

            /// <summary>
            /// Authenticates the current user.
            /// </summary>
            /// <param name="user">Provide the user entity.</param>
            public static void AuthenticateUser(UserEntity user)
            {
                var principle = new CustomPrincipal(user);

                FormsAuthentication.SetAuthCookie(user.Id.ToString(), false);
                HttpContext.Current.User = principle;
                Thread.CurrentPrincipal = principle;
            }

            /// <summary>
            /// Authenticates the current user and updates the users last login.
            /// </summary>
            /// <param name="user">Provide the user entity.</param>
            /// <param name="updateLastLogin">Provide whether you want to update the last login.</param>
            public static void AuthenticateUser(UserEntity user, bool updateLastLogin)
            {
                AuthenticateUser(user);

                if (updateLastLogin)
                {
                    user.DateLastLogin = DateTime.Now;
                    user.Save();
                }
            }
        }
    }
}