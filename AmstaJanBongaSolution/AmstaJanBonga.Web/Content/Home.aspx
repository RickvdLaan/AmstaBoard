﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Main.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="AmstaJanBonga.Web.Content.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="_cphHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="_cphContent" runat="server">
    <div class="tile agenda">
        <h2>Agenda bewoners</h2>

         <div class="tile-wrapper">
            <div class="tile-container">
                <a href="#">Druk hier om uw agenda te bekijken</a>
            </div>
        </div>
    </div>

    <div class="tile staff">
        <h2>Dag en avonddienst</h2>

        <div class="tile-wrapper">
            <div class="tile-container-cell">
                <img class="image image-staff" src="http://betterpropertiesauburn.com/wp-content/uploads/2015/11/ad516503a11cd5ca435acc9bb6523536-1.png" />
       
                <img class="image image-staff" src="http://betterpropertiesauburn.com/wp-content/uploads/2015/11/ad516503a11cd5ca435acc9bb6523536-1.png" />

                <img class="image image-staff" src="http://betterpropertiesauburn.com/wp-content/uploads/2015/11/ad516503a11cd5ca435acc9bb6523536-1.png" />
            </div>
        </div>
    </div>

    <div class="tile general">
        <h2>Algemeen</h2>
    </div>

    <div class="tile chores">
        <h2>Corvee</h2>

         <div class="tile-wrapper">
            <div class="tile-container-row">
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
            </div>
        </div>
    </div>
</asp:Content>
