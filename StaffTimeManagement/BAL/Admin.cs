using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StaffTimeManagement.DAL;

namespace StaffTimeManagement.BAL
{
    public class Admin
    {
        private string adminId;
        private string firstName;
        private string lastName;
        private string email;
        private string phoneNumber;

        public string AdminId { get => adminId; set => adminId = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Email { get => email; set => email = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }


        public List<Admin> GetAllAdmins()
        {
            return AdminDB.GetAllRecords();
        }

        public Admin GetAdminById(string id)
        {
            return AdminDB.SearchAdminWithId(id);
        }

        public List<Admin> GetAdminByIdWithLike(string id)
        {
            return AdminDB.SearchRecordByIdWithLike(id);
        }

        public void AddAdmin(Admin a)
        {
            AdminDB.AddRecord(a);
        }

        public void DeleteAdmin(Admin a)
        {
            AdminDB.DeleteRecord(a);
        }

        public void UpdateAdmin(Admin a)
        {
            AdminDB.UpdateRecord(a);
        }

    }
}