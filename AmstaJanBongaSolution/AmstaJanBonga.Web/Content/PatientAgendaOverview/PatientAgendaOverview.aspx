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
    <div style="display: table; border-spacing: 1em; height: Calc(100% - 100px);">
        <asp:Repeater runat="server" ID="_repPatients">
            <ItemTemplate>
                <!-- Row -->
                <%# (Container.ItemIndex + 5) % 5 == 0 ? "<div style=\"display: table-row\">" : string.Empty %>

                <!-- Cell -->
                <div class="tile-container-cell">
                    <img class="image-patients" src="../../Includes/Css/Images/avatar.jpg">
                    <h3 style="text-align: center;"><%# Eval("Name") %></h3>
                </div>

                 <%# (Container.ItemIndex + 5) % 5 == 4 ? "</div>" : string.Empty %>
            </ItemTemplate>
        </asp:Repeater>
    </div>

    <!-- Back: with ReturnUrl -->
    <asp:HyperLink runat="server" NavigateUrl="~/Content/Livingroom/Livingroom.aspx" CssClass="previous">       
        <i class="fa fa-arrow-left" aria-hidden="true"></i>
    </asp:HyperLink>
</asp:Content>
