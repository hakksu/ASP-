<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RE.aspx.cs" Inherits="WebApplication2.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <div>
        </div>
        <p>
        </p>
        </p>
         <br/>
        <asp:Label ID="Label2" runat="server" Text="標題"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" required="" aria-required="true" oninput="setCustomValidity('');" oninvalid="setCustomValidity('未填入標題')"></asp:TextBox>
        </p>
        <asp:Label ID="Label1" runat="server" Text="暱稱" ></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" required="" aria-required="true" oninput="setCustomValidity('');" oninvalid="setCustomValidity('未填入暱稱')" ></asp:TextBox>
        </p>
        <asp:Label ID="Label3" runat="server" Text="內容"></asp:Label><br/>
        <asp:TextBox ID="TextBox3" runat="server" Height="377px" TextMode="MultiLine" Width="100%" required="" aria-required="true" oninput="setCustomValidity('');" oninvalid="setCustomValidity('未填入內容')"></asp:TextBox>
        </p>
        <br/>
        <asp:Button ID="Button1" runat="server" Text="發文" OnClick="Button1_Click" />
        

</asp:Content>
