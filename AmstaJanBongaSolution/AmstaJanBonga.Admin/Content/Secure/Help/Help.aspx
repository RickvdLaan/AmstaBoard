<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Main.Master" AutoEventWireup="true" CodeBehind="Help.aspx.cs" Inherits="AmstaJanBonga.Admin.Content.Secure.Help.Help" %>

<%@ Register Src="~/Content/Controls/LegendaWidget/LegendaWidget.ascx" TagPrefix="uc1" TagName="LegendaWidget" %>
<%@ Register Src="~/Content/Controls/GeneralWidget/GeneralWidget.ascx" TagPrefix="uc1" TagName="GeneralWidget" %>


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
        <a href="https://adminjanbonga.jouwsoftware.nl/_uploads/downloads/AmstaBord-CMS-Handleiding-v1.pdf" download="amstabord-cms-handleiding.pdf" target="_blank">
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

        <uc1:GeneralWidget runat="server" id="GeneralWidget" />
    </div>
    <div class="manual">
        <div class="box">
            <!-- Dashboard -->
            <div>
                <h2 id="toc_dashboard">
                    1. Dashboard
                </h2>

                <p>
                    Het dashboard biedt een simpel overzicht van het beheersysteem, er zijn verschillende snelkoppelingen, er is een legenda (zoals hierboven weergegeven) voor alle icoontjes binnen het beheersysteem en er is een overzicht te zien van alle woonkamers (zie figuur 1. Woonkamer overzicht) om snel te kunnen zien welke gegevens wel, of niet zijn ingevoerd. 
                </p>    
                
                <figure>
                    <img src="https://adminjanbonga.jouwsoftware.nl/_uploads/Images/JanBongaManual/living_room_overview.PNG" />
                    <figcaption>Figuur 1. Woonkamer overzicht</figcaption>
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
                    Voor het toevoegen van gebruikers kunt u drukken op "<i class="fa fa-plus-circle" aria-hidden="true"></i> Gebruiker Toevoegen" op het gebruikersoverzicht. Hier voert u een unieke gebruikersnaam in en vervolgens het wachtwoord. Tot slot geeft u aan welke functie of rol deze gebruiker heeft binnen Amsta en slaat vervolgens de gebruiker op.
                </p>

                <p>
                    Om de gebruiker te wijzigen kunt u vanaf het gebruikersoverzicht op het potloodje <i class="fa fa-pencil" aria-hidden="true"></i> drukken. Het wijzigen van de gebruikersnaam is niet mogelijk, maar de functie (rol) binnen het beheersysteem kan wel worden aangepast, om zo meer of minder rechten toe te kennen. 
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
                    De medewerkers zijn iedereen die op de woonkamers werken. Medewerkers worden gekoppeld aan één van de woonkamers en kunnen vervolgens worden geselecteerd voor de diensten op de woonkamer. Door te drukken op "<i class="fa fa-user-md" aria-hidden="true"></i> Medewerkers" in het menu (zie figuur 2. Menu) komt u op het medewerkersoverzicht.
                </p>

                <h3 id="toc_employees_add_edit">
                    3.1. Medewerkers toevoegen of wijzigen
                </h3>

                <p>
                    Voor het toevoegen van medewerkers kunt u drukken op "<i class="fa fa-plus-circle" aria-hidden="true"></i> Medewerker Toevoegen" op het medewerkersoverzicht. Hier voert u de voornaam in van de medewerker (let op, als u hier ook de achternaam invoert, komt dit ook op het scherm te staan). Vervolgens kunt u een foto toevoegen (optioneel), zo kunnen uw collega's en bewoners u eenvoudig herkennen op het scherm. Verder is er de mogelijkheid om de medewerker aan een gebruiker te koppelen zodat hij of zij ook kan inloggen op de woonkamer waaraan deze gekoppeld wordt, maar dit kan ook op een later moment gebeuren. Tot slot selecteert u op welke woonkamer deze medewerker werkt en drukt u op opslaan.
                </p>

                <p>
                    Om de medewerker te wijzigen kunt u vanaf het medewerkersoverzicht op het potloodje <i class="fa fa-pencil" aria-hidden="true"></i> drukken. Hier kunt u de naam wijzigen, een andere foto selecteren of de bestaande foto verwijderen. Een gebruiker koppelen aan de medewerker of een andere woonkamer selecteren.
                </p>
            </div>
            <!-- Living rooms -->
            <div>
                <h2 id="toc_living_rooms">
                    4. Woonkamers
                </h2>

                <p>
                    Vanuit het overzicht van alle woonkamers ziet u welke woonkamers zijn toegevoegd aan het beheersysteem. Door te drukken op "<i class="fa fa-home" aria-hidden="true"></i> Woonkamers" in het menu (zie figuur 2. Menu) komt u op het overzicht van de woonkamers.
                </p>

                <p>
                    Verder kunt u vanuit het overzicht drukken op diensten <i class="fa fa-clock-o" aria-hidden="true"></i> om de diensten van die woonkamer in te kunnen zien, algemene informatie <i class="fa fa-coffee" aria-hidden="true"></i> voor het informatieoverzicht of corvee <i class="el el-broom" aria-hidden="true"></i> om de corveediensten te zien voor de geselecteerde woonkamer.
                </p>

                <h3 id="toc_living_room_add_edit">
                    4.1. Woonkamers toevoegen of wijzigen
                </h3>

                <p>
                    Om een woonkamer toe te voegen aan het systeem kunt u drukken op "<i class="fa fa-plus-circle" aria-hidden="true"></i> Woonkamer Toevoegen" op het overzicht van de woonkamers. Hier voert u de naam van de woonkamer in en kunt u een kleur toewijzen aan de woonkamer, druk vervolgens op opslaan om de woonkamer toe te voegen aan het systeem.
                </p>

                <p>
                    Om een woonkamer te wijzigen kunt u vanaf het overzicht van de woonkamers op het potloodje <i class="fa fa-pencil" aria-hidden="true"></i> drukken. Hier kunt u de naam en kleur wijzigen van de woonkamer.
                </p>

                <p>
                    Voor het verwijderen van een woonkamer dient een verzoek ingediend te worden bij de applicatiebeheerder.
                </p>

                <h3 id="toc_living_room_shifts">
                    4.2. Diensten
                </h3>

                <p>
                    Het dienstenoverzicht weergeeft alle diensten van het personeel voor de geselecteerde woonkamer. Door te drukken op het icoontje van de diensten <i class="fa fa-clock-o" aria-hidden="true"></i> vanuit het overzicht van de woonkamers komt u op het dienstenoverzicht.
                </p>

                <h4 id="toc_living_room_shifts_add_edit">
                    4.2.1. Diensten toevoegen of wijzigen
                </h4>

                <p>
                    Om een dienst toe te voegen drukt u op "<i class="fa fa-plus-circle" aria-hidden="true"></i> Dienst Toevoegen" op het dienstenoverzicht. Vervolgens selecteert u een datum, wie er dag- en avonddienst hebben en drukt u op opslaan.
                </p>

                <p>
                    Om een dienst te wijzigen kunt u vanaf het dienstenoverzicht op het potloodje <i class="fa fa-pencil" aria-hidden="true"></i> drukken. Vanuit hier kunt u vervolgens andere medewerkers selecteren voor de dienst.
                </p>

                <h3 id="toc_living_room_general">
                    4.3. Algemene informatie
                </h3>

                <p>
                    Het overzicht van de algemene informatie weergeeft voor welke dagen een bericht is geplaatst op het AmstaBord. Dit kunnen maaltijden zijn, verjaardagen of andere bijzonderheden. Door te drukken op het icoontje van de algemene informatie <i class="fa fa-coffee" aria-hidden="true"></i> vanuit het overzicht van de woonkamers komt u op het overzicht van de algemene informatie.
                </p>

                <h4 id="toc_living_room_general_single">
                    4.3.1. Algemeen bericht
                </h4>

                <p>
                    Het algemene bericht dat geplaatst kan worden op het AmstaBord kan alles zijn, een voorbeeld is om hier de maaltijden neer te zetten of eventuele bijzonderheden. Om een algemeen bericht toe te voegen drukt u op "<i class="fa fa-plus-circle" aria-hidden="true"></i> Bericht Toevoegen", hier kunt u een datum selecteren en vervolgens het bericht invoeren, druk vervolgens op opslaan en het bericht is opgeslagen.
                </p>

                <h4 id="toc_living_room_general_repeat">
                    4.3.2. Herhalend bericht
                </h4>

                <p>
                    Het herhalende bericht is een bericht dat iedere dag weergegeven zal worden op het AmstaBord. Hier kan bijvoorbeeld neergezet worden wanneer de koffietijden zijn. Om een herhalend bericht toe te voegen of te bewerken drukt u op "<i class="fa fa-pencil" aria-hidden="true"></i> Herhalend Bericht Bewerken". Als u geen herhalend bericht wilt op het AmstaBord, kunt u het veld leeg laten en vervolgens op opslaan drukken.
                </p>

                <h3 id="toc_living_room_chores">
                    4.4. Corvee
                </h3>

                <p>
                    Het overzicht van de corveediensten weergeeft voor welke dagen corveediensten zijn ingevuld. Door te drukken op het icoontje van de corveedienst <i class="el el-broom" aria-hidden="true"></i> vanuit het overzicht van de woonkamers komt u op het overzicht van de corveediensten.
                </p>

                <h4 id="toc_living_room_chores_add_edit">
                    4.4.1. Corvee toevoegen of wijzigen
                </h4>

                <p>
                    Om een corveedienst toe te voegen drukt u op "<i class="fa fa-plus-circle" aria-hidden="true"></i> Corvee Toevoegen" vanuit het overzicht van de corveediensten. Vervolgens selecteert u een datum en welke bewoners er 's ochtends, 's middags of 's avonds corvee hebben.
                </p>

                <p>
                    Om een corveedienst te wijzigen kunt u vanuit het overzicht op het potloodje <i class="fa fa-pencil" aria-hidden="true"></i> drukken. Vanuit hier kunt u vervolgens andere bewoners selecteren voor de corveedienst.
                </p>
            </div>
            <!-- Patients -->
            <div>
                <h2 id="toc_patients">
                    5. Bewoners
                </h2>

                <p>
                    De bewoners kunnen worden toegevoegd aan het systeem als zij, of hun begeleider(s) toestemming geven tot het opslaan van zijn of haar persoonlijke gegevens, zoals dit beschreven staat in de wet bescherming persoonsgegevens (WBP).
                </p>

                <p>
                    Door te drukken op "<i class="fa fa-users" aria-hidden="true"></i> Bewoners" in het menu (zie figuur 2. Menu) komt u terecht op het overzicht van alle bewoners die zijn toegevoegd aan het systeem. 
                </p>

                <h3 id="toc_patients_add_edit">
                    5.1. Bewoners toevoegen of wijzigen
                </h3>

                <p>
                    Voor het toevoegen van bewoners kunt u drukken op "<i class="fa fa-plus-circle" aria-hidden="true"></i> Bewoner Toevoegen" op het overzicht van alle bewoners. Hier voert u de voornaam in van de bewoner (let op, als u hier ook de achternaam invoert, komt dit ook op het scherm te staan). Vervolgens selecteert u een foto van de bewoner, op welke woonkamer deze bewoner is geplaatst en drukt u op opslaan.
                </p>

                <p>
                    Om een bewoner te wijzigen, kunt u vanaf het overzicht van de bewoners op het potloodje <i class="fa fa-pencil" aria-hidden="true"></i> drukken. Hier kunt u de naam wijzigen, een andere foto selecteren of de bewoner aan een andere woonkamer koppelen.
                </p>

                <h3 id="toc_patients_agenda">
                    5.2. Agenda
                </h3>

                <p>
                    De agenda van de bewoners geeft de bewoners de mogelijkheid om hun persoonlijke agenda in te zien op het AmstaBord. De agenda kan worden benaderd door op het icoontje van de agenda <i class="fa fa-calendar" aria-hidden="true"></i> te drukken vanuit het overzicht van de bewoners.
                </p>

                <h4 id="toc_patients_appointment_repeat">
                    5.2.1. Eenmalige afspraken
                </h4>

                <p>
                    Om een eenmalige afspraak in de agenda te zetten drukt u op "<i class="fa fa-plus-circle" aria-hidden="true"></i> Afspraak Toevoegen" op het overzicht van de agenda. Vanuit hier kunt u een titel, datum en starttijd, eindtijd, locatie en omschrijving toevoegen. Tot slot kunt u selecteren om de afspraak eenmalig te herhalen. 
                </p>

                <h4 id="toc_patients_appointment_single">
                    5.2.2. Herhalende afspraken
                </h4>

                <p>
                    Om een herhalende afspraak in de agenda te zetten drukt u op "<i class="fa fa-plus-circle" aria-hidden="true"></i> Afspraak Toevoegen" op het overzicht van de agenda. Vanuit hier kunt u een titel, datum en starttijd, eindtijd, locatie en omschrijving toevoegen. Tot slot kunt u selecteren of u de afspraak wilt herhalen om de week, twee, drie of vier weken.
                </p>
            </div>
            <!-- Deletion -->
            <div>
                <h2 id="toc_deletion">
                    6. Verwijderen gegevens
                </h2>

                <p>
                    Op het overzicht van de pagina's staat onder opties een rood prullenbak <i class="fa fa-trash" aria-hidden="true"></i> icoontje. Wanneer u hierop drukt, krijgt u een bevestigingsbericht of u het geselecteerde item wilt verwijderen. Indien u op "Ja" drukt, wordt het verwijderd. Maar let op, niet alle gegevens worden permanent verwijderd. Het is dan ook mogelijk om in sommige gevallen gegevens te herstellen als het verkeerde is verwijderd, indien dit het geval is, dient u contact op te nemen met de applicatiebeheerder.
                </p>

                <p>
                    Komt een bewoner te overlijden? Dan kunt u een verzoek indienen bij de applicatiebeheerder om de gegevens van de bewoner permanent te verwijderen uit het systeem.
                </p>
            </div>
            <!-- Settings -->
            <div>
                <h2 id="toc_settings">
                    7. Instellingen
                </h2>

                <p>
                    In het systeem zijn verschillende rechten per functie, zo kan een stagiair alleen gegevens toevoegen aan een woonkamer en de agenda van de bewoners en deze aanpassen, maar kan verder geen mensen toevoegen een het systeem of verwijderen. Terwijl een medewerker dit wel kan, indien er een wens is, dat een bepaalde functie binnen het systeem iets juist wel, of niet moet kunnen uitvoeren kan hiertoe een verzoek ingediend worden bij de applicatiebeheerder.
                </p>

                <p>
                    Wanneer u inlogt op het systeem, wordt u om veiligheidsredenen automatisch weer uitgelogd als u langer dan tien minuten niets uitvoert op het systeem. Dit kan op basis van een verzoek bij de applicatiebeheerder worden aangepast, met een minimum van vijf en een maximum van dertig minuten.
                </p>
            </div>
        </div>
    </div>
</asp:Content>