<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Main.Master" AutoEventWireup="true" CodeBehind="Livingroom.aspx.cs" Inherits="AmstaJanBonga.Web.Content.Livingroom.Livingroom" %>
<asp:Content ID="Content1" ContentPlaceHolderID="_cphHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="_cphContent" runat="server">

    <asp:Image runat="server" CssClass="amsta" ImageUrl="~/Includes/Css/Images/Amsta.png" />

    <div class="livingroom">
        <h2>
            Woonkamer
        </h2>

        <div class="tile-wrapper-livingroom red-bg">
            <asp:HyperLink runat="server" CssClass="tile-container-cell livingroom-tile" NavigateUrl="~/Content/Home/Home.aspx">       
                    Woonkamer Stimuleren
            </asp:HyperLink>
        </div>

        <div class="tile-wrapper-livingroom purple-bg">
            <asp:HyperLink runat="server" CssClass="tile-container-cell livingroom-tile" NavigateUrl="~/Content/Home/Home.aspx">       
                    Woonkamer B
            </asp:HyperLink>
        </div>

        <div class="tile-wrapper-livingroom orange-bg">
            <asp:HyperLink runat="server" CssClass="tile-container-cell livingroom-tile" NavigateUrl="~/Content/Home/Home.aspx">       
                    Woonkamer C
            </asp:HyperLink>
        </div>

        <div class="tile-wrapper-livingroom green-bg">
            <asp:HyperLink runat="server" CssClass="tile-container-cell livingroom-tile" NavigateUrl="~/Content/Home/Home.aspx">       
                    Woonkamer D
            </asp:HyperLink>
        </div>
    </div>
</asp:Content>