<%@ Page Title="" Language="C#" MasterPageFile="~/MainPage.Master" AutoEventWireup="true" CodeBehind="Payment.aspx.cs" Inherits="WebsiteTest.Payment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PaymentPage" runat="server">
    <h1>Payment</h1>
    <p>Enter card number: 
        <asp:TextBox ID="TextBox1" runat="server" Width="284px"></asp:TextBox>
&nbsp;</p>
    <p>Enter exp date:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Verify" OnClick="Button1_Click" />
    </p>
    <p>
        <asp:Button ID="Button2" runat="server" Text="Pay" Width="69px" OnClick="Button2_Click" />
    </p>
    <p>
        <asp:Label ID="Label1" runat="server"></asp:Label>
    </p>
</asp:Content>

