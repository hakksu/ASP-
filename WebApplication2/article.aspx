<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="article.aspx.cs" Inherits="WebApplication2.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <p></p>
    <br />
    <br />
    主題:<asp:Label ID="Message_header" runat="server" Text="Label"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;發表時間:<asp:Label ID="Message_Time" runat="server" Text="Label"></asp:Label>
   <br />
    發表人:<asp:Label ID="Message_Name" runat="server" Text="Label"></asp:Label>

   <br />
   內容:<br /><asp:Label ID="Main" runat="server" Text="Label"></asp:Label>
   <p/> 
    
    <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
             <p/> 
             <!--<asp:Label ID="Label1" runat="server" Text=''></asp:Label>樓
              <br />-->
              <asp:Label ID="who" runat="server" Text='<%# Bind("name") %>'></asp:Label>: 
              <br />
              <asp:Label  ID ="repmain" runat="server" Text='<%# Bind("main") %>'></asp:Label>
             <p/>
            </ItemTemplate>
     </asp:Repeater>
     <br/>
    <asp:Button ID="Button2" runat="server" Text="回文" OnClick="Button2_Click" />
</asp:Content>
