namespace AmstaJanBonga.Web
{
    /// <summary>
    /// This class contains addons to the default System.Web.UI.Page; this class can only be inherited.
    /// </summary>
    public abstract class DefaultPage : System.Web.UI.Page
    {
        #region Properties

        /// <summary>
        /// Gets the main master page.
        /// </summary>
        public MasterPage.Main MasterPage { get { return (MasterPage.Main)this.Master; } }

        #endregion
    }
}