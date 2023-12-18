using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StaffTimeManagement.BAL;
using System.Data.SqlClient;

namespace StaffTimeManagement.DAL
{
    public class ManagerDB
    {
        public static List<Manager> GetAllRecords()
        {
            List<Manager> listOfM = new List<Manager>();
            SqlConnection conn = UtilityDB.GetDBConnection();
            SqlCommand cmdGetAll = new SqlCommand();
            cmdGetAll.Connection = conn;
            cmdGetAll.CommandText = "SELECT * FROM Managers ";
            Manager manager;
            SqlDataReader reader = cmdGetAll.ExecuteReader();
            while (reader.Read())
            {
                manager = new Manager();
                manager.ManagerId = reader["managerId"].ToString();
                manager.FirstName = reader["firstName"].ToString();
                manager.LastName = reader["lastName"].ToString();
                manager.Email = reader["email"].ToString();
                manager.PhoneNumber = reader["phoneNumber"].ToString();

                listOfM.Add(manager);
            }
            conn.Close();
            return listOfM;


        }


        public static Manager SearchManagerWithId(string id)
        {
            Manager manager = new Manager();
            SqlConnection conn = UtilityDB.GetDBConnection();
            SqlCommand cmdSearch = new SqlCommand();
            cmdSearch.Connection = conn;
            cmdSearch.CommandText = "SELECT * FROM Managers WHERE managerId = @ManagerId";
            cmdSearch.Parameters.AddWithValue("@ManagerId", id);
            SqlDataReader reader = cmdSearch.ExecuteReader();
            while (reader.Read())
            {
                manager.ManagerId = reader["managerId"].ToString();
                manager.FirstName = reader["firstName"].ToString();
                manager.LastName = reader["lastName"].ToString();
                manager.Email = reader["email"].ToString();
                manager.PhoneNumber = reader["phoneNumber"].ToString();

                conn.Close();
                return manager;
            }
            conn.Close();
            return null;



        }

        public static List<Manager> SearchRecordByIdWithLike(string id)
        {
            List<Manager> listM = new List<Manager>();
            SqlConnection conn = UtilityDB.GetDBConnection();
            SqlCommand cmdGetAll = new SqlCommand();
            cmdGetAll.Connection = conn;
            //cmdGetAll.CommandText = "SELECT * FROM Admins ";
            cmdGetAll.CommandText = "SELECT * FROM Managers WHERE managerId LIKE '%' + @input + '%' ";

            cmdGetAll.Parameters.AddWithValue("@input", id);
            Manager manager;
            SqlDataReader reader = cmdGetAll.ExecuteReader();
            while (reader.Read())
            {
                manager = new Manager();
                manager.ManagerId = reader["managerId"].ToString();
                manager.FirstName = reader["firstName"].ToString();
                manager.LastName = reader["lastName"].ToString();
                manager.Email = reader["email"].ToString();
                manager.PhoneNumber = reader["phoneNumber"].ToString();

                listM.Add(manager);
            }
            conn.Close();
            return listM;
        }


        public static void AddRecord(Manager u)
        {
            SqlConnection conn = UtilityDB.GetDBConnection();
            SqlCommand cmdAdd = new SqlCommand();
            cmdAdd.Connection = conn;
            cmdAdd.CommandText = "INSERT INTO Managers VALUES (@ManagerId, @FirstName, @LastName, @Email, @PhoneNumber)";
            cmdAdd.Parameters.AddWithValue("@ManagerId", u.ManagerId);
            cmdAdd.Parameters.AddWithValue("@FirstName", u.FirstName);
            cmdAdd.Parameters.AddWithValue("@LastName", u.LastName);
            cmdAdd.Parameters.AddWithValue("@Email", u.Email);
            cmdAdd.Parameters.AddWithValue("@PhoneNumber", u.PhoneNumber);
            cmdAdd.ExecuteNonQuery();

        }

        public static void DeleteRecord(Manager u)
        {
            SqlConnection conn = UtilityDB.GetDBConnection();
            SqlCommand cmdDelete = new SqlCommand();
            cmdDelete.Connection = conn;
            cmdDelete.CommandText = "DELETE FROM Managers WHERE managerId = @ManagerId";
            cmdDelete.Parameters.AddWithValue("@ManagerId", u.ManagerId);
            cmdDelete.ExecuteNonQuery();
        }

        public static void UpdateRecord(Manager u)
        {
            SqlConnection conn = UtilityDB.GetDBConnection();
            SqlCommand cmdUpdate = new SqlCommand();
            cmdUpdate.Connection = conn;
            cmdUpdate.CommandText = "UPDATE Managers SET firstName = @FirstName, lastName= @LastName, email = @Email, phoneNumber = @PhoneNumber WHERE managerId = @ManagerId";
            cmdUpdate.Parameters.AddWithValue("@ManagerId", u.ManagerId);
            cmdUpdate.Parameters.AddWithValue("@FirstName", u.FirstName);
            cmdUpdate.Parameters.AddWithValue("@LastName", u.LastName);
            cmdUpdate.Parameters.AddWithValue("@Email", u.Email);
            cmdUpdate.Parameters.AddWithValue("@PhoneNumber", u.PhoneNumber);
            cmdUpdate.ExecuteNonQuery();


        }
    }
}