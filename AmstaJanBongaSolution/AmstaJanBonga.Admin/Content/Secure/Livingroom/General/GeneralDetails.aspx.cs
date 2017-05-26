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

        private LivingRoomEntity _livingRoom = null;

        private LivingRoomGeneralEventEntity _livingRoomGeneralEvent = null;

        #endregion

        #region Properties

        private bool HasDate
        {
            get { return Url.QueryStringParser.HasParameter("LivingRoomId"); }
        }

        private bool HasLivingRoomId
        {
            get { return Url.QueryStringParser.HasParameter("LivingRoomId"); }
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

        private LivingRoomEntity Livingroom
        {
            get
            {
                if (this._livingRoom == null && this.HasLivingRoomId)
                    this._livingRoom = LivingRoomReader.GetLivingRoomById(Url.QueryStringParser.GetInt("LivingRoomId"), true);

                return this._livingRoom;
            }
        }

        private LivingRoomGeneralEventEntity LivingRoomGeneralEvent
        {
            get
            {
                if (this._livingRoomGeneralEvent == null && this.HasLivingRoomId)
                    this._livingRoomGeneralEvent = LivingRoomGeneralEventReader.GetLivingRoomGeneralByLivingRoomIdAndDate(this.Livingroom.Id, this.QueryStringDate.Date, true);

                return this._livingRoomGeneralEvent;
            }
        }

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.PreFill();

                if (this.HasLivingRoomId)
                {
                    if (this.HasDate)
                        this._hlEdit.NavigateUrl = "~/Content/Secure/Livingroom/General/GeneralEventAddEdit.aspx?LivingRoomId={0}&Date={1}".FormatString(this.Livingroom.Id, this.QueryStringDate.Date);

                    this._hlReturn.NavigateUrl = "~/Content/Secure/Livingroom/General/GeneralOverview.aspx?LivingRoomId={0}".FormatString(this.Livingroom.Id);
                }
            }
        }

        #region PreFill

        private void PreFill()
        {
            if (this.HasLivingRoomId && this.HasDate)
            {
                this._lblDate.Text = this.QueryStringDate.ToString("dd-MM-yyyy");
                this._lblLivingroom.Text = this.Livingroom.Name;
                this._lblDescription.Text = this.LivingRoomGeneralEvent.Description;
            }
        }

        #endregion
    }
}