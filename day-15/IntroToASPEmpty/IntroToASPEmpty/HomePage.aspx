<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="IntroToASPEmpty.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 201px;
        }
        .auto-style3 {
            width: 291px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
        <tr>
            <td colspan="3"><h2>Few Basic Controls</h2></td>
        </tr>
        <tr>
            <td class="auto-style2">User Name</td>
            <td class="auto-style3">
                <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUserName" ErrorMessage="Enter User Name First" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">User Email</td>
            <td class="auto-style3">
                <asp:TextBox ID="txtUserEmail" runat="server" TextMode="Email"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtUserEmail" ErrorMessage="Enter User Email" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">User Password</td>
            <td class="auto-style3">
                <asp:TextBox ID="txtUserPwd" runat="server" TextMode="Password"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtUserPwd" ErrorMessage="Enter User Password" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Confirm Password</td>
            <td class="auto-style3">
                <asp:TextBox ID="txtCPwd" runat="server" TextMode="Password"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtCPwd" ErrorMessage="Re Enter User Password" ForeColor="Red"></asp:RequiredFieldValidator>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtUserPwd" ControlToValidate="txtCPwd" ErrorMessage="Password Confirm Password Mismatch" ForeColor="Red"></asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">User Age</td>
            <td class="auto-style3">
                <asp:TextBox ID="txtUsrAge" runat="server" TextMode="Number"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtUsrAge" ErrorMessage="Enter User Age" ForeColor="Red"></asp:RequiredFieldValidator>
                <br />
                <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtUsrAge" ErrorMessage="Age must be between 18 and 85" ForeColor="Red" MaximumValue="85" MinimumValue="18" Type="Integer"></asp:RangeValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Pincode</td>
            <td class="auto-style3">
                <asp:TextBox ID="txtUsrPincode" runat="server" TextMode="Number"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtUsrPincode" ErrorMessage="Enter Pincode" ForeColor="Red"></asp:RequiredFieldValidator>
                <br />
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtUsrPincode" ErrorMessage="Invalid Pincode: Enter 6 digit" ForeColor="Red" ValidationExpression="\d{6}"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">About User </td>
            <td class="auto-style3">
                <asp:TextBox ID="txtAbout" runat="server" Height="129px" TextMode="MultiLine" Width="324px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">
                <asp:Button ID="btnSubmit" runat="server" OnClick="BtnSubmit_Click" Text="Submit Details" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:Label ID="lblInfo" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
