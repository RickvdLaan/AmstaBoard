using Rlaan.Toolkit.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AmstaJanBonga.Admin.Content.Secure.Livingroom.General
{
    public partial class GeneralAddEdit : SecurePage
    {
        #region Properties



        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.Page.IsPostBack)
            {
                _hlReturn.NavigateUrl = "";
            }
        }

        #region Methods

        private void PreFill()
        {

        }

        private void Save()
        {

        }

        #endregion

        #region Events

        protected void _btnSave_Click(object sender, EventArgs e)
        {

        }

        protected void _btnCancel_Click(object sender, EventArgs e)
        {

        }

        #endregion
    }
}