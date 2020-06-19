<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddPatron.aspx.cs" Inherits="Library.AddPatron" %>
<asp:Content ID="Content7" ContentPlaceHolderID="main" runat="server">
   <h2>Add Patron</h2>

    <fieldset>
        <div>
            <asp:label id="FirstNameLabel" runat="server"  text="First Name: " />
            <asp:textbox id="FirstNameInput" runat="server" />
        </div>

        <div>
            <asp:label id="LastNameLabel" runat="server" text="Last Name: " />
            <asp:textbox id="LastNameInput" runat="server" />
        </div>

        <div>   
            <asp:label id="EmailAddress" runat="server" text="Email Address: " />
            <asp:textbox id="emailInput" runat="server" />
        </div>

        <div>   
            <asp:label id="StreetAddress" runat="server" text=" Street Address: " />
            <asp:textbox id="AddressInput" runat="server" />
        </div>

         <div>
            <asp:label id="City" runat="server" text="City: " />
            <asp:textbox id="CityInput" runat="server" />
        </div>
        <div>   
            <asp:label id="ZipCode" runat="server" text="Zip Code: " />
            <asp:textbox id="ZipInput" runat="server" />
        </div>

        <div>
              <asp:DropDownList ID="StateList" runat="server" AppendDataBoundItems ="True" AutoPostBack="True" DataSourceID="StateListDataSource" DataTextField="Name" DataValueField="Id">
    <asp:ListItem>Select a state</asp:ListItem>
    </asp:DropDownList>
    <asp:SqlDataSource ID="StateListDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:Library %>" SelectCommand="SELECT [Id], [Name] FROM [State]"></asp:SqlDataSource>
        </div>
    </fieldset>

    <div>
        <asp:button id="Save" runat="server" text="Save" onclick="SavePatron" />
    </div>

</asp:Content>
