<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BookCopies.aspx.cs" Inherits="Library.BookCopies" %>
<%@ import namespace="System.Data" %>
<asp:Content ID="Content1" ContentPlaceHolderID="main" runat="server">
    <asp:repeater id="Books" runat="server" itemtype="DataRow">
            <headertemplate>
                <table>
                    <tr>
                        <th>Title</th>
                        <th>LibraryId</th>
                        <th>Library Name</th>
                        
                        <th>&nbsp;</th>
                    </tr>
            </headertemplate>
            <itemtemplate>
                <tr>
                    <td><%# Item.Field<string>("title") %></td>
                    <td><%# Item.Field<int>("LibraryId") %></td>
                    <td><%# Item.Field<string>("LocationName") %></td>
                    
                    <%--<td><%# Item.Field<string>("LastName") %></td>--%>
                    <%--<td><asp:hyperlink runat="server" navigateurl='<%# $"~/AuthorEdit.aspx?ID={Item.Field<int>("AuthorId")}" %>' text="Edit" /></td>--%>
                </tr>
            </itemtemplate>
            <footertemplate>
                </table>
            </footertemplate>
        </asp:repeater>
</asp:Content>
