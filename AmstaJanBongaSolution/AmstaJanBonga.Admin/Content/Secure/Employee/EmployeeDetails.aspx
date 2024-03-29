﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Main.Master" AutoEventWireup="true" CodeBehind="EmployeeDetails.aspx.cs" Inherits="AmstaJanBonga.Admin.Content.Secure.Employee.EmployeeDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="_cphHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="_cphMainTitle" runat="server">
    Medewerker
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="_cphSubTitle" runat="server">
    Bekijken
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="_cphExplanation" runat="server">
    Vanuit hier kan de geselecteerde medewerker worden bekeken of worden gewijzigd.
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="_cphContent" runat="server">
    <div class="box">
        <h2 class="display-inline">
             Bekijken
        </h2>
        
        <div class="shortcut">
            <div class="return right">
                <asp:HyperLink runat="server" CssClass="return fa fa-reply display-inline" ToolTip="Terug naar medewerkersoverzicht" NavigateUrl="~/Content/Secure/Employee/EMployeeOverview.aspx"></asp:HyperLink>
            </div>
            
            <asp:HyperLink runat="server" ID="_hlEdit" CssClass="edit fa fa-pencil">
                Medewerker Bewerken
            </asp:HyperLink>

            <div class="clear"></div>
        </div>

        <table class="table-add-edit">
            <tbody>
                <tr>
                    <td class="label">
                        Voornaam
                    </td>
                    <td>
                        <asp:Label runat="server" ID="_lblFirstName"></asp:Label>
                    </td>
                </tr>

                <tr>
                    <td class="label">
                        Huiskamer
                    </td>
                    <td>
                        <asp:Label runat="server" ID="_lblLivingroom"></asp:Label>
                    </td>
                </tr>

                <tr>
                    <td class="label">
                        Foto
                    </td>
                    <td>
                        <asp:Image runat="server" ID="_imgEmployee" />
                    </td>
                </tr>

                <tr>
                    <td class="label">
                        Gebruikersnaam
                    </td>
                    <td>
                        <asp:Label runat="server" ID="_lblUsername"></asp:Label>
                    </td>
                </tr>
            </tbody>
        </table>
    </div>
</asp:Content>
