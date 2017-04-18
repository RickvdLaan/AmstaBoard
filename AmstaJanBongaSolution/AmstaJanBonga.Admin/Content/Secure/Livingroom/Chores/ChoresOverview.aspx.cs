using Rlaan.Toolkit.Extensions;
using Rlaan.Toolkit.Web;
using System;
using System.Collections.Generic;
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
                this._hlAddEditChores.NavigateUrl = "~/Content/Secure/Livingroom/Chores/ChoresAddEdit.aspx?LivingroomId={0}".FormatString(this.LivingroomId);
            }
        }

        protected void _gvChores_PreRender(object sender, EventArgs e)
        {

        }
    }
}