<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Main.Master" AutoEventWireup="true" CodeBehind="ChoresOverview.aspx.cs" Inherits="AmstaJanBonga.Admin.Content.Secure.Livingroom.Chores.ChoresOverview" %>

<%@ Import namespace="Rlaan.Toolkit.Extensions" %>
<%@ Import namespace="AmstaJanBonga.Business.Enums" %>

<asp:Content ID="Content1" ContentPlaceHolderID="_cphHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="_cphMainTitle" runat="server">
    Corvee
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="_cphSubTitle" runat="server">
    Overzicht
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="_cphExplanation" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="_cphContent" runat="server">
    <div class="box">
        <h2>Corvee</h2>

        <div class="shortcut">
            <asp:HyperLink runat="server" ID="_hlAddEditChores" CssClass="fa fa-plus-circle" Text="Corvee Toevoegen"></asp:HyperLink>
        </div>
       
        <div class="gridview">
            <asp:GridView runat="server" ID="_gvChores" OnPreRender="_gvChores_PreRender" ShowHeaderWhenEmpty="true" AlternatingRowStyle-CssClass="alt" AllowPaging="false" AllowSorting="false" AutoGenerateColumns="false">
                <Columns>    
                    <asp:TemplateField>
                        <HeaderTemplate>
                            Woonkamer
                        </HeaderTemplate>

                        <ItemTemplate>
                            <asp:HyperLink runat="server" NavigateUrl='<%# "~/Content/Secure/Livingroom/Chores/ChoresDetails.aspx?LivingroomId={0}&Date={1}".FormatString(DataBinder.Eval(Container.DataItem, "LivingroomId"), DataBinder.Eval(Container.DataItem, "Date")) %>'>
                                <%# Eval("Name").ToString().CapitalizeFirstLetter() %>
                            </asp:HyperLink>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField>
                        <HeaderTemplate>
                            Datum
                        </HeaderTemplate>

                        <ItemTemplate>
                            <%# Convert.ToDateTime(Eval("Date")).ToString("dd-MM-yyyy") %>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField ItemStyle-CssClass="center" HeaderStyle-CssClass="center details-width">
                        <HeaderTemplate>
                            Opties
                        </HeaderTemplate>

                        <ItemTemplate>
                            <asp:HyperLink runat="server" ToolTip="Bekijken" CssClass="details fa fa-search disabled"></asp:HyperLink>
                            <asp:HyperLink runat="server" ToolTip="Wijzigen" CssClass="edit fa fa-pencil disabled"></asp:HyperLink>
                            <asp:HyperLink runat="server" ToolTip="Verwijderen" CssClass="delete fa fa-times disabled"></asp:HyperLink>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>
