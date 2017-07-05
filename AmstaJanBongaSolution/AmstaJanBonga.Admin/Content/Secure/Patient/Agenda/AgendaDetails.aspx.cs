using AmstaJanBonga.Business.Database.Readers;
using AmstaJanBonga.Business.EntityClasses;
using Rlaan.Toolkit.Extensions;
using Rlaan.Toolkit.Web;
using System;

namespace AmstaJanBonga.Admin.Content.Secure.Patient.Agenda
{
    public partial class AgendaDetails : SecurePage
    {
        #region Variables & Objects

        private AgendaEventMetaEntity _agendaEventMetaId = null;

        #endregion

        #region Properties

        private bool HasAgendaEventMetaId
        {
            get { return Url.QueryStringParser.HasParameter("AgendaEventMetaId"); }
        }

        private AgendaEventMetaEntity AgendaEventMeta
        {
            get
            {
                if (this._agendaEventMetaId == null && this.HasAgendaEventMetaId)
                    this._agendaEventMetaId = AgendaEventMetaReader.GetAgendaEventMetaById(Url.QueryStringParser.GetInt("AgendaEventMetaId"), true);

                return this._agendaEventMetaId;
            }
        }

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.PreFill();
            }
        }

        #region Methods

        private void PreFill()
        {
            if (this.HasAgendaEventMetaId)
            {
                // Title
                this._lblTitle.Text = this.AgendaEventMeta.AgendaEvent.Title;

                // Date
                var date = Time.UnixTime.UnixTimeStampToDateTime(this.AgendaEventMeta.EventUnixTimeStamp);
                this._lblDate.Text = "{0} {1} {2}".FormatString(
                                new System.Globalization.CultureInfo("nl-NL").DateTimeFormat.GetDayName(date.DayOfWeek),
                                date.Day,
                                new System.Globalization.CultureInfo("nl-NL").DateTimeFormat.GetMonthName(date.Month));

                // Time
                this._lblTime.Text = "van {0} tot {1}".FormatString(
                    new Time(this.AgendaEventMeta.AgendaEvent.TimeStart).ToString(),
                    new Time(this.AgendaEventMeta.AgendaEvent.TimeEnd).ToString());

                // Location
                this._lblLocation.Text = this.AgendaEventMeta.AgendaEvent.Location;

                // Description
                this._lblDescription.Text = this.AgendaEventMeta.AgendaEvent.Description;

                // Repeat interval
                this._lblRepeatInterval.Text = this.AgendaEventMeta.RepeatInterval.HasValue ?
                    "{0} dagen.".FormatString(Time.UnixTime.UnixTimeStampToDateTime(this.AgendaEventMeta.RepeatInterval.Value).Day - 1) :
                    "Eenmalige afspraak.";
            }
        }

        #endregion
    }
}