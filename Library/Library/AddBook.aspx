<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddBook.aspx.cs" Inherits="Library.AddBook" %>

<asp:Content ID="Content3" ContentPlaceHolderID="main" runat="server">
   
    <div>
         <asp:DropDownList ID="AuthorListChose" runat="server" AppendDataBoundItems ="True" AutoPostBack="True" DataSourceID="AuthorListDataSource" DataTextField="FirstName" DataValueField="Id">
    <asp:ListItem>Select an author</asp:ListItem>
    </asp:DropDownList>
    <asp:SqlDataSource ID="AuthorListDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:Library %>" SelectCommand="SELECT [FirstName], [Id], [LastName] FROM [Author]"></asp:SqlDataSource>

         <asp:DropDownList ID="LibraryList" runat="server" AppendDataBoundItems ="True" AutoPostBack="True" DataSourceID="LibraryListDataSource" DataTextField="LocationName" DataValueField="Id">
    <asp:ListItem>Select a library</asp:ListItem>
    </asp:DropDownList>
    <asp:SqlDataSource ID="LibraryListDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:Library %>" SelectCommand="SELECT [Id], [LocationName] FROM [Library]"></asp:SqlDataSource>


    </div>
   
     <fieldset>
        <div>
            <asp:label id="BookTitleLabel" runat="server"  text="Book Title: " />
            <asp:textbox id="BookTitle" runat="server" />
        </div>
        <div>
            <asp:label id="ISBNLabel" runat="server"  text="ISBN: " />
            <asp:textbox id="ISBNGet" runat="server" />
        </div>

        <div>
           
        </div>
    </fieldset>
    <div>
        <asp:button id="Save" runat="server" text="Save" OnClick ="SaveItem" />
    </div>

</asp:Content>
