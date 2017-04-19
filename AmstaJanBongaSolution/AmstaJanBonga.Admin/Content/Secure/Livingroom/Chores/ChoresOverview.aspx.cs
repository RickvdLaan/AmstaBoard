using AmstaJanBonga.Business.Database.Readers;
using Rlaan.Toolkit.Extensions;
using Rlaan.Toolkit.Web;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
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

        public DataTable Chores
        {
            get { return this._chores; }
            set { this._chores = value; }
        }

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this._hlAddEditChores.NavigateUrl = "~/Content/Secure/Livingroom/Chores/ChoresAddEdit.aspx?LivingroomId={0}".FormatString(this.LivingroomId);
            }
        }

        #region PreRender

        protected void _gvChores_PreRender(object sender, EventArgs e)
        {
            if (this.HasLivingroomId)
            {
                this.Chores = ChoreReader.GetAllChoresDistinctByLivingroomId(this.LivingroomId);

                this._gvChores.DataSource = this.Chores;
                this._gvChores.DataBind();

                if (this._gvChores.Rows.Count > 0)
                {
                    //This replaces <td> with <th> and adds the scope attribute
                    this._gvChores.UseAccessibleHeader = true;

                    //This will add the <thead> and <tbody> elements
                    this._gvChores.HeaderRow.TableSection = TableRowSection.TableHeader;

                    //This adds the <tfoot> element. 
                    //Remove if you don't have a footer row
                    this._gvChores.FooterRow.TableSection = TableRowSection.TableFooter;
                }
            }
        }

        #endregion
    }
}