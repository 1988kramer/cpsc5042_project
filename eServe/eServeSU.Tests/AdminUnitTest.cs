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
    public class AdminUnitTest
    {
        public TestContext TestContext { get; set; }
        public string ConnectionString = ConfigurationManager.ConnectionStrings["eServeConnection"].ConnectionString;

        [TestMethod]
        [TestCategory("Admin")]
        [Description("")]
        public void Test_GetAllOpportunity()
        {
            //Initialize SqlQueryHelper object
            var sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();

            var command = new SqlCommand("select count(*) from opportunity_section where OpportunityID = 10");
            var csCount = Convert.ToInt32(command.ExecuteScalar());

            //Opportunity

            CourseSection cs = new CourseSection();

            List<CourseSection> csList = cs.GetAssignedCourseSection(10);

            Assert.AreEqual(csCount, csList.Count);
        }
    }
}
