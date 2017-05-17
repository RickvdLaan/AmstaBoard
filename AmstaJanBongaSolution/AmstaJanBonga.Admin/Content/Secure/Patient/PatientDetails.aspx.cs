using AmstaJanBonga.Business.Database.Readers;
using AmstaJanBonga.Business.EntityClasses;
using Rlaan.Toolkit.Extensions;
using Rlaan.Toolkit.Web;
using System;

namespace AmstaJanBonga.Admin.Content.Secure.Patient
{
    public partial class PatientDetails : SecurePage
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
                this.PreFillForm();

                if (this.HasPatientId)
                    this._hlEdit.NavigateUrl = "~/Content/Secure/Patient/PatientAddEdit.aspx?PatientId={0}".FormatString(this.Patient.Id);
            }
        }

        #region Render

        private void PreFillForm()
        {
            if (this.HasPatientId)
            {
                this._lblFirstName.Text = this.Patient.FirstName.CapitalizeFirstLetter();
                this._lblLivingroom.Text = this.Patient.LivingRoom.Name;
                this._imgPatient.ImageUrl = this.Patient.ImagePath;
            }
        }

        #endregion
    }
}