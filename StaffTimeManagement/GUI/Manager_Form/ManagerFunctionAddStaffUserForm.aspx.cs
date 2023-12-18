using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StaffTimeManagement.BAL;
using System.Windows.Forms;

namespace StaffTimeManagement.GUI.Manager_Form
{
    public partial class ManagerFunctionAddStaffUserForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect(@"\GUI\Manager_Form\ManagerFunctionUserForm.aspx");
        }

        protected void ButtonNext_Click(object sender, EventArgs e)
        {
            if (TextBoxUsername.Text == "")
            {
                MessageBox.Show("Username is required!!!");
                TextBoxUsername.Focus();
                return;
            }

            User_Staff uS = new User_Staff();
            User_Staff uS1 = new User_Staff();
            uS.UserName = TextBoxUsername.Text;

            if (uS1.GetUserStaffById(uS) != null)
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
            uS1.StaffId = uS1.UserName;

            Session["userStaffM"] = uS1;
            Response.Redirect(@"\GUI\Manager_Form\ManagerFunctionAddStaffForm.aspx");
        }
    }
}