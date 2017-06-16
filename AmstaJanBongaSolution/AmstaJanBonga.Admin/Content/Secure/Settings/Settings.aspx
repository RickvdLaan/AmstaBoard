<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Main.Master" AutoEventWireup="true" CodeBehind="Settings.aspx.cs" Inherits="AmstaJanBonga.Admin.Content.Secure.Settings.Settings" %>

<%@ Register Src="~/Content/Controls/JsListBox/JsListBox.ascx" TagPrefix="uc1" TagName="JsListBox" %>

<asp:Content ID="Content1" ContentPlaceHolderID="_cphHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="_cphMainTitle" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="_cphSubTitle" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="_cphExplanation" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="_cphContent" runat="server">
     <div class="box">
        <h2 class="display-inline">
             Permissions
        </h2>

         <asp:UpdatePanel runat="server" UpdateMode="Conditional">
             <ContentTemplate>
                <asp:DropDownList runat="server" ID="_ddlRoles" OnSelectedIndexChanged="_ddlRoles_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>

                <h3>Create</h3>

                <uc1:JsListBox runat="server" ID="_lbCreate" />

                <h3>Read</h3>

                <uc1:JsListBox runat="server" ID="_lbRead" />

                <h3>Update</h3>

                <uc1:JsListBox runat="server" ID="_lbUpdate" />

                <h3>Delete</h3>

                <uc1:JsListBox runat="server" ID="_lbDelete" />
             </ContentTemplate>
         </asp:UpdatePanel>
       
        <asp:Button runat="server" ID="_btnSave" CssClass="button button-save green-bg" Text="Opslaan" OnClick="_btnSave_Click" ValidateRequestMode="Enabled" ValidationGroup="Validate" CausesValidation="true" />
    </div>
</asp:Content>
