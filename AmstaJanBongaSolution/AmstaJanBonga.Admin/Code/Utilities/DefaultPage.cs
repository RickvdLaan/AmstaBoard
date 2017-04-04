using Resources;
using Rlaan.Toolkit.Extensions;
using Rlaan.Toolkit.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
        /// Overrides the base OnPreRender.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPreRender(EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.NotificationMessage) && this.MasterPage != null)
            {
                this.MasterPage.AddNotificationMessage(
                    Resource.ResourceManager.GetString(this.NotificationMessage) ?? Resource.NotificationQueryStringNotFound.FormatString(this.NotificationMessage));
            }
        }

        #endregion
    }
}