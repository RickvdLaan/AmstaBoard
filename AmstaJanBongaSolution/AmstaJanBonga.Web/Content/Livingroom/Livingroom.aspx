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
                $('.staff').find('img').addClass('image-staff-3')
            }
            else if (images == 2) {
                $('.staff').find('img').addClass('image-staff-2')
            }
            else {
                alert("There are less than two images or more than three, this shouldn't be possible.");
            }
        }
        </script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="_cphContent" runat="server">
    <!-- Agenda -->
    <div class="tile agenda">
        <h2>
            Agenda bewoners
            <i class="fa fa-calendar" aria-hidden="true"></i>
        </h2>

         <div class="tile-wrapper">
             <asp:HyperLink runat="server" CssClass="tile-container-cell button-press" NavigateUrl="~/Content/PatientAgendaOverview/PatientAgendaOverview.aspx">Druk hier om uw agenda te bekijken</asp:HyperLink>
        </div>
    </div>

    <!-- Staff -->
    <div class="tile staff">
        <h2>
            Dag en avonddienst
            <i class="fa fa-clock-o" aria-hidden="true"></i>
        </h2>

        <div class="tile-wrapper">
            <div class="tile-container-cell">
                <h4>Dag</h4>
                <asp:Image runat="server" CssClass="image image-staff" ImageUrl="~/Includes/Css/Images/avatar.jpg" />
                <h3>Voornaam</h3>
            </div>

            <div class="tile-container-cell">
                <h4>Dag</h4>
                <asp:Image runat="server" CssClass="image image-staff" ImageUrl="~/Includes/Css/Images/avatar.jpg" />
                <h3>Voornaam</h3>
            </div>

            <div class="tile-container-cell">
                <h4>Avond</h4>
                <asp:Image runat="server" CssClass="image image-staff" ImageUrl="~/Includes/Css/Images/avatar.jpg" />
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
                <h3>Ochtend</h3>

                <asp:Image runat="server" CssClass="image image-chores" ImageUrl="~/Includes/Css/Images/avatar.jpg" />
                <asp:Image runat="server" CssClass="image image-chores" ImageUrl="~/Includes/Css/Images/avatar.jpg" />
            </div>

            <div class="tile-container-cell">
                <h3>Middag</h3>

                <asp:Image runat="server" CssClass="image image-chores" ImageUrl="~/Includes/Css/Images/avatar.jpg" />
                <asp:Image runat="server" CssClass="image image-chores" ImageUrl="~/Includes/Css/Images/avatar.jpg" />
            </div>

              <div class="tile-container-cell">
                <h3> Avond</h3>

                <asp:Image runat="server" CssClass="image image-chores" ImageUrl="~/Includes/Css/Images/avatar.jpg" />
                <asp:Image runat="server" CssClass="image image-chores" ImageUrl="~/Includes/Css/Images/avatar.jpg" />
            </div>
        </div>
    </div>
</asp:Content>

 <%--<div class="tile-container-row">
                <h4>
                    Dag
                </h4>

                <h4>
                    Dag
                </h4>

                <h4>
                    Avond
                </h4>
            </div>

            <div class="tile-container-cell">
                <img class="image image-staff" src="http://betterpropertiesauburn.com/wp-content/uploads/2015/11/ad516503a11cd5ca435acc9bb6523536-1.png" />
       
                <img class="image image-staff" src="http://betterpropertiesauburn.com/wp-content/uploads/2015/11/ad516503a11cd5ca435acc9bb6523536-1.png" />

                <img class="image image-staff" src="http://betterpropertiesauburn.com/wp-content/uploads/2015/11/ad516503a11cd5ca435acc9bb6523536-1.png" />
            </div>

            <div class="tile-container-row">
                <h3>
                    Voornaam
                </h3>

                <h3>
                    Voornaam
                </h3>

                <h3>
                    Voornaam
                </h3>
            </div>--%>

 <%--<div class="tile-container-row">
                <h3>
                    Ochtend
                </h3>

                <h3>
                    Middag
                </h3>

                <h3>
                    Avond
                </h3>
            </div>

            <div class="tile-container-row">
                <img class="image image-chores" src="http://betterpropertiesauburn.com/wp-content/uploads/2015/11/ad516503a11cd5ca435acc9bb6523536-1.png" />
       
                <img class="image image-chores" src="http://betterpropertiesauburn.com/wp-content/uploads/2015/11/ad516503a11cd5ca435acc9bb6523536-1.png" />

                <img class="image image-chores" src="http://betterpropertiesauburn.com/wp-content/uploads/2015/11/ad516503a11cd5ca435acc9bb6523536-1.png" />
            </div>
              <div class="tile-container-row">
                <img class="image image-chores" src="http://betterpropertiesauburn.com/wp-content/uploads/2015/11/ad516503a11cd5ca435acc9bb6523536-1.png" />
       
                <img class="image image-chores" src="http://betterpropertiesauburn.com/wp-content/uploads/2015/11/ad516503a11cd5ca435acc9bb6523536-1.png" />

                <img class="image image-chores" src="http://betterpropertiesauburn.com/wp-content/uploads/2015/11/ad516503a11cd5ca435acc9bb6523536-1.png" />
            </div>--%>