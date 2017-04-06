using AmstaJanBonga.Business.Database.Readers;
using AmstaJanBonga.Business.EntityClasses;
using Rlaan.Toolkit.Web;
using System;
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
                this.PreFillForm();
            }
        }

        #region Render

        private void PreFillForm()
        {
            if (this.HasUserId)
            {
                this._trPassword.Visible = false;
                this._trVerifyPassword.Visible = false;

                this._txtUsername.Text = this.User.Username;
                this._cbActive.Checked = this.User.IsActive;
            }
        }

        #endregion

        #region Save

        private void Save()
        {
            if (this.HasUserId)
            {

            }
            else
            {

            }
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