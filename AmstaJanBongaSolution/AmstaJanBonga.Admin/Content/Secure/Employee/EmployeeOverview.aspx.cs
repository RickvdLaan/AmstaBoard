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
            this.Employees = EmployeeReader.GetAllEmployeesJoinedWithLivingroom();

            this._gvEmployee.DataSource = this.Employees;
            this._gvEmployee.DataBind();

            if (this._gvEmployee.Rows.Count > 0)
            {
                //This replaces <td> with <th> and adds the scope attribute
                this._gvEmployee.UseAccessibleHeader = true;

                //This will add the <thead> and <tbody> elements
                this._gvEmployee.HeaderRow.TableSection = TableRowSection.TableHeader;

                //This adds the <tfoot> element. 
                //Remove if you don't have a footer row
                this._gvEmployee.FooterRow.TableSection = TableRowSection.TableFooter;
            }
        }

        #endregion
    }
}