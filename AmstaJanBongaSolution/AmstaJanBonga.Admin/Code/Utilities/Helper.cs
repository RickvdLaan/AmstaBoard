using Rlaan.Toolkit.Web;

public class Helper
{
    #region Properties

    public static string SubTitleAddEdit
    {
        get { return Url.GetFullUrl.Contains("Id=") ? "Wijzigen" : "Toevoegen"; }
    }

    /// <summary>
    /// Returns the query string ReturnUrl or null.
    /// </summary>
    public static string ReturnUrl
    {
        get { return Url.QueryStringParser.HasParameter("ReturnUrl") ? Url.QueryStringParser.GetString("ReturnUrl") : null; }
    }

    #endregion
}