using Rlaan.Toolkit.Web;
using System;


namespace AmstaJanBonga.Web.Utilities
{
    /// <summary>
    /// This class contains addons to the default System.Web.UI.Page; this class can only be inherited.
    /// </summary>
    public abstract class DefaultPage : System.Web.UI.Page
    {
        #region Properties

        /// <summary>
        /// Gets the master page that determines the overall look of the page.
        /// </summary>
        public MasterPage.Main MasterPage { get { return (MasterPage.Main)this.Master; } }

        /// <summary>
        /// Gets the notification message resource name if found in the querystring.
        /// </summary>
        private string NotificationMessage
        {
            get
            {
                return Url.QueryStringParser.HasParameter("NotificationMessage") ? Url.QueryStringParser.GetString("NotificationMessage") : null;
            }
        }

        #endregion


        #region Overrides

        /// <summary>
        /// Extends the base OnPreRender.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPreRender(EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.NotificationMessage) && this.MasterPage != null)
            {
                this.MasterPage.AddNotificationMessage(Resource.ResourceManager.GetString(
                    this.NotificationMessage) ?? string.Format(Resource.NotificationQueryStringNotFound, this.NotificationMessage));
            }

            base.OnPreRender(e);
        }

        #endregion
    }
}