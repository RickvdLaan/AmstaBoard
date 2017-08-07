using AmstaJanBonga.Business.Database.Readers;
using AmstaJanBonga.Business.Enums;
using AmstaJanBonga.Business.Security;
using Rlaan.Toolkit.Configuration;
using Rlaan.Toolkit.Extensions;
using Rlaan.Toolkit.Web;
using System;
using System.Threading;
using System.Web;
using System.Web.Routing;
using System.Web.Security;

namespace AmstaJanBonga.Admin
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
         
        }

        /// <summary>
        /// When the IIdentity is changed.
        /// </summary>
        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// When the IPrincipal is changed.
        /// </summary>
        protected void Application_OnPostAuthenticateRequest(object sender, EventArgs e)
        {
            if (Project.Environment.IsDevelopEnvironment)
                System.Diagnostics.Debug.WriteLine("Application_OnPostAuthenticateRequest entered.{0}{1}".FormatString(Environment.NewLine, HttpContext.Current.Request.Url));

            //////////////////////////////////////////////////////////////////////////////////////
            //    Returns true if any of the provided requests is found in the requested url    //
            //                                                                                  //
            //  1. Script Resource manager of the .NET pipeline                                 //
            //  2. Web Resource manager of the .NET pipeline                                    //
            //  3. Caching of files within the project.                                         //
            //  4. A channel between your Visual Studio IDE and any open browser.               //
            if (Helper.IgnoreAuthenticateRequest("ScriptResource.axd", "WebResource.axd", "build=", "__browserLink/requestData"))
                return;

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
                    Log.Object(user, "Admin: No RoleTypeEnum found by value {0}, it was either not implemented or does not exist and wasn't caught by the login screen.".FormatString(user.UserRole.RoleTypeEnum));
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

            /*
             * The MapPageRoute asks for the following parameters: "Route name", "new url name", "physical url".
            */

            // Route for the home page, no query strings available.
            routes.MapPageRoute("Login", "Login", "~/Content/Unsecure/Login/Login.aspx");

            // Route for the home page, no query strings available.
            routes.MapPageRoute("Dashboard", "Dashboard", "~/Content/Secure/Dashboard.aspx");

            // Route for the insufficient privileges page, no query strings available.
            routes.MapPageRoute("InsufficientPrivileges", "InsufficientPrivileges", "~/Content/Secure/InsufficientPrivileges/InsufficientPrivileges.aspx");
        }
    }
}