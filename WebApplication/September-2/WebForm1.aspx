<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="September_2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
       
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
           
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
         
            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
         
            <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
         
            <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
         
            <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
         
            <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
         
            <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>
         
            <asp:Label ID="Label9" runat="server" Text="Label"></asp:Label>
            
        <asp:Label ID="Label10" runat="server" Text="Label"></asp:Label>
             </div>
         
        <asp:TextBox ID="TextBox1" runat="server" style="width:224px">
            </asp:TextBox>

         <h> Results: </h>
            <span runat="server" id="changed_text" />


         <div>
              <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />

                </div>
    </form>
</body>
</html>
