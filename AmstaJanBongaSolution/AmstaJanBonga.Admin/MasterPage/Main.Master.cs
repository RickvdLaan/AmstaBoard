using AmstaJanBonga.Business.Security;
using Rlaan.Toolkit.Configuration;
using Rlaan.Toolkit.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AmstaJanBonga.Admin.MasterPage
{
    public partial class Main : System.Web.UI.MasterPage
    {
        #region Variables & Objects

        private List<string> _notificationMessages = new List<string>();

        #endregion

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
        }

        #region Overrides

        protected override void OnPreRender(EventArgs e)
        {
            if (this._notificationMessages.Count > 0)
                this.RenderNotificationmessage();

            base.OnPreRender(e);
        }

        protected override void OnInit(EventArgs e)
        {
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

        #region Methods

        /// <summary>
        /// Renders the JQuery notification message.
        /// </summary>
        private void RenderNotificationmessage()
        {
            var litHead = this.Page.Master.FindControl("_litHead") as System.Web.UI.WebControls.Literal;
            litHead.Visible = true;
            litHead.Text += "<script src='http://ajax.googleapis.com/ajax/libs/jquery/2.1.1/jquery.min.js' type='text/javascript'></script>";
            litHead.Text += "<script type='text/javascript' src='http://static.rickvanderlaan.nl/Js/jquery.notification.js'></script>";

            var litNotificationMessage = this.Page.Master.FindControl("_litNotificationMessage") as System.Web.UI.WebControls.Literal;
            litNotificationMessage.Text = "<script type='text/javascript'>";

            foreach (var message in this._notificationMessages)
                litNotificationMessage.Text += "$().renderMessage('showNotification', '{0}');".FormatString(message);

            litNotificationMessage.Text += "</script>";

            this._notificationMessages.Clear();
        }

        /// <summary>
        /// Renders the notification message that will be displayed.
        /// </summary>
        /// <param name="message">Provide the message that must be displayed, accepted format: [Aa]-[Zz]-[09].</param>
        public void AddNotificationMessage(string message)
        {
            // FIXME: .?
            //if (!Regex.IsMatch(message, "^[A-Za-z0-9]+$"))
            //throw new Exception("Notification message contains illegal characters.");

            this._notificationMessages.Add(message);
        }

        #endregion
    }
}