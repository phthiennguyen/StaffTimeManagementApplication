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
    public partial class AdminFunctionModifyStaffInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Staff staff = Session["staffObject"] as Staff;

                TextBoxFirstName.Text = staff.FirstName;
                TextBoxLastName.Text = staff.LastName;
                TextBoxEmail.Text = staff.Email;
                TextBoxPhoneNumber.Text = staff.PhoneNumber;
            }
        }

        protected void ButtonBack_Click(object sender, EventArgs e)
        {
            Response.Redirect(@"\GUI\Admin_Form\AdminFunctionSelectUserStaff.aspx");
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



            User_Staff uS = Session["userStaffObject"] as User_Staff;
            Staff staff = Session["staffObject"] as Staff;
            staff.FirstName = TextBoxFirstName.Text;
            staff.LastName = TextBoxLastName.Text;
            staff.Email = TextBoxEmail.Text;
            staff.PhoneNumber = TextBoxPhoneNumber.Text;
            staff.UpdateStaff(staff);
            Response.Redirect(@"\GUI\Admin_Form\AdminFunctionSelectUserStaff.aspx");

        }
    }
}