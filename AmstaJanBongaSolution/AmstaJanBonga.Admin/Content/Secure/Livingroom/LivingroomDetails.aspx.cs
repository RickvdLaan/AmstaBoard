using AmstaJanBonga.Business.Database.Readers;
using AmstaJanBonga.Business.EntityClasses;
using AmstaJanBonga.Business.Enums;
using Rlaan.Toolkit.Extensions;
using Rlaan.Toolkit.Web;
using System;

namespace AmstaJanBonga.Admin.Content.Secure.Livingroom
{
    public partial class LivingroomDetails : SecurePage
    {
        #region Variables & Objects

        private LivingRoomEntity _livingroom = null;

        #endregion

        #region Properties

        private bool HasLivingRoomId
        {
            get { return Url.QueryStringParser.HasParameter("LivingRoomId"); }
        }

        private LivingRoomEntity LivingRoom
        {
            get
            {
                if (this._livingroom == null && this.HasLivingRoomId)
                    this._livingroom = LivingRoomReader.GetLivingRoomById(Url.QueryStringParser.GetInt("LivingRoomId"), true);

                return this._livingroom;
            }
        }

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.PreFill();

                if (this.HasLivingRoomId)
                {
                    this._hlEdit.NavigateUrl = "~/Content/Secure/Livingroom/LivingroomAddEdit.aspx?LivingRoomId={0}".FormatString(this.LivingRoom.Id);
                    this._hlReturn.NavigateUrl = "~/Content/Secure/Livingroom/LivingroomOverview.aspx?LivingRoomId={0}".FormatString(this.LivingRoom.Id);
                }
            }
        }

        #region PreFill

        private void PreFill()
        {
            if (this.HasLivingRoomId)
            {
                this._lblLivingroom.Text = this.LivingRoom.Name;
                this._lblColour.Text = ((ColourTypeEnum)Enum.Parse(typeof(ColourTypeEnum), this.LivingRoom.ColourTypeEnum.ToString())).Description();
            }
        }

        #endregion
    }
}