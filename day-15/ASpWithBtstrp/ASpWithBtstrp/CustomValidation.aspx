<%@ Page Title="" Language="C#" MasterPageFile="~/SiteLayout.Master" AutoEventWireup="true" CodeBehind="CustomValidation.aspx.cs" Inherits="ASpWithBtstrp.CustomValidation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-md-4">Enter Even Number</div>
        <div class="col-md-4">
            <asp:TextBox ID="numInput" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="numInput" ErrorMessage="Please Enter Number" ForeColor="Red"></asp:RequiredFieldValidator>
        </div>
    </div>
    <div class="col-md-4">
        <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="numInput" ErrorMessage="Enter Even Number" ForeColor="Red" OnServerValidate="CheckEven"></asp:CustomValidator>
    </div>
    <div>
        <asp:Button ID="Button1" runat="server" OnClick="Btn_Submit_Click" Text="Submit" />
    </div>
    <div>
        <asp:Label ID="ResultLabel" runat="server"></asp:Label>
    </div>
</asp:Content>
