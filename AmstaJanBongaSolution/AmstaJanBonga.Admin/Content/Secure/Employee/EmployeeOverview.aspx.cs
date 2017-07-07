using AmstaJanBonga.Business.Database.Managers;
using AmstaJanBonga.Business.Database.Readers;
using System;
using System.Data;
using System.Web.UI.WebControls;

namespace AmstaJanBonga.Admin.Content.Secure.Employee
{
    public partial class EmployeeOverview : SecurePage
    {
        #region Variables & Objects

        private DataTable _employees = null;

        #endregion

        #region Properties

        public DataTable Employees
        {
            get
            {
                if (this._employees == null)
                    // LivingRoom is a required field when you add an employee, so this 
                    // method can be called.
                    this._employees = EmployeeReader.GetAllEmployeesJoinedWithLivingRoom();

                return this._employees;
            }
        }

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
                this.DataBindEmployees();
        }

        #region DataBinding

        private void DataBindEmployees()
        {
            this._gvEmployee.DataSource = this.Employees;
            this._gvEmployee.DataBind();
        }

        #endregion

        #region Events

        protected void _gvEmployee_PreRender(object sender, EventArgs e)
        {
            this._gvEmployee.UseAccessibleHeader = true;
            this._gvEmployee.HeaderRow.TableSection = TableRowSection.TableHeader;

            if (this._gvEmployee.TopPagerRow != null)
                this._gvEmployee.TopPagerRow.TableSection = TableRowSection.TableHeader;

            if (this._gvEmployee.Rows.Count > 0)
            {
                if (this._gvEmployee.BottomPagerRow != null)
                    this._gvEmployee.BottomPagerRow.TableSection = TableRowSection.TableFooter;
            }
        }

        protected void _lbDelete_Click(object sender, EventArgs e)
        {
            // Get command argument
            var linkButton = (LinkButton)sender;
            var employeeId = Convert.ToInt32(linkButton.CommandArgument);

            // Mark employee as deleted.
            EmployeeManager.MarkEmployeeAsDeleted(employeeId);

            this.DataBindEmployees();
        }

        protected void _gvEmployee_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this._gvEmployee.PageIndex = e.NewPageIndex;

            this.DataBindEmployees();
        }

        #endregion
    }
}