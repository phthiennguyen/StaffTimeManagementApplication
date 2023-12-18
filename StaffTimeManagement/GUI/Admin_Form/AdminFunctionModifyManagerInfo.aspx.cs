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
    public partial class AdminFunctionModifyManagerInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Manager manager = Session["managerObject"] as Manager;

                TextBoxFirstName.Text = manager.FirstName;
                TextBoxLastName.Text = manager.LastName;
                TextBoxEmail.Text = manager.Email;
                TextBoxPhoneNumber.Text = manager.PhoneNumber;
            }
            
        }

        protected void ButtonModify_Click(object sender, EventArgs e)
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



            User_Manager uS = Session["userManagerObject"] as User_Manager;
            Manager manager = Session["managerObject"] as Manager;
            manager.FirstName = TextBoxFirstName.Text;
            manager.LastName = TextBoxLastName.Text;
            manager.Email = TextBoxEmail.Text;
            manager.PhoneNumber = TextBoxPhoneNumber.Text;
            manager.UpdateManager(manager);
            Response.Redirect(@"\GUI\Admin_Form\AdminFunctionSelectUserManager.aspx");
        }

        protected void ButtonBack_Click(object sender, EventArgs e)
        {
            Response.Redirect(@"\GUI\Admin_Form\AdminFunctionSelectUserManager.aspx");
        }
    }
}