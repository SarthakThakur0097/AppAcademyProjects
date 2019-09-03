<%@ page title="" language="c#" masterpagefile="~/site.master" autoeventwireup="true" codebehind="addstate.aspx.cs" inherits="Library.AddState" %>

<asp:content id="content4" contentplaceholderid="main" runat="server">
    <h2>add state</h2>

    <fieldset>
        <div>
            <asp:label id="statelabel" runat="server"  text="state name: " />
            <asp:textbox id="stateinput" runat="server" />
        </div>
        <div>
           
        </div>
    </fieldset>

    <div>
        <asp:button id="save" runat="server" text="save" onclick="SaveState" />
    </div>


</asp:content>
