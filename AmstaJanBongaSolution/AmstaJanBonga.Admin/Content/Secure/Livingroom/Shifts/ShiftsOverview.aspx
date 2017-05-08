﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Main.Master" AutoEventWireup="true" CodeBehind="ShiftsOverview.aspx.cs" Inherits="AmstaJanBonga.Admin.Content.Secure.Livingroom.Shifts.ShiftsOverview" %>

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
            <asp:HyperLink runat="server" ID="_hlAddEditShifts" CssClass="fa fa-plus-circle" Text="Dienst Toevoegen"></asp:HyperLink>
        </div>
       
        <div class="gridview">
            <asp:GridView runat="server" ID="_gvShifts" OnPreRender="_gvShifts_PreRender" ShowHeaderWhenEmpty="true" AlternatingRowStyle-CssClass="alt" AllowPaging="false" AllowSorting="false" AutoGenerateColumns="false">
                <Columns>    
                    <asp:TemplateField>
                        <HeaderTemplate>
                            Woonkamer
                        </HeaderTemplate>

                        <ItemTemplate>
                            <asp:HyperLink runat="server" NavigateUrl='<%# "~/Content/Secure/Livingroom/Shifts/ShiftsDetails.aspx?LivingroomId={0}&Date={1}".FormatString(DataBinder.Eval(Container.DataItem, "LivingroomId"), DataBinder.Eval(Container.DataItem, "Date")) %>'>
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

                    <asp:TemplateField ItemStyle-CssClass="options" HeaderStyle-CssClass="center details-width">
                        <HeaderTemplate>
                            Opties
                        </HeaderTemplate>

                        <ItemTemplate>
                            <asp:HyperLink runat="server" ID="_hlDetails" NavigateUrl='<%# "~/Content/Secure/Livingroom/Shifts/ShiftsDetails.aspx?LivingroomId={0}&Date={1}".FormatString(DataBinder.Eval(Container.DataItem, "LivingroomId"), DataBinder.Eval(Container.DataItem, "Date")) %>' ToolTip="Bekijken" CssClass="details fa fa-search"></asp:HyperLink>
                            <asp:HyperLink runat="server" ID="_hlEdit" NavigateUrl='<%# "~/Content/Secure/Livingroom/Shifts/ShiftsAddEdit.aspx?LivingroomId={0}&Date={1}".FormatString(DataBinder.Eval(Container.DataItem, "LivingroomId"), DataBinder.Eval(Container.DataItem, "Date")) %>' ToolTip="Wijzigen" CssClass="edit fa fa-pencil"></asp:HyperLink>
                            <asp:HyperLink runat="server" ToolTip="Verwijderen" CssClass="delete fa fa-times disabled"></asp:HyperLink>
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
