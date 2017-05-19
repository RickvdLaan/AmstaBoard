using AmstaJanBonga.Business.Security;
using Rlaan.Toolkit.Configuration;
using Rlaan.Toolkit.Web;
using System;
using System.Web;
using System.Web.UI.WebControls;

namespace AmstaJanBonga.Admin.MasterPage
{
    public partial class Main : System.Web.UI.MasterPage
    {
        #region Properties

        /// <summary>
        /// Contains the username of the authenticated user.
        /// </summary>
        protected string Username { get; private set; }

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.Page.IsPostBack && Authentication.IsAuthenticated)
                this.Username = Authentication.AuthenticatedUser.Username ?? string.Empty;

            if (Url.GetFullUrl.Contains("Dashboard"))
                this._liDashboard.Attributes.Add("class", "nav-menu-active");
            else if (Url.GetFullUrl.Contains("User"))
                this._liUser.Attributes.Add("class", "nav-menu-active");
            else if (Url.GetFullUrl.Contains("Patient"))
                this._liPatient.Attributes.Add("class", "nav-menu-active");
            else if (Url.GetFullUrl.Contains("Employee"))
                this._liEmployee.Attributes.Add("class", "nav-menu-active");
            else if (Url.GetFullUrl.Contains("Livingroom"))
                this._liLivingRoom.Attributes.Add("class", "nav-menu-active");
        }

        #region Overrides

        protected override void OnInit(EventArgs e)
        {
            this.Page.MaintainScrollPositionOnPostBack = true;

            // Were one of these exceptions ever to occur on the live environment then give the developer a punch in the head for not testing his work!
            if (Project.Environment.IsDevelopEnvironment || Project.Environment.IsStagingEnvironment || Project.Environment.IsLiveEnvironment)
            {
                // Checks if the page inherits at least from the DefaultPage class.
                if (!this.Page.GetType().IsSubclassOf(typeof(DefaultPage)))
                    throw new DefaultPageNotImplementedException("The DefaultPage was not implemented on the current page.");
               
                // Checks if the current page is placed under the secure folder and if the page inherits at least from the SecurePage class.
                if (HttpContext.Current.Request.Url.AbsolutePath.Contains("Content/Secure") && !this.Page.GetType().IsSubclassOf(typeof(SecurePage)))
                    throw new SecurePageNotImplementedException("The current page was placed in the secure folder but does not implemented the SecurePage class.");
            }

            base.OnInit(e);
        }

        #endregion

        #region Events

        protected void _lbDashboard_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Dashboard");
        }

        protected void _lbSignOut_Click(object sender, EventArgs e)
        {
            Authentication.Utility.SignOut();
        }

        #endregion
    }
}