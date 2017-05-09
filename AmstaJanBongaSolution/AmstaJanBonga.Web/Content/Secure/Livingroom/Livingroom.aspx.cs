using AmstaJanBonga.Business.CollectionClasses;
using AmstaJanBonga.Business.Database.Managers;
using AmstaJanBonga.Business.Database.Readers;
using AmstaJanBonga.Business.Enums;
using Rlaan.Toolkit.Extensions;
using System;
using System.Web.UI.WebControls;

namespace AmstaJanBonga.Web.Content
{
    public partial class Home : SecurePage
    {
        #region Variables & Objects

        private string _emptyEmployeeDiv = "<li><div style='display: inline-table; background-color: #f4f4f4; opacity: 0.75;' class='image image-shifts' data-remodal-target='shift-remodal' onclick='HiddenFieldEmployee(-1, 0)'><i class='fa fa-plus' style='color: #683d84; display: table-cell; font-size: 3vw; text-align: center; vertical-align: middle;' aria-hidden='true'></i></div></li>";

        private string _emptyPatientDiv = "<li><div style='display: inline-table; background-color: #f4f4f4; opacity: 0.75;' class='image image-chores' data-remodal-target='chores-remodal' onclick='HiddenFieldPatient(-1, {0})'><i class='fa fa-plus' style='color: #009eed; display: table-cell; font-size: 3vw; text-align: center; vertical-align: middle;' aria-hidden='true'></i></div></li>";

        private EmployeeCollection _employees = null;

        private PatientCollection _patients = null;

        #endregion

        #region Properties

        private EmployeeCollection Employees
        {
            get
            {
                if (this._employees == null)
                {
                    this._employees = new EmployeeCollection();
                    this._employees = EmployeeReader.GetAllEmployeesByLivingroomId(Helper.LIVINGROOM_STIMULATE);
                }

                return this._employees;
            }
            set { this._employees = value; }
        }

        private PatientCollection Patients
        {
            get
            {
                if (this._patients == null)
                {   
                    this._patients = new PatientCollection();
                    this._patients = PatientReader.GetAllPatientsByLivingroomId(Helper.LIVINGROOM_STIMULATE);
                }

                return this._patients;
            }
            set { this._patients = value; }
        }

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Databinding the employees and patients.
                this.DatabindEmployees();
                this.DatabindPatients();

                // Databinding the chores and shifts.
                this.DatabindChores();
                this.DatabindShifts();

