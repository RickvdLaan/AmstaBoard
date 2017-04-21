using AmstaJanBonga.Business.Database.Managers;
using AmstaJanBonga.Business.Enums;
using Rlaan.Toolkit.Configuration;
using Rlaan.Toolkit.Web;
using System.IO;
using System.Web;
using System.Web.UI.WebControls;

public abstract class Helper
{
    #region Temp code Sprint 1

    public const int LIVINGROOM_STIMULATE = 2;

    #endregion

    #region Properties

    /// <summary>
    /// Returns the Sub-title's value.
    /// </summary>
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

    public abstract class FileManager
    {
        /// <summary>
        /// Validates whether the image has a valid file extension.
        /// </summary>
        /// <param name="fileName">The entire filename.</param>
        /// <returns></returns>
        public static bool IsValidImage(string fileName)
        {
            switch (Path.GetExtension(fileName).ToUpper())
            {
                case ".JPG":
                    return true;
                case ".JPEG":
                    return true;
                case ".PNG":
                    return true;
                case ".GIF":
                    return true;
                default:
                    return false;
            }
        }

        /// <summary>
        /// Replaces illegal chars for '-'.
        /// </summary>
        /// <param name="filename">The entire filename.</param>
        /// <returns></returns>
        public static string ReplaceIllegalChars(string filename)
        {
            var chars = Path.GetInvalidFileNameChars();

            foreach (char _chars in chars)
            {
                filename = filename.Replace(_chars, '-');
            }

            return filename;
        }

        /// <summary>
        /// Saves the uploaded file to the provided virtual directory.
        /// <para>&#160;</para>
        /// Provide a unique id to make sure that the uploaded file doesn't conflict with another file.
        /// </summary>
        /// <param name="fileUpload">Provide the FileUpload control.</param>
        /// <param name="virtualDirectory">Provide the path to the virtual directory.</param>
        /// <param name="uniqueId">Provide the unique id.</param>
        /// <returns>Path to the file.</returns>
        public static string SaveFileToVirtualDirectory(FileUpload fileUpload, string virtualDirectory, int uniqueId)
        {
            // Checks if there is a file to save.
            if (string.IsNullOrEmpty(fileUpload.FileName))
                return string.Empty;

            // Sets the file name.
            var fileNameToUse = string.Format("file-{0}{1}",
                uniqueId,
                Path.GetExtension(fileUpload.FileName));

            // The path without the filename
            var path = HttpContext.Current.Server.MapPath(
                   string.Format("{0}{1}",
                   HttpContext.Current.Request.ApplicationPath,
                   virtualDirectory));

            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            // Saves the file to the virtual directory.
            fileUpload.SaveAs(path + fileNameToUse);

            // Returns the full path.
            return (path + fileNameToUse);
        }
    }
}