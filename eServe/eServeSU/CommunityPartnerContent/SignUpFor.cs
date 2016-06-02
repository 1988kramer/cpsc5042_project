using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace eServeSU
{
    public class SignUpFor
    {
        private int cppID;
        private int studentID;
        private int opportunityID;
        private string studentReflection;
        private string signUpStatus;

        private DatabaseHelper dbHelper;

        

       public SignUpFor()

        { dbHelper = new DatabaseHelper();
            dbHelper.DbConnection = ConfigurationManager.ConnectionStrings["eServeConnection"].ConnectionString;
    }
        public int CPPID
       {
           get { return cppID; }
           set { cppID = value; }
       }

        public int StudentID
        {
            get { return studentID; }
            set { studentID = value; }
        }

        public int OpportunityID
        {
            get { return opportunityID; }
            set { opportunityID = value; }
        }

        public string SignUpStatus
        {
            get { return signUpStatus ; }
            set { signUpStatus  = value; }
        }


        public string StudentReflection
        {
            get { return studentReflection; }
            set { studentReflection  = value; }
        }

        public void UpdateSignUpFor()
        {
            dbHelper.UpdateSignUpFor(Constant.SP_UpdateSignUpStatus, this.CPPID, this.StudentID, this.OpportunityID,
                this.SignUpStatus );
        }
    }
}