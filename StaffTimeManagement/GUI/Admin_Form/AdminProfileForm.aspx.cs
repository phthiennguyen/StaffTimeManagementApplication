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
    public partial class AdminProfileForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Session["adminId"] as string;
            Admin admin = new Admin();
            admin = admin.GetAdminById(id);

            labelLoginAs.Text = admin.FirstName;

            TextBoxAdminId.Text = admin.AdminId;
            TextBoxFirstName.Text = admin.FirstName;
            TextBoxLastName.Text = admin.LastName;
            TextBoxEmail.Text = admin.Email;
            TextBoxPhoneNumber.Text = admin.PhoneNumber;

            TextBoxAdminId.Enabled = false;
            TextBoxFirstName.Enabled = false;
            TextBoxLastName.Enabled = false;
            TextBoxEmail.Enabled = false;
            TextBoxPhoneNumber.Enabled = false;

        }

        protected void ButtonModify_Click(object sender, EventArgs e)
        {

            Response.Redirect(@"\GUI\Admin_Form\AdminProfileModifyAdminInfo.aspx");
        }
    }
}