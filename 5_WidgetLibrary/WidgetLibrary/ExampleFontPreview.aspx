<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ExampleFontPreview.aspx.cs" Inherits="WidgetLibrary.ExampleFontPreview" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    
    <h1>Widget Library</h1>

<h2>Font Preview Documentation</h2>

<p>
   This control changes the font based off the item selected
</p>

<h3>Available Properties</h3>
<ul>
    
   <li>`DropDownList`: A dropdown menu that provides a list of fonts to chose from</li>
   
</ul>

<h3>Examples</h3>

<%--<pre>&lt;wl:rendertime runat="server" /&gt;</pre>--%>

<!-- This content is being rendered by an instance of the RenderTime user control -->
<form id="form1" runat="server">
        <div>
             <uc:FontD runat ="server" />
        </div>
    </form>

<%--<pre>&lt; /&gt;</pre>--%>

<!-- This content is being rendered by an instance of the RenderTime user control -->

<p>
   <a href="Default.aspx">Return to Home</a>
</p>

</body>
</html>
