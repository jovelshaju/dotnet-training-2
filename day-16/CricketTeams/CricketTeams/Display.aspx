<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Display.aspx.cs" Inherits="CricketTeams.Display" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
        <div class="row">
            <div class="col-md-12">
                <h2>---Team List---</h2>
                <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
                <asp:GridView ID="gvTeams" runat="server" CellPadding="4" AutoGenerateColumns="False" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:BoundField DataField="TeamID" HeaderText="Team ID" />
                        <asp:BoundField DataField="TeamName" HeaderText="Team Name" />
                        <asp:ImageField DataImageUrlField="TeamLogo" HeaderText="Team Logo">
                            <ControlStyle BorderColor="#993366" BorderStyle="Solid" BorderWidth="2px" Height="300px" Width="300px" />
                        </asp:ImageField>
                    </Columns>
                    <EditRowStyle BackColor="#2461BF" />
                    <FooterStyle BackColor="#507CD1" ForeColor="White" Font-Bold="True" />
                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <PagerStyle ForeColor="White" HorizontalAlign="Center" BackColor="#2461BF" />
                    <RowStyle BackColor="#EFF3FB" />
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#F5F7FB" />
                    <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                    <SortedDescendingCellStyle BackColor="#E9EBEF" />
                    <SortedDescendingHeaderStyle BackColor="#4870BE" />
                </asp:GridView>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
