<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditServiceLineForServiceManager.aspx.cs" Inherits="NHUB.EditServiceLineForServiceManager" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
                   <script type="text/javascript"src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
    <link href="http://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/3.0.3/css/bootstrap.min.css"
          rel="stylesheet" type="text/css"/>
    <script type="text/javascript" src="http://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/3.0.3/js/bootstrap.min.js"></script>
    <link href="http://cdn.rawgit.com/davidstutz/bootstrap-multiselect/master/dist/css/bootstrap-multiselect.css" rel="stylesheet" type="text/css"/>
    <script src="http://cdn.rawgit.com/davidstutz/bootstrap-multiselect/master/dist/js/bootstrap-multiselect.js" type="text/javascript"></script>
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

                                                       <script type="text/javascript">
                                 $(function () {
            $('#EditServiceLineListBoxForServiceManager').multiselect({
                includeSelectAllOption: true
            });
        });
    </script> 
                     
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
        <asp:Button ID="CancelButtonForServiceManager" runat="server" Text="Cancel" OnClick="CancelButtonForServiceManager_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="UpdateButtonForServiceManager" runat="server" Text="Update" OnClick="UpdateButtonForServiceManager_Click" />
    </form>
</body>
</html>
