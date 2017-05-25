using AmstaJanBonga.Business.Database.Managers;
using AmstaJanBonga.Business.Database.Readers;
using AmstaJanBonga.Business.EntityClasses;
using AmstaJanBonga.Business.Enums;
using Rlaan.Toolkit.Web;
using System;
using Rlaan.Toolkit.Extensions;
using System.Web.UI.WebControls;

namespace AmstaJanBonga.Admin.Content.Secure.User
{
    public partial class UserAddEdit : SecurePage
    {
        #region Variables & Objects

        private UserEntity _user = null;

        #endregion

        #region Properties

        private bool HasUserId
        {
            get { return Url.QueryStringParser.HasParameter("UserId"); }
        }

        private new UserEntity User
        {
            get
            {
                if (this._user == null)
                {
                    if (this.HasUserId)
                        this._user = UserReader.GetUserById(Url.QueryStringParser.GetInt("UserId"), true);
                }

                return this._user;
            }
        }

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.PreFillRoles();
                this.PreFillForm();
            }
        }

        #region PreFill

        private void PreFillForm()
        {
            if (this.HasUserId)
            {
                this._txtUsername.Enabled = false;

                this._trPassword.Visible = false;
                this._trVerifyPassword.Visible = false;

                this._txtUsername.Text = this.User.Username;

                this._ddlRoles.SelectedItem.Value = this.User.UserRole.RoleTypeEnum.ToString();
            }
        }

        private void PreFillRoles()
        {
            var roleValues = (RoleTypeEnum[])Enum.GetValues(typeof(RoleTypeEnum));

            for (int i = 0; i < roleValues.Length; i++)
            {
                // Root acounts are allowed to create users with root access. So when validating the
                // current users role.
                if (CurrentUser.RoleTypeEnum != (byte)RoleTypeEnum.Root)
                    // Skipping the root in the loop when a user is not root.
                    if ((RoleTypeEnum)Enum.Parse(typeof(RoleTypeEnum), roleValues[i].ToString()) == RoleTypeEnum.Root)
                        continue;

                this._ddlRoles.Items.Add(new ListItem(roleValues[i].Description(), roleValues[i].ToString()));
            }

            this._ddlRoles.ClearSelection();
            this._ddlRoles.Items.FindByText(RoleTypeEnum.Employee.Description()).Selected = true;
        }

        #endregion

        #region Save

        private void Save()
        {
            // Edit
            if (this.HasUserId)
            {
                UserManager.UpdateUserRole(this.User, (RoleTypeEnum)Enum.Parse(typeof(RoleTypeEnum), this._ddlRoles.SelectedValue));
            }
            // Add
            else
            {
                UserManager.InsertUser(
                    this._txtUsername.Text, 
                    this._txtPassword.Text, 
                    (RoleTypeEnum)Enum.Parse(typeof(RoleTypeEnum), this._ddlRoles.SelectedValue));
            }
        }

        #endregion

        #region Events

        protected void _btnSave_Click(object sender, EventArgs e)
        {
            this.Page.Validate("Validate");

            if (this.Page.IsValid)
            {
                this.Save();

                Response.Redirect("~/Content/Secure/User/UserOverview.aspx");
            }
        }

        protected void _btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Content/Secure/User/UserOverview.aspx");
        }

        protected void _cvUsername_ServerValidate(object source, ServerValidateEventArgs args)
        {
            var validator = (CustomValidator)source;

            if (validator != null)
            {
                if (!this.HasUserId || (this.HasUserId && (this._txtUsername.Text != this.User.Username)))
                    args.IsValid = UserReader.IsAvailableUsername(this._txtUsername.Text);
                else
                    // The username has not changed.
                    args.IsValid = true;
            }
        }

        protected void _cvPassword_ServerValidate(object source, ServerValidateEventArgs args)
        {
            var validator = (CustomValidator)source;

            if (validator != null)
                args.IsValid = (this._txtPassword.Text == this._txtVerifyPassword.Text);
        }

        #endregion
    }
}