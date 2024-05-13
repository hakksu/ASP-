<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Leaderboard.aspx.cs" Inherits="WebApplication2.Leaderboard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <p></p>
    <br />
    
    <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
             <p/> 
               <asp:Label ID="who" runat="server" Text='<%# Bind("name") %>'></asp:Label>花了<asp:Label  ID ="Label3" runat="server" Text='<%# Bind("s") %>'></asp:Label>次破解了範圍為0~
              <asp:Label  ID ="Label4" runat="server" Text='<%# Bind("range") %>'></asp:Label>的密碼
              <br />
              <asp:Label  ID ="repmain" runat="server" Text='<%# Bind("main") %>'></asp:Label>
             <p/>
            </ItemTemplate>
     </asp:Repeater>

     <br/>

</asp:Content>
