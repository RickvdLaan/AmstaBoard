using SD.LLBLGen.Pro.ORMSupportClasses;
using System;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AmstaJanBonga.Admin.Content.Controls.JsListBox
{
    [ValidationProperty("DestinationCount")]
    public partial class JsListBox : System.Web.UI.UserControl
    {
        #region Variables & Objects

        private string _dataTextField, _dataValueField;

        private IEntityCollection _dataSource = null, _dataDestination = null;

        #endregion

        #region Properties

        // Collections

        public IEntityCollection DataSource
        {
            get { return this._dataSource; }
            set
            {
                this._dataSource = value;
            }
        }

        public IEntityCollection DataDestination
        {
            get { return this._dataDestination; }
            set
            {
                this._dataDestination = value;
            }
        }

        // Fields

        public string DataTextField
        {
            get { return this._dataTextField; }
            set { this._dataTextField = value; }
        }

        public string DataValueField
        {
            get { return this._dataValueField; }
            set { this._dataValueField = value; }
        }

        // Listboxes
        
        public ListBox ListBoxSource
        {
            get { return this._lbSource; }
        }

        public ListBox ListBoxDestination
        {
            get { return this._lbDestination; }
        }

        /// <summary>
        /// Gets the destination count, which is used for the RequiredFieldValidator.
        /// </summary>
        public string DestinationCount
        {
            get
            {
                if (this._lbDestination.Items.Count != 1 && this._lbDestination.Items.Count != 2)
                    return string.Empty;
                else
                    return this._lbDestination.Items.Count.ToString();
            }
        }

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                // Registering double click events.
                this._lbSource.Attributes.Add("ondblclick", Page.ClientScript.GetPostBackEventReference(this._lbSource, "lstdbclick_source"));
                this._lbDestination.Attributes.Add("ondblclick", Page.ClientScript.GetPostBackEventReference(this._lbSource, "lstdbclick_destination"));
            }

            // Transfering data when a double click event is fired.
            if (Request["__EVENTARGUMENT"] != null)
            {
                if (Request["__EVENTARGUMENT"] == "lstdbclick_source")
                    MoveListBoxItems(this._lbSource, this._lbDestination);
                else if (Request["__EVENTARGUMENT"] == "lstdbclick_destination")
                    MoveListBoxItems(this._lbDestination, this._lbSource);
            }
        }

        #region Overrides

        public override void DataBind()
        {
            this._lbSource.DataSource = this.DataSource;
            this._lbSource.DataTextField = this.DataTextField;
            this._lbSource.DataValueField = this.DataValueField;
            this._lbSource.DataBind();

            this._lbDestination.DataSource = this.DataDestination;
            this._lbDestination.DataTextField = this.DataTextField;
            this._lbDestination.DataValueField = this.DataValueField;
            this._lbDestination.DataBind();

            base.DataBind();
        }

        #endregion

        #region Methods

        public void Clear()
        {
            this._lbSource.Items.Clear();
            this._lbDestination.Items.Clear();
        }

        private void MoveListBoxItems(ListBox source, ListBox destination)
        {
            foreach (var item in source.Items.GetSelectedItems().ToList())
            {
                destination.Items.Add(item);
                source.Items.Remove(item);
            }

            source.ClearSelection();
            destination.ClearSelection();
        }

        #endregion

        #region Events

        protected void _lbTransferToDestination_Click(object sender, EventArgs e)
        {
            MoveListBoxItems(this._lbSource, this._lbDestination);
        }

        protected void _lbTransferToSource_Click(object sender, EventArgs e)
        {
            MoveListBoxItems(this._lbDestination, this._lbSource);
        }

        #endregion
    }
}