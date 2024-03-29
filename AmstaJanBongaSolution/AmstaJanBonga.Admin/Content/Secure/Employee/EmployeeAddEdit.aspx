﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Main.Master" AutoEventWireup="true" CodeBehind="EmployeeAddEdit.aspx.cs" Inherits="AmstaJanBonga.Admin.Content.Secure.Employee.EmployeeAddEdit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="_cphHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="_cphMainTitle" runat="server">
    Medewerkers
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="_cphSubTitle" runat="server">
    <%= Helper.SubTitleAddEdit %>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="_cphExplanation" runat="server">
    Vanuit hier kan een medewerker worden toegevoegd of worden gewijzigd.
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="_cphContent" runat="server">
    <div class="box">
        <h2 class="display-inline">
             Medewerker <%= Helper.SubTitleAddEdit %>
        </h2>

        <div class="return right">
            <asp:HyperLink runat="server" CssClass="return fa fa-reply display-inline" ToolTip="Terug naar medewerkeroverzicht" NavigateUrl="~/Content/Secure/Employee/EmployeeOverview.aspx"></asp:HyperLink>
        </div>

        <div class="clear"></div>

        <table class="table-add-edit">
            <tbody>
                <tr>
                    <td class="label required">
                        Voornaam
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="_txtFirstName" CssClass="textbox" placeholder="Voornaam" MaxLength="50"></asp:TextBox>
                        <asp:RequiredFieldValidator runat="server" ValidateRequestMode="Enabled" CssClass="error" ErrorMessage="Verplichte velden kunnen niet leeg blijven." Display="Dynamic" ControlToValidate="_txtFirstName" ValidationGroup="Validate"></asp:RequiredFieldValidator>
                    </td>
                </tr>

                <tr>
                    <td class="label">
                        Foto
                    </td>
                    <td>
                        <asp:FileUpload runat="server" ID="_fileUpload" />
                        <asp:RegularExpressionValidator runat="server" ErrorMessage="Alleen plaatjes van het type jpg, gif, en png zijn toegestaan." CssClass="error" ValidateRequestMode="Enabled" ValidationExpression="([a-zA-Z0-9\s_\\.\-:])+(.png|.jpg|.gif|.PNG|.JPG|.GIF|.jpeg|.JPEG)$" ControlToValidate="_fileUpload" ValidationGroup="Validate" Display="Dynamic"></asp:RegularExpressionValidator>
                    </td>
                </tr>

                <tr>
                    <td class="label">

                    </td>
                    <td>
                        <asp:Button runat="server" ID="_btnDeleteExistingPicture" Text="Verwijder bestaande foto" Enabled="false" OnClick="_btnDeleteExistingPicture_Click" />
                    </td>
                </tr>

                
                <tr>
                    <td class="label">
                        Gebruiker
                    </td>
                    <td>
                        <asp:DropDownList runat="server" ID="_ddlUser" AppendDataBoundItems="false"></asp:DropDownList>
                    </td>
                </tr>

                <tr>
                    <td class="label required">
                        Woonkamer
                    </td>
                    <td>
                        <asp:DropDownList runat="server" ID="_ddlLivingrooms" AppendDataBoundItems="false"></asp:DropDownList>
                        <asp:RequiredFieldValidator runat="server" ValidateRequestMode="Enabled" CssClass="error" ErrorMessage="Verplichte velden kunnen niet leeg blijven." Display="Dynamic" ControlToValidate="_ddlLivingrooms" ValidationGroup="Validate"></asp:RequiredFieldValidator>
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
