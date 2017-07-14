<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="AmstaJanBonga.Admin.Content.Unsecure.Login.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title>AmstaBord CMS - Login</title>

        <link href="~/Includes/Css/Login.css?build=04072017" rel="stylesheet" />
        
        <link rel="shortcut icon" type="image/x-icon" href="~/Includes/Css/Images/favicon.png" />

        <meta charset="UTF-8" />
        <meta name="robots" content="noindex, nofollow" />
        <meta name="viewport" content="width=device-width, initial-scale=1.0, user-scalable=no, minimum-scale=1.0, maximum-scale=1.0" />
    </head>

    <body>
        <form runat="server">
            <div id="form-signin" class="container">
                <div class="logo"></div>

                <asp:ScriptManager runat="server"></asp:ScriptManager>
                <asp:UpdatePanel runat="server" UpdateMode="Conditional">
                    <ContentTemplate>
                         <asp:Login runat="server" ID="_loginAuthentication" OnAuthenticate="_loginAuthentication_OnAuthenticate" RenderOuterTable="false">
                            <LayoutTemplate>
                                <asp:TextBox runat="server" ID="UserName" CssClass="textbox" MaxLength="20" ToolTip='<%$ Resources: Resource, EnterUsername %>'></asp:TextBox> 
                                <asp:TextBox runat="server" ID="Password" TextMode="Password" CssClass="textbox" MaxLength="20" ToolTip='<%$ Resources: Resource, EnterPassword %>'></asp:TextBox>
                                <asp:Button runat="server" ID="_btnLogin" Text='<%$ Resources: Resource, SignIn %>' CommandName="Login" CssClass="button" ToolTip='<%$ Resources: Resource, SignIn %>' />   
                            
                                <asp:Label runat="server" ID="FailureText" CssClass="error_detailed" ToolTip='<%$ Resources: Resource, AnErrorOccured %>'></asp:Label>
                            </LayoutTemplate>
                        </asp:Login>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
        </form>
    </body>
</html>
