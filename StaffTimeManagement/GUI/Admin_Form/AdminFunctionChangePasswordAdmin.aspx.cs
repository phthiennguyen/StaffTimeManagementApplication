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
    public partial class AdminFunctionChangePasswordAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect(@"\GUI\Admin_Form\AdminFunctionSelectUserAdmin.aspx");
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
            User_Admin u = new User_Admin();
            u = Session["userAdminObject"] as User_Admin;
            u.Password = TextBoxPassword.Text;
            u.UpdateUserAdmin(u);
            Response.Redirect(@"\GUI\Admin_Form\AdminFunctionSelectUserAdmin.aspx");
        }
    }
}