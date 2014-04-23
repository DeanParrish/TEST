<%@ Page Title="" Language="C#" MasterPageFile="~/Template.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table>
        <thead>
            <asp:Label ID="lblWelcome" runat="server" Text="Welcome! Please log in to continue" />
        </thead>
        <tr>
            <td><asp:Label ID="lblEMail" runat="server" Text="Enter your E-Mail address." /></td>
        </tr>
    </table>
</asp:Content>

