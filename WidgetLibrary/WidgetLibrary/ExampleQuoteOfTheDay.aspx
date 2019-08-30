<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ExampleQuoteOfTheDay.aspx.cs" Inherits="WidgetLibrary.ExampleQuoteOfTheDay" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
   
    <h1>Widget Library</h1>

<h2>Quote Of The Day Control Documentation</h2>

<p>
   This control reaches out to an API displays the quote of the day and then generates a random quote based off each button click
</p>

<h3>Available Properties</h3>
<ul>
    
  
   <li>`Button`: A button that calls GetRandomQuote method to generate a random quote</li>
</ul>

<h3>Examples</h3>

<pre>&lt;uc:QuoteOfTheDay runat="server" /&gt;</pre>

<!-- This content is being rendered by an instance of the RenderTime user control -->
<div>
   
</div>

     <form id="form1" runat="server">
        <div>
               <uc:QuoteOfTheDay Randomize ="true" runat ="server" />
        </div>
    </form>

<!-- This content is being rendered by an instance of the RenderTime user control -->

<p>
   <a href="Default.aspx">Return to Home</a>
</p>

</body>
</html>