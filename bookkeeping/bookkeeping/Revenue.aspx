<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Revenue.aspx.cs" Inherits="bookkeeping.Revenue" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <strong>Add Revenue</strong></p>
    <p>
        <asp:TextBox ID="txtName" runat="server">[NAME]</asp:TextBox>
        <asp:TextBox ID="txtDescription" runat="server">[DESCRIPTION]</asp:TextBox>
        <asp:TextBox ID="txtAmount" runat="server">$</asp:TextBox>
        <asp:DropDownList ID="ddlRevenueParty" runat="server">
        </asp:DropDownList>
&nbsp;<asp:Button ID="btnRevenueSubmit" runat="server" OnClick="btnRevenueSubmit_Click" Text="Submit Revenue" />
    </p>
    <p>
        <strong>Last 10 Revenue</strong></p>
    <p>
        Here are the last 10 submissions...</p>
    <p>
        <strong>Highest 10 Revenue</strong></p>
    <p>
        Here are the highest 10 submissions of the past 6 months...</p>
    <p>
        &nbsp;</p>
</asp:Content>
