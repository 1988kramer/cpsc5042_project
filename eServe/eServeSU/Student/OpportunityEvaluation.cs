using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eServeSU
{
    public class OpportunityEvaluation
    {

        public OpportunityEvaluation()
        {
            dbHelper = new DatabaseHelper();
            dbHelper.DbConnection = ConfigurationManager.ConnectionStrings["eServeConnection"].ConnectionString;    
        }

        private DatabaseHelper dbHelper;
        public int StudentID { get; set; }
        public int OpportunityID { get; set; }
        public string OrganizationName { get; set; }
        public string Answer1 { get; set; }
        public string Answer2 { get; set; }
        public string Answer3 { get; set; }
        public string Answer4 { get; set; }
        public string Rate1 { get; set; }
        public string Rate2 { get; set; }
        public string Rate3 { get; set; }
        public string Rate4 { get; set; }
        public string Rate5 { get; set; }
        public string Rate6 { get; set; }
        public string Comments { get; set; }

        public void SubmitOpportunityEvaluation(OpportunityEvaluation evaluation)
        {
            dbHelper.AddOpportunityEvaluation(Constant.SP_AddOpportunityEvaluation, evaluation.StudentID, evaluation.OpportunityID, evaluation.OrganizationName, evaluation.Answer1, evaluation.Answer2,
                evaluation.Answer3, evaluation.Answer4, evaluation.Rate1, evaluation.Rate2, evaluation.Rate3, evaluation.Rate4, evaluation.Rate5, evaluation.Rate6, evaluation.Comments);         
        }
        public void GetStudentEvaluation()
        {

            var reader = dbHelper.GetStudentEvaluation(Constant.SP_GetStudentEvaluation,this.StudentID, this.OpportunityID);
            while (reader.Read())
            {
              OrganizationName = reader["OrganizationName"].ToString();
              Answer1 = reader["Answer1"].ToString();
              Answer2 = reader["Answer2"].ToString();
              Answer3 = reader["Answer3"].ToString();
              Answer4 = reader["Answer4"].ToString();
              Rate1 = reader["Rate1"].ToString();
              Rate2 = reader["Rate2"].ToString();
              Rate3 = reader["Rate3"].ToString();
              Rate4 = reader["Rate4"].ToString();
              Rate5 = reader["Rate5"].ToString();
              Rate6 = reader["Rate6"].ToString();
              Comments = reader["Comments"].ToString();
            } reader.Close();
        }
    }
}