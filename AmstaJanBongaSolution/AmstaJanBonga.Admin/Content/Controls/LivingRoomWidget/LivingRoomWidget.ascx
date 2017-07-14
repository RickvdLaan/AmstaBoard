<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LivingRoomWidget.ascx.cs" Inherits="AmstaJanBonga.Admin.Content.Controls.LivingRoomWidget.LivingRoomWidget" %>

<div runat="server" id="_divWidget" class="widget">
    <h2>Woonkamers vandaag</h2>

    <p>
        Weergeeft welke gegevens wel of niet zijn ingevoerd voor vandaag. Druk op het kruisje, of het vinkje om te gegevens te bekijken of in te voeren.
    </p>

    <table class="living-room-statistics">
        <thead>         
            <tr>
                <td class="label">
                    Woonkamer:
                </td>

                <td>
                    <i class="fa fa-clock-o" aria-hidden="true" title="Diensten"></i>
                </td>

                <td>
                    <i class="fa fa-coffee" aria-hidden="true" title="Algemene informatie"></i>
                </td>

                <td>
                    <i class="el el-broom" aria-hidden="true" title="Corvee"></i>
                </td>
            </tr>
        </thead>

        <tbody>       
                <asp:Repeater runat="server" ID="_repLivingRooms">
                    <ItemTemplate>
                        <tr>
                            <td>
                                <%# Eval("Name") %>
                            </td>

                            <td>
                                 <%# (int)Eval("ShiftCount") == 0 ? 
                                         "<a href='Content/Secure/LivingRoom/Shifts/ShiftsAddEdit.aspx?LivingRoomId=" + Eval("Id") + "'><i class='fa fa-times' aria-hidden='true'></i></a>" : 
                                         "<a href='Content/Secure/LivingRoom/Shifts/ShiftsDetails.aspx?LivingRoomId=" + Eval("Id") + "&Date=" + DateTime.Now.Date + "'><i class='fa fa-check' aria-hidden='true'></i></a>" %>
                            </td>
                            

                            <td>
                                 <%# (int)Eval("GeneralCount") == 0 ? 
                                         "<a href='Content/Secure/LivingRoom/General/GeneralEventAddEdit.aspx?LivingRoomId=" + Eval("Id") + "'><i class='fa fa-times' aria-hidden='true'></i></a>" : 
                                         "<a href='Content/Secure/LivingRoom/General/GeneralDetails.aspx?LivingRoomId=" + Eval("Id") + "&Date=" + DateTime.Now.Date + "'><i class='fa fa-check' aria-hidden='true'></i></a>" %>
                            </td>

                            <td>
                                <%# (int)Eval("ChoreCount") == 0 ? 
                                         "<a href='Content/Secure/LivingRoom/Chores/ChoresAddEdit.aspx?LivingRoomId=" + Eval("Id") + "'><i class='fa fa-times' aria-hidden='true'></i></a>" : 
                                         "<a href='Content/Secure/LivingRoom/Chores/ChoresDetails.aspx?LivingRoomId=" + Eval("Id") + "&Date=" + DateTime.Now.Date + "'><i class='fa fa-check' aria-hidden='true'></i></a>" %>
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
        </tbody>
    </table>
</div>