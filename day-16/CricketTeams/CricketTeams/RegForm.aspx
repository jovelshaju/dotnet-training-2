<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegForm.aspx.cs" Inherits="CricketTeams.RegForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous" />

    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p" crossorigin="anonymous"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                <h2>Team Registration Form</h2>
            </div>
            <div class="row">
                <div class="col-md-4">Enter Team ID: </div>
                <div class="col-md-4">
                    <asp:TextBox ID="txtTeamID" runat="server"></asp:TextBox>
                    &nbsp;&nbsp;
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Team ID is required" ForeColor="Red" ControlToValidate="txtTeamID"></asp:RequiredFieldValidator>
                    <br />
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Enter Valid Team ID" ValidationExpression="T[0-9][0-9]" ForeColor="Red" ControlToValidate="txtTeamID"></asp:RegularExpressionValidator>
                </div>
            </div>
            <div class="row">
                <div class="col-md-4">Enter Team Name: </div>
                <div class="col-md-4">
                    <asp:TextBox ID="txtTeamName" runat="server"></asp:TextBox>
                    &nbsp;&nbsp;
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Team Name is required" ForeColor="Red" ControlToValidate="txtTeamName"></asp:RequiredFieldValidator>
                    <br />
                </div>
            </div>

            <div class="row">
                <div class="col-md-4">Upload Team Logo: </div>
                <div class="col-md-4">
                    <asp:FileUpload ID="imgUpload" runat="server" />
                    <br />
                </div>
            </div>
            <asp:Button Text="Submit" CssClass="btn btn-primary" runat="server" ID="btnSubmit" OnClick="btnSubmit_click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/PlayerReg.aspx">Register Player</asp:HyperLink>
            <br />
            <br />
            <asp:Label ID="lblMsg" runat="server" ForeColor="Red"></asp:Label>
        </div>
    </form>

</body>
</html>
