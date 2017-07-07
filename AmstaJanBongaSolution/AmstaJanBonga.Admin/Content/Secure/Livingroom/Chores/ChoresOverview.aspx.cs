using AmstaJanBonga.Business.Database.Readers;
using Rlaan.Toolkit.Extensions;
using Rlaan.Toolkit.Web;
using System;
using System.Data;
using System.Web.UI.WebControls;

namespace AmstaJanBonga.Admin.Content.Secure.Livingroom.Chores
{
    public partial class ChoresOverview : SecurePage
    {
        #region Variables & Objects

        private int _livingroomId = -1;

        private DataTable _chores = null;

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

        public DataTable Chores
        {
            get
            {
                if (this._chores == null)
                    this._chores = LivingRoomChoreEventReader.GetAllChoresDistinctByLivingRoomId(this.LivingRoomId);

                return this._chores;
            }
        }

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this._hlAddEditChores.NavigateUrl = "~/Content/Secure/LivingRoom/Chores/ChoresAddEdit.aspx?LivingRoomId={0}".FormatString(this.LivingRoomId);

                this.DataBindChores();
            }
        }

        #region DataBinding

        private void DataBindChores()
        {
            this._gvChores.DataSource = this.Chores;
            this._gvChores.DataBind();
        }

        #endregion

        #region Events

        protected void _gvChores_PreRender(object sender, EventArgs e)
        {
            if (this.HasLivingRoomId)
            {
                this._gvChores.UseAccessibleHeader = true;
                this._gvChores.HeaderRow.TableSection = TableRowSection.TableHeader;

                if (this._gvChores.TopPagerRow != null)
                    this._gvChores.TopPagerRow.TableSection = TableRowSection.TableHeader;

                if (this._gvChores.Rows.Count > 0)
                {
                    if (this._gvChores.BottomPagerRow != null)
                        this._gvChores.BottomPagerRow.TableSection = TableRowSection.TableFooter;
                }
            }
        }

        protected void _gvChores_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this._gvChores.PageIndex = e.NewPageIndex;

            this.DataBindChores();
        }

        #endregion
    }
}