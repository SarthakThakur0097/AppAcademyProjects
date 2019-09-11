<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LibraryList.aspx.cs" Inherits="Library.LibraryList" %>

<%@ import namespace="System.Data" %>
<asp:Content ID="Content5" ContentPlaceHolderID="main" runat="server">
    <h2>Libraries</h2>

        <div>
            <asp:hyperlink runat="server" navigateurl="~/AddLibrary.aspx">Add A New Library</asp:hyperlink>
        </div>

        <asp:repeater id="Libraries" runat="server" itemtype="DataRow">
            <headertemplate>
                <table class="table table-sm table-striped table-hover">
                    <tr>
                        <th>StateName</th>
                       
                        <th>&nbsp;</th>
                    </tr>
            </headertemplate>
            <itemtemplate>
                <tr>
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

