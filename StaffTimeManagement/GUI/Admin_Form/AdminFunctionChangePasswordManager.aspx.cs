using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using StaffTimeManagement.BAL;

namespace StaffTimeManagement.GUI.Admin_Form
{
    public partial class AdminFunctionChangePasswordManager : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect(@"\GUI\Admin_Form\AdminFunctionSelectUserManager.aspx");
        }

        protected void ButtonChangePassword_Click(object sender, EventArgs e)
        {
            if (TextBoxPassword.Text == "")
            {
                MessageBox.Show("New Password is required!!!");
                TextBoxPassword.Focus();
                return;
            }

            if (TextBoxPasswordRe.Text == "")
            {
                MessageBox.Show("Please retype Password");
                TextBoxPasswordRe.Focus();
                return;
            }

            if (TextBoxPasswordRe.Text != TextBoxPassword.Text)
            {
                MessageBox.Show("Password is not matched!!!");
                TextBoxPasswordRe.Focus();
                return;
            }
            User_Manager u = new User_Manager();
            u = Session["userManagerObject"] as User_Manager;
            u.Password = TextBoxPassword.Text;
            u.UpdateUserManager(u);
            Response.Redirect(@"\GUI\Admin_Form\AdminFunctionSelectUserManager.aspx");
        }
    }
}