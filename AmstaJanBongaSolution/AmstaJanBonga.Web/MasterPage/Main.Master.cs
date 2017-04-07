using Rlaan.Toolkit.Configuration;
using Rlaan.Toolkit.Extensions;
using Rlaan.Toolkit.Web;
using System;
using System.Globalization;
using System.Web;

namespace AmstaJanBonga.Web.MasterPage
{
    public partial class Main : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                this.UpdateInformationBar();
            }
        }

        #region Overrides

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
        /// Adds a css class to the content section.
        /// </summary>
        /// <param name="cssClass">The css class to add.</param>
        public void AddClassToContent(string cssClass)
        {
            this._sectionContent.Attributes.Add("class", "{0} {1}".FormatString(this._sectionContent.Attributes["class"], cssClass));
        }

        private void UpdateInformationBar()
        {
            var culture = new CultureInfo("nl-NL");
            var day = culture.DateTimeFormat.GetDayName(DateTime.Today.DayOfWeek);
            var month = culture.DateTimeFormat.GetMonthName(DateTime.Today.Month);

            // Current day.
            this._litDay.Text = "Het is vandaag {0} {1} {2}.".FormatString(day, DateTime.Now.Day, month);

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

        protected void _lbHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Livingroom");
        }

        #endregion
    }
}