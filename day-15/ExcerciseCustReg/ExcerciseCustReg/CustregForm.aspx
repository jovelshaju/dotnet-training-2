<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustregForm.aspx.cs" Inherits="ExcerciseCustReg.WebForm1" %>

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
            <div class="row">Enter your Details below</div>
            <br />
            <div class="col-md-4">
                <asp:Label ID="usrNameLbl" runat="server" Text="Enter Name:"></asp:Label>
                <asp:TextBox ID="usrNameInput" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="usrNameInput" ErrorMessage="Name is required" ForeColor="Red"></asp:RequiredFieldValidator>
                <br />
                <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="usrNameInput" ErrorMessage="Name must be of length atleast 6" ForeColor="Red" OnServerValidate="NameLengthCheck"></asp:CustomValidator>

            </div>
            <br />

            <div class="col-md-4">
                <asp:Label ID="usrGenderLbl" runat="server" Text="Choose Gender:"></asp:Label>
                <asp:RadioButtonList ID="usrGenderInput" runat="server">
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                    <asp:ListItem>Transgender</asp:ListItem>
                </asp:RadioButtonList>
            </div>
            <br />

            <div class="col-md-4">
                <asp:Label ID="usrCityLbl" runat="server" Text="Enter City:"></asp:Label>
                <asp:DropDownList ID="usrCityInput" runat="server">
                    <asp:ListItem>Mumbai</asp:ListItem>
                    <asp:ListItem>Delhi</asp:ListItem>
                    <asp:ListItem>Chennai</asp:ListItem>
                    <asp:ListItem>Bangalore</asp:ListItem>
                </asp:DropDownList>
            </div>
            <br />

            <div class="col-md-4">
                <asp:Label ID="usrFrqntlyShopLbl" runat="server" Text="Enter Frequently Shopping Materials:"></asp:Label>
                <asp:CheckBoxList ID="usrChoicesInput" runat="server">
                    <asp:ListItem>Clothes</asp:ListItem>
                    <asp:ListItem>Electronics</asp:ListItem>
                    <asp:ListItem>Home Appliances</asp:ListItem>
                    <asp:ListItem>Stationary</asp:ListItem>
                </asp:CheckBoxList>
            </div>
            <br />


            <div class="col-md-4">
                <asp:Label ID="usrMailLbl" runat="server" Text="Enter Mail-ID:"></asp:Label>
                <asp:TextBox ID="usrMailIDInput" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="usrMailIDInput" ErrorMessage="Mail-ID is required" ForeColor="Red"></asp:RequiredFieldValidator>
                <br />
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="usrMailIDInput" ErrorMessage="Enter valid Email-ID" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </div>
            <br />

            <div class="col-md-4">
                <asp:Button ID="btn_Submit" runat="server" OnClick="btn_Submit_Click" Text="Submit" />

            </div>
            <br />
            <div class="col-md-4">
                <asp:Label ID="DetailsLbl" runat="server"></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>
