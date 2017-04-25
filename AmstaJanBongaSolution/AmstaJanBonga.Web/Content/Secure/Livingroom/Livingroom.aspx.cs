using AmstaJanBonga.Business.CollectionClasses;
using AmstaJanBonga.Business.Database.Managers;
using AmstaJanBonga.Business.Database.Readers;
using AmstaJanBonga.Business.Enums;
using Rlaan.Toolkit.Extensions;
using Rlaan.Toolkit.Web;
using System;
using System.ComponentModel;
using System.Data;
using System.Threading;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using System.Web.UI.WebControls;

namespace AmstaJanBonga.Web.Content
{
    public partial class Home : SecurePage
    {
        #region Variables & Objects

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
                this.DatabindEmployees();
                this.DatabindPatients();
                this.DatabindChores();
            }
        }

        #region Methods

        private void DatabindEmployees()
        {

        }

        public void DatabindPatients()
        {
            this._repPatients.DataSource = this.Patients;
            this._repPatients.DataBind();

            // Excluding a patient
            //for (int i = 0; i < source.Count; i++)
            //{
            //    if (source[i].Id == patientIdToExclude)
            //    {
            //        source.Remove(source[i]);
            //        break;
            //    }
            //}
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

        protected void _lbPatient_Click(object sender, EventArgs e)
        {
            var linkButton = (LinkButton)sender;

            var values = this._hfPatient.Value.Split('-');

            var timeOfDay = (TimeOfDayTypeEnum)Enum.Parse(typeof(TimeOfDayTypeEnum), values[1]);

            var oldChore = ChoreManager.CreateChoreEntity(values[0].ToInt(), Helper.LIVINGROOM_STIMULATE, DateTime.Now, timeOfDay);
            var newChore = ChoreManager.CreateChoreEntity(linkButton.CommandArgument.ToInt(), Helper.LIVINGROOM_STIMULATE, DateTime.Now, timeOfDay);

            ChoreManager.UpdateChore(oldChore, newChore);
        }
    }
}