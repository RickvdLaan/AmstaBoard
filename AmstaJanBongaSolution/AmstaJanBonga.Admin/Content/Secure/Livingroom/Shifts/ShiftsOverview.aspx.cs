﻿using AmstaJanBonga.Business.Database.Readers;
using Rlaan.Toolkit.Extensions;
using Rlaan.Toolkit.Web;
using System;
using System.Data;
using System.Web.UI.WebControls;

namespace AmstaJanBonga.Admin.Content.Secure.Livingroom.Shifts
{
    public partial class ShiftsOverview : SecurePage
    {
        #region Variables & Objects

        private int _livingroomId = -1;

        private DataTable _shifts = null;

        #endregion

        #region Properties

        private bool HasLivingroomId
        {
            get { return Url.QueryStringParser.HasParameter("LivingroomId"); }
        }

        private int LivingroomId
        {
            get
            {
                if (this._livingroomId == -1 && this.HasLivingroomId)
                {
                    this._livingroomId = Url.QueryStringParser.GetInt("LivingroomId");
                }

                return this._livingroomId;
            }
        }

        public DataTable Shifts
        {
            get { return this._shifts; }
            set { this._shifts = value; }
        }

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this._hlAddEditShifts.NavigateUrl = "~/Content/Secure/Livingroom/Shifts/ShiftsAddEdit.aspx?LivingroomId={0}".FormatString(this.LivingroomId);
            }
        }
        #region PreRender

        protected void _gvShifts_PreRender(object sender, EventArgs e)
        {
            if (this.HasLivingroomId)
            {
                this.Shifts = LivingroomShiftEventReader.GetAllShiftsDistinctByLivingroomId(this.LivingroomId);

                this._gvShifts.DataSource = this.Shifts;
                this._gvShifts.DataBind();

                if (this._gvShifts.Rows.Count > 0)
                {
                    //This replaces <td> with <th> and adds the scope attribute
                    this._gvShifts.UseAccessibleHeader = true;

                    //This will add the <thead> and <tbody> elements
                    this._gvShifts.HeaderRow.TableSection = TableRowSection.TableHeader;

                    //This adds the <tfoot> element. 
                    //Remove if you don't have a footer row
                    this._gvShifts.FooterRow.TableSection = TableRowSection.TableFooter;
                }
            }
        }

        #endregion
    }
}