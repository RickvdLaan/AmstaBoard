﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Main.Master" AutoEventWireup="true" CodeBehind="Error500.aspx.cs" Inherits="AmstaJanBonga.Web.Content.Unsecure.Error.Error500" %>
<asp:Content ID="Content1" ContentPlaceHolderID="_cphHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="_cphContent" runat="server">
    <h1 class="h1-error">
        <i class="fa fa-exclamation-circle" aria-hidden="true"></i>

        Error 500 - Onverwachte Fout
    </h1>

    <div class="error-div">
        <p>
            Oops, er is iets fout gegaan, onze excuses hiervoor! We hebben een rapport opgebouwd 
            van deze fout en deze doorgestuurd naar de applicatiebeheerder.
        </p>

        <h2>Wat nu?</h2>

        <p>
            1. Druk <asp:HyperLink runat="server" NavigateUrl="~/LivingRoom">hier</asp:HyperLink>
            of op het <i class="fa fa-th-large" aria-hidden="true"></i> icoontje linksboven om terug te gaan naar het hoofdscherm.
        </p>
        <p>
            2. Reageert het touchscreen scherm niet of blijft de error staan? Restart de computer door op de power knop te drukken van de 
            computer, wacht tot deze is afgesloten en zet de computer weer opnieuw aan.
        </p>
        <p>
            3. Blijft deze error tevoorschijn komen na het proberen van de bovengenoemde oplossingen? Neem dan contact op met de applicatiebeheerder.
        </p>
    </div>  
</asp:Content>
