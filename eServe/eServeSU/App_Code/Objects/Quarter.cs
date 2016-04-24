using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace eServeSU
{
    /// <summary>
    /// Summary description for Quarter
    /// </summary>
    public class Quarter
    {
        public Quarter()
        {
            //
            // TODO: Add constructor logic here
            //
            dbHelper = new DatabaseHelper();
            dbHelper.DbConnection = ConfigurationManager.ConnectionStrings["eServeConnection"].ConnectionString;
        }

        private String quarterName;
        private int quarterId;
        private String quarterShortName;
        private DateTime startDate;
        private DateTime endDate;
        private DatabaseHelper dbHelper;

        public String QuarterName
        {
            get { return this.quarterName; }
            set
            {
                try
                {
                    this.quarterName = value;

                    if (this.quarterName == "")
                    {
                        throw new Exception(
                            "Please provide quarter name ...");
                    }
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
        }

        public int QuarterId
        {
            get { return this.quarterId; }
            set
            {
                this.quarterId = value;
                if (this.quarterId == 0)
                {
                    throw new Exception("Please provide quarter Id ...");
                }
            }
        }

        public DateTime StartDate
        {
            get { return this.startDate; }
            set
            {
                this.startDate = value;
                if (this.startDate == null)
                {
                    throw new Exception("Please provide start date ...");
                }
            }
        }

         public DateTime EndDate
        {
            get { return this.endDate; }
            set
            {
                this.endDate = value;
                if (this.endDate == null)
                {
                    throw new Exception("Please provide end date ...");
                }
            }
        }
        public String QuarterShortName
        {
            get { return this.quarterShortName; }
            set
            {
                try
                {
                    this.quarterShortName = value;

                    if (this.quarterShortName == "")
                    {
                        throw new Exception(
                            "Please provide quarter short name ...");
                    }
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
        }

        public List<Quarter> GetAllQuarters()
        {
            var reader = dbHelper.GetFocusArea(Constant.SP_GetQuarter);

            List<Quarter> quarterList = new List<Quarter>();
            Quarter quarter = null;

            while (reader.Read())
            {
                quarter = new Quarter();
                quarter.QuarterId = Convert.ToInt32(reader["QuarterId"]);
                quarter.QuarterName = reader["QuarterName"].ToString();
                quarter.QuarterShortName = reader["QuarterShortName"].ToString();
                quarter.StartDate = Convert.ToDateTime(reader["StartDate"]);
                quarter.EndDate = Convert.ToDateTime(reader["EndDate"]);

                quarterList.Add(quarter);
            }

            return quarterList;
        }

        public int GetCurrentQuarterId()
        {
            int currentQuarterId = 0;

            DateTime today = DateTime.Now;
            List<Quarter> quarters = GetAllQuarters();

            foreach (Quarter q in quarters)
            {
                if (today < q.endDate && today > q.startDate)
                {
                    currentQuarterId = q.QuarterId;
                    break;
                }
            }

            return currentQuarterId;
        }

        public string GetCurrentQuarterName()
        {
            string currentQuarterName = string.Empty;

            DateTime today = DateTime.Now;
            List<Quarter> quarters = GetAllQuarters();

            foreach (Quarter quarter in quarters)
            {
                if (today < quarter.endDate && today > quarter.startDate)
                {
                    currentQuarterName = quarter.quarterName;
                    break;
                }
            }

            return currentQuarterName;
        }
    }
}
