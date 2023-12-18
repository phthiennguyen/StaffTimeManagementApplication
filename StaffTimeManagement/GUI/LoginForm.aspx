<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginForm.aspx.cs" Inherits="StaffTimeManagement.GUI.LoginForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <link rel="stylesheet" href="CSS/Login.css" />
   

</head>
<body>
    <div class="center">

        <h1>Login</h1>
        <form method ="post" runat="server">

            <div class="txt_field">
                 <asp:DropDownList class="input" ID="DropDownListLoginAs" runat="server"></asp:DropDownList>
                <label>Login As</label>
            </div>

            <div class ="txt_field">
                <asp:TextBox ID="textBoxUsername" class="input" runat="server"></asp:TextBox>
                <label>Username</label>
            </div>
            <div class ="txt_field">
                <asp:TextBox ID="textBoxPassword" type="password" class="input" runat="server"></asp:TextBox>
                <label>Password</label>
            </div>
            <div class="container">
                <asp:Button ID="ButtonLogin" class="button"  runat="server" Text="Login" OnClick="ButtonLogin_Click" />
            </div>
             
        </form>
        

           
        
        
        



    </div>
 
    

    
 
    
 
    

    
 
    

   
 
    

    
 
    

</body>
</html>
