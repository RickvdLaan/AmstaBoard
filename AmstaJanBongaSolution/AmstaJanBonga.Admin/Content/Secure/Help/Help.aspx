<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Main.Master" AutoEventWireup="true" CodeBehind="Help.aspx.cs" Inherits="AmstaJanBonga.Admin.Content.Secure.Help.Help" %>

<%@ Register Src="~/Content/Controls/LegendaWidget/LegendaWidget.ascx" TagPrefix="uc1" TagName="LegendaWidget" %>

<asp:Content ID="Content1" ContentPlaceHolderID="_cphHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="_cphMainTitle" runat="server">
    Handleiding
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="_cphSubTitle" runat="server">
    Digitaal
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="_cphExplanation" runat="server">
    De digitale handleiding van de applicatie.
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="_cphContent" runat="server">
    
    <div class="shortcut">
        <a href="#" target="_blank">
            <small>Download handleiding als <i class="fa fa-file-pdf-o" aria-hidden="true" title="pdf"></i>.</small>
        </a>
    </div>

    <div class="widget-container">
        <div class="table-of-contents widget">
            <h2>Inhoudsopgave</h2>
            <ul>
                <li>1. <a href="#toc_dashboard">Dashboard</a></li>
                <li>
                    2. <a href="#toc_users">Gebruikers</a>

                    <ul>
                        <li>2.1. <a href="#toc_users_add_edit">Toevoegen en wijzigen</a></li>
                    </ul>
                </li>
                <li>
                    3. <a href="#toc_employees">Medewerkers</a>

                    <ul>
                        <li>3.1. <a href="#toc_employees_add_edit">Toevoegen en wijzigen</a></li>
                    </ul>
                </li>
                <li>
                    4. <a href="#toc_living_rooms">Woonkamers</a>

                    <ul>
                        <li>4.1. <a href="#toc_living_room_add_edit">Toevoegen en wijzigen</a></li>
                        <li>
                            4.2. <a href="#toc_living_room_shifts">Diensten</a>

                            <ul>
                                <li>4.2.1. <a href="#toc_living_room_shifts_add_edit">Toevoegen en wijzigen</a></li>
                            </ul>
                        </li>
                        <li>
                            4.3. <a href="#toc_living_room_general">Algemene informatie</a>

                            <ul>
                                <li>4.3.1. <a href="#toc_living_room_general_single">Algemeen bericht</a></li>
                                <li>4.3.2. <a href="#toc_living_room_general_repeat">Herhalend bericht</a></li>
                            </ul>
                        </li>
                        <li>
                            4.4. <a href="#toc_living_room_chores">Corvee</a>

                            <ul>
                                <li>4.4.1. <a href="#toc_living_room_chores_add_edit">Toevoegen en wijzigen</a></li>
                            </ul>
                        </li>
                    </ul>
                </li>
                <li>
                    5. <a href="#toc_patients">Bewoners</a>

                    <ul>
                        <li>5.1. <a href="#toc_patients_add_edit">Toevoegen en wijzigen</a></li>
                        <li>
                            5.2. <a href="#toc_patients_agenda">Agenda</a>

                            <ul>
                                <li>5.2.1 <a href="#toc_patients_appointment_repeat">Herhalende afspraken</a></li>
                                <li>5.2.2 <a href="#toc_patients_appointment_single">Eenmalige afspraken</a></li>
                            </ul>
                        </li>
                    </ul>
                </li>
                <li>6. <a href="#toc_deletion">Verwijderen gegevens</a></li>
                <li>7. <a href="#toc_settings">Instellingen</a></li>
            </ul>
        </div>

        <uc1:LegendaWidget runat="server" ID="LegendaWidget" />
    </div>
    <div class="manual">
        <div class="box">
            <!-- Dashboard -->
            <div>
                <h2 id="toc_dashboard">
                    1. Dashboard
                </h2>

                <p>

                </p>

                <h3>

                </h3>

                <p>

                </p>
            </div>
            <!-- Users -->
            <div>
                <h2 id="toc_users">
                    2. Gebruikers
                </h2>
        
                <p>

                </p>

                <h3 id="toc_users_add_edit">
                    2.1. Toevoegen en wijzigen
                </h3>

                <p>

                </p>
            </div>
            <!-- Employees -->
            <div>
                <h2 id="toc_employees">
                    3. Medewerkers
                </h2>

                <p>

                </p>

                <h3 id="toc_employees_add_edit">
                    3.1. Toevoegen en wijzigen
                </h3>

                <p>

                </p>
            </div>
            <!-- Living rooms -->
            <div>
                <h2 id="toc_living_rooms">
                    4. Woonkamers
                </h2>

                <p>

                </p>

                <h3 id="toc_living_room_add_edit">
                    4.1. Toevoegen en wijzigen
                </h3>

                <p>

                </p>

                <h3 id="toc_living_room_shifts">
                    4.2. Diensten
                </h3>

                <p>

                </p>

                <h4 id="toc_living_room_shifts_add_edit">
                    4.2.1. Toevoegen en wijzigen
                </h4>

                <p>

                </p>

                <h3 id="toc_living_room_general">
                    4.3. Algemene informatie
                </h3>

                <p>

                </p>

                <h4 id="toc_living_room_general_single">
                    4.3.1. Algemeen bericht
                </h4>

                <p>

                </p>

                <h4 id="toc_living_room_general_repeat">
                    4.3.2. Herhalend bericht
                </h4>

                <p>

                </p>

                <h3 id="toc_living_room_chores">
                    4.4. Corvee
                </h3>

                <p>
               
                </p>

                <h4 id="toc_living_room_chores_add_edit">
                    4.4.1. Toevoegen en wijzigen
                </h4>

                <p>

                </p>
            </div>
            <!-- Patients -->
            <div>
                <h2 id="toc_patients">
                    5. Bewooners
                </h2>

                <p>

                </p>

                <h3 id="toc_patients_add_edit">
                    5.1. Toevoegen en wijzigen
                </h3>

                <p>

                </p>

                <h3 id="toc_patients_agenda">
                    5.2. Agenda
                </h3>

                <p>

                </p>

                <h4 id="toc_patients_appointment_repeat">
                    5.2.1. Herhalende afspraken
                </h4>

                <p>

                </p>

                <h4 id="toc_patients_appointment_single">
                    5.2.2. Eenmalige afspraken
                </h4>

                <p>

                </p>
            </div>
            <!-- Deletion -->
            <div>
                <h2 id="toc_deletion">
                    6. Verwijderen gegevens
                </h2>

                <p>

                </p>
            </div>
            <!-- Settings -->
            <div>
                <h2 id="toc_settings">
                    7. Instellingen
                </h2>

                <p>

                </p>
            </div>
        </div>
    </div>
</asp:Content>
