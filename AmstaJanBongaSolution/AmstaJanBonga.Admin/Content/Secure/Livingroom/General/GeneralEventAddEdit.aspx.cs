using AmstaJanBonga.Business.Database.Managers;
using AmstaJanBonga.Business.Database.Readers;
using Rlaan.Toolkit.Extensions;
using Rlaan.Toolkit.Web;
using System;

namespace AmstaJanBonga.Admin.Content.Secure.Livingroom.General
{
    public partial class GeneralEventAddEdit : SecurePage
    {
        #region Variables & Objects

        private int _livingroomId = -1;

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

        private int LivingRoomId
        {
            get
            {
                if (this.HasLivingRoomId)
                    this._livingroomId = Url.QueryStringParser.GetInt("LivingRoomId");

                return this._livingroomId;
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

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.PreFill();

                this._hlReturn.NavigateUrl = "~/Content/Secure/Livingroom/General/GeneralOverview.aspx?LivingRoomId={0}".FormatString(this.LivingRoomId);
            }
        }

        #region PreFill

        private void PreFill()
        {
            if (this.HasLivingRoomId)
            {
                var livingroomGeneral = LivingRoomGeneralReader.GetLivingroomGeneralById(this.LivingRoomId, true);

                // Edit
                if (this.HasDate)
                {
                    var livingroomGeneralEvent = LivingRoomGeneralEventReader.GetLivingroomGeneralByLivingRoomIdAndDate(this.LivingRoomId, this.QueryStringDate.Date, true);

                    // Sets the date.
                    this.ExtendedCalendar.SelectedDate = this.QueryStringDate.Date;
                    this.ExtendedCalendar.Visible = false;

                    // Shows the date.
                    this._txtDate.Text = this.ExtendedCalendar.SelectedDate.Date.ToString("dd-MM-yyyy");
                    this._txtDate.Visible = true;

                    // Sets the descriptions.
                    this._txtGeneral.Text = livingroomGeneral.Description.Replace("<br />", Environment.NewLine);
                    this._txtGeneralEvent.Text = livingroomGeneralEvent.Description.Replace("<br />", Environment.NewLine);
                }
                // Add
                else
                {
                    this._txtGeneral.Text = livingroomGeneral.Description.Replace("<br />", Environment.NewLine);
                }
            }
        }

        #endregion

        #region Methods

        private void Save()
        {
            if (this.HasLivingRoomId)
            {
                var general = Server.HtmlEncode(this._txtGeneral.Text).Replace(Environment.NewLine, "<br />");
                var generalEvent = Server.HtmlEncode(this._txtGeneralEvent.Text).Replace(Environment.NewLine, "<br />");

                // Edit (Update)
                if (this.HasDate)
                {
                    LivingroomGeneralEventManager.Update(this.LivingRoomId, this.ExtendedCalendar.SelectedDate.Date, generalEvent);
                }
                // Add (Insert)
                else
                {
                    LivingroomGeneralEventManager.Insert(this.LivingRoomId, this.ExtendedCalendar.SelectedDate.Date, generalEvent);
                }

                // This one needs to be updated/inserted regardless.
                LivingroomGeneralManager.InsertOrUpdate(this.LivingRoomId, string.IsNullOrWhiteSpace(general) ? null : general);
            }
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

                Response.Redirect("~/Content/Secure/Livingroom/General/GeneralOverview.aspx?LivingRoomId={0}".FormatString(this.LivingRoomId));
            }
        }

        protected void _btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Content/Secure/Livingroom/General/GeneralOverview.aspx?LivingRoomId={0}".FormatString(this.LivingRoomId));
        }

        #endregion
    }
}