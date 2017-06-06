<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Main.Master" AutoEventWireup="true" CodeBehind="LivingRoomAddEdit.aspx.cs" Inherits="AmstaJanBonga.Admin.Content.Secure.LivingRoom.LivingRoomAddEdit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="_cphHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="_cphMainTitle" runat="server">
    Woonkamer
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="_cphSubTitle" runat="server">
      <%= Helper.SubTitleAddEdit %>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="_cphExplanation" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="_cphContent" runat="server">
      <div class="box">
        <h2 class="display-inline">
             Woonkamer <%= Helper.SubTitleAddEdit %>
        </h2>

        <div class="return right">
            <asp:HyperLink runat="server" CssClass="return fa fa-reply display-inline" ToolTip="Terug naar woonkameroverzicht" NavigateUrl="~/Content/Secure/LivingRoom/LivingRoomOverview.aspx"></asp:HyperLink>
        </div>

        <div class="clear"></div>

        <table class="table-add-edit">
            <tbody>
                <tr>
                    <td class="label required">
                        Woonkamer
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="_txtLivingRoomName" CssClass="textbox" placeholder="Voornaam" MaxLength="20"></asp:TextBox>
                        <asp:RequiredFieldValidator runat="server" ValidateRequestMode="Enabled" CssClass="error" ErrorMessage="Verplichte velden kunnen niet leeg blijven." Display="Dynamic" ControlToValidate="_txtLivingRoomName" ValidationGroup="Validate"></asp:RequiredFieldValidator>
                    </td>
                </tr>

                <tr>
                    <td class="label required">
                        Kleur
                    </td>
                    <td>
                        <asp:DropDownList runat="server" ID="_ddlLivingRoomColours" AppendDataBoundItems="false"></asp:DropDownList>
                        <asp:RequiredFieldValidator runat="server" ValidateRequestMode="Enabled" CssClass="error" ErrorMessage="Verplichte velden kunnen niet leeg blijven." Display="Dynamic" ControlToValidate="_ddlLivingRoomColours" ValidationGroup="Validate"></asp:RequiredFieldValidator>
                    </td>
                </tr>
            </tbody>
        </table>

        <asp:Label runat="server" ID="_lblError" CssClass="error"></asp:Label>
    </div>

    <div class="box">
        <asp:Button runat="server" ID="_btnSave" CssClass="button button-save green-bg" Text="Opslaan" OnClick="_btnSave_Click" ValidateRequestMode="Enabled" ValidationGroup="Validate" CausesValidation="true" />
        <asp:Button runat="server" ID="_btnCancel" CssClass="button button-cancel red-bg" Text="Annuleren" OnClick="_btnCancel_Click" />
    </div>
</asp:Content>
