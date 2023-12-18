<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminProfileForm.aspx.cs" Inherits="StaffTimeManagement.GUI.Admin_Form.AdminProfileForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin's Profile</title>
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
        .auto-style4 {
            width: 141px;
            height: 22px;
        }
        .auto-style5 {
            height: 22px;
            width: 124px;
        }
        .auto-style6 {
            width: 124px;
        }
        .auto-style7 {
            width: 133px;
            height: 22px;
        }
        .auto-style8 {
            width: 133px;
        }
        .auto-style9 {
            height: 22px;
            width: 154px;
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
            <p>Login as Admin, 
            <asp:Label ID="labelLoginAs" runat="server">Admin</asp:Label>

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
        <h1>Admin's Profile</h1>
        <table class="auto-style2">
        
       
        <tr>
            <td class="auto-style7"></td>
            <td class="auto-style5"></td>
            <td class="auto-style9"></td>
            <td class="auto-style3"></td>
            <td class="auto-style5"></td>
            <td class="auto-style4"></td>
            <td class="auto-style3"></td>
            <td class="auto-style3"></td>
        </tr>
        <tr>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style10">&nbsp;</td>
            <td>&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style6">
                <asp:Label ID="Label4" runat="server" Text="ID:"></asp:Label>
            </td>
            <td class="auto-style10">
                <asp:TextBox ID="TextBoxAdminId" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td class="auto-style6">
                <asp:Label ID="Label7" runat="server" Text="Email:"></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:TextBox ID="TextBoxEmail" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style10">&nbsp;</td>
            <td>&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style6">
                <asp:Label ID="Label5" runat="server" Text="First Name:"></asp:Label>
            </td>
            <td class="auto-style10">
                <asp:TextBox ID="TextBoxFirstName" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td class="auto-style6">
                <asp:Label ID="Label8" runat="server" Text="Phone Number:"></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:TextBox ID="TextBoxPhoneNumber" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style10">&nbsp;</td>
            <td>&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style6">
                <asp:Label ID="Label6" runat="server" Text="Last Name:"></asp:Label>
            </td>
            <td class="auto-style10">
                <asp:TextBox ID="TextBoxLastName" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style1">
                <asp:Button ID="ButtonModify" runat="server" Text="MODIFY" OnClick="ButtonModify_Click" />
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>


        




    </div>
    </form>
</body>
</html>
