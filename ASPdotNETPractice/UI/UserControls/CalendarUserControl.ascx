<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CalendarUserControl.ascx.cs" Inherits="ASPdotNETPractice.UI.UserControls.CalendarUserControl" %>
<h3>Calendar User Control</h3>
<div>
    <p>
        Date of Birth
    <asp:TextBox ID="DOBTextBox" runat="server" Enabled="false">Select Date of Birth</asp:TextBox>
        <asp:Button ID="CalendarButton" runat="server" Text="Calendar" OnClick="CalendarButton_Click" />
        <asp:Calendar ID="Calendar" runat="server" OnSelectionChanged="Calendar_SelectDate"></asp:Calendar>
    </p>
</div>
