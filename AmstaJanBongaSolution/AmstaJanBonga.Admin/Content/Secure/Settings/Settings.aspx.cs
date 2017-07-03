using AmstaJanBonga.Business.CollectionClasses;
using AmstaJanBonga.Business.Database.Managers;
using AmstaJanBonga.Business.Database.Readers;
using AmstaJanBonga.Business.Enums;
using Rlaan.Toolkit.Web;
using System;
using System.Web.UI.WebControls;

namespace AmstaJanBonga.Admin.Content.Secure.Settings
{
    public partial class Settings : SecurePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.DataBindRoles();
            }
        }

        #region Databinding

        private void DataBindRoles()
        {
            this._ddlRoles.DataSource = UserRoleReader.GetAllUserRoles();
            this._ddlRoles.DataTextField = "Name";
            this._ddlRoles.DataValueField = "RoleTypeEnum";
            this._ddlRoles.DataBind();

            this._ddlRoles.Items.Insert(0, new ListItem("Selecteer rol", string.Empty));
        }

        private void DateBindCreate(RoleTypeEnum roleType)
        {
            // Binds the source and destination data with its value fields.
            this._lbCreate.DataSource = UserActivityReader.GetAllActivitiesByCrudAndByRole(CrudTypeEnum.Create, roleType, false);
            this._lbCreate.DataDestination = UserActivityReader.GetAllActivitiesByCrudAndByRole(CrudTypeEnum.Create, roleType, true);
            this._lbCreate.DataTextField = "Name";
            this._lbCreate.DataValueField = "Name";

            // Binds the data.
            this._lbCreate.DataBind();
        }

        private void DataBindRead(RoleTypeEnum roleType)
        {
            // Binds the source and destination data with its value fields.
            this._lbRead.DataSource = UserActivityReader.GetAllActivitiesByCrudAndByRole(CrudTypeEnum.Read, roleType, false);
            this._lbRead.DataDestination = UserActivityReader.GetAllActivitiesByCrudAndByRole(CrudTypeEnum.Read, roleType, true);
            this._lbRead.DataTextField = "Name";
            this._lbRead.DataValueField = "Name";

            // Binds the data.
            this._lbRead.DataBind();
        }

        private void DataBindUpdate(RoleTypeEnum roleType)
        {
            // Binds the source and destination data with its value fields.
            this._lbUpdate.DataSource = UserActivityReader.GetAllActivitiesByCrudAndByRole(CrudTypeEnum.Update, roleType, false);
            this._lbUpdate.DataDestination = UserActivityReader.GetAllActivitiesByCrudAndByRole(CrudTypeEnum.Update, roleType, true);
            this._lbUpdate.DataTextField = "Name";
            this._lbUpdate.DataValueField = "Name";

            // Binds the data.
            this._lbUpdate.DataBind();
        }

        private void DataBindDelete(RoleTypeEnum roleType)
        {
            // Binds the source and destination data with its value fields.
            this._lbDelete.DataSource = UserActivityReader.GetAllActivitiesByCrudAndByRole(CrudTypeEnum.Delete, roleType, false);
            this._lbDelete.DataDestination = UserActivityReader.GetAllActivitiesByCrudAndByRole(CrudTypeEnum.Delete, roleType, true);
            this._lbDelete.DataTextField = "Name";
            this._lbDelete.DataValueField = "Name";

            // Binds the data.
            this._lbDelete.DataBind();
        }

        #endregion

        #region Methods

        private void Save()
        {
            var roleType = (RoleTypeEnum)Enum.Parse(typeof(RoleTypeEnum), this._ddlRoles.SelectedValue);

            // @Cleanup @Simplify @Optimize: Certain data could be cached to prevent extra round trips to the database.
            // Maybe cache it in the current session, and use lazy loading? Furthermore, the code could be simplified
            // to increase its readability, if someone has to work with this code in the future it will be a pain
            // to understand and see all the steps that are taken! 
            // -R Laan, van der, 3 juli 2017
            UserRoleActivityManager.UpdateMulti(
                UserRoleActivityReader.CreateUserRoleActivityEntityCollection(roleType,
                    UserActivityReader.GetAllActivitiesByCrudAndByRole(CrudTypeEnum.Create, roleType, true),
                    UserActivityReader.GetAllActivitiesByCrudAndByRole(CrudTypeEnum.Read, roleType, true),
                    UserActivityReader.GetAllActivitiesByCrudAndByRole(CrudTypeEnum.Update, roleType, true),
                    UserActivityReader.GetAllActivitiesByCrudAndByRole(CrudTypeEnum.Delete, roleType, true)), 
                this.GetSelectedUserRoleActivities(roleType));
        }

        private UserRoleActivityCollection GetSelectedUserRoleActivities(RoleTypeEnum roleType)
        {
            var activities = new UserRoleActivityCollection();

            // Create
            for (int i = 0; i < this._lbCreate.ListBoxDestination.Items.Count; i++)
                activities.Add(UserRoleActivityReader.CreateUserRoleActivityEntity(roleType, this._lbCreate.ListBoxDestination.Items[i].Value));

            // Read
            for (int i = 0; i < this._lbRead.ListBoxDestination.Items.Count; i++)
                activities.Add(UserRoleActivityReader.CreateUserRoleActivityEntity(roleType, this._lbRead.ListBoxDestination.Items[i].Value));

            // Update
            for (int i = 0; i < this._lbUpdate.ListBoxDestination.Items.Count; i++)
                activities.Add(UserRoleActivityReader.CreateUserRoleActivityEntity(roleType, this._lbUpdate.ListBoxDestination.Items[i].Value));

            // Delete
            for (int i = 0; i < this._lbDelete.ListBoxDestination.Items.Count; i++)
                activities.Add(UserRoleActivityReader.CreateUserRoleActivityEntity(roleType, this._lbDelete.ListBoxDestination.Items[i].Value));

            return activities;
        }

        #endregion

        #region Events

        protected void _btnSave_Click(object sender, EventArgs e)
        {
            Save();

            Url.Refresh();
        }

        protected void _ddlRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this._ddlRoles.SelectedValue))
            {
                this._lbCreate.Clear();
                this._lbRead.Clear();
                this._lbUpdate.Clear();
                this._lbDelete.Clear();
            }
            else
            {
                var roleType = (RoleTypeEnum)Enum.Parse(typeof(RoleTypeEnum), this._ddlRoles.SelectedValue);

                this.DateBindCreate(roleType);
                this.DataBindRead(roleType);
                this.DataBindUpdate(roleType);
                this.DataBindDelete(roleType);
            }
        }

        #endregion
    }
}