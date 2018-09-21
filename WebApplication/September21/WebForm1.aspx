<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="September21.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 344px;
        }
        .auto-style2 {
            width: 344px;
            height: 35px;
        }
        .auto-style3 {
            height: 35px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width: 73%; height: 290px;">
                <tr>
                    <td class="auto-style1">FirstName</td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="enter first name"></asp:RequiredFieldValidator>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                  <tr>
                    <td>LastName</td>
                    <td>
                        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                       <%-- <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"  ControlToValidate="TextBox4" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>--%>
                      </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">EmailId</td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                       <%-- <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"  ControlToValidate="TextBox2" ErrorMessage="invalid email"></asp:RegularExpressionValidator>--%>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>              
                    <td class="auto-style1">DOB</td>

                    <td>
                  <asp:TextBox ID="txtSelectDate" runat="server" TextMode="Date"></asp:TextBox>
                   </td>
                    <td>&nbsp;</td>
                </tr>
                   <tr>
                    <td class="auto-style2">Gender</td>
                    <td class="auto-style3">
                        <asp:RadioButtonList ID="RadioButtonList2" runat="server">
                            <asp:ListItem>Male</asp:ListItem>
                            <asp:ListItem>Female</asp:ListItem>
                            <asp:ListItem>Other</asp:ListItem>
                            
                        </asp:RadioButtonList>
                       </td>
                    <td class="auto-style3"></td>
                </tr>
                   <tr>
                    <td class="auto-style1">Country</td>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server">
                            <asp:ListItem>India</asp:ListItem>
                            <asp:ListItem>US</asp:ListItem>
                            <asp:ListItem>Canada</asp:ListItem>
                            <asp:ListItem>Australia</asp:ListItem>
                            <asp:ListItem>North Korea</asp:ListItem>
                            <asp:ListItem>China</asp:ListItem>
                            <asp:ListItem>Russia</asp:ListItem>

                        </asp:DropDownList>
                       </td>
                    <td>&nbsp;</td>
                </tr>
                 <tr>
                    <td class="auto-style1">Interests</td>
                    <td>
                        <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                            <asp:ListItem>Singing</asp:ListItem>
                            <asp:ListItem>Dancing</asp:ListItem>
                            <asp:ListItem>Reading</asp:ListItem>
                            <asp:ListItem>Writing</asp:ListItem>
                        </asp:CheckBoxList>
                     </td>
                    <td>&nbsp;</td>
                </tr>
                 <tr>
                    <td class="auto-style1">Mobile Number</td>
                    <td>
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                       <%-- <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox3" ValidationExpression="[0-9]{10}" ErrorMessage="not correct mno"></asp:RegularExpressionValidator>--%>

                     </td>
                    <td>&nbsp;</td>
                </tr>
                 <tr>
                    <td class="auto-style1">Remember Me</td>
                    <td>
                        <asp:CheckBox ID="CheckBox1" runat="server" />
                     </td>
                    <td>&nbsp;</td>
                </tr>
                 <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                 <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
                     </td>
                    <td>&nbsp;</td>
                </tr>

            </table>

        </div>
    </form>
</body>
</html>
