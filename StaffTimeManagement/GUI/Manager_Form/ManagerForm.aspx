<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManagerForm.aspx.cs" Inherits="StaffTimeManagement.GUI.Manager_Form.ManagerForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Manager</title>
    <link rel="stylesheet" href="CSS/Home.css" />
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
            
        <a href="#home">Dashborad</a>
        <asp:HyperLink ID="HyperlinkManagerProfileForm" runat="server" NavigateUrl="~/GUI/Manager_Form/ManagerProfileForm.aspx" Text="Profile"></asp:HyperLink>
        <asp:HyperLink ID="HyperlinkManagerUserForm" runat="server" NavigateUrl="~/GUI/Manager_Form/ManagerFunctionUserForm.aspx" Text="User"></asp:HyperLink>
        <a href="#settings">Settings</a>
        <asp:HyperLink ID="HyperlinkLoginForm" runat="server" NavigateUrl="~/GUI/LoginForm.aspx" Text="Log Out"></asp:HyperLink>
    </div>

    <div class="content">
        <h1>Manager's Dashboard</h1>
        <div class="Info">
            <label >Number of Manager:</label>
            <asp:Label ID="LabelManagerNo" runat="server" Text="Label"></asp:Label>
            
        </div>

        <div class="Info">
            <label >Number of Staff:</label>
            <asp:Label ID="LabelStaffInfo" runat="server" Text="Label"></asp:Label>
            
        </div>
    </div>
        
    </form>
</body>
</html>
