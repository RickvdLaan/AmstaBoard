<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Main.Master" AutoEventWireup="true" CodeBehind="ChoresAddEdit.aspx.cs" Inherits="AmstaJanBonga.Admin.Content.Secure.Livingroom.Chores.ChoresAddEdit" %>

<%@ Register Src="~/Content/Controls/JsListBox/JsListBox.ascx" TagPrefix="jsListBoxMorning" TagName="JsListBox" %>

<asp:Content ID="Content1" ContentPlaceHolderID="_cphHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="_cphMainTitle" runat="server">
    Corvee
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="_cphSubTitle" runat="server">
     ...
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="_cphExplanation" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="_cphContent" runat="server">
    <div class="box">
        <h2 class="display-inline">
             Corvee ...
        </h2>

        <div class="return right">
            <asp:HyperLink runat="server" CssClass="return fa fa-reply display-inline" ToolTip="Terug naar woonkameroverzicht"></asp:HyperLink>
        </div>

        <div class="clear"></div>

        <table class="table-add-edit">
            <tbody>
                <tr>
                    <td class="label required">
                        Datum
                    </td>
                    <td>
                        <asp:Calendar runat="server"></asp:Calendar>
                    </td>
                </tr>

                <tr>
                    <td class="label">
                        Woonkamer
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="_txtLivingroom" Enabled="false"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td class="label required">
                        Ochtend
                    </td>
                    <td>
                        <jsListBoxMorning:JsListBox runat="server" id="_jlbMorning" />
                    </td>
                </tr>

                <tr>
                    <td class="label required">
                        Middag
                    </td>
                    <td>
                        <jsListBoxMorning:JsListBox runat="server" id="_jlbAfternoon" />
                    </td>
                </tr>

                <tr>
                    <td class="label required">
                        Avond
                    </td>
                    <td>
                        <jsListBoxMorning:JsListBox runat="server" id="_jlbEvening" />
                    </td>
                </tr>
            </tbody>
        </table>

        <asp:Label runat="server" ID="_lblError" CssClass="error"></asp:Label>

        <div class="buttons">
            <asp:Button runat="server" ID="_btnSave" CssClass="button button-save" Text="Opslaan" OnClick="_btnSave_Click" ValidateRequestMode="Enabled" ValidationGroup="Validate" CausesValidation="true" />
            <asp:Button runat="server" ID="_btnCancel" CssClass="button button-cancel" Text="Annuleren" OnClick="_btnCancel_Click" />
        </div>
    </div>
</asp:Content>
