using AmstaJanBonga.Business.CollectionClasses;
using AmstaJanBonga.Business.Database.Managers;
using AmstaJanBonga.Business.Database.Readers;
using AmstaJanBonga.Business.EntityClasses;
using Rlaan.Toolkit.Extensions;
using Rlaan.Toolkit.Web;
using System;
using System.Web.UI.WebControls;

namespace AmstaJanBonga.Admin.Content.Secure.Patient.Agenda
{
    public partial class AgendaOverview : SecurePage
    {
        #region Variables & Objects

        private PatientEntity _patient = null;

        private AgendaEventCollection _agendaEvents = null;

        #endregion

        #region Properties

        private bool HasPatientId
        {
            get { return Url.QueryStringParser.HasParameter("PatientId"); }
        }

        protected PatientEntity Patient
        {
            get
            {
                if (this.HasPatientId &&  this._patient == null)
                    this._patient = PatientReader.GetPatientById(Url.QueryStringParser.GetInt("PatientId"));

                return this._patient;
            }
        }

        private AgendaEventCollection AgendaEvents
        {
            get
            {
                if (this._agendaEvents == null)
                    this._agendaEvents = AgendaEventReader.GetAllEventsByPatientId(this.Patient.Id);

                return this._agendaEvents;
            }
        }

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (this.HasPatientId)
                    this._hlAddEvent.NavigateUrl = "~/Content/Secure/Patient/Agenda/AgendaAddEdit.aspx?PatientId={0}".FormatString(Url.QueryStringParser.GetInt("PatientId"));

                this.DataBindAgendaEvents();
            }
        }

        #region DataBinding

        private void DataBindAgendaEvents()
        {
            var repeat = new AgendaEventMetaCollection();
            var single = new AgendaEventMetaCollection();

            foreach (var agendaEvent in this.AgendaEvents)
            {
                // We used a WHERE clause in the query on the patient id, so there aren't more than one.

                // Repeat
                if (agendaEvent.AgendaEventMetas[0].RepeatInterval.HasValue)
                    repeat.Add(agendaEvent.AgendaEventMetas[0]);
                // Single
                else
                    single.Add(agendaEvent.AgendaEventMetas[0]);
            }

            this._gvPatientAgenda.DataSource = single;
            this._gvPatientAgendaRepeat.DataSource = repeat;

            this._gvPatientAgenda.DataBind();
            this._gvPatientAgendaRepeat.DataBind();
        }

        #endregion

        #region Events

        // Repeat

        protected void _gvPatientAgendaRepeat_PreRender(object sender, EventArgs e)
        {
            this._gvPatientAgendaRepeat.UseAccessibleHeader = true;
            this._gvPatientAgendaRepeat.HeaderRow.TableSection = TableRowSection.TableHeader;

            if (this._gvPatientAgendaRepeat.TopPagerRow != null)
                this._gvPatientAgendaRepeat.TopPagerRow.TableSection = TableRowSection.TableHeader;

            if (this._gvPatientAgendaRepeat.Rows.Count > 0)
            {
                if (this._gvPatientAgendaRepeat.BottomPagerRow != null)
                    this._gvPatientAgendaRepeat.BottomPagerRow.TableSection = TableRowSection.TableFooter;
            }
        }

        protected void _gvPatientAgendaRepeat_PageIndexChanging(object sender, System.Web.UI.WebControls.GridViewPageEventArgs e)
        {
            this._gvPatientAgendaRepeat.PageIndex = e.NewPageIndex;

            this.DataBindAgendaEvents();
        }
        
        // Single

        protected void _gvPatientAgenda_PreRender(object sender, EventArgs e)
        {
            this._gvPatientAgenda.UseAccessibleHeader = true;
            this._gvPatientAgenda.HeaderRow.TableSection = TableRowSection.TableHeader;

            if (this._gvPatientAgenda.TopPagerRow != null)
                this._gvPatientAgenda.TopPagerRow.TableSection = TableRowSection.TableHeader;

            if (this._gvPatientAgenda.Rows.Count > 0)
            {
                if (this._gvPatientAgenda.BottomPagerRow != null)
                    this._gvPatientAgenda.BottomPagerRow.TableSection = TableRowSection.TableFooter;
            }
        }

        protected void _gvPatientAgenda_PageIndexChanging(object sender, System.Web.UI.WebControls.GridViewPageEventArgs e)
        {
            this._gvPatientAgenda.PageIndex = e.NewPageIndex;

            this.DataBindAgendaEvents();
        }

        // Delete

        protected void _lbDelete_Click(object sender, EventArgs e)
        {
            // Get command argument
            var linkButton = (LinkButton)sender;
            var agendaEventMetaId = Convert.ToInt32(linkButton.CommandArgument);

            // Mark patient as deleted.
            AgendaEventMetaManager.MarkAgendaEventMetaAsDeleted(agendaEventMetaId);

            this.DataBindAgendaEvents();
        }

        #endregion
    }
}