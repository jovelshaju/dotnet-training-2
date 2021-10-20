<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PlayerReg.aspx.cs" Inherits="CricketTeams.PlayerReg" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous" />

    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p" crossorigin="anonymous"></script>

</head>
<body>
    <form id="form1" runat="server">
        <div class="container" style="padding:10px">
            <div class="row">
                <h2>Player Registration Form</h2>
            </div>
            <div class="row">
                <div class="col-md-4">Enter Player ID: </div>
                <div class="col-md-4">
                    <asp:TextBox ID="txtPlayerID" runat="server"></asp:TextBox>
                    &nbsp;&nbsp;
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Player ID is required" ForeColor="Red" ControlToValidate="txtPlayerID"></asp:RequiredFieldValidator>
                    <br />
                </div>
            </div>
            <div class="row">
                <div class="col-md-4">Enter Player Name: </div>
                <div class="col-md-4">
                    <asp:TextBox ID="txtPlayerName" runat="server"></asp:TextBox>
                    &nbsp;&nbsp;
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Player Name is required" ForeColor="Red" ControlToValidate="txtPlayerName"></asp:RequiredFieldValidator>
                    <br />
                </div>
            </div>
            <div class="row">
                <div class="col-md-4">Choose Team: </div>
                <div class="col-md-4">
                    <asp:DropDownList ID="TeamList" runat="server" DataSourceID="SqlDataSource1" DataTextField="TeamName" DataValueField="TeamID">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CricDBConnectionString %>" SelectCommand="SELECT [TeamName], [TeamID] FROM [Teams]"></asp:SqlDataSource>
                    <br />
                </div>

            </div>
            <div class="row">
                                <div class="col-md-4">Enter Date of Birth: </div>
                <div class="col-md-4"> 
                    <asp:Calendar ID="calDOB" runat="server" BackColor="White" BorderColor="#3366CC" BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#003399" Height="200px" Width="220px">
                        <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
                        <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
                        <OtherMonthDayStyle ForeColor="#999999" />
                        <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                        <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
                        <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" Font-Bold="True" Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
                        <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
                        <WeekendDayStyle BackColor="#CCCCFF" />
                    </asp:Calendar>
                                </div>
            </div>
            <div class="row">
                <div class="col-md-4">Upload Player Photo: </div>
                <div class="col-md-4">
                    <asp:FileUpload ID="imgUpload" runat="server" />
                    <br />
                </div>
            </div>

            <asp:Button Text="Register" CssClass="btn btn-primary" runat="server" ID="btnRegister" OnClick="btnRegister_click" />
            <br />
            <br />
            <asp:Label ID="lblMsg" runat="server" ForeColor="Red"></asp:Label>
        </div>
    </form>
</body>
</html>
