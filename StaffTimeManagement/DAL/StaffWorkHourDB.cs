using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StaffTimeManagement.BAL;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StaffTimeManagement.DAL
{
    public class StaffWorkHourDB
    {
        public static List<StaffWorkHour> GetAllRecords()
        {
            List<StaffWorkHour> listOfSH = new List<StaffWorkHour>();
            SqlConnection conn = UtilityDB.GetDBConnection();
            SqlCommand cmdGetAll = new SqlCommand();
            cmdGetAll.Connection = conn;
            cmdGetAll.CommandText = "SELECT * FROM StaffWorkHours ";
            StaffWorkHour staffWH;
            SqlDataReader reader = cmdGetAll.ExecuteReader();
            while (reader.Read())
            {
                staffWH = new StaffWorkHour();
                staffWH.StaffId = reader["staffId"].ToString();
                staffWH.EntryId = Convert.ToInt32(reader["entryId"].ToString());
                //staffWH.TimeIn = Convert.ToDateTime(reader["timeIn"].ToString());
                staffWH.TimeIn = Convert.ToDateTime(reader["timeIn"].ToString());
                if (reader["timeOut"].ToString() == "")
                {
                    staffWH.TimeOut = null;
                }
                else
                {
                    staffWH.TimeOut = Convert.ToDateTime(reader["timeOut"].ToString());
                }
                
                staffWH.Date = Convert.ToDateTime(reader["date"].ToString());
                listOfSH.Add(staffWH);
            }
            conn.Close();
            return listOfSH;
        }

        public static void ClockIn(StaffWorkHour s)
        {
            SqlConnection conn = UtilityDB.GetDBConnection();
            SqlCommand cmdClockIn = new SqlCommand();
            cmdClockIn.Connection = conn;
            cmdClockIn.CommandText = "INSERT INTO StaffWorkHours(timeIn, staffId, date) VALUES( @TimeIn, @StaffId, @Date)";


            //DateTime timeIn = new DateTime(s.TimeIn.Year, s.TimeIn.Month, s.TimeIn.Day, s.TimeIn.Hour, s.TimeIn.Minute, s.TimeIn.Second);


            string timeInAsString = s.TimeIn.Value.ToString("yyyy-MM-dd HH:mm:ss.ff");

            
            cmdClockIn.Parameters.AddWithValue("@TimeIn", timeInAsString);
            cmdClockIn.Parameters.AddWithValue("@StaffId", s.StaffId);
            cmdClockIn.Parameters.AddWithValue("@Date", s.Date);
            cmdClockIn.ExecuteNonQuery();
        }

        public static void ClockOut(StaffWorkHour s)
        {
            SqlConnection conn = UtilityDB.GetDBConnection();
            SqlCommand cmdClockOut = new SqlCommand();
            cmdClockOut.Connection = conn;
            cmdClockOut.CommandText = "UPDATE StaffWorkHours SET timeOut = @TimeOut WHERE timeIn = @TimeIn AND staffId = @StaffId";
            
            //DateTime timeIn = new DateTime(s.TimeIn.Year, s.TimeIn.Month, s.TimeIn.Day, s.TimeIn.Hour, s.TimeIn.Minute, s.TimeIn.Second);
            //DateTime timeOut = new DateTime(s.TimeOut.Year, s.TimeOut.Month, s.TimeOut.Day, s.TimeOut.Hour, s.TimeOut.Minute, s.TimeOut.Second);


            string timeInAsString = s.TimeIn.Value.ToString("yyyy-MM-dd HH:mm:ss.ff");
            string timeOutAsString = s.TimeOut.Value.ToString("yyyy-MM-dd HH:mm:ss.ff");



            cmdClockOut.Parameters.AddWithValue("@TimeOut", timeOutAsString);
            cmdClockOut.Parameters.AddWithValue("@TimeIn", timeInAsString);
            cmdClockOut.Parameters.AddWithValue("@StaffId", s.StaffId);
            cmdClockOut.ExecuteNonQuery();

            

        }


        public static void DeleteRecord(StaffWorkHour s)
        {
            SqlConnection conn = UtilityDB.GetDBConnection();
            SqlCommand cmdDelete = new SqlCommand();
            cmdDelete.Connection = conn;
            cmdDelete.CommandText = "Delete From StaffWorkHours WHERE timeIn = @TimeIn AND staffId = @StaffId";

            string timeInAsString = s.TimeIn.Value.ToString("yyyy-MM-dd HH:mm:ss.ff");
            cmdDelete.Parameters.AddWithValue("@TimeIn", timeInAsString);
            cmdDelete.Parameters.AddWithValue("@StaffId", s.StaffId);
            cmdDelete.ExecuteNonQuery();

        }

        public static void DeleteAllRecordWithStaffId(StaffWorkHour s)
        {
            SqlConnection conn = UtilityDB.GetDBConnection();
            SqlCommand cmdDelete = new SqlCommand();
            cmdDelete.Connection = conn;
            cmdDelete.CommandText = "Delete From StaffWorkHours WHERE staffId = @StaffId";

            cmdDelete.Parameters.AddWithValue("@StaffId", s.StaffId);
            cmdDelete.ExecuteNonQuery();

        }




        public static StaffWorkHour GetStaffWorkHour(StaffWorkHour s)
        {
            SqlConnection conn = UtilityDB.GetDBConnection();
            SqlCommand cmdGet = new SqlCommand();
            cmdGet.Connection = conn;


            
            
            cmdGet.CommandText = "SELECT * FROM StaffWorkHours WHERE timeIn = @TimeIn AND staffId = @StaffId";

            string time = s.TimeIn.Value.ToString("yyyy-MM-dd HH:mm:ss.ff");

            cmdGet.Parameters.AddWithValue("@TimeIn", time);
            cmdGet.Parameters.AddWithValue("@StaffId", s.StaffId);
            SqlDataReader reader = cmdGet.ExecuteReader();
            StaffWorkHour swh = new StaffWorkHour();
            while (reader.Read())
            {
                swh.StaffId = reader["staffId"].ToString();
                swh.TimeIn = Convert.ToDateTime(reader["timeIn"].ToString());
                if (reader["timeOut"].ToString() != "")
                {

                    swh.TimeOut = Convert.ToDateTime(reader["timeOut"].ToString());
                }
                else
                {
                    swh.TimeOut = null;
                }

                swh.Date = Convert.ToDateTime(reader["date"].ToString());
                conn.Close();
                return swh;
            }
            conn.Close();
            return null;
        }

        public static StaffWorkHour test()
        {
            SqlConnection conn = UtilityDB.GetDBConnection();
            SqlCommand cmdGet = new SqlCommand();
            cmdGet.Connection = conn;


            cmdGet.CommandText = "SELECT * FROM StaffWorkHours WHERE entryId = 1";
            SqlDataReader reader = cmdGet.ExecuteReader();
            StaffWorkHour swh = new StaffWorkHour();
            while (reader.Read())
            {
                swh.StaffId = reader["staffId"].ToString();
                swh.TimeIn = Convert.ToDateTime(reader["timeIn"].ToString());
                if (reader["timeOut"] != null)
                {
                    swh.TimeOut = Convert.ToDateTime(reader["timeOut"].ToString());
                }

                swh.Date = Convert.ToDateTime(reader["date"].ToString());
                conn.Close();
                return swh;
            }
            conn.Close();
            return null;
        }

        public static List<StaffWorkHour> GetRecordsByStaffId(String s)
        {
            SqlConnection conn = UtilityDB.GetDBConnection();
            SqlCommand cmdGet = new SqlCommand();
            cmdGet.Connection = conn;
            cmdGet.CommandText = "SELECT * FROM StaffWorkHours WHERE staffId = @StaffId";
            cmdGet.Parameters.AddWithValue("@StaffId", s);
            SqlDataReader reader = cmdGet.ExecuteReader();
            StaffWorkHour swh;
            List<StaffWorkHour> list = new List<StaffWorkHour>();
            while (reader.Read())
            {
                swh = new StaffWorkHour();
                swh.StaffId = reader["staffId"].ToString();
                swh.TimeIn = Convert.ToDateTime(reader["timeIn"].ToString());
                if (reader["timeOut"].ToString() != "")
                {

                    swh.TimeOut = Convert.ToDateTime(reader["timeOut"].ToString());
                }
                else
                {
                    swh.TimeOut = null;
                }

                swh.Date = Convert.ToDateTime(reader["date"].ToString());
                list.Add(swh);
            }
            return list;
        }




    }
}