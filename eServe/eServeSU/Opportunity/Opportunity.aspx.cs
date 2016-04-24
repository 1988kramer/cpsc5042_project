using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eServeSU
{
    public partial class Opportunity_Opportunity : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Session["OppId"] = 1;
            if (!Page.IsPostBack)
            {
                DataBind_OpportunityType();
                DataBind_FocusArea();
                DataBind_Quarter();
                DataBind_CommunityPartnerPeople();

                if (Session["OppId"] != null)
                {
                    tbAdd.Text = "Update Opportunity";
                    lblTitle.Text = "Edit/View Opportunity";
                    if (Session["IsClone"] != null)
                    {
                        tbAdd.Text = "Clone Opportunity";
                        lblTitle.Text = "Clone Opportunity";
                    }
                    Opportunity thisOpp = new Opportunity();
                    thisOpp = thisOpp.GetOneOpportunityById(Convert.ToInt32(Session["OppId"]));
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
            }

            if (Session["OppId"] != null && Session["IsClone"] == null && opp.Status == "Open")
            {
                tbName.Enabled = false;
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
        protected void btnAdd_Click(Object sender, EventArgs e)
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
            // When the button is clicked,
            // change the button text, and disable it.

            
            clickedButton.Text = "...Processing...";
            clickedButton.Enabled = false;

            // Save to database
            Opportunity opp = new Opportunity();
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

            if (Session["OppId"] != null && Session["IsClone"] == null)
            {
                opp.OpportunityId = Convert.ToInt32(Session["OppId"].ToString());
                opp.Update();
                lblEmpty.Text = "The opportunity was updated successfully. Please refresh the Opportunity page to review. Please close the window.";
            }
            else
            {
                opp.Add();
                lblEmpty.Text = "New opportunity was added successfully. Please refresh the Opportunity page to review. Please close the window.";
            }
            clickedButton.Enabled = true;
            clickedButton.Text = "Close";
            Session["OppId"] = null;
            Session["IsClone"] = null;
        }
    }
}