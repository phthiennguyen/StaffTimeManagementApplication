<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManagerFunctionModifyStaffWorkHour.aspx.cs" Inherits="StaffTimeManagement.GUI.Manager_Form.ManagerFunctionModifyStaffWorkHour" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add Staff's Work Hour</title>
    <link rel="stylesheet" href="CSS/Home.css" />
    <style type="text/css">
        

        .auto-style5 {
            width: 131px;
            height: 40px;
        }
        .auto-style6 {
            height: 40px;
        }
                

        .auto-style9 {
            width: 131px;
            height: 41px;
        }
        .auto-style10 {
            height: 41px;
        }
                

        .auto-style11 {
            height: 41px;
            width: 289px;
        }
        .auto-style12 {
            height: 40px;
            width: 289px;
        }
                

        .auto-style13 {
            width: 1150px;
        }
        .auto-style14 {
            height: 41px;
            width: 158px;
        }
        .auto-style15 {
            height: 40px;
            width: 158px;
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
        <h1>Manager's Function Modify Staff&#39;s Work Hour</h1>
        
        <table class="auto-style13">
        
       
        <tr>
            <td class="auto-style9">
                <h2>Time In</h2>
                </td>
            <td class="auto-style11">
                &nbsp;</td>
            <td class="auto-style14">
                &nbsp;</td>
            <td class="auto-style10">
                <h2>Time Out</h2>
                </td>
            <td class="auto-style10">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5">
                Date:</td>
            <td class="auto-style12">
                <asp:Calendar ID="CalendarTimeIn" runat="server"></asp:Calendar>
            </td>
            <td class="auto-style15">
                &nbsp;</td>
            <td class="auto-style6">
                Date:</td>
            <td class="auto-style6">
                <asp:Calendar ID="CalendarTimeOut" runat="server"></asp:Calendar>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">
                Hour:</td>
            <td class="auto-style12">
                <asp:TextBox ID="TextBoxInHour" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style15">
                &nbsp;</td>
            <td class="auto-style6">
                Hour:</td>
            <td class="auto-style6">
                <asp:TextBox ID="TextBoxOutHour" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style9">
                Minutes:</td>
            <td class="auto-style11">
                <asp:TextBox ID="TextBoxInMinute" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style14">
                </td>
            <td class="auto-style10">
                Minutes:</td>
            <td class="auto-style10">
                <asp:TextBox ID="TextBoxOutMinute" runat="server"></asp:TextBox>
            </td>
        </tr>

            
        <tr>
            <td class="auto-style9">
                &nbsp;</td>
            <td class="auto-style11">
                &nbsp;</td>
            <td class="auto-style14">
                &nbsp;</td>
            <td class="auto-style10">
                &nbsp;</td>
            <td class="auto-style10">
                <asp:Button ID="ButtonBack" runat="server" Text="Back" OnClick="ButtonBack_Click"  />
                &nbsp
                <asp:Button ID="ButtonSave" runat="server" Text="Save" OnClick="ButtonSave_Click"  />
            </td>
        </tr>

            
        </table>
        &nbsp;
        &nbsp;
                 

    </div>
    </form>
</body>
</html>