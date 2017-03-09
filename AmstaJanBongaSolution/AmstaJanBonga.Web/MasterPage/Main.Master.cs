using Rlaan.Toolkit.Extensions;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Web.UI.WebControls;

namespace AmstaJanBonga.Web.MasterPage
{
    public partial class Main : System.Web.UI.MasterPage
    {
        #region Variables & Objects

        private List<string> _notificationMessages = new List<string>();

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                this.UpdateInformationBar();
            }
        }

        #region Overrides

        protected override void OnPreRender(EventArgs e)
        {
            if (this._notificationMessages.Count > 0)
                this.RenderNotificationmessage();

            base.OnPreRender(e);
        }

        #endregion

        #region Notification Message

        /// <summary>
        /// Renders the JQuery notification message.
        /// </summary>
        private void RenderNotificationmessage()
        {
            var litNotificationMessage = this.Page.Master.FindControl("_litNotificationMessage") as Literal;
            litNotificationMessage.Text = "<script type='text/javascript'>";

            foreach (var message in this._notificationMessages)
                // Make sure that the text you're about to load in doesn't contain any weird characters, else it won't load.
                litNotificationMessage.Text += string.Format("$().renderMessage('showNotification', '{0}');", message);

            litNotificationMessage.Text += "</script>";
        }

        /// <summary>
        /// Renders the notification message that will be displayed.
        /// </summary>
        /// <param name="message">Provide the message that must be displayed.</param>
        public void AddNotificationMessage(string message)
        {
            this._notificationMessages.Add(message);
        }

        #endregion

        #region Methods

        private void UpdateInformationBar()
        {
            // Current day.
            this._litDay.Text = "Het is vandaag {0} {1} {2}.".FormatString(
                DateTimeFormatInfo.CurrentInfo.GetDayName(DateTime.Now.DayOfWeek),
                DateTime.Now.Day,
                DateTimeFormatInfo.CurrentInfo.GetMonthName(DateTime.Now.Month));

            // The time.
            this._litTime.Text = "{0}".FormatString(DateTime.Now.ToString("HH:mm"));

            // Weather
            this._litWeather.Text = "Het weer: 11 °C";
        }

        #endregion

        #region Events

        protected void _timer_Tick(object sender, EventArgs e)
        {
            this.UpdateInformationBar();
        }

        #endregion
    }
}