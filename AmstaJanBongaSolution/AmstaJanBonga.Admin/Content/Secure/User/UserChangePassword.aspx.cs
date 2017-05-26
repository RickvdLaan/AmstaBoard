using AmstaJanBonga.Business.Database.Managers;
using AmstaJanBonga.Business.Database.Readers;
using AmstaJanBonga.Business.EntityClasses;
using AmstaJanBonga.Business.Enums;
using Rlaan.Toolkit.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AmstaJanBonga.Admin.Content.Secure.User
{
    public partial class UserChangePassword : SecurePage
    {
        #region Properties

        private UserEntity _user = null;

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
                this.PreFillForm();
            }
        }

        #region Overrides

        protected override void OnPreRenderComplete(EventArgs e)
        {
            base.OnPreRenderComplete(e);

            if (CurrentUser.RoleTypeEnum == (byte)RoleTypeEnum.Root)
            {
                this._txtCurrentPassword.Enabled = false;
                this._rfvCurrentPassword.Enabled = false;
                this._cvValidatePassword.Enabled = false;
            }
        }

        #endregion

        #region Render

        private void PreFillForm()
        {
            if (this.HasUserId)
            {
                this._lblUsername.Text = this.User.Username;
            }
        }

        #endregion

        #region Save

        private void Save()
        {
            if (this.HasUserId)
            {
                UserManager.UpdatePassword(this.User, _txtNewPassword.Text);
            }
        }

        #endregion

        #region Validators

        protected void _cvComparePasswords_ServerValidate(object source, ServerValidateEventArgs args)
        {
            var validator = (CustomValidator)source;

            if (validator != null)
                args.IsValid = (this._txtNewPassword.Text == this._txtVerifyNewPassword.Text);
        }

        protected void _cvValidatePassword_ServerValidate(object source, ServerValidateEventArgs args)
        {
            var validator = (CustomValidator)source;

            if (validator != null)
                args.IsValid = this.User.IsValidPassword(this._txtCurrentPassword.Text);
        }

        #endregion

        #region Events

        protected void _btnSave_Click(object sender, EventArgs e)
        {
            this.Page.Validate("Validate");

            if (this.Page.IsValid)
            {
                Save();

                Response.Redirect("~/Content/Secure/User/UserOverview.aspx");
            }
        }

        protected void _btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Content/Secure/User/UserOverview.aspx");
        }

        #endregion
    }
}