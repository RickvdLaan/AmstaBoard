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

            for (int i = 8; i <= 23; i++)
            {
                DataRow appointment;
                appointment = this._agendaDay.NewRow();

                // 10:00 tot :12:00
                if (i == 10)
                {
                    var height = (58 + (59 * (12 - 10))) + (12 - 10);
                    var top = (60 * (10 - 8)); // Start hour appointment - start hour of the agenda (which is 08:00).

                    appointment[0] = "<div data-remodal-target=\"appointment-remodal\" class=\"appointment red-bg\" style=\"height: {0}px; top: {1}px;\">".FormatString(height, top) +
                        "<dl><dt>Afspraak fysio</dt><dd><p>Tijdstip: Van 10:00 tot 12:00 uur.</p></dd><dd><p>Waar: Ruimte A.<p></dd><dd><p>Omschrijving: Maecenas convallis nisi at turpis auctor, aliquet molestie felis blandit.<p></dd></dl>"
                        + "</div>";
                }
                //// 11:00 tot 15:00
                //if (i == 11)
                //{
                //    var height = (58 + (59 * (15 - 11))) + (15 - 11);
                //    var top = (60 * (11 - 8)); // Start hour appointment - start hour of the agenda (which is 08:00).

                //    appointment[0] = "<div data-remodal-target=\"appointment-remodal\" class=\"appointment red-bg\" style=\"height: {0}px; top: {1}px;\">".FormatString(height, top) +
                //        "<dl><dt>Activiteit</dt><dd><p>Tijdstip: Van 11:00 tot 15:00 uur.</p></dd><dd><p>Waar: De woonkamer.<p></dd><dd><p>Omschrijving: Nulla mattis tellus vel est pellentesque dapibus. Pellentesque ornare lobortis pellentesque.<p></dd></dl>"
                //        + "</div>";
                //}
                // 14:00 tot 17:00
                if (i == 14)
                {
                    var height = (58 + (59 * (17 - 14))) + (17 - 14);
                    var top = (60 * (14 - 8)); // Start hour appointment - start hour of the agenda (which is 08:00).

                    appointment[0] = "<div data-remodal-target=\"appointment-remodal\" class=\"appointment red-bg\" style=\"height: {0}px; top: {1}px;\">".FormatString(height, top) +
                        "<dl><dt>Familiebezoek</dt><dd><p>Tijdstip: Van 14:00 tot 17:00 uur.</p></dd><dd><p>Waar: De woonkamer.<p></dd><dd><p>Omschrijving: Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum porttitor sollicitudin volutpat. Nulla consectetur neque id nulla dignissim, ac faucibus velit posuere.<p></dd></dl>"
                        + "</div>";
                }
                // 19:00 tot 19:00
                if (i == 19)
                {
                    var height = (58 + (59 * (19 - 19))) + (19 - 19);
                    var top = (60 * (19 - 8)); // Start hour appointment - start hour of the agenda (which is 08:00).

                    appointment[0] = "<div data-remodal-target=\"appointment-remodal\" class=\"appointment red-bg\" style=\"height: {0}px; top: {1}px;\">".FormatString(height, top) +
                        "<dl><dt>Activiteit</dt><dd><p>Tijdstip: Van 19:00 tot 20:00 uur.</p></dd><dd><p>Waar: De woonkamer.<p></dd><dd><p>Omschrijving: Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum porttitor sollicitudin volutpat. Nulla consectetur neque id nulla dignissim, ac faucibus velit posuere.<p></dd></dl>"
                        + "</div>";
                }

                this._agendaDay.Rows.Add(appointment);
            }

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

                for (int j = 8; j <= 23; j++)
                {
                    DataRow appointment;
                    appointment = this._agendaWeekAppointments.NewRow();

                    // 10:00 tot :12:00
                    if (j == 10)
                    {
                        var height = (58 + (59 * (12 - 10))) + (12 - 10);
                        var top = (60 * (10 - 8)); // Start hour appointment - start hour of the agenda (which is 08:00).

                        appointment[0] = "<div data-remodal-target=\"appointment-remodal\" class=\"appointment red-bg\" style=\"height: {0}px; top: {1}px;\">".FormatString(height, top) +
                            "<dl><dt>Afspraak fysio</dt><dd><p>Tijdstip: Van 10:00 tot 12:00 uur.</p></dd><dd><p>Waar: Ruimte A.<p></dd><dd><p>Omschrijving: Maecenas convallis nisi at turpis auctor, aliquet molestie felis blandit.<p></dd></dl>"
                            + "</div>";
                    }
                    //// 11:00 tot 15:00
                    //if (j == 11)
                    //{
                    //    var height = (58 + (59 * (15 - 11))) + (15 - 11);
                    //    var top = (60 * (11 - 8)); // Start hour appointment - start hour of the agenda (which is 08:00).

                    //    appointment[0] = "<div data-remodal-target=\"appointment-remodal\" class=\"appointment red-bg\" style=\"height: {0}px; top: {1}px;\">".FormatString(height, top) +
                    //        "<dl><dt>Activiteit</dt><dd><p>Tijdstip: Van 11:00 tot 15:00 uur.</p></dd><dd><p>Waar: De woonkamer.<p></dd><dd><p>Omschrijving: Nulla mattis tellus vel est pellentesque dapibus. Pellentesque ornare lobortis pellentesque.<p></dd></dl>"
                    //        + "</div>";
                    //}
                    // 14:00 tot 17:00
                    if (j == 14)
                    {
                        var height = (58 + (59 * (17 - 14))) + (17 - 14);
                        var top = (60 * (14 - 8)); // Start hour appointment - start hour of the agenda (which is 08:00).

                        appointment[0] = "<div data-remodal-target=\"appointment-remodal\" class=\"appointment red-bg\" style=\"height: {0}px; top: {1}px;\">".FormatString(height, top) +
                            "<dl><dt>Familiebezoek</dt><dd><p>Tijdstip: Van 14:00 tot 17:00 uur.</p></dd><dd><p>Waar: De woonkamer.<p></dd><dd><p>Omschrijving: Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum porttitor sollicitudin volutpat. Nulla consectetur neque id nulla dignissim, ac faucibus velit posuere.<p></dd></dl>"
                            + "</div>";
                    }
                    // 19:00 tot 19:00
                    if (j == 19)
                    {
                        var height = (58 + (59 * (19 - 19))) + (19 - 19);
                        var top = (60 * (19 - 8)); // Start hour appointment - start hour of the agenda (which is 08:00).

                        appointment[0] = "<div data-remodal-target=\"appointment-remodal\" class=\"appointment red-bg\" style=\"height: {0}px; top: {1}px;\">".FormatString(height, top) +
                            "<dl><dt>Activiteit</dt><dd><p>Tijdstip: Van 19:00 tot 20:00 uur.</p></dd><dd><p>Waar: De woonkamer.<p></dd><dd><p>Omschrijving: Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum porttitor sollicitudin volutpat. Nulla consectetur neque id nulla dignissim, ac faucibus velit posuere.<p></dd></dl>"
                            + "</div>";
                    }

                    this._agendaWeekAppointments.Rows.Add(appointment);
                }

                Repeater childRepeater = (Repeater)args.Item.FindControl("_repAgendaWeekChild");
                childRepeater.DataSource = this._agendaWeekAppointments;
                childRepeater.DataBind();

                this._agendaWeekAppointments.Clear();
            }
        }

        #endregion
    }
}