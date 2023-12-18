using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using StaffTimeManagement.BAL;

namespace StaffTimeManagement.DAL
{
    public class User_AdminDB
    {
        public static User_Admin SearchUser(User_Admin uA)
        {
            SqlConnection conn = UtilityDB.GetDBConnection();
            SqlCommand cmdSearch = new SqlCommand();
            cmdSearch.Connection = conn;
            cmdSearch.CommandText = "SELECT * FROM Users_Admins WHERE UserName = @UserName AND Password= @Password";
            cmdSearch.Parameters.AddWithValue("@UserName", uA.UserName);
            cmdSearch.Parameters.AddWithValue("@Password", uA.Password);
            SqlDataReader reader = cmdSearch.ExecuteReader();
            if (reader.Read())
            {
                return uA;
            }
            conn.Close();
            return null;




        }

        public static User_Admin SearchUserWithId(User_Admin uA)
        {
            SqlConnection conn = UtilityDB.GetDBConnection();
            SqlCommand cmdSearch = new SqlCommand();
            cmdSearch.Connection = conn;
            cmdSearch.CommandText = "SELECT * FROM Users_Admins WHERE UserName = @UserName";
            cmdSearch.Parameters.AddWithValue("@UserName", uA.UserName);
            SqlDataReader reader = cmdSearch.ExecuteReader();
            if (reader.Read())
            {
                uA.UserName = reader["userName"].ToString();
                uA.Password = reader["password"].ToString();
                uA.AdminId = reader["adminId"].ToString();
                return uA;
            }
            conn.Close();
            return null;




        }

        public static void AddRecord(User_Admin u)
        {
            SqlConnection conn = UtilityDB.GetDBConnection();
            SqlCommand cmdAdd = new SqlCommand();
            cmdAdd.Connection = conn;
            cmdAdd.CommandText = "INSERT INTO Users_Admins VALUES (@username, @password, @adminId)";
            cmdAdd.Parameters.AddWithValue("@username", u.UserName);
            cmdAdd.Parameters.AddWithValue("@password", u.Password);
            cmdAdd.Parameters.AddWithValue("@adminId", u.AdminId);
            cmdAdd.ExecuteNonQuery();

        }

        public static void DeleteRecord(User_Admin u)
        {
            SqlConnection conn = UtilityDB.GetDBConnection();
            SqlCommand cmdDelete = new SqlCommand();
            cmdDelete.Connection = conn;
            cmdDelete.CommandText = "DELETE FROM Users_Admins WHERE userName = @UserName";
            cmdDelete.Parameters.AddWithValue("@UserName", u.UserName);
            cmdDelete.ExecuteNonQuery();
        }

        public static void UpdateRecord(User_Admin u)
        {
            SqlConnection conn = UtilityDB.GetDBConnection();
            SqlCommand cmdUpdate = new SqlCommand();
            cmdUpdate.Connection = conn;
            cmdUpdate.CommandText = "UPDATE Users_Admins SET password = @Password WHERE userName = @UserName";
            cmdUpdate.Parameters.AddWithValue("@UserName", u.UserName);
            cmdUpdate.Parameters.AddWithValue("@Password", u.Password);
            cmdUpdate.ExecuteNonQuery();


        }
    }
}