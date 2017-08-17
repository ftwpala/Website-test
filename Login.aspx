<%@ Page Title="" Language="C#" MasterPageFile="~/MainPage.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebsiteTest.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="LoginBar" runat="server">
    <asp:Login ID="Login1" runat="server"  TitleText="<h3>Sign In</h3>" DestinationPageUrl="Default.aspx" OnAuthenticate="Login1_Authenticate">
    </asp:Login>
</asp:Content>


