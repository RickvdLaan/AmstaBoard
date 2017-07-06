using AmstaJanBonga.Business.Database.Managers;
using AmstaJanBonga.Business.Database.Readers;
using System;
using System.Data;
using System.Web.UI.WebControls;

namespace AmstaJanBonga.Admin.Content.Secure.Employee
{
    public partial class EmployeeOverview : SecurePage
    {
        #region Properties

        private DataTable _employees = null;
        public DataTable Employees
        {
            get { return this._employees; }
            set { this._employees = value; }
        }

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        #region Events

        protected void _gvEmployee_PreRender(object sender, EventArgs e)
        {
            // LivingRoom is a required field when you add an employee, so this 
            // method can be called.
            this.Employees = EmployeeReader.GetAllEmployeesJoinedWithLivingRoom();

            this._gvEmployee.DataSource = this.Employees;
            this._gvEmployee.DataBind();

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
        }

        #endregion
    }
}