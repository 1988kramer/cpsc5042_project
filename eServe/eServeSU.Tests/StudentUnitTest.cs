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
    public class StudentUnitTest
    {
        public TestContext TestContext { get; set; }
        public string ConnectionString = ConfigurationManager.ConnectionStrings["eServeConnection"].ConnectionString;

        [TestMethod]
        [TestCategory("Student")]
        [Description("")]
        public void Test_GetAllRegisteredOpportunity()
        {
            //Initialize SqlQueryHelper object
            var sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();

            var command = new SqlCommand("sselect count(distinct [OpportunityID]) from [dbo].[SignUpFor] where studentid = 106288");
            var oppRegisteredCount = Convert.ToInt32(command.ExecuteScalar());

            //Opportunity

            OpportunityRegistered oppRegistered = new OpportunityRegistered();

            List<OpportunityRegistered> oppRegisteredList = oppRegistered.GetOpportunityRegisteredByStudentId(106288);

            Assert.AreEqual(oppRegisteredCount, oppRegisteredList.Count);
        }
    }
}
