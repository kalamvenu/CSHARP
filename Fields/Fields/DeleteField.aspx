<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteField.aspx.cs" Inherits="Fields.DeleteField" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="NameLabel" runat="server" Text="Name"></asp:Label>
            <br />
            <br />
        </div>
        <asp:Button ID="DeleteButton" runat="server" OnClick="DeleteButton_Click" Text="Delete" />
        <asp:Button ID="CancelButton" runat="server" OnClick="CancelButton_Click" Text="Cancel" />
    </form>
</body>
</html>
