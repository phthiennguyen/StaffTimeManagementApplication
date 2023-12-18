<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminFunctionAddStaffUserForm.aspx.cs" Inherits="StaffTimeManagement.GUI.Admin_Form.AdminFunctionAddStaffUserForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Create Staff's User</title>
    <link rel="stylesheet" href="CSS/Home.css" />
    <style type="text/css">
        

        .auto-style1 {
            width: 100%;
        }
        

        .auto-style2 {
            width: 553px;
        }
        

        .auto-style3 {
            width: 189px;
        }
        .auto-style5 {
            width: 189px;
            height: 40px;
        }
        .auto-style6 {
            height: 40px;
        }
        .auto-style8 {
            width: 100%;
            height: 40px;
        }
        

        .auto-style9 {
            width: 189px;
            height: 41px;
        }
        .auto-style10 {
            height: 41px;
        }
        .auto-style11 {
            width: 100%;
            height: 41px;
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
        <asp:HyperLink ID="HyperlinkAdminFunctionForm" runat="server" NavigateUrl="~/GUI/Admin_Form/AdminFunctionForm.aspx" Text="Function"></asp:HyperLink>
        <a href="#settings">Settings</a>
        <asp:HyperLink ID="HyperlinkLoginForm" runat="server" NavigateUrl="~/GUI/LoginForm.aspx" Text="Log Out"></asp:HyperLink>
    </div>

    <div class="content">
        <h1>Admin's Function Create Staff's User</h1>
        
        <table class="auto-style2">
        
       
        <tr>
            <td class="auto-style3">
                <asp:Label ID="LabelUserName" runat="server" Text="Username:"></asp:Label>
            </td>
            <td class="auto-style10">
                <asp:TextBox ID="TextBoxUsername" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">
                <asp:Label ID="LabelPassword" runat="server" Text="Password:"></asp:Label>
            </td>
            <td class="auto-style6">
                <asp:TextBox ID="TextBoxPassword" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">
                <asp:Label ID="LabelPasswordRe" runat="server" Text="Retype Password:"></asp:Label>
            </td>
            <td class="auto-style6">
                <asp:TextBox ID="TextBoxPasswordRe" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style9">
                <asp:Button ID="ButtonCancel" runat="server" Text="CANCEL" OnClick="ButtonCancel_Click" />
                </td>
            <td class="auto-style10">
                <asp:Button ID="ButtonNext" runat="server" Text="NEXT" OnClick="ButtonNext_Click" />
            </td>
        </tr>
        </table>
        

    </div>
    </form>
</body>
</html>
