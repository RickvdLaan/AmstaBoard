﻿using AmstaJanBonga.Business.Database.Readers;
using AmstaJanBonga.Business.Enums;
using AmstaJanBonga.Business.Security;
using Rlaan.Toolkit.Configuration;
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
                    RoleTypeEnum.Root))
                {
                    // User passed all checks, we can re-authenticate the current user.
                    Authentication.Utility.AuthenticateUser(user);

                    // Sets the forms-authentication user identity ticket.
                    user.AuthenticationTicket = formIdentity.Ticket;

                    // Initializes the custom principal class.
                    var principle = new JouwSoftwarePrincipal(user);

                    // Re-sets the security information.
                    HttpContext.Current.User = principle;
                    Thread.CurrentPrincipal = principle;
                }
                else
                {
                    // For some weird reason the user isn't authenticated anymore or doesn't have enough privileges.
                    Response.Redirect("~/Unsecure/InsufficientPrivileges/InsufficientPrivileges.aspx");
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
        }
    }
}