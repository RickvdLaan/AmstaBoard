using AmstaJanBonga.Business.Security;
using Rlaan.Toolkit.Configuration;
using Rlaan.Toolkit.Extensions;
using Rlaan.Toolkit.Web;
using System;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Web;
using System.Xml;
using System.Xml.Linq;

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
            this._litWeather.Text = "Het weer: {0} °C".FormatString(GetTemperature());
        }

        public string GetTemperature()
        {
            // TODO: Create cookie to store the temperature with the datetime of its creation.
            // Check whether a cookie exist, if so parse the date time and see if it's older than 30 minutes.
            // If it's older than 30 minutes, get the data against and store this in the cookie and return the value.
            // If the data is NOT older than 30 minutes, parse the data out the cookie and return it.

            var temperature = string.Empty;

            var locationId = 2759794;
            var apiId = "84f3dec579b93e63775499eecfa68338";
            var apiCall = @"http://api.openweathermap.org/data/2.5/weather?id={0}&units=metric&mode=xml&APPID={1}".FormatString(locationId, apiId);

            using (var client = new WebClient())
            {
                var xdoc = XDocument.Parse(client.DownloadString(apiCall));

                temperature = Math.Round(
                                Convert.ToDecimal(
                                    (from doc in xdoc.Descendants("temperature") select (string)doc.Attribute("value")).ToList()[0]
                                        .Replace('.', ',')), 1)
                                            .ToString()
                                                .Replace(',', '.');
            }

            return temperature;
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

        protected void _lbTime_Click(object sender, EventArgs e)
        {
            //// A maybe functionality? Triple click on time for sign out?
            //// Could be turned on and off from the CMS?
            //var counter = 1;

            //// Checking whether a cookie already exists, if so. Nothing will be done.
            //if (Request.Cookies["SOCT"] == null)
            //{
            //    // Creates a cookie which has an expire time of five minutes...
            //    var cookie = new HttpCookie("SOCT");
            //    cookie.Value = counter.ToString();
            //    cookie.Expires = DateTime.Now.AddSeconds(10);
            //    Response.Cookies.Add(cookie);
            //}
            //else
            //{
            //    counter = int.Parse(Request.Cookies["SOCT"].Value);
            //    counter++;

            //    var cookie = new HttpCookie("SOCT");
            //    cookie.Value = counter.ToString();
            //    cookie.Expires = DateTime.Now.AddSeconds(10);
            //    Response.Cookies.Add(cookie);
            //}

            //if (counter >= 3)
            //{
            //    var cookie = new HttpCookie("SOCT");
            //    cookie.Expires = DateTime.Now.AddSeconds(-1);
            //    Response.Cookies.Add(cookie);

            //    Authentication.Utility.SignOut();
            //}
            //else
            //    Url.Refresh();
        }

        #endregion
    }
}