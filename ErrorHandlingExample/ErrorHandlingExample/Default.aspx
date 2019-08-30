<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ErrorHandlingExample._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:TextBox ID ="Number1" runat ="server"></asp:TextBox>
    <asp:TextBox ID ="Number2" runat ="server"></asp:TextBox>
    <asp:Button ID ="Sum" runat ="server" Text ="Add" OnClick ="Sum_Click" />
    <asp:Label ID ="Result" runat ="server"></asp:Label>

    <asp:HyperLink NavigateUrl ="~/Default.aspx" runat ="server" Text ="Clear"></asp:HyperLink>


</asp:Content>
