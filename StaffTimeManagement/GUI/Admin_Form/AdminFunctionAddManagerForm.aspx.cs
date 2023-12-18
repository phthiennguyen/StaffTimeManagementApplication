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
    public partial class AdminFunctionAddManagerForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect(@"\GUI\Admin_Form\AdminFunctionAddManagerUserForm.aspx");
        }

        protected void ButtonCREATE_Click(object sender, EventArgs e)
        {
            if (TextBoxFirstName.Text == "")
            {
                MessageBox.Show("First name is required!!!");
                TextBoxFirstName.Focus();
                return;
            }
            if (TextBoxLastName.Text == "")
            {
                MessageBox.Show("Last name is required!!!");
                TextBoxFirstName.Focus();
                return;
            }
            if (TextBoxEmail.Text == "")
            {
                MessageBox.Show("Email is required!!!");
                TextBoxFirstName.Focus();
                return;
            }
            if (TextBoxPhoneNumber.Text == "")
            {
                MessageBox.Show("Phone number is required!!!");
                TextBoxFirstName.Focus();
                return;
            }



            User_Manager uS = Session["userManager"] as User_Manager;
            Manager manager = new Manager();
            manager.ManagerId = uS.ManagerId;
            manager.FirstName = TextBoxFirstName.Text;
            manager.LastName = TextBoxLastName.Text;
            manager.Email = TextBoxEmail.Text;
            manager.PhoneNumber = TextBoxPhoneNumber.Text;

            uS.AddManager(uS);
            manager.AddManager(manager);

            Response.Redirect(@"\GUI\Admin_Form\AdminFunctionForm.aspx");
        }
    }
}