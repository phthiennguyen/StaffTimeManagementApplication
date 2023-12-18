using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StaffTimeManagement.DAL;

namespace StaffTimeManagement.BAL
{
    public class Staff
    {
        private string staffId;
        private string firstName;
        private string lastName;
        private string email;
        private string phoneNumber;

        public string StaffId { get => staffId; set => staffId = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Email { get => email; set => email = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }

        public List<Staff> GetAllStaffs()
        {
            return StaffDB.GetAllRecords();
        }
        public Staff GetStaffById(string id)
        {
            return StaffDB.SearchStaffWithId(id);
        }

        public List<Staff> GetStaffByIdWithLike(string id)
        {
            return StaffDB.SearchRecordByIdWithLike(id);
        }

        public void AddStaff(Staff s)
        {
            StaffDB.AddRecord(s);
        }

        public void DeleteStaff(Staff s)
        {
            StaffDB.DeleteRecord(s);
        }
        public void UpdateStaff(Staff a)
        {
            StaffDB.UpdateRecord(a);
        }
    }
}