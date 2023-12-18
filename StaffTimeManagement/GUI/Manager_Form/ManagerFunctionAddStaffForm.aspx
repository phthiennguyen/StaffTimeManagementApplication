<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManagerFunctionAddStaffForm.aspx.cs" Inherits="StaffTimeManagement.GUI.Manager_Form.ManagerFunctionAddStaffForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Create Staff</title>
    <link rel="stylesheet" href="CSS/Home.css" />
    <style type="text/css">
        

        .auto-style1 {
            width: 100%;
        }
        

        .auto-style2 {
            width: 553px;
        }
        

        .auto-style3 {
            width: 157px;
        }
        .auto-style4 {
            width: 188px;
        }
        .auto-style5 {
            width: 157px;
            height: 40px;
        }
        .auto-style6 {
            height: 40px;
        }
        .auto-style7 {
            width: 188px;
            height: 40px;
        }
        .auto-style8 {
            width: 100%;
            height: 40px;
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
            
         <asp:HyperLink ID="HyperlinkManagerForm" runat="server" NavigateUrl="~/GUI/Manager_Form/ManagerForm.aspx" Text="DashBoard"></asp:HyperLink>
        <asp:HyperLink ID="HyperlinkManagerProfileForm" runat="server" NavigateUrl="~/GUI/Manager_Form/ManagerProfileForm.aspx" Text="Profile"></asp:HyperLink>
        <asp:HyperLink ID="HyperlinkManagerFunctionUserForm" runat="server" NavigateUrl="~/GUI/Manager_Form/ManagerFunctionUserForm.aspx" Text="User"></asp:HyperLink>
        <a href="#settings">Settings</a>
        <asp:HyperLink ID="HyperlinkLoginForm" runat="server" NavigateUrl="~/GUI/LoginForm.aspx" Text="Log Out"></asp:HyperLink>
    </div>

    <div class="content">
        <h1>Admin's Function Create Staff</h1>
        
        <table class="auto-style2">
        
       
        <tr>
            <td class="auto-style3">
                <asp:Label ID="Label5" runat="server" Text="First Name:"></asp:Label>
            </td>
            <td class="auto-style10">
                <asp:TextBox ID="TextBoxFirstName" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style4">
                <asp:Label ID="Label7" runat="server" Text="Email:"></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:TextBox ID="TextBoxEmail" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">
                <asp:Label ID="Label6" runat="server" Text="Last Name:"></asp:Label>
            </td>
            <td class="auto-style6">
                <asp:TextBox ID="TextBoxLastName" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style7">
                <asp:Label ID="Label8" runat="server" Text="Phone Number:"></asp:Label>
            </td>
            <td class="auto-style8">
                <asp:TextBox ID="TextBoxPhoneNumber" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">
                &nbsp;</td>
            <td class="auto-style6">
                &nbsp;</td>
            <td class="auto-style7">
                &nbsp;</td>
            <td class="auto-style8">
                <asp:Button ID="ButtonCancel" runat="server" Text="BACK" OnClick="ButtonCancel_Click" />
                <asp:Button ID="ButtonCREATE" runat="server" Text="CREATE" OnClick="ButtonCREATE_Click" />
            </td>
        </tr>
        </table>
        

    </div>
    </form>
</body>
</html>
