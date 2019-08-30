<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LibrarianList.aspx.cs" Inherits="Library.LibrarianList" %>

<%@ import namespace="System.Data" %>
<asp:Content ID="Content5" ContentPlaceHolderID="main" runat="server">
    <h2>Libraries</h2>

        <div>
            <asp:hyperlink runat="server" navigateurl="~/AddLibrary.aspx">Add A New Library</asp:hyperlink>
        </div>

        <asp:repeater id="Librarians" runat="server" itemtype="DataRow">
            <headertemplate>
                <table>
                    <tr>
                        <th>Name</th>
                       
                        <th>&nbsp;</th>
                    </tr>
            </headertemplate>
            <itemtemplate>
                <tr>
                    <td><%# Item.Field<string>("FirstName") %></td>
                 
                    
                    <%--<td><%# Item.Field<string>("LastName") %></td>--%>
                    <%--<td><asp:hyperlink runat="server" navigateurl='<%# $"~/AuthorEdit.aspx?ID={Item.Field<int>("AuthorId")}" %>' text="Edit" /></td>--%>
                </tr>
            </itemtemplate>
            <footertemplate>
                </table>
            </footertemplate>
        </asp:repeater>

    </asp:Content>

