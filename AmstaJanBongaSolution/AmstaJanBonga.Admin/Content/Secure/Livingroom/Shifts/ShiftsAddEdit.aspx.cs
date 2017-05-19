using AmstaJanBonga.Admin.Content.Controls.JsListBox;
using AmstaJanBonga.Business.CollectionClasses;
using AmstaJanBonga.Business.Database.Managers;
using AmstaJanBonga.Business.Database.Readers;
using AmstaJanBonga.Business.EntityClasses;
using AmstaJanBonga.Business.Enums;
using Rlaan.Toolkit.Extensions;
using Rlaan.Toolkit.Web;
using System;
using System.Collections.Generic;

namespace AmstaJanBonga.Admin.Content.Secure.Livingroom.Shifts
{
    public partial class ShiftsAddEdit : SecurePage
    {
        #region Variables & Objects

        private LivingRoomEntity _livingroom = null;

        private LivingRoomShiftEventCollection _shifts = null;

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

        private LivingRoomShiftEventCollection Shifts
        {
            get
            {
                if (this._shifts == null && this.HasLivingRoomId && this.HasDate)
                {
                    // Gets all shifts for a specific livingroom and date.
                    this._shifts = LivingRoomShiftEventReader.GetAllShiftsFilteredByLivingroomAndDate(this.Livingroom.Id, this.QueryStringDate.Date);
                }

                return this._shifts;
            }
            set
            {
                this._shifts = value;
            }
        }

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.PreFill();

                this._hlReturn.NavigateUrl = "~/Content/Secure/Livingroom/Shifts/ShiftsOverview.aspx?LivingRoomId={0}".FormatString(this.Livingroom.Id);
            }
        }

        #region PreFill

        private void PreFill()
        {
            if (this.HasLivingRoomId)
            {
                // Gets all the employees for a specific livingroom.
                var employees = EmployeeReader.GetAllEmployeesByLivingRoomId(this.Livingroom.Id);

                // Edit
                if (this.HasDate)
                {
                    // Sets the date.
                    this.ExtendedCalendar.SelectedDate = this.QueryStringDate.Date;
                    this.ExtendedCalendar.Visible = false;

                    // Shows the date.
                    this._txtDate.Text = this.ExtendedCalendar.SelectedDate.Date.ToString("dd-MM-yyyy");
                    this._txtDate.Visible = true;

                    // Sets the livingroom name.
                    this._txtLivingroom.Text = this.Livingroom.Name;

                    // Fills the list boxes.
                    this.PreFillListBox(this.Shifts, employees, this._jlbDay, ShiftTypeEnum.Day);
                    this.PreFillListBox(this.Shifts, employees, this._jlbEvening, ShiftTypeEnum.Evening);
                }
                // Add
                else
                {
                    this._txtLivingroom.Text = Livingroom.Name;

                    // Morning
                    this._jlbDay.DataSource = employees;
                    this._jlbDay.DataTextField = "FirstName";
                    this._jlbDay.DataValueField = "Id";
                    this._jlbDay.DataBind();

                    // Evening
                    this._jlbEvening.DataSource = employees;
                    this._jlbEvening.DataTextField = "FirstName";
                    this._jlbEvening.DataValueField = "Id";
                    this._jlbEvening.DataBind();
                }
            }
        }

        private void PreFillListBox(LivingRoomShiftEventCollection shifts, EmployeeCollection employees, JsListBox listBox, ShiftTypeEnum shiftTypeEnum)
        {
            // The shift source and destination data.
            var shiftSourceData = new EmployeeCollection();
            var shiftDestinationData = new EmployeeCollection(); ;

            foreach (var shift in shifts)
            {
                if (shift.ShiftTypeEnum == (byte)shiftTypeEnum)
                {
                    foreach (var employee in employees)
                    {
                        if (shift.Employee.Id == employee.Id)
                        {
                            shiftDestinationData.Add(employee);
                        }
                    }
                }
            }

            // Adds the source data.
            shiftSourceData.AddRange(employees);
            shiftSourceData.RemoveRange(shiftDestinationData);

            // Binds the source and destination data with its value fields.
            listBox.DataSource = shiftSourceData;
            listBox.DataDestination = shiftDestinationData;
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
                    // Updates multiple shifts at once.
                    LivingRoomShiftEventManager.UpdateMulti(this.Shifts, this.GetSelectedEmployees());
                }
                // Add
                else
                {
                    // Inserts multiple shifts at once.
                    LivingRoomShiftEventManager.InsertMulti(this.GetSelectedEmployees());
                }
            }
        }

        private LivingRoomShiftEventCollection GetSelectedEmployees()
        {
            var shifts = new LivingRoomShiftEventCollection();

            // Day
            for (int i = 0; i < _jlbDay.ListBoxDestination.Items.Count; i++)
                shifts.Add(LivingRoomShiftEventManager.CreateLivingroomShiftEventEntity(this._jlbDay.ListBoxDestination.Items[i].Value.ToInt(), Livingroom.Id, this.ExtendedCalendar.SelectedDate, ShiftTypeEnum.Day));

            // Evening
            for (int i = 0; i < _jlbEvening.ListBoxDestination.Items.Count; i++)
                shifts.Add(LivingRoomShiftEventManager.CreateLivingroomShiftEventEntity(this._jlbEvening.ListBoxDestination.Items[i].Value.ToInt(), Livingroom.Id, this.ExtendedCalendar.SelectedDate, ShiftTypeEnum.Evening));

            return shifts;
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
            this.Page.Validate("Validate");

            if (this.Page.IsValid)
            {
                this.Save();

                Response.Redirect("~/Content/Secure/Livingroom/Shifts/ShiftsOverview.aspx?LivingRoomId={0}".FormatString(this.Livingroom.Id));
            }
        }

        protected void _btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Content/Secure/Livingroom/Shifts/ShiftsOverview.aspx?LivingRoomId={0}".FormatString(this.Livingroom.Id));
        }

        #endregion
    }
}