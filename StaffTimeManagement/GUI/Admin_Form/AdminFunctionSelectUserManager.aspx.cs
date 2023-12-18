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
    public partial class AdminFunctionSelectUserManager : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                User_Manager uS = Session["userManagerObject"] as User_Manager;
                Manager manager = Session["managerObject"] as Manager;

                TextBoxUserName.Text = uS.UserName;
                TextBoxPassword.Text = uS.Password;

                TextBoxFirstName.Text = manager.FirstName;
                TextBoxLastName.Text = manager.LastName;
                TextBoxEmail.Text = manager.Email;
                TextBoxPhoneNumber.Text = manager.PhoneNumber;

                TextBoxUserName.Enabled = false;
                TextBoxPassword.Enabled = false;
                TextBoxFirstName.Enabled = false;
                TextBoxLastName.Enabled = false;
                TextBoxEmail.Enabled = false;
                TextBoxPhoneNumber.Enabled = false;
                MessageBox.Show(manager.LastName);
                //TextBoxPassword.TextMode = TextBoxMode.Password;

            }
        }

        protected void ButtonBack_Click(object sender, EventArgs e)
        {
            Response.Redirect(@"\GUI\Admin_Form\AdminFunctionForm.aspx");
        }

        protected void ButtonChangePassword_Click(object sender, EventArgs e)
        {
            Response.Redirect(@"\GUI\Admin_Form\AdminFunctionChangePasswordManager.aspx");
        }

        protected void ButtonDelete_Click(object sender, EventArgs e)
        {
            User_Manager uS = Session["userManagerObject"] as User_Manager;
            Manager manager = Session["managerObject"] as Manager;

            uS.DeleteUserManager(uS);
            manager.DeleteManager(manager);
            Response.Redirect(@"\GUI\Admin_Form\AdminFunctionForm.aspx");
        }

        protected void ButtonModify_Click(object sender, EventArgs e)
        {
            Response.Redirect(@"\GUI\Admin_Form\AdminFunctionModifyManagerInfo.aspx");
        }
    }
}