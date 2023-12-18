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
    public partial class AdminFunctionAddManagerUserForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect(@"\GUI\Admin_Form\AdminFunctionForm.aspx");
        }

        protected void ButtonNext_Click(object sender, EventArgs e)
        {
            if (TextBoxUsername.Text == "")
            {
                MessageBox.Show("Username is required!!!");
                TextBoxUsername.Focus();
                return;
            }

            User_Manager uS = new User_Manager();
            User_Manager uS1 = new User_Manager();
            uS.UserName = TextBoxUsername.Text;

            if (uS1.GetUserManagerById(uS) != null)
            {
                MessageBox.Show("Username is already existed!!!");
                TextBoxUsername.Focus();
                return;
            }

            if (TextBoxPassword.Text == "")
            {
                MessageBox.Show("Password is required!!!");
                TextBoxPassword.Focus();
                return;
            }

            if (TextBoxPasswordRe.Text == "")
            {
                MessageBox.Show("Retype Password is required!!!");
                TextBoxPasswordRe.Focus();
                return;
            }

            if (TextBoxPassword.Text != TextBoxPasswordRe.Text)
            {
                MessageBox.Show("Password does not matched!!!");
                TextBoxPasswordRe.Focus();
                return;
            }

            uS1.UserName = TextBoxUsername.Text;
            uS1.Password = TextBoxPassword.Text;
            uS1.ManagerId = uS1.UserName;

            Session["userManager"] = uS1;
            Response.Redirect(@"\GUI\Admin_Form\AdminFunctionAddManagerForm.aspx");
        }
    }
}