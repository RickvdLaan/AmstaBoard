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
                        
                        </HeaderTemplate>

                        <ItemTemplate>

                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField>
                        <HeaderTemplate>
                            
                        </HeaderTemplate>

                        <ItemTemplate>
                            
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField ItemStyle-CssClass="center" HeaderStyle-CssClass="center details-width">
                        <HeaderTemplate>
                            Opties
                        </HeaderTemplate>

                        <ItemTemplate>
    
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>
