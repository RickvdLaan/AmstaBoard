using AmstaJanBonga.Web.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AmstaJanBonga.Web.Content.Livingroom
{
    public partial class Livingroom : DefaultPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected override void OnPreRender(EventArgs e)
        {
            this.MasterPage.ChangeBackgroundColour("grey-bg");

            base.OnPreRender(e);
        }
    }
}