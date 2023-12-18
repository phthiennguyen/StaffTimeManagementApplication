<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManagerFunctionChangePasswordStaff.aspx.cs" Inherits="StaffTimeManagement.GUI.Manager_Form.ManagerFunctionChangePasswordStaff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>User's Change Password</title>
    <link rel="stylesheet" href="CSS/Profile.css" />
    <style type="text/css">
        .auto-style1 {
            width: 141px;
        }
        .auto-style2 {
            width: 1046px;
        }
        .auto-style3 {
            height: 22px;
        }
        .auto-style6 {
            width: 124px;
        }
        .auto-style8 {
            width: 133px;
        }
        .auto-style10 {
            width: 154px;
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
        <asp:HyperLink ID="HyperlinkAdminForm" runat="server" NavigateUrl="~/GUI/Admin_Form/AdminForm.aspx" Text="DashBoard"></asp:HyperLink>
        <a href="#profile">Profile</a>
        <asp:HyperLink ID="HyperlinkAdminFunctionForm" runat="server" NavigateUrl="~/GUI/Admin_Form/AdminFunctionForm.aspx" Text="Function"></asp:HyperLink>
        <a href="#settings">Settings</a>
        <asp:HyperLink ID="HyperlinkLoginForm" runat="server" NavigateUrl="~/GUI/LoginForm.aspx" Text="Log Out"></asp:HyperLink>

    </div>

    <div class="content">
        <h1>Staff change Password</h1>
        <table class="auto-style2">
        
       
        <tr>
            <td class="auto-style3" colspan="7">
                <h2>Account</h2>
            </td>
        </tr>
        <tr>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style10">&nbsp;</td>
            <td>&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style6">
                <asp:Label ID="LabelNewPassword" runat="server" Text="New Password:"></asp:Label>
            </td>
            <td class="auto-style10">
                <asp:TextBox ID="TextBoxPassword" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td class="auto-style6">
                <asp:Label ID="LabelPasswordRe" runat="server" Text="Retype Password:"></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:TextBox ID="TextBoxPasswordRe" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style10">&nbsp;</td>
            <td>&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
            <td>
                <asp:Button ID="ButtonCancel" runat="server" Text="CANCEL" OnClick="ButtonCancel_Click" />
                <asp:Button ID="ButtonChangePassword" runat="server" Text="Change Password" OnClick="ButtonChangePassword_Click" />
            </td>
        </tr>
        </table>


        




        <br />


        




    </div>
    </form>
</body>
</html>
