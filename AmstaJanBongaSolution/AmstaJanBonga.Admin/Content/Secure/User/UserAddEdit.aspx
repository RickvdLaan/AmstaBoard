<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Main.Master" AutoEventWireup="true" CodeBehind="UserAddEdit.aspx.cs" Inherits="AmstaJanBonga.Admin.Content.Secure.User.UserAddEdit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="_cphHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="_cphMainTitle" runat="server">
    Gebruiker
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="_cphSubTitle" runat="server">
    <%= Helper.SubTitleAddEdit %>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="_cphExplanation" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="_cphContent" runat="server">
     <div class="box">
        <h2 class="display-inline">
             Gebruiker <%= Helper.SubTitleAddEdit %>
        </h2>

        <div class="return right">
            <asp:HyperLink runat="server" CssClass="return fa fa-reply display-inline" ToolTip="Terug naar gebruikersoverzicht" NavigateUrl="~/Content/Secure/User/UserOverview.aspx"></asp:HyperLink>
        </div>

        <div class="clear"></div>

        <table class="table-add-edit">
            <tbody>
                <tr>
                    <td class="label required">
                        Gebruikersnaam
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="_txtUsername" CssClass="textbox" MaxLength="20"></asp:TextBox>
                        <asp:RegularExpressionValidator runat="server" ValidateRequestMode="Enabled" CssClass="error" ErrorMessage="Alleen letters mogen worden gebruikt." Display="Dynamic" ControlToValidate="_txtUsername" ValidationGroup="Validate" ValidationExpression="^[a-zA-Z]+$"></asp:RegularExpressionValidator>
                        <asp:RequiredFieldValidator runat="server" ValidateRequestMode="Enabled" CssClass="error" ErrorMessage="Verplichte velden kunnen niet leeg blijven." Display="Dynamic" ControlToValidate="_txtUsername" ValidationGroup="Validate"></asp:RequiredFieldValidator>
                        <asp:CustomValidator runat="server" ID="_cvUsername" CssClass="error" ErrorMessage="Gebruikersnaam is al in gebruik." ControlToValidate="_txtUsername" ValidationGroup="Validate" Display="Dynamic" OnServerValidate="_cvUsername_ServerValidate"></asp:CustomValidator>
                    </td>
                </tr>

                <tr runat="server" id="_trPassword">
                    <td class="label required">
                        Wachtwoord
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="_txtPassword" CssClass="textbox" TextMode="Password" MaxLength="20"></asp:TextBox>
                        <asp:RequiredFieldValidator runat="server" ValidateRequestMode="Enabled" CssClass="error" ErrorMessage="Verplichte velden kunnen niet leeg blijven." Display="Dynamic" ControlToValidate="_txtPassword" ValidationGroup="Validate"></asp:RequiredFieldValidator>
                        <asp:CustomValidator runat="server" ID="_cvPassword" CssClass="error" ErrorMessage="De ingevoerde wachtwoorden komen niet overeen." ControlToValidate="_txtPassword" ValidationGroup="Validate" Display="Dynamic" OnServerValidate="_cvPassword_ServerValidate"></asp:CustomValidator>
                    </td>
                </tr>

                <tr runat="server" id="_trVerifyPassword">
                    <td class="label required">
                        Herhaal
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="_txtVerifyPassword" CssClass="textbox" TextMode="Password" MaxLength="20"></asp:TextBox>
                        <asp:RequiredFieldValidator runat="server" ValidateRequestMode="Enabled" CssClass="error" ErrorMessage="Verplichte velden kunnen niet leeg blijven." Display="Dynamic" ControlToValidate="_txtVerifyPassword" ValidationGroup="Validate"></asp:RequiredFieldValidator>
                    </td>
                </tr>

                <tr>
                    <td class="label required">
                        Actief
                    </td>
                    <td>
                        <asp:CheckBox runat="server" ID="_cbActive" Checked="true" />
                    </td>
                </tr>
            </tbody>
        </table>

        <asp:Label runat="server" ID="_lblError" CssClass="error"></asp:Label>

        <div class="buttons">
            <asp:Button runat="server" ID="_btnSave" CssClass="button" Text="Opslaan" OnClick="_btnSave_Click" ValidateRequestMode="Enabled" ValidationGroup="Validate" CausesValidation="true" />
            <asp:Button runat="server" ID="_btnCancel" CssClass="button" Text="Annuleren" OnClick="_btnCancel_Click" />
        </div>
    </div>
</asp:Content>
