<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="gamereport.aspx.cs" Inherits="WebApplication2.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p></p><br>
    <h2>恭喜</h2>
    <br>
    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    <br>
    輸入你想留的暱稱<br>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br>感言<br>
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <br>
    <asp:Button ID="Button2" runat="server" Text="留名" OnClick="Button2_Click" />
    <br>
</asp:Content>
