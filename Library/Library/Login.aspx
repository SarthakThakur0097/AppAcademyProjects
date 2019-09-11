<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Library.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
  <div>
    <asp:Label
        ID="BadLoginMessage"
        ForeColor="Red"
        Text="Your username and password is wrong."
        Visible="False"
        runat="server" />
  </div>
  <div>
    <label>
      User name:
      <asp:TextBox ID="Username" runat="server" />
    </label>
  </div>
  <div>
    <label>
      Password:
      <asp:TextBox ID="Password" TextMode="Password" runat="server" />
    </label>
  </div>
  <div>
    <asp:Button ID="LoginButton" Text="Login" OnClick="LoginButton_Click" runat="server" />
   
  </div>
</asp:Content>
