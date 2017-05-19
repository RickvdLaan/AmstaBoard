using AmstaJanBonga.Business.EntityClasses;
using Rlaan.Toolkit.Configuration;
using Rlaan.Toolkit.Extensions;
using Rlaan.Toolkit.Web;
using System;
using System.Security;
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

        /// <summary>
        /// Validates whether the AuthenticatedUser has enough privileges to access the provided activity.
        /// </summary>
        /// <param name="activity"></param>
        public static void AuthenticateActivity(string activity)
        {
            // Validating whether the provided activity isn't null. empty or consists only of white-space characters.
            if (string.IsNullOrWhiteSpace(activity))
                throw new InvalidOperationException("Provided activity is empty.");

            // Validating whether the current user is authenticated.
            if (IsAuthenticated)
            {
                foreach (var roleActivity in AuthenticatedUser.UserRole.UserRoleActivities)
                {
                    // Checking whether the current user is allowed to access the provided activity.
                    if (roleActivity.UserActivityName == activity)
                        return;
                }

                // User doesn't have the right privileges. 
                HttpContext.Current.Response.Redirect("~/InsufficientPrivileges");
            }
            // The user is not logged in, redirecting!
            else
            {
                // Logging the current event for investigation.
                if (Project.Environment.IsStagingEnvironment || Project.Environment.IsLiveEnvironment)
                    Log.Object(AuthenticatedUser, "The AuthenticatedUser wasn't logged in on the AuthenticateActivity check.");

                // Redirecting to the login page.
                HttpContext.Current.Response.Redirect(FormsAuthentication.LoginUrl);
            }
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
                HttpContext.Current.Response.Redirect(FormsAuthentication.LoginUrl);
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