using AmstaJanBonga.Web.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AmstaJanBonga.Web.Content.PatientAgendaOverview
{
    public partial class PatientAgendaOverview : DefaultPage
    {
        DataTable patients = new DataTable("Patients");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
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
        }

        protected override void OnPreRender(EventArgs e)
        {
            this.MasterPage.ChangeBackgroundColour("green-bg");

            base.OnPreRender(e);
        }
    }
}