using StaffTimeManagement.BAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace StaffTimeManagement.GUI.Manager_Form
{
    public partial class ManagerFunctionChangePasswordStaff : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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
            User_Staff u = new User_Staff();
            u = Session["userStaffObjectM"] as User_Staff;
            u.Password = TextBoxPassword.Text;
            u.UpdateUserStaff(u);
            Response.Redirect(@"\GUI\Manager_Form\ManagerFunctionSelectUserStaff.aspx");
        }

        protected void ButtonCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect(@"\GUI\Manager_Form\ManagerFunctionSelectUserStaff.aspx");
        }
    }
}