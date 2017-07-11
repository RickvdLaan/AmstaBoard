<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Main.Master" AutoEventWireup="true" CodeBehind="AgendaAddEdit.aspx.cs" Inherits="AmstaJanBonga.Admin.Content.Secure.Patient.Agenda.AgendaAddEdit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="_cphHead" runat="server">
    <link href="../../../../Includes/jquery.datetimepicker.min.css" rel="stylesheet" />
    <script src="../../../../Includes/jquery.datetimepicker.full.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="_cphMainTitle" runat="server">
    Afspraak
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="_cphSubTitle" runat="server">
    <%= Helper.SubTitleAddEdit %>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="_cphExplanation" runat="server">
    Vanuit hier kan een afspraak worden toegevoegd of een bestaande afspraak worden gewijzigd.
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="_cphContent" runat="server">
    <asp:HiddenField runat="server" ID="_hfStart" />
    <asp:HiddenField runat="server" ID="_hfEnd" />
    
    <div class="box">
        <h2 class="display-inline">
            Afspraak <%= Helper.SubTitleAddEdit %>
        </h2>

        <div class="return right">
            <asp:HyperLink runat="server" CssClass="return fa fa-reply display-inline" ToolTip="Terug naar patiëntenoverzicht" NavigateUrl="~/Content/Secure/Patient/PatientOverview.aspx"></asp:HyperLink>
        </div>

        <div class="clear"></div>

        <table class="table-add-edit">
            <tbody>
                <tr>
                    <td class="label required">
                        Titel
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="_txtTitle" CssClass="textbox" placeholder="Titel" MaxLength="20"></asp:TextBox>
                        <asp:RequiredFieldValidator runat="server" ValidateRequestMode="Enabled" CssClass="error" ErrorMessage="Verplichte velden kunnen niet leeg blijven." Display="Dynamic" ControlToValidate="_txtTitle" ValidationGroup="Validate"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="label required">
                        Datum & starttijd
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="_txtStart" CssClass="textbox" ReadOnly="true" placeholder="Start datum en tijd"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td class="label required">
                        Eindtijd
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="_txtEnd" CssClass="textbox" ReadOnly="true" placeholder="Eindtijd"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td class="label">
                        Locatie
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="_txtLocation" CssClass="textbox" placeholder="Locatie" MaxLength="20"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td class="label">
                        Omschrijving
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="_txtDescription" CssClass="textbox" Height="150" placeholder="Omschrijving" MaxLength="255" TextMode="MultiLine"></asp:TextBox>
                    </td>
                </tr>

                
                <tr>
                    <td class="label">
                        Wekelijks herhalen
                    </td>
                    <td>
                        <asp:CheckBox runat="server" ID="_cbRepeat" />
                    </td>
                </tr>
            </tbody>
        </table>

        <asp:Label runat="server" ID="_lblError" CssClass="error"></asp:Label>
    </div>

    <div class="box">
        <asp:Button runat="server" ID="_btnSave" CssClass="button button-save green-bg" Text="Opslaan" OnClick="_btnSave_Click" ValidateRequestMode="Enabled" ValidationGroup="Validate" CausesValidation="true" />
        <asp:Button runat="server" ID="_btnCancel" CssClass="button button-cancel red-bg" Text="Annuleren" OnClick="_btnCancel_Click" />
    </div>


























        <script>
            jQuery.datetimepicker.setLocale('nl');

            $('#<%= _txtStart.ClientID %>').datetimepicker({
                onGenerate: function (ct, $input) {
                    $input.prop('readonly', true);
                    var $this = $(this);
                    $this.find('.xdsoft_date').removeClass('xdsoft_disabled');
                    $this.find('.xdsoft_time').removeClass('xdsoft_disabled');
                }
            });

            $('#<%= _txtStart.ClientID %>').datetimepicker({
                inline: false,
                datepicker: true,
                lang: 'nl',
                timepicker: true,
                step: 15,
                onChangeDateTime: function (current_time, $input) {
                    var hfStart = document.getElementById('<%= _hfStart.ClientID %>');

                if (hfStart) {
                    hfStart.value = current_time;
                }
            },
            defaultTime: '08:00',
            allowTimes: [
                '08:00', '08:15', '08:30', '08:45',
                '09:00', '09:15', '09:30', '09:45',
                '10:00', '10:15', '10:30', '10:45',
                '11:00', '11:15', '11:30', '11:45',
                '12:00', '12:15', '12:30', '12:45',
                '13:00', '13:15', '13:30', '13:45',
                '14:00', '14:15', '14:30', '14:45',
                '15:00', '15:15', '15:30', '15:45',
                '16:00', '16:15', '16:30', '16:45',
                '17:00', '17:15', '17:30', '17:45',
                '18:00', '18:15', '18:30', '18:45',
                '19:00', '19:15', '19:30', '19:45',
                '20:00', '20:15', '20:30', '20:45',
                '21:00', '21:15', '21:30', '21:45',
                '22:00', '22:15', '22:30', '22:45',
                '23:00', '23:15', '23:30', '23:45',
            ]
            });

            $('#<%= _txtEnd.ClientID %>').datetimepicker({
                onGenerate: function (ct, $input) {
                    $input.prop('readonly', true);
                    var $this = $(this);
                    $this.find('.xdsoft_date').removeClass('xdsoft_disabled');
                    $this.find('.xdsoft_time').removeClass('xdsoft_disabled');
                }
            });

            $('#<%= _txtEnd.ClientID %>').datetimepicker({
                datepicker: false,
                step: 15,
                allowTimes: [
                    '08:00', '08:15', '08:30', '08:45',
                    '09:00', '09:15', '09:30', '09:45',
                    '10:00', '10:15', '10:30', '10:45',
                    '11:00', '11:15', '11:30', '11:45',
                    '12:00', '12:15', '12:30', '12:45',
                    '13:00', '13:15', '13:30', '13:45',
                    '14:00', '14:15', '14:30', '14:45',
                    '15:00', '15:15', '15:30', '15:45',
                    '16:00', '16:15', '16:30', '16:45',
                    '17:00', '17:15', '17:30', '17:45',
                    '18:00', '18:15', '18:30', '18:45',
                    '19:00', '19:15', '19:30', '19:45',
                    '20:00', '20:15', '20:30', '20:45',
                    '21:00', '21:15', '21:30', '21:45',
                    '22:00', '22:15', '22:30', '22:45',
                    '23:00', '23:15', '23:30', '23:45',
                ],
                onChangeDateTime: function (current_time, $input) {
                    var hfEnd = document.getElementById('<%= _hfEnd.ClientID %>');

                    if (hfEnd) {
                        hfEnd.value = current_time;
                    }
                },
                format: 'H:i'
            });

    </script>
</asp:Content>
