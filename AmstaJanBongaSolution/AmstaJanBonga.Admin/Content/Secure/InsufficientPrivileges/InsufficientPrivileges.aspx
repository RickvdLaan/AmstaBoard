<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Main.Master" AutoEventWireup="true" CodeBehind="InsufficientPrivileges.aspx.cs" Inherits="AmstaJanBonga.Admin.Content.Secure.InsufficientPrivileges.InsufficientPrivileges" %>
<asp:Content ID="Content1" ContentPlaceHolderID="_cphHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="_cphMainTitle" runat="server">
    Proces gestopt
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="_cphSubTitle" runat="server">
    Onvoldoende rechten
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="_cphExplanation" runat="server">
    Deze pagina komt naar voren omdat een actie is uitgevoerd waartoe u niet bevoegd bent. 
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="_cphContent" runat="server">
    <div class="box">
         <h1 class="h1-error">
        <i class="fa fa-exclamation-circle" aria-hidden="true"></i>

        Onvoldoende rechten
    </h1>

    <p>
        Uw account heeft niet de juiste bevoegdheden om deze actie uit te voeren. Indien dit incorrect is dient u contact opnemen met de beheerder van de applicatie.
        Druk <asp:HyperLink runat="server" NavigateUrl="~/Dashboard">hier</asp:HyperLink> om terug te gaan naar het hoofdscherm.
    </p>
    </div> 
</asp:Content>
