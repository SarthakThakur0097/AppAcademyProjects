<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TicTacToeBoardAI.ascx.cs" Inherits="UglyTicTacToe.Controls.TicTacToeBoardAI" %>
<asp:Label ID ="GameID" Text ="AI Game" runat ="server"></asp:Label>
<asp:Label ID ="PlayerTurnDisplay" Text =" " runat ="server"></asp:Label>
<asp:Panel ID ="AllButtons" runat ="server">

<asp:Button ID ="reset" Text = "New Game" runat="server" OnClick ="reset_Click" />
<div>
    <asp:Button id ="rc00" Text =" " runat="server" OnClick ="rc00_Click" />
    <asp:Button id ="rc01" Text =" " runat="server" OnClick ="rc01_Click"  />
    <asp:Button id ="rc02" Text =" " runat="server" OnClick ="rc02_Click" />
</div>

<div>
    <asp:Button id ="rc10" Text =" " runat="server" OnClick ="rc10_Click" />
    <asp:Button id ="rc11" CssClass="" Text =" " runat="server" OnClick ="rc11_Click"  />
    <asp:Button id ="rc12" Text =" " runat="server" OnClick ="rc12_Click"  />
</div>

<div>
    <asp:Button id ="rc20" Text =" " runat="server" OnClick ="rc20_Click" />
    <asp:Button id ="rc21" Text =" " runat="server" OnClick ="rc21_Click"  />
    <asp:Button id ="rc22" Text =" " runat="server" OnClick ="rc22_Click" />
</div>
    </asp:Panel>
<asp:Label ID ="TestBox" Text ="" runat ="server"></asp:Label>


