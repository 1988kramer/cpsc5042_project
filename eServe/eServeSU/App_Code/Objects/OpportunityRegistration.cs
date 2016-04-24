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
    public class OpportunityRegistration
    {
        public OpportunityRegistration()
        {
            //
            // TODO: Add constructor logic here
            //
            dbHelper = new DatabaseHelper();
            dbHelper.DbConnection = ConfigurationManager.ConnectionStrings["eServeConnection"].ConnectionString;
        }

        public int OpportunityID { get; set; }
        public string Position { get; set; }
        public string Organization { get; set; }
        public string Location { get; set; }
        public string SlotsAvailable { get; set; }
        public string DistanceFromSU { get; set; }
        public string MinimumAge { get; set; }
        public string CRCRequiredByPartner { get; set; }
        public string TimeCommittment { get; set; }
        public string JobDescription { get; set; }

        private DatabaseHelper dbHelper;

        public List<OpportunityRegistration> GetOpportunityListByStudentId(int studentId)
        {
            var reader = dbHelper.GetOpportunityRegistrationByStudentId(Constant.SP_GetOpportunityListByStudentId, studentId);

            List<OpportunityRegistration> regirationList = new List<OpportunityRegistration>();
            OpportunityRegistration opportunityRegistration = null;

            while (reader.Read())
            {
                opportunityRegistration = new OpportunityRegistration();

                opportunityRegistration.OpportunityID = Convert.ToInt32(reader["OpportunityID"]);
                opportunityRegistration.Position = reader["Position"].ToString();
                opportunityRegistration.Organization = reader["Organization"].ToString();
                opportunityRegistration.Location = reader["Location"].ToString();
                opportunityRegistration.SlotsAvailable = reader["SlotsAvailable"].ToString();
                opportunityRegistration.DistanceFromSU = reader["DistanceFromSU"].ToString();
                opportunityRegistration.MinimumAge = reader["MinimumAge"].ToString();
                opportunityRegistration.CRCRequiredByPartner = reader["CRCRequired"].ToString();
                opportunityRegistration.TimeCommittment = reader["TimeCommittment"].ToString();
                opportunityRegistration.JobDescription = reader["JobDescription"].ToString();

                regirationList.Add(opportunityRegistration);
            }

            return regirationList;
        }
    }
}
