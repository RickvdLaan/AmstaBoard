using AmstaJanBonga.Business.Database.Managers;
using AmstaJanBonga.Business.Database.Readers;
using AmstaJanBonga.Business.EntityClasses;
using AmstaJanBonga.Business.Enums;
using Rlaan.Toolkit.Extensions;
using Rlaan.Toolkit.Web;
using System;
using System.Web.UI.WebControls;

namespace AmstaJanBonga.Admin.Content.Secure.LivingRoom
{
    public partial class LivingRoomAddEdit : SecurePage
    {
        #region Variables & Objects

        private LivingRoomEntity _livingRoom = null;

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
                if (this._livingRoom == null)
                {
                    if (this.HasLivingRoomId)
                        this._livingRoom = LivingRoomReader.GetLivingRoomById(Url.QueryStringParser.GetInt("LivingRoomId"), true);
                }

                return this._livingRoom;
            }
        }

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.PreFillForm();
                this.PreFillColours();
            }
        }

        #region PreFill

        private void PreFillForm()
        {
            // Edit
            if (this.HasLivingRoomId)
            {
                this._txtLivingRoomName.Text = this.LivingRoom.Name;
                this._ddlLivingRoomColours.SelectedValue = this.LivingRoom.ColourTypeEnum.ToString();
            }
        }

        private void PreFillColours()
        {
            var roleValues = (ColourTypeEnum[])Enum.GetValues(typeof(ColourTypeEnum));

            for (int i = 0; i < roleValues.Length; i++)
            {
                this._ddlLivingRoomColours.Items.Add(new ListItem(roleValues[i].Description(), roleValues[i].ToString()));
            }

            this._ddlLivingRoomColours.ClearSelection();
            this._ddlLivingRoomColours.Items.FindByText(ColourTypeEnum.Default.Description()).Selected = true;
        }

        #endregion

        #region Save

        private void Save()
        {
            // Edit
            if (this.HasLivingRoomId)
            {
                LivingRoomManager.UpdateLivingRoom();
            }
            // Add
            else
            {
                LivingRoomManager.InsertLivingRoom();
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

                Response.Redirect("~/Content/Secure/LivingRoom/LivingRoomOverview.aspx");
            }
        }

        protected void _btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Content/Secure/LivingRoom/LivingRoomOverview.aspx");
        }

        #endregion
    }
}