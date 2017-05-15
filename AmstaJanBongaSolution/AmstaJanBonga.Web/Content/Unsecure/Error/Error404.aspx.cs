using System;

namespace AmstaJanBonga.Web.Content.Unsecure.Error
{
    public partial class Error404 : DefaultPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        #region Overrides

        protected override void OnPreRenderComplete(EventArgs e)
        {
            this.MasterPage.AddClassToContent("red-bg");

            base.OnPreRenderComplete(e);
        }

        #endregion
    }
}