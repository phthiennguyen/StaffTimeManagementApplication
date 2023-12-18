using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using StaffTimeManagement.BAL;

namespace StaffTimeManagement.GUI
{
    public partial class LoginForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                DropDownListLoginAs.Items.Add("");
                DropDownListLoginAs.Items.Add("Admin");
                DropDownListLoginAs.Items.Add("Manager");
                DropDownListLoginAs.Items.Add("Staff");
            }
            




        }

        protected void ButtonLogin_Click(object sender, EventArgs e)
        {
            int loginAs = DropDownListLoginAs.SelectedIndex;

            if(textBoxUsername.Text == "")
            {
                MessageBox.Show("Please Enter Username ", "Missing Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxUsername.Focus();
                return;

            }
            if (textBoxPassword.Text == "")
            {
                MessageBox.Show("Missing Password ", "Missing Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxUsername.Focus();
                return ;
            }


            switch (DropDownListLoginAs.SelectedValue)
            {
                case "":

                    MessageBox.Show("Missing Login As " + loginAs, "Missing Input",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    DropDownListLoginAs.Focus();

                    break;
                case "Admin":  //admin
                    User_Admin uA = new User_Admin();
                    uA.UserName = textBoxUsername.Text;
                    uA.Password = textBoxPassword.Text;

                    if(uA.GetUserAdmin(uA) != null)
                    {
                        Session["adminId"] = uA.UserName;
                        Response.Redirect(@"\GUI\Admin_Form\AdminForm.aspx");
                    }
                    else
                    {
                        MessageBox.Show("Admin Account does not exist!!! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    break;

                case "Manager":
                    User_Manager uM = new User_Manager();
                    uM.UserName = textBoxUsername.Text;
                    uM.Password = textBoxPassword.Text;

                    if (uM.GetUserManager(uM) != null)
                    {
                        Session["managerId"] = uM.UserName;
                        Response.Redirect(@"\GUI\Manager_Form\ManagerForm.aspx");
                    }
                    else
                    {
                        MessageBox.Show("Manager Account does not exist!!! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;


                case "Staff":
                    User_Staff uS = new User_Staff();
                    uS.UserName = textBoxUsername.Text;
                    uS.Password = textBoxPassword.Text;

                    if (uS.GetUserStaff(uS) != null)
                    {
                        Session["staffId"] = uS.UserName;
                        Session["TimeClockIn"] = DateTime.Now;
                        Response.Redirect(@"\GUI\Staff_Form\StaffForm.aspx");
                    }
                    else
                    {
                        MessageBox.Show("Staff Account does not exist!!! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    break;

            }

        }
    }
}