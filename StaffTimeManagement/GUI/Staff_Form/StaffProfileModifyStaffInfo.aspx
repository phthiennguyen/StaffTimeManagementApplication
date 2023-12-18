<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StaffProfileModifyStaffInfo.aspx.cs" Inherits="StaffTimeManagement.GUI.Staff_Form.StaffProfileModifyStaffInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>User's Profile</title>
    <link rel="stylesheet" href="CSS/Profile.css" />
    <style type="text/css">
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
        .auto-style11 {
            width: 206px;
        }
        .auto-style12 {
            width: 8px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="top-sidebar">
            <div class ="label-button-container">
            <p>Login as Staff, 
            <asp:Label ID="labelLoginAs" runat="server">Staff</asp:Label>

            </p>
             </div>

        </div>


        <div class="sidebar">
        <asp:HyperLink ID="HyperlinkManagerForm" runat="server" NavigateUrl="~/GUI/Manager_Form/ManagerForm.aspx" Text="DashBoard"></asp:HyperLink>
        <asp:HyperLink ID="HyperlinkManagerProfile" runat="server" NavigateUrl="~/GUI/Manager_Form/ManagerProfileForm.aspx" Text="Profile"></asp:HyperLink>
        <asp:HyperLink ID="HyperlinkManagerFunctionUserForm" runat="server" NavigateUrl="~/GUI/Manager_Form/ManagerFunctionUserForm.aspx" Text="User"></asp:HyperLink>
        <asp:HyperLink ID="HyperlinkLoginForm" runat="server" NavigateUrl="~/GUI/LoginForm.aspx" Text="Log Out"></asp:HyperLink>

    </div>

    <div class="content">
        <h1>Staff's Profile</h1>


        




        <br />
        <table class="auto-style2">
        
       
        <tr>
            <td class="auto-style3" colspan="7">
                <h2>
                    &nbsp;</h2>
            </td>
        </tr>
        <tr>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style12">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style11">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style6">
                <asp:Label ID="LabelFirstName" runat="server" Text="First Name:"></asp:Label>
            </td>
            <td class="auto-style10">
                <asp:TextBox ID="TextBoxFirstName" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style12">&nbsp;</td>
            <td class="auto-style6">
                <asp:Label ID="LabelEmail" runat="server" Text="Email:"></asp:Label>
            </td>
            <td class="auto-style11">
                <asp:TextBox ID="TextBoxEmail" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style12">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style11">&nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style6">
                <asp:Label ID="LabelLastName" runat="server" Text="Last Name:"></asp:Label>
            </td>
            <td class="auto-style10">
                <asp:TextBox ID="TextBoxLastName" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style12">&nbsp;</td>
            <td class="auto-style6">
                <asp:Label ID="LabelPhoneNumber" runat="server" Text="Phone Number:"></asp:Label>
            </td>
            <td class="auto-style11">
                <asp:TextBox ID="TextBoxPhoneNumber" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style12">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style11">&nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style12">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style11">&nbsp;</td>
            <td>
                <asp:Button ID="ButtonBack" runat="server" Text="BACK" OnClick="ButtonBack_Click" />
                <asp:Button ID="ButtonModify" runat="server" Text="MODIFY" OnClick="ButtonModify_Click" />
            </td>
        </tr>
        </table>


        




    </div>
    </form>
</body>
</html>
