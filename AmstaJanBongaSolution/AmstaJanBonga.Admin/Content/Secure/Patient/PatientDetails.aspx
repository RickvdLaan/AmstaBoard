<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Main.Master" AutoEventWireup="true" CodeBehind="PatientDetails.aspx.cs" Inherits="AmstaJanBonga.Admin.Content.Secure.Patient.PatientDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="_cphHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="_cphMainTitle" runat="server">
    Bewoner
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="_cphSubTitle" runat="server">
    Bekijken
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="_cphExplanation" runat="server">
    Vanuit hier kan de geselecteerde bewoner worden bekeken of worden gewijzigd.
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="_cphContent" runat="server">
     <div class="box">
        <h2 class="display-inline">
             Bekijken
        </h2>
        
        <div class="shortcut">
            <div class="return right">
                <asp:HyperLink runat="server" CssClass="return fa fa-reply display-inline" ToolTip="Terug naar gebruikersoverzicht" NavigateUrl="~/Content/Secure/Patient/PatientOverview.aspx"></asp:HyperLink>
            </div>

            <asp:HyperLink runat="server" ID="_hlEdit" CssClass="edit fa fa-pencil">
                Bewoner Bewerken
            </asp:HyperLink>

            <div class="clear"></div>
        </div>

        <table class="table-add-edit">
            <tbody>
                <tr>
                    <td class="label">
                        Voornaam
                    </td>
                    <td>
                        <asp:Label runat="server" ID="_lblFirstName"></asp:Label>
                    </td>
                </tr>

                <tr>
                    <td class="label">
                        Huiskamer
                    </td>
                    <td>
                        <asp:Label runat="server" ID="_lblLivingroom"></asp:Label>
                    </td>
                </tr>

                <tr>
                    <td class="label">
                        Foto
                    </td>
                    <td>
                        <asp:Image runat="server" ID="_imgPatient" />
                    </td>
                </tr>
            </tbody>
        </table>
    </div>
</asp:Content>
