using AmstaJanBonga.Business.Database.Readers;
using System;

namespace AmstaJanBonga.Admin.Content.Controls.LivingRoomWidget
{
    public partial class LivingRoomWidget : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.DataBindLivingRoomStatistics();
            }
        }

        #region DataBinding

        private void DataBindLivingRoomStatistics()
        {
            this._repLivingRooms.DataSource = LivingRoomReader.GetAllLivingRoomStatisticsByDateWithStoredProcedure(DateTime.Now.Date);
            this._repLivingRooms.DataBind();
        }

        #endregion
    }
}