﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.UI.WebControls;

public static class Extensions
{
    /// <summary>
    /// Returns a collection of the selected list items.
    /// </summary>
    /// <param name="items"></param>
    /// <returns></returns>
    public static IEnumerable<ListItem> GetSelectedItems(this ListItemCollection items)
    {
        return items.OfType<ListItem>().Where(item => item.Selected);
    }

    /// <summary>
    /// Converts the string to a nullable int32.
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public static int? ToNullableInt(this string value)
    {
        // Can't be inlined because the compiler is C# 6.0, and not 7.0.
        int parsedValue;

        return (int.TryParse(value, out parsedValue) ? (int?)parsedValue : null);
    }

    /// <summary>
    /// Gets the start date of the week (Monday)
    /// </summary>
    /// <param name="dt"></param>
    /// <returns></returns>
    public static DateTime GetDateStartOfWeek(this DateTime dt)
    {
        int diff = dt.DayOfWeek - DayOfWeek.Monday;
        if (diff < 0)
        {
            diff += 7;
        }
        return dt.AddDays(-1 * diff).Date;
    }

    /// <summary>
    /// Gets the last date of the week (Sunday)
    /// </summary>
    /// <param name="dt"></param>
    /// <returns></returns>
    public static DateTime GetDateEndOfWeek(this DateTime dt)
    {
        int diff = dt.DayOfWeek - DayOfWeek.Sunday;
        if (diff > 0)
        {
            diff -= 7;
        }
        return dt.AddDays(-1 * diff).Date;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="source"></param>
    /// <param name="start"></param>
    /// <param name="end"></param>
    /// <param name="ignoreIsLoopback"></param>
    /// <returns></returns>
    public static bool IsInRange(this IPAddress source, IPAddress start, IPAddress end, bool ignoreIsLoopback = true)
    {
        // Checking IP addresses that start with 127.x.y.z
        if (ignoreIsLoopback)
        {
            return (IpInUint(source.ToString().Split(new char[] { '.' })) >= IpInUint(start.ToString().Split(new char[] { '.' })) && 
                    IpInUint(source.ToString().Split(new char[] { '.' })) <= IpInUint(end.ToString().Split(new char[] { '.' })));
        }
        else
        {
            if (IPAddress.IsLoopback(source) == false)
                return (IpInUint(source.ToString().Split(new char[] { '.' })) >= IpInUint(start.ToString().Split(new char[] { '.' })) &&
                        IpInUint(source.ToString().Split(new char[] { '.' })) <= IpInUint(end.ToString().Split(new char[] { '.' })));

            return true;
        }
    }

    private static UInt32 IpInUint(string[] s)
    {
        return (Convert.ToUInt32(s[0]) << 24) | (Convert.ToUInt32(s[1]) << 16) | (Convert.ToUInt32(s[2]) << 8) | (Convert.ToUInt32(s[3]));
    }
}