using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StaffTimeManagement.BAL;

namespace StaffTimeManagement.GUI.Staff_Form
{
    public partial class StaffProfileForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Session["staffId"] as string;
            Staff staff = new Staff();
            staff = staff.GetStaffById(id);

            labelLoginAs.Text = staff.FirstName;

            TextBoxStaffId.Text = staff.StaffId;
            TextBoxFirstName.Text = staff.FirstName;
            TextBoxLastName.Text = staff.LastName;
            TextBoxEmail.Text = staff.Email;
            TextBoxPhoneNumber.Text = staff.PhoneNumber;

            TextBoxStaffId.Enabled = false;
            TextBoxFirstName.Enabled = false;
            TextBoxLastName.Enabled = false;
            TextBoxEmail.Enabled = false;
            TextBoxPhoneNumber.Enabled = false;
        }

        protected void ButtonModify_Click(object sender, EventArgs e)
        {
            Response.Redirect(@"\GUI\Staff_Form\StaffProfileModifyStaffInfo.aspx");
        }
    }
}