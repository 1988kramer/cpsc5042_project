using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eServeSU
{
    public partial class AdminApproval : System.Web.UI.Page
    {
        private string adminOppStatus = string.Empty;
        protected void Page_Load(object sender, EventArgs e)
        {            
            if (!Page.IsPostBack)
            {
                DataBind_OpportunityType();
                DataBind_FocusArea();
                DataBind_Quarter();
                DataBind_CommunityPartnerPeople();

                if (Session["AdminOppId"] != null)
                {  
                    Opportunity thisOpp = new Opportunity();
                    thisOpp = thisOpp.GetOneOpportunityById(Convert.ToInt32(Session["AdminOppId"]));
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
                adminOppStatus = opp.Status;
                if(adminOppStatus == "Open")
                    btnApproval.Text = "Close";
            }

            if (Session["AdminOppId"] != null)
            {
                //tbName.Enabled = false;
                //tbDate.Enabled = false;
                //tbSlot.Enabled = false;
                //ddlSupervisor.Enabled = false;
                //tbThisLocation.Enabled = false;
                //tbJobDescription.Enabled = false;
                //tbRequirement.Enabled = false;
                //ddlType.Enabled = false;
                //ddlQuarter.Enabled = false;
                //tbJobHours.Enabled = false;
                //tbRequirementAge.Enabled = false;
                //rblResume.Enabled = false;
                //rblCRC.Enabled = false;
                //tbDistance.Enabled = false;
                //tbLink.Enabled = false;
                //ddlTimeCommitment.Enabled = false;
                //ddlFocusArea.Enabled = false;
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
        protected void btnApproval_Click(Object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            if (clickedButton.Text == "Close")
            {
                string close = @"<script type='text/javascript'>
                                window.returnValue = true;
                                window.close();
                                </script>";
                base.Response.Write(close);
            }
            else
            {
                // When the button is clicked,
                // change the button text, and disable it.
                clickedButton.Text = "...Processing...";
                clickedButton.Enabled = false;
                // Save to database
                Opportunity opp = new Opportunity();
                opp.OpportunityId = Convert.ToInt32(Session["AdminOppId"].ToString());
                opp.Approve();
            }

            clickedButton.Enabled = true;
            clickedButton.Text = "Close";
            Session["AdminOppId"] = null;
        }
        protected void btnUpdate_Click(Object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            
            // When the button is clicked,
            clickedButton.Enabled = false;
            // Save to database
            Opportunity opp = new Opportunity();
            opp.OpportunityId = Convert.ToInt32(Session["AdminOppId"].ToString());
            opp.Name = tbName.Text;
            opp.Location = tbThisLocation.Text;
            opp.JobDescription = tbJobDescription.Text;
            opp.Requirement = tbRequirement.Text;
            opp.DateApproved = DateTime.Now;
            opp.OpportunityTypeId = Convert.ToInt32(ddlType.SelectedItem.Value);
            opp.CPId = 1;
            opp.CPPId = Convert.ToInt32(ddlSupervisor.SelectedItem.Value);
            opp.QuarterId = Convert.ToInt32(ddlQuarter.SelectedItem.Value);
            opp.JobHours = tbJobHours.Text;
            opp.MinimumAge = tbRequirementAge.Text;
            opp.ResumeRequired = rblResume.SelectedValue;
            opp.CrcRequiredByPartner = rblCRC.SelectedValue;
            opp.DistanceFromSU = tbDistance.Text;
            opp.LinkToOnlineApp = tbLink.Text;
            opp.OrientationDate = Convert.ToDateTime(tbDate.Text);
            opp.TotalNumberSlots = Convert.ToInt32(tbSlot.Text);
            opp.TimeCommittment = ddlTimeCommitment.SelectedItem.Value;
            
            opp.Update();
            lblEmpty.Text = "The opportunity was updated successfully.";
            
            clickedButton.Enabled = true;
        }
    }
}