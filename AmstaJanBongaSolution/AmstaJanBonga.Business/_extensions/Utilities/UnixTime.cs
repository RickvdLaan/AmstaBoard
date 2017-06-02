using System;

public partial class Time
{
    public class UnixTime
    {
        // Timestamp is written as TimeStamp to improve readability.

        #region Variables & Objects

        public const int UNIX_TIMESTAMP_DAY = 86400;
        public const int UNIX_TIMESTAMP_WEEK = 604800;

        #endregion

        #region Properties

        /// <summary>
        /// Gets the first day of the week in a UnixTimeStamp format (Monday).
        /// </summary>
        public static int FirstDayOfWeek
        {
            get { return DateTimeToUnixTimeStamp(DateTime.Now.GetDateStartOfWeek()); }
        }

        /// <summary>
        /// Gets the last day of the week in a UnixTimeStamp format (Sunday).
        /// </summary>
        public static int LastDayOfWeek
        {
            get { return DateTimeToUnixTimeStamp(DateTime.Now.GetDateEndOfWeek()); }
        }

        /// <summary>
        /// Gets the current day in a UnixTimeStamp format.
        /// </summary>
        public static int Today
        {
            get { return DateTimeToUnixTimeStamp(DateTime.Now); }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Converts the passed unixTimeStamp to the DateTime equivelant.
        /// </summary>
        /// <param name="unixTimeStamp"></param>
        /// <returns></returns>
        public static DateTime UnixTimeStampToDateTime(int unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            return new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Local).AddSeconds(unixTimeStamp).ToLocalTime();
        }

        /// <summary>
        /// Converts the passed DateTime to its UnixTimeStamp equivelant.
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static int DateTimeToUnixTimeStamp(DateTime dateTime)
        {
            return (Int32)(dateTime.Subtract(new DateTime(1970, 1, 1) + dateTime.TimeOfDay)).TotalSeconds;
        }

        #endregion
    }
}