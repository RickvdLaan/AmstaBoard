using AmstaJanBonga.Business.Database.Managers;
using AmstaJanBonga.Business.Database.Readers;
using Rlaan.Toolkit.Web;
using System;
using System.Globalization;
using System.Web.UI.WebControls;

namespace AmstaJanBonga.Admin.Content.Secure.Patient.Agenda
{
    public partial class AgendaAddEdit : SecurePage
    {
        private const int TIME_START = 480; // 08:00

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        #region Save

        private void Save()
        {
            var timeStart = DateTime.ParseExact(_hfStart.Value.Substring(0, 24), "ddd MMM d yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            var timeEnd   = DateTime.ParseExact(_hfEnd.Value.Substring(0, 24), "ddd MMM d yyyy HH:mm:ss", CultureInfo.InvariantCulture);



            // Title
            // Starting time
            // Ending time
            // Location or null
            // Description or null
            // UnixTimeStamp
            // UnixInteral or null

            var agendaEventId = AgendaEventManager.InsertAgendaEvent(
                this._txtTitle.Text,
                timeStart.TimeOfDay.Minutes + TIME_START,
                timeEnd.TimeOfDay.Minutes + TIME_START,
                this._txtLocation.Text,
                this._txtDescription.Text);

            AgendaEventMetaManager.InsertAgendaEventMeta(
                agendaEventId,
                Url.QueryStringParser.GetInt("PatientId"), 
                Time.UnixTime.DateTimeToUnixTimeStamp(timeStart.Date), 
                this._cbRepeat.Checked ? Time.UnixTime.UNIX_TIMESTAMP_WEEK : -1);
        }

        #endregion

        protected void _btnSave_Click(object sender, EventArgs e)
        {
            this.Page.Validate("Validate");

            if (this.Page.IsValid)
            {
                this.Save();
            }
        }

        protected void _btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}