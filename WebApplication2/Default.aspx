<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        Username: <asp:TextBox ID="username" runat="server"></asp:TextBox>
        Password: <asp:TextBox ID="password" runat="server"></asp:TextBox>

        <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click"/>
    </main>

</asp:Content>
