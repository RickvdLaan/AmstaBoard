<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Main.Master" AutoEventWireup="true" CodeBehind="Livingroom.aspx.cs" Inherits="AmstaJanBonga.Web.Content.Home" %>

<%@ Import namespace="Rlaan.Toolkit.Extensions" %>
<%@ Import namespace="AmstaJanBonga.Business.Enums" %>

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

        function HiddenFieldEmployee(employeeId, shiftType) {
            var hiddenFieldEmployee = document.getElementById('<%= _hfEmployee.ClientID %>');

            if (hiddenFieldEmployee) {
                hiddenFieldEmployee.value = employeeId + "_" + shiftType;
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
    <div class="tile staff">
        <h2>
            Dag en avonddienst
            <i class="fa fa-clock-o" aria-hidden="true"></i>
        </h2>

        <asp:HiddenField runat="server" ID="_hfEmployee" />

        <div class="tile-wrapper">
            <asp:Repeater runat="server" ID="_repEmployeeShiftsDay" OnDataBinding="_repEmployeeShiftsDay_DataBinding">
                <ItemTemplate>
                    <div class="tile-container-cell">
                        <h4>
                            <%# ((ShiftTypeEnum)Enum.Parse(typeof(ShiftTypeEnum), Eval("ShiftTypeEnum").ToString())).Description() %>
                        </h4>
                        <div class="image image-staff image-empty" style='background-image: url(<%# Eval("Employee.ImagePath").ToString().Replace('\\', '/')%>);' data-remodal-target="shift-remodal" onclick='HiddenFieldEmployee(<%# Eval("Employee.Id") %>, <%# Eval("ShiftTypeEnum") %>)'></div>
                        <h3>
                             <%# Eval("Employee.FirstName") %>
                        </h3>
                    </div>
                </ItemTemplate>
            </asp:Repeater>

            <asp:Literal runat="server" ID="_litShift" Visible="false"></asp:Literal>
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
                                <div class="image image-chores" style='background-image: url(<%# Eval("Patient.ImagePath").ToString().Replace('\\', '/')%>);' data-remodal-target="chores-remodal" onclick='HiddenFieldPatient(<%# Eval("Patient.Id") %>, 0)'></div>
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
                                <div class="image image-chores" style='background-image: url(<%# Eval("Patient.ImagePath").ToString().Replace('\\', '/')%>);' data-remodal-target="chores-remodal" onclick='HiddenFieldPatient(<%# Eval("Patient.Id") %>, 1)'></div>
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
                                <div class="image image-chores" style='background-image: url(<%# Eval("Patient.ImagePath").ToString().Replace('\\', '/')%>);' data-remodal-target="chores-remodal" onclick='HiddenFieldPatient(<%# Eval("Patient.Id") %>, 2)'></div>
                            </li>
                        </ItemTemplate>
                    </asp:Repeater>

                     <asp:Literal runat="server" ID="_litChoreEvening" Visible="false"></asp:Literal>
                </ul>
            </div>
        </div>
    </div>

    <!-- Select Employee -->
    <div class="remodal purple-bg no-select" data-remodal-id="shift-remodal" data-remodal-options="hashTracking: false">
        <table>
            <thead>
                <tr>
                    <td>
                         <h2>Selecteer werknemer</h2>
                    </td>
                </tr>
            </thead>

            <tbody>
                <tr>
                    <td>
                        <!-- Employees -->
                        <div class="employee-overview">
                            <asp:Repeater runat="server" ID="_repEmployees">
                                <ItemTemplate>
                                    <!-- Row -->
                                    <%# (Container.ItemIndex + 5) % 5 == 0 ? "<div style=\"display: table-row\">" : string.Empty %>

                                    <!-- Cell -->
                                    <div class="tile-container-cell">
                                        <asp:LinkButton CssClass="employee-select" runat="server" ID="_lbEmployee" OnClick="_lbEmployee_Click" CommandArgument='<%# Eval("Id") %>'>
                                            <div class="image image-shifts" style='pointer-events: none; background-image: url(<%# Eval("ImagePath").ToString().Replace('\\', '/')%>);'data-remodal-action="confirm"></div>
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