<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Main.Master" AutoEventWireup="true" CodeBehind="PatientAgendaOverview.aspx.cs" Inherits="AmstaJanBonga.Web.Content.PatientAgendaOverview.PatientAgendaOverview" %>
<asp:Content ID="Content1" ContentPlaceHolderID="_cphHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="_cphContent" runat="server">
    <!-- Title -->
    <div class="agenda">
        <h2>
            Agenda bewoners
            <i class="fa fa-calendar" aria-hidden="true"></i>
        </h2>
    </div>

    <!-- Patients -->
    <div class="patient-overview">
        <asp:Repeater runat="server" ID="_repPatients">
            <ItemTemplate>
                <!-- Row -->
                <%# (Container.ItemIndex + 5) % 5 == 0 ? "<div style=\"display: table-row\">" : string.Empty %>

                <!-- Cell -->
                <div class="tile-container-cell">
                    <asp:HyperLink runat="server" NavigateUrl='<%# "~/Content/Secure/PatientAgenda/PatientAgenda.aspx#" + DateTime.Now.Hour.ToString() + ":00" %>' style="display:block;">
                        <asp:Image runat="server" CssClass="image-patients" ImageUrl="~/Includes/Css/Images/avatar.jpg" />

                        <h3 style="text-align: center;"><%# Eval("Name") %></h3>
                    </asp:HyperLink>
                </div>

                 <%# (Container.ItemIndex + 5) % 5 == 4 ? "</div>" : string.Empty %>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</asp:Content>
