<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Main.Master" AutoEventWireup="true" CodeBehind="GeneralAddEdit.aspx.cs" Inherits="AmstaJanBonga.Admin.Content.Secure.Livingroom.General.GeneralAddEdit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="_cphHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="_cphMainTitle" runat="server">
    Algemeen Bericht
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="_cphSubTitle" runat="server">
    Bewerken
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="_cphExplanation" runat="server">
    Op deze pagina kunt u het algemene bericht bewerken die u iedere dag op het scherm weergegeven wilt hebben.
    Voorbeeld: "De koffietijden zijn om 11:00 en 15:00 uur".
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="_cphContent" runat="server">
    <div class="box">
        <h2 class="display-inline">
             Algemeen bericht bewerken
        </h2>
        
        <div class="return right">
            <asp:HyperLink runat="server" ID="_hlReturn" CssClass="return fa fa-reply display-inline" ToolTip="Terug naar informatie overzicht"></asp:HyperLink>
        </div>
        
        <div class="clear"></div>

        <table class="table-add-edit">
            <tbody>
                <tr>
                    <td class="label">
                        Bericht
                    </td>
                    <td colspan="2">
                        <asp:TextBox runat="server" CssClass="no-resize" ID="_txtGeneral" TextMode="MultiLine" MaxLength="50"></asp:TextBox>
                    </td>
                </tr>
            </tbody>
        </table>

        <asp:Label runat="server" Visible="false" ID="_lblError" CssClass="error"></asp:Label>
    </div>

    <div class="box">
        <asp:Button runat="server" ID="_btnSave" CssClass="button button-save green-bg" Text="Opslaan" OnClick="_btnSave_Click" ValidateRequestMode="Enabled" ValidationGroup="Validate" CausesValidation="true" />
        <asp:Button runat="server" ID="_btnCancel" CssClass="button button-cancel red-bg" Text="Annuleren" OnClick="_btnCancel_Click" />
    </div>
</asp:Content>
