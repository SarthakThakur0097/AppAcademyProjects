<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PatronList.aspx.cs" Inherits="Library.PatronList" %>

<%@ import namespace="System.Data" %>
<asp:Content ID="Content5" ContentPlaceHolderID="main" runat="server">
    <h2>Libraries</h2>

        <div>
            <asp:hyperlink runat="server" navigateurl="~/AddPatron.aspx">Add A New Patron</asp:hyperlink>
        </div>

        <asp:repeater id="Patrons" runat="server" itemtype="DataRow">
            <headertemplate>
                <table class="table table-sm table-striped table-hover">
                    <tr>
                        <th>Patrons</th>
                       
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

