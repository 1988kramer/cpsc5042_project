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
    public class OpportunityStudentReflection
    {
        public OpportunityStudentReflection()
        {
            dbHelper = new DatabaseHelper();
            dbHelper.DbConnection = ConfigurationManager.ConnectionStrings["eServeConnection"].ConnectionString;
        }

        private DatabaseHelper dbHelper;
        public int StudentID { get; set; }
        public int OpportunityID { get; set; }        
        public string StudentReflection { get; set; }
        public void SubmitOpportunitySelfReflection(OpportunityStudentReflection studentRelfection)
        {
            dbHelper.AddOpportunityStudentReflection(Constant.SP_AddOpportunityStudentReflection, studentRelfection.StudentID, 
                                                                                                    studentRelfection.OpportunityID, studentRelfection.StudentReflection);
        }
    }
}