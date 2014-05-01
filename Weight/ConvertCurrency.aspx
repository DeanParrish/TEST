<%@ Page Title="" Language="C#" MasterPageFile="~/Template.master" AutoEventWireup="true" CodeFile="ConvertCurrency.aspx.cs" Inherits="CurrencyConversion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:DropDownList ID="ddlCurrency1" runat="server" DataSourceID="xmlCurrency" >
        <asp:ListItem></asp:ListItem>
    </asp:DropDownList>
    </asp:DropDownList>
    <asp:XmlDataSource ID="xmlCurrency" runat="server" DataFile="~/App_Data/ExchangeRates.xml" />
    <asp:TextBox ID="txtAmount" runat="server" />
    <asp:Button ID="btnSubmit" runat="server" Text="Submit" />
    <asp:Label ID="lblResult" runat="server" />
</asp:Content>

