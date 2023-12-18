using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using StaffTimeManagement.BAL;

namespace StaffTimeManagement.GUI.Manager_Form
{
    public partial class ManagerFunctionAddStaffForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect(@"\GUI\Manager_Form\ManagerFunctionAddStaffUserForm.aspx");
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



            User_Staff uS = Session["userStaffM"] as User_Staff;
            Staff staff = new Staff();
            staff.StaffId = uS.StaffId;
            staff.FirstName = TextBoxFirstName.Text;
            staff.LastName = TextBoxLastName.Text;
            staff.Email = TextBoxEmail.Text;
            staff.PhoneNumber = TextBoxPhoneNumber.Text;

            uS.AddStaff(uS);
            staff.AddStaff(staff);

            Response.Redirect(@"\GUI\Manager_Form\ManagerFunctionUserForm.aspx");
        }
    }
}