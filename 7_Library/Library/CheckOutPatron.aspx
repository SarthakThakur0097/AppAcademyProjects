<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CheckOutPatron.aspx.cs" Inherits="Library.CheckOutPatron" %>
<asp:Content ID="Content1" ContentPlaceHolderID="main" runat="server">

<h2>Checkout</h2>

    <fieldset>
        <div>
        <asp:DropDownList ID="BookList" runat="server" AppendDataBoundItems ="True" AutoPostBack="True" DataSourceID="BookListDataSource" DataTextField="Title" DataValueField="Id">
    <asp:ListItem>Select a book</asp:ListItem>
    </asp:DropDownList>
    <asp:SqlDataSource ID="BookListDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:Library %>" SelectCommand="SELECT [ItemCopy].Id, [ItemCopy].ItemId, [Item].Title  
FROM [Item] JOIN  ItemCopy ON ItemCopy.ItemId = Item.Id
     "></asp:SqlDataSource>
        </div>

        <div>
        <asp:DropDownList ID="PatronList" runat="server" AppendDataBoundItems ="True" AutoPostBack="True" DataSourceID="PatronListDataSource" DataTextField="FirstName" DataValueField="LibraryCardId">
            <asp:ListItem>Select a Patron</asp:ListItem>
        </asp:DropDownList>
    <asp:SqlDataSource ID="PatronListDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:Library %>" SelectCommand="SELECT [FirstName], [LastName], [LibraryCardId] FROM [Patron]"></asp:SqlDataSource>
        </div>

        <div>
            <asp:DropDownList ID="LibrarianList" runat="server" AppendDataBoundItems ="True" AutoPostBack="True" DataSourceID="LibrarianDataSource" DataTextField="FirstName" DataValueField="LibraryCardId">
    <asp:ListItem>Select A Librarian</asp:ListItem>
    </asp:DropDownList>
    <asp:SqlDataSource ID="LibrarianDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:Library %>" SelectCommand="SELECT [Patron].FirstName, [Patron].LastName, [Librarian].LibraryCardId  
FROM [Librarian] JOIN  [Patron] ON [Librarian].LibraryCardId = [Patron].LibraryCardId"></asp:SqlDataSource>
        </div>
    </fieldset>

    <div>
        <asp:button id="Save" runat="server" text="Checkout" OnClick ="CheckOut_Book" />
    </div>


</asp:Content>
