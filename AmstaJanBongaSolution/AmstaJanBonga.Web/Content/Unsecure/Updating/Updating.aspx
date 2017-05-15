<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Updating.aspx.cs" Inherits="AmstaJanBonga.Web.Content.Unsecure.Updating.Updating" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Aan het updaten...</title>
    
    <style type="text/css">
        @font-face {
            font-family: Arcon;
            src: url(arcon.regular.otf);
        }

        * {
            margin: 0;
            padding: 0;
        }

        html, body, form, #container {
            display: table;
            height: 100%;
            width: 100%;
        }

        body {
            font-family: 'Open Sans', sans-serif;
        }

        .orange-bg {
            background: rgb(255,146,0);
            background: -moz-linear-gradient(top, rgba(255,167,53,1) 0%, rgba(255,146,0,1) 100%);
            background: -webkit-linear-gradient(top, rgba(255,167,53,1) 0%,rgba(255,146,0,1) 100%);
            background: linear-gradient(to bottom, rgba(255,167,53,1) 0%,rgba(255,146,0,1) 100%);
            filter: progid:DXImageTransform.Microsoft.gradient( startColorstr='#ffa735', endColorstr='#ff9200',GradientType=0 );
        }

        div#container {
            color: #f7f7f7;
            display: table-cell;
            text-align: center;
            vertical-align: middle;
        }

        #container > div {
            left: 0;
            position: absolute;
            right: 0;
            top: 20%;
        }

        div#container i {
            animation-duration: 3s;
            font-size: 8em;
            margin-bottom: 25px;
            opacity: 0.55;
        }
        
        div#container h1 {
            margin-bottom: 30px;
        }

        div#container p {
            margin: 15px auto;
            text-align: left;
            width: 650px;
            font-size: 18px;
        }
    </style>

    <!-- 17kb -->
    <link href="https://fonts.googleapis.com/css?family=Open+Sans" rel="stylesheet" type="text/css" />
    <!-- 33kb -->
    <script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jquery/1.7/jquery.min.js"></script>  
       
    <!-- Loading FontAwesome before rendering the page -->
    <script type="text/javascript"> 
        (function () {
            var css = document.createElement('link');
            css.href = '/Includes/font-awesome-4.7.0/css/font-awesome.min.css';
            css.rel = 'stylesheet';
            css.type = 'text/css';

            document.getElementsByTagName('head')[0].appendChild(css);
        })(); 
    </script>
</head>
<body>
    <form id="form1" class="orange-bg" runat="server">
        <asp:ScriptManager runat="server" EnablePageMethods="true"></asp:ScriptManager>
        
        <div id="container"> 
            <asp:UpdatePanel runat="server" UpdateMode="Conditional">
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="_timer" EventName="Tick" />
                </Triggers>
            </asp:UpdatePanel>

            <!-- Update Timer -->
            <asp:Timer runat="server" ID="_timer" Interval="10000" OnTick="_timer_Tick"></asp:Timer>

            <div>
                <i class="fa fa-spinner fa-spin fa-3x fa-fw"></i>
            </div>

            <h1>
                De applicatie is aan het updaten
            </h1>

            <p>
                De applicatie is aan het updaten naar een nieuwe versie, dit proces neemt enkele minuten in beslag.
            </p>

            <p>
                Er hoeft verder niets gedaan te worden, zodra de update is uitgevoerd wordt de applicatie automatisch opnieuw opgestart.
            </p>
        </div>
    </form>
</body>
</html>
