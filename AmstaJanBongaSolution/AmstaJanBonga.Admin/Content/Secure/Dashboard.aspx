<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Main.Master" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="AmstaJanBonga.Admin.Content.Secure.Dashboard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="_cphContent" runat="server">
    <asp:Button runat="server" ID="_btnSignout" OnClick="_btnSignout_Click" Text="Uitloggen"/>
</asp:Content>
