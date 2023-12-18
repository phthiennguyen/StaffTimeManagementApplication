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
    public partial class AdminFunctionForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                

                List<Admin> listA = new List<Admin>();
                Admin admin = new Admin();
                listA = admin.GetAllAdmins();
                GridViewAdminUser.DataSource = listA;
                GridViewAdminUser.DataBind();

                List<Manager> listM = new List<Manager>();
                Manager manager = new Manager();
                listM = manager.GetAllManagers();
                GridViewManagerUser.DataSource = listM;
                GridViewManagerUser.DataBind();

                List<Staff> listS = new List<Staff>();
                Staff staff = new Staff();
                listS = staff.GetAllStaffs();
                GridViewStaffUser.DataSource = listS;
                GridViewStaffUser.DataBind();



            }
        }



        protected void TextBoxIdSearchAdmin_TextChanged(object sender, EventArgs e)
        {

            //GridViewAdminUser.Columns.Clear();
            List<Admin> listA = new List<Admin>();
            Admin admin = new Admin();
            listA = admin.GetAdminByIdWithLike(TextBoxIdSearchAdmin.Text.Trim());
           if(listA.Count > 0)
            {
                GridViewAdminUser.DataSource = listA;
                GridViewAdminUser.DataBind();
            }
            else
            {
                Admin nullAdmin = new Admin();
                listA.Add(nullAdmin);
                GridViewAdminUser.DataSource = listA;
                GridViewAdminUser.DataBind();

            }





        }

        protected void TexBoxIdSearchManager_TextChanged(object sender, EventArgs e)
        {
            List<Manager> listM = new List<Manager>();
            Manager manager = new Manager();
            listM = manager.GetManagerByIdWithLike(TexBoxIdSearchManager.Text.Trim());
            if (listM.Count > 0)
            {
                GridViewManagerUser.DataSource = listM;
                GridViewManagerUser.DataBind();
            }
            else
            {
                Manager nullManager = new Manager();
                listM.Add(nullManager);
                GridViewManagerUser.DataSource = listM;
                GridViewManagerUser.DataBind();

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

        protected void ButtonCreateA_Click(object sender, EventArgs e)
        {
            Response.Redirect(@"\GUI\Admin_Form\AdminFunctionAddAdminUserForm.aspx");
        }

        protected void ButtonCreateM_Click(object sender, EventArgs e)
        {
            Response.Redirect(@"\GUI\Admin_Form\AdminFunctionAddManagerUserForm.aspx");
        }

        protected void ButtonCreateStaff_Click(object sender, EventArgs e)
        {
            Response.Redirect(@"\GUI\Admin_Form\AdminFunctionAddStaffUserForm.aspx");
        }

        protected void GridViewAdminUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            User_Admin uS = new User_Admin();
            
            admin.AdminId = GridViewAdminUser.SelectedRow.Cells[1].Text;
            //admin.FirstName = GridViewAdminUser.SelectedRow.Cells[2].Text;
            //admin.LastName = GridViewAdminUser.SelectedRow.Cells[3].Text;
            //admin.Email = GridViewAdminUser.SelectedRow.Cells[4].Text;
            //admin.PhoneNumber = GridViewAdminUser.SelectedRow.Cells[5].Text;
            uS.UserName = GridViewAdminUser.SelectedRow.Cells[1].Text;
            uS = uS.GetUserAdminById(uS);
            admin = admin.GetAdminById(admin.AdminId);
            Session["userAdminObject"] = uS;
            Session["adminObject"] = admin;
            Response.Redirect(@"\GUI\Admin_Form\AdminFunctionSelectUserAdmin.aspx");
        }

        protected void GridViewManagerUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            Manager manager = new Manager();
            User_Manager uA = new User_Manager();
            manager.ManagerId = GridViewManagerUser.SelectedRow.Cells[1].Text;
            uA.UserName = GridViewManagerUser.SelectedRow.Cells[1].Text;
            //manager.FirstName = GridViewManagerUser.SelectedRow.Cells[2].Text;
            //manager.LastName = GridViewManagerUser.SelectedRow.Cells[3].Text;
            //manager.Email = GridViewManagerUser.SelectedRow.Cells[4].Text;
            //manager.PhoneNumber = GridViewManagerUser.SelectedRow.Cells[5].Text;
            manager = manager.GetManagerById(manager.ManagerId);
            uA = uA.GetUserManagerById(uA);
            Session["managerObject"] = manager;
            Session["UsermanagerObject"] = uA;
            Response.Redirect(@"\GUI\Admin_Form\AdminFunctionSelectUserManager.aspx");
        }

        protected void GridViewStaffUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            Staff staff = new Staff();
            User_Staff uS = new User_Staff();
            staff.StaffId = GridViewStaffUser.SelectedRow.Cells[1].Text;
            uS.UserName = GridViewStaffUser.SelectedRow.Cells[1].Text;
            //staff.FirstName = GridViewStaffUser.SelectedRow.Cells[2].Text;
            //staff.LastName = GridViewStaffUser.SelectedRow.Cells[3].Text;
            //staff.Email = GridViewStaffUser.SelectedRow.Cells[4].Text;
            //staff.PhoneNumber = GridViewStaffUser.SelectedRow.Cells[5].Text;
            uS = uS.GetUserStaffById(uS);
            staff = staff.GetStaffById(staff.StaffId);
            Session["staffObject"] = staff;
            Session["userStaffObject"] = uS;
            Response.Redirect(@"\GUI\Admin_Form\AdminFunctionSelectUserStaff.aspx");
        }
    }
}