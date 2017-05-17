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
     <div class="box">
        <h2>
            Snelkoppelingen
        </h2>
        <div class="shortcut">
            <asp:HyperLink runat="server" CssClass="fa fa-plus-circle" Text="Gebruiker Toevoegen"></asp:HyperLink>
        </div>
    </div>

    <div class="box">
        Claim check

        <asp:GridView ID="ClaimsGridView" runat="server" CellPadding="3">  
            <AlternatingRowStyle BackColor="White" />  
            <HeaderStyle BackColor="#7AC0DA" ForeColor="White" />  
        </asp:GridView>  
    </div>
</asp:Content>
