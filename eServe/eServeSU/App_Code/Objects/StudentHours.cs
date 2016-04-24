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
    /// Summary description for 
    /// </summary>
    public class StudentHours
    {
        public StudentHours()
        {
            dbHelper = new DatabaseHelper();
            dbHelper.DbConnection = ConfigurationManager.ConnectionStrings["eServeConnection"].ConnectionString;
        }

        private DatabaseHelper dbHelper;
        public string HoursVolunteered { get; set; }
        public string PartnerApprovedHours { get; set; }

        public StudentHours GetVolunteeredAndPartnerApprovedHours(int studentId, int opportunityID)
        {
            var reader = dbHelper.GetVolunteeredAndPartnerApprovedHours(Constant.SP_GetStudentVolunteeredPartnerApprovedHoursByOpportunityId, studentId, opportunityID);
            
            StudentHours studentHours = new StudentHours();
            reader.Read();
            studentHours.HoursVolunteered = reader["HoursVolunteered"].ToString();
            studentHours.PartnerApprovedHours = reader["PartnerApprovedHours"].ToString();

            return studentHours;
        }
    }
}
