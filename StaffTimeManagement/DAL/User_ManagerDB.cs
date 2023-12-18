using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using StaffTimeManagement.BAL;

namespace StaffTimeManagement.DAL
{
    public class User_ManagerDB
    {
        public static User_Manager SearchUser(User_Manager uM)
        {
            SqlConnection conn = UtilityDB.GetDBConnection();
            SqlCommand cmdSearch = new SqlCommand();
            cmdSearch.Connection = conn;
            cmdSearch.CommandText = "SELECT * FROM Users_Managers WHERE UserName = @UserName AND Password= @Password";
            cmdSearch.Parameters.AddWithValue("@UserName", uM.UserName);
            cmdSearch.Parameters.AddWithValue("@Password", uM.Password);
            SqlDataReader reader = cmdSearch.ExecuteReader();
            if (reader.Read())
            {
                return uM;
            }
            conn.Close();
            return null;




        }

        public static User_Manager SearchUserWithId(User_Manager uM)
        {
            SqlConnection conn = UtilityDB.GetDBConnection();
            SqlCommand cmdSearch = new SqlCommand();
            cmdSearch.Connection = conn;
            cmdSearch.CommandText = "SELECT * FROM Users_Managers WHERE UserName = @UserName";
            cmdSearch.Parameters.AddWithValue("@UserName", uM.UserName);
            SqlDataReader reader = cmdSearch.ExecuteReader();
            if (reader.Read())
            {
                uM.UserName = reader["userName"].ToString();
                uM.Password = reader["password"].ToString();
                uM.ManagerId = reader["managerId"].ToString();
                return uM;
                
            }
            conn.Close();
            return null;




        }

        public static void AddRecord(User_Manager u)
        {
            SqlConnection conn = UtilityDB.GetDBConnection();
            SqlCommand cmdAdd = new SqlCommand();
            cmdAdd.Connection = conn;
            cmdAdd.CommandText = "INSERT INTO Users_Managers VALUES (@username, @password, @managerId)";
            cmdAdd.Parameters.AddWithValue("@username", u.UserName);
            cmdAdd.Parameters.AddWithValue("@password", u.Password);
            cmdAdd.Parameters.AddWithValue("@managerId", u.ManagerId);
            cmdAdd.ExecuteNonQuery();

        }

        public static void DeleteRecord(User_Manager u)
        {
            SqlConnection conn = UtilityDB.GetDBConnection();
            SqlCommand cmdDelete = new SqlCommand();
            cmdDelete.Connection = conn;
            cmdDelete.CommandText = "DELETE FROM Users_Managers WHERE userName = @UserName";
            cmdDelete.Parameters.AddWithValue("@UserName", u.UserName);
            cmdDelete.ExecuteNonQuery();
        }

        public static void UpdateRecord(User_Manager u)
        {
            SqlConnection conn = UtilityDB.GetDBConnection();
            SqlCommand cmdUpdate = new SqlCommand();
            cmdUpdate.Connection = conn;
            cmdUpdate.CommandText = "UPDATE Users_Managers SET password = @Password WHERE userName = @UserName";
            cmdUpdate.Parameters.AddWithValue("@UserName", u.UserName);
            cmdUpdate.Parameters.AddWithValue("@Password", u.Password);
            cmdUpdate.ExecuteNonQuery();


        }
    }
}