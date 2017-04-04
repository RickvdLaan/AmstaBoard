using AmstaJanBonga.Business.Database.Readers;
using AmstaJanBonga.Business.Enums;
using AmstaJanBonga.Business.Security;
using Resources;
using Rlaan.Toolkit.Configuration;
using Rlaan.Toolkit.Web;
using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AmstaJanBonga.Admin.Content.Unsecure.Login
{
    public partial class Login : DefaultPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsCallback)
            {
                var txtUsername = _loginAuthentication.FindControl("UserName") as TextBox;
                txtUsername.Attributes.Add("placeholder", Resource.Username);
                txtUsername.Attributes.Add("type", "username");

                (_loginAuthentication.FindControl("Password") as TextBox).Attributes.Add("placeholder", Resource.Password);
            }
        }

        #region Overrides

        protected override void OnInit(EventArgs e)
        {
            if (Authentication.IsAuthenticated)
                Response.Redirect("~/Dashboard");
        }

        #endregion

        #region Events

        protected void _loginAuthentication_OnAuthenticate(object sender, AuthenticateEventArgs e)
        {
            // Gets the account information from the login control.
            var username = _loginAuthentication.UserName;
            var password = _loginAuthentication.Password;

            // Validates both fields.
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                _loginAuthentication.FailureText = Resource.EmptyUsernameAndOrPassword;

                e.Authenticated = false;
                return;
            }

            // Determines whether the database connection is available.
            if (!NetworkInformation.IsDatabaseConnectionAvailable(WebConfig.GetSetting("ConnectionString.SQL Server (SqlClient)")))
            {
                _loginAuthentication.FailureText = Resource.ServerConncetionError;

                e.Authenticated = false;
                return;
            }

            // Gets the user which corresponds with the username and password.
            var user = UserReader.GetUserByUsernameAndPassword(username, password);

            // User will be null if either the username or password are invalid.
            if (user == null)
            {
                _loginAuthentication.FailureText = Resource.InvalidUsernameAndOrPassword;

                e.Authenticated = false;
                return;
            }

            // Determines whether the current user is active.
            if (!user.IsActive)
            {
                _loginAuthentication.FailureText = Resource.DisabledAccount;

                e.Authenticated = false;
                return;
            }

            // Determines whether the current user has the appropriate role.
            if (!UserReader.IsUserInRole(user, RoleTypeEnum.Root, RoleTypeEnum.Manager, RoleTypeEnum.Employee))
            {
                _loginAuthentication.FailureText = Resource.AccountPermissions;

                e.Authenticated = false;
                return;
            }

            // Authenticates the user and updates the last login.
            Authentication.Utility.AuthenticateUser(user, true);
            e.Authenticated = true;

            // Looks if a return url is present.
            if (Helper.ReturnUrl != null)
                Response.Redirect(Helper.ReturnUrl);

            // There was no return url present, so we assume that the user came from the login page.
            Response.Redirect("~/Dashboard");
        }

        #endregion
    }
}