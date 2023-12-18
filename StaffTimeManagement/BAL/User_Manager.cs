using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StaffTimeManagement.DAL;

namespace StaffTimeManagement.BAL
{
    public class User_Manager
    {
        private string userName;
        private string password;
        private string managerId;

        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public string ManagerId { get => managerId; set => managerId = value; }


        public User_Manager GetUserManager(User_Manager uM)
        {
            return User_ManagerDB.SearchUser(uM);
        }

        public User_Manager GetUserManagerById(User_Manager uM)
        {
            return User_ManagerDB.SearchUserWithId(uM);
        }

        public void AddManager(User_Manager u)
        {
            User_ManagerDB.AddRecord(u);
        }

        public void DeleteUserManager(User_Manager u)
        {
            User_ManagerDB.DeleteRecord(u);
        }
        public void UpdateUserManager(User_Manager uA)
        {
            User_ManagerDB.UpdateRecord(uA);
        }
    }
}