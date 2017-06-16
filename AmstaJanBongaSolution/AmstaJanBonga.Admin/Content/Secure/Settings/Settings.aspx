<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Main.Master" AutoEventWireup="true" CodeBehind="Settings.aspx.cs" Inherits="AmstaJanBonga.Admin.Content.Secure.Settings.Settings" %>
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
             Rechten
        </h2>

        <h3>Creëren</h3>

         <asp:Table runat="server">
             <asp:TableRow runat="server">
                 test
             </asp:TableRow>
         </asp:Table>

        <h3>Lezen</h3>
        <h3>Bijwerken</h3>
        <h3>Verwijderen</h3>

        <asp:Label runat="server" ID="_lblError" CssClass="error"></asp:Label>

        <asp:Button runat="server" ID="_btnSave" CssClass="button button-save green-bg" Text="Opslaan" OnClick="_btnSave_Click" ValidateRequestMode="Enabled" ValidationGroup="Validate" CausesValidation="true" />
    </div>
</asp:Content>
