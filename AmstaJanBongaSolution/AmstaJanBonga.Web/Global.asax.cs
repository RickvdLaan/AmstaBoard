using AmstaJanBonga.Business.Database.Readers;
using AmstaJanBonga.Business.Enums;
using AmstaJanBonga.Business.Security;
using Rlaan.Toolkit.Configuration;
using Rlaan.Toolkit.Extensions;
using Rlaan.Toolkit.Web;
using System;
using System.Diagnostics;
using System.Threading;
using System.Web;
using System.Web.Routing;
using System.Web.Security;

namespace AmstaJanBonga.Web
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            InitialiseRoutes(RouteTable.Routes);
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            // Checking whether the environment is live or staging.
            if (Project.Environment.IsLiveEnvironment || Project.Environment.IsStagingEnvironment)
            {
                if (!IpReader.IsIpAllowed(NetworkInformation.GetUsersIPAddress()))
                {
                    if (Authentication.IsAuthenticated)
                        Authentication.Utility.SignOut();
                }
            }
        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// When the IPrincipal is changed.
        /// </summary>
        protected void Application_OnPostAuthenticateRequest(object sender, EventArgs e)
        {
            Debug.WriteLine("Application_OnPostAuthenticateRequest entered.");

            // Gets the security information for the current HTTP request, returns an IPrincipal.
            var principal = HttpContext.Current.User;

            // We check if the current user is authenticated and if the authentication type is correct.
            if (principal.Identity.IsAuthenticated && principal.Identity.AuthenticationType == "Forms")
            {
                // Everything is going good so far, since we're using form authentification we're going to cast the principal to a FormsIdentity.
                var formIdentity = principal.Identity as FormsIdentity;

                // We extract the unique user id from the forms identity (already decrypted) to get the current user.
                var user = UserReader.GetUserById(int.Parse(formIdentity.Name));

                // We check if the user exists and if the user does exist we check if it has the appropriate roles.
                if (user != null && UserReader.IsUserInRole(user,
                    RoleTypeEnum.Employee,
                    RoleTypeEnum.Manager,
                    RoleTypeEnum.Root,
                    RoleTypeEnum.Trainee))
                {
                    // User passed all checks, we can re-authenticate the current user.
                    Authentication.Utility.AuthenticateUser(user);

                    // Sets the forms-authentication user identity ticket.
                    user.AuthenticationTicket = formIdentity.Ticket;

                    // Initializes the custom principal class.
                    var principle = new CustomPrincipal(user);

                    // Re-sets the security information.
                    HttpContext.Current.User = principle;
                    Thread.CurrentPrincipal = principle;
                }
                else
                {
                    // User is not allowed to log in, and it was missed in the login screen.
                    if (Authentication.IsAuthenticated)
                        Authentication.Utility.SignOut();

                    // Logging the event to the developer.
                    Log.Object(user, "Web: No RoleTypeEnum found by value {0}, it was either not implemented or does not exist and wasn't caught by the login screen.".FormatString(user.UserRole.RoleTypeEnum));
                }
            }
        }

        protected void Application_Error(object sender, EventArgs e)
        {
            if (Project.Environment.IsLiveEnvironment)
            {
                try
                {
                    Log.Exception(Server.GetLastError());

                    Server.ClearError();
                }
                catch { }
            }
        }

        protected void Session_End(object sender, EventArgs e)
        {
            if (Project.Environment.IsLiveEnvironment)
            {
                Authentication.Utility.SignOut();
                Response.Redirect(FormsAuthentication.LoginUrl);
            }
        }

        protected void Application_End(object sender, EventArgs e)
        {
            if (Project.Environment.IsLiveEnvironment)
            {
                // 1. IIS (re)started, 2. Web.Config got modified, 3. Application (re)started.
                if (Authentication.IsAuthenticated)
                {
                    Authentication.Utility.SignOut();
                    Response.Redirect(FormsAuthentication.LoginUrl);
                }
            }
        }

        /// <summary>
        /// Initialises the routes.
        /// </summary>
        /// <param name="routes">Provide an empty collection of routes.</param>
        private void InitialiseRoutes(RouteCollection routes)
        {
            routes.Ignore("Images/");
            routes.Ignore("Includes/");
            routes.Ignore("Controls/");
            routes.Ignore("Utilities/");
            routes.Ignore("MasterPage/");
            routes.Ignore("Service Reference/");
            routes.Ignore("App_GlobalResources/");

            routes.MapPageRoute("Login", "Login", "~/Content/Unsecure/Login/Login.aspx");
            routes.MapPageRoute("Livingroom", "Livingroom", "~/Content/Secure/Livingroom/Livingroom.aspx");
            routes.MapPageRoute("Erro500", "Error500", "~/Content/Unsecure/Error/Error500.aspx");
            routes.MapPageRoute("Erro404", "Error404", "~/Content/Unsecure/Error/Error404.aspx");
            routes.MapPageRoute("Updating", "Updating", "~/Content/Unsecure/Updating/Updating.aspx");
        }
    }
}