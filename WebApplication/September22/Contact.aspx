<%@ Page Title="Order Management" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="September22.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
     <% if (Context.User.IsInRole("Order"))
                            {%>

    <h2><%: Title %>.</h2>
    <h3>Order Management page.</h3>
    <address>
        Orders<br />
        <br />
        <abbr title="Order">P:</abbr>
        Orders
    </address>

    <address>
        <strong>Google</strong>   <a href="https://www.google.com">www.google.com</a><br />
        <strong>Microsoft</strong> <a href="https://www.google.com">www.microsoft.com</a>
    </address>

     <%}%>

    <% else{%>

     <h3>Your are not allowed to access this page.</h3>
     <%}%>
</asp:Content>
