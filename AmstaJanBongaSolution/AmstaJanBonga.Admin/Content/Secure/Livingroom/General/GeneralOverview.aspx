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
            <asp:HyperLink runat="server" ID="_hlAddEditGeneralEvent" CssClass="fa fa-plus-circle" Text="Gegevens Toevoegen"></asp:HyperLink>
            <asp:HyperLink runat="server" ID="_hlAddEditGeneral" CssClass="fa fa-pencil" Text="Algemeen bericht bewerken"></asp:HyperLink>

            <div class="return right">
                <asp:HyperLink runat="server" CssClass="return fa fa-reply display-inline" ToolTip="Terug naar woonkameroverzicht" NavigateUrl="~/Content/Secure/Livingroom/LivingroomOverview.aspx"></asp:HyperLink>
            </div>

            <div class="clear"></div>
        </div>
       
        <div class="gridview">
            <asp:GridView runat="server" ID="_gvGeneral" OnPreRender="_gvGeneral_PreRender" ShowHeaderWhenEmpty="true" AlternatingRowStyle-CssClass="alt" AllowPaging="false" AllowSorting="false" AutoGenerateColumns="false">
                <Columns>    
                    <asp:TemplateField>
                        <HeaderTemplate>
                            Datum
                        </HeaderTemplate>

                        <ItemTemplate>
                            <asp:HyperLink runat="server" NavigateUrl='<%# "~/Content/Secure/Livingroom/General/GeneralDetails.aspx?LivingRoomId={0}&Date={1}".FormatString(DataBinder.Eval(Container.DataItem, "LivingRoomId"), DataBinder.Eval(Container.DataItem, "Date")) %>'>
                                 <%# "{0} {1} {2}".FormatString(
                                new System.Globalization.CultureInfo("nl-NL").DateTimeFormat.GetDayName(Convert.ToDateTime(Eval("Date")).DayOfWeek), 
                                Convert.ToDateTime(Eval("Date")).Day, 
                                new System.Globalization.CultureInfo("nl-NL").DateTimeFormat.GetMonthName(Convert.ToDateTime(Eval("Date")).Month)) %>
                            </asp:HyperLink>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField>
                        <HeaderTemplate>
                            Woonkamer
                        </HeaderTemplate>

                        <ItemTemplate>
                                <%# Eval("LivingRoom.Name").ToString().CapitalizeFirstLetter() %>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField ItemStyle-CssClass="options" HeaderStyle-CssClass="center details-width">
                        <HeaderTemplate>
                            Opties
                        </HeaderTemplate>

                        <ItemTemplate>
                            <asp:HyperLink runat="server" ID="_hlDetails" NavigateUrl='<%# "~/Content/Secure/Livingroom/General/GeneralDetails.aspx?LivingRoomId={0}&Date={1}".FormatString(DataBinder.Eval(Container.DataItem, "LivingRoomId"), DataBinder.Eval(Container.DataItem, "Date")) %>' ToolTip="Bekijken" CssClass="details fa fa-search"></asp:HyperLink>
                            <asp:HyperLink runat="server" ID="_hlEdit" NavigateUrl='<%# "~/Content/Secure/Livingroom/General/GeneralEventAddEdit.aspx?LivingRoomId={0}&Date={1}".FormatString(DataBinder.Eval(Container.DataItem, "LivingRoomId"), DataBinder.Eval(Container.DataItem, "Date")) %>' ToolTip="Wijzigen" CssClass="edit fa fa-pencil"></asp:HyperLink>
                            <asp:HyperLink runat="server" ToolTip="Verwijderen" CssClass="delete fa fa-times"></asp:HyperLink>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>

                <EmptyDataTemplate>
                    Er zijn nog geen gegevens ingevoerd.
                </EmptyDataTemplate>
            </asp:GridView>
        </div>
    </div>
</asp:Content>
