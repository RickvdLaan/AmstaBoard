using Rlaan.Toolkit.Extensions;
using Rlaan.Toolkit.Web;
using System;
using System.Globalization;

namespace AmstaJanBonga.Web.MasterPage
{
    public partial class Main : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                this.UpdateInformationBar();

                // Setting the navigate url to the home button.
                if (Url.GetFullUrl.Contains("/Livingroom/"))
                    this._hlBtnHome.NavigateUrl = "~/Content/Livingroom/LivingroomOverview.aspx";
                else
                    this._hlBtnHome.NavigateUrl = "~/Content/Livingroom/Livingroom.aspx";
            }
        }

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