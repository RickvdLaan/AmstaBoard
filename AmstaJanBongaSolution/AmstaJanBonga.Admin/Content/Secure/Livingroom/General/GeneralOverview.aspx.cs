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

        private bool HasLivingroomId
        {
            get { return Url.QueryStringParser.HasParameter("LivingroomId"); }
        }

        private int LivingroomId
        {
            get
            {
                if (this._livingroomId == -1 && this.HasLivingroomId)
                {
                    this._livingroomId = Url.QueryStringParser.GetInt("LivingroomId");
                }

                return this._livingroomId;
            }
        }

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this._hlAddEditGeneral.NavigateUrl = "~/Content/Secure/Livingroom/General/GeneralAddEdit.aspx?LivingroomId={0}".FormatString(this.LivingroomId);
            }
        }

        #region PreRender

        protected void _gvGeneral_PreRender(object sender, EventArgs e)
        {
            if (this.HasLivingroomId)
            {
                // Fixme: Implement GeneralReader and GetAllGeneralInformationByLivingroomId
                //this.General = GeneralReader.GetAllGeneralInformationByLivingroomId(this.LivingroomId);

                //this._gvGeneral.DataSource = this.Chores;
                //this._gvGeneral.DataBind();

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