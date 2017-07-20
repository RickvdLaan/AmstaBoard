<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Main.Master" AutoEventWireup="true" CodeBehind="ShiftsAddEdit.aspx.cs" Inherits="AmstaJanBonga.Admin.Content.Secure.Livingroom.Shifts.ShiftsAddEdit" %>

<%@ Import namespace="Rlaan.Toolkit.Extensions" %>
<%@ Register Src="~/Content/Controls/JsListBox/JsListBox.ascx" TagPrefix="CustomControl" TagName="JsListBox" %>
<%@ Register Src="~/Content/Controls/ExtendedCalendar/Shifts/ExtendedCalendar.ascx" TagPrefix="CustomControl" TagName="ExtendedCalendar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="_cphHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="_cphMainTitle" runat="server">
    Dienst
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="_cphSubTitle" runat="server">
      <%= this.SubTitleAddEdit %>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="_cphExplanation" runat="server">
    Vanuit hier kan een dienst worden toegevoegd of worden gewijzigd.
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="_cphContent" runat="server">
 <div class="box">
        <h2 class="display-inline">
             Dienst <%= this.SubTitleAddEdit %>
        </h2>

        <div class="return right">
            <asp:HyperLink runat="server" ID="_hlReturn" CssClass="return fa fa-reply display-inline" ToolTip="Terug naar dienstoverzicht"></asp:HyperLink>
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
                    <td class="label">
                        Dag
                    </td>
                    <td>
                        <CustomControl:JsListBox runat="server" id="_jlbDay" />
                    </td>
                    <td class="error">
                        <asp:RequiredFieldValidator runat="server" Enabled="false" ValidateRequestMode="Enabled" CssClass="error" InitialValue="" ErrorMessage="Selecteer minimaal één, of maximaal twee medewerkers." Display="Dynamic" ControlToValidate="_jlbDay" ValidationGroup="Validate"></asp:RequiredFieldValidator>
                    </td>
                </tr>

                <tr>
                    <td class="label">
                        Avond
                    </td>
                    <td>
                        <CustomControl:JsListBox runat="server" id="_jlbEvening" />                     
                    </td>
                    <td class="error">
                         <asp:RequiredFieldValidator runat="server" Enabled="false" ValidateRequestMode="Enabled" CssClass="error" InitialValue="" ErrorMessage="Selecteer één medewerker." Display="Dynamic" ControlToValidate="_jlbEvening" ValidationGroup="Validate"></asp:RequiredFieldValidator>
                         <asp:Label runat="server" ID="_lblError" CssClass="error" Visible="false"></asp:Label>
                    </td>
                </tr>
            </tbody>
        </table>
    </div>

    <div class="box">
        <asp:Button runat="server" ID="_btnSave" CssClass="button button-save green-bg" Text="Opslaan" OnClick="_btnSave_Click" ValidateRequestMode="Enabled" ValidationGroup="Validate" CausesValidation="true" />
        <asp:Button runat="server" ID="_btnCancel" CssClass="button button-cancel red-bg" Text="Annuleren" OnClick="_btnCancel_Click" />
    </div>
</asp:Content>
