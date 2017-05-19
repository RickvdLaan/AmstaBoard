using AmstaJanBonga.Business.CollectionClasses;
using AmstaJanBonga.Business.Database.Readers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AmstaJanBonga.Admin.Content.Secure.User
{
    public partial class UserOverview : SecurePage
    {
        #region Properties

        private UserCollection _users = null;
        public UserCollection Users
        {
            get { return this._users; }
            set { this._users = value; }
        }

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        #region Events

        protected void _gvUsers_PreRender(object sender, EventArgs e)
        {
            this.Users = UserReader.GetAllUsers();

            this._gvUsers.DataSource = this.Users;
            this._gvUsers.DataBind();

            this._gvUsers.UseAccessibleHeader = true;
            this._gvUsers.HeaderRow.TableSection = TableRowSection.TableHeader;

            if (this._gvUsers.TopPagerRow != null)
                this._gvUsers.TopPagerRow.TableSection = TableRowSection.TableHeader;

            if (this._gvUsers.Rows.Count > 0)
            {
                if (this._gvUsers.BottomPagerRow != null)
                    this._gvUsers.BottomPagerRow.TableSection = TableRowSection.TableFooter;
            }
        }

        #endregion
    }
}