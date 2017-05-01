using AmstaJanBonga.Business.Database.Readers;
using AmstaJanBonga.Business.EntityClasses;
using Rlaan.Toolkit.Extensions;
using Rlaan.Toolkit.Web;
using System;

namespace AmstaJanBonga.Admin.Content.Secure.Livingroom.General
{
    public partial class GeneralDetails : SecurePage
    {
        #region Variables & Objects

        private DateTime _date = DateTime.MinValue;

        private LivingroomEntity _livingroom = null;

        private LivingroomGeneralEventEntity _livingroomGeneralEvent = null;

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

        private DateTime QueryStringDate
        {
            get
            {
                if (this._date == DateTime.MinValue && this.HasDate)
                    this._date = Url.QueryStringParser.GetDateTime("Date");

                return this._date;
            }
        }

        private LivingroomEntity Livingroom
        {
            get
            {
                if (this._livingroom == null && this.HasLivingroomId)
                    this._livingroom = LivingroomReader.GetLivingroomById(Url.QueryStringParser.GetInt("LivingroomId"), true);

                return this._livingroom;
            }
        }

        private LivingroomGeneralEventEntity LivingroomGeneralEvent
        {
            get
            {
                if (this._livingroomGeneralEvent == null && this.HasLivingroomId)
                    this._livingroomGeneralEvent = LivingroomGeneralEventReader.GetLivingroomGeneralByIdAndDate(this.Livingroom.Id, this.QueryStringDate.Date, true);

                return this._livingroomGeneralEvent;
            }
        }

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.PreFill();

                this._hlEdit.NavigateUrl = "~/Content/Secure/Livingroom/General/GeneralEventAddEdit.aspx?LivingroomId={0}&Date={1}".FormatString(this.Livingroom.Id, this.QueryStringDate.Date);
                this._hlReturn.NavigateUrl = "~/Content/Secure/Livingroom/General/GeneralOverview.aspx?LivingroomId={0}".FormatString(this.Livingroom.Id);
            }
        }

        #region PreFill

        private void PreFill()
        {
            if (this.HasLivingroomId && this.HasDate)
            {
                this._lblDate.Text = this.QueryStringDate.ToString("dd-MM-yyyy");
                this._lblLivingroom.Text = this.Livingroom.Name;
                this._lblDescription.Text = this.LivingroomGeneralEvent.Description;
            }
        }

        #endregion
    }
}