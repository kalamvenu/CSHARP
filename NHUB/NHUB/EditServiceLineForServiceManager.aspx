<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditServiceLineForServiceManager.aspx.cs" Inherits="NHUB.EditServiceLineForServiceManager" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <div>
            <br />
            <asp:Label ID="EditServiceLineLabelForServiceManager" runat="server" Text="Edit Service Line"></asp:Label>
            <br />
            <br />
            <table class="auto-style1">
                <tr>
                    <td>Name :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                    <td>
                        &nbsp;<asp:TextBox ID="EditServiceLineTextBoxForServiceManager" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>Operation Managers :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                    <td>


                     
                        <asp:ListBox ID="EditServiceLineListBoxForServiceManager" runat="server" SelectionMode="Multiple"></asp:ListBox>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="CancelButtonForServiceManager" runat="server" Text="Cancel" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="UpdateButtonForServiceManager" runat="server" Text="Update" />
    </form>
</body>
</html>
