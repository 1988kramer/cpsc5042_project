using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace eServeSU
{
    public  class CommunityPartnerStudentViews
    {
        private int opportunityID;
        private int cpID;
        private int cppID;
        private string name;
        private int studentID;
        private string firstName;
        private string lastName;
        private string signUpStatus;
        private string partnerEvaluation;
        private int sectionID;
        private string sectionName;
        private int professorID;
        private string professorFirstName;
        private string professorLastName;
        private int totalHoursVolunteered;
        private int partnerApprovedHours;
        private string professorEmail;
        DatabaseHelper dbHelper;

        public CommunityPartnerStudentViews ()
        {
            //
            // TODO: Add constructor logic here
            //
            dbHelper = new DatabaseHelper();
            dbHelper.DbConnection = ConfigurationManager.ConnectionStrings["eServeConnection"].ConnectionString;
        }

        public int OpportunityID
        {
            get { return opportunityID; }
            set
            {
                opportunityID = value;
            }
        }
        public int CPPID
        {
            get { return cppID; }
            set
            {
                cppID = value;
            }
        }

        public int CPID
        {
            get { return cpID; }
            set
            {
                cpID = value;
            }
        }
       
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
            }
        }

        public int StudentID
        {
            get { return studentID; }
            set
            {
                studentID = value;
            }
        }

        public string FirstName
        {
            get { return firstName; }
            set
            {
                firstName  = value;
            }
        }

        public string LastName
        {
            get { return lastName ; }
            set
            {
                lastName = value;
            }
        }

        public string Student
        {
            get { return FirstName + "  " + LastName; }
        }

        public string SignUpStatus
        {
            get { return signUpStatus; }
            set
            {
                signUpStatus = value;
            }
        }
        public string PartnerEvaluation
        {
            get { return partnerEvaluation; }
            set
            {
                partnerEvaluation  = value;
            }
        }

        public int SectionID
        {
            get { return sectionID; }
            set
            {
                sectionID = value;
            }
        }
        public string SectionName
        {
            get { return sectionName; }
            set
            {
                sectionName = value;
            }
        }

        public int ProfessorID
        {
            get { return professorID; }
            set
            {
                professorID = value;
            }
        }
        public string ProfessorFirstName
        {
            get { return professorFirstName; }
            set
            {
                professorFirstName  = value;
            }
        }

        public string ProfessorLastName
        {
            get { return professorLastName; }
            set
            {
                professorLastName = value;
            }
        }
        public string Professor
        {
            get { return ProfessorFirstName + "  " + ProfessorLastName; }
        }

        public int TotalHoursVolunteered
        {
            get { return totalHoursVolunteered; }
            set
            {
                totalHoursVolunteered = value;
            }
        }
        public int PartnerApprovedHours
        {
            get { return partnerApprovedHours; }
            set
            {
                partnerApprovedHours = value;
            }
        }
        public string ProfessorEmail
        {
            get { return professorEmail; }
            set
            {
                professorEmail = value;
            }
        }

        public List<CommunityPartnerStudentViews> GetAllCommunityPartnerStudentView()
        {
            var reader = dbHelper.GetCommunityPartnerStudentView(Constant.SP_GetCommunityPartnerStudentView);

            List<CommunityPartnerStudentViews> cpsvList = new  List<CommunityPartnerStudentViews>();
            CommunityPartnerStudentViews cpsv = null;
            while (reader.Read())
            {
                cpsv = new CommunityPartnerStudentViews();

                cpsv.OpportunityID = Convert.ToInt32(reader["OpportunityID"]);
                cpsv.CPPID = Convert.ToInt32(reader["CPPID"]);
                cpsv.CPID = Convert.ToInt32(reader["CPID"]);
                cpsv.Name = reader["Name"].ToString ();
                cpsv.StudentID = Convert.ToInt32(reader["StudentID"]);
                cpsv.FirstName = reader["FirstName"].ToString();
                cpsv.LastName = reader["LastName"].ToString ();
                cpsv.SignUpStatus = reader["SignUpStatus"].ToString() ;
                cpsv.SectionID = Convert.ToInt32 (reader["SectionID"]);
                cpsv.SectionName = reader["SectionName"].ToString ();
                cpsv.ProfessorID = Convert .ToInt32(reader["ProfessorID"]);
                cpsv.ProfessorFirstName = reader["ProfessorFirstName"].ToString();
                cpsv.ProfessorLastName = reader["ProfessorLastName"].ToString  ();
                cpsv.TotalHoursVolunteered = Convert .ToInt32 (reader["TotalHoursVolunteered"]);
                cpsv.PartnerApprovedHours = Convert .ToInt32 (reader["PartnerApprovedHours"]);
                cpsv.ProfessorEmail = reader["ProfessorEmail"].ToString();

                cpsvList.Add(cpsv);



            }return cpsvList;
            
        }

        public void UpdateSignUpFor()
        {
            dbHelper.UpdateSignUpFor(Constant.SP_UpdateSignUpStatus, this.CPPID, this.StudentID, this.OpportunityID, this.SignUpStatus);
        }



    }
}