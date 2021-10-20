<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dynamic Themes.aspx.cs" Inherits="WebApplication1.Dynamic_Themes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="ddlThemes" runat="server">
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="btnAplyTh" runat="server" OnClick="btnAplyTh_click" Text="Apply Theme" />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnClrTh" runat="server" OnClick="btnClTh_click" Text="Clear Theme" />
        </div>
    </form>
</body>
</html>
