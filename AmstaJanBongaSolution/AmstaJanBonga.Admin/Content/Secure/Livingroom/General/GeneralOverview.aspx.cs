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
                this._hlAddEditGeneral.NavigateUrl = "~/Content/Secure/Livingroom/General/GeneralEventAddEdit.aspx?LivingRoomId={0}".FormatString(this.LivingRoomId);
            }
        }

        #region PreRender

        protected void _gvGeneral_PreRender(object sender, EventArgs e)
        {
            if (this.HasLivingRoomId)
            {
                this._gvGeneral.DataSource = LivingRoomGeneralEventReader.GetAllLivingRoomGeneralEventsByLivingRoomId(this.LivingRoomId);
                this._gvGeneral.DataBind();

                if (this._gvGeneral.Rows.Count > 0)
                {
                    //This replaces <td> with <th> and adds the scope attribute
                    this._gvGeneral.UseAccessibleHeader = true;

                    //This will add the <thead> and <tbody> elements
                    this._gvGeneral.HeaderRow.TableSection = TableRowSection.TableHeader;

                    //This adds the <tfoot> element. 
                    //Remove if you don't have a footer row
                    this._gvGeneral.FooterRow.TableSection = TableRowSection.TableFooter;
                }
            }
        }

        #endregion
    }
}