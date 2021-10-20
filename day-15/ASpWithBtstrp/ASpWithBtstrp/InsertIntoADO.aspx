<%@ Page Title="" Language="C#" MasterPageFile="~/SiteLayout.Master" AutoEventWireup="true" CodeBehind="InsertIntoADO.aspx.cs" Inherits="ASpWithBtstrp.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <h2>Customer Registration</h2>
        
  <div class="mb-3">
      <asp:Label Text="Enter ID:" runat="server" CssClass="form-label" />
      &nbsp;
      <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="usrIDInput" ErrorMessage="ID is required" ForeColor="Red"></asp:RequiredFieldValidator>
      <asp:TextBox runat="server" ID="usrIDInput" CssClass="form-control"/>
      
      
  </div>
        <div class="mb-3">
          <asp:Label Text="Enter Name:" runat="server" CssClass="form-label" />
      &nbsp;
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="usrnameInput" ErrorMessage="Name is required" ForeColor="Red"></asp:RequiredFieldValidator>
      <asp:TextBox runat="server" ID="usrnameInput" CssClass="form-control"/>
      </div>
    <div class="mb-3">
      <asp:Label Text="Enter Email ID:" runat="server" CssClass="form-label" />
      &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="usrnameInput" ErrorMessage="Email-ID is required" ForeColor="Red"></asp:RequiredFieldValidator>
&nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="usrEmailInput" ErrorMessage="Enter Valid Email-ID" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
&nbsp;<asp:TextBox runat="server" ID="usrEmailInput" CssClass="form-control"/>
  </div>
  <div class="mb-3">
      <asp:Label Text="Enter Contact:" runat="server" CssClass="form-label" />
      &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="usrnameInput" ErrorMessage="Contact is required" ForeColor="Red"></asp:RequiredFieldValidator>
&nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="usrContactInput" ErrorMessage="Enter Valid Contact" ForeColor="Red" ValidationExpression="\d{10}"></asp:RegularExpressionValidator>
      <asp:TextBox runat="server" ID="usrContactInput" CssClass="form-control"/>
  </div>

            <asp:Button Text="Submit" runat="server" CssClass="btn btn-primary" OnClick="btn_Reg_Cust" />

        <br />
        <br />
        <asp:Label ID="lblMsg" runat="server"></asp:Label>

    </div>
   
</asp:Content>
