<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddLibrarian.aspx.cs" Inherits="Library.AddLibrarian" %>
<asp:Content ID="Content1" ContentPlaceHolderID="main" runat="server">
    <h2>Add Librarian</h2>

    <fieldset>

        <div>
         <asp:DropDownList ID="LibraryList" runat="server" AppendDataBoundItems ="True" AutoPostBack="True" DataSourceID="LibraryListDataSource" DataTextField="LocationName" DataValueField="Id">
    <asp:ListItem>Select a Library</asp:ListItem>
    </asp:DropDownList>
    <asp:SqlDataSource ID="LibraryListDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:Library %>" SelectCommand="SELECT [Id], [LocationName] FROM [Library]"></asp:SqlDataSource>

    <asp:SqlDataSource ID="StateListDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:Library %>" SelectCommand="SELECT [Id], [Name] FROM [State]"></asp:SqlDataSource>
    
         <asp:DropDownList ID="PatronList" runat="server" AppendDataBoundItems ="True" AutoPostBack="True" DataSourceID="PatronDataSource" DataTextField="FirstName" DataValueField="LibraryCardId">
    <asp:ListItem>Select a Patron</asp:ListItem>
    </asp:DropDownList>
    <asp:SqlDataSource ID="PatronDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:Library %>" SelectCommand="SELECT [FirstName], [LibraryCardId], [LastName], [AddressLine1], [ZipCode], [City] FROM [Patron]"></asp:SqlDataSource>
    

            <div>
                <asp:Label id ="Password" Text ="Password" runat="server"></asp:Label>
                <asp:TextBox ID ="PasswordInput" runat ="server"></asp:TextBox>
            </div>
      
             
     
        
        </div>
       
        


       
    </fieldset>
    <div>
        <asp:button id="Save" runat="server" text="Save" onclick="SaveLibrarian" />
    </div>


</asp:Content>
