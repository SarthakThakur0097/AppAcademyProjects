<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddLibrary.aspx.cs" Inherits="Library.AddLibrary" %>

<asp:Content ID="Content5" ContentPlaceHolderID="main" runat="server">
     <h2>Add Library</h2>

    <fieldset>
        <div>
            <asp:label id="LibNameLabel" runat="server"  text="Name: " />
            <asp:textbox id="LibName" runat="server" />
        </div>
        <div>
            <asp:label id="AddressLabel" runat="server"  text="Address: " />
            <asp:textbox id="AddressInput" runat="server" />
        </div>

        <div>
           <asp:label id="City" runat="server"  text="City: " />
            <asp:textbox id="CityInput" runat="server" />
        </div>
       
        <div>
              <asp:DropDownList ID="StateList" runat="server" AppendDataBoundItems ="True" AutoPostBack="True" DataSourceID="AuthorListDataSource" DataTextField="Name" DataValueField="Id">
    <asp:ListItem>Select your state</asp:ListItem>
    </asp:DropDownList>
    <asp:SqlDataSource ID="AuthorListDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:Library %>" SelectCommand="SELECT [Id], [Name] FROM [State]"></asp:SqlDataSource>
       
        </div>
        
        <div>
           <asp:label id="PostCode" runat="server"  text="ZipCode: " />
            <asp:textbox id="ZipCodeInput" runat="server" />
        </div>

       
    </fieldset>

    <div>
        <asp:button id="Save" runat="server" text="Save" OnClick="Add_Library" />
    </div>

</asp:Content>
