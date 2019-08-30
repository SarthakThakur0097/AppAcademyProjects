<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AITicTacToe.aspx.cs" Inherits="UglyTicTacToe.AITicTacToe" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Styles/Main.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <uc:CreateBoardai runat ="server" />
        </div>
    </form>
</body>
</html>
