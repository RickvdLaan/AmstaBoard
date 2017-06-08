<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Main.Master" AutoEventWireup="true" CodeBehind="ErrorNetwork.aspx.cs" Inherits="AmstaJanBonga.Web.Content.Unsecure.Error.ErrorNetwork" %>
<asp:Content ID="Content1" ContentPlaceHolderID="_cphHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="_cphContent" runat="server">
     <h1 class="h1-error">
        <i class="fa fa-server" aria-hidden="true"></i>
         Geen verbinding met de server
    </h1>

    <div class="error-div">
        <p>
            Momenteel kan er geen verbinding tot stand worden gebracht met de server, onze excuses hiervoor! 
            Een bericht is doorgestuurd naar de applicatiebeheerder.
        </p>

        <h2>Wat nu?</h2>

        <p>
            Zodra er weer verbinding is met de server wordt de applicatie vanzelf weer opgestart.
        </p>
    </div>  

    <asp:UpdatePanel runat="server" UpdateMode="Conditional">
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="_timer" EventName="Tick" />
        </Triggers>
    </asp:UpdatePanel>
                
    <!-- Update Timer -->
    <asp:Timer runat="server" ID="_timer" Interval="300000" OnTick="_timer_Tick" Enabled="true"></asp:Timer>
</asp:Content>
