using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StaffTimeManagement.BAL;
using System.Windows.Forms;

namespace StaffTimeManagement.GUI.Admin_Form
{
    public partial class AdminFunctionSelectUserStaff : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                User_Staff uS = Session["userStaffObject"] as User_Staff;
                Staff staff = Session["staffObject"] as Staff;

                TextBoxUserName.Text = uS.UserName;
                TextBoxPassword.Text = uS.Password;

                TextBoxFirstName.Text = staff.FirstName;
                TextBoxLastName.Text = staff.LastName;
                TextBoxEmail.Text = staff.Email;
                TextBoxPhoneNumber.Text = staff.PhoneNumber;

                TextBoxUserName.Enabled = false;
                TextBoxPassword.Enabled = false;
                TextBoxFirstName.Enabled = false;
                TextBoxLastName.Enabled = false;
                TextBoxEmail.Enabled = false;
                TextBoxPhoneNumber.Enabled = false;

                //TextBoxPassword.TextMode = TextBoxMode.Password;

            }
        }

        protected void ButtonBack_Click(object sender, EventArgs e)
        {
            Response.Redirect(@"\GUI\Admin_Form\AdminFunctionForm.aspx");
        }

        protected void ButtonDelete_Click(object sender, EventArgs e)
        {
            User_Staff uS = Session["userStaffObject"] as User_Staff;
            Staff staff = Session["staffObject"] as Staff;

            uS.DeleteUserStaff(uS);
            staff.DeleteStaff(staff);
            Response.Redirect(@"\GUI\Admin_Form\AdminFunctionForm.aspx");
        }

        protected void ButtonChangePassword_Click(object sender, EventArgs e)
        {
            Response.Redirect(@"\GUI\Admin_Form\AdminFunctionChangePasswordStaff.aspx");
        }

        protected void ButtonModify_Click(object sender, EventArgs e)
        {
            Response.Redirect(@"\GUI\Admin_Form\AdminFunctionModifyStaffInfo.aspx");
        }
    }
}