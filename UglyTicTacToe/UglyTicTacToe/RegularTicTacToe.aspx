<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegularTicTacToe.aspx.cs" Inherits="UglyTicTacToe.RegularTicTacToe" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

        <link href="Styles/Main.css" rel="stylesheet" />

    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <uc:CreateBoard runat ="server" />
        </div>
    </form>
</body>
</html>
