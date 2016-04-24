using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Globalization;
using System.Web;

namespace eServeSU
{
  public  class StudentCourseEvaluation
    {
      private int opportunityID;
      private int studentID; 
      private string name;
      private string firstName;
      private string lastName;
      private string sectionName;
      private string courseEvaluationByStudent;
      private DatabaseHelper dbHelper;

       public StudentCourseEvaluation ()
        {
            //
            // TODO: Add constructor logic here
            //
            dbHelper = new DatabaseHelper();
            dbHelper.DbConnection = ConfigurationManager.ConnectionStrings["eServeConnection"].ConnectionString;
        }

       public int OpportunityID
       {
           get { return this.opportunityID; }
           set { this.opportunityID = value; }
       }
       public int StudentID
       {
           get { return this.studentID; }
           set { this.studentID = value; }
       }
         public string Name
       {
           get { return this.name; }
           set { this.name = value; }
       }

         public string FirstName
         {
             get { return this.firstName; }
             set { this.firstName = value; }
         }

         public string LastName
         {
             get { return this.lastName; }
             set { this.lastName = value; }
         }

      public string Student
         {
             get { return FirstName + " " + LastName; }
         }
         public string SectionName
         {
             get { return this.sectionName; }
             set { this.sectionName = value; }
         }

         public string CourseEvaluationByStudent
         {
             get { return this.courseEvaluationByStudent; }
             set
             {
                 this.courseEvaluationByStudent = value;
         
             }
         }
      public List<StudentCourseEvaluation> GetAllCourseEvaluation()
         {
             var reader = dbHelper.GetCourseEvaluationByStudent(Constant.SP_GetCourseEvaluationByStudent);
             List<StudentCourseEvaluation> studentCourseEvalList = new List<StudentCourseEvaluation>();
             StudentCourseEvaluation courseEval = null;
          while (reader.Read())
          {
              courseEval = new StudentCourseEvaluation();
              courseEval.OpportunityID = Convert.ToInt32(reader["OpportunityID"]);

              courseEval.StudentID = Convert.ToInt32(reader["StudentID"]);

              courseEval.Name = reader["Name"].ToString();

              courseEval.FirstName = reader["FirstName"].ToString();

              courseEval.LastName = reader["LastName"].ToString();

              courseEval.SectionName = reader["SectionName"].ToString();

              studentCourseEvalList.Add(courseEval);


          } 
          reader.Close();
          return studentCourseEvalList;
          
         }

      
    }
}
