using AmstaJanBonga.Business.Database.Readers;
using AmstaJanBonga.Business.EntityClasses;
using Rlaan.Toolkit.Web;
using Rlaan.Toolkit.Extensions;
using System;

namespace AmstaJanBonga.Admin.Content.Secure.Livingroom.Chores
{
    public partial class ChoresDetails : SecurePage
    {
        #region Variables & Objects

        private DateTime _date = DateTime.MinValue;

        private LivingroomEntity _livingroom = null;

        #endregion

        #region Properties

        private bool HasDate
        {
            get { return Url.QueryStringParser.HasParameter("LivingroomId"); } 
        }

        private bool HasLivingroomId
        {
            get { return Url.QueryStringParser.HasParameter("LivingroomId"); }
        }

        private DateTime Date
        {
            get
            {
                if (this._date == DateTime.MinValue && this.HasDate)
                {
                    this._date = Url.QueryStringParser.GetDateTime("Date");
                }

                return this._date;
            }
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

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.PreFill();

                this._hlEdit.NavigateUrl = "";
                this._hlReturn.NavigateUrl = "~/Content/Secure/Livingroom/Chores/ChoresOverview.aspx?LivingroomId={0}".FormatString(this.Livingroom.Id);
            }
        }

        #region PreFill

        private void PreFill()
        {
            if (this.HasLivingroomId && this.HasDate)
            {
                this._lblDate.Text = this.Date.ToString("dd-MM-yyyy");
                this._lblLivingroom.Text = this.Livingroom.Name;
                this._lblMorning.Text = string.Empty;
                this._lblAfternoon.Text = string.Empty;
                this._lblEvening.Text = string.Empty;
            }
        }

        #endregion
    }
}