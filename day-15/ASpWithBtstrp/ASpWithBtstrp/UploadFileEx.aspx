<%@ Page Title="" Language="C#" MasterPageFile="~/SiteLayout.Master" AutoEventWireup="true" CodeBehind="UploadFileEx.aspx.cs" Inherits="ASpWithBtstrp.UploadFileEx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="w-100">
    <tr>
        <td>Upload Image Here:</td>
        <td>
            <asp:FileUpload ID="imgUpload" runat="server" />
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>
            <asp:Button ID="btnUpload" runat="server" OnClick="btnUpload_click" Text="Upload" />
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblMsg" runat="server" ForeColor="Red"></asp:Label>
        </td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>
