﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Main.Master" AutoEventWireup="true" CodeBehind="Livingroom.aspx.cs" Inherits="AmstaJanBonga.Web.Content.Home" %>

<%@ Import namespace="Rlaan.Toolkit.Extensions" %>

<asp:Content ID="Content1" ContentPlaceHolderID="_cphHead" runat="server">
    <!-- Sets the width of the staff images based on the amount of staff members -->
    <script>
        $(function () {
            SetStaffImageClasses();
        });

        function SetStaffImageClasses() {
            return;
            var images = $(".staff div.image").length;

            if (images == 3) {
                $('.staff').find('div.image').addClass('image-staff-3');
            }
            else if (images == 2) {
                $('.staff').find('div.image').addClass('image-staff-2');
            }
            else {
                alert("There are less than two images or more than three, this shouldn't be possible.");
            }
        }

        function HiddenFieldPatient(patientId, timeOfDay) {
            var hiddenFieldPatient = document.getElementById('<%= _hfPatient.ClientID %>');

            if (hiddenFieldPatient) {
                hiddenFieldPatient.value = patientId + "_" + timeOfDay;
            }
        }
    </script>

    <link href="/Includes/remodal-1.1.1/dist/remodal-default-theme.css" rel="stylesheet" />
    <link href="/Includes/remodal-1.1.1/dist/remodal.css" rel="stylesheet" />
    <script src="/Includes/remodal-1.1.1/dist/remodal.min.js"></script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="_cphContent" runat="server">
    <!-- Agenda -->
    <div class="tile agenda disabled">
        <h2>
            Agenda bewoners
            <i class="fa fa-calendar" aria-hidden="true"></i>
        </h2>

         <div class="tile-wrapper">
             <asp:HyperLink runat="server" Enabled="false" CssClass="tile-container-cell button-press" NavigateUrl="~/Content/Secure/PatientAgendaOverview/PatientAgendaOverview.aspx">Druk hier om uw agenda te bekijken</asp:HyperLink>
        </div>
    </div>

    <!-- Staff -->
    <div class="tile staff disabled">
        <h2>
            Dag en avonddienst
            <i class="fa fa-clock-o" aria-hidden="true"></i>
        </h2>

        <div class="tile-wrapper">
            <div class="tile-container-cell">
                <h4>Dag</h4>
                <div class="image image-staff image-empty"></div> <%-- data-remodal-target="employee-remodal" />--%>
                <h3>Voornaam</h3>
            </div>

            <div class="tile-container-cell">
                <h4>Dag</h4>
                <div class="image image-staff image-empty"></div> <%-- data-remodal-target="employee-remodal" />--%>
                <h3>Voornaam</h3>
            </div>

            <div class="tile-container-cell">
                <h4>Avond</h4>
                <div class="image image-staff image-empty"></div> <%-- data-remodal-target="employee-remodal" />--%>
                <h3>Voornaam</h3>
            </div>
        </div>
    </div>

    <!-- General -->
    <div class="tile general">
        <h2>
            Algemeen
            <i class="fa fa-coffee" aria-hidden="true"></i>
        </h2>

        <div class="tile-wrapper">
            <div class="tile-container-cell">
                <asp:Literal runat="server" ID="_litGeneral"></asp:Literal>
            </div>
        </div>
    </div>

    <!-- Chores -->
    <div class="tile chores">
        <h2>
            Corvee
            <i class="fa fa-trash-o" aria-hidden="true"></i>
        </h2>

        <asp:HiddenField runat="server" ID="_hfPatient" />

         <div class="tile-wrapper">
            <div class="tile-container-cell">
                <ul>
                    <li>
                        <h3>Ochtend</h3>
                    </li>
                    
                     <asp:Repeater runat="server" ID="_repChoreMorning" OnDataBinding="_repChoreMorning_DataBinding">
                        <ItemTemplate>
                            <li>
                                <div id='<%# Eval("Patient.Id") %>' class="image image-chores" style='background-image: url(<%# Eval("Patient.ImagePath").ToString().Replace('\\', '/')%>);' data-remodal-target="chores-remodal" onclick='HiddenFieldPatient(<%# Eval("Patient.Id") %>, 0)'></div>
                            </li>
                        </ItemTemplate>
                    </asp:Repeater> 

                    <asp:Literal runat="server" ID="_litChoreMorning" Visible="false"></asp:Literal>
                </ul>
            </div>

            <div class="tile-container-cell">
                <ul>
                    <li>
                        <h3>Middag</h3>
                    </li>
                    
                     <asp:Repeater runat="server" ID="_repChoreAfternoon" OnDataBinding="_repChoreAfternoon_DataBinding">
                        <ItemTemplate>
                            <li>
                                <div id='<%# Eval("Patient.Id") %>' class="image image-chores" style='background-image: url(<%# Eval("Patient.ImagePath").ToString().Replace('\\', '/')%>);' data-remodal-target="chores-remodal" onclick='HiddenFieldPatient(<%# Eval("Patient.Id") %>, 1)'></div>
                            </li>
                        </ItemTemplate>
                    </asp:Repeater>

                     <asp:Literal runat="server" ID="_litChoreAfternoon" Visible="false"></asp:Literal>
                </ul>
            </div>

              <div class="tile-container-cell">
                <ul>
                    <li>
                        <h3>Avond</h3>
                    </li>
                    
                     <asp:Repeater runat="server" ID="_repChoreEvening" OnDataBinding="_repChoreEvening_DataBinding">
                        <ItemTemplate>
                            <li>
                                <div id='<%# Eval("Patient.Id") %>' class="image image-chores" style='background-image: url(<%# Eval("Patient.ImagePath").ToString().Replace('\\', '/')%>);' data-remodal-target="chores-remodal" onclick='HiddenFieldPatient(<%# Eval("Patient.Id") %>, 2)'></div>
                            </li>
                        </ItemTemplate>
                    </asp:Repeater>

                     <asp:Literal runat="server" ID="_litChoreEvening" Visible="false"></asp:Literal>
                </ul>
            </div>
        </div>
    </div>

    <!-- Select Employee -->
    <div class="remodal purple-bg no-select select-staff" data-remodal-id="employee-remodal" data-remodal-options="hashTracking: false">
        <table>
            <thead>
                <tr>
                    <td>
                         <h2>Selecteer personeelslid</h2>
                    </td>
                </tr>
            </thead>

            <tbody>
                <tr>
                    <td>
                        <!-- Employee -->
                        <div class="patient-overview">
                            <asp:Repeater runat="server" ID="_repEmployees">
                                <ItemTemplate>
                                    <!-- Row -->
                                    <%# (Container.ItemIndex + 5) % 5 == 0 ? "<div style=\"display: table-row\">" : string.Empty %>

                                    <!-- Cell -->
                                    <div class="tile-container-cell">
                                        <asp:Image runat="server" CssClass="image-select-staff" data-remodal-action="confirm" ImageUrl="~/Includes/Css/Images/avatar.jpg" />
                                    </div>

                                    <%# (Container.ItemIndex + 5) % 5 == 4 ? "</div>" : string.Empty %>
                                </ItemTemplate>
                            </asp:Repeater>
                        </div>
                    </td>
                </tr>
            </tbody>

            <tfoot>
                <tr>
                    <td>
                        <button data-remodal-action="cancel" class="remodal-cancel">Annuleren</button>
                    </td>
                </tr>
            </tfoot>
        </table>
    </div>

    <!-- Select Patient -->
    <div class="remodal blue-bg no-select" data-remodal-id="chores-remodal" data-remodal-options="hashTracking: false">
        <table>
            <thead>
                <tr>
                    <td>
                         <h2>Selecteer bewoner</h2>
                    </td>
                </tr>
            </thead>

            <tbody>
                <tr>
                    <td>
                        <!-- Patients -->
                        <div class="patient-overview">
                            <asp:Repeater runat="server" ID="_repPatients">
                                <ItemTemplate>
                                    <!-- Row -->
                                    <%# (Container.ItemIndex + 5) % 5 == 0 ? "<div style=\"display: table-row\">" : string.Empty %>

                                    <!-- Cell -->
                                    <div class="tile-container-cell">
                                        <asp:LinkButton CssClass="patient-select" runat="server" ID="_lbPatient" OnClick="_lbPatient_Click" CommandArgument='<%# Eval("Id") %>'>
                                            <div class="image image-chores" style='pointer-events: none; background-image: url(<%# Eval("ImagePath").ToString().Replace('\\', '/')%>);'data-remodal-action="confirm"></div>
                                        </asp:LinkButton>
                                    </div>

                                    <%# (Container.ItemIndex + 5) % 5 == 4 ? "</div>" : string.Empty %>
                                </ItemTemplate>
                            </asp:Repeater>
                        </div>
                    </td>
                </tr>
            </tbody>

            <tfoot>
                <tr>
                    <td>
                        <button data-remodal-action="cancel" class="remodal-cancel">Annuleren</button>
                    </td>
                </tr>
            </tfoot>
        </table>
    </div>
</asp:Content>