using AmstaJanBonga.Business.Database.Readers;
using AmstaJanBonga.Business.EntityClasses;
using Rlaan.Toolkit.Extensions;
using Rlaan.Toolkit.Web;
using System;

namespace AmstaJanBonga.Admin.Content.Secure.User
{
    public partial class UserDetails : SecurePage
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
                this._hlEdit.NavigateUrl = "~/Content/Secure/User/UserAddEdit.aspx?UserId={0}".FormatString(this.User.Id);
            }
        }

        #region Overrides

        protected override void OnPreRenderComplete(EventArgs e)
        {
            this.PreFillForm();

            base.OnPreRenderComplete(e);
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
    }
}