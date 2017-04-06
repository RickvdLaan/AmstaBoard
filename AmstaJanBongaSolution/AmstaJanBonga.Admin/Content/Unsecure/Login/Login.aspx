<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="AmstaJanBonga.Admin.Content.Unsecure.Login.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>CMS - Login</title>

    <link href="~/Includes/Css/StyleSheet.css" rel="stylesheet" />
    <link href="~/Includes/Css/Login/Login.css" rel="stylesheet" />

    <meta charset="UTF-8" />
    <meta name="robots" content="noindex, nofollow" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0, user-scalable=no, minimum-scale=1.0, maximum-scale=1.0" />
</head>
<body>
    <form id="form1" runat="server">
        <div id="form-signin" class="container">
            <asp:Image runat="server" ImageUrl="~/Includes/Css/Images/logo.svg" CssClass="logo" AlternateText="Amsta" />

            <asp:Login runat="server" ID="_loginAuthentication" OnAuthenticate="_loginAuthentication_OnAuthenticate" RenderOuterTable="false">
                <LayoutTemplate>
                    <asp:TextBox runat="server" ID="UserName" CssClass="textbox" MaxLength="20" ToolTip='<%$ Resources: Resource, EnterUsername %>'></asp:TextBox> 
                    <asp:TextBox runat="server" ID="Password" TextMode="Password" CssClass="textbox" MaxLength="20" ToolTip='<%$ Resources: Resource, EnterPassword %>'></asp:TextBox>
                    <asp:Button runat="server" ID="_btnLogin" Text='<%$ Resources: Resource, SignIn %>' CommandName="Login" CssClass="button" ToolTip='<%$ Resources: Resource, SignIn %>' />   
                            
                    <asp:Label runat="server" ID="FailureText" CssClass="error_detailed" ToolTip='<%$ Resources: Resource, AnErrorOccured %>'></asp:Label>
                </LayoutTemplate>
            </asp:Login>
        </div>
    </form>
</body>
</html>
