using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AmstaJanBonga.Web.Content.Unsecure.Error
{
    public partial class ErrorNetwork : DefaultPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        #region Overrides

        protected override void OnPreRenderComplete(EventArgs e)
        {
            this.MasterPage.AddClassToContent("green-bg");
            
            base.OnPreRenderComplete(e);
        }

        #endregion

        protected void _timer_Tick(object sender, EventArgs e)
        {
            Response.Redirect("~/LivingRoom");
        }
    }
}