using AmstaJanBonga.Business.Database.Managers;
using AmstaJanBonga.Business.Database.Readers;
using AmstaJanBonga.Business.EntityClasses;
using Rlaan.Toolkit.Extensions;
using Rlaan.Toolkit.Web;
using System;
using System.Web.UI.WebControls;

namespace AmstaJanBonga.Admin.Content.Secure.Employee
{
    public partial class EmployeeAddEdit : SecurePage
    {
        #region Variables & Objects

        private EmployeeEntity _employee = null;

        #endregion

        #region Properties

        private bool HasEmployeeId
        {
            get { return Url.QueryStringParser.HasParameter("EmployeeId"); }
        }

        private EmployeeEntity Employee
        {
            get
            {
                if (this._employee == null)
                {
                    if (this.HasEmployeeId)
                        this._employee = EmployeeReader.GetEmployeeById(Url.QueryStringParser.GetInt("EmployeeId"), true);
                }

                return this._employee;
            }
        }

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.PreFillForm();
                this.PreFillLivingrooms();
                this.PreFillUnlinkedUsers();
            }
        }

        #region PreFill

        private void PreFillForm()
        {
            // Edit
            if (this.HasEmployeeId)
            {
                this._txtFirstName.Text = this.Employee.FirstName;
                this._cbActive.Checked = this.Employee.IsActive;
            }
        }

        private void PreFillLivingrooms()
        {
            var livingrooms = LivingroomReader.GetAllLivingrooms();

            for (int i = 0; i < livingrooms.Count; i++)
            {
                this._ddlLivingrooms.Items.Add(new ListItem(livingrooms[i].Name, livingrooms[i].Id.ToString()));
            }

            this._ddlLivingrooms.Items.Insert(0, new ListItem("Selecteer woonkamer", string.Empty));

            // Edit
            if (this.HasEmployeeId)
            {
                this._ddlLivingrooms.SelectedValue = this.Employee.LivingroomId.ToString();
            }
        }

        private void PreFillUnlinkedUsers()
        {
            var users = null as Business.CollectionClasses.UserCollection;

            // Add
            if (!this.HasEmployeeId)
            {
                users = UserReader.GetAllUnlinkedUsers();

                for (int i = 0; i < users.Count; i++)
                {
                    this._ddlUser.Items.Add(new ListItem(users[i].Username, users[i].Id.ToString()));
                }

                this._ddlUser.Items.Insert(0, new ListItem("Selecteer gebruiker", string.Empty));
            }
            // Edit
            else
            {
                users = UserReader.GetAllUnlinkedUsers(this.Employee.UserId);

                for (int i = 0; i < users.Count; i++)
                {
                    this._ddlUser.Items.Add(new ListItem(users[i].Username, users[i].Id.ToString()));
                }

                this._ddlUser.Items.Insert(0, new ListItem("Selecteer gebruiker", string.Empty));
                this._ddlUser.SelectedValue = 
                    this.Employee.UserId.HasValue ? this.Employee.UserId.Value.ToString() : string.Empty;
            }
        }

        #endregion

        #region Save

        private void Save()
        {
            // Edit
            if (this.HasEmployeeId)
            {
                EmployeeManager.UpdateEmployee(this.Employee, this._ddlLivingrooms.SelectedValue.ToInt(), this._ddlUser.SelectedValue.ToNullableInt(), this._txtFirstName.Text, this._fileUpload, this._cbActive.Checked);
            }
            // Add
            else
            {
                EmployeeManager.InsertEmployee(this._ddlLivingrooms.SelectedValue.ToInt(), this._ddlUser.SelectedValue.ToNullableInt(), this._txtFirstName.Text, this._fileUpload, this._cbActive.Checked);
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

                Response.Redirect("~/Content/Secure/Employee/EmployeeOverview.aspx");
            }
        }

        protected void _btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Content/Secure/Employee/EmployeeOverview.aspx");
        }

        #endregion
    }
}