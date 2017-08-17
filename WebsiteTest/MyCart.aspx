<%@ Page Title="" Language="C#" MasterPageFile="~/MainPage.Master" AutoEventWireup="true" CodeBehind="MyCart.aspx.cs" Inherits="WebsiteTest.MyCart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Cart" runat="server">
    <h1>Your items</h1>
    <p>
        <asp:ListBox ID="ListBox1" runat="server" Height="127px" style="margin-right: 32px" Width="258px"></asp:ListBox>
        <asp:Label ID="Label1" runat="server" Text="Final price"></asp:Label>
&nbsp;<asp:Label ID="Label2" runat="server" Width="72px"></asp:Label>
&nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="margin-left: 33px" Text="Proceed to payment" />
        <asp:Label ID="Label3" runat="server"></asp:Label>
    </p>
</asp:Content>

