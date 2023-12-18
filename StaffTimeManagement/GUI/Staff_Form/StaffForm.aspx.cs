using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StaffTimeManagement.BAL;
using System.Windows.Forms;

namespace StaffTimeManagement.GUI.Staff_Form
{
    public partial class StaffForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {

                string id = Session["staffId"] as string;

               Staff staff = new Staff();

                staff = staff.GetStaffById(id);

                labelLoginAs.Text = staff.FirstName;

                
                

                StaffWorkHour swh = new StaffWorkHour();
                swh.TimeIn = (DateTime)Session["TimeClockIn"];
                swh.StaffId = id;
               

                swh = swh.GetSWHWithStaffIdAndClockIn(swh);
                List<StaffWorkHour> list = new List<StaffWorkHour>();
                if (swh == null)
                {
                    ButtonClockIn.Enabled = true;
                    ButtonClockOut.Enabled = false;

                }
                else
                {
                    if(swh.TimeOut == null)
                    {
                        ButtonClockOut.Enabled = true;
                        ButtonClockIn.Enabled = false;
                        
                        list.Add(swh);

                        GridViewClockin.DataSource = list;
                        GridViewClockin.DataBind();
                    }
                }

                

            }
            else
            {
                string id = Session["staffId"] as string;
                StaffWorkHour swh = new StaffWorkHour();
                swh.TimeIn = (DateTime)Session["TimeClockIn"];
                swh.StaffId = id;


                swh = swh.GetSWHWithStaffIdAndClockIn(swh);
                List<StaffWorkHour> list = new List<StaffWorkHour>();
                if (swh == null)
                {
                    ButtonClockIn.Enabled = true;
                    ButtonClockOut.Enabled = false;

                }
                else
                {
                    if (swh.TimeOut == null)
                    {
                        ButtonClockOut.Enabled = true;
                        ButtonClockIn.Enabled = false;

                        list.Add(swh);

                        GridViewClockin.DataSource = list;
                        GridViewClockin.DataBind();
                    }
                }
            }
        }

        protected void ButtonClockIn_Click(object sender, EventArgs e)
        {
            string id = Session["staffId"] as string;

            StaffWorkHour swh = new StaffWorkHour();
            //swh.TimeIn = Convert.ToDateTime(currentTime);
            //swh.TimeIn = new DateTime( DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            swh.TimeIn = DateTime.Now.AddMilliseconds(-DateTime.Now.Millisecond);
            swh.Date = DateTime.Now.Date;
            swh.StaffId = id;
            swh.ClockIn(swh);
            Session["TimeClockIn"] = swh.TimeIn;


            Response.Redirect(Request.RawUrl);







        }

        protected void ButtonClockOut_Click(object sender, EventArgs e)
        {
            List<StaffWorkHour> list = new List<StaffWorkHour>();
            string id = Session["staffId"] as string;

            StaffWorkHour swh = new StaffWorkHour();
            swh.TimeIn = (DateTime)Session["TimeClockIn"];
            swh.TimeOut = DateTime.Now;
            swh.StaffId = id;
            Session["TimeClockOut"] = swh.TimeOut;
            swh.ClockOut(swh);

            list.Add(swh);
            GridViewClockOut.DataSource = list;
            GridViewClockOut.DataBind();
            Session["TimeClockIn"] = swh.TimeOut;

            ButtonClockIn.Enabled = true;
            ButtonClockOut.Enabled = false;
        }

        protected void ButtonViewHistory_Click(object sender, EventArgs e)
        {
            List<StaffWorkHour> listSWH = new List<StaffWorkHour>();
            StaffWorkHour swh = new StaffWorkHour();
            listSWH = swh.GetAllStaffWorkHours();
            GridViewClockinHistory.DataSource = listSWH;
            GridViewClockinHistory.DataBind();


        }



    }
}