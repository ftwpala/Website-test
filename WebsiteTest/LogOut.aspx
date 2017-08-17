<%@ Page Title="" Language="C#" MasterPageFile="~/MainPage.Master" AutoEventWireup="true" CodeBehind="LogOut.aspx.cs" Inherits="WebsiteTest.LogOut" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" runat="server" contentplaceholderid="LogOutPage">
           
    <h1 style="height: 101px">Are you sure you want to log out?<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Log out" Width="96px" />
    </h1>
    
 </asp:Content>

