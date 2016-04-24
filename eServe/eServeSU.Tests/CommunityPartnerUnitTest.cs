using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using eServeSU;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.SqlClient;

namespace eServeUnitTest
{
    [TestClass]
    public class CommunityPartnerUnitTest
    {
        public TestContext TestContext { get; set; }
        public string ConnectionString = ConfigurationManager.ConnectionStrings["eServeConnection"].ConnectionString;

        [TestMethod]
        [TestCategory("CommunityPartner")]
        [Description("")]
        public void Test_GetAllCommunityPartner()
        {
            //Initialize SqlQueryHelper object
            var sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
          
            var command = new SqlCommand("select count(*) from CommunityPartner");
            var cpCount = Convert.ToInt32(command.ExecuteScalar());

            //CommunityPartner
            
            CommunityPartner cp = new CommunityPartner();

            List<CommunityPartner> cpList = cp.GetAllCommunityPartner();
            
            Assert.AreEqual(cpCount, cpList.Count);
        }
    }
}
