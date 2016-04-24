using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace eServeSU
{
    public class Profile
    {
        public Profile()
        {
            //
            // TODO: Add constructor logic here
            //
            dbHelper = new DatabaseHelper();
            dbHelper.DbConnection = ConfigurationManager.ConnectionStrings["eServeConnection"].ConnectionString;
        }

        private DatabaseHelper dbHelper;
        private String studentID;
        private String firstName;
        private String lastNameName;
        private String preferedName;
        private String dateOfBirth;
        private String gender;
        private String internationalStudent;
        private String lastBackgroundCheck;

        public String StudentID { get; set; }

        public String FirstName { get; set; }

        public String LastName { get; set; }

        public String PreferedName
        {
            get { return this.preferedName; }
            set
            {
                try
                {
                    this.preferedName = value;

                    if (this.preferedName == "")
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

        public String DateOfBirth { get; set; }
        public String Gender { get; set; }
        public String InternationalStudent { get; set; }
        public String LastBackgroundCheck { get; set; }
        public List<string> Ethinicity { get; set; }
        public List<string> FocusAreas { get; set; }

        public Profile GetStudentProfile(int studentId)
        {
            var reader = dbHelper.GetStudentProfile(Constant.SP_GetStudentProfile, studentId);

            Profile profile = new Profile();
            reader.Read();
            profile.StudentID = reader["StudentID"].ToString();
            profile.FirstName = reader["FirstName"].ToString();
            profile.LastName = reader["LastName"].ToString();
            profile.PreferedName = reader["PreferedName"].ToString();
            profile.DateOfBirth = reader["DateOfBirth"].ToString();
            profile.Gender = reader["Gender"].ToString();
            profile.InternationalStudent = reader["InternationalStudent"].ToString();
            profile.LastBackgroundCheck = reader["LastBackgroundCheck"].ToString();
            profile.Ethinicity = GetProfileEthnicity(studentId);
            profile.FocusAreas = GetProfileFocusAreas(studentId);

            return profile;
        }

        public List<string> GetProfileEthnicity(int studentId)
        {
            List<string> result = new List<string>();
            var reader = dbHelper.GetStudentProfile(Constant.SP_GetProfileEthinicity, studentId);

            int rowCount = 0;
            while (reader.Read())
            {
                result.Add(reader[1].ToString());
                rowCount++;
            }

            return result;
        }

        public List<string> GetProfileFocusAreas(int studentId)
        {
            List<string> result = new List<string>();
            var reader = dbHelper.GetStudentProfile(Constant.SP_GetProfileFocusAreas, studentId);

            int rowCount = 0;
            while (reader.Read())
            {
                result.Add(reader[1].ToString());
                rowCount++;
            }

            return result;
        }

        //public int OpportunityId
        //{
        //    get{ return this.oppId; }
        //    set
        //    {
        //        this.oppId = value;
        //        if (this.oppId == 0)
        //        {
        //            throw new Exception("Please provide opportunity Id ...");
        //        }
        //    }
        //}
        //public String JobDescription
        //{
        //    get { return this.jobDescription; }
        //    set
        //    {
        //        this.jobDescription = value;

        //        if (this.jobDescription == "")
        //        {
        //            throw new Exception("Please provide job description ...");
        //        }
        //    }
        //}
        //public void Add()
        //{   
        //    dbHelper.AddOpportunity(Constant.SP_AddOpportunit, this.Name, this.Location, this.JobDescription);
        //}

        //public void Update()
        //{
        //    dbHelper.UpdateOpportunity(Constant.SP_UpdateOpportunit, this.Name, this.Location, this.JobDescription, this.OpportunityId);
        //}

        //public void Delete()
        //{
        //    dbHelper.DeleteOpportunity(Constant.SP_DeleteOpportunit, this.OpportunityId);
        //}
    }

}

