using Rlaan.Toolkit.Web;

namespace AmstaJanBonga.Admin
{
    public class Helper
    {
        #region Properties

        /// <summary>
        /// Returns the query string ReturnUrl or null.
        /// </summary>
        public static string ReturnUrl
        {
            get { return Url.QueryStringParser.HasParameter("ReturnUrl") ? Url.QueryStringParser.GetString("ReturnUrl") : null; }
        }

        #endregion
    }
}