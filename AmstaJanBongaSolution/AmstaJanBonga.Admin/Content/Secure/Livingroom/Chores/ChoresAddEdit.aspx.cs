using AmstaJanBonga.Business.Database.Readers;
using AmstaJanBonga.Business.EntityClasses;
using AmstaJanBonga.Business.HelperClasses;
using Rlaan.Toolkit.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AmstaJanBonga.Admin.Content.Secure.Livingroom.Chores
{
    public partial class ChoresAddEdit : SecurePage
    {
        #region Variables & Objects

        private LivingroomEntity _livingroom = null;

        #endregion

        #region Properties

        private bool HasLivingroomId
        {
            get { return Url.QueryStringParser.HasParameter("LivingroomId"); }
        }

        private LivingroomEntity Livingroom
        {
            get
            {
                if (this._livingroom == null)
                {
                    if (this.HasLivingroomId)
                        this._livingroom = LivingroomReader.GetLivingroomById(Url.QueryStringParser.GetInt("LivingroomId"), true);
                }

                return this._livingroom;
            }
        }

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.PreFill();
            }
        }

        private void PreFill()
        {
            if (HasLivingroomId)
            {
                this._txtLivingroom.Text = Livingroom.Name;

                // Morning
                this._jlbMorning.DataSource = PatientReader.GetAllPatientsByLivingroomId(this.Livingroom.Id);
                this._jlbMorning.DataTextField = "FirstName";
                this._jlbMorning.DataValueField = "Id";
                this._jlbMorning.DataBind();

                // Afternoon
                this._jlbAfternoon.DataSource = PatientReader.GetAllPatientsByLivingroomId(this.Livingroom.Id);
                this._jlbAfternoon.DataTextField = "FirstName";
                this._jlbAfternoon.DataValueField = "Id";
                this._jlbAfternoon.DataBind();

                // Evening
                this._jlbEvening.DataSource = PatientReader.GetAllPatientsByLivingroomId(this.Livingroom.Id);
                this._jlbEvening.DataTextField = "FirstName";
                this._jlbEvening.DataValueField = "Id";
                this._jlbEvening.DataBind();
            }
        }

        protected void _btnSave_Click(object sender, EventArgs e)
        {

        }

        protected void _btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}