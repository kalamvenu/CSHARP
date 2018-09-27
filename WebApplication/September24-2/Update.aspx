<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Update.aspx.cs" Inherits="September24_2.Update" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           

            <asp:TextBox ID="TextBox1" runat="server">Name</asp:TextBox><br />
            <asp:TextBox ID="TextBox2" runat="server">Price</asp:TextBox><br />
            <asp:TextBox ID="TextBox3" runat="server">URL</asp:TextBox><br />
            <asp:TextBox ID="TextBox4" runat="server">Description</asp:TextBox><br />
            <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>

            <asp:Button ID="Button1" runat="server" Text="Button" onclick="Button1_Click" />

            <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
             <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
