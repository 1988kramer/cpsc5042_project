using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Web;

namespace eServeSU
{
    /// <summary>
    /// Summary description for OpportunityRegistered
    /// </summary>
    public class StudentTimeEntry
    {
        public StudentTimeEntry()
        {
            //
            // TODO: Add constructor logic here
            //
            dbHelper = new DatabaseHelper();
            dbHelper.DbConnection = ConfigurationManager.ConnectionStrings["eServeConnection"].ConnectionString;
        }

        public string  WorkDate { get; set; }
        public int OpportunityID { get; set; }
        public int StudentID { get; set; }
        public int CPPID { get; set; }
        public int PartnerApprovedHours { get; set; }
        public string TimeEntryDate { get; set; }
        public int HoursVolunteered { get; set; }

        private DatabaseHelper dbHelper;

        public void SubmitStudentTimeEntry(StudentTimeEntry studentTimeEntry)
        {
            dbHelper.SubmitStudentTimeEntry(Constant.SP_AddTimeEntries, studentTimeEntry.WorkDate, studentTimeEntry.OpportunityID, studentTimeEntry.StudentID,
                                                        studentTimeEntry.CPPID, studentTimeEntry.PartnerApprovedHours, studentTimeEntry.TimeEntryDate, studentTimeEntry.HoursVolunteered);
        }

        public List<StudentTimeEntry> GetStudentTimeEntriesByOpportunityId(int studentId, int opportunityId)
        {
            var reader = dbHelper.GetStudentTimeEntriesByOpportunityID(Constant.SP_GetStudentTimeEntriesByOpportunityID, studentId, opportunityId);

            List<StudentTimeEntry> studentTimeEntryList = new List<StudentTimeEntry>();
            StudentTimeEntry studentTimeEntry = null;

            while (reader.Read())
            {
                studentTimeEntry = new StudentTimeEntry();

                studentTimeEntry.WorkDate = reader["WorkDate"].ToString();
                studentTimeEntry.HoursVolunteered = Convert.ToInt32(reader["HoursVolunteered"]);
                //studentTimeEntry.PartnerApprovedHours = Convert.ToInt32(reader["PartnerApprovedHours"]);
                studentTimeEntryList.Add(studentTimeEntry);
            }

            return studentTimeEntryList;
        }

        public List<StudentTimeEntry> GetTimeEntries(int studentId, int opportunityId)
        {
            var reader = dbHelper.GetTimeEntries(Constant.SP_GetTimeEntries, studentId, opportunityId);

            List<StudentTimeEntry> studentTimeEntryList = new List<StudentTimeEntry>();
            StudentTimeEntry studentTimeEntry = null;

            while (reader.Read())
            {
                studentTimeEntry = new StudentTimeEntry();

                studentTimeEntry.WorkDate = reader["WorkDate"].ToString();
                studentTimeEntry.HoursVolunteered = Convert.ToInt32(reader["HoursVolunteered"]);
                studentTimeEntry.PartnerApprovedHours = Convert.ToInt32(reader["PartnerApprovedHours"]);
                studentTimeEntryList.Add(studentTimeEntry);
            }

            return studentTimeEntryList;
        }

        public void UpdatePartnerHours()
        {
            dbHelper.UpdateTimeEntries(Constant.SP_UpdateTimeEntries, this.OpportunityID, this.StudentID,Convert.ToDateTime (this.WorkDate),this.PartnerApprovedHours);
        }
    }
}
