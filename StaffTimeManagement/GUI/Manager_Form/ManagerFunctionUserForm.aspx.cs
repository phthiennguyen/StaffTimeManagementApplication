using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StaffTimeManagement.BAL;

namespace StaffTimeManagement.GUI.Manager_Form
{
    public partial class ManagerFunctionUserForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            { 

                List<Staff> listS = new List<Staff>();
                Staff staff = new Staff();
                listS = staff.GetAllStaffs();
                GridViewStaffUser.DataSource = listS;
                GridViewStaffUser.DataBind();



            }
        }

        protected void TexBoxIdSearchStaff_TextChanged(object sender, EventArgs e)
        {
            List<Staff> listS = new List<Staff>();
            Staff staff = new Staff();
            listS = staff.GetStaffByIdWithLike(TexBoxIdSearchStaff.Text.Trim());
            if (listS.Count > 0)
            {
                GridViewStaffUser.DataSource = listS;
                GridViewStaffUser.DataBind();
            }
            else
            {
                Staff nullStaff = new Staff();
                listS.Add(nullStaff);
                GridViewStaffUser.DataSource = listS;
                GridViewStaffUser.DataBind();

            }
        }

        protected void ButtonCreateStaff_Click(object sender, EventArgs e)
        {
            Response.Redirect(@"\GUI\Manager_Form\ManagerFunctionAddStaffUserForm.aspx");
        }

        protected void GridViewStaffUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            Staff staff = new Staff();
            User_Staff uS = new User_Staff();
            staff.StaffId = GridViewStaffUser.SelectedRow.Cells[1].Text;
            uS.UserName = GridViewStaffUser.SelectedRow.Cells[1].Text;
            uS = uS.GetUserStaffById(uS);
            staff = staff.GetStaffById(staff.StaffId);
            Session["staffObjectM"] = staff;
            Session["userStaffObjectM"] = uS;
            Response.Redirect(@"\GUI\Manager_Form\ManagerFunctionSelectUserStaff.aspx");
        }
    }
}