using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StaffTimeManagement.BAL;
using System.Windows.Forms;

namespace StaffTimeManagement.GUI.Manager_Form
{
    public partial class ManagerProfileModifyManagerInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Manager manager = new Manager();
                manager.ManagerId = Session["managerId"] as string;
                manager = manager.GetManagerById(manager.ManagerId);

                TextBoxFirstName.Text = manager.FirstName;
                TextBoxLastName.Text = manager.LastName;
                TextBoxEmail.Text = manager.Email;
                TextBoxPhoneNumber.Text = manager.PhoneNumber;
            }
            
        }

        protected void ButtonBack_Click(object sender, EventArgs e)
        {
            Response.Redirect(@"\GUI\Manager_Form\ManagerProfileForm.aspx");
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




            Manager manager = new Manager();
            manager.ManagerId = Session["managerId"] as string;
            manager = manager.GetManagerById(manager.ManagerId);
            manager.FirstName = TextBoxFirstName.Text;
            manager.LastName = TextBoxLastName.Text;
            manager.Email = TextBoxEmail.Text;
            manager.PhoneNumber = TextBoxPhoneNumber.Text;
            manager.UpdateManager(manager);
            Response.Redirect(@"\GUI\Manager_Form\ManagerProfileForm.aspx");
        }
    }
}