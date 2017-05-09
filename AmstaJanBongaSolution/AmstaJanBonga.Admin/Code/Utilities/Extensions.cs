using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;

public static class Extensions
{
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
        int parsedValue;
        bool success = int.TryParse(value.ToString(), out parsedValue);

        return success ? (int?)parsedValue : null;
    }
}