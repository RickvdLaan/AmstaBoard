<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Main.Master" AutoEventWireup="true" CodeBehind="LivingroomOverview.aspx.cs" Inherits="AmstaJanBonga.Admin.Content.Secure.Livingroom.LivingroomOverview" %>

<%@ Import namespace="Rlaan.Toolkit.Extensions" %>
<%@ Import namespace="AmstaJanBonga.Business.Enums" %>

<asp:Content ID="Content1" ContentPlaceHolderID="_cphHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="_cphMainTitle" runat="server">
    Woonkamer
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="_cphSubTitle" runat="server">
    Overzicht
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="_cphExplanation" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="_cphContent" runat="server">
    <div class="box">
        <h2>Woonkamers</h2>

        <div class="shortcut">
            <asp:HyperLink runat="server" CssClass="fa fa-plus-circle" Text="Woonkamer Toevoegen" NavigateUrl="~/Content/Secure/Livingroom/LivingroomAddEdit.aspx"></asp:HyperLink>
        </div>
       
        <div class="gridview">
            <asp:GridView runat="server" ID="_gvLivingrooms" HeaderStyle-CssClass="gridview-header" OnPreRender="_gvLivingrooms_PreRender" ShowHeaderWhenEmpty="true" AlternatingRowStyle-CssClass="alt" AllowPaging="false" AllowSorting="false" AutoGenerateColumns="false">
                <Columns>          
                    <asp:TemplateField>
                        <HeaderTemplate>
                            Woonkamer
                        </HeaderTemplate>

                        <ItemTemplate>
                            <asp:HyperLink runat="server" NavigateUrl='<%# Eval("Id","~/Content/Secure/Livingroom/LivingroomDetails.aspx?LivingRoomId={0}") %>'>
                                <%# Eval("Name").ToString().CapitalizeFirstLetter() %>
                            </asp:HyperLink>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField>
                        <HeaderTemplate>
                            Kleur
                        </HeaderTemplate>

                        <ItemTemplate>
                             <%#  ((ColourTypeEnum)Enum.Parse(typeof(ColourTypeEnum), Eval("ColourTypeEnum").ToString())).Description() %>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField ItemStyle-CssClass="options" HeaderStyle-CssClass="center details-width">
                        <HeaderTemplate>
                            Opties
                        </HeaderTemplate>

                        <ItemTemplate>
                            <asp:HyperLink runat="server" ToolTip="Diensten" CssClass="fa fa-clock-o" aria-hidden="true" NavigateUrl='<%# Eval("Id", "~/Content/Secure/Livingroom/Shifts/ShiftsOverview.aspx?LivingRoomId={0}") %>'></asp:HyperLink>
                            <asp:HyperLink runat="server" ToolTip="Algemeen" CssClass="fa fa-coffee" aria-hidden="true" NavigateUrl='<%# Eval("Id","~/Content/Secure/Livingroom/General/GeneralOverview.aspx?LivingRoomId={0}") %>'></asp:HyperLink>
                            <asp:HyperLink runat="server" ToolTip="Corvee" CssClass="fa fa-trash-o" aria-hidden="true" NavigateUrl='<%# Eval("Id","~/Content/Secure/Livingroom/Chores/ChoresOverview.aspx?LivingRoomId={0}") %>'></asp:HyperLink>
                            <asp:HyperLink runat="server" ToolTip="Bekijken" CssClass="details fa fa-search" NavigateUrl='<%# Eval("Id","~/Content/Secure/Livingroom/LivingroomDetails.aspx?LivingRoomId={0}") %>'></asp:HyperLink>
                            <asp:HyperLink runat="server" ToolTip="Wijzigen" CssClass="edit fa fa-pencil" NavigateUrl='<%# Eval("Id","~/Content/Secure/Livingroom/LivingroomAddEdit.aspx?LivingRoomId={0}") %>'></asp:HyperLink>
                            <asp:HyperLink runat="server" ToolTip="Verwijderen" CssClass="delete fa fa-times"></asp:HyperLink>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>
