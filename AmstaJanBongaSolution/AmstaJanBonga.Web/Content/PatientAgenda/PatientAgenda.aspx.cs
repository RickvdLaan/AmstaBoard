using AmstaJanBonga.Web.Utilities;
using Rlaan.Toolkit.Extensions;
using System;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AmstaJanBonga.Web.Content.PatientAgenda
{
    public partial class PatientAgenda : DefaultPage
    {
        #region Variables & Objects

        private DataTable _agendaTime = new DataTable("AgendaTime");

        private DataTable _agendaDay = new DataTable("AgendaDay");

        private DataTable _agendaWeekDay = new DataTable("AgendaWeekDay");

        private DataTable _agendaWeekAppointments = new DataTable("AgendaWeek");

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.DatabindAgendaTime();  
                this.DatabindAgendaDay();   
                this.DatabindAgendaWeek();  
            }
        }

        #region Overrides

        protected override void OnPreRender(EventArgs e)
        {
            this.MasterPage.AddClassToContent("grey-bg");
            this.MasterPage.AddClassToContent("overflow-auto");

            base.OnPreRender(e);
        }

        #endregion

        #region Methods

        public string GenerateAppointment(string title, string location, Time startTime, Time endTime, string description)
        {
            // Generate unique id.
            var id = Guid.NewGuid();

            // Todo: Calculate minutes in it.
            var hourLength = (endTime.Hour - startTime.Hour);

            // 58 and 59 are the default heights.
            var height = 58 + (59 * (hourLength));

            // Start hour appointment - start hour of the agenda (which is 08:00) times the height + border.
            var top = (60 * (startTime.Hour - 8)); 

            // Html code.
            return "<div id=\"{0}\" data-remodal-target=\"appointment-remodal\" class=\"appointment red-bg\" style=\"height: {1}px; top: {2}px;\"><dl><dt class=\"dialog-title\">{3}</dt><dd><p>Waar: <span class=\"dialog-location\">{4}</span></p></dd><dd><p>Tijdstip: <span class=\"dialog-time\">Van {5} tot {6} uur.</span></p></dd><dd><p>Omschrijving: <span class=\"dialog-description\">{7}</span></p></dd></dl></div>".FormatString(
                id, height, top, title, location, startTime.ToString(), endTime.ToString(), description);
        }

        private void DatabindAgendaTime()
        {
            this._agendaTime.Columns.Add("Time");

            for (int i = 8; i <= 23; i++)
            {
                DataRow hour;
                hour = this._agendaTime.NewRow();
                hour[0] = "{0}:00".FormatString(i);

                this._agendaTime.Rows.Add(hour);
            }

            this._repTime.DataSource = this._agendaTime;
            this._repTime.DataBind();
        }

        private void DatabindAgendaDay()
        {
            this._agendaDay.Columns.Add("Appointments");

            var appointment = this._agendaDay.NewRow();

            appointment[0] += this.GenerateAppointment("Afspraak fysio", "Ruimte A", new Time(10, 0), new Time(12, 0), "Een omschrijving.");
            appointment[0] += this.GenerateAppointment("Familiebezoek", "De woonkamer.", new Time(14, 0), new Time(17, 0), "Een omschrijving.");
            appointment[0] += this.GenerateAppointment("Activiteit", "De woonkamer.", new Time(19, 0), new Time(19, 0), "Een omschrijving.");

            this._agendaDay.Rows.Add(appointment);

            this._repAgendaDay.DataSource = this._agendaDay;
            this._repAgendaDay.DataBind();
        }

        private void DatabindAgendaWeek()
        {
            this._agendaWeekDay.Columns.Add("Days");

            for (int i = 0; i < 7; i++)
            {
                this._agendaWeekDay.Rows.Add(this._agendaWeekDay.NewRow());
            }

            this._repAgendaWeek.DataSource = this._agendaWeekDay;
            this._repAgendaWeek.DataBind();
        }

        #endregion

        #region Events

        protected void _btnSelectDayAgenda_Click(object sender, EventArgs e)
        {
            this._pnlDayHeader.Visible = true;
            this._pnlDay.Visible = true;

            this._pnlWeekHeader.Visible = false;
            this._pnlWeek.Visible = false;

            ScriptManager.RegisterStartupScript(this, GetType(), this.Page.UniqueID, "UpdateAllAppointments();SetColumnDayWidth();ScrollToAnchor();", true);
        }

        protected void _btnSelectWeekAgenda_Click(object sender, EventArgs e)
        {
            this._pnlDayHeader.Visible = false;
            this._pnlDay.Visible = false;

            this._pnlWeekHeader.Visible = true;
            this._pnlWeek.Visible = true;

            ScriptManager.RegisterStartupScript(this, GetType(), this.Page.UniqueID, "UpdateAllAppointments();SetColumnDayWidth();ScrollToAnchor();", true);
        }

        protected void _repAgendaWeek_ItemDataBound(object sender, RepeaterItemEventArgs args)
        {
            Context.ApplicationInstance.CompleteRequest();

            if (args.Item.ItemType == ListItemType.Item || args.Item.ItemType == ListItemType.AlternatingItem)
            {
                if (!this._agendaWeekAppointments.Columns.Contains("Appointments"))
                    this._agendaWeekAppointments.Columns.Add("Appointments");

                var appointment = this._agendaWeekAppointments.NewRow();

                appointment[0] += this.GenerateAppointment("Afspraak fysio", "Ruimte A", new Time(10, 0), new Time(12, 0), "Een omschrijving.");
                appointment[0] += this.GenerateAppointment("Familiebezoek", "De woonkamer.", new Time(14, 0), new Time(17, 0), "Een omschrijving.");
                appointment[0] += this.GenerateAppointment("Activiteit", "De woonkamer.", new Time(19, 0), new Time(19, 0), "Een omschrijving.");

                this._agendaWeekAppointments.Rows.Add(appointment);

                Repeater childRepeater = (Repeater)args.Item.FindControl("_repAgendaWeekChild");
                childRepeater.DataSource = this._agendaWeekAppointments;
                childRepeater.DataBind();

                this._agendaWeekAppointments.Clear();
            }
        }

        #endregion
    }
}