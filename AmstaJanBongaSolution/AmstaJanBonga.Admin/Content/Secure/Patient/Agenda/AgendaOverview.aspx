﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Main.Master" AutoEventWireup="true" CodeBehind="AgendaOverview.aspx.cs" Inherits="AmstaJanBonga.Admin.Content.Secure.Patient.Agenda.AgendaOverview" %>

<%@ Import namespace="Rlaan.Toolkit.Extensions" %>

<asp:Content ID="Content1" ContentPlaceHolderID="_cphHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="_cphMainTitle" runat="server">
    Agenda
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="_cphSubTitle" runat="server">
    Overzicht
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="_cphExplanation" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="_cphContent" runat="server">
    <div class="box">
        <h2>Agenda van <%= Patient.FirstName %></h2>

        <div class="shortcut">
            <div class="return right">
                <asp:HyperLink runat="server" CssClass="return fa fa-reply display-inline" ToolTip="Terug naar bewoneroverzicht" NavigateUrl="~/Content/Secure/Patient/PatientOverview.aspx"></asp:HyperLink>
            </div>

            <asp:HyperLink runat="server" ID="_hlAddEvent" CssClass="fa fa-plus-circle" Text="Afspraak Toevoegen"></asp:HyperLink>
            <%--<asp:HyperLink runat="server" CssClass="fa fa-plus-circle" Text="Bericht Toevoegen"></asp:HyperLink>--%>
            
            <div class="clear"></div>
        </div>
        
        <h3>Herhalende afspraken</h3>

        <div class="gridview">
            <asp:GridView runat="server" ID="_gvPatientAgendaRepeat" OnPreRender="_gvPatientAgendaRepeat_PreRender" ShowHeaderWhenEmpty="true" AlternatingRowStyle-CssClass="alt" AllowPaging="true" PageSize="10" AllowSorting="false" AutoGenerateColumns="false" OnPageIndexChanging="_gvPatientAgendaRepeat_PageIndexChanging">
                <Columns>
                   <asp:TemplateField>
                        <HeaderTemplate>
                            Titel
                        </HeaderTemplate>

                        <ItemTemplate>
                            <%# Eval("AgendaEvent.Title") %>
                        </ItemTemplate>
                    </asp:TemplateField>

                    
                    <asp:TemplateField>
                        <HeaderTemplate>
                            Dag
                        </HeaderTemplate>

                        <ItemTemplate>
                           <%# new System.Globalization.CultureInfo("nl-NL").DateTimeFormat.GetDayName(
                                    Time.UnixTime.UnixTimeStampToDateTime(Eval("EventUnixTimeStamp").ToString().ToInt()).DayOfWeek).CapitalizeFirstLetter() %>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField>
                        <HeaderTemplate>
                            Tijd
                        </HeaderTemplate>

                        <ItemTemplate>
                            <%# new Time(Eval("AgendaEvent.TimeStart").ToString().ToInt()).ToString() %> -  <%# new Time(Eval("AgendaEvent.TimeEnd").ToString().ToInt()).ToString()  %>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField>
                        <HeaderTemplate>
                            Herhalend om
                        </HeaderTemplate>

                        <ItemTemplate>
                            <%# Time.UnixTime.UnixTimeStampToDateTime(Eval("RepeatInterval").ToString().ToInt()).Day - 1 %> dagen
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField ItemStyle-CssClass="options" HeaderStyle-CssClass="center details-width">
                        <HeaderTemplate>
                            Opties
                        </HeaderTemplate>

                        <ItemTemplate>
                            <asp:HyperLink runat="server" ToolTip="Bekijken" CssClass="details fa fa-search" NavigateUrl='<%# Eval("Id","~/Content/Secure/Patient/Agenda/AgendaDetails.aspx?AgendaEventMetaId={0}") %>'></asp:HyperLink>
                            <asp:HyperLink runat="server" ToolTip="Wijzigen" CssClass="edit fa fa-pencil" NavigateUrl='<%# "~/Content/Secure/Patient/Agenda/AgendaAddEdit.aspx?AgendaEventMetaId={0}&PatientId={1}".FormatString(Eval("Id"), Eval("PatientId")) %>'></asp:HyperLink>
                            <asp:HyperLink runat="server" ToolTip="Verwijderen" CssClass="delete fa fa-times"></asp:HyperLink>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>

                <EmptyDataTemplate>
                    Er zijn nog geen herhalende afspraken ingepland.
                </EmptyDataTemplate>
            </asp:GridView>
        </div>

        <h3>Eenmalige afspraken</h3>

         <div class="gridview">
            <asp:GridView runat="server" ID="_gvPatientAgenda" OnPreRender="_gvPatientAgenda_PreRender" ShowHeaderWhenEmpty="true" AlternatingRowStyle-CssClass="alt" AllowPaging="true" PageSize="10" AllowSorting="false" AutoGenerateColumns="false" OnPageIndexChanging="_gvPatientAgenda_PageIndexChanging">
                <Columns>
                   <asp:TemplateField>
                        <HeaderTemplate>
                            Titel
                        </HeaderTemplate>

                        <ItemTemplate>
                            
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField ItemStyle-CssClass="options" HeaderStyle-CssClass="center details-width">
                        <HeaderTemplate>
                            Opties
                        </HeaderTemplate>

                        <ItemTemplate>
                            <asp:HyperLink runat="server" ToolTip="Bekijken" CssClass="details fa fa-search" NavigateUrl='<%# Eval("Id","") %>'></asp:HyperLink>
                            <asp:HyperLink runat="server" ToolTip="Wijzigen" CssClass="edit fa fa-pencil" NavigateUrl='<%# Eval("Id","") %>'></asp:HyperLink>
                            <asp:HyperLink runat="server" ToolTip="Verwijderen" CssClass="delete fa fa-times"></asp:HyperLink>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>

                <EmptyDataTemplate>
                    Er zijn geen nieuwe afspraken ingepland.
                </EmptyDataTemplate>
            </asp:GridView>
        </div>
    </div>
</asp:Content>