using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StaffTimeManagement.BAL;

namespace StaffTimeManagement.GUI.Manager_Form
{
    public partial class ManagerForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                string id = Session["managerId"] as string;

                

                Manager manager = new Manager();
                List<Manager> listM = manager.GetAllManagers();


                Staff staff = new Staff();
                List<Staff> listS = staff.GetAllStaffs();

                LabelManagerNo.Text = listM.Count().ToString();
                LabelStaffInfo.Text = listS.Count().ToString();

                manager = manager.GetManagerById(id);

                labelLoginAs.Text = manager.FirstName;

            }

        }
    }
}