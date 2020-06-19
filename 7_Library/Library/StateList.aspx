<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="StateList.aspx.cs" Inherits="Library.StateList" %>

<%@ import namespace="System.Data" %>
<asp:Content ID="Content5" ContentPlaceHolderID="main" runat="server">
    <h2>States</h2>

        <div>
            <asp:hyperlink runat="server" navigateurl="~/AddState.aspx">Add A New State</asp:hyperlink>
        </div>

        <asp:repeater id="States" runat="server" itemtype="DataRow">
            <headertemplate>
                <table>
                    <tr>
                        <th>StateName</th>
                       
                        <th>&nbsp;</th>
                    </tr>
            </headertemplate>
            <itemtemplate>
                <tr>
                    <td><%# Item.Field<string>("name") %></td>
                 
                    
                    <%--<td><%# Item.Field<string>("LastName") %></td>--%>
                    <%--<td><asp:hyperlink runat="server" navigateurl='<%# $"~/AuthorEdit.aspx?ID={Item.Field<int>("AuthorId")}" %>' text="Edit" /></td>--%>
                </tr>
            </itemtemplate>
            <footertemplate>
                </table>
            </footertemplate>
        </asp:repeater>

    </asp:Content>

