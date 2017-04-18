using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;

public static class Extensions
{
    public static IEnumerable<ListItem> GetSelectedItems(this ListItemCollection items)
    {
        return items.OfType<ListItem>().Where(item => item.Selected);
    }
}