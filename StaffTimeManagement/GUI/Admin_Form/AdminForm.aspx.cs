using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StaffTimeManagement.BAL;

namespace StaffTimeManagement.GUI
{
    public partial class AdminForm : System.Web.UI.Page
    {
        public int truong = 123;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                string id = Session["adminId"] as string;

                Admin admin = new Admin();
                List<Admin> listA = admin.GetAllAdmins();

                Manager manager = new Manager();
                List<Manager> listM = manager.GetAllManagers();


                Staff staff = new Staff();
                List<Staff> listS = staff.GetAllStaffs();

                LabelAdminNo.Text = listA.Count().ToString();
                LabelManagerNo.Text = listM.Count().ToString();
                LabelStaffInfo.Text = listS.Count().ToString();

                admin = admin.GetAdminById(id);

                labelLoginAs.Text = admin.FirstName;

            }
        }

       
    }
}