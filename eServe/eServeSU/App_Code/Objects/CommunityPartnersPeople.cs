using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace eServeSU
{
    /// <summary>
    /// Summary description for CommunityPartnersPeople
    /// </summary>
    public class CommunityPartnersPeople
    {
        public CommunityPartnersPeople()
        {
            dbHelper = new DatabaseHelper();
            dbHelper.DbConnection = ConfigurationManager.ConnectionStrings["eServeConnection"].ConnectionString;
            //total hack
            cpId = 1;
        }

        private int cppId;
        private String firstName;
        private String lastName;
        private string title;
        private string phone;
        private string emailID;
        private int cpId;

        private DatabaseHelper dbHelper;

        public String FirstName
        {
            get { return this.firstName; }
            set
            {
                try
                {
                    this.firstName = value;

                    if (this.firstName == "")
                    {
                        throw new Exception(
                            "Please provide first name ...");
                    }
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
        }

        public String LastName
        {
            get { return this.lastName; }
            set
            {
                try
                {
                    this.lastName = value;

                    if (this.lastName == "")
                    {
                        throw new Exception(
                            "Please provide last name ...");
                    }
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
        }

        public int CPPID
        {
            get { return this.cppId; }
            set { this.cppId = value; }
        }
        public int CPID
        {
            get { return this.cpId; }
            set { this.cpId = value; }
        }


        public string Supervisor
        {
            get { return FirstName + "  " + LastName; }
        }

        public String Title
        {
            get { return this.title; }
            set
            {
                try
                {
                    this.title = value;

                    if (this.title == "")
                    {
                        throw new Exception(
                            "Please provide Title ...");
                    }
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
        }

        public String Phone
        {
            get { return this.phone; }
            set
            {
                try
                {
                    this.phone = value;

                    if (this.phone == "")
                    {
                        throw new Exception(
                            "Please provide phone number ...");
                    }
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
        }

        public String EmailID
        {
            get { return this.emailID; }
            set
            {
                try
                {
                    this.emailID = value;

                    if (this.emailID == "")
                    {
                        throw new Exception(
                            "Please provide first name ...");
                    }
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
        }
        public List<CommunityPartnersPeople> GetAllCommunityPartnerPeople()
        {
            var reader = dbHelper.GetCommunityPartnerPeople(Constant.SP_GetCommunityPartnerPeople, this.CPID);

            List<CommunityPartnersPeople> communityPartnerPeopleList = new List<CommunityPartnersPeople>();
            CommunityPartnersPeople communityPartnerPeople ;

            while (reader.Read())
            {
                communityPartnerPeople = new CommunityPartnersPeople();
                communityPartnerPeople.CPPID = Convert.ToInt32(reader["SupervisorID"]);
                communityPartnerPeople.FirstName = reader["FirstName"].ToString();
                communityPartnerPeople.LastName = reader["LastName"].ToString();
                communityPartnerPeople.Title = reader["Title"].ToString();
                communityPartnerPeople.Phone = reader["Phone"].ToString();
                communityPartnerPeople.EmailID = reader["EmailID"].ToString();

                communityPartnerPeopleList.Add(communityPartnerPeople);
            }

            return communityPartnerPeopleList;
        }

        public CommunityPartnersPeople GetSupervisor(int cppid)
        {
            var reader = dbHelper.GetSupervisor(Constant.SP_GetSupervisor, cppid);

            CommunityPartnersPeople communityPartnerPeople = null;
            while (reader.Read())
            {
                communityPartnerPeople = new CommunityPartnersPeople();
                communityPartnerPeople.CPPID = Convert.ToInt32(reader["SupervisorID"]);
                communityPartnerPeople.FirstName = reader["FirstName"].ToString();
                communityPartnerPeople.LastName = reader["LastName"].ToString();
                communityPartnerPeople.Title = reader["Title"].ToString();
                communityPartnerPeople.Phone = reader["Phone"].ToString();
                communityPartnerPeople.EmailID = reader["EmailID"].ToString();
            } return communityPartnerPeople;
        }

        public void DeleteSupervisor()
        {

            dbHelper.DeleteSupervisor(Constant.SP_DeleteCommunityPartnerPeople, this.CPPID,this.CPID);
            

        }

        public void UpdateSupervisor()
          
        {
            dbHelper.UpdateSupervisor(Constant.SP_UpdateSupervisor, this.CPPID, this.FirstName, this.LastName, this.Title, 
                this.Phone, this.EmailID);
        
        }



    }
}
