<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Revenue.aspx.cs" Inherits="bookkeeping.Revenue" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        Add Revenue</p>
    <p>
        <asp:TextBox ID="txtName" runat="server">[NAME]</asp:TextBox>
        <asp:TextBox ID="txtDescription" runat="server">[DESCRIPTION]</asp:TextBox>
        <asp:TextBox ID="txtAmount" runat="server">$</asp:TextBox>
&nbsp;<asp:Button ID="btnRevenueSubmit" runat="server" OnClick="btnRevenueSubmit_Click" Text="Submit Revenue" />
    </p>
    <p>
        Last 10 Revenue</p>
    <p>
        &nbsp;</p>
    <p>
        Highest 10 Revenue</p>
    <p>
        &nbsp;</p>
</asp:Content>
