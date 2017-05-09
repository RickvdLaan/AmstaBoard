using AmstaJanBonga.Business.Database.Readers;
using AmstaJanBonga.Business.EntityClasses;
using Rlaan.Toolkit.Extensions;
using Rlaan.Toolkit.Web;
using System;

namespace AmstaJanBonga.Admin.Content.Secure.Employee
{
    public partial class EmployeeDetails : SecurePage
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

                if (this.HasEmployeeId)
                    this._hlEdit.NavigateUrl = "~/Content/Secure/Employee/EmployeeAddEdit.aspx?EmployeeId={0}".FormatString(this.Employee.Id);
            }
        }

        #region Render

        private void PreFillForm()
        {
            if (this.HasEmployeeId)
            {
                this._lblFirstName.Text = this.Employee.FirstName.CapitalizeFirstLetter();
                this._lblLivingroom.Text = this.Employee.Livingroom.Name;
                this._imgEmployee.ImageUrl = this.Employee.ImagePath;
                this._lblUsername.Text = this.Employee.UserId.HasValue ? this.Employee.User.Username : "Geen account gekoppeld.";
            }
        }

        #endregion
    }
}