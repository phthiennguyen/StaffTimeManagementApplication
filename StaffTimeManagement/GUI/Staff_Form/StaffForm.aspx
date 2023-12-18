<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StaffForm.aspx.cs" Inherits="StaffTimeManagement.GUI.Staff_Form.StaffForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Staff's Profile</title>
    <link rel="stylesheet" href="CSS/Profile.css" />
    <style type="text/css">
        .auto-style2 {
            width: 1046px;
        }
        .auto-style9 {
            height: 22px;
            width: 154px;
        }
        .auto-style10 {
            width: 154px;
        }
        .auto-style11 {
            height: 22px;
            width: 37px;
        }
        .auto-style12 {
            width: 37px;
        }
        .auto-style13 {
            height: 22px;
            width: 50px;
        }
        .auto-style14 {
            width: 50px;
        }
        .auto-style15 {
            height: 22px;
            width: 38px;
        }
        .auto-style16 {
            width: 38px;
        }
        .auto-style17 {
            width: 154px;
            text-align: center;
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
        <asp:HyperLink ID="HyperlinkStaffForm" runat="server" NavigateUrl="~/GUI/Staff_Form/StaffForm.aspx" Text="DashBoard"></asp:HyperLink>
        <asp:HyperLink ID="HyperlinkStaffProfileForm" runat="server" NavigateUrl="~/GUI/Staff_Form/StaffProfileForm.aspx" Text="Profile"></asp:HyperLink>
        <asp:HyperLink ID="HyperlinkLoginForm" OnClick="LogOut_Click" runat="server" NavigateUrl="~/GUI/LoginForm.aspx" Text="Log Out"></asp:HyperLink>

    </div>

    <div class="content">
        <h1>DashBoard</h1>
        <table class="auto-style2">
        
       
        <tr>
            <td class="auto-style11"></td>
            <td class="auto-style15"></td>
            <td class="auto-style9"></td>
            <td class="auto-style9"></td>
            <td class="auto-style13"></td>
        </tr>
        <tr>
            <td class="auto-style12">&nbsp;</td>
            <td class="auto-style16">
                <asp:Button ID="ButtonClockIn" runat="server" Text="Clock In" OnClick="ButtonClockIn_Click" />
            </td>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style17">
                <asp:Button ID="ButtonClockOut" runat="server" Text="Clock Out" OnClick="ButtonClockOut_Click" />
            </td>
            <td class="auto-style14">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style12">&nbsp;</td>
            <td class="auto-style16">
                &nbsp;</td>
            <td class="auto-style10">
                &nbsp;</td>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style14">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style11"></td>
            <td class="auto-style15">
                <asp:GridView ID="GridViewClockin" runat="server" AutoGenerateColumns="False">
                    <Columns>
                        <asp:BoundField DataField="timeIn" HeaderText="Time" />
                    </Columns>
                </asp:GridView>
            </td>
            <td class="auto-style9"></td>
            <td class="auto-style9">
                <asp:GridView ID="GridViewClockOut" runat="server" AutoGenerateColumns="False">
                    <Columns>
                        <asp:BoundField DataField="timeOut" HeaderText="Time" />
                    </Columns>
                </asp:GridView>
            </td>
            <td class="auto-style13"></td>
        </tr>
        <tr>
            <td class="auto-style12">&nbsp;</td>
            <td class="auto-style16">
                &nbsp;</td>
            <td class="auto-style10">
                &nbsp;</td>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style14">
                &nbsp;</td>
        </tr>
        </table>
        &nbsp;
        &nbsp;

        <table class="auto-style2">
        
       
        <tr>
            <td class="auto-style15"></td>
        </tr>
        <tr>
            <td class="auto-style16">
                <asp:Button ID="ButtonViewHistory" runat="server" Text="View History" OnClick="ButtonViewHistory_Click" />
            </td>
        </tr>
        <tr>
            <td class="auto-style16">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style15">
                <asp:GridView ID="GridViewClockinHistory" runat="server" AutoGenerateColumns="False">
                    <Columns>
                        <asp:BoundField DataField="timeIn" HeaderText="Time In" />
                        <asp:BoundField DataField="timeOut" HeaderText="Time Out" />
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td class="auto-style16">
                &nbsp;</td>
        </tr>
        </table>
        




    </div>
    </form>
</body>
</html>
