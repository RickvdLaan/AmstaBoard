﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Main.Master" AutoEventWireup="true" CodeBehind="ChoresDetails.aspx.cs" Inherits="AmstaJanBonga.Admin.Content.Secure.Livingroom.Chores.ChoresDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="_cphHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="_cphMainTitle" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="_cphSubTitle" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="_cphExplanation" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="_cphContent" runat="server">
    <div class="box">
        <h2 class="display-inline">
            Bekijken
        </h2>

        <div class="return right">
            <asp:HyperLink runat="server" ID="_hlReturn" CssClass="return fa fa-reply display-inline" ToolTip="Terug naar corvee overzicht"></asp:HyperLink>
        </div>

        <div class="clear"></div>
        
        <div class="shortcut">
            <asp:HyperLink runat="server" ID="_hlEdit" CssClass="edit fa fa-pencil">
                Corvee bewerken
            </asp:HyperLink>
        </div>

        <table class="table-add-edit">
            <tbody>
                <tr>
                    <td class="label">
                        Datum
                    </td>
                    <td>
                        <asp:Label runat="server" ID="_lblDate"></asp:Label>
                    </td>
                </tr>

                <tr>
                    <td class="label">
                        Woonkamer
                    </td>
                    <td>
                        <asp:Label runat="server" ID="_lblLivingroom"></asp:Label>
                    </td>
                </tr>

                <tr>
                    <td class="label">
                        Ochtend
                    </td>
                    <td>
                        <asp:Label runat="server" ID="_lblMorning"></asp:Label>
                    </td>
                </tr>
                
                <tr>
                    <td class="label">
                        Middag
                    </td>
                    <td>
                        <asp:Label runat="server" ID="_lblAfternoon"></asp:Label>
                    </td>
                </tr>
             
                <tr>
                    <td class="label">
                        Avond
                    </td>
                    <td>
                        <asp:Label runat="server" ID="_lblEvening"></asp:Label>
                    </td>
                </tr>
            </tbody>
        </table>
    </div>
</asp:Content>