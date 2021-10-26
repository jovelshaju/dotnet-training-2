<%@ Page Title="" Language="C#" MasterPageFile="~/SiteLayout.Master" AutoEventWireup="true" CodeBehind="Logout.aspx.cs" Inherits="RoleBasedExrse.Logout" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
                <tr>
                    <td colspan="3"><h1>Sign Out Page</h1>
                       <br />
                        <h2>Bye!!!</h2>
                    </td>
                </tr>
                <tr>
                    <td colspan="3">&nbsp; You have signed out from the website to sign In again&nbsp;
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Login.aspx">Click Here</asp:HyperLink>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp; You can browse our web as a guest as well&nbsp; to browse&nbsp; Home Page&nbsp;&nbsp;
                        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Home.aspx">Click Here</asp:HyperLink>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
</asp:Content>
