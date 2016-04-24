using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace eServeSU
{
    public class CommunityAlert
    {
       private int alertID;
       private int cpID;
       private string message;
       private DateTime date;
       private DatabaseHelper dbHelper;

        public CommunityAlert ()
       {
           dbHelper = new DatabaseHelper();
           dbHelper.DbConnection = ConfigurationManager.ConnectionStrings["eServeConnection"].ConnectionString;
       }

        public int AlertID
        {
           get {return alertID;}
            set {alertID = value;}
        }
        public int CPID
        {
            get { return cpID; }
            set { cpID = value; }
        }
        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public List<CommunityAlert > GetAllCommunityPartnerAlertView()
        {
           var reader = dbHelper.GetCommunityPartnerAlert(Constant.SP_CommunityPartnerAlertView);
           List<CommunityAlert> caList = new List<CommunityAlert>();
           CommunityAlert ca = null;
            while (reader.Read())
            {
                ca = new CommunityAlert();
               ca. AlertID  = Convert.ToInt32(reader["AlertID"]);
               ca. Message = reader["Message"].ToString();
               ca. Date = Convert.ToDateTime(reader["Date"]);

               caList.Add(ca);
             
                
            }
            return caList;
        }

        public void DeleteAlertMessage()
    {
        dbHelper.DeleteCommunityPartnerAlert(Constant.SP_DeleteCommunityPartnerAlert, this.AlertID);
    }

            
       

    }
}