<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Update.aspx.cs" Inherits="September24_2.Update" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:TextBox ID="TextBox1" runat="server">Name</asp:TextBox>
            <asp:TextBox ID="TextBox2" runat="server">Price</asp:TextBox>
            <asp:TextBox ID="TextBox3" runat="server">URL</asp:TextBox>
            <asp:TextBox ID="TextBox4" runat="server">Description</asp:TextBox>

            <asp:Button ID="Button1" runat="server" Text="Button" />

            <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
        </div>
    </form>
</body>
</html>
