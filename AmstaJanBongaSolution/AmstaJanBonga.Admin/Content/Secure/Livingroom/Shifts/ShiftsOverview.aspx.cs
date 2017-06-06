using AmstaJanBonga.Business.Database.Readers;
using Rlaan.Toolkit.Extensions;
using Rlaan.Toolkit.Web;
using System;
using System.Data;
using System.Web.UI.WebControls;

namespace AmstaJanBonga.Admin.Content.Secure.Livingroom.Shifts
{
    public partial class ShiftsOverview : SecurePage
    {
        #region Variables & Objects

        private int _livingroomId = -1;

        private DataTable _shifts = null;

        #endregion

        #region Properties

        private bool HasLivingRoomId
        {
            get { return Url.QueryStringParser.HasParameter("LivingRoomId"); }
        }

        private int LivingRoomId
        {
            get
            {
                if (this._livingroomId == -1 && this.HasLivingRoomId)
                {
                    this._livingroomId = Url.QueryStringParser.GetInt("LivingRoomId");
                }

                return this._livingroomId;
            }
        }

        public DataTable Shifts
        {
            get { return this._shifts; }
            set { this._shifts = value; }
        }

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this._hlAddEditShifts.NavigateUrl = "~/Content/Secure/LivingRoom/Shifts/ShiftsAddEdit.aspx?LivingRoomId={0}".FormatString(this.LivingRoomId);
            }
        }

        #region PreRender

        protected void _gvShifts_PreRender(object sender, EventArgs e)
        {
            if (this.HasLivingRoomId)
            {
                this.Shifts = LivingRoomShiftEventReader.GetAllShiftsDistinctByLivingRoomId(this.LivingRoomId);

                this._gvShifts.DataSource = this.Shifts;
                this._gvShifts.DataBind();

                this._gvShifts.UseAccessibleHeader = true;
                this._gvShifts.HeaderRow.TableSection = TableRowSection.TableHeader;

                if (this._gvShifts.TopPagerRow != null)
                    this._gvShifts.TopPagerRow.TableSection = TableRowSection.TableHeader;

                if (this._gvShifts.Rows.Count > 0)
                {
                    if (this._gvShifts.BottomPagerRow != null)
                        this._gvShifts.BottomPagerRow.TableSection = TableRowSection.TableFooter;
                }
            }
        }

        #endregion
    }
}