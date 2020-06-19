<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="FontPreview.ascx.cs" Inherits="WidgetLibrary.Controls.FontPreview" %>
<asp:DropDownList ID ="Fonts" runat ="server" AutoPostBack ="true" OnSelectedIndexChanged ="Fonts_SelectedIndexChanged" >
    
  

    <asp:ListItem Value ="Arial">Arial</asp:ListItem>
    <asp:ListItem Value ="Helvetica">Helvetica</asp:ListItem>
    <asp:ListItem Value ="Times New Roman">Times New Roman</asp:ListItem>
    <asp:ListItem Value ="Courier">Courier</asp:ListItem>
    <asp:ListItem Value ="Verdana">Verdana</asp:ListItem>
    <asp:ListItem Value ="Georgia">Georgia</asp:ListItem>
    <asp:ListItem Value ="Palatino">Palatino</asp:ListItem>
    <asp:ListItem Value ="Garamond">Garamond</asp:ListItem>
    <asp:ListItem Value ="Bookman">Bookman</asp:ListItem>
    <asp:ListItem Value ="Comic Sans MS">Comic Sans MS</asp:ListItem>
    <asp:ListItem Value ="Trebuchet MS">Trebuchet MS</asp:ListItem>
    <asp:ListItem Value ="Arial Black">Arial Black</asp:ListItem>
    <asp:ListItem Value ="Impact">Impact</asp:ListItem>
    
</asp:DropDownList>

 <asp:Label id ="textIpsum" runat ="server">
   
       Lorem ipsum dolor sit amet, consectetur adipiscing elit.
Nullam vulputate, nisl ut volutpat pulvinar, mi lectus
malesuada arcu, eu scelerisque tortor elit eu augue.
Nullam in nibh eleifend, fringilla enim id, consectetur
dolor. Pellentesque habitant morbi tristique senectus et
netus et malesuada fames ac turpis egestas. Fusce eleifend
sit amet justo nec euismod. Sed pharetra laoreet dolor.
Cras auctor molestie quam, sed pulvinar ligula malesuada
tincidunt. Suspendisse euismod tincidunt justo, a faucibus
nisi commodo eu. Vestibulum tempus vehicula diam mattis
convallis. Cras a velit et lacus pulvinar varius vel eget
magna. Donec nisl magna, interdum non sem nec, viverra
lobortis velit. Aenean faucibus quam vel ante congue dictum.
Mauris vel metus lorem. Curabitur mattis nisi ut convallis
vehicula. Donec mollis bibendum luctus. Class aptent taciti
sociosqu ad litora torquent per conubia nostra, per
inceptos himenaeos.
 </asp:Label>