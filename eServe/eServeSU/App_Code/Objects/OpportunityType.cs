using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace eServeSU
{
    /// <summary>
    /// Summary description for OpportunityType
    /// </summary>
    public class OpportunityType
    {
        public OpportunityType()
        {
            //
            // TODO: Add constructor logic here
            //
            dbHelper = new DatabaseHelper();
            dbHelper.DbConnection = ConfigurationManager.ConnectionStrings["eServeConnection"].ConnectionString;
        }

        private String name;
        private int oppTypeId;

        private DatabaseHelper dbHelper;

        public String Name
        {
            get { return this.name; }
            set
            {
                try
                {
                    this.name = value;

                    if (this.name == "")
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

        public int OpportunityTypeId
        {
            get { return this.oppTypeId; }
            set
            {
                this.oppTypeId = value;
                if (this.oppTypeId == 0)
                {
                    throw new Exception("Please provide opportunity type Id ...");
                }
            }
        }

        public List<OpportunityType> GetAllOpportunityTypes()
        {
            var reader = dbHelper.GetOpportunityType(Constant.SP_GetOpportunityType);

            List<OpportunityType> oppTypeList = new List<OpportunityType>();
            OpportunityType oppType = null;

            while (reader.Read())
            {
                oppType = new OpportunityType();
                oppType.OpportunityTypeId = Convert.ToInt32(reader["OpportunityTypeId"]);
                oppType.Name = reader["Name"].ToString();

                oppTypeList.Add(oppType);
            }

            return oppTypeList;
        }
    }
}
