using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace eServeSU
{
    /// <summary>
    /// Summary description for Course Section
    /// </summary>
    public class OpportunitySectionStudent
    {
        public OpportunitySectionStudent()
        {
            //
            // TODO: Add constructor logic here
            //
            dbHelper = new DatabaseHelper();
            dbHelper.DbConnection = ConfigurationManager.ConnectionStrings["eServeConnection"].ConnectionString;
        }

        private int opportunityID;
        private string courseShortName;
        private string quarterShortName;
        private string sectionName;
        private string studentName;
        private string professorName;
        private string opportunityTypeName;
        private string opportunityName;
        private string organizationName;
        private string studentEmail;
        private string partnerApprovedHours;

        private DatabaseHelper dbHelper;

        public String OrganizationName
        {
            get { return this.organizationName; }
            set
            {
                try
                {
                    this.organizationName = value;

                    if (this.organizationName == "")
                    {
                        throw new Exception(
                            "Please provide organization name ...");
                    }
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
        }

        public String CourseShortName
        {
            get { return this.courseShortName; }
            set
            {
                try
                {
                    this.courseShortName = value;

                    if (this.courseShortName == "")
                    {
                        throw new Exception(
                            "Please provide course short name ...");
                    }
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
        }

        public String ProfessorName
        {
            get { return this.professorName; }
            set
            {
                try
                {
                    this.professorName = value;

                    if (this.professorName == "")
                    {
                        throw new Exception(
                            "Please provide professor name ...");
                    }
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
        }

        public String QuarterShortName
        {
            get { return this.quarterShortName; }
            set
            {
                try
                {
                    this.quarterShortName = value;

                    if (this.quarterShortName == "")
                    {
                        throw new Exception(
                            "Please provide quarter short name ...");
                    }
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
        }

        public String StudentName
        {
            get { return this.studentName; }
            set
            {
                try
                {
                    this.studentName = value;

                    if (this.studentName == "")
                    {
                        throw new Exception(
                            "Please provide student name");
                    }
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
        }

        public int OpportunityID
        {
            get { return this.opportunityID; }
            set
            {
                this.opportunityID = value;
                if (this.opportunityID == 0)
                {
                    throw new Exception("Please provide opportunity Id ...");
                }
            }
        }

        public String SectionName
        {
            get { return this.sectionName; }
            set
            {
                try
                {
                    this.sectionName = value;

                    if (this.sectionName == "")
                    {
                        throw new Exception(
                            "Please provide section name ...");
                    }
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
        }

        public String OpportunityName
        {
            get { return this.opportunityName; }
            set
            {
                try
                {
                    this.opportunityName = value;

                    if (this.opportunityName == "")
                    {
                        throw new Exception(
                            "Please provide opportunity name ...");
                    }
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
        }

        public String OpportunityTypeName
        {
            get { return this.opportunityTypeName; }
            set
            {
                try
                {
                    this.opportunityTypeName = value;

                    if (this.opportunityTypeName == "")
                    {
                        throw new Exception(
                            "Please provide opportunity type name ...");
                    }
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
        }

        public String StudentEmail
        {
            get { return this.studentEmail; }
            set
            {
                try
                {
                    this.studentEmail = value;

                    if (this.studentEmail == "")
                    {
                        throw new Exception(
                            "Please provide student email ...");
                    }
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
        }

        public String PartnerApprovedHours
        {
            get { return this.partnerApprovedHours; }
            set
            {
                try
                {
                    this.partnerApprovedHours = value;

                    if (this.partnerApprovedHours == "")
                    {
                        throw new Exception(
                            "Please provide partner approved hours ...");
                    }
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
        }

        public void AssignOpportunityToStudentByAdmin(int opportunityID, string studentEmail)
        {
            dbHelper.AssingnOpportunityToStudentByAdmin(Constant.sp_AssignOpportunityToStudentByAdmin, opportunityID, studentEmail);
        }

        public List<OpportunitySectionStudent> GetOpportunityStudentListReport(int quarterID)
        {
            var reader = dbHelper.GetOpportunityStudentListReport(Constant.sp_GetOpportunityStudentListReport, quarterID);

            List<OpportunitySectionStudent> opportunitySectionStudentList = new List<OpportunitySectionStudent>();
            OpportunitySectionStudent oppSectionStudent = null;

            while (reader.Read())
            {
                oppSectionStudent = new OpportunitySectionStudent();
                oppSectionStudent.OpportunityID = Convert.ToInt32(reader["OpportunityID"]);
                oppSectionStudent.OpportunityName = reader["OpportunityName"].ToString();
                oppSectionStudent.OrganizationName = reader["OrganizationName"].ToString();
                oppSectionStudent.OpportunityTypeName = reader["OpportunityTypeName"].ToString();
                oppSectionStudent.SectionName = reader["SectionName"].ToString();
                oppSectionStudent.CourseShortName = reader["CourseShortName"].ToString();
                oppSectionStudent.QuarterShortName = reader["QuarterShortName"].ToString();
                oppSectionStudent.ProfessorName = reader["ProfessorName"].ToString();
                oppSectionStudent.StudentName = reader["StudentName"].ToString();
                oppSectionStudent.StudentEmail = reader["StudentEmail"].ToString();
                oppSectionStudent.PartnerApprovedHours = reader["PartnerApprovedHours"].ToString();

                opportunitySectionStudentList.Add(oppSectionStudent);
            }

            return opportunitySectionStudentList;
        }
    }
}
