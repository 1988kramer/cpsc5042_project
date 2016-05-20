using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace eServeSU
{
  /// <summary>
  /// Summary description for DatabaseHelper
  /// </summary>
  public class DatabaseHelper
  {
    public DatabaseHelper()
    {
      dbConnection = string.Empty;
    }

    private string dbConnection;

    public string DbConnection
    {
      get { return dbConnection; }
      set { dbConnection = value; }
    }

    public void AddOpportunity(string queryString, string name, string location, string jobDescription,
        string requirement, string timeCommitment, int totalNumberSlot, DateTime orientationDate,
        string resumeRequired,
        string minAge, string crcRequiredByPartner, string linkToOnlineApp,
        int typeId, int cpId, int cppId, int quarterId, string jobHours, string distanceFromSu)
    {
      using (var connection = new SqlConnection(dbConnection))
      {
        var command = new SqlCommand(queryString, connection);

        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.Add("@Name", SqlDbType.VarChar, 50).Value = name;
        command.Parameters.Add("@Location", SqlDbType.VarChar, 50).Value = location;
        command.Parameters.Add("@JobDescription", SqlDbType.VarChar, 8000).Value = jobDescription;
        command.Parameters.Add("@Requirements", SqlDbType.VarChar, 1000).Value = requirement;
        command.Parameters.Add("@TimeCommittment", SqlDbType.VarChar, 9).Value = timeCommitment;
        command.Parameters.Add("@TotalNumberOfSlots", SqlDbType.Int).Value = totalNumberSlot;
        command.Parameters.Add("@OrientationDate", SqlDbType.DateTime).Value = orientationDate;
        command.Parameters.Add("@ResumeRequired", SqlDbType.VarChar, 3).Value = resumeRequired;
        command.Parameters.Add("@MinimumAge", SqlDbType.VarChar, 8).Value = minAge;
        command.Parameters.Add("@CRCRequiredByPartner", SqlDbType.VarChar, 3).Value = crcRequiredByPartner;
        command.Parameters.Add("@CRCRequiredBySU", SqlDbType.VarChar, 3).Value = "No";
        command.Parameters.Add("@LinkToOnlineApp", SqlDbType.VarChar, 200).Value = linkToOnlineApp;
        command.Parameters.Add("@TypeID", SqlDbType.Int).Value = typeId;
        command.Parameters.Add("@CPID", SqlDbType.Int).Value = cpId;
        command.Parameters.Add("@CPPID", SqlDbType.Int).Value = cppId;
        command.Parameters.Add("@QuarterID", SqlDbType.Int).Value = quarterId;
        command.Parameters.Add("@JobHours", SqlDbType.VarChar, 20).Value = jobHours;
        command.Parameters.Add("@DistanceFromSU", SqlDbType.VarChar, 8).Value = distanceFromSu;

        command.Connection.Open();
        command.ExecuteNonQuery();
        command.Connection.Close();
      }
    }

    public void UpdateOpportunity(string queryString, string name, string location, string jobDescription,
        int opptunityId,
        string requirement, string timeCommitment, int totalNumberSlot, DateTime orientationDate,
        string resumeRequired,
        string minAge, string crcRequiredByPartner, string linkToOnlineApp,
        int typeId, int cpId, int cppId, int quarterId, string jobHours, string distanceFromSu)
    {
      using (var connection = new SqlConnection(dbConnection))
      {
        var command = new SqlCommand(queryString, connection);

        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.Add("@OpportunityId", SqlDbType.Int).Value = opptunityId;
        command.Parameters.Add("@Name", SqlDbType.VarChar, 50).Value = name;
        command.Parameters.Add("@Location", SqlDbType.VarChar, 50).Value = location;
        command.Parameters.Add("@JobDescription", SqlDbType.VarChar, 8000).Value = jobDescription;
        command.Parameters.Add("@Requirements", SqlDbType.VarChar, 1000).Value = requirement;
        command.Parameters.Add("@TimeCommittment", SqlDbType.VarChar, 9).Value = timeCommitment;
        command.Parameters.Add("@TotalNumberOfSlots", SqlDbType.Int).Value = totalNumberSlot;
        command.Parameters.Add("@OrientationDate", SqlDbType.DateTime).Value = orientationDate;
        command.Parameters.Add("@ResumeRequired", SqlDbType.VarChar, 3).Value = resumeRequired;
        command.Parameters.Add("@MinimumAge", SqlDbType.VarChar, 8).Value = minAge;
        command.Parameters.Add("@CRCRequiredByPartner", SqlDbType.VarChar, 3).Value = crcRequiredByPartner;
        command.Parameters.Add("@CRCRequiredBySU", SqlDbType.VarChar, 3).Value = "No";
        command.Parameters.Add("@LinkToOnlineApp", SqlDbType.VarChar, 200).Value = linkToOnlineApp;
        command.Parameters.Add("@TypeID", SqlDbType.Int).Value = typeId;
        command.Parameters.Add("@CPID", SqlDbType.Int).Value = cpId;
        command.Parameters.Add("@CPPID", SqlDbType.Int).Value = cppId;
        command.Parameters.Add("@QuarterID", SqlDbType.Int).Value = quarterId;
        command.Parameters.Add("@JobHours", SqlDbType.VarChar, 20).Value = jobHours;
        command.Parameters.Add("@DistanceFromSU", SqlDbType.VarChar, 8).Value = distanceFromSu;


        command.Connection.Open();
        command.ExecuteNonQuery();
        command.Connection.Close();
      }
    }

    public void DeleteOpportunity(string queryString, int opportunityId)
    {
      using (var connection = new SqlConnection(dbConnection))
      {
        var command = new SqlCommand(queryString, connection);

        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.Add("@OpportunityId", SqlDbType.Int).Value = opportunityId;
        command.Connection.Open();
        command.ExecuteNonQuery();
        command.Connection.Close();
      }
    }

    public void ApproveOpportunity(string queryString, int opportunityId)
    {
      using (var connection = new SqlConnection(dbConnection))
      {
        var command = new SqlCommand(queryString, connection);

        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.Add("@OpportunityId", SqlDbType.Int).Value = opportunityId;
        command.Connection.Open();
        command.ExecuteNonQuery();
        command.Connection.Close();
      }
    }

    public SqlDataReader GetOpportunityList(string queryString)
    {
      if (string.IsNullOrEmpty(dbConnection))
        dbConnection = ConfigurationManager.AppSettings["eServeConnection"];

      var connection = new SqlConnection(dbConnection);
      connection.Open();
      var command = new SqlCommand(queryString, connection);

      return command.ExecuteReader();
    }

    public SqlDataReader GetOneOpportunityById(string queryString, int opportunityId)
    {
      if (string.IsNullOrEmpty(dbConnection))
        dbConnection = ConfigurationManager.AppSettings["eServeConnection"];

      var connection = new SqlConnection(dbConnection);
      var command = new SqlCommand(queryString, connection);
      command.CommandType = CommandType.StoredProcedure;
      command.Parameters.Add("@OpportunityId", SqlDbType.Int).Value = opportunityId;
      command.Connection.Open();


      return command.ExecuteReader();

    }
    public SqlDataReader GetOpportunityType(string queryString)
    {
      if (string.IsNullOrEmpty(dbConnection))
        dbConnection = ConfigurationManager.AppSettings["eServeConnection"];

      var connection = new SqlConnection(dbConnection);
      connection.Open();
      var command = new SqlCommand(queryString, connection);

      return command.ExecuteReader();
    }

    public SqlDataReader GetFocusArea(string queryString)
    {
      if (string.IsNullOrEmpty(dbConnection))
        dbConnection = ConfigurationManager.AppSettings["eServeConnection"];

      var connection = new SqlConnection(dbConnection);
      connection.Open();
      var command = new SqlCommand(queryString, connection);

      return command.ExecuteReader();
    }
    public SqlDataReader GetQuarter(string queryString)
    {
      if (string.IsNullOrEmpty(dbConnection))
        dbConnection = ConfigurationManager.AppSettings["eServeConnection"];

      var connection = new SqlConnection(dbConnection);
      connection.Open();
      var command = new SqlCommand(queryString, connection);

      return command.ExecuteReader();
    }

    public SqlDataReader GetCommunityPartnerPeople(string queryString, int communityPartnerId)
    {
      if (string.IsNullOrEmpty(dbConnection))
        dbConnection = ConfigurationManager.AppSettings["eServeConnection"];

      var connection = new SqlConnection(dbConnection);
      connection.Open();
      var command = new SqlCommand(queryString, connection);

      command.CommandType = CommandType.StoredProcedure;
      command.Parameters.Add("@CPID", SqlDbType.Int).Value = communityPartnerId;

      return command.ExecuteReader();
    }

    public SqlDataReader GetAutoPopulatePartnerEval(string queryString, int CPID, int CPPID, int StudentID, int OpportunityID)
    {
      if (string.IsNullOrEmpty(dbConnection))
        dbConnection = ConfigurationManager.AppSettings["eServeConnection"];

      var connection = new SqlConnection(dbConnection);
      connection.Open();
      var command = new SqlCommand(queryString, connection);
      command.CommandType = CommandType.StoredProcedure;
      command.Parameters.Add("@CPID", SqlDbType.Int).Value = CPID;
      command.Parameters.Add("@CPPID", SqlDbType.Int).Value = CPPID;
      command.Parameters.Add("@StudentID", SqlDbType.Int).Value = StudentID;
      command.Parameters.Add("@OpportunityID", SqlDbType.Int).Value = OpportunityID;

      return command.ExecuteReader();
    }

    public SqlDataReader GetcommunityPartner(string queryString, int communityPartnerId)
    {
      if (string.IsNullOrEmpty(dbConnection))
        dbConnection = ConfigurationManager.AppSettings["eServeConnection"];
      var connection = new SqlConnection(dbConnection);
      connection.Open();
      var command = new SqlCommand(queryString, connection);

      command.CommandType = CommandType.StoredProcedure;
      command.Parameters.Add("@CPID", SqlDbType.Int).Value = communityPartnerId;

      return command.ExecuteReader();

    }

    public SqlDataReader GetCommunityPartnerAlert(string queryString)
    {
      if (string.IsNullOrEmpty(dbConnection))
        dbConnection = ConfigurationManager.AppSettings["eServeConnection"];

      var connection = new SqlConnection(dbConnection);
      connection.Open();
      var command = new SqlCommand(queryString, connection);

      return command.ExecuteReader();
    }

    public void DeleteCommunityPartnerAlert(string queryString, int AlertID)
    {
      using (var connection = new SqlConnection(dbConnection))
      {
        var command = new SqlCommand(queryString, connection);

        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.Add("@AlertID", SqlDbType.Int).Value = AlertID;
        command.Connection.Open();
        command.ExecuteNonQuery();
        command.Connection.Close();
      }
    }

    public void AddPartnerEvaluation(string queryString, int CPPID, int OpportunityID, int StudentID, string OrganizationName, string SupervisorFirstName, string SupervisorLastName,
        string StudentFirstName, string StudentLastName, string HoursCompleted, string Question1, string Rate1, string Rate2,
        string Rate3, string Rate4, string Rate5, string Rate6, string Question2, string Question3, string Question4)
    {
      using (var connection = new SqlConnection(dbConnection))
      {
        var command = new SqlCommand(queryString, connection);
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.Add("@CPPID", SqlDbType.Int).Value = CPPID;
        command.Parameters.Add("@OpportunityID", SqlDbType.Int).Value = OpportunityID;
        command.Parameters.Add("@StudentID", SqlDbType.Int).Value = StudentID;
        command.Parameters.Add("@OrganizationName", SqlDbType.VarChar, 150).Value = OrganizationName;
        command.Parameters.Add("@SupervisorFirstName", SqlDbType.VarChar, 15).Value = SupervisorFirstName;
        command.Parameters.Add("@SupervisorLastName", SqlDbType.VarChar, 15).Value = SupervisorLastName;
        command.Parameters.Add("@StudentFirstName", SqlDbType.VarChar, 15).Value = StudentFirstName;
        command.Parameters.Add("@StudentLastName", SqlDbType.VarChar, 15).Value = StudentLastName;
        command.Parameters.Add("@HoursCompleted", SqlDbType.VarChar, 8).Value = HoursCompleted;
        command.Parameters.Add("@Question1", SqlDbType.VarChar, 4000).Value = Question1;
        command.Parameters.Add("@Rate1", SqlDbType.VarChar, 17).Value = Rate1;
        command.Parameters.Add("@Rate2", SqlDbType.VarChar, 17).Value = Rate2;
        command.Parameters.Add("@Rate3", SqlDbType.VarChar, 17).Value = Rate3;
        command.Parameters.Add("@Rate4", SqlDbType.VarChar, 17).Value = Rate4;
        command.Parameters.Add("@Rate5", SqlDbType.VarChar, 17).Value = Rate5;
        command.Parameters.Add("@Rate6", SqlDbType.VarChar, 17).Value = Rate6;
        command.Parameters.Add("@Question2", SqlDbType.VarChar, 4000).Value = Question2;
        command.Parameters.Add("@Question3", SqlDbType.VarChar, 4000).Value = Question3;
        command.Parameters.Add("@Question4", SqlDbType.VarChar, 4000).Value = Question4;

        command.Connection.Open();
        command.ExecuteNonQuery();
        command.Connection.Close();
      }
    }

    public SqlDataReader GetSupervisor(string queryString, int cppid)
    {
      if (string.IsNullOrEmpty(dbConnection))
        dbConnection = ConfigurationManager.AppSettings["eServeConnection"];

      var connection = new SqlConnection(dbConnection);
      connection.Open();
      var command = new SqlCommand(queryString, connection);

      command.CommandType = CommandType.StoredProcedure;
      command.Parameters.Add("@CPPID", SqlDbType.Int).Value = cppid;

      return command.ExecuteReader();

    }

    public SqlDataReader GetStudentEvaluation(string queryString, int OpportunityID, int StudentID)
    {
      if (string.IsNullOrEmpty(dbConnection))
        dbConnection = ConfigurationManager.AppSettings["eServeConnection"];

      var connection = new SqlConnection(dbConnection);
      connection.Open();
      var command = new SqlCommand(queryString, connection);

      command.CommandType = CommandType.StoredProcedure;
      command.Parameters.Add("@OpportunityID", SqlDbType.Int).Value = OpportunityID;
      command.Parameters.Add("@StudentID", SqlDbType.Int).Value = StudentID;

      return command.ExecuteReader();

    }

    public void AddOpportunityStudentReflection(string queryString, int studentID, int opportunityID, string studentReflection)
    {
      using (var connection = new SqlConnection(dbConnection))
      {
        var command = new SqlCommand(queryString, connection);

        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.Add("@StudentID", SqlDbType.Int).Value = studentID;
        command.Parameters.Add("@OpportunityID", SqlDbType.Int).Value = opportunityID;
        command.Parameters.Add("@StudentReflection", SqlDbType.VarChar, 8000).Value = studentReflection;

        command.Connection.Open();
        command.ExecuteNonQuery();
        command.Connection.Close();
      }
    }

    public void AddOpportunityEvaluation(string queryString, int studentID, int opportunityID, string organizationName, string answer1, string answer2, string answer3, string answer4,
        string rate1, string rate2, string rate3, string rate4, string rate5, string rate6, string comments)
    {
      using (var connection = new SqlConnection(dbConnection))
      {
        var command = new SqlCommand(queryString, connection);

        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.Add("@StudentID", SqlDbType.Int).Value = studentID;
        command.Parameters.Add("@OpportunityID", SqlDbType.Int).Value = opportunityID;
        command.Parameters.Add("@OrganizationName", SqlDbType.VarChar, 1000).Value = organizationName;
        command.Parameters.Add("@Answer1", SqlDbType.VarChar, 8000).Value = answer1;
        command.Parameters.Add("@Answer2", SqlDbType.VarChar, 8000).Value = answer2;
        command.Parameters.Add("@Answer3", SqlDbType.VarChar, 8000).Value = answer3;
        command.Parameters.Add("@Answer4", SqlDbType.VarChar, 8000).Value = answer4;
        command.Parameters.Add("@Rate1", SqlDbType.VarChar, 50).Value = rate1;
        command.Parameters.Add("@Rate2", SqlDbType.VarChar, 50).Value = rate2;
        command.Parameters.Add("@Rate3", SqlDbType.VarChar, 50).Value = rate3;
        command.Parameters.Add("@Rate4", SqlDbType.VarChar, 50).Value = rate4;
        command.Parameters.Add("@Rate5", SqlDbType.VarChar, 50).Value = rate5;
        command.Parameters.Add("@Rate6", SqlDbType.VarChar, 50).Value = rate6;
        command.Parameters.Add("@Comments", SqlDbType.VarChar, 8000).Value = comments;

        command.Connection.Open();
        command.ExecuteNonQuery();
        command.Connection.Close();
      }
    }

    public void UpdateSupervisor(string queryString, int CPPID, string FirstName, string LastName,
        string Title, string Phone, string EmailID)
    {
      using (var connection = new SqlConnection(dbConnection))
      {
        var command = new SqlCommand(queryString, connection);

        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.Add("@CPPID", SqlDbType.Int).Value = CPPID;
        command.Parameters.Add("@FirstName", SqlDbType.VarChar, 50).Value = FirstName;
        command.Parameters.Add("@LastName", SqlDbType.VarChar, 50).Value = LastName;
        command.Parameters.Add("@Phone", SqlDbType.VarChar, 15).Value = Phone;
        command.Parameters.Add("@Title", SqlDbType.VarChar, 50).Value = Title;
        command.Parameters.Add("@EmailID", SqlDbType.VarChar, 50).Value = EmailID;

        command.Connection.Open();
        command.ExecuteNonQuery();
        command.Connection.Close();
      }
    }

    public void UpdateSignUpFor(string queryString, int CPPID, int StudentID, int OpportunityID, string SignUpStatus)

    {
      using (var connection = new SqlConnection(dbConnection))
      {
        var command = new SqlCommand(queryString, connection);

        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.Add("@CPPID", SqlDbType.Int).Value = CPPID;
        command.Parameters.Add("@StudentID", SqlDbType.Int).Value = StudentID;
        command.Parameters.Add("@OpportunityID", SqlDbType.Int).Value = OpportunityID;
        command.Parameters.Add("@SignUpStatus", SqlDbType.VarChar, 8).Value = SignUpStatus;

        command.Connection.Open();
        command.ExecuteNonQuery();
        command.Connection.Close();
      }
    }

    public void DeleteSupervisor(string queryString, int CPPID, int CPID)
    {
      using (var connection = new SqlConnection(dbConnection))
      {
        var command = new SqlCommand(queryString, connection);

        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.Add("@CPPID", SqlDbType.Int).Value = CPPID;
        command.Parameters.Add("@CPID", SqlDbType.Int).Value = CPID;
        command.Connection.Open();
        command.ExecuteNonQuery();
        command.Connection.Close();
      }
    }

    public void UpdateCommunityPartnerProfile(string queryString, int CPID, string OrganizationName, string Address,
       string Website, string MainPhone, string MissionStatement, string Description)
    {
      using (var connection = new SqlConnection(dbConnection))
      {
        var command = new SqlCommand(queryString, connection);

        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.Add("@CPID", SqlDbType.Int).Value = CPID;
        command.Parameters.Add("@OrganizationName", SqlDbType.VarChar, 50).Value = OrganizationName;
        command.Parameters.Add("@Address", SqlDbType.VarChar, 50).Value = Address;
        command.Parameters.Add("@Website", SqlDbType.VarChar, 50).Value = Website;
        command.Parameters.Add("@MainPhone", SqlDbType.VarChar, 50).Value = MainPhone;
        command.Parameters.Add("@MissionStatement", SqlDbType.VarChar, 8000).Value = MissionStatement;
        command.Parameters.Add("@WorkDescription", SqlDbType.VarChar, 1000).Value = Description;

        command.Connection.Open();
        command.ExecuteNonQuery();
        command.Connection.Close();
      }
    }

    public SqlDataReader GetCommunityPartnerStudentView(string queryString)
    {
      if (string.IsNullOrEmpty(dbConnection))
        dbConnection = ConfigurationManager.AppSettings["eServeConnection"];

      var connection = new SqlConnection(dbConnection);
      connection.Open();
      var command = new SqlCommand(queryString, connection);
      command.CommandType = CommandType.StoredProcedure;
      return command.ExecuteReader();
    }

    public SqlDataReader GetCourseEvaluationByStudent(string queryString)
    {
      if (string.IsNullOrEmpty(dbConnection))
        dbConnection = ConfigurationManager.AppSettings["eServeConnection"];

      var connection = new SqlConnection(dbConnection);
      connection.Open();
      var command = new SqlCommand(queryString, connection);

      return command.ExecuteReader();
    }
    public SqlDataReader DeleteAllStudentFocusAreas(string queryString, int studentId)
    {
      if (string.IsNullOrEmpty(dbConnection))
        dbConnection = ConfigurationManager.AppSettings["eServeConnection"];

      //var connection = new SqlConnection(dbConnection);
      //connection.Open();
      //var command = new SqlCommand(queryString, connection);
      var connection = new SqlConnection(dbConnection);
      var command = new SqlCommand(queryString, connection);
      command.CommandType = CommandType.StoredProcedure;
      command.Parameters.Add("@StudentId", SqlDbType.Int).Value = studentId;
      command.Connection.Open();

      return command.ExecuteReader();
    }
    public SqlDataReader AddStudentFocusArea(string queryString, int studentId, int focusAreaId)
    {
      if (string.IsNullOrEmpty(dbConnection))
        dbConnection = ConfigurationManager.AppSettings["eServeConnection"];

      //var connection = new SqlConnection(dbConnection);
      //connection.Open();
      //var command = new SqlCommand(queryString, connection);
      var connection = new SqlConnection(dbConnection);
      var command = new SqlCommand(queryString, connection);
      command.CommandType = CommandType.StoredProcedure;
      command.Parameters.Add("@FocusAreaID", SqlDbType.Int).Value = focusAreaId;
      command.Parameters.Add("@StudentID", SqlDbType.Int).Value = studentId;
      command.Connection.Open();

      return command.ExecuteReader();
    }
    public SqlDataReader UpdateStudentProfile(string queryString, int studentId, string preferedName, string gender, string isInternationalStudent)
    {
      if (string.IsNullOrEmpty(dbConnection))
        dbConnection = ConfigurationManager.AppSettings["eServeConnection"];

      //var connection = new SqlConnection(dbConnection);
      //connection.Open();
      //var command = new SqlCommand(queryString, connection);
      var connection = new SqlConnection(dbConnection);
      var command = new SqlCommand(queryString, connection);
      command.CommandType = CommandType.StoredProcedure;
      command.Parameters.Add("@StudentId", SqlDbType.Int).Value = studentId;
      command.Parameters.Add("@PreferedName", SqlDbType.VarChar, 1000).Value = preferedName;
      command.Parameters.Add("@Gender", SqlDbType.VarChar, 1000).Value = gender;
      command.Parameters.Add("@InternationalStudent", SqlDbType.VarChar, 1000).Value = isInternationalStudent;
      command.Connection.Open();

      return command.ExecuteReader();
    }
    public SqlDataReader GetStudentProfile(string queryString, int studentId)
    {
      if (string.IsNullOrEmpty(dbConnection))
        dbConnection = ConfigurationManager.AppSettings["eServeConnection"];

      //var connection = new SqlConnection(dbConnection);
      //connection.Open();
      //var command = new SqlCommand(queryString, connection);
      var connection = new SqlConnection(dbConnection);
      var command = new SqlCommand(queryString, connection);
      command.CommandType = CommandType.StoredProcedure;
      command.Parameters.Add("@StudentId", SqlDbType.Int).Value = studentId;
      command.Connection.Open();

      return command.ExecuteReader();
    }
    public SqlDataReader GetRegisteredOpportunityByStudentId(string queryString, int studentId)
    {
      if (string.IsNullOrEmpty(dbConnection))
        dbConnection = ConfigurationManager.AppSettings["eServeConnection"];

      var connection = new SqlConnection(dbConnection);
      var command = new SqlCommand(queryString, connection);
      command.CommandType = CommandType.StoredProcedure;
      command.Parameters.Add("@StudentId", SqlDbType.Int).Value = studentId;
      command.Connection.Open();

      return command.ExecuteReader();
    }
    public SqlDataReader RegisteredOpportunityByStudentAndOpportunityId(string queryString, int studentId, int opportunityId)
    {
      if (string.IsNullOrEmpty(dbConnection))
        dbConnection = ConfigurationManager.AppSettings["eServeConnection"];

      var connection = new SqlConnection(dbConnection);
      var command = new SqlCommand(queryString, connection);
      command.CommandType = CommandType.StoredProcedure;
      command.Parameters.Add("@StudentId", SqlDbType.Int).Value = studentId;
      command.Parameters.Add("@OpportunityId", SqlDbType.Int).Value = opportunityId;
      command.Connection.Open();

      return command.ExecuteReader();
    }
    public SqlDataReader GetOpportunityRegistrationByStudentId(string queryString, int studentId)
    {
      if (string.IsNullOrEmpty(dbConnection))
        dbConnection = ConfigurationManager.AppSettings["eServeConnection"];

      var connection = new SqlConnection(dbConnection);
      var command = new SqlCommand(queryString, connection);
      command.CommandType = CommandType.StoredProcedure;
      command.Parameters.Add("@StudentId", SqlDbType.Int).Value = studentId;
      command.Connection.Open();

      return command.ExecuteReader();
    }
    public SqlDataReader GetOpportunityDetailByOpportunityId(string queryString, int opportunityId)
    {
      if (string.IsNullOrEmpty(dbConnection))
        dbConnection = ConfigurationManager.AppSettings["eServeConnection"];

      var connection = new SqlConnection(dbConnection);
      var command = new SqlCommand(queryString, connection);
      command.CommandType = CommandType.StoredProcedure;
      command.Parameters.Add("@OpportunityId", SqlDbType.Int).Value = opportunityId;
      command.Connection.Open();

      return command.ExecuteReader();
    }

    public SqlDataReader GetVolunteeredAndPartnerApprovedHours(string queryString, int studentId, int opportunityID)
    {
      if (string.IsNullOrEmpty(dbConnection))
        dbConnection = ConfigurationManager.AppSettings["eServeConnection"];

      var connection = new SqlConnection(dbConnection);
      var command = new SqlCommand(queryString, connection);
      command.Parameters.Add("@StudentId", SqlDbType.Int).Value = studentId;
      command.Parameters.Add("@OpportunityID", SqlDbType.Int).Value = opportunityID;
      command.CommandType = CommandType.StoredProcedure;
      command.Connection.Open();

      return command.ExecuteReader();
    }

    public SqlDataReader GetUnAssignedCourseSection(string queryString, int opportunityId)
    {
      if (string.IsNullOrEmpty(dbConnection))
        dbConnection = ConfigurationManager.AppSettings["eServeConnection"];

      var connection = new SqlConnection(dbConnection);
      var command = new SqlCommand(queryString, connection);
      command.CommandType = CommandType.StoredProcedure;
      command.Parameters.Add("@OpportunityId", SqlDbType.Int).Value = opportunityId;
      command.Connection.Open();

      return command.ExecuteReader();
    }

    public SqlDataReader GetAssignedCourseSection(string queryString, int opportunityId)
    {
      if (string.IsNullOrEmpty(dbConnection))
        dbConnection = ConfigurationManager.AppSettings["eServeConnection"];

      var connection = new SqlConnection(dbConnection);
      var command = new SqlCommand(queryString, connection);
      command.CommandType = CommandType.StoredProcedure;
      command.Parameters.Add("@OpportunityId", SqlDbType.Int).Value = opportunityId;
      command.Connection.Open();

      return command.ExecuteReader();
    }

    public void AddCourseSectionToOpportunity(string queryString, int opportunityId, string courseSectionIDs)
    {
      if (string.IsNullOrEmpty(dbConnection))
        dbConnection = ConfigurationManager.AppSettings["eServeConnection"];

      var connection = new SqlConnection(dbConnection);
      var command = new SqlCommand(queryString, connection);
      command.CommandType = CommandType.StoredProcedure;
      command.Parameters.Add("@OpportunityId", SqlDbType.Int).Value = opportunityId;
      command.Parameters.Add("@CourseSectionIDs", SqlDbType.VarChar, 1000).Value = courseSectionIDs;
      command.Connection.Open();

      command.ExecuteNonQuery();
      command.Connection.Close();
    }

    public void RemoveCourseSectionFromOpportunity(string queryString, int opportunityId, string courseSectionIDs)
    {
      if (string.IsNullOrEmpty(dbConnection))
        dbConnection = ConfigurationManager.AppSettings["eServeConnection"];

      var connection = new SqlConnection(dbConnection);
      var command = new SqlCommand(queryString, connection);
      command.CommandType = CommandType.StoredProcedure;
      command.Parameters.Add("@OpportunityId", SqlDbType.Int).Value = opportunityId;
      command.Parameters.Add("@CourseSectionIDs", SqlDbType.VarChar, 1000).Value = courseSectionIDs;
      command.Connection.Open();

      command.ExecuteNonQuery();
      command.Connection.Close();
    }

    public SqlDataReader GetOpportunityListForAdmin(string queryString)
    {
      if (string.IsNullOrEmpty(dbConnection))
        dbConnection = ConfigurationManager.AppSettings["eServeConnection"];

      var connection = new SqlConnection(dbConnection);
      var command = new SqlCommand(queryString, connection);
      command.CommandType = CommandType.StoredProcedure;
      command.Connection.Open();

      return command.ExecuteReader();
    }
    public SqlDataReader GetOpportunityStudentListReport(string queryString, int quarterID)
    {
      if (string.IsNullOrEmpty(dbConnection))
        dbConnection = ConfigurationManager.AppSettings["eServeConnection"];

      var connection = new SqlConnection(dbConnection);
      var command = new SqlCommand(queryString, connection);
      command.Parameters.Add("@QuarterID", SqlDbType.Int).Value = quarterID;
      command.CommandType = CommandType.StoredProcedure;
      command.Connection.Open();

      return command.ExecuteReader();
    }

    public SqlDataReader GetTimeEntries(string queryString, int studentId, int opportunityID)
    {
      if (string.IsNullOrEmpty(dbConnection))
        dbConnection = ConfigurationManager.AppSettings["eServeConnection"];

      var connection = new SqlConnection(dbConnection);
      var command = new SqlCommand(queryString, connection);
      command.Parameters.Add("@OpportunityID", SqlDbType.Int).Value = opportunityID;
      command.Parameters.Add("@StudentID", SqlDbType.Int).Value = studentId;
      command.CommandType = CommandType.StoredProcedure;
      command.Connection.Open();

      return command.ExecuteReader();
    }

    public SqlDataReader GetStudentSubmission(string queryString, int studentId, int opportunityID)
    {
      if (string.IsNullOrEmpty(dbConnection))
        dbConnection = ConfigurationManager.AppSettings["eServeConnection"];

      var connection = new SqlConnection(dbConnection);
      var command = new SqlCommand(queryString, connection);
      command.Parameters.Add("@OpportunityID", SqlDbType.Int).Value = opportunityID;
      command.Parameters.Add("@StudentID", SqlDbType.Int).Value = studentId;
      command.CommandType = CommandType.StoredProcedure;
      command.Connection.Open();

      return command.ExecuteReader();
    }

    public SqlDataReader UpdateTimeEntries(string queryString, int OpportunityID, int StudentID, DateTime WorkDate, int PartnerApprovedHours)
    {
      if (string.IsNullOrEmpty(dbConnection))
        dbConnection = ConfigurationManager.AppSettings["eServeConnection"];

      //var connection = new SqlConnection(dbConnection);
      //connection.Open();
      //var command = new SqlCommand(queryString, connection);
      var connection = new SqlConnection(dbConnection);
      var command = new SqlCommand(queryString, connection);
      command.CommandType = CommandType.StoredProcedure;
      command.Parameters.Add("@OpportunityID", SqlDbType.Int).Value = OpportunityID;
      command.Parameters.Add("@StudentID", SqlDbType.Int).Value = StudentID;
      command.Parameters.Add("@WorkDate", SqlDbType.DateTime).Value = WorkDate;
      command.Parameters.Add("@PartnerApprovedHours", SqlDbType.Int).Value = PartnerApprovedHours;
      command.Connection.Open();

      return command.ExecuteReader();
    }
    public SqlDataReader GetStudentTimeEntriesByOpportunityID(string queryString, int studentId, int opportunityID)
    {
      if (string.IsNullOrEmpty(dbConnection))
        dbConnection = ConfigurationManager.AppSettings["eServeConnection"];

      var connection = new SqlConnection(dbConnection);
      var command = new SqlCommand(queryString, connection);
      command.Parameters.Add("@StudentId", SqlDbType.Int).Value = studentId;
      command.Parameters.Add("@OpportunityID", SqlDbType.Int).Value = opportunityID;
      command.CommandType = CommandType.StoredProcedure;
      command.Connection.Open();

      return command.ExecuteReader();
    }
    public void SubmitStudentTimeEntry(string queryString, string workDate, int opportunityID, int studentID,
                                        int cppid, int partnerApprovedHours, string timeEntryDate, int hoursVolunteered)
    {
      if (string.IsNullOrEmpty(dbConnection))
        dbConnection = ConfigurationManager.AppSettings["eServeConnection"];

      var connection = new SqlConnection(dbConnection);
      var command = new SqlCommand(queryString, connection);
      command.CommandType = CommandType.StoredProcedure;
      command.Parameters.Add("@WorkDate", SqlDbType.VarChar, 1000).Value = workDate;
      command.Parameters.Add("@OpportunityID", SqlDbType.Int, 1000).Value = opportunityID;
      command.Parameters.Add("@StudentID", SqlDbType.Int, 1000).Value = studentID;
      command.Parameters.Add("@CPPID", SqlDbType.Int, 1000).Value = cppid;
      command.Parameters.Add("@PartnerApprovedHours", SqlDbType.NVarChar, 1000).Value = partnerApprovedHours;
      command.Parameters.Add("@TimeEntryDate", SqlDbType.VarChar, 1000).Value = timeEntryDate;
      command.Parameters.Add("@HoursVolunteered", SqlDbType.Int, 1000).Value = hoursVolunteered;
      command.Connection.Open();

      command.ExecuteNonQuery();
      command.Connection.Close();
    }

    public void AssingnOpportunityToStudentByAdmin(string queryString, int opportunityID, string studentEmail)
    {
      if (string.IsNullOrEmpty(dbConnection))
        dbConnection = ConfigurationManager.AppSettings["eServeConnection"];

      var connection = new SqlConnection(dbConnection);
      var command = new SqlCommand(queryString, connection);
      command.Parameters.Add("@OpportunityID", SqlDbType.Int).Value = opportunityID;
      command.Parameters.Add("@StudentEmail", SqlDbType.NVarChar).Value = studentEmail;
      command.CommandType = CommandType.StoredProcedure;
      command.Connection.Open();

      command.ExecuteNonQuery();

    }

    public SqlDataReader GetStudentCourseOppDetailForFaculty(string queryString, int professorID)
    {
      if (string.IsNullOrEmpty(dbConnection))
        dbConnection = ConfigurationManager.AppSettings["eServeConnection"];

      var connection = new SqlConnection(dbConnection);
      var command = new SqlCommand(queryString, connection);
      command.Parameters.Add("@ProfessorID", SqlDbType.Int).Value = professorID;
      command.CommandType = CommandType.StoredProcedure;
      command.Connection.Open();

      return command.ExecuteReader();
    }

    public SqlDataReader GetPartnerEvaluationByStudentIDOppID(string queryString, int studentId, int opportunityID)
    {
      if (string.IsNullOrEmpty(dbConnection))
        dbConnection = ConfigurationManager.AppSettings["eServeConnection"];

      var connection = new SqlConnection(dbConnection);
      var command = new SqlCommand(queryString, connection);
      command.Parameters.Add("@StudentId", SqlDbType.Int).Value = studentId;
      command.Parameters.Add("@OpportunityID", SqlDbType.Int).Value = opportunityID;
      command.CommandType = CommandType.StoredProcedure;
      command.Connection.Open();

      return command.ExecuteReader();
    }

    public SqlDataReader GetStudentEvaluationByStudentIDOppID(string queryString, int studentId, int opportunityID)
    {
      if (string.IsNullOrEmpty(dbConnection))
        dbConnection = ConfigurationManager.AppSettings["eServeConnection"];

      var connection = new SqlConnection(dbConnection);
      var command = new SqlCommand(queryString, connection);
      command.Parameters.Add("@StudentId", SqlDbType.Int).Value = studentId;
      command.Parameters.Add("@OpportunityID", SqlDbType.Int).Value = opportunityID;
      command.CommandType = CommandType.StoredProcedure;
      command.Connection.Open();

      return command.ExecuteReader();
    }
  }
}