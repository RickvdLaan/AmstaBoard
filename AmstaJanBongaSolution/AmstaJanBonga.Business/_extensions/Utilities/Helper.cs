using Rlaan.Toolkit.Extensions;
using Rlaan.Toolkit.Web;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI.WebControls;

public abstract partial class Helper
{
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

    /// <summary>
    /// Get current user ip address.
    /// </summary>
    /// <returns>The IP Address</returns>
    public static string GetUserIPAddress()
    {
        var context = HttpContext.Current;
        var ip = string.Empty;

        if (context.Request.ServerVariables["HTTP_X_FORWARDED_FOR"] != null)
            ip = context.Request.ServerVariables["HTTP_X_FORWARDED_FOR"].ToString();
        else if (!string.IsNullOrWhiteSpace(context.Request.UserHostAddress))
            ip = context.Request.UserHostAddress;

        if (ip == "::1")
            ip = "127.0.0.1";

        return ip;
    }

    /// <summary>
    /// Validates whether the source IP-address is equal or in range of the accepted IP-address.
    /// </summary>
    /// <param name="acceptedIP">The accepted IP-address or range of addresses with the CIDR format. Exanmple: "143.24.20.36" or "143.24.20.36/29".</param>
    /// <param name="sourceIP">The provided IP-address to check.</param>
    /// <returns></returns>
    public static bool IsIpInRangeOrEqualTo(string acceptedIP, string sourceIP)
    {
        var IP = acceptedIP.ToString();
        var parts = IP.Split('.', '/');

        var ipnum = (Convert.ToUInt32(parts[0]) << 24) |
            (Convert.ToUInt32(parts[1]) << 16) |
            (Convert.ToUInt32(parts[2]) << 8) |
            Convert.ToUInt32(parts[3]);

        var mask = 0xffffffff;
        var maskbits = 0;

        if (acceptedIP.Contains('/'))
            maskbits = Convert.ToInt32(parts[4]);

        mask <<= (32 - maskbits);

        var ipstart = ToIPAddress(ipnum & mask);
        var ipend = ToIPAddress(ipnum | (mask ^ 0xffffffff));

        return IPAddress.Parse(sourceIP).IsInRange(ipstart, ipend);
    }

    private static IPAddress ToIPAddress(uint ip)
    {
        return IPAddress.Parse("{0}.{1}.{2}.{3}".FormatString(ip >> 24, (ip >> 16) & 0xff, (ip >> 8) & 0xff, ip & 0xff));
    }

    /// <summary>
    /// Returns true if any of the provided requests is found in the requested url.
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    public static bool IgnoreAuthenticateRequest(params string[] request)
    {
        var url = HttpContext.Current.Request.Url.ToString();

        return request.Any(r => url.Contains(r));
    }

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

            // Creates the directory if it does not exist.
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            // Saves the file to the virtual directory.
            fileUpload.SaveAs(path + fileNameToUse);

            // Returns the full path.
            return (path + fileNameToUse);
        }

        /// <summary>
        /// Saves an image to the specified virtual directory as a JPEG file, with lowered quality.
        /// <para>Images are saved as .JPEG with either a width, or height of a "<paramref name="widthOrHeight"/>"
        /// amount pixels, depending on the aspect ratio of the provided image.</para>
        /// </summary>
        /// <param name="fileUpload">Provide the FileUpload controller with a single uploaded image of any type.</param>
        /// <param name="virtualDirectory">The virtual directory path, excluding the application map path.</param>
        /// <param name="uniqueId">A unique id to make sure it doesn't override any existing image.</param>
        /// <param name="widthOrHeight"></param>
        /// <returns></returns>
        public static string SaveImageToVirtualDirectory(FileUpload fileUpload, string virtualDirectory, int uniqueId, int widthOrHeight = 400)
        {
            // Checks if there is a file to save.
            if (string.IsNullOrEmpty(fileUpload.FileName))
                return string.Empty;

            // Sets the file name.
            var fileNameToUse = "image-{0}{1}".FormatString(uniqueId, Path.GetExtension(fileUpload.FileName));

            // The path without the filename
            var path = HttpContext.Current.Server.MapPath("{0}{1}".FormatString(HttpContext.Current.Request.ApplicationPath, virtualDirectory));

            // Creates the directory if it does not exist.
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            // Create a bitmap of the content of the fileUpload control in memory
            using (var originalBMP = new Bitmap(fileUpload.FileContent))
            {
                // Calculate the new image dimensions
                // Figure out the ratio
                var ratioX = (double)widthOrHeight / (double)originalBMP.Width;
                var ratioY = (double)widthOrHeight / (double)originalBMP.Height;
                // use whichever multiplier is smaller
                var ratio = ratioX < ratioY ? ratioX : ratioY;

                // now we can get the new height and width
                var newHeight = Convert.ToInt32((double)originalBMP.Height * ratio);
                var newWidth = Convert.ToInt32((double)originalBMP.Width * ratio);

                // Create a new bitmap which will hold the previous resized bitmap
                using (var newBMP = new Bitmap(originalBMP, newWidth, newHeight))
                {
                    // Quality
                    var qualityParam = new EncoderParameter(Encoder.Quality, 80L);

                    // JPEG image codec 
                    var jpegCodec = GetEncoderInfo("image/jpeg") ?? throw new ArgumentNullException();
                    var encoderParams = new EncoderParameters(1);
                    encoderParams.Param[0] = qualityParam;

                    // Changing the file extension to JPEG.
                    fileNameToUse = Path.ChangeExtension(fileNameToUse, ".jpeg");

                    // Save the new graphic file to the server
                    newBMP.Save(path + fileNameToUse, jpegCodec, encoderParams);
                }
            }

            // Returns the full path.
            return (path + fileNameToUse);
        }

        /// <summary> 
        /// Returns the image codec with the given mime type.
        /// </summary> 
        private static ImageCodecInfo GetEncoderInfo(string mimeType)
        {
            // Get image codecs for all image formats 
            var codecs = ImageCodecInfo.GetImageEncoders();

            // Find the correct image codec 
            for (int i = 0; i < codecs.Length; i++)
                if (codecs[i].MimeType == mimeType)
                    return codecs[i];

            return null;
        }
    }
}