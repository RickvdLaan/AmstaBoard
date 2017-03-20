﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Main.Master" AutoEventWireup="true" CodeBehind="PatientAgenda.aspx.cs" Inherits="AmstaJanBonga.Web.Content.PatientAgenda.PatientAgenda" %>
<asp:Content ID="Content1" ContentPlaceHolderID="_cphHead" runat="server">
    <script src="../../Includes/Js/calendar-appointments.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="_cphContent" runat="server">
    <!-- The photo of the patient. -->
    <asp:Image runat="server" CssClass="agenda-image" ImageUrl="~/Includes/Css/Images/avatar.jpg" />

    <asp:UpdatePanel runat="server" UpdateMode="Conditional" style="height: Calc(100% - 170px);">
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="_btnSelectDayAgenda" EventName="Click" />
            <asp:AsyncPostBackTrigger ControlID="_btnSelectWeekAgenda" EventName="Click" />
        </Triggers>

        <ContentTemplate>
            <!-- Agenda container --> 
            <div id="agenda-button-container">
                <asp:Button runat="server" Text="Week" CssClass="agenda-button" ID="_btnSelectWeekAgenda" OnClick="_btnSelectWeekAgenda_Click" />
                <asp:Button runat="server" Text="Dag"  CssClass="agenda-button" ID="_btnSelectDayAgenda" OnClick="_btnSelectDayAgenda_Click" />   
            </div>

            <asp:Panel runat="server" ID="_pnlDayHeader" CssClass="calendar-header blue-bg" Visible="false">
                <h2>
                    Vandaag
                </h2>
            </asp:Panel>

            <asp:Panel runat="server" ID="_pnlWeekHeader" CssClass="calendar-header blue-bg" Visible="true">
                Maandag
                Dinsdag
                Woensdag
                Donderdag
                Vrijdag
                Zaterdag
                Zondag
            </asp:Panel>

            <div class="calendar">
                <table>
                    <tbody>
                        <tr>
                            <td style="width:60px;"></td>
                            
                            <td colspan="7">
                                <div class="calendar-hourmarkers-wrapper">
                                    <div class="calendar-hourmarkers">
                                        <div class="calendar-hourmarker-cell"><div class="calendar-hourmarker-cell-inner"></div></div>
                                        <div class="calendar-hourmarker-cell"><div class="calendar-hourmarker-cell-inner"></div></div>
                                        <div class="calendar-hourmarker-cell"><div class="calendar-hourmarker-cell-inner"></div></div>
                                        <div class="calendar-hourmarker-cell"><div class="calendar-hourmarker-cell-inner"></div></div>
                                        <div class="calendar-hourmarker-cell"><div class="calendar-hourmarker-cell-inner"></div></div>
                                        <div class="calendar-hourmarker-cell"><div class="calendar-hourmarker-cell-inner"></div></div>
                                        <div class="calendar-hourmarker-cell"><div class="calendar-hourmarker-cell-inner"></div></div>
                                        <div class="calendar-hourmarker-cell"><div class="calendar-hourmarker-cell-inner"></div></div>
                                        <div class="calendar-hourmarker-cell"><div class="calendar-hourmarker-cell-inner"></div></div>
                                        <div class="calendar-hourmarker-cell"><div class="calendar-hourmarker-cell-inner"></div></div>
                                        <div class="calendar-hourmarker-cell"><div class="calendar-hourmarker-cell-inner"></div></div>
                                        <div class="calendar-hourmarker-cell"><div class="calendar-hourmarker-cell-inner"></div></div>
                                        <div class="calendar-hourmarker-cell"><div class="calendar-hourmarker-cell-inner"></div></div>
                                        <div class="calendar-hourmarker-cell"><div class="calendar-hourmarker-cell-inner"></div></div>
                                        <div class="calendar-hourmarker-cell"><div class="calendar-hourmarker-cell-inner"></div></div>
                                        <div class="calendar-hourmarker-cell 
                                               calendar-hourmarker-cell-last"><div class="calendar-hourmarker-cell-inner"></div></div>
                                    </div>
                                </div>
                            </td>
                        </tr>

                        <tr>
                            <!-- Hours -->
                            <td class="times">
                                <asp:Repeater runat="server" ID="_repTime">
                                    <ItemTemplate>
                                        <div id='<%# Eval("Time") %>'>
                                            <%# Eval("Time") %>
                                        </div>
                                    </ItemTemplate>
                                </asp:Repeater>
                            </td>

                            <!-- Day -->
                            <asp:Panel runat="server" ID="_pnlDay" Visible="false">
                                <td class="column-day">
                                    <asp:Repeater runat="server" ID="_repAgendaDay">
                                        <ItemTemplate>
                                                <%# Eval("Appointments") %>
                                        </ItemTemplate>
                                    </asp:Repeater>
                                </td>
                            </asp:Panel>
                            
                            <!-- Week -->
                            <asp:Panel runat="server" ID="_pnlWeek" Visible="true">
                                 <asp:Repeater runat="server" ID="_repAgendaWeek">
                                        <ItemTemplate>
                                            <td class="column-day">
                                                <%# Eval("Appointments") %>
                                            </td>
                                        </ItemTemplate>
                                    </asp:Repeater>
                                </td>
                            </asp:Panel>
                        </tr>
                    </tbody>
                </table>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>