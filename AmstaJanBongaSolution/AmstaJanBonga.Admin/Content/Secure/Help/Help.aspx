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
    De digitale handleiding van het beheersysteem.
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
                        <li>2.1. <a href="#toc_users_add_edit">Gebruikers toevoegen of wijzigen</a></li>
                    </ul>
                </li>
                <li>
                    3. <a href="#toc_employees">Medewerkers</a>

                    <ul>
                        <li>3.1. <a href="#toc_employees_add_edit">Medewerkers toevoegen of wijzigen</a></li>
                    </ul>
                </li>
                <li>
                    4. <a href="#toc_living_rooms">Woonkamers</a>

                    <ul>
                        <li>4.1. <a href="#toc_living_room_add_edit">Woonkamers toevoegen of wijzigen</a></li>
                        <li>
                            4.2. <a href="#toc_living_room_shifts">Diensten</a>

                            <ul>
                                <li>4.2.1. <a href="#toc_living_room_shifts_add_edit">Diensten toevoegen of wijzigen</a></li>
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
                                <li>4.4.1. <a href="#toc_living_room_chores_add_edit">Corvee toevoegen of wijzigen</a></li>
                            </ul>
                        </li>
                    </ul>
                </li>
                <li>
                    5. <a href="#toc_patients">Bewoners</a>

                    <ul>
                        <li>5.1. <a href="#toc_patients_add_edit">Bewoners toevoegen of wijzigen</a></li>
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

        <div class="widget">
            <h2>Algemene Informatie</h2>
            Het AmstaBord kan worden benaderd met de volgende link:
            <a href="https://www.jouwsoftware.nl/AmstaBord">jouwsoftware.nl/AmstaBord</a>
            <br /><br />
            Het beheersysteem van AmstaBord kan worden benaderd worden met de volgende link:
            <a href="https://www.jouwsoftware.nl/AmstaBordCMS">jouwsoftware.nl/AmstaBordCMS</a>
        </div>
    </div>
    <div class="manual">
        <div class="box">
            <!-- Dashboard -->
            <div>
                <h2 id="toc_dashboard">
                    1. Dashboard
                </h2>

                <p>
                    Het dashboard biedt een simpel overzicht van het beheersysteem, er zijn verschillende snelkoppelingen, er is een legenda (zoals hierboven weergegeven) voor alle icoontjes binnen het beheersysteem en er is een overzicht te zien van alle woonkamers (zie figuur 1. Woonkameroverzicht) om snel te kunnen zien welke gegevens wel, of niet zijn ingevoerd. 
                </p>    
                
                <figure>
                    <img src="https://adminjanbonga.jouwsoftware.nl/_uploads/Images/JanBongaManual/living_room_overview.PNG" />
                    <figcaption>Figuur 1. Woonkameroverzicht</figcaption>
                </figure>

                <p>
                    Als er op een kruisje <i class="fa fa-times" aria-hidden="true"></i> wordt gedrukt, brengt dit kruisje u meteen naar het invoerveld voor de geselecteerde woonkamer. Zo kunnen de gegevens direct worden ingevoerd.

                    Bij het drukken op een vinkje <i class="fa fa-check" aria-hidden="true"></i> komt u op de details pagina van de ingevoerde informatie zodat u een overzicht heeft van wat er is ingevoerd.
                </p>               
            </div>
            <!-- Users -->
            <div>
                <h2 id="toc_users">
                    2. Gebruikers
                </h2>
        
                <p>
                    De gebruikers zijn de beheerders van het beheersysteem. Zij kunnen alle gegevens invoeren, wijzigen en verwijderen, afhankelijk van hun rol binnen Amsta.
                </p>

                <figure>
                    <img src="https://adminjanbonga.jouwsoftware.nl/_uploads/Images/JanBongaManual/menu.PNG" />
                    <figcaption>Figuur 2. Menu</figcaption>
                </figure>

                <p>
                    Door te drukken op "<i class="fa fa-user" aria-hidden="true"></i> Gebruikers" in het menu (zie figuur 2. Menu) komt u op het overzicht van alle gebruikers die zijn toegevoegd aan het systeem.
                </p>

                <h3 id="toc_users_add_edit">
                    2.1. Gebruikers toevoegen of wijzigen
                </h3>

                <p>
                    Voor het toevoegen van gebruikers kunt u drukken op "<i class="fa fa-plus-circle" aria-hidden="true"></i> Gebruiker Toevoegen" op het gebruikersoverzicht. Hier voert u een unieke gebruikersnaam en het wachtwoord in. Tot slot geeft u aan welke functie deze gebruiker heeft binnen Amsta en slaat vervolgens de gebruiker op.
                </p>

                <p>
                    Om de gebruiker te wijzigen kan er op het potloodje <i class="fa fa-pencil" aria-hidden="true"></i> worden gedrukt. Het wijzigen van de gebruikersnaam is niet mogelijk, maar de functie (rol) binnen Amsta of het systeem kan wel worden aangepast. 
                </p>

                <p>
                    Om uw wachtwoord te veranderen kunt u vanaf het gebruikersoverzicht op het slotje <i class="fa fa-lock" aria-hidden="true"></i> drukken, waarna het huidige wachtwoord en het nieuwe wachtwoord kan worden ingevuld.
                </p>

                <p>
                    Bent u uw wachtwoord vergeten? Neem dan contact op met de applicatiebeheerder.
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
                    3.1. Medewerkers toevoegen of wijzigen
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
                    4.1. Woonkamers toevoegen of wijzigen
                </h3>

                <p>

                </p>

                <h3 id="toc_living_room_shifts">
                    4.2. Diensten
                </h3>

                <p>

                </p>

                <h4 id="toc_living_room_shifts_add_edit">
                    4.2.1. Diensten toevoegen of wijzigen
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
                    4.4.1. Corvee toevoegen of wijzigen
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
                    5.1. Bewoners toevoegen of wijzigen
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