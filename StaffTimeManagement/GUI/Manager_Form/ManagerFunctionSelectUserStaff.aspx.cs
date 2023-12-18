using StaffTimeManagement.BAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace StaffTimeManagement.GUI.Manager_Form
{
    public partial class ManagerFunctionSelectUserStaff : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                User_Staff uS = Session["userStaffObjectM"] as User_Staff;
                Staff staff = Session["staffObjectM"] as Staff;

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

                StaffWorkHour swh = new StaffWorkHour();
                List<StaffWorkHour> workHourList = swh.GetSWHWithStaffId(staff.StaffId);
                GridViewWhour.DataSource = workHourList;
                GridViewWhour.DataBind();
                

            }
        }

        protected void ButtonChangePassword_Click(object sender, EventArgs e)
        {
            Response.Redirect(@"\GUI\Manager_Form\ManagerFunctionChangePasswordStaff.aspx");
        }

        protected void ButtonModify_Click(object sender, EventArgs e)
        {
            Response.Redirect(@"\GUI\Manager_Form\ManagerFunctionModifyStaffInfo.aspx");
        }

        protected void ButtonBack_Click(object sender, EventArgs e)
        {
            Response.Redirect(@"\GUI\Manager_Form\ManagerFunctionUserForm.aspx");
        }

        protected void ButtonDelete_Click(object sender, EventArgs e)
        {
            User_Staff uS = Session["userStaffObjectM"] as User_Staff;
            Staff staff = Session["staffObjectM"] as Staff;
            uS.DeleteUserStaff(uS);
            staff.DeleteStaff(staff);
            Response.Redirect(@"\GUI\Manager_Form\ManagerFunctionUserForm.aspx");
        }

        protected void ButtonAddWH_Click(object sender, EventArgs e)
        {
            Response.Redirect(@"\GUI\Manager_Form\ManagerFunctionAddStaffWorkHour.aspx");
        }

        protected void GridViewWhour_SelectedIndexChanged(object sender, EventArgs e)
        {
            StaffWorkHour whour = new StaffWorkHour();
            Staff staff = Session["staffObjectM"] as Staff;

            List<StaffWorkHour> listSWH = whour.GetSWHWithStaffId(staff.StaffId);
            whour = listSWH[GridViewWhour.SelectedIndex];


            Session["staffWorkHourSession"] = whour;

            Response.Redirect(@"\GUI\Manager_Form\ManagerFunctionSelectStaffWorkHour.aspx");
        }
    }
}