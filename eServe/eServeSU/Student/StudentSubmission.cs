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
    public class StudentSubmission
    {
        public StudentSubmission()
        {
            dbHelper = new DatabaseHelper();
            dbHelper.DbConnection = ConfigurationManager.ConnectionStrings["eServeConnection"].ConnectionString;
        }

        private DatabaseHelper dbHelper;

        public bool CheckStudentEvaluationSubmitted(int studentId, int opportunityID)
        {
            var reader = dbHelper.GetStudentSubmission(Constant.SP_GetStudentEvaluationCountByOpportunityID, studentId, opportunityID);

            reader.Read();
            int recordCount = Convert.ToInt32(reader["Count"].ToString());
            bool isSubmitted = false;
            if (recordCount == 1)
            {
                isSubmitted = true;
            }

            return isSubmitted;
        }

        public bool CheckStudentReflectionSubmitted(int studentId, int opportunityID)
        {
            var reader = dbHelper.GetStudentSubmission(Constant.SP_GetStudentReflectionCountByOpportunityID, studentId, opportunityID);

            reader.Read();
            int recordCount = Convert.ToInt32(reader["Count"].ToString());
            bool isSubmitted = false;
            if (recordCount == 1)
            {
                isSubmitted = true;
            }

            return isSubmitted;
        }
    }
}