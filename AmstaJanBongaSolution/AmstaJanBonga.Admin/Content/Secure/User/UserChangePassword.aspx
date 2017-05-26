<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Main.Master" AutoEventWireup="true" CodeBehind="UserChangePassword.aspx.cs" Inherits="AmstaJanBonga.Admin.Content.Secure.User.UserChangePassword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="_cphHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="_cphMainTitle" runat="server">
    Gebruiker
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="_cphSubTitle" runat="server">
    Wachtwoord Wijzigen
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="_cphExplanation" runat="server">
    Hier kunt u uw wahctwoord veranderen.
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
                    <td class="label">
                        Gebruiker
                    </td>
                    <td>
                        <asp:Label runat="server" ID="_lblUsername"></asp:Label>
                    </td>
                </tr>

                <tr runat="server">
                    <td class="label required">
                        Huidige wachtwoord
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="_txtCurrentPassword" CssClass="textbox" TextMode="Password" MaxLength="20"></asp:TextBox>
                        <asp:RequiredFieldValidator runat="server" ID="_rfvCurrentPassword" ValidateRequestMode="Enabled" CssClass="error" ErrorMessage="Verplichte velden kunnen niet leeg blijven." Display="Dynamic" ControlToValidate="_txtCurrentPassword" ValidationGroup="Validate"></asp:RequiredFieldValidator>
                        <asp:CustomValidator runat="server" ID="_cvValidatePassword" CssClass="error" ErrorMessage="Het ingevoerde wachtwoord is onjuist." ControlToValidate="_txtCurrentPassword" ValidationGroup="Validate" Display="Dynamic" OnServerValidate="_cvValidatePassword_ServerValidate"></asp:CustomValidator>
                    </td>
                </tr>

                <tr runat="server">
                    <td class="label required">
                        Nieuw wachtwoord
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="_txtNewPassword" CssClass="textbox" TextMode="Password" MaxLength="20"></asp:TextBox>
                        <asp:RequiredFieldValidator runat="server" ValidateRequestMode="Enabled" CssClass="error" ErrorMessage="Verplichte velden kunnen niet leeg blijven." Display="Dynamic" ControlToValidate="_txtNewPassword" ValidationGroup="Validate"></asp:RequiredFieldValidator>
                        <asp:CustomValidator runat="server" ID="_cvComparePasswords" CssClass="error" ErrorMessage="De ingevoerde wachtwoorden komen niet overeen." ControlToValidate="_txtNewPassword" ValidationGroup="Validate" Display="Dynamic" OnServerValidate="_cvComparePasswords_ServerValidate"></asp:CustomValidator>
                    </td>
                </tr>

                <tr runat="server" id="_trVerifyPassword">
                    <td class="label required">
                        Herhaal wachtwoord
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="_txtVerifyNewPassword" CssClass="textbox" TextMode="Password" MaxLength="20"></asp:TextBox>
                        <asp:RequiredFieldValidator runat="server" ValidateRequestMode="Enabled" CssClass="error" ErrorMessage="Verplichte velden kunnen niet leeg blijven." Display="Dynamic" ControlToValidate="_txtVerifyNewPassword" ValidationGroup="Validate"></asp:RequiredFieldValidator>
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
