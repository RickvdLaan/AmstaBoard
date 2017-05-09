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

        private LivingroomEntity _livingroom = null;

        private LivingroomChoreEventCollection _chores = null;

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

        private LivingroomChoreEventCollection Chores
        {
            get
            {
                if (this._chores == null)
                    this._chores = LivingroomChoreEventReader.GetAllChoresFilteredByLivingroomAndDate(this.Livingroom.Id, this.QueryStringDate.Date);

                return this._chores;
            }
        }

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.PreFill();

                if (this.HasLivingroomId)
                {
                    if (this.HasDate)
                        this._hlEdit.NavigateUrl = "~/Content/Secure/Livingroom/Chores/ChoresAddEdit.aspx?LivingroomId={0}&Date={1}".FormatString(this.Livingroom.Id, this.QueryStringDate.Date);

                    this._hlReturn.NavigateUrl = "~/Content/Secure/Livingroom/Chores/ChoresOverview.aspx?LivingroomId={0}".FormatString(this.Livingroom.Id);
                }
            }
        }

        #region PreFill

        private void PreFill()
        {
            if (this.HasLivingroomId && this.HasDate)
            {
                this._lblDate.Text = this.QueryStringDate.ToString("dd-MM-yyyy");
                this._lblLivingroom.Text = this.Livingroom.Name;

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