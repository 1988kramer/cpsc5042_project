using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace eServeSU
{
    public class CommunityPartnerProfile
    {
        public CommunityPartnerProfile()
        {
            //
            // TODO: Add constructor logic here
            //
            dbHelper = new DatabaseHelper();
            dbHelper.DbConnection = ConfigurationManager.ConnectionStrings["eServeConnection"].ConnectionString;
        }

        private int CPID;
        private String organizationName;
        private String address;
        private String website;
        private string mainPhone;
        private String missionStatement;
        private String workDescription;
        private DatabaseHelper dbHelper;

        public int CommunityPartnerID
        {
            get { return this.CPID; }

            set
            {
                try
                {
                    this.CPID = value;
                    if (this.CPID == 0)
                        throw new Exception("Please provide CommunityPartner ID...");

                }
                catch(Exception e)
                {
                    throw new Exception(e.Message);
                }

            }
        }
        public string OrganizationName
        {
            get { return this.organizationName; }

            set
            {
                try
                {
                    this.organizationName = value;
                    if (this.organizationName == "")
                        throw new Exception("Please provide organization name...");

                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }

            }
        }

        public string Address
        {
            get { return this.address; }

            set
            {
                try
                {
                    this.address = value;
                    if (this.address == "")
                        throw new Exception("Please provide the address...");

                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }

            }
        }
        
        public string Website
        {
            get { return this.website; }

            set
            {
                try
                {
                    this.website = value;
                    if (this.website == "")
                        throw new Exception("Please provide Website...");

                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }

            }
        }
        public string MainPhone
        {
            get { return this.mainPhone; }

            set
            {
                try
                {
                    this.mainPhone = value;
                    if (this.mainPhone == "")
                        throw new Exception("Please provide Phone number...");

                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }

            }
        }
        public string MissionStatement
        {
            get { return this.missionStatement; }

            set
            {
                
               this.missionStatement = value;
                        
             }
        }
        public string WorkDescription
        {
            get { return this.workDescription; }

            set
            {

                this.workDescription = value;

            }
        }

        public void GetcommunityPartnerProfile()
        {
            var reader = dbHelper.GetcommunityPartner(Constant.SP_GetCommunityPartner,1);

            while (reader.Read())
            {
                CPID = Convert.ToInt32(reader["CommunityPartnerID"]);
                organizationName = reader["OrganizationName"].ToString();
                mainPhone = reader["MainPhone"].ToString();
                address = reader["Address"].ToString();
                missionStatement = reader["MissionStatement"].ToString();
                workDescription = reader["WorkDescription"].ToString();
            }
        }
        
    }
}