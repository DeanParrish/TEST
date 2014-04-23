<%@ Page Title="" Language="C#" MasterPageFile="~/Template.master" AutoEventWireup="true" CodeFile="CreateAccount.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
        <table class="tableView">
            <tr>
                <td><asp:Label ID="lblEMail" runat="server" Text="E-Mail:" /></td>
                <td><asp:TextBox ID="txtEMail" runat="server" /></td>
                <td>

        <asp:RegularExpressionValidator ID="validEMail" runat="server" 
            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" CssClass="error" 
            ControlToValidate="txtHeightFoot" ErrorMessage="This must be a valid email." Display="Dynamic" 
            Text="This must be a valid email" />

                </td>
            </tr>
            <tr>
                <td><asp:Label ID="lblLastName" runat="server" Text="Last Name:" /></td>
                <td><asp:TextBox ID="txtLastName" runat="server" /></td>
            </tr>
            <tr>
                <td><asp:Label ID="lblFirstName" runat="server" Text="First Name:" /></td>
                <td><asp:TextBox ID="txtFirstName" runat="server" /></td>
            </tr>
            <tr>
                <td><asp:Label ID="lblWeight" runat="server" Text="Weight:" /></td>
                <td><asp:TextBox ID="txtWeight" runat="server" /></td>
            </tr>
            <tr>
                <td><asp:Label ID="lblHeightFoot" runat="server" Text="Height in Feet" /></td>
                <td><asp:TextBox ID="txtHeightFoot" runat="server" /></td>
            </tr>
            <tr>
                <td><asp:Label ID="lblHeightInch" runat="server" Text="Height in Inches" /></td>
                <td><asp:TextBox ID="txtHeightInch" runat="server" /></td>
            </tr>
            <tr>
                <td><asp:Button ID="btnReset" runat="server" Text="Cancel" OnClick="btnReset_Click" CausesValidation="False" /></td>
                <td><asp:Button ID="btnSubmit" runat="server" Text="Sign Up" OnClick="btnSubmit_Click" CausesValidation="true" /></td>
            </tr>
        </table>

        </asp:Content>

