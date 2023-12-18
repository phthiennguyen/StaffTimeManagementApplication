using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StaffTimeManagement.DAL;

namespace StaffTimeManagement.BAL
{
    public class Manager
    {
        private string managerId;
        private string firstName;
        private string lastName;
        private string email;
        private string phoneNumber;

        public string ManagerId { get => managerId; set => managerId = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Email { get => email; set => email = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }


        public List<Manager> GetAllManagers()
        {
            return ManagerDB.GetAllRecords();
        }

        public Manager GetManagerById(string id)
        {
            return ManagerDB.SearchManagerWithId(id);
        }
        public List<Manager> GetManagerByIdWithLike(string id)
        {
            return ManagerDB.SearchRecordByIdWithLike(id);
        }


        public void AddManager(Manager m)
        {
            ManagerDB.AddRecord(m);
        }

        public void DeleteManager(Manager m)
        {
            ManagerDB.DeleteRecord(m);
        }

        public void UpdateManager(Manager a)
        {
            ManagerDB.UpdateRecord(a);
        }
    }
}