<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Main.Master" AutoEventWireup="true" CodeBehind="PatientAgenda.aspx.cs" Inherits="AmstaJanBonga.Web.Content.PatientAgenda.PatientAgenda" %>
<asp:Content ID="Content1" ContentPlaceHolderID="_cphHead" runat="server">
    <script src="../../Includes/Js/calendar-appointments.js"></script>

    <link href="../../Includes/remodal-1.1.1/dist/remodal-default-theme.css" rel="stylesheet" />
    <link href="../../Includes/remodal-1.1.1/dist/remodal.css" rel="stylesheet" />
    <script src="../../Includes/remodal-1.1.1/dist/remodal.min.js"></script>
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

            <asp:Panel runat="server" ID="_pnlDayHeader" CssClass="calendar-header blue-bg" Visible="true">
                <h2>
                    Vandaag
                </h2>
            </asp:Panel>

            <asp:Panel runat="server" ID="_pnlWeekHeader" CssClass="calendar-header blue-bg" Visible="false">
                <div class="week">Maandag   </div>
                <div class="week">Dinsdag   </div>
                <div class="week">Woensdag  </div>
                <div class="week">Donderdag </div>
                <div class="week">Vrijdag   </div>
                <div class="week">Zaterdag  </div>
                <div class="week">Zondag    </div>
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
                            <asp:Panel runat="server" ID="_pnlDay" Visible="true">
                                <td class="column-day">
                                    <asp:Repeater runat="server" ID="_repAgendaDay">
                                        <ItemTemplate>
                                                <%# Eval("Appointments") %>
                                        </ItemTemplate>
                                    </asp:Repeater>
                                </td>
                            </asp:Panel>
                            
                            <!-- Week -->
                            <asp:Panel runat="server" ID="_pnlWeek" Visible="false">
                                 <asp:Repeater runat="server" ID="_repAgendaWeek" OnItemDataBound="_repAgendaWeek_ItemDataBound">
                                        <ItemTemplate>
                                            <td class="column-day">
                                                <%# Eval("Days") %>

                                                <asp:Repeater runat="server" ID="_repAgendaWeekChild">
                                                    <ItemTemplate>
                                                        <%# Eval("Appointments") %>
                                                    </ItemTemplate>
                                                </asp:Repeater>
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
    
    <div class="remodal red-bg no-select" data-remodal-id="appointment-remodal" data-remodal-options="hashTracking: false">
        <table>
            <thead>
                <tr>
                    <td colspan="2">
                        <h2>Naam van de afspraak</h2>
                    </td>
                </tr>
            </thead>

            <tbody>
                <tr>
                    <td class="label">
                        Waar:
                    </td>

                    <td>
                        De woonkamer.
                    </td>
                </tr>

                <tr>
                    <td class="label">
                        Tijdstip:
                    </td>

                    <td>
                        Van 14:00 tot 17:00 uur.
                    </td>
                </tr>

                <tr>
                    <td class="label">
                        Omschrijving:
                    </td>

                    <td>
                        Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum porttitor sollicitudin volutpat. 
                        Nulla consectetur neque id nulla dignissim, ac faucibus velit posuere.
                    </td>
                </tr>
            </tbody>

            <tfoot>
                <tr>
                    <td colspan="2">
                        <button data-remodal-action="confirm" class="remodal-confirm">Oke</button>
                    </td>
                </tr>
            </tfoot>
        </table>
    </div>
</asp:Content>