                // Databinding the general information.
                this.DatabindGeneral();
            }
        }

        #region Methods

        private void DatabindEmployees()
        {
            this._repEmployees.DataSource = this.Employees;
            this._repEmployees.DataBind();
        }

        private void DatabindPatients()
        {
            this._repPatients.DataSource = this.Patients;
            this._repPatients.DataBind();
        }

        private void DatabindGeneral()
        {
            var generalEvent = LivingroomGeneralEventReader.GetLivingroomGeneralByIdAndDate(Helper.LIVINGROOM_STIMULATE, DateTime.Now, false);

            if (generalEvent != null)
            {
                if (!string.IsNullOrWhiteSpace(generalEvent.LivingroomGeneral.Description))
                {
                    this._litGeneral.Text += generalEvent.LivingroomGeneral.Description;
                    this._litGeneral.Text += "<br /><br />";
                }

                this._litGeneral.Text += generalEvent.Description;
            }
            // No date was added, so trying again.
            else
            {
                var general = LivingroomGeneralReader.GetLivingroomGeneralById(Helper.LIVINGROOM_STIMULATE, false);

                if (general != null && !string.IsNullOrWhiteSpace(general.Description))
                    this._litGeneral.Text += general.Description;
            }
        }

        private void DatabindShifts()
        {
            var dataSource = LivingroomShiftEventReader.GetAllShiftsFilteredByLivingroomAndDate(Helper.LIVINGROOM_STIMULATE, DateTime.Now);

            var dataSourceDay = new LivingroomShiftEventCollection();
            var dataSourceEvening = new LivingroomShiftEventCollection();

            for (int i = 0; i < dataSource.Count; i++)
            {
                if (dataSource[i].ShiftTypeEnum == (byte)ShiftTypeEnum.Day)
                    dataSourceDay.Add(dataSource[i]);
                else
                    dataSourceEvening.Add(dataSource[i]);
            }

            this._repEmployeeShiftsDay.DataSource = dataSourceDay;
            this._repEmployeeShiftsDay.DataBind();
        }

        private void DatabindChores()
        {
            var chores = LivingroomChoreEventReader.GetAllChoresFilteredByLivingroomAndDate(Helper.LIVINGROOM_STIMULATE, DateTime.Now);

            var morning = new LivingroomChoreEventCollection();
            var afternoon = new LivingroomChoreEventCollection();
            var evening = new LivingroomChoreEventCollection();

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
                    throw new NotImplementedException("Nothing found for {0} in TimeOfDayTypeEnum.".FormatString(chore.TimeOfDayTypeEnum));
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

        #region Events

        // Employees (Shifts)

        protected void _lbEmployee_Click(object sender, EventArgs e)
        {
            var linkButton = (LinkButton)sender;

            var values = this._hfEmployee.Value.Split('_');

            var shiftType = (ShiftTypeEnum)Enum.Parse(typeof(ShiftTypeEnum), values[1]);

            var oldShift = LivingroomShiftEventReader.GetShiftByIds(values[0].ToInt(), Helper.LIVINGROOM_STIMULATE, DateTime.Now, shiftType, true);
            var newShift = LivingroomShiftEventReader.GetShiftByIds(linkButton.CommandArgument.ToInt(), Helper.LIVINGROOM_STIMULATE, DateTime.Now, shiftType, false);

            LivingroomShiftEventManager.UpdateShift(oldShift, newShift);

            this.DatabindShifts();
        }

        // Patients (Chores)

        protected void _lbPatient_Click(object sender, EventArgs e)
        {
            var linkButton = (LinkButton)sender;

            var values = this._hfPatient.Value.Split('_');

            var timeOfDay = (TimeOfDayTypeEnum)Enum.Parse(typeof(TimeOfDayTypeEnum), values[1]);

            var oldChore = LivingroomChoreEventReader.GetChoreByIds(values[0].ToInt(), Helper.LIVINGROOM_STIMULATE, DateTime.Now, timeOfDay, true);
            var newChore = LivingroomChoreEventReader.GetChoreByIds(linkButton.CommandArgument.ToInt(), Helper.LIVINGROOM_STIMULATE, DateTime.Now, timeOfDay, false);

            LivingroomChoreEventManager.UpdateChore(oldChore, newChore);

            this.DatabindChores();
        }

        // Employees (Shifts)

        protected void _repEmployeeShiftsDay_DataBinding(object sender, EventArgs e)
        {
            // TODO: If two, show 2x add, if one, show 1x add.
            // Always show evening if not added. If added, dont show.
            var dataSource = ((Repeater)sender).DataSource as LivingroomShiftEventCollection;

            if (dataSource.Count < 2)
            {
                switch (dataSource.Count)
                {
                    case 0:
                    case 1:
                        this._litShift.Text = this._emptyEmployeeDiv;
                        this._litShift.Visible = true;
                        break;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        protected void _repChoreMorning_DataBinding(object sender, EventArgs e)
        {
            var dataSource = ((Repeater)sender).DataSource as LivingroomChoreEventCollection;

            if (dataSource.Count < 2)
            {
                switch (dataSource.Count)
                {
                    case 0:
                        this._litChoreMorning.Text = this._emptyPatientDiv.FormatString((byte)TimeOfDayTypeEnum.Morning);
                        this._litChoreMorning.Text += this._emptyPatientDiv.FormatString((byte)TimeOfDayTypeEnum.Morning);
                        this._litChoreMorning.Visible = true;
                        break;
                    case 1:
                        this._litChoreMorning.Text = this._emptyPatientDiv.FormatString((byte)TimeOfDayTypeEnum.Morning);
                        this._litChoreMorning.Visible = true;
                        break;
                    default:
                        throw new NotImplementedException();
                }
            }
            else
            {
                this._litChoreMorning.Visible = false;
            }
        }

        protected void _repChoreAfternoon_DataBinding(object sender, EventArgs e)
        {
            var dataSource = ((Repeater)sender).DataSource as LivingroomChoreEventCollection;
            var count = dataSource.Count;

            if (count < 2)
            {
                switch (count)
                {
                    case 0:
                        this._litChoreAfternoon.Text = this._emptyPatientDiv.FormatString((byte)TimeOfDayTypeEnum.Afternoon);
                        this._litChoreAfternoon.Text += this._emptyPatientDiv.FormatString((byte)TimeOfDayTypeEnum.Afternoon);
                        this._litChoreAfternoon.Visible = true;
                        break;
                    case 1:
                        this._litChoreAfternoon.Text = this._emptyPatientDiv.FormatString((byte)TimeOfDayTypeEnum.Afternoon);
                        this._litChoreAfternoon.Visible = true;
                        break;
                    default:
                        throw new NotImplementedException();
                }
            }
            else
            {
                this._litChoreAfternoon.Visible = false;
            }
        }

        protected void _repChoreEvening_DataBinding(object sender, EventArgs e)
        {
            var dataSource = ((Repeater)sender).DataSource as LivingroomChoreEventCollection;
            var count = dataSource.Count;

            if (count < 2)
            {
                switch (count)
                {
                    case 0:
                        this._litChoreEvening.Text = this._emptyPatientDiv.FormatString((byte)TimeOfDayTypeEnum.Evening);
                        this._litChoreEvening.Text += this._emptyPatientDiv.FormatString((byte)TimeOfDayTypeEnum.Evening);
                        this._litChoreEvening.Visible = true;
                        break;
                    case 1:
                        this._litChoreEvening.Text = this._emptyPatientDiv.FormatString((byte)TimeOfDayTypeEnum.Evening);
                        this._litChoreEvening.Visible = true;
                        break;
                    default:
                        throw new NotImplementedException();
                }
            }
            else
            {
                this._litChoreEvening.Visible = false;
            }
        }

        #endregion
    }
}