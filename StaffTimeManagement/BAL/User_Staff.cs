using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StaffTimeManagement.DAL;

namespace StaffTimeManagement.BAL
{
    public class User_Staff
    {
        private string userName;
        private string password;
        private string staffId;

        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public string StaffId { get => staffId; set => staffId = value; }

        public User_Staff GetUserStaff(User_Staff uS)
        {
            return User_StaffDB.SearchUser(uS);
        }

        public User_Staff GetUserStaffById(User_Staff uS)
        {
            return User_StaffDB.SearchUserWithId(uS);
        }

        public void AddStaff(User_Staff u)
        {
            User_StaffDB.AddRecord(u);
        }

        public void DeleteUserStaff(User_Staff u)
        {
            User_StaffDB.DeleteRecord(u);
        }
        public void UpdateUserStaff(User_Staff uA)
        {
            User_StaffDB.UpdateRecord(uA);
        }

    }
}