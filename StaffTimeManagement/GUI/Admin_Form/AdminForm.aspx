<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminForm.aspx.cs" Inherits="StaffTimeManagement.GUI.AdminForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin</title>
    <link rel="stylesheet" href="CSS/Home.css" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.4.2/css/all.min.css" integrity="sha512-z3gLpd7yknf1YoNbCzqRKc4qyor8gaKU1qmn+CShxbuBusANI9QpRohGBreCFkKxLhei6S9CQXFEbbKuqLg0DA==" crossorigin="anonymous" referrerpolicy="no-referrer" />

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
            
        <a href="#home">Dashborad</a>
        <asp:HyperLink ID="HyperlinkAdminProfileForm" runat="server" NavigateUrl="~/GUI/Admin_Form/AdminProfileForm.aspx" Text="Profile"></asp:HyperLink>
        <asp:HyperLink ID="HyperlinkAdminFunctionForm" runat="server" NavigateUrl="~/GUI/Admin_Form/AdminFunctionForm.aspx" Text="Function"></asp:HyperLink>
        <a href="#settings">Settings</a>
        <asp:HyperLink ID="HyperlinkLoginForm" runat="server" NavigateUrl="~/GUI/LoginForm.aspx" Text="Log Out"></asp:HyperLink>
    </div>

    <div class="content">
        <h1>Admin's Dashboard</h1>
        


        <div class="Info">
            <label >Number of Admin:</label>
            <asp:Label ID="LabelAdminNo" runat="server" Text="Label"></asp:Label>
            
        </div>

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
