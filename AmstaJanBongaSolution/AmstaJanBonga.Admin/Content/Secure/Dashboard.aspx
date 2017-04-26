<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Main.Master" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="AmstaJanBonga.Admin.Content.Secure.Dashboard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="_cphHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="_cphMainTitle" runat="server">
    Dashboard
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="_cphSubTitle" runat="server">
    Overzicht
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="_cphExplanation" runat="server">
    Bepaalde uitleg hier.
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="_cphContent" runat="server">
    <div class="warning">
        <h2>
            Let op!
        </h2>
        <p>
            Dit is een product in ontwikkeling en onderdelen in deze versie kunnen anders werken dan wellicht wordt verwacht. 
            
            Het uiterlijk is ook niet definitief en alles m.b.t. het uiterlijk wordt in de loop van het project veranderd. 
            
            Bepaalde onderdelen werken wel en andere nog niet en de functionaliteiten en bereikbaarheid van de software kan niet gegarrandeerd worden gedurende deze fase. 
        </p>
    </div>


     <div class="box">
        <h2>
            Snelkoppelingen
        </h2>
        <div class="shortcut">
            <asp:HyperLink runat="server" CssClass="fa fa-plus-circle" Text="Gebruiker Toevoegen"></asp:HyperLink>
        </div>
    </div>
</asp:Content>
