<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Main.Master" AutoEventWireup="true" CodeBehind="PatientAgenda.aspx.cs" Inherits="AmstaJanBonga.Web.Content.PatientAgenda.PatientAgenda" %>
<asp:Content ID="Content1" ContentPlaceHolderID="_cphHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="_cphContent" runat="server">
    <asp:Image runat="server" CssClass="agenda-image" ImageUrl="~/Includes/Css/Images/avatar.jpg" />

    <table class="agenda-day">
        <thead>
            <tr>
                <td>
                    <!-- Purposely left blank without a colspan for design purposes. -->
                </td>

                <td>
                    Dagoverzicht van [Voornaam]
                </td>
            </tr>

            <tr>
                <td>
                    <!-- Purposely left blank without a colspan for design purposes. -->
                </td>

                <td>
                    Vandaag
                </td>
            </tr>
        </thead>
        
        <tbody>
            <asp:Repeater runat="server" ID="_repAgendaDay">
                <ItemTemplate>
                    <tr>
                        <td>
                            <%# Eval("Time") %>
                        </td>

                        <td>
                            <%# Eval("Appointment") %>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>
