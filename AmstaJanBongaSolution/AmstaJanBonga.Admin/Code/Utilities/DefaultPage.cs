using Resources;
using Rlaan.Toolkit.Extensions;
using Rlaan.Toolkit.Web;
using System;
using System.Web.UI;

namespace AmstaJanBonga.Admin
{
    public abstract class DefaultPage : System.Web.UI.Page
    {
        #region Properties

        /// <summary>
        /// Gets the master page that determines the overall look of the page.
        /// </summary>
        public MasterPage.Main MasterPage { get { return (MasterPage.Main)this.Master; } }

        #endregion

        #region Overrides

        protected override void OnPreInit(EventArgs e)
        {
            base.OnPreInit(e);

            OutputCacheParameters d = new OutputCacheParameters();
            

            // Stop Caching in IE
            Response.Cache.SetCacheability(System.Web.HttpCacheability.NoCache);

            // Stop Caching in Firefox
            Response.Cache.SetNoStore();
        }

        #endregion
    }
}