<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TicTacToeBoard.ascx.cs" Inherits="UglyTicTacToe.Controls.TicTacToeBoard" %>


<asp:Label ID ="PlayerTurnDisplay" CssClass ="playerDisplay" Text =" " runat ="server"></asp:Label>
<asp:Button ID ="reset" CssClass ="resetButt" Text = "New Game" runat="server" OnClick ="reset_Click" />
<asp:Panel ID ="AllButtons" runat ="server">
<div>
    <asp:Button id ="rc00" Text =" " runat="server" OnClick ="rc00_Click" />
    <asp:Button id ="rc01" Text =" " runat="server" OnClick ="rc01_Click"  />
    <asp:Button id ="rc02" Text =" " runat="server" OnClick ="rc02_Click" />
</div>

<div>
    <asp:Button id ="rc10" Text =" " runat="server" OnClick ="rc10_Click" />
    <asp:Button id ="rc11" CssClass="testing" Text =" " runat="server" OnClick ="rc11_Click"  />
    <asp:Button id ="rc12" Text =" " runat="server" OnClick ="rc12_Click"  />
</div>

<div>
    <asp:Button id ="rc20" Text =" " runat="server" OnClick ="rc20_Click" />
    <asp:Button id ="rc21" Text =" " runat="server" OnClick ="rc21_Click"  />
    <asp:Button id ="rc22" Text =" " runat="server" OnClick ="rc22_Click" />
</div>
    </asp:Panel>
<asp:Label ID ="TestBox" Text ="" runat ="server"></asp:Label>





