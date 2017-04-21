<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="JsListBox.ascx.cs" Inherits="AmstaJanBonga.Admin.Content.Controls.JsListBox.JsListBox" %>

<asp:UpdatePanel runat="server" UpdateMode="Conditional">
    <ContentTemplate>
        <div class="js-listbox-container">
            <div class="js-listbox-wrapper">            
                <div class="js-listbox-source">
                   <%-- <small>Selecteerbaar</small>--%>

                    <asp:ListBox runat="server" ID="_lbSource" CssClass="js-listbox" SelectionMode="Multiple"></asp:ListBox>
                </div>

                <div class="js-listbox-button-area">
                    <ul>
                        <li>
                            <asp:LinkButton runat="server" ID="_lbTransferToDestination" CssClass="fa fa-arrow-right orange-bg js-listbox-button" aria-hidden="true" OnClick="_lbTransferToDestination_Click" />
                        </li>
                        <li>
                            <asp:LinkButton runat="server" ID="_lbTransferToSource" CssClass="fa fa-arrow-left orange-bg js-listbox-button" aria-hidden="true" OnClick="_lbTransferToSource_Click" />
                        </li>
                    </ul>
                </div>

                <div class="js-listbox-destination">
                    <%--<small>Geselecteerd</small>--%>
                    <asp:ListBox runat="server" ID="_lbDestination" CssClass="js-listbox" SelectionMode="Multiple"></asp:ListBox>
                </div>
            </div>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>