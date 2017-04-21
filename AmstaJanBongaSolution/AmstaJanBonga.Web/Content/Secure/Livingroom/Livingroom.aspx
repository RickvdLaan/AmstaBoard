<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Main.Master" AutoEventWireup="true" CodeBehind="Livingroom.aspx.cs" Inherits="AmstaJanBonga.Web.Content.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="_cphHead" runat="server">
    <!-- Sets the width of the staff images based on the amount of staff members -->
    <script>
        $(function () {
            SetStaffImageClasses();
        });

        function SetStaffImageClasses() {
            var images = $(".staff img").length;

            if (images == 3) {
                $('.staff').find('img').addClass('image-staff-3');
            }
            else if (images == 2) {
                $('.staff').find('img').addClass('image-staff-2');
            }
            else {
                alert("There are less than two images or more than three, this shouldn't be possible.");
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
                <asp:Image runat="server" CssClass="image image-staff" ImageUrl="~/Includes/Css/Images/avatar.jpg" /> <%--data-remodal-target="employee-remodal"/>--%> 
                <h3>Voornaam</h3>
            </div>

            <div class="tile-container-cell">
                <h4>Dag</h4>
                <asp:Image runat="server" CssClass="image image-staff" ImageUrl="~/Includes/Css/Images/avatar.jpg" /> <%--data-remodal-target="employee-remodal" />--%>
                <h3>Voornaam</h3>
            </div>

            <div class="tile-container-cell">
                <h4>Avond</h4>
                <asp:Image runat="server" CssClass="image image-staff" ImageUrl="~/Includes/Css/Images/avatar.jpg" /> <%--data-remodal-target="employee-remodal" />--%>
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
                <asp:Literal runat="server">           
                    Koffietijden: 11:00 & 15:00 uur
                    <br />
                    <br />
                     Maaltijden: Lasagne of spaghetti
                </asp:Literal>
            </div>
        </div>
    </div>

    <!-- Chores -->
    <div class="tile chores">
        <h2>
            Corvee
            <i class="fa fa-trash-o" aria-hidden="true"></i>
        </h2>

         <div class="tile-wrapper">
            <div class="tile-container-cell">
                <ul>
                    <li>
                        <h3>Ochtend</h3>
                    </li>
                    
                     <asp:Repeater runat="server" ID="_repChoreMorning">
                        <ItemTemplate>
                            <li>
                                <asp:Image runat="server" CssClass="image image-chores" ImageUrl='<%# Eval("Patient.ImagePath") %>' data-remodal-target="chores-remodal" />
                            </li>
                        </ItemTemplate>
                    </asp:Repeater>
                </ul>
            </div>

            <div class="tile-container-cell">
                <ul>
                    <li>
                        <h3>Middag</h3>
                    </li>
                    
                     <asp:Repeater runat="server" ID="_repChoreAfternoon">
                        <ItemTemplate>
                            <li>
                                <asp:Image runat="server" CssClass="image image-chores" ImageUrl='<%# Eval("Patient.ImagePath") %>' data-remodal-target="chores-remodal" />
                            </li>
                        </ItemTemplate>
                    </asp:Repeater>
                </ul>
            </div>

              <div class="tile-container-cell">
                <ul>
                    <li>
                        <h3>Avond</h3>
                    </li>
                    
                     <asp:Repeater runat="server" ID="_repChoreEvening">
                        <ItemTemplate>
                            <li>
                                <asp:Image runat="server" CssClass="image image-chores" ImageUrl='<%# Eval("Patient.ImagePath") %>' data-remodal-target="chores-remodal" />
                            </li>
                        </ItemTemplate>
                    </asp:Repeater>
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
                        <!-- Patients -->
                        <div class="patient-overview">
                            <asp:Repeater runat="server" ID="_repEmployees">
                                <ItemTemplate>
                                    <!-- Row -->
                                    <%# (Container.ItemIndex + 5) % 5 == 0 ? "<div style=\"display: table-row\">" : string.Empty %>

                                    <!-- Cell -->
                                    <div class="tile-container-cell">                          
                                        <asp:Image runat="server" CssClass="image-select-staff" data-remodal-action="confirm" ImageUrl="~/Includes/Css/Images/avatar.jpg" />
                                        <%--<h3 style="text-align: center;"><%# Eval("Name") %></h3>--%>
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
                                        <asp:Image runat="server" CssClass="image-select-patient" data-remodal-action="confirm" ImageUrl="~/Includes/Css/Images/avatar.jpg" />
                                        <%--<h3 style="text-align: center;"><%# Eval("Name") %></h3>--%>
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