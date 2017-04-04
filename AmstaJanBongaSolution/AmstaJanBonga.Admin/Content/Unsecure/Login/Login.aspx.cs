using AmstaJanBonga.Business.Database.Managers;
using AmstaJanBonga.Business.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AmstaJanBonga.Admin.Content.Unsecure.Login
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //UserManager.InsertUser("Rick", "password", Business.Enums.RoleTypeEnum.Root);
        }
    }
}