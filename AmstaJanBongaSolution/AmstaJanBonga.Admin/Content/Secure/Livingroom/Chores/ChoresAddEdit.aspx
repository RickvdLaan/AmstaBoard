<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Main.Master" AutoEventWireup="true" CodeBehind="ChoresAddEdit.aspx.cs" Inherits="AmstaJanBonga.Admin.Content.Secure.Livingroom.Chores.ChoresAddEdit" %>

<%@ Import namespace="Rlaan.Toolkit.Extensions" %>
<%@ Register Src="~/Content/Controls/JsListBox/JsListBox.ascx" TagPrefix="CustomControl" TagName="JsListBox" %>
<%@ Register Src="~/Content/Controls/ExtendedCalendar/Chores/ExtendedCalendar.ascx" TagPrefix="CustomControl" TagName="ExtendedCalendar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="_cphHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="_cphMainTitle" runat="server">
    Corvee
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="_cphSubTitle" runat="server">
     <%= this.SubTitleAddEdit %>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="_cphExplanation" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="_cphContent" runat="server">
    <div class="box">
        <h2 class="display-inline">
             Corvee <%= this.SubTitleAddEdit %>
        </h2>

        <div class="return right">
            <asp:HyperLink runat="server" ID="_hlReturn" CssClass="return fa fa-reply display-inline" ToolTip="Terug naar corvee overzicht"></asp:HyperLink>
        </div>

        <div class="clear"></div>

        <table class="table-add-edit">
            <tbody>
                <tr>
                    <td class="label required">
                        Datum
                    </td>
                    <td>
                        <CustomControl:ExtendedCalendar runat="server" ID="ExtendedCalendar" />
                        <asp:TextBox runat="server" ID="_txtDate" Visible="false" Enabled="false"></asp:TextBox>
                    </td>
                    <td class="error">
                        <asp:RequiredFieldValidator runat="server" ValidateRequestMode="Enabled" CssClass="error" InitialValue="" ErrorMessage="Geen dag geselecteerd." Display="Dynamic" ControlToValidate="ExtendedCalendar" ValidationGroup="Validate"></asp:RequiredFieldValidator>
                        <asp:CustomValidator runat="server" ControlToValidate="ExtendedCalendar" CssClass="error" OnServerValidate="Calendar_ServerValidate" Display="Dynamic" ErrorMessage="Datums in het verleden zijn ongeldig." ValidationGroup="Validate"></asp:CustomValidator>
                    </td>
                </tr>

                <tr>
                    <td class="label">
                        Woonkamer
                    </td>
                    <td colspan="2" class="error">
                        <asp:TextBox runat="server" ID="_txtLivingroom" Enabled="false"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td class="label required">
                        Ochtend
                    </td>
                    <td>
                        <CustomControl:JsListBox runat="server" id="_jlbMorning" />
                    </td>
                    <td class="error">
                        <asp:RequiredFieldValidator runat="server" ValidateRequestMode="Enabled" CssClass="error" InitialValue="" ErrorMessage="Selecteer minimaal één, of maximaal twee bewoners." Display="Dynamic" ControlToValidate="_jlbMorning" ValidationGroup="Validate"></asp:RequiredFieldValidator>
                    </td>
                </tr>

                <tr>
                    <td class="label required">
                        Middag
                    </td>
                    <td>
                        <CustomControl:JsListBox runat="server" id="_jlbAfternoon" />
                    </td>
                    <td class="error">
                        <asp:RequiredFieldValidator runat="server" ValidateRequestMode="Enabled" CssClass="error" InitialValue="" ErrorMessage="Selecteer minimaal één, of maximaal twee bewoners." Display="Dynamic" ControlToValidate="_jlbAfternoon" ValidationGroup="Validate"></asp:RequiredFieldValidator>
                    </td>
                </tr>

                <tr>
                    <td class="label required">
                        Avond
                    </td>
                    <td>
                        <CustomControl:JsListBox runat="server" id="_jlbEvening" />                     
                    </td>
                    <td class="error">
                         <asp:RequiredFieldValidator runat="server" ValidateRequestMode="Enabled" CssClass="error" InitialValue="" ErrorMessage="Selecteer minimaal één, of maximaal twee bewoners." Display="Dynamic" ControlToValidate="_jlbEvening" ValidationGroup="Validate"></asp:RequiredFieldValidator>
                    </td>
                </tr>
            </tbody>
        </table>

        <asp:Label runat="server" ID="_lblError" CssClass="error"></asp:Label>

        <div class="buttons">
            <asp:Button runat="server" ID="_btnSave" CssClass="button button-save green-bg" Text="Opslaan" OnClick="_btnSave_Click" ValidateRequestMode="Enabled" ValidationGroup="Validate" CausesValidation="true" />
            <asp:Button runat="server" ID="_btnCancel" CssClass="button button-cancel red-bg" Text="Annuleren" OnClick="_btnCancel_Click" />
        </div>
    </div>
</asp:Content>
