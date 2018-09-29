<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ServiceLines.aspx.cs" Inherits="NHUB.ServiceLines" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            <asp:Label ID="ServiceLinesLabel" runat="server" Text="Service Lines :"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:PlaceHolder ID="ServiceLinesPlaceHolder" runat="server"></asp:PlaceHolder>
            
      <asp:Button ID="AddServiceLine" runat="server" Text="Add Service Line" OnClick="AddServiceLine_Click" />
            
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
