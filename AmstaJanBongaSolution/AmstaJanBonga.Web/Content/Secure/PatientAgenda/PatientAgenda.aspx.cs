using AmstaJanBonga.Business.Database.Readers;
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

        private PatientEntity _patient = null;

        private DataTable _agendaTime = new DataTable("AgendaTime");

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
            this._repAgendaDay.DataSource = null;
            this._repAgendaDay.DataBind();
        }

        private void DatabindAgendaWeek()
        {
            this._repAgendaWeek.DataSource = null;
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