<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LivingRoomWidget.ascx.cs" Inherits="AmstaJanBonga.Admin.Content.Controls.LivingRoomWidget.LivingRoomWidget" %>

<div runat="server" id="_divWidget" class="widget">
    <h2>Woonkamers vandaag</h2>

    <p>
        Weergeeft welke gegevens wel of niet zijn ingevoerd voor vandaag.
    </p>

    <table>
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
                    <i class="fa fa-trash-o" aria-hidden="true" title="Corvee"></i>
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
                                         "<i class='fa fa-times' aria-hidden='true'></i>" : 
                                         "<i class='fa fa-check' aria-hidden='true'></i>" %>
                            </td>
                            

                            <td>
                                 <%# (int)Eval("GeneralCount") == 0 ? 
                                         "<i class='fa fa-times' aria-hidden='true'></i>" : 
                                         "<i class='fa fa-check' aria-hidden='true'></i>" %>
                            </td>

                            <td>
                                <%# (int)Eval("ChoreCount") == 0 ? 
                                         "<i class='fa fa-times' aria-hidden='true'></i>" : 
                                         "<i class='fa fa-check' aria-hidden='true'></i>" %>
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
        </tbody>
    </table>
</div>