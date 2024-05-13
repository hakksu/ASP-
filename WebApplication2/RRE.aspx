<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RRE.aspx.cs" Inherits="WebApplication2.RRE" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br>
    <h1>回應留言</h1>
        <p>
            暱稱<asp:TextBox ID="Reply_Name" runat="server" ></asp:TextBox>
        </p>
        內容</p>
    <asp:TextBox ID="Reply_Main" runat="server" Height="301px" TextMode="MultiLine" Width="100%"></asp:TextBox>
        <br />
        <asp:Button ID="pass" runat="server" Text="確定回應" OnClick="pass_Click"/>
        <asp:Label ID="Message" runat="server" ForeColor="red" Text=""></asp:Label>
</asp:Content>
