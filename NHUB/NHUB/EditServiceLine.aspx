<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditServiceLine.aspx.cs" Inherits="NHUB.EditServiceLine" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <asp:Label ID="EditServiceLineLabel" runat="server" Text="Edit Service Line"></asp:Label>
            <br />
            <br />
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">Name :</td>
                    <td>
                        <asp:TextBox ID="EditServiceLineTextBox" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Owners :</td>
                    <td>


                       
                        <asp:ListBox ID="EditServiceLineListBox" runat="server" SelectionMode="Multiple"></asp:ListBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                </tr>
            </table>
        </div>
        <asp:Button ID="CancelButton" runat="server" Text="Cancel" />
        <asp:Button ID="UpdateButton" runat="server" Text="Update" />
    </form>
</body>
</html>
