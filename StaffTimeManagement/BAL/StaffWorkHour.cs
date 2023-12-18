using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StaffTimeManagement.DAL;

namespace StaffTimeManagement.BAL
{
    public class StaffWorkHour
    {
        private int entryId;
        private DateTime? timeIn;
        private DateTime? timeOut;
        private string staffId;
        private DateTime? date;

        public int EntryId { get => entryId; set => entryId = value; }
        public DateTime? TimeIn { get => timeIn; set => timeIn = value; }
        public DateTime? TimeOut { get => timeOut; set => timeOut = value; }
        public string StaffId { get => staffId; set => staffId = value; }
        public DateTime? Date { get => date; set => date = value; }


        

        public List<StaffWorkHour> GetAllStaffWorkHours()
        {
            return StaffWorkHourDB.GetAllRecords();
        }

        public void ClockIn(StaffWorkHour s)
        {
            StaffWorkHourDB.ClockIn(s);
        }

        public void ClockOut(StaffWorkHour s)
        {
            StaffWorkHourDB.ClockOut(s);
        }

        public StaffWorkHour GetSWHWithStaffIdAndClockIn(StaffWorkHour s)
        {
            return StaffWorkHourDB.GetStaffWorkHour(s);
        }

        public StaffWorkHour test()
        {
            return StaffWorkHourDB.test();
        }

        public List<StaffWorkHour> GetSWHWithStaffId(string s)
        {
            return StaffWorkHourDB.GetRecordsByStaffId(s);
        }

        public void DeleteSWH(StaffWorkHour s)
        {
            StaffWorkHourDB.DeleteRecord(s);
        }

        public void DeleteSWHwithStaffId(StaffWorkHour s)
        {
            StaffWorkHourDB.DeleteAllRecordWithStaffId(s);
        }

    }
}