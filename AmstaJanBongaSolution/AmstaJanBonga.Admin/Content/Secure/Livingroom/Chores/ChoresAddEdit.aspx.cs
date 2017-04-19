using AmstaJanBonga.Business.Database.Managers;
using AmstaJanBonga.Business.Database.Readers;
using AmstaJanBonga.Business.EntityClasses;
using Rlaan.Toolkit.Web;
using Rlaan.Toolkit.Extensions;
using System;
using AmstaJanBonga.Business.Enums;
using System.Collections.Generic;

namespace AmstaJanBonga.Admin.Content.Secure.Livingroom.Chores
{
    public partial class ChoresAddEdit : SecurePage
    {
        #region Variables & Objects

        private List<DateTime> _dates = null;

        private LivingroomEntity _livingroom = null;

        #endregion

        #region Properties

        private bool HasLivingroomId
        {
            get { return Url.QueryStringParser.HasParameter("LivingroomId"); }
        }

        private LivingroomEntity Livingroom
        {
            get
            {
                if (this._livingroom == null && this.HasLivingroomId)
                {
                    this._livingroom = LivingroomReader.GetLivingroomById(Url.QueryStringParser.GetInt("LivingroomId"), true);
                }

                return this._livingroom;
            }
        }

        private List<DateTime> Dates
        {
            get { return this._dates; }
            set { this._dates = value; }
        }

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.PreFill();

                this._hlReturn.NavigateUrl = "~/Content/Secure/Livingroom/Chores/ChoresOverview.aspx?LivingroomId={0}".FormatString(this.Livingroom.Id);
            }
        }

        #region Overrides

        protected override void OnPreRenderComplete(EventArgs e)
        {
            this.Dates = ChoreReader.GetAllUsedDatesByLivingroomId(this.Livingroom.Id);

            base.OnPreRenderComplete(e);
        }

        #endregion

        #region PreFill

        private void PreFill()
        {
            if (HasLivingroomId)
            {
                var dataSource = PatientReader.GetAllPatientsByLivingroomId(this.Livingroom.Id);

                this._txtLivingroom.Text = Livingroom.Name;

                // Morning
                this._jlbMorning.DataSource = dataSource;
                this._jlbMorning.DataTextField = "FirstName";
                this._jlbMorning.DataValueField = "Id";
                this._jlbMorning.DataBind();

                // Afternoon
                this._jlbAfternoon.DataSource = dataSource;
                this._jlbAfternoon.DataTextField = "FirstName";
                this._jlbAfternoon.DataValueField = "Id";
                this._jlbAfternoon.DataBind();

                // Evening
                this._jlbEvening.DataSource = dataSource;
                this._jlbEvening.DataTextField = "FirstName";
                this._jlbEvening.DataValueField = "Id";
                this._jlbEvening.DataBind();
            }
        }

        #endregion

        #region Save

        private void Save()
        {
            // Inserts multiple chores at once.
            ChoreManager.InsertMulti(
                // Morning
                ChoreManager.CreateChoreEntity(this._jlbMorning.ListBoxDestination.Items[0].Value.ToInt(), Livingroom.Id, this._calendar.SelectedDate, TimeOfDayTypeEnum.MorningOne),
                ChoreManager.CreateChoreEntity(this._jlbMorning.ListBoxDestination.Items[1].Value.ToInt(), Livingroom.Id, this._calendar.SelectedDate, TimeOfDayTypeEnum.MorningTwo),
                // Afternoon
                ChoreManager.CreateChoreEntity(this._jlbAfternoon.ListBoxDestination.Items[0].Value.ToInt(), Livingroom.Id, this._calendar.SelectedDate, TimeOfDayTypeEnum.AfternoonOne),
                ChoreManager.CreateChoreEntity(this._jlbAfternoon.ListBoxDestination.Items[1].Value.ToInt(), Livingroom.Id, this._calendar.SelectedDate, TimeOfDayTypeEnum.AfternoonTwo),
                // Evening
                ChoreManager.CreateChoreEntity(this._jlbEvening.ListBoxDestination.Items[0].Value.ToInt(), Livingroom.Id, this._calendar.SelectedDate, TimeOfDayTypeEnum.EveningOne),
                ChoreManager.CreateChoreEntity(this._jlbEvening.ListBoxDestination.Items[1].Value.ToInt(), Livingroom.Id, this._calendar.SelectedDate, TimeOfDayTypeEnum.EveningTwo)
            );
        }

        #endregion

        #region Events

        protected void _btnSave_Click(object sender, EventArgs e)
        {
            this.Page.Validate("Validate");

            if (this.Page.IsValid)
            {
                this.Save();

                Response.Redirect("~/Content/Secure/Livingroom/Chores/ChoresOverview.aspx?LivingroomId={0}".FormatString(this.Livingroom.Id));
            }
        }

        protected void _btnCancel_Click(object sender, EventArgs e)
        {

        }

        protected void _calendar_DayRender(object sender, System.Web.UI.WebControls.DayRenderEventArgs e)
        {
            if (e.Day.IsOtherMonth)
            {
                e.Cell.Text = string.Empty;
            }

            foreach (var date in this.Dates)
            {
                if (e.Day.Date == date)
                {
                    e.Day.IsSelectable = false;
                    e.Cell.CssClass = "calendar-unavailable";
                    //this.Dates.Remove(date);
                }
            }
        }

        #endregion
    }
}