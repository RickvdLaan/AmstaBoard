using Rlaan.Toolkit.Configuration;
using Rlaan.Toolkit.Extensions;
using Rlaan.Toolkit.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace AmstaJanBonga.Web
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {

        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            // Checking whether the environment is live or staging.
            if (Project.Environment.IsLiveEnvironment || Project.Environment.IsStagingEnvironment)
            {
                // Checking if the connect is secure and if it's not a local connection.
                if (HttpContext.Current.Request.IsSecureConnection.Equals(false) && HttpContext.Current.Request.IsLocal.Equals(false))
                {
                    // The connection wasn't secure and it wasn't a local connection, redirecting to a secure connection.
                    Response.Redirect("https://{0}{1}".FormatString(Request.ServerVariables["HTTP_HOST"], HttpContext.Current.Request.RawUrl));
                }
            }
        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

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

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}