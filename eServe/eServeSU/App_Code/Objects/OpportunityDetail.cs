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
    public class OpportunityDetail
    {
        public OpportunityDetail()
        {
            //
            // TODO: Add constructor logic here
            //
            dbHelper = new DatabaseHelper();
            dbHelper.DbConnection = ConfigurationManager.ConnectionStrings["eServeConnection"].ConnectionString;
        }
        
        public int opportunityId { get; set; }
        public string OrganizationName { get; set; }
        public string OrganizationDesc { get; set; }
        public string OpportunityName { get; set; }
        public string OpportunityDesc { get; set; }
        public string SlotsAvailable { get; set; }
        public string DistanceFromSU { get; set; }       
        public string Location { get; set; }
        public string TimeCommittment { get; set; }
        public string SiteSupervisorName { get; set; }
        public string SiteSupervisorEmail { get; set; }
        public string BackgroundCheck { get; set; }
        public string MinimumAge { get; set; }
        public string Link { get; set; }
        public string OtherRequirements { get; set; }

        private DatabaseHelper dbHelper;

        public OpportunityDetail GetOpportunityDetailById(int opportunityId)
        {
            var reader = dbHelper.GetOpportunityDetailByOpportunityId(Constant.SP_GetOpportunityDetailByOpportunityId, opportunityId);
            List<OpportunityDetail> detailList = new List<OpportunityDetail>();
            OpportunityDetail opportunityDetail = null;
            
            while (reader.Read())
            {
                opportunityDetail = new OpportunityDetail();

                opportunityDetail.OrganizationName = reader["OrganizationName"].ToString();
                opportunityDetail.OrganizationDesc = reader["OrganizationDesc"].ToString();
                opportunityDetail.OpportunityName = reader["OpportunityName"].ToString();
                opportunityDetail.OpportunityDesc = reader["OpportunityDesc"].ToString();
                //opportunityDetail.SlotsAvailable = reader["SlotsAvailable"].ToString();
                //opportunityDetail.DistanceFromSU = reader["DistanceFromSU"].ToString();
                opportunityDetail.Location = reader["Location"].ToString();
                opportunityDetail.TimeCommittment = reader["TimeCommittment"].ToString();
                opportunityDetail.SiteSupervisorName = reader["SiteSupervisorName"].ToString();
                opportunityDetail.SiteSupervisorEmail = reader["SupervisorEmail"].ToString();
                opportunityDetail.BackgroundCheck = reader["MinimumAge"].ToString();
                opportunityDetail.MinimumAge = reader["MinimumAge"].ToString();
                opportunityDetail.Link = reader["Link"].ToString();
                opportunityDetail.OtherRequirements = "Resume";

                detailList.Add(opportunityDetail);
            }

            return opportunityDetail;
        }
    }
}
