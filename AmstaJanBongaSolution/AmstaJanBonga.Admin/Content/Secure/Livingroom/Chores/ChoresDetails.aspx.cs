using AmstaJanBonga.Business.Database.Readers;
using AmstaJanBonga.Business.EntityClasses;
using Rlaan.Toolkit.Web;
using Rlaan.Toolkit.Extensions;
using System;
using AmstaJanBonga.Business.Enums;
using AmstaJanBonga.Business.CollectionClasses;

namespace AmstaJanBonga.Admin.Content.Secure.Livingroom.Chores
{
    public partial class ChoresDetails : SecurePage
    {
        #region Variables & Objects

        private DateTime _date = DateTime.MinValue;

        private LivingRoomEntity _livingroom = null;

        private LivingRoomChoreEventCollection _chores = null;

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

        private LivingRoomEntity LivingRoom
        {
            get
            {
                if (this._livingroom == null && this.HasLivingRoomId)
                    this._livingroom = LivingRoomReader.GetLivingRoomById(Url.QueryStringParser.GetInt("LivingRoomId"), true);

                return this._livingroom;
            }
        }

        private LivingRoomChoreEventCollection Chores
        {
            get
            {
                if (this._chores == null)
                    this._chores = LivingRoomChoreEventReader.GetAllChoresFilteredByLivingroomAndDate(this.LivingRoom.Id, this.QueryStringDate.Date);

                return this._chores;
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
                        this._hlEdit.NavigateUrl = "~/Content/Secure/LivingRoom/Chores/ChoresAddEdit.aspx?LivingRoomId={0}&Date={1}".FormatString(this.LivingRoom.Id, this.QueryStringDate.Date);

                    this._hlReturn.NavigateUrl = "~/Content/Secure/LivingRoom/Chores/ChoresOverview.aspx?LivingRoomId={0}".FormatString(this.LivingRoom.Id);
                }
            }
        }

        #region PreFill

        private void PreFill()
        {
            if (this.HasLivingRoomId && this.HasDate)
            {
                this._lblDate.Text = this.QueryStringDate.ToString("dd-MM-yyyy");
                this._lblLivingroom.Text = this.LivingRoom.Name;

                foreach (var chore in this.Chores)
                {
                    if (chore.TimeOfDayTypeEnum == (byte)TimeOfDayTypeEnum.Morning)
                    {
                        this._lblMorning.Text += chore.Patient.FirstName;
                    }
                    else if (chore.TimeOfDayTypeEnum == (byte)TimeOfDayTypeEnum.Afternoon)
                    {
                        this._lblAfternoon.Text += chore.Patient.FirstName;
                    }
                    else if (chore.TimeOfDayTypeEnum == (byte)TimeOfDayTypeEnum.Evening)
                    {
                        this._lblEvening.Text += chore.Patient.FirstName;
                    }
                    else
                        throw new NotImplementedException("TimeOfDayTypeEnum with value {0} was not implemented, or does not exist.".FormatString(chore.TimeOfDayTypeEnum));
                }
            }
        }

        #endregion
    }
}