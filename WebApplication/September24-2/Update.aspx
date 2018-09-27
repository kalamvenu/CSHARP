<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Update.aspx.cs" Inherits="September24_2.Update" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           

            <asp:TextBox ID="NameTextBox" runat="server">Name</asp:TextBox><br />
            <asp:TextBox ID="PriceTextBox" runat="server">Price</asp:TextBox><br />
            <asp:TextBox ID="URLTextBox" runat="server">URL</asp:TextBox><br />
            <asp:TextBox ID="DescriptionTextBox" runat="server">Description</asp:TextBox><br />
            <asp:DropDownList ID="DropDownListforBrands" runat="server"></asp:DropDownList>

            <asp:Button ID="Updatebtn" runat="server" Text="Update" onclick="Button1_Click" />

             <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
