<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ThreeMethod.aspx.cs" Inherits="WebApplication1.ThreeMethod" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Three Methods
            <br />
            <br />
            <asp:Button Text="Response Redirect" runat="server" ID="btnRR" OnClick="btnRR_click" SkinID="BlueButton" />
            <br />
            <br />
            <asp:Button Text="Server Transer" runat="server" ID="btnST" OnClick="btnST_click" />
            <br />
            <br />
            <asp:Button Text="Server Execute" runat="server" />
        </div>
    </form>
</body>
</html>
