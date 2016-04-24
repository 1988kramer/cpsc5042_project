using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eServeSU
{
    public partial class FacultyOppDetail : System.Web.UI.Page
    {
        private string oppStatus = string.Empty;
        protected void Page_Load(object sender, EventArgs e)
        {            
            if (!Page.IsPostBack)
            {
                DataBind_OpportunityType();
                DataBind_FocusArea();
                DataBind_Quarter();
                DataBind_CommunityPartnerPeople();

                if (Session["FacultyOppId"] != null)
                {  
                    Opportunity thisOpp = new Opportunity();
                    thisOpp = thisOpp.GetOneOpportunityById(Convert.ToInt32(Session["FacultyOppId"]));
                    DataBind(thisOpp);
                }
            }
        }

        protected void DataBind(Opportunity opp)
        {
            if (opp != null)
            {
                tbName.Text = opp.Name;
                tbThisLocation.Text = opp.Location;
                tbJobDescription.Text = opp.JobDescription;
                tbRequirement.Text = opp.Requirement;
                ddlType.SelectedValue = opp.OpportunityTypeId.ToString();
                ddlSupervisor.SelectedValue = opp.CPPId.ToString();
                ddlQuarter.SelectedValue = opp.QuarterId.ToString();
                tbJobHours.Text = opp.JobHours;
                tbRequirementAge.Text = opp.MinimumAge;
                rblResume.SelectedValue = opp.ResumeRequired;
                rblCRC.SelectedValue = opp.CrcRequiredByPartner;
                tbDistance.Text = opp.DistanceFromSU;
                tbLink.Text = opp.LinkToOnlineApp;
                tbDate.Text = opp.OrientationDate.ToString();
                tbSlot.Text = opp.TotalNumberSlots.ToString();
                ddlTimeCommitment.SelectedValue = opp.TimeCommittment;
                oppStatus = opp.Status;
            }

            if (Session["FacultyOppId"] != null)
            {
                tbName.Enabled = false;
                tbDate.Enabled = false;
                tbSlot.Enabled = false;
                ddlSupervisor.Enabled = false;
                tbThisLocation.Enabled = false;
                tbJobDescription.Enabled = false;
                tbRequirement.Enabled = false;
                ddlType.Enabled = false;
                ddlQuarter.Enabled = false;
                tbJobHours.Enabled = false;
                tbRequirementAge.Enabled = false;
                rblResume.Enabled = false;
                rblCRC.Enabled = false;
                tbDistance.Enabled = false;
                tbLink.Enabled = false;
                ddlTimeCommitment.Enabled = false;
                ddlFocusArea.Enabled = false;
            }
        }

        protected void DataBind_OpportunityType()
        {
            OpportunityType oppType = new OpportunityType();

            ddlType.DataSource = oppType.GetAllOpportunityTypes();
            ddlType.DataTextField = "Name";
            ddlType.DataValueField = "OpportunityTypeId";
            ddlType.DataBind();
        }

        protected void DataBind_FocusArea()
        {
            FocusArea focusArea = new FocusArea();

            ddlFocusArea.DataSource = focusArea.GetAllFocusAreas();
            ddlFocusArea.DataTextField = "AreaName";
            ddlFocusArea.DataValueField = "FocusAreaId";
            ddlFocusArea.DataBind();
        }

        protected void DataBind_CommunityPartnerPeople()
        {
            CommunityPartnersPeople ccp = new CommunityPartnersPeople();

            ddlSupervisor.DataSource = ccp.GetAllCommunityPartnerPeople();
            ddlSupervisor.DataTextField = "Supervisor";
            ddlSupervisor.DataValueField = "CPPID";
            ddlSupervisor.DataBind();
        }
        protected void DataBind_Quarter()
        {
            Quarter focusArea = new Quarter();

            ddlQuarter.DataSource = focusArea.GetAllQuarters();
            ddlQuarter.DataTextField = "QuarterName";
            ddlQuarter.DataValueField = "QuarterId";
            ddlQuarter.DataBind();
        }
    }
}