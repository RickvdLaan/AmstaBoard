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

        private string _emptyPatientDiv = "<li><div style='display: inline-table; background-color: #f4f4f4; opacity: 0.75;' class='image image-chores' data-remodal-target='chores-remodal' onclick='HiddenFieldPatient(-1, {0})'><i class='fa fa-plus' style='color: #009eed; display: table-cell; font-size: 52px; text-align: center; vertical-align: middle;' aria-hidden='true'></i></div></li>";

        private PatientCollection _patients = null;

        #endregion

        #region Properties

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
            set
            {
                this._patients = value;
            }
        }

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.DatabindPatients();
                this.DatabindChores();
                this.DatabindGeneral();
            }
        }

        #region Methods

        public void DatabindPatients()
        {
            this._repPatients.DataSource = this.Patients;
            this._repPatients.DataBind();
        }

        private void DatabindGeneral()
        {
            var general = LivingroomGeneralEventReader.GetLivingroomGeneralByIdAndDate(Helper.LIVINGROOM_STIMULATE, DateTime.Now, false);

            if (general != null)
            {
                if (!string.IsNullOrWhiteSpace(general.LivingroomGeneral.Description))
                {
                    this._litGeneral.Text += general.LivingroomGeneral.Description;
                    this._litGeneral.Text += "<br /><br />";
                }

                this._litGeneral.Text += general.Description;
            }
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

        protected void _repChoreMorning_DataBinding(object sender, EventArgs e)
        {
            var dataSource = ((Repeater)sender).DataSource as LivingroomChoreEventCollection;
            var count = dataSource.Count;

            if (count < 2)
            {
                switch (count)
                {
                    case 0:
                        _litChoreMorning.Text = this._emptyPatientDiv.FormatString((byte)TimeOfDayTypeEnum.Morning);
                        _litChoreMorning.Text += this._emptyPatientDiv.FormatString((byte)TimeOfDayTypeEnum.Morning);
                        _litChoreMorning.Visible = true;
                        break;
                    case 1:
                        _litChoreMorning.Text = this._emptyPatientDiv.FormatString((byte)TimeOfDayTypeEnum.Morning);
                        _litChoreMorning.Visible = true;
                        break;
                    default:
                        throw new NotImplementedException();
                }
            }
            else
            {
                _litChoreMorning.Visible = false;
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
                        _litChoreAfternoon.Text = this._emptyPatientDiv.FormatString((byte)TimeOfDayTypeEnum.Afternoon);
                        _litChoreAfternoon.Text += this._emptyPatientDiv.FormatString((byte)TimeOfDayTypeEnum.Afternoon);
                        _litChoreAfternoon.Visible = true;
                        break;
                    case 1:
                        _litChoreAfternoon.Text = this._emptyPatientDiv.FormatString((byte)TimeOfDayTypeEnum.Afternoon);
                        _litChoreAfternoon.Visible = true;
                        break;
                    default:
                        throw new NotImplementedException();
                }
            }
            else
            {
                _litChoreAfternoon.Visible = false;
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
                        _litChoreEvening.Text = this._emptyPatientDiv.FormatString((byte)TimeOfDayTypeEnum.Evening);
                        _litChoreEvening.Text += this._emptyPatientDiv.FormatString((byte)TimeOfDayTypeEnum.Evening);
                        _litChoreEvening.Visible = true;
                        break;
                    case 1:
                        _litChoreEvening.Text = this._emptyPatientDiv.FormatString((byte)TimeOfDayTypeEnum.Evening);
                        _litChoreEvening.Visible = true;
                        break;
                    default:
                        throw new NotImplementedException();
                }
            }
            else
            {
                _litChoreEvening.Visible = false;
            }
        }

        #endregion
    }
}