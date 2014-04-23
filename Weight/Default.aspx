<%@ Page Title="" Language="C#" MasterPageFile="~/Template.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table>
        <tr class="tableHead">
            <td>
                <asp:Label ID="lblWelcome" runat="server" Text="Welcome! Please log in to continue" />
            </td>
        </tr>
        <tr>
            <td><asp:Label ID="lblEMail" runat="server" Text="Enter your E-Mail address." /></td>
            <td><asp:TextBox ID="txtEMail" runat="server" /></td>
        </tr>
        <tr>
            <td><asp:Label ID="lblPassword" runat="server" Text="Enter your password" /></td>
            <td><asp:TextBox ID="txtPassword" runat="server" TextMode="Password" /></td>
        </tr>
        <tr>
            <td><asp:Button ID="btnReset" runat="server" Text="Cancel" OnClick="btnReset_Click" /></td>
            <td><asp:Button ID="btnSubmit" runat="server" Text="Log In" OnClick="btnSubmit_Click" /></td>
        </tr>
        <tr>
            <td><asp:HyperLink ID="hypNewEmail" runat="server" Text="Don't have an account? Click here."
                target="_self" NavigateUrl="~/CreateAccount.aspx" /></td>
        </tr>
    </table>
</asp:Content>

