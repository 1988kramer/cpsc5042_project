﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eServeSU;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace eServeSU.Tests
{
    /// <summary>
    /// Tests for the new features implemented for user story 1.4
    /// </summary>
    [TestClass]
    public class NewFeatureUnitTest
    {
        public TestContext TestContext { get; set; }
        public string ConnectionString = ConfigurationManager.ConnectionStrings["eServeConnection"].ConnectionString;

        [TestMethod]
        public void Test_PartnerCanChangeStatus()
        {
            //Initialize SqlQueryHelper object
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();

            CommunityPartnerStudentViews testPartner = new CommunityPartnerStudentViews(); 
            testPartner.CPID = 1;
            testPartner.CPPID = 1;
            testPartner.StudentID = 106288;

            int oppID = 2;
            
            // make sure sign up status for test field is pending
            SqlCommand update = new SqlCommand("update SignUpFor set SignUpStatus = 'pending' where StudentID = @studentID and OpportunityID = @oppID", 
                                                sqlConnection);
            update.Parameters.AddWithValue("@studentID", testPartner.StudentID);
            update.Parameters.AddWithValue("@oppID", oppID);
            update.ExecuteNonQuery();

            testPartner.UpdateSignUpFor(); // still need to implement this method

            SqlCommand getStatus = new SqlCommand("select SignUpStatus from SignUpFor where StudentID = @studentID and OpportunityID = @oppID limit 1", 
                                                    sqlConnection);
            var reader = getStatus.ExecuteReader();
            string status = reader.GetString(reader.GetOrdinal("SignUpFor"));
            Assert.IsTrue(status.Equals("Approved"));
        }

        [TestMethod]
        public void Test_OpportunityViewableByStudent()
        {
            //Initialize SqlQueryHelper object
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();

            int studentID = 106288;
            OpportunityRegistered opps = new OpportunityRegistered();
            List<OpportunityRegistered> opportunities = opps.GetOpportunityRegisteredByStudentId(studentID);

            SqlCommand getStatusCount = new SqlCommand("select count (*) from SignUpFor where StudentID = @studentID", sqlConnection);
            getStatusCount.Parameters.AddWithValue("@studentID", studentID);
            Int32 oppCount = Convert.ToInt32(getStatusCount.ExecuteScalar());

            Assert.AreEqual(oppCount, opportunities.Count);
        }

        [TestMethod]
        public void Test_SignedUpForOpportunitiesAreViewable()
        {
            //Initialize SqlQueryHelper object
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();

            int studentID = 106288;
            OpportunityRegistered opps = new OpportunityRegistered();
            List<OpportunityRegistered> opportunities = opps.GetOpportunityRegisteredByStudentId(studentID);

            SqlCommand getSignUpStatus = new SqlCommand("select OpportunityID, SignUpStatus from SignUpFor where StudentID = @studentID", sqlConnection);
            getSignUpStatus.Parameters.AddWithValue("@studentID", studentID);
            var reader = getSignUpStatus.ExecuteReader();

            bool result = true;
            int i = 0;

            while (reader.Read() && i < opportunities.Count && result)
            {
                string signUpStatus = reader.GetString(reader.GetOrdinal("SignUpStatus"));
                Int32 oppID = Convert.ToInt32(reader["OpportunityID"]);
                if (opportunities[i].OpportunityID != oppID || opportunities[i].Status.Equals(signUpStatus))
                    result = false;
            }

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Test_StudentCanViewOnlyOwnOpportunities()
        {
            //Initialize SqlQueryHelper object
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();

            int studentID = 106288;
            OpportunityRegistered opps = new OpportunityRegistered();
            List<OpportunityRegistered> opportunities = opps.GetOpportunityRegisteredByStudentId(studentID);

            bool result = true;

            foreach (OpportunityRegistered opp in opportunities)
            {
                if (opp.StudentId != studentID)
                    result = false;
            }

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Test_ChangeByPartnerViewableByStudent()
        {
            //Initialize SqlQueryHelper object
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();

            CommunityPartnerStudentViews testPartner = new CommunityPartnerStudentViews();
            testPartner.CPID = 1;
            testPartner.CPPID = 1;
            testPartner.StudentID = 106288;

            int oppID = 2;

            // make sure sign up status for test field is pending
            SqlCommand update = new SqlCommand("update SignUpFor set SignUpStatus = 'pending' where StudentID = @studentID and OpportunityID = @oppID",
                                                sqlConnection);
            update.Parameters.AddWithValue("@studentID", testPartner.StudentID);
            update.Parameters.AddWithValue("@oppID", oppID);
            update.ExecuteNonQuery();

            testPartner.UpdateSignUpFor(); // still need to implement this method

            OpportunityRegistered opportunity = new OpportunityRegistered();
            List<OpportunityRegistered> opportunities = opportunity.GetOpportunityRegisteredByStudentId(testPartner.StudentID);

            // is a student allowed to sign up for the same opportunity twice? if so this may not work
            foreach (OpportunityRegistered opp in opportunities)
            {
                if (opp.OpportunityID == oppID)
                    Assert.IsTrue(opp.Status.Equals("Approved"));
            }
        }

        [TestMethod]
        public void Test_PartnerCanOnlyChangeStatusForOwnOpportunities()
        {
            //Initialize SqlQueryHelper object
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
        }
    }
}
