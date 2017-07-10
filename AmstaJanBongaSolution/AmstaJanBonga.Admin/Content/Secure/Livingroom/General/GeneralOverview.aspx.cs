using AmstaJanBonga.Business.CollectionClasses;
using AmstaJanBonga.Business.Database.Managers;
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

        private LivingRoomGeneralEventCollection _livingRoomGeneralEvent = null;

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

        private LivingRoomGeneralEventCollection LivingRoomGeneralEventCollection
        {
            get
            {
                if (this._livingRoomGeneralEvent == null)
                    this._livingRoomGeneralEvent = LivingRoomGeneralEventReader.GetAllLivingRoomGeneralEventsByLivingRoomId(this.LivingRoomId);

                return this._livingRoomGeneralEvent;
            }
        }

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this._hlAddEditGeneral.NavigateUrl = "~/Content/Secure/LivingRoom/General/GeneralAddEdit.aspx?LivingRoomId={0}".FormatString(this.LivingRoomId);
                this._hlAddEditGeneralEvent.NavigateUrl = "~/Content/Secure/LivingRoom/General/GeneralEventAddEdit.aspx?LivingRoomId={0}".FormatString(this.LivingRoomId);

                this.DataBindGeneral();
            }
        }

        #region DataBinding

        private void DataBindGeneral()
        {
            this._gvGeneral.DataSource = this.LivingRoomGeneralEventCollection;
            this._gvGeneral.DataBind();
        }

        #endregion

        #region Events

        protected void _gvGeneral_PreRender(object sender, EventArgs e)
        {
            if (this.HasLivingRoomId)
            {
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

        protected void _gvGeneral_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this._gvGeneral.PageIndex = e.NewPageIndex;

            this.DataBindGeneral();
        }

        protected void _lbDelete_Click(object sender, EventArgs e)
        {
            // Get command argument
            var linkButton = (LinkButton)sender;
            var ids = linkButton.CommandArgument.Split('_');

            var livingRoomId = ids[0];
            var date = ids[1];

            LivingRoomGeneralEventManager.DeleteGeneralEvent(livingRoomId.ToInt(), Convert.ToDateTime(date));

            this.DataBindGeneral();
        }

        #endregion
    }
}