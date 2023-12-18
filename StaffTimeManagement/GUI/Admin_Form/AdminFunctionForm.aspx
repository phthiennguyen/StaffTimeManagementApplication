<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminFunctionForm.aspx.cs" Inherits="StaffTimeManagement.GUI.Admin_Form.AdminFunctionForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin's Function</title>
    <link rel="stylesheet" href="CSS/Home.css" />
    <style type="text/css">
        

        .auto-style1 {
            width: 100%;
        }
        

        .auto-style2 {
            width: 174px;
        }
        

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="top-sidebar">
            <div class ="label-button-container">
            <p>Login as Admin, 
            <asp:Label ID="labelLoginAs" runat="server">Admin</asp:Label>

            </p>
             </div>

        </div>


        <div class="sidebar">
            
        <asp:HyperLink ID="HyperlinkAdminForm" runat="server" NavigateUrl="~/GUI/Admin_Form/AdminForm.aspx" Text="DashBoard"></asp:HyperLink>
        <asp:HyperLink ID="HyperlinkAdminProfileForm" runat="server" NavigateUrl="~/GUI/Admin_Form/AdminProfileForm.aspx" Text="Profile"></asp:HyperLink>
        <a href="#User">User</a>
        <a href="#settings">Settings</a>
        <asp:HyperLink ID="HyperlinkLoginForm" runat="server" NavigateUrl="~/GUI/LoginForm.aspx" Text="Log Out"></asp:HyperLink>
    </div>

    <div class="content">
        <h1>Admin's Function</h1>
        
        <div class ="container">
       
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        <h2>Admin</h2>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <label for="TexBoxIdSearchAdmin">ID</label> 
                        <asp:TextBox ID="TextBoxIdSearchAdmin" runat="server" OnTextChanged="TextBoxIdSearchAdmin_TextChanged" autopostback="true"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Button ID="ButtonCreateA" runat="server" Text="Create" OnClick="ButtonCreateA_Click" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:GridView ID="GridViewAdminUser" runat="server" AutoGenerateColumns="False" AutoGenerateSelectButton="True" OnSelectedIndexChanged="GridViewAdminUser_SelectedIndexChanged">
                            <Columns>
                                <asp:BoundField DataField="adminId" HeaderText="UserName" />
                                <asp:BoundField DataField="firstName" HeaderText="First Name" />
                                <asp:BoundField DataField="lastName" HeaderText="Last Name" />
                                <asp:BoundField DataField="email" HeaderText="Email" />
                                <asp:BoundField DataField="phoneNumber" HeaderText="Phone Number" />
                            </Columns>
                        </asp:GridView>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                </tr>
            </table>
            
        </div>

        <div class ="container">
       
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        <h2>Manager</h2>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <label for="TexBoxIdSearchManager">ID</label> 
                        <asp:TextBox ID="TexBoxIdSearchManager" runat="server" OnTextChanged="TexBoxIdSearchManager_TextChanged" autopostback="true"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Button ID="ButtonCreateM" runat="server" Text="Create" OnClick="ButtonCreateM_Click" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:GridView ID="GridViewManagerUser" runat="server" AutoGenerateColumns="False" AutoGenerateSelectButton="True" OnSelectedIndexChanged="GridViewManagerUser_SelectedIndexChanged">
                            <Columns>
                                <asp:BoundField DataField="managerId" HeaderText="UserName" />
                                <asp:BoundField DataField="firstName" HeaderText="First Name" />
                                <asp:BoundField DataField="lastName" HeaderText="Last Name" />
                                <asp:BoundField DataField="email" HeaderText="Email" />
                                <asp:BoundField DataField="phoneNumber" HeaderText="Phone Number" />
                            </Columns>
                        </asp:GridView>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                </tr>
            </table>
            
        </div>

        <div class ="container">
       
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        <h2>Staff</h2>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <label for="TexBoxIdSearchStaff">ID</label> 
                        <asp:TextBox ID="TexBoxIdSearchStaff" runat="server" OnTextChanged="TexBoxIdSearchStaff_TextChanged"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Button ID="ButtonCreateStaff" runat="server" Text="Create" OnClick="ButtonCreateStaff_Click" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:GridView ID="GridViewStaffUser" runat="server" AutoGenerateColumns="False" AutoGenerateSelectButton="True" OnSelectedIndexChanged="GridViewStaffUser_SelectedIndexChanged">
                            <Columns>
                                <asp:BoundField DataField="staffId" HeaderText="UserName" />
                                <asp:BoundField DataField="firstName" HeaderText="First Name" />
                                <asp:BoundField DataField="lastName" HeaderText="Last Name" />
                                <asp:BoundField DataField="email" HeaderText="Email" />
                                <asp:BoundField DataField="phoneNumber" HeaderText="Phone Number" />
                            </Columns>
                        </asp:GridView>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                </tr>
            </table>
            
        </div>

    </div>
    </form>
</body>
</html>
