﻿using AmstaJanBonga.Business.Database.Readers;
using AmstaJanBonga.Business.Enums;
using AmstaJanBonga.Business.Security;

using Rlaan.Toolkit.Configuration;
using Rlaan.Toolkit.Extensions;
using Rlaan.Toolkit.Web;

using System;
using System.Data.SqlClient;
using System.Linq;
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
                // Checking if the the users IP address is allowed.
                if (!IpReader.GetAllIps().Any(ip => Helper.IsIpInRangeOrEqualTo(ip.Ipaddress, Helper.GetUserIPAddress())))
                {
                    if (Authentication.IsAuthenticated)
                        Authentication.Utility.SignOut();

                    // Redirect to the access denied page of the main domain.
                    Response.Redirect("https://www.jouwsoftware.nl/access_denied/index.html", false);
                }
            }
        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// When the IPrincipal is changed or a new PostBack is requested.
        /// </summary>
        protected void Application_OnPostAuthenticateRequest(object sender, EventArgs e)
        {
            if (Project.Environment.IsDevelopEnvironment)
                System.Diagnostics.Debug.WriteLine("Application_OnPostAuthenticateRequest entered.{0}{1}".FormatString(Environment.NewLine, HttpContext.Current.Request.Url));

            //////////////////////////////////////////////////////////////////////////////////////
            //    Returns true if any of the provided requests are found in the requested url   //
            //                                                                                  //
            //  1. Script Resource manager of the .NET pipeline                                 //
            //  2. Web Resource manager of the .NET pipeline                                    //
            //  3. Caching of files within the project.                                         //
            //  4. ErrorNetwork is called when a transport-level error has occurred when        //
            //     receiving results from the server. For this reason there shouldn't be done   //
            //     any authentication checks since it requires a valid connection.              //
            //     Note: No useful information can be received on this page.                    //
            //  5. A channel between your Visual Studio IDE and any open browser.               //
            if (Helper.IgnoreAuthenticateRequest("ScriptResource.axd", "WebResource.axd", "build=", "ErrorNetwork", "__browserLink/requestData"))
                return;

            // Gets the security information for the current HTTP request, returns an IPrincipal.
            var principal = HttpContext.Current.User;

            // We check if the current user is authenticated and if the authentication type is correct.
            if (principal.Identity.IsAuthenticated && principal.Identity.AuthenticationType == "Forms")
            {
                // Everything is going good so far, since we're using form authentification we're going to cast the principal to a FormsIdentity.
                var formIdentity = principal.Identity as FormsIdentity;

                // We extract the unique user id from the forms identity (already decrypted) to get the current user.
                var user = UserReader.GetUserByIdFromEmployee(int.Parse(formIdentity.Name), false);

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
                    // User is not allowed to log in (anymore), or something weird and unknown happened.
                    if (Authentication.IsAuthenticated)
                        Authentication.Utility.SignOut();
                }
            }
        }

        protected void Application_Error(object sender, EventArgs e)
        {
            if (Project.Environment.IsLiveEnvironment)
            {
                try
                {
                    if ((Server.GetLastError() is SqlException))
                    {
                        // Transport-level error occured, the specified network name is no longer available. 
                        if ((Server.GetLastError() as SqlException).Number == 64)
                            Response.Redirect("ErrorNetwork");
                    }
                    else
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
            routes.MapPageRoute("LivingRoom", "LivingRoom", "~/Content/Secure/LivingRoom/LivingRoom.aspx");
            routes.MapPageRoute("Erro500", "Error500", "~/Content/Unsecure/Error/Error500.aspx");
            routes.MapPageRoute("Erro404", "Error404", "~/Content/Unsecure/Error/Error404.aspx");
            routes.MapPageRoute("Updating", "Updating", "~/Content/Unsecure/Updating/Updating.aspx");
            routes.MapPageRoute("ErrorNetwork", "ErrorNetwork", "~/Content/Unsecure/Error/ErrorNetwork.aspx");
        }
    }
}