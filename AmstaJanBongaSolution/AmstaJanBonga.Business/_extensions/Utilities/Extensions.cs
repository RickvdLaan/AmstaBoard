using System;
using System.Collections.Generic;
using System.Linq;
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
}