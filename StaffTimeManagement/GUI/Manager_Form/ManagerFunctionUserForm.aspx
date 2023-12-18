<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManagerFunctionUserForm.aspx.cs" Inherits="StaffTimeManagement.GUI.Manager_Form.ManagerFunctionUserForm" %>

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
        

        .auto-style3 {
            width: 174px;
            height: 151px;
        }
        

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="top-sidebar">
            <div class ="label-button-container">
            <p>Login as Manager, 
            <asp:Label ID="labelLoginAs" runat="server">Manager</asp:Label>

            </p>
             </div>

        </div>


        <div class="sidebar">
            
        <asp:HyperLink ID="HyperlinkManagerForm" runat="server" NavigateUrl="~/GUI/Manager_Form/ManagerForm.aspx" Text="DashBoard"></asp:HyperLink>
        <asp:HyperLink ID="HyperlinkManagerProfileForm" runat="server" NavigateUrl="~/GUI/Manager_Form/ManagerProfileForm.aspx" Text="Profile"></asp:HyperLink>
        <asp:HyperLink ID="HyperlinkManagerFunctionUserForm" runat="server" NavigateUrl="~/GUI/Manager_Form/ManagerFunctionUserForm.aspx" Text="User"></asp:HyperLink>
        <a href="#settings">Settings</a>
        <asp:HyperLink ID="HyperlinkLoginForm" runat="server" NavigateUrl="~/GUI/LoginForm.aspx" Text="Log Out"></asp:HyperLink>
    </div>

    <div class="content">
        <h1>Manager's Function</h1>
        
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
                    <td class="auto-style3">
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
