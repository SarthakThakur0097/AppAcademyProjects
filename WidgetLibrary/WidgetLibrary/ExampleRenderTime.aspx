<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ExampleRenderTime.aspx.cs" Inherits="WidgetLibrary.ExampleRenderTime" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
    <h1>Widget Library</h1>

<h2>Render Time Control Documentation</h2>

<p>
   This control simply displays the time that the current
   page was rendered at.
</p>

<h3>Available Properties</h3>
<ul>
   <li>`Label`: The text that displays what the current render time is.</li>
   <li>`Format`: The date format string to use for the render time.</li>
</ul>

<h3>Examples</h3>

<pre>&lt;wl:rendertime runat="server" /&gt;</pre>

<!-- This content is being rendered by an instance of the RenderTime user control -->
<div>
      <uc:RenderTime runat ="server" />
</div>

<pre>&lt;wl:rendertime label="This is a custom label: " format="MM/dd/yy hh:mm tt" runat="server" /&gt;</pre>

<!-- This content is being rendered by an instance of the RenderTime user control -->

<p>
   <a href="Default.aspx">Return to Home</a>
</p>

</body>
</html>
