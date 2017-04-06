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

            if (this._gvUsers.Rows.Count > 0)
            {
                //This replaces <td> with <th> and adds the scope attribute
                this._gvUsers.UseAccessibleHeader = true;

                //This will add the <thead> and <tbody> elements
                this._gvUsers.HeaderRow.TableSection = TableRowSection.TableHeader;

                //This adds the <tfoot> element. 
                //Remove if you don't have a footer row
                this._gvUsers.FooterRow.TableSection = TableRowSection.TableFooter;
            }
        }

        #endregion
    }
}