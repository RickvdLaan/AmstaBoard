using Rlaan.Toolkit.Extensions;
using Rlaan.Toolkit.Web;
using System;

namespace AmstaJanBonga.Admin.Content.Secure.Livingroom.General
{
    public partial class GeneralAddEdit : SecurePage
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

        private bool HasLivingroomId
        {
            get { return Url.QueryStringParser.HasParameter("LivingroomId"); }
        }

        private bool HasDate
        {
            get { return Url.QueryStringParser.HasParameter("Date"); }
        }

        private int LivingroomId
        {
            get
            {
                if (this.HasLivingroomId)
                    this._livingroomId = Url.QueryStringParser.GetInt("LivingroomId");

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

                this._hlReturn.NavigateUrl = "~/Content/Secure/Livingroom/General/GeneralOverview.aspx?LivingroomId={0}".FormatString(this.LivingroomId);
            }
        }

        #region PreFill

        private void PreFill()
        {
            if (this.HasLivingroomId)
            {
                // Edit
                if (this.HasDate)
                {
                    // Sets the date.
                    this.ExtendedCalendar.SelectedDate = this.QueryStringDate.Date;
                    this.ExtendedCalendar.Visible = false;

                    // Shows the date.
                    this._txtDate.Text = this.ExtendedCalendar.SelectedDate.Date.ToString("dd-MM-yyyy");
                    this._txtDate.Visible = true;
                }
                // Add
                else
                {

                }
            }
        }

        #endregion

        #region Methods

        private void Save()
        {

        }

        #endregion

        #region Events

        protected void _btnSave_Click(object sender, EventArgs e)
        {
            this.Page.Validate("Validate");

            if (this.Page.IsValid)
            {
                this.Save();

                Response.Redirect("~/Content/Secure/Livingroom/General/GeneralOverview.aspx?LivingroomId={0}".FormatString(this.LivingroomId));
            }
        }

        protected void _btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Content/Secure/Livingroom/General/GeneralOverview.aspx?LivingroomId={0}".FormatString(this.LivingroomId));
        }

        #endregion
    }
}