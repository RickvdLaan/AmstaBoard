<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Main.Master" AutoEventWireup="true" CodeBehind="PatientOverview.aspx.cs" Inherits="AmstaJanBonga.Admin.Content.Secure.Patient.PatientOverview" %>

<%@ Import namespace="Rlaan.Toolkit.Extensions" %>
<%@ Import namespace="AmstaJanBonga.Business.Enums" %>

<asp:Content ID="Content1" ContentPlaceHolderID="_cphHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="_cphMainTitle" runat="server">
    Bewoners
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="_cphSubTitle" runat="server">
    Overzicht
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="_cphExplanation" runat="server">
    Dit is het overzicht van de bewoners, op deze pagina zijn alle bewoners te vinden die zijn toegevoegd aan het systeem. Vanuit hier is
    het mogelijk om bewoners toe te voegen, te bekijken, wijzigen en de agenda aan te passen van de geselecteerde bewoner.
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="_cphContent" runat="server">
     <div class="box">
        <h2>Bewoners</h2>
            
        <div class="shortcut">
            <asp:HyperLink runat="server" CssClass="fa fa-plus-circle" Text="Bewoner Toevoegen" NavigateUrl="~/Content/Secure/Patient/PatientAddEdit.aspx"></asp:HyperLink>
        </div>
       
        <div class="gridview">
            <asp:GridView runat="server" ID="_gvPatients" OnPreRender="_gvPatients_PreRender" PagerStyle-CssClass="paging" ShowHeaderWhenEmpty="true" AlternatingRowStyle-CssClass="alt" AllowPaging="true" PageSize="10" AllowSorting="false" AutoGenerateColumns="false" OnPageIndexChanging="_gvPatients_PageIndexChanging">
                <Columns>
                    <asp:TemplateField>
                    <HeaderTemplate>
                        Bewoner
                    </HeaderTemplate>

                    <ItemTemplate>
                        <asp:HyperLink runat="server" NavigateUrl='<%# Eval("Id","~/Content/Secure/Patient/PatientDetails.aspx?PatientId={0}") %>'>
                            <%# Eval("FirstName").ToString().CapitalizeFirstLetter() %>
                        </asp:HyperLink>
                    </ItemTemplate>
                    </asp:TemplateField>
    
                    <asp:TemplateField>
                        <HeaderTemplate>
                            Woonkamer
                        </HeaderTemplate>

                        <ItemTemplate>
                            <%# Eval("Name") %>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField ItemStyle-CssClass="options" HeaderStyle-CssClass="center details-width">
                        <HeaderTemplate>
                            Opties
                        </HeaderTemplate>

                        <ItemTemplate>
                            <asp:HyperLink runat="server" ToolTip="Agenda" CssClass="calendar fa fa-calendar" NavigateUrl='<%# Eval("Id","~/Content/Secure/Patient/Agenda/AgendaOverview.aspx?PatientId={0}") %>'></asp:HyperLink>
                            <asp:HyperLink runat="server" ToolTip="Bekijken" CssClass="details fa fa-search" NavigateUrl='<%# Eval("Id","~/Content/Secure/Patient/PatientDetails.aspx?PatientId={0}") %>'></asp:HyperLink>
                            <asp:HyperLink runat="server" ToolTip="Wijzigen" CssClass="edit fa fa-pencil" NavigateUrl='<%# Eval("Id","~/Content/Secure/Patient/PatientAddEdit.aspx?PatientId={0}") %>'></asp:HyperLink>
                            <asp:LinkButton runat="server" ToolTip="Verwijderen" CssClass="delete fa fa-times" OnClick="_lbDelete_Click" OnClientClick="return confirm('U staat op het punt om deze bewoner te verwijderen. Weet u het zeker?');" CommandArgument='<%# Eval("Id") %>'></asp:LinkButton>
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
