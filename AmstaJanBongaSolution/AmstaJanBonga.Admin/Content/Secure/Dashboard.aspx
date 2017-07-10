<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Main.Master" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="AmstaJanBonga.Admin.Content.Secure.Dashboard" %>

<%@ Register Src="~/Content/Controls/LivingRoomWidget/LivingRoomWidget.ascx" TagPrefix="uc1" TagName="LivingRoomWidget" %>

<asp:Content ID="Content1" ContentPlaceHolderID="_cphHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="_cphMainTitle" runat="server">
    Dashboard
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="_cphSubTitle" runat="server">
    Overzicht
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="_cphExplanation" runat="server">
    Op het dashboard zijn verschillende snelkoppelingen te vinden naar veel gebruikte acties en wordt er algemene informatie weergegeven over de applicaties.
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="_cphContent" runat="server">
     <div class="box">
        <h2>
            Snelkoppelingen
        </h2>
        <div class="shortcut">
            <asp:HyperLink runat="server" CssClass="fa fa-plus-circle" Text="Gebruiker Toevoegen" NavigateUrl="~/Content/Secure/User/UserAddEdit.aspx"></asp:HyperLink>
            <asp:HyperLink runat="server" CssClass="fa fa-plus-circle" Text="Werknemer Toevoegen" NavigateUrl="~/Content/Secure/Employee/EmployeeAddEdit.aspx"></asp:HyperLink>
            <asp:HyperLink runat="server" CssClass="fa fa-plus-circle" Text="Bewoner Toevoegen" NavigateUrl="~/Content/Secure/Patient/PatientAddEdit.aspx"></asp:HyperLink>
        </div>
    </div>

    <div class="widget-container">
        <uc1:LivingRoomWidget runat="server" id="LivingRoomWidget" />
    </div>
    
</asp:Content>
