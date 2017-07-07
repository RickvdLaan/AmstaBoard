using AmstaJanBonga.Business.CollectionClasses;
using AmstaJanBonga.Business.Database.Readers;
using System;
using System.Web.UI.WebControls;

namespace AmstaJanBonga.Admin.Content.Secure.LivingRoom
{
    public partial class LivingRoomOverview : SecurePage
    {
        #region Variables & Objects

        private LivingRoomCollection _livingrooms = null;

        #endregion

        #region Properties

        public LivingRoomCollection Livingrooms
        {
            get
            {
                if (this._livingrooms == null)
                    this._livingrooms = LivingRoomReader.GetAllLivingRooms();

                return this._livingrooms;
            }
        }

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
                this.DataBindLivingRooms();
        }

        #region DataBinding

        private void DataBindLivingRooms()
        {
            this._gvLivingrooms.DataSource = this.Livingrooms;
            this._gvLivingrooms.DataBind();
        }

        #endregion

        #region Events

        protected void _gvLivingrooms_PreRender(object sender, EventArgs e)
        {
            this._gvLivingrooms.UseAccessibleHeader = true;
            this._gvLivingrooms.HeaderRow.TableSection = TableRowSection.TableHeader;

            if (this._gvLivingrooms.TopPagerRow != null)
                this._gvLivingrooms.TopPagerRow.TableSection = TableRowSection.TableHeader;

            if (this._gvLivingrooms.Rows.Count > 0)
            {
                if (this._gvLivingrooms.BottomPagerRow != null)
                    this._gvLivingrooms.BottomPagerRow.TableSection = TableRowSection.TableFooter;
            }
        }

        protected void _gvLivingrooms_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this._gvLivingrooms.PageIndex = e.NewPageIndex;

            this.DataBindLivingRooms();
        }

        #endregion
    }
}