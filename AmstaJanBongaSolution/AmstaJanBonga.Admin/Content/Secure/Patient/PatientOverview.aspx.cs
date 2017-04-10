using AmstaJanBonga.Business.CollectionClasses;
using AmstaJanBonga.Business.Database.Readers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AmstaJanBonga.Admin.Content.Secure.Patient
{
    public partial class PatientOverview : SecurePage
    {
        #region Properties

        private PatientCollection _patients = null;
        public PatientCollection Patients
        {
            get { return this._patients; }
            set { this._patients = value; }
        }

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        #region Events

        protected void _gvPatients_PreRender(object sender, EventArgs e)
        {
            this.Patients = PatientReader.GetAllPatients();

            this._gvPatients.DataSource = this.Patients;
            this._gvPatients.DataBind();

            if (this._gvPatients.Rows.Count > 0)
            {
                //This replaces <td> with <th> and adds the scope attribute
                this._gvPatients.UseAccessibleHeader = true;

                //This will add the <thead> and <tbody> elements
                this._gvPatients.HeaderRow.TableSection = TableRowSection.TableHeader;

                //This adds the <tfoot> element. 
                //Remove if you don't have a footer row
                this._gvPatients.FooterRow.TableSection = TableRowSection.TableFooter;
            }
        }

        #endregion
    }
}