﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Main.Master" AutoEventWireup="true" CodeBehind="UserOverview.aspx.cs" Inherits="AmstaJanBonga.Admin.Content.Secure.User.UserOverview" %>

<%@ Import namespace="Rlaan.Toolkit.Extensions" %>
<%@ Import namespace="AmstaJanBonga.Business.Enums" %>

<asp:Content ID="Content1" ContentPlaceHolderID="_cphHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="_cphMainTitle" runat="server">
    Gebruikers
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="_cphSubTitle" runat="server">
    Overzicht
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="_cphExplanation" runat="server">
    Dit is het gebruikersoverzicht, vanuit hier kunnen alle gebruikers worden beheerd.
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="_cphContent" runat="server">
     <div class="box">
        <h2>Gebruikers</h2>

        <div class="shortcut">
            <asp:HyperLink runat="server" CssClass="fa fa-plus-circle" Text="Gebruiker Toevoegen" NavigateUrl="~/Content/Secure/User/UserAddEdit.aspx"></asp:HyperLink>
        </div>
       
        <div class="gridview">
            <asp:GridView runat="server" ID="_gvUsers" OnPreRender="_gvUsers_PreRender" OnPageIndexChanging="_gvUsers_PageIndexChanging" PagerStyle-CssClass="paging" ShowHeaderWhenEmpty="true" AlternatingRowStyle-CssClass="alt" AllowPaging="true" PageSize="10" AllowSorting="false" AutoGenerateColumns="false">
                <Columns>          
                     <asp:TemplateField>
                        <HeaderTemplate>
                            Gebruiker
                        </HeaderTemplate>

                        <ItemTemplate>
                            <asp:HyperLink runat="server" NavigateUrl='<%# Eval("Id", "~/Content/Secure/User/UserDetails.aspx?UserId={0}") %>'>
                                <%# Eval("Username").ToString().CapitalizeFirstLetter() %>
                            </asp:HyperLink>
                        </ItemTemplate>
                     </asp:TemplateField>

                    <asp:TemplateField>
                        <HeaderTemplate>
                            Functie
                        </HeaderTemplate>

                        <ItemTemplate>
                            <%#  ((RoleTypeEnum)Enum.Parse(typeof(RoleTypeEnum), Eval("UserRole.RoleTypeEnum").ToString())).Description() %>
                        </ItemTemplate>
                    </asp:TemplateField>
    
                    <asp:TemplateField ItemStyle-CssClass="options" HeaderStyle-CssClass="center details-width">
                        <HeaderTemplate>
                            Opties
                        </HeaderTemplate>

                        <ItemTemplate>
                            <asp:HyperLink runat="server" ToolTip="Bekijken" CssClass="details fa fa-search" NavigateUrl='<%# Eval("Id","~/Content/Secure/User/UserDetails.aspx?UserId={0}") %>'></asp:HyperLink>
                            <asp:HyperLink runat="server" ToolTip="Wachtwoord Wijzigen" CssClass="edit fa fa-lock" NavigateUrl='<%# Eval("Id", "~/Content/Secure/User/UserChangePassword.aspx?UserId={0}") %>'></asp:HyperLink>
                            <asp:HyperLink runat="server" ToolTip="Wijzigen" CssClass="edit fa fa-pencil" NavigateUrl='<%# Eval("Id","~/Content/Secure/User/UserAddEdit.aspx?UserId={0}") %>'></asp:HyperLink>
                            <asp:LinkButton runat="server" ToolTip="Verwijderen" CssClass="delete fa fa-trash" OnClick="_lbDelete_Click" OnClientClick="return confirm('U staat op het punt om deze gebruiker te verwijderen. Weet u het zeker?');" CommandArgument='<%# Eval("Id") %>'></asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>

                <EmptyDataTemplate>
                    Er zijn nog geen gebruikers ingevoerd.
                </EmptyDataTemplate>
            </asp:GridView>
        </div>
    </div>
</asp:Content>
