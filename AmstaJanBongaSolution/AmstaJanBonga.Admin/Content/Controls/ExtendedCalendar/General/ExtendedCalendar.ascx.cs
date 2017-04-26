using AmstaJanBonga.Business.Database.Readers;
using Rlaan.Toolkit.Web;
using System;
using System.Collections.Generic;
using System.Web.UI;

namespace AmstaJanBonga.Admin.Content.Controls.ExtendedCalendar.General
{
    [ValidationProperty("Text")]
    public partial class ExtendedCalendar : System.Web.UI.UserControl
    {
        #region Variables & Objects

        private List<DateTime> _dates = null;

        #endregion

        #region Properties

        public DateTime SelectedDate
        {
            get { return this._calendar.SelectedDate; }
            set { this._calendar.SelectedDate = value; }
        }

        private List<DateTime> Dates
        {
            get { return this._dates; }
            set { this._dates = value; }
        }

        public string Text
        {
            get
            {
                var dateString = this._calendar.SelectedDate.ToString("yyyy-MM-dd");
               
                if (dateString == DateTime.MinValue.ToString("yyyy-MM-dd"))
                    return string.Empty;

                return dateString;
            }
        }

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        #region Events

        protected void _calendar_DayRender(object sender, System.Web.UI.WebControls.DayRenderEventArgs e)
        {
            if (this.Dates == null)
            {
                // The QueryStringParser validation check should already be done on the page this is used
                // to catch any possible exceptions. So we're assuming everything is right.
                this.Dates = LivingroomGeneralEventReader.GetAllUsedDatesByLivingroomId(Url.QueryStringParser.GetInt("LivingroomId"));
            }

            if (e.Day.IsOtherMonth)
            {
                e.Cell.Text = string.Empty;
            }

            foreach (var date in this.Dates)
            {
                if (e.Day.Date == date)
                {
                    e.Day.IsSelectable = false;
                    e.Cell.CssClass += " calendar-unavailable red-bg";
                    e.Cell.Text = "x";
                    e.Cell.ToolTip = "Deze datum is al in gebruik.";
                }
            }
        }

        #endregion
    }
}