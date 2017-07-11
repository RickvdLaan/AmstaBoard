<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Main.Master" AutoEventWireup="true" CodeBehind="AgendaDetails.aspx.cs" Inherits="AmstaJanBonga.Admin.Content.Secure.Patient.Agenda.AgendaDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="_cphHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="_cphMainTitle" runat="server">
    Afspraak
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="_cphSubTitle" runat="server">
    Bekijken
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="_cphExplanation" runat="server">
    Vanuit hier kan de geselecteerde afspraak worden bekeken of worden gewijzigd.
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="_cphContent" runat="server">
     <div class="box">
        <h2 class="display-inline">
            Bekijken
        </h2>
        
        <div class="shortcut">
            <div class="return right">
                <asp:HyperLink runat="server" ID="_hlReturn" CssClass="return fa fa-reply display-inline" ToolTip="Terug naar agenda overzicht"></asp:HyperLink>
            </div>

            <asp:HyperLink runat="server" ID="_hlEdit" CssClass="edit fa fa-pencil">
                Afspraak bewerken
            </asp:HyperLink>

            <div class="clear"></div>
        </div>

        <table class="table-add-edit">
            <tbody>
                <tr>
                    <td class="label">
                        Titel
                    </td>
                    <td>
                        <asp:Label runat="server" ID="_lblTitle"></asp:Label>
                    </td>
                </tr>

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
                        Tijd
                    </td>
                    <td>
                        <asp:Label runat="server" ID="_lblTime"></asp:Label>
                    </td>
                </tr>

                 <tr>
                    <td class="label">
                        Locatie
                    </td>
                    <td>
                        <asp:Label runat="server" ID="_lblLocation"></asp:Label>
                    </td>
                </tr>

                 <tr>
                    <td class="label">
                        Omschrijving
                    </td>
                    <td>
                        <asp:Label runat="server" ID="_lblDescription"></asp:Label>
                    </td>
                </tr>

                 <tr>
                    <td class="label">
                        Herhaald om de
                    </td>
                    <td>
                        <asp:Label runat="server" ID="_lblRepeatInterval"></asp:Label>
                    </td>
                </tr>
            </tbody>
        </table>
    </div>
</asp:Content>
