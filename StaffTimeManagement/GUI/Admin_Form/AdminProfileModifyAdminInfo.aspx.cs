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
    public partial class AdminProfileModifyAdminInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Admin admin = new Admin();
                admin.AdminId = Session["adminId"] as string;
                admin = admin.GetAdminById(admin.AdminId);

                TextBoxFirstName.Text = admin.FirstName;
                TextBoxLastName.Text = admin.LastName;
                TextBoxEmail.Text = admin.Email;
                TextBoxPhoneNumber.Text = admin.PhoneNumber;
            }



        }

        protected void ButtonBack_Click(object sender, EventArgs e)
        {
            Response.Redirect(@"\GUI\Admin_Form\AdminProfileForm.aspx");
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



            
            Admin admin = new Admin();
            admin.AdminId = Session["adminId"] as string;
            admin = admin.GetAdminById(admin.AdminId);
            admin.FirstName = TextBoxFirstName.Text;
            admin.LastName = TextBoxLastName.Text;
            admin.Email = TextBoxEmail.Text;
            admin.PhoneNumber = TextBoxPhoneNumber.Text;
            admin.UpdateAdmin(admin);
            Response.Redirect(@"\GUI\Admin_Form\AdminProfileForm.aspx");
        }
    }
}