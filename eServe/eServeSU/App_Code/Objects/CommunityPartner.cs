using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace eServeSU
{
  /// <summary>
  /// Summary description for CommunityPartner
  /// </summary>
  public class CommunityPartner
  {
    public CommunityPartner()
    {
      cpId = 0;
      organizationName = string.Empty;

      dbHelper = new DatabaseHelper();
      dbHelper.DbConnection = ConfigurationManager.ConnectionStrings["eServeConnection"].ConnectionString;
    }

    private int cpId;
    private String organizationName;

    private DatabaseHelper dbHelper;

    public String OrganizationName
    {
      get { return this.organizationName; }
      set
      {
        try
        {
          this.organizationName = value;

          if (this.organizationName == "")
          {
            throw new Exception(
                "Please provide organization name ...");
          }
        }
        catch (Exception e)
        {
          throw new Exception(e.Message);
        }
      }
    }

    public int CommunityPartnerId
    {
      get { return this.cpId; }
      set
      {
        this.cpId = value;
        if (this.cpId == 0)
        {
          throw new Exception("Please provide community Partner Id ...");
        }
      }
    }

    public List<CommunityPartner> GetAllCommunityPartner()
    {
      var reader = dbHelper.GetFocusArea(Constant.SP_GetCommunityPartner);

      List<CommunityPartner> communityPartnerList = new List<CommunityPartner>();
      CommunityPartner communityPartner = null;

      while (reader.Read())
      {
        communityPartner = new CommunityPartner();
        communityPartner.CommunityPartnerId = Convert.ToInt32(reader["CommunityPartnerId"]);
        communityPartner.OrganizationName = reader["OrganizationName"].ToString();

        communityPartnerList.Add(communityPartner);
      }

      return communityPartnerList;
    }
  }
}