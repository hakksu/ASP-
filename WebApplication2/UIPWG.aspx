<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UIPWG.aspx.cs" Inherits="WebApplication2.UIPWG" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <p></p><br>

     <asp:Label ID="Label3" runat="server" Height="26px" Width="55px"></asp:Label>
     <asp:Button ID="Button2" runat="server" Text="產生密碼" OnClick="Button2_Click" />

     <asp:Label ID="Label4" runat="server" Height="25px" Width="226px"></asp:Label>

    <br>
    <asp:Label ID="Label1" runat="server" Text="請輸入數字"></asp:Label>
    <br>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" Text="答題" OnClick="Button1_Click" />
    <br>
    <asp:Label ID="min" runat="server" ForeColor="red" Text=""></asp:Label>
    <asp:Label ID="Label6" runat="server" ForeColor="red" Text=""></asp:Label>
    <asp:Label ID="max" runat="server" ForeColor="red" Text=""></asp:Label>
     &nbsp;&nbsp;&nbsp;<asp:Label ID="Label2" runat="server" ForeColor="red" Text=""></asp:Label>
     <asp:Label ID="Label5" runat="server" Height="1px" Text="0" Width="1px" Font-Size="1pt"></asp:Label>
</asp:Content>
