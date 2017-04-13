using AmstaJanBonga.Business.Database.Managers;
using AmstaJanBonga.Business.Database.Readers;
using AmstaJanBonga.Business.EntityClasses;
using Rlaan.Toolkit.Extensions;
using Rlaan.Toolkit.Web;
using System;
using System.Web.UI.WebControls;

namespace AmstaJanBonga.Admin.Content.Secure.Patient
{
    public partial class PatientAddEdit : SecurePage
    {
        #region Variables & Objects

        private PatientEntity _patient = null;

        #endregion

        #region Properties

        private bool HasPatientId
        {
            get { return Url.QueryStringParser.HasParameter("PatientId"); }
        }

        private PatientEntity Patient
        {
            get
            {
                if (this._patient == null)
                {
                    if (this.HasPatientId)
                        this._patient = PatientReader.GetPatientById(Url.QueryStringParser.GetInt("PatientId"), true);
                }

                return this._patient;
            }
        }

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.PreFillLivingrooms();
            }
        }

        #region PreFill

        private void PreFillLivingrooms()
        {
            var livingrooms = LivingroomReader.GetAllLivingrooms();

            for (int i = 0; i < livingrooms.Count; i++)
            {
                this._ddlLivingrooms.Items.Add(new ListItem(livingrooms[i].Name, livingrooms[i].Id.ToString()));
            }

            this._ddlLivingrooms.Items.Insert(0, new ListItem("Selecteer woonkamer", string.Empty));
        }

        #endregion

        #region Save

        private void Save()
        {
            // Edit
            if (this.HasPatientId)
            {
                PatientManager.UpdatePatient(this.Patient, this._ddlLivingrooms.SelectedValue.ToInt(), this._txtFirstName.Text, this._fileUpload, this._cbActive.Checked);
            }
            // Add
            else
            {
                PatientManager.InsertPatient(this._ddlLivingrooms.SelectedValue.ToInt(), this._txtFirstName.Text, this._fileUpload, this._cbActive.Checked);
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

                Response.Redirect("~/Content/Secure/Patient/PatientOverview.aspx");
            }
        }

        protected void _btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Content/Secure/Patient/PatientOverview.aspx");
        }

        #endregion
    }
}