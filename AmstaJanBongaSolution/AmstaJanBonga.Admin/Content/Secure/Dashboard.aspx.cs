using AmstaJanBonga.Business.Security;
using System;

namespace AmstaJanBonga.Admin.Content.Secure
{
    public partial class Dashboard : SecurePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void _btnSignout_Click(object sender, EventArgs e)
        {
            Authentication.Utility.SignOut();
        }
    }
}