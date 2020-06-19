<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ExampleWeatherDisplay.aspx.cs" Inherits="WidgetLibrary.ExampleWeatherDisplay" %>



<asp:Content ContentPlaceHolderID ="MainContent" runat ="server">

    <h1>Widget Library</h1>

<h2>Weather Display Control Documentation</h2>

<p>
   This control simply takes the input of a numerical value and connects to an API to retrieve the current weather details corresponding to that Zip-Code
</p>

<h3>Available Properties</h3>
<ul>
   <li>`TextBox`: A textbox that takes in userinput and validates if it is a valid zip-code or not </li>
</ul>

<h3>Examples</h3>

<pre>&lt;uc:WeatherD runat="server" /&gt;</pre>

<!-- This content is being rendered by an instance of the RenderTime user control -->
<div>
   
        <div>
             <uc:WeatherD runat ="server" />

        </div>
   

</div>



<!-- This content is being rendered by an instance of the RenderTime user control -->

<p>
   <a href="Default.aspx">Return to Home</a>
</p>
    </asp:Content>