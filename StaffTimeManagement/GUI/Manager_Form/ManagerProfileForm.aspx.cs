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
    public partial class ManagerProfileForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Session["managerId"] as string;
            Manager manager = new Manager();
            manager = manager.GetManagerById(id);

            labelLoginAs.Text = manager.FirstName;

            TextBoxManagerId.Text = manager.ManagerId;
            TextBoxFirstName.Text = manager.FirstName;
            TextBoxLastName.Text = manager.LastName;
            TextBoxEmail.Text = manager.Email;
            TextBoxPhoneNumber.Text = manager.PhoneNumber;

            TextBoxManagerId.Enabled = false;
            TextBoxFirstName.Enabled = false;
            TextBoxLastName.Enabled = false;
            TextBoxEmail.Enabled = false;
            TextBoxPhoneNumber.Enabled = false;
        }

        protected void ButtonModify_Click(object sender, EventArgs e)
        {
            Response.Redirect(@"\GUI\Manager_Form\ManagerProfileModifyManagerInfo.aspx");
        }
    }
}