using AmstaJanBonga.Web.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AmstaJanBonga.Web.Content
{
    public partial class Home : DefaultPage
    {
        private DataTable employees = new DataTable("Employees");
        private DataTable patients = new DataTable("Patients");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.DatabindEmployees();
                this.DatabindPatients();
            }
        }

        #region Methods

        private void DatabindEmployees()
        {
            employees.Columns.Add("Name");

            for (int i = 0; i <= 4; i++)
            {
                DataRow workRow;
                workRow = employees.NewRow();
                workRow[0] = "Voornaam-" + i;
                employees.Rows.Add(workRow);
            }

            this._repEmployees.DataSource = employees;
            this._repEmployees.DataBind();
        }

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