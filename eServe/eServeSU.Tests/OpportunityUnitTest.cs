using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eServeSU;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace eServeUnitTest
{
    [TestClass]
    public class OpportunityUnitTest
    {
        public TestContext TestContext { get; set; }
        public string ConnectionString = ConfigurationManager.ConnectionStrings["eServeConnection"].ConnectionString;

        [TestMethod]
        [TestCategory("Opportunity")]
        [Description("")]
        public void Test_GetAllOpportunity()
        {
            //Initialize SqlQueryHelper object
            var sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();

            var command = new SqlCommand("select count(*) from opportunity");
            var oppCount = Convert.ToInt32(command.ExecuteScalar());

            //Opportunity
            Opportunity opp = new Opportunity();
            List<Opportunity> oppList = opp.GetAllOpportunities();
            Assert.AreEqual(oppCount, oppList.Count);
        }
    }
}
