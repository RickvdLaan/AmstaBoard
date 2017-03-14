<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Main.Master" AutoEventWireup="true" CodeBehind="LivingroomOverview.aspx.cs" Inherits="AmstaJanBonga.Web.Content.Livingroom.Livingroom" %>
<asp:Content ID="Content1" ContentPlaceHolderID="_cphHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="_cphContent" runat="server">
    <!-- Livingrooms -->
    <div class="livingroom">
        <h2>
            Woonkamers
        </h2>

        <div class="tile-wrapper-livingroom red-bg">
            <asp:HyperLink runat="server" CssClass="tile-container-cell livingroom-tile button-press" NavigateUrl="~/Content/Livingroom/Livingroom.aspx">       
                    Woonkamer Stimuleren
            </asp:HyperLink>
        </div>

        <div class="tile-wrapper-livingroom purple-bg">
            <asp:HyperLink runat="server" CssClass="tile-container-cell livingroom-tile button-press" NavigateUrl="~/Content/Livingroom/Livingroom.aspx">       
                    Woonkamer B
            </asp:HyperLink>
        </div>

        <div class="tile-wrapper-livingroom orange-bg">
            <asp:HyperLink runat="server" CssClass="tile-container-cell livingroom-tile button-press" NavigateUrl="~/Content/Livingroom/Livingroom.aspx">       
                    Woonkamer C
            </asp:HyperLink>
        </div>

        <div class="tile-wrapper-livingroom green-bg">
            <asp:HyperLink runat="server" CssClass="tile-container-cell livingroom-tile button-press" NavigateUrl="~/Content/Livingroom/Livingroom.aspx">       
                    Woonkamer D
            </asp:HyperLink>
        </div>
    </div>

    <!-- Logo -->
    <asp:Image runat="server" CssClass="amsta" ImageUrl="~/Includes/Css/Images/Amsta.png" />
</asp:Content>