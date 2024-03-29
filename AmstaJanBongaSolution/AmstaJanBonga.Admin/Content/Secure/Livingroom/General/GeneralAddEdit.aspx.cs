﻿using AmstaJanBonga.Business.Database.Managers;
using AmstaJanBonga.Business.Database.Readers;
using AmstaJanBonga.Business.EntityClasses;
using Rlaan.Toolkit.Extensions;
using Rlaan.Toolkit.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AmstaJanBonga.Admin.Content.Secure.Livingroom.General
{
    public partial class GeneralAddEdit : SecurePage
    {
        #region Variables & Objects

        private int _livingRoomId = -1;

        private LivingRoomGeneralEntity _livingRoomGeneral = null;

        #endregion

        #region Properties

        private bool HasLivingRoomId
        {
            get { return Url.QueryStringParser.HasParameter("LivingRoomId"); }
        }

        private int LivingRoomId
        {
            get
            {
                if (this.HasLivingRoomId)
                    this._livingRoomId = Url.QueryStringParser.GetInt("LivingRoomId");

                return this._livingRoomId;
            }
        }

        private LivingRoomGeneralEntity LivingRoomGeneral
        {
            get
            {
                if (this._livingRoomGeneral == null)
                    this._livingRoomGeneral = LivingRoomGeneralReader.GetLivingRoomGeneralById(this.LivingRoomId, false);

                return this._livingRoomGeneral;
            }
        }

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.Page.IsPostBack)
            {
                this.PreFill();

                this._hlReturn.NavigateUrl = "~/Content/Secure/LivingRoom/General/GeneralOverview.aspx?LivingRoomId={0}".FormatString(this.LivingRoomId);
            }
        }

        #region Methods

        private void PreFill()
        {
            if (this.HasLivingRoomId)
            {
                // Sets the descriptions.
                this._txtGeneral.Text = Server.HtmlDecode(LivingRoomGeneral.Description).Replace("<br />", Environment.NewLine);
            }
        }

        private void Save()
        {
            if (this.HasLivingRoomId)
            {
                var general = Server.HtmlEncode(this._txtGeneral.Text).Replace(Environment.NewLine, "<br />");

                // This one needs to be updated/inserted regardless.
                LivingRoomGeneralManager.InsertOrUpdate(this.LivingRoomId, string.IsNullOrWhiteSpace(general) ? null : general);
            }
        }

        #endregion

        #region Events

        protected void _btnSave_Click(object sender, EventArgs e)
        {
            if (Server.HtmlDecode(this.LivingRoomGeneral.Description) != Server.HtmlEncode(this._txtGeneral.Text))
            {
                this.Save();
            }

            Response.Redirect("~/Content/Secure/LivingRoom/General/GeneralOverview.aspx?LivingRoomId={0}".FormatString(this.LivingRoomId));
        }

        protected void _btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Content/Secure/LivingRoom/General/GeneralOverview.aspx?LivingRoomId={0}".FormatString(this.LivingRoomId));
        }

        #endregion
    }
}