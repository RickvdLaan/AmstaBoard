using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AmstaJanBonga.Admin.Content.Secure.Livingroom
{
    public partial class LivingroomOverview : SecurePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}


//private void PreFillRoles()
//{
//    var colourValues = (ColourTypeEnum[])Enum.GetValues(typeof(ColourTypeEnum));

//    for (int i = 0; i < colourValues.Length; i++)
//    {
//        this._ddlLivingrooms.Items.Add(new ListItem(colourValues[i].Description(), colourValues[i].ToString()));
//    }

//    this._ddlLivingrooms.Items.Insert(0, new ListItem("Selecteer woonkamer", string.Empty));
//}