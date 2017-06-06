using AmstaJanBonga.Business.Database.Readers;
using Rlaan.Toolkit.Extensions;
using Rlaan.Toolkit.Web;
using System;
using System.Web.UI.WebControls;

namespace AmstaJanBonga.Admin.Content.Secure.Livingroom.General
{
    public partial class GeneralOverview : SecurePage
    {
        #region Variables & Objects

        private int _livingroomId = -1;

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

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this._hlAddEditGeneral.NavigateUrl = "~/Content/Secure/LivingRoom/General/GeneralAddEdit.aspx?LivingRoomId={0}".FormatString(this.LivingRoomId);
                this._hlAddEditGeneralEvent.NavigateUrl = "~/Content/Secure/LivingRoom/General/GeneralEventAddEdit.aspx?LivingRoomId={0}".FormatString(this.LivingRoomId);
            }
        }

        #region PreRender

        protected void _gvGeneral_PreRender(object sender, EventArgs e)
        {
            if (this.HasLivingRoomId)
            {
                this._gvGeneral.DataSource = LivingRoomGeneralEventReader.GetAllLivingRoomGeneralEventsByLivingRoomId(this.LivingRoomId);
                this._gvGeneral.DataBind();

                this._gvGeneral.UseAccessibleHeader = true;
                this._gvGeneral.HeaderRow.TableSection = TableRowSection.TableHeader;

                if (this._gvGeneral.TopPagerRow != null)
                    this._gvGeneral.TopPagerRow.TableSection = TableRowSection.TableHeader;

                if (this._gvGeneral.Rows.Count > 0)
                {
                    if (this._gvGeneral.BottomPagerRow != null)
                        this._gvGeneral.BottomPagerRow.TableSection = TableRowSection.TableFooter;
                }
            }
        }

        #endregion
    }
}