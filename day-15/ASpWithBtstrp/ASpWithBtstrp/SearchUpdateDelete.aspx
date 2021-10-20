<%@ Page Title="" Language="C#" MasterPageFile="~/SiteLayout.Master" AutoEventWireup="true" CodeBehind="SearchUpdateDelete.aspx.cs" Inherits="ASpWithBtstrp.SearchUpdateDelete" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="w-100">
        <tr>
            <td>Enter ID:</td>
            <td>
                <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;&nbsp;
                <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_click" />
            </td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:Label ID="msgLbl" runat="server" ForeColor="Red"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:panel ID="DataPanel" runat="server">
                    <table id="DetailsTable" class="w-100">
                    <tr>
                        <td>CID</td>
                        <td>
                            <asp:Label ID="usrCID" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>CName</td>
                        <td>
                            <asp:TextBox ID="usrName" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>CEmail</td>
                        <td>
                            <asp:TextBox ID="usrEMail" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>CContact</td>
                        <td>
                            <asp:TextBox ID="usrContact" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_click" />
                        </td>
                        <td>
                            <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_click" />
                        </td>
                    </tr>
                </table>
                </asp:panel>
                
            </td>
        </tr>
    </table>
</asp:Content>
