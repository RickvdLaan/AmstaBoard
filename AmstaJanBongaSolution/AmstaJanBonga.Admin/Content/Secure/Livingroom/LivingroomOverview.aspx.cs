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

        private LivingRoomCollection _livingrooms = null;
        public LivingRoomCollection Livingrooms
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
            this.Livingrooms = LivingRoomReader.GetAllLivingRooms();

            this._gvLivingrooms.DataSource = this.Livingrooms;
            this._gvLivingrooms.DataBind();

            this._gvLivingrooms.UseAccessibleHeader = true;
            this._gvLivingrooms.HeaderRow.TableSection = TableRowSection.TableHeader;

            if (this._gvLivingrooms.TopPagerRow != null)
                this._gvLivingrooms.TopPagerRow.TableSection = TableRowSection.TableHeader;

            if (this._gvLivingrooms.Rows.Count > 0)
            {
                if (this._gvLivingrooms.BottomPagerRow != null)
                    this._gvLivingrooms.BottomPagerRow.TableSection = TableRowSection.TableFooter;
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