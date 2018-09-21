<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="Testing_Registration_and_validation_september_21.Registration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    
        <div>
            <table style="width: 76%; height: 384px;">
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
               
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox4" ErrorMessage="enter last name"></asp:RequiredFieldValidator>
                      </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1" style="height: 27px">EmailId</td>
                    <td style="height: 27px">
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox2" ErrorMessage="invalid email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    </td>
                    <td style="height: 27px"></td>
                </tr>
                <tr>              
                    <td class="auto-style1" style="height: 24px">DOB</td>

                    <td style="height: 24px">
                  <asp:TextBox ID="txtSelectDate" runat="server" TextMode="Date"></asp:TextBox>
                   </td>
                    <td style="height: 24px"></td>
                </tr>
                   <tr>
                    <td class="auto-style2" style="height: 65px">Gender</td>
                    <td class="auto-style3" style="height: 65px">
                        <asp:RadioButtonList ID="RadioButtonList2" runat="server">
                            <asp:ListItem>Male</asp:ListItem>
                            <asp:ListItem>Female</asp:ListItem>
                            <asp:ListItem>Other</asp:ListItem>
                            
                        </asp:RadioButtonList>
                       </td>
                    <td style="height: 65px"></td>
                </tr>
                   <tr>
                    <td class="auto-style1" style="height: 24px">Country</td>
                    <td style="height: 24px">
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
                    <td style="height: 24px"></td>
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
             
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="incorrect mobile number" ValidationExpression="[0-9]{10}" ControlToValidate="TextBox3"></asp:RegularExpressionValidator>

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

    <%--     <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
             <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
             <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
             <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
             <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
             <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
             <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
             <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>
             <asp:Label ID="Label9" runat="server" Text="Label"></asp:Label>
             <asp:Label ID="Label10" runat="server" Text="Label"></asp:Label>--%>

        
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>


        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server"></asp:ObjectDataSource>


        </div>


</asp:Content>
