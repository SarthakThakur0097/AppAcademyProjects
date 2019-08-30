<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BookList.aspx.cs" Inherits="Library.BookList" %>
<%@ import namespace="System.Data" %>

<asp:Content ID="Content3" ContentPlaceHolderID="main" runat="server">
    <h2>Books</h2>

        <div>
            <asp:hyperlink runat="server" navigateurl="~/AddBook.aspx">Add New Book</asp:hyperlink>
        </div>

        <asp:repeater id="Books" runat="server" itemtype="DataRow">
            <headertemplate>
                <table>
                    <tr>
                        <th>Book Title</th>
                        <th>Author Name</th>
                        <th>&nbsp;</th>
                    </tr>
            </headertemplate>
            <itemtemplate>
                <tr>
                    <td><%# Item.Field<string>("title") %></td>
                    <td><%# Item.Field<string>("FirstName") %></td>
                    <td><%# Item.Field<string>("LastName") %></td>
                    
                    <%--<td><%# Item.Field<string>("LastName") %></td>--%>
                    <%--<td><asp:hyperlink runat="server" navigateurl='<%# $"~/AuthorEdit.aspx?ID={Item.Field<int>("AuthorId")}" %>' text="Edit" /></td>--%>
                </tr>
            </itemtemplate>
            <footertemplate>
                </table>
            </footertemplate>
        </asp:repeater>
</asp:Content>
