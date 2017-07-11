using AmstaJanBonga.Business.Database.Managers;
using AmstaJanBonga.Business.Database.Readers;
using AmstaJanBonga.Business.EntityClasses;
using Rlaan.Toolkit.Web;
using Rlaan.Toolkit.Extensions;
using System;
using AmstaJanBonga.Business.Enums;
using AmstaJanBonga.Business.CollectionClasses;
using AmstaJanBonga.Admin.Content.Controls.JsListBox;
using System.Collections.Generic;

namespace AmstaJanBonga.Admin.Content.Secure.Livingroom.Chores
{
    public partial class ChoresAddEdit : SecurePage
    {
        #region Variables & Objects

        private LivingRoomEntity _livingroom = null;

        private LivingRoomChoreEventCollection _chores = null;

        private DateTime _date = DateTime.MinValue;

        #endregion

        #region Properties

        /// <summary>
        /// Returns the Sub-title's value.
        /// </summary>
        protected string SubTitleAddEdit
        {
            get { return Url.GetFullUrl.Contains("&Date=") ? "Wijzigen" : "Toevoegen"; }
        }

        private bool HasLivingRoomId
        {
            get { return Url.QueryStringParser.HasParameter("LivingRoomId"); }
        }

        private bool HasDate
        {
            get { return Url.QueryStringParser.HasParameter("Date"); }
        }

        private LivingRoomEntity Livingroom
        {
            get
            {
                if (this._livingroom == null && this.HasLivingRoomId)
                    this._livingroom = LivingRoomReader.GetLivingRoomById(Url.QueryStringParser.GetInt("LivingRoomId"), true);
                
                return this._livingroom;
            }
        }

        private DateTime QueryStringDate
        {
            get
            {
                if (this._date == DateTime.MinValue && this.HasDate)
                    this._date = Url.QueryStringParser.GetDateTime("Date");

                return this._date;
            }
        }

        private LivingRoomChoreEventCollection Chores
        {
            get
            {
                if (this._chores == null && this.HasLivingRoomId && this.HasDate)
                {
                    // Gets all chores for a specific living room and date.
                    this._chores = LivingRoomChoreEventReader.GetAllChoresFilteredByLivingroomAndDate(this.Livingroom.Id, this.QueryStringDate.Date);
                }

                return this._chores;
            }
            set
            {
                this._chores = value;
            }
        }

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.PreFill();

