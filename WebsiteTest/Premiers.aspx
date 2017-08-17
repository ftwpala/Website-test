<%@ Page Title="" Language="C#" MasterPageFile="~/MainPage.Master" AutoEventWireup="true" CodeBehind="Premiers.aspx.cs" Inherits="WebsiteTest.Premiers" %>
<%@ MasterType VirtualPath="~/MainPage.Master" %>  

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Premiers" runat="server">
    <h1>Movies projected this week</h1>
    <h1>
        <asp:Label ID="Label1" runat="server" ForeColor="Red" Text="You have to be logged in to add tickets to your cart!"></asp:Label>
    </h1>
    <h1>
        <asp:ImageButton ID="ImageButton1" runat="server" Height="173px" Width="150px" ImageUrl="~/Graphic/RickMorty.png" AlternateText="No Image available" OnClick="ImageButton1_Click"/>
        <asp:ImageButton ID="ImageButton2" runat="server" Height="173px" style="margin-left: 27px" Width="150px" ImageUrl="~/Graphic/RideAlong.png" AlternateText="No Image available" OnClick="ImageButton2_Click"/>
        <asp:ImageButton ID="ImageButton3" runat="server" Height="173px" style="margin-left: 27px" Width="150px" ImageUrl="~/Graphic/Godfather.png" AlternateText="No Image available" OnClick="ImageButton3_Click"/>
    </h1>
    <h1>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="margin-left: 25px" Text="Add to cart" Width="89px" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="margin-left: 97px" Text="Add to cart" />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" style="margin-left: 87px" Text="Add to cart" />
    </h1>
</asp:Content>
