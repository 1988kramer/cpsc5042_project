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
        public string ConnectionString = "Server=tcp:cs5051-sajwanih.database.windows.net,1433;Database=eServe;User ID=sajwanih@cs5051-sajwanih;Password=129280Eserve;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        // ConfigurationManager.ConnectionStrings["eServeConnection"].ConnectionString;

        [TestMethod]
        [TestCategory("CommunityPartner")]
        [Description("")]
        public void Test_GetAllCommunityPartner()
        {
            //Initialize SqlQueryHelper object
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
          
            SqlCommand command = new SqlCommand("select count(*) from CommunityPartners", sqlConnection);
            Int32 cpCount = Convert.ToInt32(command.ExecuteScalar());

            //CommunityPartner
            
            CommunityPartner cp = new CommunityPartner();

            List<CommunityPartner> cpList = cp.GetAllCommunityPartner();
            
            Assert.AreEqual(cpCount, cpList.Count);
        }
    }
}
