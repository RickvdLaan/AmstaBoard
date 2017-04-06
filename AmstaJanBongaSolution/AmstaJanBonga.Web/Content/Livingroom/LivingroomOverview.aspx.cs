using System;

namespace AmstaJanBonga.Web.Content.Livingroom
{
    public partial class Livingroom : DefaultPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected override void OnPreRender(EventArgs e)
        {
            this.MasterPage.AddClassToContent("grey-bg");

            base.OnPreRender(e);
        }
    }
}