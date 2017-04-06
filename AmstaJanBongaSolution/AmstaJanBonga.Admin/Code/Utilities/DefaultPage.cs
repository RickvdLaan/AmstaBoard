using Resources;
using Rlaan.Toolkit.Extensions;
using Rlaan.Toolkit.Web;
using System;

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
    }
}