                this._hlReturn.NavigateUrl = "~/Content/Secure/LivingRoom/Chores/ChoresOverview.aspx?LivingRoomId={0}".FormatString(this.Livingroom.Id);
            }
        }

        #region PreFill

        private void PreFill()
        {
            if (this.HasLivingRoomId)
            {
                // Gets all the patients for a specific living room.
                var patients = PatientReader.GetAllPatientsByLivingRoomId(this.Livingroom.Id);

                // Edit
                if (this.HasDate)
                {
                    // Sets the date.
                    this.ExtendedCalendar.SelectedDate = this.QueryStringDate.Date;
                    this.ExtendedCalendar.Visible = false;

                    // Shows the date.
                    this._txtDate.Text = this.ExtendedCalendar.SelectedDate.Date.ToString("dd-MM-yyyy");
                    this._txtDate.Visible = true;

                    // Sets the living room name.
                    this._txtLivingroom.Text = this.Livingroom.Name;

                    // Fills the list boxes.
                    this.PreFillListBox(this.Chores, patients, this._jlbMorning,   TimeOfDayTypeEnum.Morning);
                    this.PreFillListBox(this.Chores, patients, this._jlbAfternoon, TimeOfDayTypeEnum.Afternoon);
                    this.PreFillListBox(this.Chores, patients, this._jlbEvening,   TimeOfDayTypeEnum.Evening);
                }
                // Add
                else
                {
                    this._txtLivingroom.Text = Livingroom.Name;

                    // Morning
                    this._jlbMorning.DataSource = patients;
                    this._jlbMorning.DataTextField = "FirstName";
                    this._jlbMorning.DataValueField = "Id";
                    this._jlbMorning.DataBind();

                    // Afternoon
                    this._jlbAfternoon.DataSource = patients;
                    this._jlbAfternoon.DataTextField = "FirstName";
                    this._jlbAfternoon.DataValueField = "Id";
                    this._jlbAfternoon.DataBind();

                    // Evening
                    this._jlbEvening.DataSource = patients;
                    this._jlbEvening.DataTextField = "FirstName";
                    this._jlbEvening.DataValueField = "Id";
                    this._jlbEvening.DataBind();
                }
            }
        }

        private void PreFillListBox(LivingRoomChoreEventCollection chores, PatientCollection patients, JsListBox listBox, TimeOfDayTypeEnum timeOfDayType)
        {
            // The chore source and destination data.
            var choreSourceData = new PatientCollection();
            var choreDestinationData = new PatientCollection(); ;

            foreach (var chore in chores)
            {
                if (chore.TimeOfDayTypeEnum == (byte)timeOfDayType)
                {
                    foreach (var patient in patients)
                    {
                        if (chore.Patient.Id == patient.Id)
                        {
                            choreDestinationData.Add(patient);
                        }
                    }
                }
            }

            // Adds the source data.
            choreSourceData.AddRange(patients);
            choreSourceData.RemoveRange(choreDestinationData);

            // Binds the source and destination data with its value fields.
            listBox.DataSource = choreSourceData;
            listBox.DataDestination = choreDestinationData;
            listBox.DataTextField = "FirstName";
            listBox.DataValueField = "Id";

            // Binds the data.
            listBox.DataBind();
        }

        #endregion

        #region Methods

        private void Save()
        {
            if (this.HasLivingRoomId)
            {
                // Edit
                if (this.HasDate)
                {
                    // Updates multiple chores at once.
                    LivingRoomChoreEventManager.UpdateMulti(this.Chores, this.GetSelectedPatients());
                }
                // Add
                else
                {
                    // Inserts multiple chores at once.
                    LivingRoomChoreEventManager.InsertMulti(this.GetSelectedPatients());
                }
            }
        }

        private LivingRoomChoreEventCollection GetSelectedPatients()
        {
            var chores = new LivingRoomChoreEventCollection();

            // Morning
            for (int i = 0; i < _jlbMorning.ListBoxDestination.Items.Count; i++)
                chores.Add(LivingRoomChoreEventManager.CreateLivingRoomChoreEventEntity(this._jlbMorning.ListBoxDestination.Items[i].Value.ToInt(), Livingroom.Id, this.ExtendedCalendar.SelectedDate, TimeOfDayTypeEnum.Morning));

            // Afternoon
            for (int i = 0; i < _jlbAfternoon.ListBoxDestination.Items.Count; i++)
                chores.Add(LivingRoomChoreEventManager.CreateLivingRoomChoreEventEntity(this._jlbAfternoon.ListBoxDestination.Items[i].Value.ToInt(), Livingroom.Id, this.ExtendedCalendar.SelectedDate, TimeOfDayTypeEnum.Afternoon));

            // Evening
            for (int i = 0; i < _jlbEvening.ListBoxDestination.Items.Count; i++)
                chores.Add(LivingRoomChoreEventManager.CreateLivingRoomChoreEventEntity(this._jlbEvening.ListBoxDestination.Items[i].Value.ToInt(), Livingroom.Id, this.ExtendedCalendar.SelectedDate, TimeOfDayTypeEnum.Evening));

            return chores;
        }

        #endregion

        #region Custom Validator

        protected void Calendar_ServerValidate(object source, System.Web.UI.WebControls.ServerValidateEventArgs args)
        {
            args.IsValid = this.ExtendedCalendar.SelectedDate.Date >= DateTime.Now.Date;
        }

        #endregion

        #region Events

        protected void _btnSave_Click(object sender, EventArgs e)
        {
            if (this._jlbMorning.ListBoxDestination.Items.Count == 0 &&
                this._jlbAfternoon.ListBoxDestination.Items.Count == 0 &&
                this._jlbEvening.ListBoxDestination.Items.Count == 0)
            {
                this._lblError.Text = "Er moet minimaal één bewoner geselecteerd worden.";
                this._lblError.Visible = true;

                return;
            }

            this.Page.Validate("Validate");

            if (this.Page.IsValid)
            {
                this.Save();

                Response.Redirect("~/Content/Secure/LivingRoom/Chores/ChoresOverview.aspx?LivingRoomId={0}".FormatString(this.Livingroom.Id));
            }
        }

        protected void _btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Content/Secure/LivingRoom/Chores/ChoresOverview.aspx?LivingRoomId={0}".FormatString(this.Livingroom.Id));
        }

        #endregion
    }
}