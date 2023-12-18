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
    public partial class ManagerFunctionAddStaffWorkHour : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonSave_Click(object sender, EventArgs e)
        {

            Staff staff = Session["staffObjectM"] as Staff;

            if (CalendarTimeIn.SelectedDate == DateTime.MinValue || CalendarTimeOut.SelectedDate == DateTime.MinValue)
            {
                MessageBox.Show("Please select Date in both calendar!!!");
                return;
            }

            if (TextBoxInHour.Text == "" || TextBoxInMinute.Text == " " || TextBoxOutHour.Text == "" || TextBoxOutMinute.Text == "" )
            {
                MessageBox.Show("Please fill all the information!!!");
                return;
            }

            StaffWorkHour whour = new StaffWorkHour();
            DateTime inputTimein = new DateTime();

            DateTime inputTimeout = new DateTime();


            //working with timeIn
            DateTime dateIn = CalendarTimeIn.SelectedDate;
            int hourIn = int.Parse(TextBoxInHour.Text);
            int minuteIn = int.Parse(TextBoxInMinute.Text);
            

            inputTimein = dateIn.Add(new TimeSpan(hourIn, minuteIn, 0));

            //working with timeOut
            DateTime dateOut = CalendarTimeOut.SelectedDate;
            int hourOut = int.Parse(TextBoxOutHour.Text);
            int minuteOut = int.Parse(TextBoxOutMinute.Text);
            inputTimeout = dateOut.Add(new TimeSpan(hourOut,minuteOut,0));

            if(inputTimein > inputTimeout)
            {
                MessageBox.Show("Time in is later than Time out!!!");
                return;
            }
            else
            {
                whour.TimeIn = inputTimein;
                whour.TimeOut = inputTimeout;
                whour.StaffId = staff.StaffId;
                whour.Date = dateIn;

                MessageBox.Show(whour.TimeIn.ToString()+ "\n" + whour.TimeOut.ToString());


                whour.ClockIn(whour); 
                whour.ClockOut(whour);
                Response.Redirect(@"\GUI\Manager_Form\ManagerFunctionSelectUserStaff.aspx");


            }








        }

        protected void ButtonCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect(@"\GUI\Manager_Form\ManagerFunctionSelectUserStaff.aspx");
        }
    }
}