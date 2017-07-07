using AmstaJanBonga.Business.CollectionClasses;
using AmstaJanBonga.Business.Database.Managers;
using AmstaJanBonga.Business.Database.Readers;
using AmstaJanBonga.Business.Enums;
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
            get
            {
                if (this._users == null)
                    this._users = UserReader.GetAllUsers();

                return this._users;
            }
        }

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
                this.DataBindUsers();
        }

        #region DataBinding

        private void DataBindUsers()
        {
            this._gvUsers.DataSource = this.Users;
            this._gvUsers.DataBind();
        }

        #endregion

        #region Events

        protected void _gvUsers_PreRender(object sender, EventArgs e)
        {
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

        protected void _gvUsers_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this._gvUsers.PageIndex = e.NewPageIndex;

            this.DataBindUsers();
        }

        protected void _lbDelete_Click(object sender, EventArgs e)
        {
            // Get command argument
            var linkButton = (LinkButton)sender;
            var userId = Convert.ToInt32(linkButton.CommandArgument);

            // Mark user as deleted.
            UserManager.MarkUserAsDeleted(userId);
        }

        #endregion
    }
}