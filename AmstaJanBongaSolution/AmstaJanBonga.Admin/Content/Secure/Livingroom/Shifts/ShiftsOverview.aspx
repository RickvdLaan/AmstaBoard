<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Main.Master" AutoEventWireup="true" CodeBehind="ShiftsOverview.aspx.cs" Inherits="AmstaJanBonga.Admin.Content.Secure.Livingroom.Shifts.ShiftsOverview" %>

<%@ Import namespace="Rlaan.Toolkit.Extensions" %>
<%@ Import namespace="AmstaJanBonga.Business.Enums" %>

<asp:Content ID="Content1" ContentPlaceHolderID="_cphHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="_cphMainTitle" runat="server">
    Diensten
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="_cphSubTitle" runat="server">
    Overzicht
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="_cphExplanation" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="_cphContent" runat="server">
    <div class="box">
        <h2>Diensten</h2>

        <div class="shortcut">
            <div class="return right">
                <asp:HyperLink runat="server" CssClass="return fa fa-reply display-inline" ToolTip="Terug naar woonkameroverzicht" NavigateUrl="~/Content/Secure/LivingRoom/LivingRoomOverview.aspx"></asp:HyperLink>
            </div>

            <asp:HyperLink runat="server" ID="_hlAddEditShifts" CssClass="fa fa-plus-circle" Text="Dienst Toevoegen"></asp:HyperLink>

            <div class="clear"></div>
        </div>
       
        <div class="gridview">
            <asp:GridView runat="server" ID="_gvShifts" OnPreRender="_gvShifts_PreRender" OnPageIndexChanging="_gvShifts_PageIndexChanging" PagerStyle-CssClass="paging" ShowHeaderWhenEmpty="true" AlternatingRowStyle-CssClass="alt" AllowPaging="true" PageSize="10" AllowSorting="false" AutoGenerateColumns="false">
                <Columns>    
                    <asp:TemplateField>
                        <HeaderTemplate>
                            Datum
                        </HeaderTemplate>

                        <ItemTemplate>
                             <asp:HyperLink runat="server" NavigateUrl='<%# "~/Content/Secure/LivingRoom/Shifts/ShiftsDetails.aspx?LivingRoomId={0}&Date={1}".FormatString(DataBinder.Eval(Container.DataItem, "LivingRoomId"), DataBinder.Eval(Container.DataItem, "Date")) %>'>
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
                                <%# Eval("Name").ToString().CapitalizeFirstLetter() %>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField ItemStyle-CssClass="options" HeaderStyle-CssClass="center details-width">
                        <HeaderTemplate>
                            Opties
                        </HeaderTemplate>

                        <ItemTemplate>
                            <asp:HyperLink runat="server" ID="_hlDetails" NavigateUrl='<%# "~/Content/Secure/LivingRoom/Shifts/ShiftsDetails.aspx?LivingRoomId={0}&Date={1}".FormatString(DataBinder.Eval(Container.DataItem, "LivingRoomId"), DataBinder.Eval(Container.DataItem, "Date")) %>' ToolTip="Bekijken" CssClass="details fa fa-search"></asp:HyperLink>
                            <asp:HyperLink runat="server" ID="_hlEdit" NavigateUrl='<%# "~/Content/Secure/LivingRoom/Shifts/ShiftsAddEdit.aspx?LivingRoomId={0}&Date={1}".FormatString(DataBinder.Eval(Container.DataItem, "LivingRoomId"), DataBinder.Eval(Container.DataItem, "Date")) %>' ToolTip="Wijzigen" CssClass="edit fa fa-pencil"></asp:HyperLink>
                            <asp:LinkButton runat="server" ToolTip="Verwijderen" CssClass="delete fa fa-times" OnClick="_lbDelete_Click" OnClientClick="return confirm('U staat op het punt om deze gegevens te verwijderen. Weet u het zeker?');" CommandArgument='<%# "{0}_{1}".FormatString(Eval("LivingRoomId"), Eval("Date")) %>'></asp:LinkButton>
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
