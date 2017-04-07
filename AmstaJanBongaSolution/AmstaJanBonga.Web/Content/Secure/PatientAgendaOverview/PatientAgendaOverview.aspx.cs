using System;
using System.Data;

namespace AmstaJanBonga.Web.Content.PatientAgendaOverview
{
    public partial class PatientAgendaOverview : SecurePage
    {
        DataTable patients = new DataTable("Patients");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.DatabindPatients();
            }
        }

        protected override void OnPreRender(EventArgs e)
        {
            this.MasterPage.AddClassToContent("green-bg");

            base.OnPreRender(e);
        }

        #region Methods

        private void DatabindPatients()
        {
            patients.Columns.Add("Name");

            for (int i = 0; i <= 9; i++)
            {
                DataRow workRow;
                workRow = patients.NewRow();
                workRow[0] = "Voornaam-" + i;
                patients.Rows.Add(workRow);
            }

            this._repPatients.DataSource = patients;
            this._repPatients.DataBind();
        }

        #endregion
    }
}