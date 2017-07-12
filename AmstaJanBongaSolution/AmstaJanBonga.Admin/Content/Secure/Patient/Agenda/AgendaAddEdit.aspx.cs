using AmstaJanBonga.Business.Database.Managers;
using AmstaJanBonga.Business.Database.Readers;
using AmstaJanBonga.Business.EntityClasses;
using Rlaan.Toolkit.Extensions;
using Rlaan.Toolkit.Web;
using System;
using System.Globalization;

namespace AmstaJanBonga.Admin.Content.Secure.Patient.Agenda
{
    public partial class AgendaAddEdit : SecurePage
    {
        #region Variables & Objects

        private AgendaEventMetaEntity _agendaEventMeta = null;

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
                if (this.HasAgendaEventMetaId)
                {
                    if (this._agendaEventMeta == null)
                        this._agendaEventMeta = AgendaEventMetaReader.GetAgendaEventMetaById(Url.QueryStringParser.GetInt("AgendaEventMetaId"), true);

                    return this._agendaEventMeta;
                }

                return null;
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

        #region PreRender

        private void PreFill()
        {
            if (this.HasAgendaEventMetaId)
            {
                // Changing the database formats to a normal format.
                var timeStart = Time.UnixTime.UnixTimeStampToDateTime(this.AgendaEventMeta.EventUnixTimeStamp)
                    .AddHours(this.AgendaEventMeta.AgendaEvent.TimeStart / 60)
                    .AddMinutes(this.AgendaEventMeta.AgendaEvent.TimeStart % 60);

                var timeEnd = new DateTime()
                    .AddHours(this.AgendaEventMeta.AgendaEvent.TimeEnd / 60)
                    .AddMinutes(this.AgendaEventMeta.AgendaEvent.TimeEnd % 60);

                // Title
                this._txtTitle.Text = this.AgendaEventMeta.AgendaEvent.Title;
                // start date & time
                this._txtStart.Text = timeStart.ToString("yyyy'/'MM'/'dd HH:mm");
                this._hfStart.Value = timeStart.ToString();
                // end time
                this._txtEnd.Text = timeEnd.ToString("HH:mm");
                this._hfEnd.Value = timeEnd.ToString();
                // Location
                this._txtLocation.Text = this.AgendaEventMeta.AgendaEvent.Location;
                // Description
                this._txtDescription.Text = this.AgendaEventMeta.AgendaEvent.Description;
                // Repeat
                this._cbRepeat.Checked = this.AgendaEventMeta.RepeatInterval.HasValue;
                this._cbRepeat.Enabled = false;
            }
        }

        #endregion

        #region Save

        private void Save()
        {
            // Add
            if (!this.HasAgendaEventMetaId)
            {
                var timeStart = DateTime.ParseExact(this._hfStart.Value.Substring(0, 24), "ddd MMM d yyyy HH:mm:ss", CultureInfo.InvariantCulture);
                var timeEnd = DateTime.ParseExact(this._hfEnd.Value.Substring(0, 24), "ddd MMM d yyyy HH:mm:ss", CultureInfo.InvariantCulture);

                // Inserts the agenda event data.
                var agendaEventId = AgendaEventManager.InsertAgendaEvent(
                    this._txtTitle.Text,                                    // The titel of the appointment
                    (timeStart.Hour * 60) + timeStart.TimeOfDay.Minutes,    // The starting time
                    (timeEnd.Hour * 60) + timeEnd.TimeOfDay.Minutes,        // The ending time
                    this._txtLocation.Text,                                 // The location of the appointment
                    this._txtDescription.Text);                             // The description of  the appointment

                // Inserts the agenda event meta data.
                AgendaEventMetaManager.InsertAgendaEventMeta(
                    agendaEventId,
                    Url.QueryStringParser.GetInt("PatientId"),
                    Time.UnixTime.DateTimeToUnixTimeStamp(timeStart.Date),
                    this._cbRepeat.Checked ? Time.UnixTime.UNIX_TIMESTAMP_WEEK : -1);
            }
            // Edit
            else if (this.HasAgendaEventMetaId)
            {
                var timeStart = this._hfStart.Value.ConvertDotNetDateTime_Or_JavaScriptDateTime_To_DotNetDateTime_Hack();
                var timeEnd = this._hfEnd.Value.ConvertDotNetDateTime_Or_JavaScriptDateTime_To_DotNetDateTime_Hack();

                // Updates the agenda event data.
                AgendaEventManager.UpdateAgendaEvent(
                    AgendaEventMeta.AgendaEventId,
                    this._txtTitle.Text,                                    // The titel of the appointment
                    (timeStart.Hour * 60) + timeStart.TimeOfDay.Minutes,    // The starting time
                    (timeEnd.Hour * 60) + timeEnd.TimeOfDay.Minutes,        // The ending time
                    this._txtLocation.Text,                                 // The location of the appointment
                    this._txtDescription.Text);                             // The description of  the appointment

                // Updates the agenda event meta data.
                AgendaEventMetaManager.UpdateAgendaEventMeta(
                    AgendaEventMeta.Id,
                    Time.UnixTime.DateTimeToUnixTimeStamp(timeStart.Date));
            }
        }

        #endregion

        #region Events

        protected void _btnSave_Click(object sender, EventArgs e)
        {
            this.Page.Validate("Validate");

            if (this.Page.IsValid)
            {
                this.Save();

                Response.Redirect("~/Content/Secure/Patient/Agenda/AgendaOverview.aspx?PatientId={0}".FormatString(Url.QueryStringParser.GetInt("PatientId")));
            }
        }

        protected void _btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Content/Secure/Patient/Agenda/AgendaOverview.aspx?PatientId={0}".FormatString(Url.QueryStringParser.GetInt("PatientId")));
        }

        #endregion

        #region Custom Validators

        protected void _cvEndTime_ServerValidate(object source, System.Web.UI.WebControls.ServerValidateEventArgs args)
        {
            // Add
            if (!this.HasAgendaEventMetaId)
            {
                var timeStart = DateTime.ParseExact(this._hfStart.Value.Substring(0, 24), "ddd MMM d yyyy HH:mm:ss", CultureInfo.InvariantCulture);
                var timeEnd = DateTime.ParseExact(this._hfEnd.Value.Substring(0, 24), "ddd MMM d yyyy HH:mm:ss", CultureInfo.InvariantCulture);

                if (timeEnd.TimeOfDay <= timeStart.TimeOfDay)
                {
                    args.IsValid = false;
                    return;
                }
            }
            // Edit
            else if (this.HasAgendaEventMetaId)
            {
                var timeStart = this._hfStart.Value.ConvertDotNetDateTime_Or_JavaScriptDateTime_To_DotNetDateTime_Hack();
                var timeEnd = this._hfEnd.Value.ConvertDotNetDateTime_Or_JavaScriptDateTime_To_DotNetDateTime_Hack();

                if (timeEnd.TimeOfDay <= timeStart.TimeOfDay)
                {
                    args.IsValid = false;
                    return;
                }
            }

            args.IsValid = true;
        }

        #endregion
    }
}