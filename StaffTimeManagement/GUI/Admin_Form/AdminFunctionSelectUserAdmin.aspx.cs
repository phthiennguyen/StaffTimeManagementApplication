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
    public partial class AdminFunctionSelectUserAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                User_Admin uS = Session["userAdminObject"] as User_Admin;
                Admin admin = Session["adminObject"] as Admin;

                TextBoxUserName.Text = uS.UserName;
                TextBoxPassword.Text = uS.Password;

                TextBoxFirstName.Text = admin.FirstName;
                TextBoxLastName.Text = admin.LastName;
                TextBoxEmail.Text = admin.Email;
                TextBoxPhoneNumber.Text = admin.PhoneNumber;

                TextBoxUserName.Enabled = false;
                TextBoxPassword.Enabled = false;
                TextBoxFirstName.Enabled = false;
                TextBoxLastName.Enabled = false;
                TextBoxEmail.Enabled = false;
                TextBoxPhoneNumber.Enabled = false;


            }
        }

        protected void ButtonBack_Click(object sender, EventArgs e)
        {
            Response.Redirect(@"\GUI\Admin_Form\AdminFunctionForm.aspx");
        }

        protected void ButtonChangePassword_Click(object sender, EventArgs e)
        {
            Response.Redirect(@"\GUI\Admin_Form\AdminFunctionChangePasswordAdmin.aspx");
        }

        protected void ButtonDelete_Click(object sender, EventArgs e)
        {
            User_Admin uS = Session["userAdminObject"] as User_Admin;
            Admin staff = Session["adminObject"] as Admin;

            uS.DeleteUserAdmin(uS);
            staff.DeleteAdmin(staff);
            Response.Redirect(@"\GUI\Admin_Form\AdminFunctionForm.aspx");
        }

        protected void ButtonModify_Click(object sender, EventArgs e)
        {
            Response.Redirect(@"\GUI\Admin_Form\AdminFunctionModifyAdminInfo.aspx");
        }
    }
}