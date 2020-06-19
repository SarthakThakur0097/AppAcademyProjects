<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Counter.ascx.cs" Inherits="WidgetLibrary.Controls.Counter" %>
<asp:Label id = "Clicks" runat="server" />
<asp:Button id ="Increase" Text ="+" runat="server" OnClick ="Increase_Click" />
<asp:Button id ="Decrease" Text ="-" runat ="server" OnClick ="Decrease_Click" />
