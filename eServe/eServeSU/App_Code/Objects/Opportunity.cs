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
    /// Summary description for Opportunity
    /// </summary>
    public class Opportunity
    {
        public Opportunity()
        {
            //
            // TODO: Add constructor logic here
            //
            dbHelper = new DatabaseHelper();
            dbHelper.DbConnection = ConfigurationManager.ConnectionStrings["eServeConnection"].ConnectionString;
        }

        private String name;
        private String location;
        private int oppId;
        private String jobDescription;
        private DateTime dateApproved;
        private string requirement;
        private string timeCommittment;
        private int totalNumberSlots;
        private DateTime orientationDate;
        private string status;
        private string resumeRequired;
        private string minimumAge;
        private string crcRequiredByPartner;
        private string crcRequiredBySU;
        private string linkToOnlineApp;
        private OpportunityType type;
        private CommunityPartner cp;
        private CommunityPartnersPeople cpp;
        private Quarter quarter;
        private string opportunityTypeName;
        private string organizationName;
        private int opportunityTypeId;
        private int cpId;
        private int cppId;
        private int quarterId;
        private string supervisor;
        private string supervisorEmail;
        private string jobHours;
        private string distanceFromSU;

        private DatabaseHelper dbHelper;

        public String Name
        {
            get { return this.name; }
            set
            {
                try
                {
                    this.name = value;

                    if (this.name == "")
                    {
                        throw new Exception(
                            "Please provide name ...");
                    }
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
        }

        public String Location
        {
            get { return this.location; }
            set
            {
                this.location = value;
                if (this.location == "")
                {
                    throw new Exception("Please provide location ...");
                }

            }
        }

        public String OrganizationName
        {
            get { return this.organizationName; }
            set
            {
                this.organizationName = value;
                if (this.organizationName == "")
                {
                    throw new Exception("Please provide organization name ...");
                }

            }
        }

        public int OpportunityId
        {
            get { return this.oppId; }
            set
            {
                this.oppId = value;
                if (this.oppId == 0)
                {
                    throw new Exception("Please provide opportunity Id ...");
                }
            }
        }

        public String JobDescription
        {
            get { return this.jobDescription; }
            set
            {
                this.jobDescription = value;

                if (this.jobDescription == "")
                {
                    throw new Exception("Please provide job description ...");
                }
            }
        }

        public string DateApprovedForDisplay
        {
            get
            {
                if (this.Status == "Open")
                    return ((DateTime) this.DateApproved).ToString("d", DateTimeFormatInfo.InvariantInfo);
                else
                    return string.Empty;
            }
        }

        public String ShortJobDescription
        {
            get
            {
                if (!string.IsNullOrEmpty(this.jobDescription) && this.jobDescription.Length > 60)
                    return string.Format("{0}......", this.jobDescription.Substring(0, 60));
                else
                {
                    return this.jobDescription;
                }
            }
        }

        public DateTime DateApproved
        {
            get { return this.dateApproved; }
            set { this.dateApproved = value; }
        }

        public DateTime OrientationDate
        {
            get { return this.orientationDate; }
            set { this.orientationDate = value; }
        }

        public string Requirement
        {
            get { return this.requirement; }
            set
            {
                try
                {
                    this.requirement = value;

                    if (this.requirement == "")
                    {
                        throw new Exception(
                            "Please provide requirement ...");
                    }
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
        }

        public string TimeCommittment
        {
            get { return this.timeCommittment; }
            set
            {
                try
                {
                    this.timeCommittment = value;

                    if (this.timeCommittment == "")
                    {
                        throw new Exception(
                            "Please provide timeCommittment ...");
                    }
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
        }

        public string LinkToOnlineApp
        {
            get { return this.linkToOnlineApp; }
            set { this.linkToOnlineApp = value; }
        }

        public string DistanceFromSU
        {
            get { return this.distanceFromSU; }
            set { this.distanceFromSU = value; }
        }

        public int TotalNumberSlots
        {
            get { return this.totalNumberSlots; }
            set { this.totalNumberSlots = value; }
        }

        public string Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        public string CrcRequiredByPartner
        {
            get { return this.crcRequiredByPartner; }
            set { this.crcRequiredByPartner = value; }
        }

        public string CrcRequiredBySU
        {
            get { return this.crcRequiredBySU; }
            set { this.crcRequiredBySU = value; }
        }

        public string JobHours
        {
            get { return this.jobHours; }
            set { this.jobHours = value; }
        }

        public int OpportunityTypeId
        {
            get { return this.opportunityTypeId; }
            set { this.opportunityTypeId = value; }
        }

        public int CPPId
        {
            get { return this.cppId; }
            set { this.cppId = value; }
        }

        public int CPId
        {
            get { return this.cpId; }
            set { this.cpId = value; }
        }

        public int QuarterId
        {
            get { return this.quarterId; }
            set { this.quarterId = value; }
        }

        public OpportunityType Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        public CommunityPartner CP
        {
            get { return this.cp; }
            set { this.cp = value; }
        }

        public CommunityPartnersPeople CPP
        {
            get { return this.cpp; }
            set { this.cpp = value; }
        }

        public Quarter QuarterName
        {
            get { return this.quarter; }
            set { this.quarter = value; }
        }

        public string OpportunityTypeName
        {
            get { return this.opportunityTypeName; }
            set { this.opportunityTypeName = value; }
        }

        public string SupervisorName
        {
            get { return this.supervisor; }
            set { this.supervisor = value; }
        }

        public string SupervisorEmail
        {
            get { return this.supervisorEmail; }
            set { this.supervisorEmail = value; }
        }

        public string MinimumAge
        {
            get { return this.minimumAge; }
            set
            {
                this.minimumAge = value;
                if (this.minimumAge == "")
                    this.minimumAge = "0";
            }
        }

        public string ResumeRequired
        {
            get { return this.resumeRequired; }
            set
            {
                try
                {
                    this.resumeRequired = value;

                    if (this.resumeRequired == "")
                    {
                        throw new Exception(
                            "Please provide if resume Required ...");
                    }
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
        }

        public string CoursePanelId;
        public string CourseGridViewId;

        public void Add()
        {
            dbHelper.AddOpportunity(Constant.SP_AddOpportunit, this.Name, this.Location, this.JobDescription,
                this.Requirement, this.TimeCommittment,
                this.TotalNumberSlots, this.OrientationDate, this.ResumeRequired, this.MinimumAge,
                this.CrcRequiredByPartner,
                this.LinkToOnlineApp, this.OpportunityTypeId, this.CPId, this.CPPId, this.QuarterId, this.JobHours,
                this.DistanceFromSU);
        }

        public void Update()
        {
            dbHelper.UpdateOpportunity(Constant.SP_UpdateOpportunit, this.Name, this.Location, this.JobDescription,
                this.OpportunityId,
                this.Requirement, this.TimeCommittment,
                this.TotalNumberSlots, this.OrientationDate, this.ResumeRequired, this.MinimumAge,
                this.CrcRequiredByPartner,
                this.LinkToOnlineApp, this.OpportunityTypeId, this.CPId, this.CPPId, this.QuarterId, this.JobHours,
                this.DistanceFromSU);
        }

        public void Approve()
        {
            dbHelper.ApproveOpportunity(Constant.SP_AppoveOpportunityByAdmin, this.OpportunityId);
        }

        public void Delete()
        {
            dbHelper.DeleteOpportunity(Constant.SP_DeleteOpportunit, this.OpportunityId);
        }


        public Opportunity GetOneOpportunityById(int opportunityId)
        {
            var reader = dbHelper.GetOneOpportunityById(Constant.SP_GetOpportunityById, opportunityId);

            Opportunity opp = new Opportunity();

            while (reader.Read())
            {
                opp.OpportunityId = Convert.ToInt32(reader["OpportunityId"]);
                opp.Name = reader["Name"].ToString();
                opp.Location = reader["Location"].ToString();
                opp.jobDescription = reader["JobDescription"].ToString();
                opp.Status = reader["Status"].ToString();
                opp.CPId = Convert.ToInt32(reader["CPID"].ToString());
                opp.CPPId = Convert.ToInt32(reader["CPPID"].ToString());
                opp.OpportunityTypeId = Convert.ToInt32(reader["TypeId"].ToString());
                opp.QuarterId = Convert.ToInt32(reader["QuarterId"].ToString());
                opp.TotalNumberSlots = Convert.ToInt32(reader["TotalNumberOfSlots"]);
                opp.Requirement = reader["Requirements"].ToString();
                opp.TimeCommittment = reader["TimeCommittment"].ToString();
                opp.OrientationDate = Convert.ToDateTime(reader["OrientationDate"].ToString());
                opp.ResumeRequired = reader["ResumeRequired"].ToString();
                opp.MinimumAge = reader["MinimumAge"].ToString();
                opp.CrcRequiredByPartner = reader["CRCRequiredByPartner"].ToString();
                opp.LinkToOnlineApp = reader["LinkToOnlineApp"].ToString();
                opp.JobHours = reader["JobHours"].ToString();
                opp.DistanceFromSU = reader["DistanceFromSU"].ToString();
                opp.DateApproved = Convert.ToDateTime(reader["DateOfCreation"]);
            }

            return opp;
        }

        public List<Opportunity> GetAllOpportunities()
        {
            var reader = dbHelper.GetOpportunityList(Constant.SP_GetOpportunityList);

            List<Opportunity> oppList = new List<Opportunity>();
            Opportunity opp = null;

            while (reader.Read())
            {
                opp = new Opportunity();
                opp.OpportunityId = Convert.ToInt32(reader["OpportunityId"]);
                opp.Name = reader["Name"].ToString();
                opp.Location = reader["Location"].ToString();
                opp.OpportunityTypeName = reader["OpportunityTypeName"].ToString();
                opp.Status = reader["Status"].ToString();
                opp.SupervisorName = reader["Supervisor"].ToString();
                opp.DateApproved = Convert.ToDateTime(reader["DateApproved"]);

                oppList.Add(opp);
            }

            return oppList;
        }

        public List<Opportunity> GetOpportunityListForAdmin()
        {
            var reader = dbHelper.GetOpportunityListForAdmin(Constant.SP_GetOpportunityListForAdmin);

            List<Opportunity> oppList = new List<Opportunity>();
            Opportunity opp = null;

            while (reader.Read())
            {
                opp = new Opportunity();
                opp.OpportunityId = Convert.ToInt32(reader["OpportunityId"]);
                opp.OrganizationName = reader["OrganizationName"].ToString();
                opp.Name = reader["Name"].ToString();
                opp.TotalNumberSlots = Convert.ToInt32(reader["TotalNumberOfSlots"]);
                opp.Status = reader["Status"].ToString();
                opp.OpportunityTypeName = reader["OpportunityTypeName"].ToString();
                opp.SupervisorName = reader["Supervisor"].ToString();
                opp.SupervisorEmail = "mailto:" + reader["SuperVisorEmail"].ToString();
                opp.DateApproved = Convert.ToDateTime(reader["DateApproved"]);
                opp.CoursePanelId = "pnCourse" + opp.OpportunityId;
                opp.CourseGridViewId = "gvCourse" + opp.OpportunityId;

                oppList.Add(opp);
            }

            return oppList;
        }

        public List<Opportunity> GetOpportunityListForFaculty()
        {
            var reader = dbHelper.GetOpportunityListForAdmin(Constant.SP_GetOpportunityListForFaculty);

            List<Opportunity> oppList = new List<Opportunity>();
            Opportunity opp = null;

            while (reader.Read())
            {
                opp = new Opportunity();
                opp.OpportunityId = Convert.ToInt32(reader["OpportunityId"]);
                opp.OrganizationName = reader["OrganizationName"].ToString();
                opp.Name = reader["Name"].ToString();
                opp.TotalNumberSlots = Convert.ToInt32(reader["TotalNumberOfSlots"]);
                opp.Status = reader["Status"].ToString();
                opp.OpportunityTypeName = reader["OpportunityTypeName"].ToString();
                opp.SupervisorName = reader["Supervisor"].ToString();
                opp.SupervisorEmail = "mailto:" + reader["SuperVisorEmail"].ToString();
                opp.DateApproved = Convert.ToDateTime(reader["DateApproved"]);
                opp.CoursePanelId = "pnCourse" + opp.OpportunityId;
                opp.CourseGridViewId = "gvCourse" + opp.OpportunityId;

                oppList.Add(opp);
            }

            return oppList;
        }
    }
}