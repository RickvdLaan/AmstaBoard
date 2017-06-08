using Rlaan.Toolkit.Configuration;
using Rlaan.Toolkit.Web;

public abstract partial class Helper
{
    public abstract class Log
    {
        #region Methods

        /// <summary>
        /// Logs the provided message, requires the "Log.Mail.To", "Log.Mail.Subject", "Log.Mail.Subject" and "Smtp.Host" WebConfig appSettings, the "Smtp.Port" is optional.
        /// </summary>
        /// <param name="message">Provide a message to log.</param>
        public static void Message(string subject, string message)
        {
            using (var mail = new Mail(
                WebConfig.GetSetting("Log.Mail.From", true),
                WebConfig.GetSetting("Log.Mail.To", true),
                subject,
                message))
            {
                mail.Send();
            }
        }

        #endregion
    }
}