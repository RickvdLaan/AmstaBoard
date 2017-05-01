<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Main.Master" AutoEventWireup="true" CodeBehind="GeneralOverview.aspx.cs" Inherits="AmstaJanBonga.Admin.Content.Secure.Livingroom.General.GeneralOverview" %>

<%@ Import namespace="Rlaan.Toolkit.Extensions" %>

<asp:Content ID="Content1" ContentPlaceHolderID="_cphHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="_cphMainTitle" runat="server">
    Algemeen
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="_cphSubTitle" runat="server">
    Overzicht
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="_cphExplanation" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="_cphContent" runat="server">
     <div class="box">
        <h2>Algemeen</h2>

        <div class="shortcut">
            <asp:HyperLink runat="server" ID="_hlAddEditGeneral" CssClass="fa fa-plus-circle" Text="Gegevens Toevoegen"></asp:HyperLink>
        </div>
       
        <div class="gridview">
            <asp:GridView runat="server" ID="_gvGeneral" OnPreRender="_gvGeneral_PreRender" ShowHeaderWhenEmpty="true" AlternatingRowStyle-CssClass="alt" AllowPaging="false" AllowSorting="false" AutoGenerateColumns="false">
                <Columns>    
                    <asp:TemplateField>
                        <HeaderTemplate>
                            Woonkamer
                        </HeaderTemplate>

                        <ItemTemplate>
                            <asp:HyperLink runat="server" NavigateUrl='<%# "~/Content/Secure/Livingroom/General/GeneralDetails.aspx?LivingroomId={0}&Date={1}".FormatString(DataBinder.Eval(Container.DataItem, "LivingroomId"), DataBinder.Eval(Container.DataItem, "Date")) %>'>
                               <%# Convert.ToDateTime(Eval("Date")).ToString("dd-MM-yyyy") %>
                            </asp:HyperLink>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField ItemStyle-CssClass="center" HeaderStyle-CssClass="center details-width">
                        <HeaderTemplate>
                            Opties
                        </HeaderTemplate>

                        <ItemTemplate>
                            <asp:HyperLink runat="server" ID="_hlDetails" NavigateUrl='<%# "~/Content/Secure/Livingroom/General/GeneralDetails.aspx?LivingroomId={0}&Date={1}".FormatString(DataBinder.Eval(Container.DataItem, "LivingroomId"), DataBinder.Eval(Container.DataItem, "Date")) %>' ToolTip="Bekijken" CssClass="details fa fa-search"></asp:HyperLink>
                            <asp:HyperLink runat="server" ID="_hlEdit" NavigateUrl='<%# "~/Content/Secure/Livingroom/General/GeneralEventAddEdit.aspx?LivingroomId={0}&Date={1}".FormatString(DataBinder.Eval(Container.DataItem, "LivingroomId"), DataBinder.Eval(Container.DataItem, "Date")) %>' ToolTip="Wijzigen" CssClass="edit fa fa-pencil"></asp:HyperLink>
                            <asp:HyperLink runat="server" ToolTip="Verwijderen" CssClass="delete fa fa-times disabled"></asp:HyperLink>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>
