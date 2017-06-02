using Rlaan.Toolkit.Configuration;
using Rlaan.Toolkit.Extensions;
using System;

namespace AmstaJanBonga.Web.Content.Unsecure.Updating
{
    public partial class Updating : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void _timer_Tick(object sender, EventArgs e)
        {
            if (!WebConfig.GetSetting("Application.IsUpdating").ToBoolean())
            {
                Response.Redirect("~/Livingroom");
            }
        }
    }
}