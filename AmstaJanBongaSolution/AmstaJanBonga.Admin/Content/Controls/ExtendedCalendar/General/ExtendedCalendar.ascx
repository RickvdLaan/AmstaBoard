<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ExtendedCalendar.ascx.cs" Inherits="AmstaJanBonga.Admin.Content.Controls.ExtendedCalendar.General.ExtendedCalendar" %>

<asp:UpdatePanel runat="server" UpdateMode="Conditional">
    <ContentTemplate>
        <div class="calendar-wrapper purple-bg">
            <asp:Calendar runat="server" ID="_calendar" CssClass="calendar" OnDayRender="_calendar_DayRender">
                <TitleStyle CssClass="calendar-title" />
                <SelectedDayStyle CssClass="calendar-selected-day" />
                <DayStyle CssClass="calendar-day orange-bg" />
                <DayHeaderStyle CssClass="calendar-day-header orange-bg" />
                <NextPrevStyle CssClass="calendar-next-prev" />        
                <OtherMonthDayStyle CssClass="calendar-other-month-day red-bg" />
            </asp:Calendar>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>        