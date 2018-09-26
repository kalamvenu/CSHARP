<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="September24_2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
       
    <div class="jumbotron">
        <h1>E Commerce  
        </h1>
         <div class="col-md-4">

 
            <a runat="server" href="~/About">Product Management page</a>
           
        </div>
        <div class="col-md-4">
           
            <p>
                <a runat="server" href="~/Contact">Order Management page</a></p>
            <p>
                &nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Search" />
            </p>
           
        </div>
    </div>
   
 
         </div>
                <asp:PlaceHolder ID="PlaceHolder1" runat="server">

                       <div class="row">

      
                    <asp:PlaceHolder ID="PlaceHolder2" runat="server"></asp:PlaceHolder>
                             </div>

   <%-- <asp:Image ID="Image1" runat="server" style="width: 113px; height: 87px"/><br />
    <asp:HyperLink ID="HyperLink1" runat="server" Text="Name"/><br />
    <asp:label runat="server" ID="label1">Price</asp:label> --%>


    </asp:PlaceHolder>


        
   

</asp:Content>
