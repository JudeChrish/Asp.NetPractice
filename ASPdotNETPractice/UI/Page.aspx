<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page.aspx.cs" Inherits="ASPdotNETPractice.UI.Page1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Test</h1>
        </div>
        <div>
            <JC:Calendar ID="Calendar1" runat="server" />
        </div>
        <asp:Button ID="PrintonScreenButton" runat="server" Text="Print on Web page" OnClick="PrintonScreen_ButtonClick" />
    </form>
</body>
</html>
