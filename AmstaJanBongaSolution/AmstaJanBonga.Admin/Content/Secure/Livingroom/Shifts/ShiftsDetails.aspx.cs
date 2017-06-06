using AmstaJanBonga.Business.CollectionClasses;
using AmstaJanBonga.Business.Database.Readers;
using AmstaJanBonga.Business.EntityClasses;
using AmstaJanBonga.Business.Enums;
using Rlaan.Toolkit.Extensions;
using Rlaan.Toolkit.Web;
using System;

namespace AmstaJanBonga.Admin.Content.Secure.Livingroom.Shifts
{
    public partial class ShiftsDetails : SecurePage
    {
        #region Variables & Objects

        private DateTime _date = DateTime.MinValue;

        private LivingRoomEntity _livingroom = null;

        private LivingRoomShiftEventCollection _shifts = null;

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

        private LivingRoomShiftEventCollection Shifts
        {
            get
            {
                if (this._shifts == null)
                    this._shifts = LivingRoomShiftEventReader.GetAllShiftsFilteredByLivingroomAndDate(this.LivingRoom.Id, this.QueryStringDate.Date);

                return this._shifts;
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
                        this._hlEdit.NavigateUrl = "~/Content/Secure/LivingRoom/Shifts/ShiftsAddEdit.aspx?LivingRoomId={0}&Date={1}".FormatString(this.LivingRoom.Id, this.QueryStringDate.Date);

                    this._hlReturn.NavigateUrl = "~/Content/Secure/LivingRoom/Shifts/ShiftsOverview.aspx?LivingRoomId={0}".FormatString(this.LivingRoom.Id);
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

                foreach (var shift in this.Shifts)
                {
                    if (shift.ShiftTypeEnum == (byte)ShiftTypeEnum.Day)
                    {
                        this._lblDay.Text += shift.Employee.FirstName;
                    }
                    else if (shift.ShiftTypeEnum == (byte)ShiftTypeEnum.Evening)
                    {
                        this._lblEvening.Text += shift.Employee.FirstName;
                    }
                    else
                        throw new NotImplementedException("ShiftTypeEnum with value {0} was not implemented, or does not exist.".FormatString(shift.ShiftTypeEnum));
                }
            }
        }

        #endregion
    }
}