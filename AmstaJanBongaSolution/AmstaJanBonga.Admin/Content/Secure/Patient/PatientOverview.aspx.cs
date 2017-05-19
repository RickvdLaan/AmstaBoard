﻿using AmstaJanBonga.Business.Database.Readers;
using System;
using System.Data;
using System.Web.UI.WebControls;

namespace AmstaJanBonga.Admin.Content.Secure.Patient
{
    public partial class PatientOverview : SecurePage
    {
        #region Properties

        private DataTable _patients = null;
        public DataTable Patients
        {
            get
            {
                if (this._patients == null)
                    this._patients = PatientReader.GetAllPatientsJoinedWithLivingroom();

                return this._patients;
            }
        }

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        #region Methods

        private void DataBindPatients()
        {
            this._gvPatients.DataSource = this.Patients;
            this._gvPatients.DataBind();
        }

        #endregion

        #region Events

        protected void _gvPatients_PreRender(object sender, EventArgs e)
        {
            this.DataBindPatients();

            if (this._gvPatients.Rows.Count > 0)
            {
                this._gvPatients.UseAccessibleHeader = true;
                this._gvPatients.HeaderRow.TableSection = TableRowSection.TableHeader;

                if (this._gvPatients.TopPagerRow != null)
                    this._gvPatients.TopPagerRow.TableSection = TableRowSection.TableHeader;
                if (this._gvPatients.BottomPagerRow != null)
                    this._gvPatients.BottomPagerRow.TableSection = TableRowSection.TableFooter;
            }
        }

        #endregion

        protected void _gvPatients_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this._gvPatients.PageIndex = e.NewPageIndex;

            this.DataBindPatients();
        }
    }
}