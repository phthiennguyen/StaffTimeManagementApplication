using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using StaffTimeManagement.BAL;

namespace StaffTimeManagement.DAL
{
    public class User_StaffDB
    {

        public static User_Staff SearchUser(User_Staff uS)
        {
            SqlConnection conn = UtilityDB.GetDBConnection();
            SqlCommand cmdSearch = new SqlCommand();
            cmdSearch.Connection = conn;
            cmdSearch.CommandText = "SELECT * FROM Users_Staffs WHERE UserName = @UserName AND Password= @Password";
            cmdSearch.Parameters.AddWithValue("@UserName", uS.UserName);
            cmdSearch.Parameters.AddWithValue("@Password", uS.Password);
            SqlDataReader reader = cmdSearch.ExecuteReader();
            if (reader.Read())
            {
                return uS;
            }
            conn.Close();
            return null;




        }

        public static User_Staff SearchUserWithId(User_Staff uS)
        {
            SqlConnection conn = UtilityDB.GetDBConnection();
            SqlCommand cmdSearch = new SqlCommand();
            cmdSearch.Connection = conn;
            cmdSearch.CommandText = "SELECT * FROM Users_Staffs WHERE UserName = @UserName";
            cmdSearch.Parameters.AddWithValue("@UserName", uS.UserName);
            SqlDataReader reader = cmdSearch.ExecuteReader();
            if (reader.Read())
            {
                uS.UserName = reader["userName"].ToString();
                uS.Password = reader["password"].ToString();
                uS.StaffId = reader["staffId"].ToString();
                return uS;
            }
            conn.Close();
            return null;




        }

        public static void AddRecord(User_Staff u)
        {
            SqlConnection conn = UtilityDB.GetDBConnection();
            SqlCommand cmdAdd = new SqlCommand();
            cmdAdd.Connection = conn;
            cmdAdd.CommandText = "INSERT INTO Users_Staffs VALUES (@username, @password, @staffId)";
            cmdAdd.Parameters.AddWithValue("@username", u.UserName);
            cmdAdd.Parameters.AddWithValue("@password", u.Password);
            cmdAdd.Parameters.AddWithValue("@staffId", u.StaffId);
            cmdAdd.ExecuteNonQuery();

        }

        public static void DeleteRecord(User_Staff u)
        {
            SqlConnection conn = UtilityDB.GetDBConnection();
            SqlCommand cmdDelete = new SqlCommand();
            cmdDelete.Connection = conn;
            cmdDelete.CommandText = "DELETE FROM Users_Staffs WHERE userName = @UserName";
            cmdDelete.Parameters.AddWithValue("@UserName", u.UserName);
            cmdDelete.ExecuteNonQuery();
        }

        public static void UpdateRecord(User_Staff u)
        {
            SqlConnection conn = UtilityDB.GetDBConnection();
            SqlCommand cmdUpdate = new SqlCommand();
            cmdUpdate.Connection = conn;
            cmdUpdate.CommandText = "UPDATE Users_Staffs SET password = @Password WHERE userName = @UserName";
            cmdUpdate.Parameters.AddWithValue("@UserName", u.UserName);
            cmdUpdate.Parameters.AddWithValue("@Password", u.Password);
            cmdUpdate.ExecuteNonQuery();


        }
    }
}