 <%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ExampleQuoteOfTheDay.aspx.cs" Inherits="WidgetLibrary.ExampleQuoteOfTheDay" %>

<asp:Content ContentPlaceHolderID ="MainContent" runat ="server">
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

     
        <div>
               <uc:QuoteOfTheDay Randomize ="true" runat ="server" />
        </div>
  

<!-- This content is being rendered by an instance of the RenderTime user control -->

<p>
   <a href="Default.aspx">Return to Home</a>
</p>

    </asp:Content>