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
    /// Summary description for Faculty
    /// </summary>
    public class Faculty
    {
        public Faculty()
        {
            //
            // TODO: Add constructor logic here
            //
            dbHelper = new DatabaseHelper();
            dbHelper.DbConnection = ConfigurationManager.ConnectionStrings["eServeConnection"].ConnectionString;
        }

        private int studentID;
        private int opportunityID;
        
        private DatabaseHelper dbHelper;

        public string StudentName { get; set; }

        public string OpportunityName { get; set; }

        public string OrganizationName { get; set; }

        public string SupervisorName { get; set; }

        public string SectionName { get; set; }

        public int HoursCompleted { get; set; }

        public int HoursApproved { get; set; }

        public int StudentID
        {
            get { return this.studentID; }
            set { this.studentID = value; }
        }

        public int OpportunityID
        {
            get { return this.opportunityID; }
            set { this.opportunityID = value; }
        }

        public string OppID_StudentID
        {
            get { return this.opportunityID.ToString() + "_" + this.studentID.ToString(); }
        }

        public string Question1 { get; set; }
        public string Question2 { get; set; }
        public string Question3 { get; set; }
        public string Question4 { get; set; }
        public string Comments { get; set; }
        public string Rate1 { get; set; }
        public string Rate2 { get; set; }
        public string Rate3 { get; set; }
        public string Rate4 { get; set; }
        public string Rate5 { get; set; }
        public string Rate6 { get; set; }


        public List<Faculty> GetStudentCourseOppListForFaculty(int professorId)
        {
            var reader = dbHelper.GetStudentCourseOppDetailForFaculty(Constant.sp_GetStudentCourseOppDetailForFaculty, professorId);

            List<Faculty> facOppList = new List<Faculty>();
            Faculty fac = null;

            while (reader.Read())
            {
                fac = new Faculty();
                fac.OpportunityID = Convert.ToInt32(reader["OpportunityId"]);
                fac.StudentID = Convert.ToInt32(reader["StudentId"]);
                fac.StudentName = reader["StudentName"].ToString();
                fac.OpportunityName = reader["OpportunityName"].ToString();
                fac.SectionName = reader["SectionName"].ToString();
                fac.HoursCompleted = Convert.ToInt32(reader["HoursCompleted"]);
                fac.HoursApproved = Convert.ToInt32(reader["HoursApproved"]);

                facOppList.Add(fac);
            }

            return facOppList;
        }

        public Faculty GetPartnerEvaluation(int studentId, int opportunityId)
        {
            var reader = dbHelper.GetPartnerEvaluationByStudentIDOppID(Constant.sp_GetPartnerEvaluationByStudentIDOppID, studentId, opportunityId);
            
            Faculty fac = null;

            while (reader.Read())
            {
                fac = new Faculty();
                fac.StudentName = reader["StudentName"].ToString();
                fac.OrganizationName = reader["OrganizationName"].ToString();
                fac.SupervisorName = reader["SupervisorName"].ToString();
                fac.Question1 = reader["Question1"].ToString();
                fac.Question2 = reader["Question2"].ToString();
                fac.Question3 = reader["Question3"].ToString();
                fac.Question4 = reader["Question4"].ToString();
                fac.Rate1 = reader["Rate1"].ToString();
                fac.Rate2 = reader["Rate2"].ToString();
                fac.Rate3 = reader["Rate3"].ToString();
                fac.Rate4 = reader["Rate4"].ToString();
                fac.Rate5 = reader["Rate5"].ToString();
                fac.Rate6 = reader["Rate6"].ToString();
            }

            return fac;
        }

        public Faculty GetStudentEvaluation(int studentId, int opportunityId)
        {
            var reader = dbHelper.GetStudentEvaluationByStudentIDOppID(Constant.sp_GetStudentEvaluationByStudentIDOppID, studentId, opportunityId);

            Faculty fac = null;

            while (reader.Read())
            {
                fac = new Faculty();
                fac.OrganizationName = reader["OrganizationName"].ToString();
                fac.Question1 = reader["Answer1"].ToString();
                fac.Question2 = reader["Answer2"].ToString();
                fac.Question3 = reader["Answer3"].ToString();
                fac.Question4 = reader["Answer4"].ToString();
                fac.Rate1 = reader["Rate1"].ToString();
                fac.Rate2 = reader["Rate2"].ToString();
                fac.Rate3 = reader["Rate3"].ToString();
                fac.Rate4 = reader["Rate4"].ToString();
                fac.Rate5 = reader["Rate5"].ToString();
                fac.Rate6 = reader["Rate6"].ToString();
                fac.Comments = reader["Comments"].ToString();
            }

            return fac;
        }
    }
}