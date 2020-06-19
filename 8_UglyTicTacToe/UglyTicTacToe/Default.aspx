<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="UglyTicTacToe.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Styles/Main.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
<%--            <uc:CreateBoard runat ="server" />--%>
            <a href="~/RegularTicTacToe.aspx" runat ="server">Regular Game</a>
            <a href="~/AiTicTacToe.aspx" runat ="server">AI Game</a>
        </div>
    </form>
</body>
</html>
