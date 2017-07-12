<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Main.Master" AutoEventWireup="true" CodeBehind="GeneralEventAddEdit.aspx.cs" Inherits="AmstaJanBonga.Admin.Content.Secure.Livingroom.General.GeneralEventAddEdit" %>

<%@ Import namespace="Rlaan.Toolkit.Extensions" %>
<%@ Register Src="~/Content/Controls/ExtendedCalendar/General/ExtendedCalendar.ascx" TagPrefix="CustomControl" TagName="ExtendedCalendar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="_cphHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="_cphMainTitle" runat="server">
    Algemeen
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="_cphSubTitle" runat="server">
    <%= this.SubTitleAddEdit %>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="_cphExplanation" runat="server">
    Vanuit hier kan informatie worden toegevoegd of worden gewijzigd.
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="_cphContent" runat="server">
      <div class="box">
        <h2 class="display-inline">
             Algemene informatie <%= this.SubTitleAddEdit %>
        </h2>

        <div class="return right">
            <asp:HyperLink runat="server" ID="_hlReturn" CssClass="return fa fa-reply display-inline" ToolTip="Terug naar informatie overzicht"></asp:HyperLink>
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
                        Herhalend
                    </td>
                    <td colspan="2">
                        <asp:TextBox runat="server" ID="_txtGeneral" CssClass="no-resize" TextMode="MultiLine" MaxLength="50" Width="320" Height="50"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td class="label required">
                        Toevoeging
                    </td>
                    <td colspan="2">
                        <asp:TextBox runat="server" ID="_txtGeneralEvent" CssClass="no-resize" TextMode="MultiLine" MaxLength="250" Width="320" Height="85"></asp:TextBox>
                        <asp:RequiredFieldValidator runat="server" ValidateRequestMode="Enabled" CssClass="error" InitialValue="" ErrorMessage="Verplichte velden kunnen niet leeg blijven." Display="Dynamic" ControlToValidate="_txtGeneralEvent" ValidationGroup="Validate"></asp:RequiredFieldValidator>
                    </td>
                </tr>
            </tbody>
        </table>

        <asp:Label runat="server" Visible="false" ID="_lblError" CssClass="error"></asp:Label>
    </div>

    <div class="buttons">
        <asp:Button runat="server" ID="_btnSave" CssClass="button button-save green-bg" Text="Opslaan" OnClick="_btnSave_Click" ValidateRequestMode="Enabled" ValidationGroup="Validate" CausesValidation="true" />
        <asp:Button runat="server" ID="_btnCancel" CssClass="button button-cancel red-bg" Text="Annuleren" OnClick="_btnCancel_Click" />
    </div>
</asp:Content>
