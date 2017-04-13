using AmstaJanBonga.Business.CollectionClasses;
using AmstaJanBonga.Business.Database.Readers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AmstaJanBonga.Admin.Content.Secure.Livingroom
{
    public partial class LivingroomOverview : SecurePage
    {
        #region Properties

        private LivingroomCollection _livingrooms = null;
        public LivingroomCollection Livingrooms
        {
            get { return this._livingrooms; }
            set { this._livingrooms = value; }
        }

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        #region Events

        protected void _gvLivingrooms_PreRender(object sender, EventArgs e)
        {
            this.Livingrooms = LivingroomReader.GetAllLivingrooms();

            this._gvLivingrooms.DataSource = this.Livingrooms;
            this._gvLivingrooms.DataBind();

            if (this._gvLivingrooms.Rows.Count > 0)
            {
                //This replaces <td> with <th> and adds the scope attribute
                this._gvLivingrooms.UseAccessibleHeader = true;

                //This will add the <thead> and <tbody> elements
                this._gvLivingrooms.HeaderRow.TableSection = TableRowSection.TableHeader;

                //This adds the <tfoot> element. 
                //Remove if you don't have a footer row
                this._gvLivingrooms.FooterRow.TableSection = TableRowSection.TableFooter;
            }
        }

        #endregion
    }
}


//private void PreFillRoles()
//{
//    var colourValues = (ColourTypeEnum[])Enum.GetValues(typeof(ColourTypeEnum));

//    for (int i = 0; i < colourValues.Length; i++)
//    {
//        this._ddlLivingrooms.Items.Add(new ListItem(colourValues[i].Description(), colourValues[i].ToString()));
//    }

//    this._ddlLivingrooms.Items.Insert(0, new ListItem("Selecteer woonkamer", string.Empty));
//}