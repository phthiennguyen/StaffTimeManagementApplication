using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StaffTimeManagement.BAL;
using System.Data.SqlClient;

namespace StaffTimeManagement.DAL
{
    public class AdminDB
    {
        public static List<Admin> GetAllRecords()
        {
            List<Admin> listOfA = new List<Admin>();
            SqlConnection conn = UtilityDB.GetDBConnection();
            SqlCommand cmdGetAll = new SqlCommand();
            cmdGetAll.Connection = conn;
            cmdGetAll.CommandText = "SELECT * FROM Admins ";
            Admin admin;
            SqlDataReader reader = cmdGetAll.ExecuteReader();
            while (reader.Read())
            {
                admin = new Admin();
                admin.AdminId = reader["adminId"].ToString();
                admin.FirstName = reader["firstName"].ToString();
                admin.LastName = reader["lastName"].ToString();
                admin.Email = reader["email"].ToString();
                admin.PhoneNumber = reader["phoneNumber"].ToString();
                
                listOfA.Add(admin);
            }
            conn.Close();
            return listOfA;


        }

        public static Admin SearchAdminWithId(string id)
        {
            Admin admin = new Admin();
            SqlConnection conn = UtilityDB.GetDBConnection();
            SqlCommand cmdSearch = new SqlCommand();
            cmdSearch.Connection = conn;
            cmdSearch.CommandText = "SELECT * FROM Admins WHERE adminId = @AdminId";
            cmdSearch.Parameters.AddWithValue("@AdminId", id);
            SqlDataReader reader = cmdSearch.ExecuteReader();
            while (reader.Read())
            {
                admin.AdminId = reader["adminId"].ToString();
                admin.FirstName = reader["firstName"].ToString();
                admin.LastName = reader["lastName"].ToString();
                admin.Email = reader["email"].ToString();
                admin.PhoneNumber = reader["phoneNumber"].ToString();
                
                conn.Close();
                return admin;
            }
            conn.Close();
            return null;



        }


        public static List<Admin> SearchRecordByIdWithLike(string id)
        {
            List<Admin> listA = new List<Admin>();
            SqlConnection conn = UtilityDB.GetDBConnection();
            SqlCommand cmdGetAll = new SqlCommand();
            cmdGetAll.Connection = conn;
            //cmdGetAll.CommandText = "SELECT * FROM Admins ";
            cmdGetAll.CommandText = "SELECT * FROM Admins WHERE adminId LIKE '%' + @input + '%' ";
            
            cmdGetAll.Parameters.AddWithValue("@input", id);
            Admin admin;
            SqlDataReader reader = cmdGetAll.ExecuteReader();
            while (reader.Read())
            {
                admin = new Admin();
                admin.AdminId = reader["adminId"].ToString();
                admin.FirstName = reader["firstName"].ToString();
                admin.LastName = reader["lastName"].ToString();
                admin.Email = reader["email"].ToString();
                admin.PhoneNumber = reader["phoneNumber"].ToString();

                listA.Add(admin);
            }
            conn.Close();
            return listA;
        }


        public static void AddRecord(Admin u)
        {
            SqlConnection conn = UtilityDB.GetDBConnection();
            SqlCommand cmdAdd = new SqlCommand();
            cmdAdd.Connection = conn;
            cmdAdd.CommandText = "INSERT INTO Admins VALUES (@AdminId, @FirstName, @LastName, @Email, @PhoneNumber)";
            cmdAdd.Parameters.AddWithValue("@AdminId", u.AdminId);
            cmdAdd.Parameters.AddWithValue("@FirstName", u.FirstName);
            cmdAdd.Parameters.AddWithValue("@LastName", u.LastName);
            cmdAdd.Parameters.AddWithValue("@Email", u.Email);
            cmdAdd.Parameters.AddWithValue("@PhoneNumber", u.PhoneNumber);
            cmdAdd.ExecuteNonQuery();

        }

        public static void DeleteRecord(Admin u)
        {
            SqlConnection conn = UtilityDB.GetDBConnection();
            SqlCommand cmdDelete = new SqlCommand();
            cmdDelete.Connection = conn;
            cmdDelete.CommandText = "DELETE FROM Admins WHERE adminId = @AdminId";
            cmdDelete.Parameters.AddWithValue("@AdminId", u.AdminId);
            cmdDelete.ExecuteNonQuery();
        }

        public static void UpdateRecord(Admin u)
        {
            SqlConnection conn = UtilityDB.GetDBConnection();
            SqlCommand cmdUpdate = new SqlCommand();
            cmdUpdate.Connection = conn;
            cmdUpdate.CommandText = "UPDATE Admins SET firstName = @FirstName, lastName= @LastName, email = @Email, phoneNumber = @PhoneNumber WHERE adminId = @AdminId";
            cmdUpdate.Parameters.AddWithValue("@AdminId", u.AdminId);
            cmdUpdate.Parameters.AddWithValue("@FirstName", u.FirstName);
            cmdUpdate.Parameters.AddWithValue("@LastName", u.LastName);
            cmdUpdate.Parameters.AddWithValue("@Email", u.Email);
            cmdUpdate.Parameters.AddWithValue("@PhoneNumber", u.PhoneNumber);
            cmdUpdate.ExecuteNonQuery();


        }

    }
}