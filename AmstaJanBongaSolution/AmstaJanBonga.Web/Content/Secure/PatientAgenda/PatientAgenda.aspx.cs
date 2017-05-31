﻿using AmstaJanBonga.Business.Database.Readers;
using AmstaJanBonga.Business.EntityClasses;
using Rlaan.Toolkit.Extensions;
using Rlaan.Toolkit.Web;
using System;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AmstaJanBonga.Web.Content.PatientAgenda
{
    public partial class PatientAgenda : SecurePage
    {
        #region Variables & Objects

        private const int AGENDA_START_HOUR = 8;

        private PatientEntity _patient = null;

        private DataTable _agendaTime = new DataTable("AgendaTime");

        private DataTable _agendaDay = new DataTable("AgendaDay");

        private DataTable _agendaWeekDay = new DataTable("AgendaWeekDay");

        private DataTable _agendaWeekAppointments = new DataTable("AgendaWeek");

        #endregion

        #region Properties

        private bool HasPatientId
        {
            get { return Url.QueryStringParser.HasParameter("PatientId"); }
        }

        private PatientEntity Patient
        {
            get
            {
                if (this._patient == null)
                {
                    if (this.HasPatientId)
                        this._patient = PatientReader.GetPatientById(Url.QueryStringParser.GetInt("PatientId"), true);
                }

                return this._patient;
            }
        }

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

            this._imagePatient.ImageUrl = this.Patient.ImagePath.Replace('\\', '/');
        }

        #endregion

        #region Databinding

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

            var appointments = AgendaEventMetaReader.GetAllEventsForTodayByPatientId(this.Patient.Id);

            foreach (var app in appointments)
            {
                appointment[0] += this.GenerateAppointment(app.Title, app.Location, new Time(10, 00), new Time(12, 00), app.Description);
            }

            this._agendaDay.Rows.Add(appointment);

            this._repAgendaDay.DataSource = this._agendaDay;
            this._repAgendaDay.DataBind();
        }

        private void DatabindAgendaWeek()
        {
            this._repAgendaWeek.DataSource = null;
            this._repAgendaWeek.DataBind();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Generates an appointment and returns the generated html.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="location"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="description"></param>
        /// <returns></returns>
        public string GenerateAppointment(string title, string location, Time startTime, Time endTime, string description)
        {
            // Generates a unique id.
            var id = Guid.NewGuid();

            // Todo: Calculate minutes in it.
            var hourLength = (endTime.Hour - startTime.Hour);

            // 58 and 59 are the default heights.
            //                                                                           -2 because of the border on the bottom
            var height = ((hourLength > 1 ? 59 : 58) * (hourLength)) + (hourLength > 1 ? (hourLength - 2) : 0);

            // Start hour appointment - start hour of the agenda times the height (which includes the border).
            var top = (60 * (startTime.Hour - AGENDA_START_HOUR));

            // Html code.
            return "<div id=\"{0}\" data-remodal-target=\"appointment-remodal\" class=\"appointment red-bg\" style=\"height: {1}px; top: {2}px;\"><dl><dt class=\"dialog-title\">{3}</dt><dd><p><span class=\"label\">Waar:</span><span class=\"dialog-location\">{4}</span></p></dd><dd><p><span class=\"label\">Tijdstip:</span><span class=\"dialog-time\">Van {5} tot {6} uur.</span></p></dd><dd><p><span class=\"label\">Omschrijving:</span><span class=\"dialog-description\">{7}</span></p></dd></dl></div>".FormatString(
                id, height, top, title, location, startTime.ToString(), endTime.ToString(), description);
        }

        #endregion

        #region Events

        protected void _btnSelectDayAgenda_Click(object sender, EventArgs e)
        {
            this._pnlDayHeader.Visible = true;
            this._pnlDay.Visible = true;

            this._pnlWeekHeader.Visible = false;
            this._pnlWeek.Visible = false;
        }

        protected void _btnSelectWeekAgenda_Click(object sender, EventArgs e)
        {
            this._pnlDayHeader.Visible = false;
            this._pnlDay.Visible = false;

            this._pnlWeekHeader.Visible = true;
            this._pnlWeek.Visible = true;
        }

        protected void _repAgendaWeek_ItemDataBound(object sender, RepeaterItemEventArgs args)
        {
            Context.ApplicationInstance.CompleteRequest();

            if (args.Item.ItemType == ListItemType.Item || args.Item.ItemType == ListItemType.AlternatingItem)
            {
                //if (!this._agendaWeekAppointments.Columns.Contains("Appointments"))
                //    this._agendaWeekAppointments.Columns.Add("Appointments");

                Repeater childRepeater = (Repeater)args.Item.FindControl("_repAgendaWeekChild");
                childRepeater.DataSource = null;
                childRepeater.DataBind();

                //this._agendaWeekAppointments.Clear();
           }
        }

        protected void _upAgenda_PreRender(object sender, EventArgs e)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), Guid.NewGuid().ToString(), "RegisterStartupScript();", true);
        }

        #endregion
    }
}