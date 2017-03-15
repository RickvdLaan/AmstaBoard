<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Main.Master" AutoEventWireup="true" CodeBehind="PatientAgenda.aspx.cs" Inherits="AmstaJanBonga.Web.Content.PatientAgenda.PatientAgenda" %>
<asp:Content ID="Content1" ContentPlaceHolderID="_cphHead" runat="server">

 <!-- Gets all appointments and checks if any are overlapping. -->
    <script>
        $(function () {
            UpdateAllAppointments();
        });

        // Checks whether two BoundingClientRects are overlapping.
        function IsOverlapping(div1, div2) {
            var x1 = div1.left;
            var y1 = div1.top;
            var h1 = div1.height;
            var w1 = div1.width;
            var b1 = y1 + h1;
            var r1 = x1 + w1;
            var x2 = div2.left;
            var y2 = div2.top;
            var h2 = div2.height;
            var w2 = div2.width;
            var b2 = y2 + h2;
            var r2 = x2 + w2;

            if (b1 < y2 || y1 > b2 || r1 < x2 || x1 > r2)
                return false;

            return true;
        }

        // Updates all the appointmentsif they are overlapping with another appointment.
        function UpdateAllAppointments() {
            var appointments = $(".appointment");

            for (var i = 0; i < appointments.length; i++) {
                for (var j = i + 1; j < appointments.length; j++) {
                    if (IsOverlapping(appointments[i].getBoundingClientRect(), appointments[j].getBoundingClientRect())) {
                        appointments[i].classList.add("appointment-50-l");
                        appointments[j].classList.add("appointment-50-r");
                    }
                }
            }
        }
    </script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="_cphContent" runat="server">
    <!-- The photo of the patient. -->
    <asp:Image runat="server" CssClass="agenda-image" ImageUrl="~/Includes/Css/Images/avatar.jpg" />

    <!-- The day agenda. -->
    <asp:Panel runat="server" ID="_pnlAgendaDay" Visible="true">
        <table class="agenda-day">
            <thead>
                <tr>
                    <td>
                        <!-- Purposely left blank without a colspan for design purposes. -->
                    </td>

                    <td class="blue-bg" style="font-size: 50px;">
                        Vandaag
                    </td>
                </tr>
            </thead>
        
            <tbody>
                <!-- Repeating through the appointments. -->
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
    </asp:Panel>

    <!-- The week agenda. -->
    <asp:Panel runat="server" ID="_pnlAgendaWeek" Visible="false">

    </asp:Panel>
</asp:Content>
