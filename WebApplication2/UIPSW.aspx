<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UIPSW.aspx.cs" Inherits="WebApplication2.UIPSW" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p></p>
    <br>

    <h1>請輸入最大值(範圍為0~最大值)</h1>
    <br>

    <asp:TextBox ID="range" runat="server" required="" aria-required="true" oninput="setCustomValidity('');" oninvalid="setCustomValidity('未填入範圍')"></asp:TextBox>
    <br>

    <asp:Button ID="Button2" runat="server" Text="開始遊戲" OnClick="Button2_Click" />
     <asp:Label ID="Label2" runat="server" ForeColor="red" Text=""></asp:Label>

    <br>
</asp:Content>
