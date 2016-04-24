using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace eServeSU
{
    public class PartnerEvaluation
    {

        private int cppID;
        private int cpID;
        
        private int opportunityID;
        private int studentID;
        private string organizationName;
        private string supervisorFirstName;   
        private string supervisorLastName;
        private string studentFirstName;
        private string studentLastName;
        private string hoursCompleted;
        private string question1;
        private string rate1;
        private string rate2;
        private string rate3;
        private string rate4;
        private string rate5;
        private string rate6;
        private string question2;
        private string question3;
        private string question4;
        private DatabaseHelper dbHelper;

        public PartnerEvaluation()

        { dbHelper = new DatabaseHelper();
            dbHelper.DbConnection = ConfigurationManager.ConnectionStrings["eServeConnection"].ConnectionString;
    }
        public int CPPID
        {
            get { return cppID; }
            set { cppID = value; }
        }

        public int CPID
        {
            get { return cpID; }
            set { cpID = value; }
        }
        public int OpportunityID
        {
            get { return opportunityID; }
            set { opportunityID = value; }
        }

        public int StudentID
        {
            get { return studentID; }
            set { studentID = value; }
        }
        public string OrganizationName
        {
            get { return organizationName; }
            set { organizationName = value; }
        }

        public string SupervisorFirstName
        {
            get { return supervisorFirstName; }
            set { supervisorFirstName = value; }
        }

        public string SupervisorLastName
        {
            get { return supervisorLastName; }
            set { supervisorLastName = value; }
        }

        public string SupervisorName
        {
            get { return supervisorFirstName + supervisorLastName; }
            
        }

        public string StudentFirstName
        {
            get { return studentFirstName; }
            set { studentFirstName = value; }
        }

        public string StudentLastName
        {
            get { return studentLastName; }
            set { studentLastName = value; }
        }

        public string StudentName
        {
            get { return studentFirstName + studentLastName; }
        }

        public string HoursCompleted
        {
            get { return hoursCompleted ; }
            set { hoursCompleted  = value; }
        }

        public string Question1
        {
            get { return question1; }
            set { question1 = value; }
        }

        public string Rate1
        {
            get { return rate1; }
            set { rate1 = value; }
        }
        public string Rate2
        {
            get { return rate2; }
            set { rate2 = value; }
        }

        public string Rate3
        {
            get { return rate3; }
            set { rate3 = value; }
        }
        public string Rate4
        {
            get { return rate4; }
            set { rate4 = value; }
        }
        public string Rate5
        {
            get { return rate5; }
            set { rate5 = value; }
        }
        public string Rate6
        {
            get { return rate6; }
            set { rate6 = value; }
        }
        public string Question2
        {
            get { return question2; }
            set { question2 = value; }
        }
        public string Question3
        {
            get { return question3; }
            set { question3 = value; }
        }
        public string Question4
        {
            get { return question4; }
            set { question4 = value; }
        }

        public void AddEvaluation()
        {
            dbHelper.AddPartnerEvaluation(Constant.SP_PartnerEvaluation ,this.CPPID,this.OpportunityID,this.StudentID, this.OrganizationName, this.SupervisorFirstName, this.SupervisorLastName,
            this.StudentFirstName, this.StudentLastName, this.HoursCompleted, this.Question1, this.Rate1, this.Rate2,
            this. Rate3, this.Rate4, this.Rate5, this.Rate6, this.Question2, this.Question3, this.Question4);
        }

        public void AutoPopulatePartnerEval()
        {
            var reader = dbHelper.GetAutoPopulatePartnerEval(Constant.SP_GetAutoPopulate, this.CPID, this.CPPID, this.StudentID, this.OpportunityID);
            while (reader.Read())
            {
                CPID = Convert.ToInt32(reader["CPID"]);
                OrganizationName = reader["OrganizationName"].ToString();
                CPPID = Convert.ToInt32(reader["CPPID"]);
                SupervisorFirstName = reader["SupervisorFirstName"].ToString();
                SupervisorLastName = reader["SupervisorLastName"].ToString();
                StudentID = Convert.ToInt32(reader["StudentID"]);
                StudentFirstName = reader["StudentFirstName"].ToString();
                StudentLastName = reader["StudentLastName"].ToString();
            }
        }
    }
}