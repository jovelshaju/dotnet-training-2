<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="UserDBExcercise.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <h2>User Sign In</h2>


        <div class="mb-3">
            <asp:Label Text="Enter Username:" runat="server" CssClass="form-label" />
            &nbsp;
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtUsrName" ErrorMessage="Username is required" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:TextBox runat="server" ID="txtUsrName" CssClass="form-control" />
        </div>
        <div class="mb-3">
            <asp:Label Text="Enter Password:" runat="server" CssClass="form-label" />
            &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtUsrPswd" ErrorMessage="Password is required" ForeColor="Red"></asp:RequiredFieldValidator>
            &nbsp;<asp:TextBox runat="server" ID="txtUsrPswd" CssClass="form-control" />
        </div>

        <asp:Button Text="Submit" runat="server" CssClass="btn btn-primary" OnClick="btnSignIn_click" />

        <br />
        <br />
        <asp:Label ID="lblMsg" runat="server"></asp:Label>

    </div>
</asp:Content>
