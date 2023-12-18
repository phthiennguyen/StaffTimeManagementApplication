using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StaffTimeManagement.DAL;

namespace StaffTimeManagement.BAL
{
    public class User_Admin
    {
        private string userName;
        private string password;
        private string adminId;

        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public string AdminId { get => adminId; set => adminId = value; }


        public User_Admin GetUserAdmin (User_Admin uA)
        {
            return User_AdminDB.SearchUser(uA);
        }

        public User_Admin GetUserAdminById(User_Admin uA)
        {
            return User_AdminDB.SearchUserWithId(uA);
        }
        public void AddAdmin(User_Admin u)
        {
            User_AdminDB.AddRecord(u);
        }
        public void DeleteUserAdmin(User_Admin uA)
        {
            User_AdminDB.DeleteRecord(uA);
        }

        public void UpdateUserAdmin(User_Admin uA)
        {
            User_AdminDB.UpdateRecord(uA);
        }

    }
}