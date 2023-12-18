using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StaffTimeManagement.BAL;
using System.Data.SqlClient;

namespace StaffTimeManagement.DAL
{
    public class StaffDB
    {

        public static List<Staff> GetAllRecords()
        {
            List<Staff> listOfS = new List<Staff>();
            SqlConnection conn = UtilityDB.GetDBConnection();
            SqlCommand cmdGetAll = new SqlCommand();
            cmdGetAll.Connection = conn;
            cmdGetAll.CommandText = "SELECT * FROM Staffs ";
            Staff staff;
            SqlDataReader reader = cmdGetAll.ExecuteReader();
            while (reader.Read())
            {
                staff = new Staff();
                staff.StaffId = reader["staffId"].ToString();
                staff.FirstName = reader["firstName"].ToString();
                staff.LastName = reader["lastName"].ToString();
                staff.Email = reader["email"].ToString();
                staff.PhoneNumber = reader["phoneNumber"].ToString();

                listOfS.Add(staff);
            }
            conn.Close();
            return listOfS;


        }

        public static Staff SearchStaffWithId(string id)
        {
            Staff staff = new Staff();
            SqlConnection conn = UtilityDB.GetDBConnection();
            SqlCommand cmdSearch = new SqlCommand();
            cmdSearch.Connection = conn;
            cmdSearch.CommandText = "SELECT * FROM Staffs WHERE staffId = @StaffId";
            cmdSearch.Parameters.AddWithValue("@StaffId", id);
            SqlDataReader reader = cmdSearch.ExecuteReader();
            while (reader.Read())
            {
                staff.StaffId = reader["staffId"].ToString();
                staff.FirstName = reader["firstName"].ToString();
                staff.LastName = reader["lastName"].ToString();
                staff.Email = reader["email"].ToString();
                staff.PhoneNumber = reader["phoneNumber"].ToString();

                conn.Close();
                return staff;
            }
            conn.Close();
            return null;



        }

        public static List<Staff> SearchRecordByIdWithLike(string id)
        {
            List<Staff> listS = new List<Staff>();
            SqlConnection conn = UtilityDB.GetDBConnection();
            SqlCommand cmdGetAll = new SqlCommand();
            cmdGetAll.Connection = conn;
            //cmdGetAll.CommandText = "SELECT * FROM Admins ";
            cmdGetAll.CommandText = "SELECT * FROM Staffs WHERE staffId LIKE '%' + @input + '%' ";

            cmdGetAll.Parameters.AddWithValue("@input", id);
            Staff staff;
            SqlDataReader reader = cmdGetAll.ExecuteReader();
            while (reader.Read())
            {
                staff = new Staff();
                staff.StaffId = reader["staffId"].ToString();
                staff.FirstName = reader["firstName"].ToString();
                staff.LastName = reader["lastName"].ToString();
                staff.Email = reader["email"].ToString();
                staff.PhoneNumber = reader["phoneNumber"].ToString();

                listS.Add(staff);
            }
            conn.Close();
            return listS;
        }


        public static void AddRecord(Staff u)
        {
            SqlConnection conn = UtilityDB.GetDBConnection();
            SqlCommand cmdAdd = new SqlCommand();
            cmdAdd.Connection = conn;
            cmdAdd.CommandText = "INSERT INTO Staffs VALUES (@StaffId, @FirstName, @LastName, @Email, @PhoneNumber)";
            cmdAdd.Parameters.AddWithValue("@StaffId", u.StaffId);
            cmdAdd.Parameters.AddWithValue("@FirstName", u.FirstName);
            cmdAdd.Parameters.AddWithValue("@LastName", u.LastName);
            cmdAdd.Parameters.AddWithValue("@Email", u.Email);
            cmdAdd.Parameters.AddWithValue("@PhoneNumber", u.PhoneNumber);
            cmdAdd.ExecuteNonQuery();

        }

        public static void DeleteRecord(Staff u)
        {
            SqlConnection conn = UtilityDB.GetDBConnection();
            SqlCommand cmdDelete = new SqlCommand();
            cmdDelete.Connection = conn;
            cmdDelete.CommandText = "DELETE FROM Staffs WHERE staffId = @StaffId";
            cmdDelete.Parameters.AddWithValue("@StaffId", u.StaffId);
            cmdDelete.ExecuteNonQuery();
        }

        public static void UpdateRecord(Staff u)
        {
            SqlConnection conn = UtilityDB.GetDBConnection();
            SqlCommand cmdUpdate = new SqlCommand();
            cmdUpdate.Connection = conn;
            cmdUpdate.CommandText = "UPDATE Staffs SET firstName = @FirstName, lastName= @LastName, email = @Email, phoneNumber = @PhoneNumber WHERE staffId = @StaffId";
            cmdUpdate.Parameters.AddWithValue("@StaffId", u.StaffId);
            cmdUpdate.Parameters.AddWithValue("@FirstName", u.FirstName);
            cmdUpdate.Parameters.AddWithValue("@LastName", u.LastName);
            cmdUpdate.Parameters.AddWithValue("@Email", u.Email);
            cmdUpdate.Parameters.AddWithValue("@PhoneNumber", u.PhoneNumber);
            cmdUpdate.ExecuteNonQuery();


        }

    }
}