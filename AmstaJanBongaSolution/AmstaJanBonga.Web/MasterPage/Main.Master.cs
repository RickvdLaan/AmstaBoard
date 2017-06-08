using AmstaJanBonga.Business.Security;
using Rlaan.Toolkit.Configuration;
using Rlaan.Toolkit.Extensions;
using Rlaan.Toolkit.Web;
using System;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Web;
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
            // Checks if the software is updating.
            if (WebConfig.GetSetting("Application.IsUpdating").ToBoolean())
            {
                Response.Redirect("~/Updating");
            }

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
            // Checks if the software is updating.
            if (WebConfig.GetSetting("Application.IsUpdating").ToBoolean())
            {
                Response.Redirect("~/Updating");
            }

            var culture = new CultureInfo("nl-NL");
            var day = culture.DateTimeFormat.GetDayName(DateTime.Today.DayOfWeek);
            var month = culture.DateTimeFormat.GetMonthName(DateTime.Today.Month);

            // Current day.
            this._litDay.Text = "Het is vandaag {0} {1} {2}.".FormatString(day, DateTime.Now.Day, month);

            // The time.
            this._litTime.Text = "{0}".FormatString(DateTime.Now.ToString("HH:mm"));

            // Weather
            var temperature = this.GetTemperature();
            this._litWeather.Text = string.IsNullOrWhiteSpace(temperature) ? "Het weer kan niet worden weergegeven." : "Het weer: {0} °C".FormatString(temperature);

            // Gets the current date and see's if it's different from the stored date.
            this.GetDate();
        }

        /// <summary>
        /// Gets the temperature in Amsterdam, and generates a cookie called: "Temperature" and saves it, with an expire time of 30 mintues.
        /// </summary>
        /// <returns></returns>
        public string GetTemperature()
        {
            var temperature = string.Empty;

            // Checking whether the cookie exists, if not, gets the temperature and saves the cookie with its value.
            if (Request.Cookies["Temperature"] == null)
            {
                var locationId = WebConfig.GetSetting("Weather.Api.Location"); ;
                var apiId = WebConfig.GetSetting("Weather.Api.Id");
                var apiCall = (WebConfig.GetSetting("Weather.Api.Url") + "weather?id={0}&units=metric&mode=xml&APPID={1}").FormatString(locationId, apiId);

                using (var client = new WebClient())
                {
                    try
                    {
                        var xdoc = XDocument.Parse(client.DownloadString(apiCall));

                        temperature = Math.Round(
                                        Convert.ToDecimal(
                                            (from doc in xdoc.Descendants("temperature") select (string)doc.Attribute("value")).ToList()[0]
                                                .Replace('.', ',')), 1)
                                                    .ToString()
                                                        .Replace(',', '.');
                    }
                    catch { }
                }

                // Creates a cookie which has an expire time of 60 minutes.
                var cookie = new HttpCookie("Temperature")
                {
                    Value = temperature,
                    Expires = DateTime.Now.AddMinutes(60)
                };

                Response.Cookies.Add(cookie);
            }
            // Cookie exists, getting the value and returning it.
            else
            {
                temperature = Request.Cookies["Temperature"].Value;
            }

            return temperature;
        }

        private void GetDate()
        {
            if (Request.Cookies["Date"] == null)
            {
                // Setting a cookie for the current date.
                var cookie = new HttpCookie("Date")
                {
                    Value = DateTime.Now.Date.ToString(),
                    Expires = DateTime.Now.AddHours(1)
                };

                // Creates the cookie.
                Response.Cookies.Add(cookie);

                Url.Refresh();
            }
            // Cookie should be removed and the page should be refreshed after midnight.
            else if (Convert.ToDateTime(Request.Cookies["Date"].Value).Date != DateTime.Now.Date)
            {
                // Deleting the old date cookie, since a new day has arrived.
                Response.Cookies["Date"].Expires = DateTime.Now.AddDays(-1);
            }
        }

        #endregion

        #region Events

        protected void _timer_Tick(object sender, EventArgs e)
        {
            this.UpdateInformationBar();
        }

        protected void _lbHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/LivingRoom", false);
        }

        protected void _SignOut_Click(object sender, EventArgs e)
        {
            Authentication.Utility.SignOut();
        }

        #endregion
    }
}