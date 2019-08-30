<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ExampleCounter.aspx.cs" Inherits="WidgetLibrary.ExampleCounter" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    
    <h1>Widget Library</h1>

<h2>Counter Widget Documentation</h2>

<p>
   This control simply displays the time that the current
   page was rendered at.
</p>

<h3>Available Properties</h3>
<ul>
   <li>`Button`: Increase button to increase the number of clicks</li>
   <li>`Button`: Decrease button to decrease the nubmer of clicks</li>
</ul>

<h3>Examples</h3>

<pre>&lt;uc:counterD runat="server" /&gt;</pre>

<!-- This content is being rendered by an instance of the RenderTime user control -->
<div>
      
</div>

    <form id="form1" runat="server">
        <div>
            <uc:counterD runat ="server" />
        </div>
    </form>

<!-- This content is being rendered by an instance of the RenderTime user control -->

<p>
   <a href="Default.aspx">Return to Home</a>
</p>

</body>
</html>
