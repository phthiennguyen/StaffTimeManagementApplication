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
    public partial class ManagerFunctionSelectStaffWorkHour : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            StaffWorkHour wHour = (StaffWorkHour)Session["staffWorkHourSession"];

            CalendarTimeIn.SelectedDate = wHour.TimeIn.Value.Date;
            CalendarTimeOut.SelectedDate = wHour.TimeOut.Value.Date;

            TextBoxInHour.Text = wHour.TimeIn.Value.Hour.ToString();
            TextBoxInMinute.Text = wHour.TimeIn.Value.Minute.ToString();
            TextBoxOutHour.Text = wHour.TimeOut.Value.Hour.ToString();
            TextBoxOutMinute.Text = wHour.TimeOut.Value.Minute.ToString();

            CalendarTimeIn.Enabled = false;
            CalendarTimeOut.Enabled = false;
            TextBoxInHour.Enabled = false;
            TextBoxInMinute.Enabled = false;
            TextBoxOutHour.Enabled = false;
            TextBoxOutMinute.Enabled = false;

            MessageBox.Show(wHour.TimeIn.ToString() + "\n" + wHour.TimeOut.ToString());
            
        }

        protected void ButtonBack_Click(object sender, EventArgs e)
        {
            Response.Redirect(@"\GUI\Manager_Form\ManagerFunctionSelectUserStaff.aspx");
        }

        protected void ButtonModify_Click(object sender, EventArgs e)
        {
            Response.Redirect(@"\GUI\Manager_Form\ManagerFunctionModifyStaffWorkHour.aspx");
        }

        protected void ButtonDelete_Click(object sender, EventArgs e)
        {
            StaffWorkHour wHour = (StaffWorkHour)Session["staffWorkHourSession"];
            wHour.DeleteSWH(wHour);
            Response.Redirect(@"\GUI\Manager_Form\ManagerFunctionSelectUserStaff.aspx");
        }
    }
}