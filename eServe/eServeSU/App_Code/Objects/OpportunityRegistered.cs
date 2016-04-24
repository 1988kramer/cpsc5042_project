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
    public class OpportunityRegistered
    {
        public OpportunityRegistered()
        {
            //
            // TODO: Add constructor logic here
            //
            dbHelper = new DatabaseHelper();
            dbHelper.DbConnection = ConfigurationManager.ConnectionStrings["eServeConnection"].ConnectionString;
        }

        public int OpportunityID { get; set; }
        public int StudentId { get; set; }
        public string Opportunity { get; set; }
        public string Course { get; set; }
        public string Quarter { get; set; }
        public string Organization { get; set; }
        public string EmailId { get; set; }
        public string Status { get; set; }
        public string HoursVolunteered { get; set; }
        public string ParternEvaluation { get; set; }
        public string StudentEvaluation { get; set; }
        public string StudentReflection { get; set; }

        private DatabaseHelper dbHelper;

        public List<OpportunityRegistered> GetOpportunityRegisteredByStudentId(int studentId)
        {
            var reader = dbHelper.GetRegisteredOpportunityByStudentId(Constant.SP_GetOpportunityRegisteredByStudentId, studentId);

            List<OpportunityRegistered> registeredList = new List<OpportunityRegistered>();
            OpportunityRegistered opportunityRegistered = null;

            while (reader.Read())
            {
                opportunityRegistered = new OpportunityRegistered();

                opportunityRegistered.OpportunityID = Convert.ToInt32(reader["OpportunityID"]);
                opportunityRegistered.StudentId = Convert.ToInt32(reader["StudentId"]);
                opportunityRegistered.Opportunity = reader["Opportunity"].ToString();
                opportunityRegistered.Course = reader["CourseName"].ToString();
                opportunityRegistered.Quarter = reader["Quarter"].ToString();
                opportunityRegistered.Organization = reader["Organization"].ToString();
                opportunityRegistered.EmailId = reader["EmailId"].ToString();
                opportunityRegistered.Status = reader["Status"].ToString();
                opportunityRegistered.HoursVolunteered = reader["HoursVolunteered"].ToString();
                opportunityRegistered.ParternEvaluation = reader["PartnerEvaluation"].ToString();
                opportunityRegistered.StudentEvaluation = reader["StudentEvaluation"].ToString();
                opportunityRegistered.StudentReflection = reader["StudentReflection"].ToString();

                registeredList.Add(opportunityRegistered);
            }

            return registeredList;
        }

        public bool RegisterOpportunity(int studentId, int opportunityId)
        {
            bool registrationStatus = true;
            var reader = dbHelper.RegisteredOpportunityByStudentAndOpportunityId(Constant.SP_RegisterStudentOpportunity, studentId, opportunityId);


            return registrationStatus;
        }
    }
}
