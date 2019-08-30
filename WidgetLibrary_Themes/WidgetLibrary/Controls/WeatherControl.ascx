<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WeatherControl.ascx.cs" Inherits="WidgetLibrary.Controls.WeatherControl" %>

<div>
    <asp:Label ID ="errorMessage" runat ="server"></asp:Label>
  
</div>
<div>
    <asp:TextBox ID ="zipInput" runat ="server"></asp:TextBox>
    <asp:Button ID ="zipButton" Text ="Check" runat ="server" OnClick = "zipButton_Click" />
    <asp:RequiredFieldValidator runat ="server"
        controltovalidate ="zipInput"
        display ="Dynamic"
        errormessage="Please enter in a zip code"
        enableclientscript ="true">
        
    </asp:RequiredFieldValidator>

    <asp:RangeValidator runat ="server"
        controltovalidate ="zipInput"
        display ="Dynamic"
        type ="Integer"
        enableclientscript ="true"
        minimumvalue ="10000"
        maximumvalue ="99999"
        errormessage ="Please provide a valid zip code"></asp:RangeValidator>
</div>

<div>
    <asp:Label id ="temp" Text ="Temperature: "  runat ="server" />

</div>

<div>
    <asp:Label id = "temp_min" Text ="Temp Min: " runat ="server" />

</div>
<div>
<asp:Label id ="temp_max" Text ="Temp Max: " runat ="server" />

</div>
<div>
    <asp:Label id ="pressure" Text ="Pressure: " runat ="server" />

</div>
<div>
    <asp:Label id ="humidity" Text ="Humidity: " runat ="server" />

</div>
<div>

<asp:Label id ="wind_speed" runat ="server" />

</div>
