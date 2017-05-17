<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Main.Master" AutoEventWireup="true" CodeBehind="UserDetails.aspx.cs" Inherits="AmstaJanBonga.Admin.Content.Secure.User.UserDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="_cphHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="_cphMainTitle" runat="server">
    Gebruiker
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="_cphSubTitle" runat="server">
    Bekijken
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="_cphExplanation" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="_cphContent" runat="server">
     <div class="box">
        <h2 class="display-inline">
             Bekijken
        </h2>

        <div class="return right">
            <asp:HyperLink runat="server" CssClass="return fa fa-reply display-inline" ToolTip="Terug naar gebruikersoverzicht" NavigateUrl="~/Content/Secure/User/UserOverview.aspx"></asp:HyperLink>
        </div>

        <div class="clear"></div>
        
        <div class="shortcut">
            <asp:HyperLink runat="server" ID="_hlEdit" CssClass="edit fa fa-pencil">
                Gebruiker Bewerken
            </asp:HyperLink>
        </div>

        <table class="table-add-edit">
            <tbody>
                <tr>
                    <td class="label">
                        Gebruikersnaam
                    </td>
                    <td>
                        <asp:Label runat="server" ID="_lblUsername"></asp:Label>
                    </td>
                </tr>

                <tr>
                    <td class="label">
                        Account type
                    </td>
                    <td>
                        <asp:Label runat="server" ID="_lblRoleType"></asp:Label>
                    </td>
                </tr>
            </tbody>
        </table>
    </div>
</asp:Content>
