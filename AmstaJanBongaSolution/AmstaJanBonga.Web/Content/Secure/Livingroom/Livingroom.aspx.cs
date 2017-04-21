using AmstaJanBonga.Business.CollectionClasses;
using AmstaJanBonga.Business.Database.Readers;
using AmstaJanBonga.Business.Enums;
using Rlaan.Toolkit.Extensions;
using System;
using System.Data;

namespace AmstaJanBonga.Web.Content
{
    public partial class Home : SecurePage
    {
        private DataTable employees = new DataTable("Employees");
        private DataTable patients = new DataTable("Patients");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.DatabindEmployees();
                this.DatabindPatients();
                this.DatabindChores();
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

        private void DatabindChores()
        {
            var chores = ChoreReader.GetAllChoresFilteredByLivingroomAndDate(Helper.LIVINGROOM_STIMULATE, DateTime.Now);

            var morning = new ChoreCollection();
            var afternoon = new ChoreCollection();
            var evening = new ChoreCollection();

            foreach (var chore in chores)
            {
                if (chore.TimeOfDayTypeEnum == (byte)TimeOfDayTypeEnum.Morning)
                {
                    morning.Add(chore);
                }
                else if (chore.TimeOfDayTypeEnum == (byte)TimeOfDayTypeEnum.Afternoon)
                {
                    afternoon.Add(chore);
                }
                else if (chore.TimeOfDayTypeEnum == (byte)TimeOfDayTypeEnum.Evening)
                {
                    evening.Add(chore);
                }
                else
                {
                    throw new NotImplementedException("Nothing for for {0} in TimeOfDayTypeEnum.".FormatString(chore.TimeOfDayTypeEnum));
                }
            }

            this._repChoreMorning.DataSource = morning;
            this._repChoreMorning.DataBind();

            this._repChoreAfternoon.DataSource = afternoon;
            this._repChoreAfternoon.DataBind();

            this._repChoreEvening.DataSource = evening;
            this._repChoreEvening.DataBind();
        }

        #endregion
    }
}