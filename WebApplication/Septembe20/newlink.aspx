
<%@ Page Title="newlink" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Septembe20.Contact" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your new link.</h3>
    <address>
      new link that just got created
    </address>

    <address>
        <div class="jumbotron">
     
             <p class="lead">
        <strong>google</strong>   <a href="https://www.google.com/">www.google.com</a><br />
        <strong>microsoft</strong> <a href="https://www.bing.com/">www.bing.com</a>
         </p>
            </div>
        
            
            </address>
</asp:Content>
