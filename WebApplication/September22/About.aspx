<%@ Page Title="Product Management" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="September22.About" %>





<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

     <% if (Context.User.IsInRole("Product")){%>
    <h2><%: Title %>.</h2>
    <h3>Your Product Management page.</h3>
    <p>Use this area to provide Product Management information.</p>

     <%}%>
     <% else{%>

     <h3>Your are not allowed to access this page.</h3>
     <%}%>
</asp:Content>

