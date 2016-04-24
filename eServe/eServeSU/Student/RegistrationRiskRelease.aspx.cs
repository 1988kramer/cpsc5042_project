using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eServeSU
{
    public partial class RegistrationRiskRelease : System.Web.UI.Page
    {        
        protected void Page_Load(object sender, EventArgs e)
        {            
            if (!Page.IsPostBack)
            {
                DataBind();
                Session["Student_FullLegalName"] = null;
            }
        }

        protected void DataBind()
        {
            int studentID = Convert.ToInt32(Session["Student_StudentID"]);
            Profile studentProfile = new Profile().GetStudentProfile(studentID);
            string studentFullLegalName = studentProfile.FirstName + " " + studentProfile.LastName;            
            lblFullLegalName.Text = "Your full legal name (" + studentFullLegalName + "):";
        }

        protected void DataBind_OpportunityType()
        {
            OpportunityType oppType = new OpportunityType();

            //ddlType.DataSource = oppType.GetAllOpportunityTypes();
            //ddlType.DataTextField = "Name";
            //ddlType.DataValueField = "OpportunityTypeId";
            //ddlType.DataBind();
        }

        protected void DataBind_FocusArea()
        {
            FocusArea focusArea = new FocusArea();

            //ddlFocusArea.DataSource = focusArea.GetAllFocusAreas();
            //ddlFocusArea.DataTextField = "AreaName";
            //ddlFocusArea.DataValueField = "FocusAreaId";
            //ddlFocusArea.DataBind();
        }

        protected void DataBind_CommunityPartnerPeople()
        {
            CommunityPartnersPeople ccp = new CommunityPartnersPeople();

            //ddlSupervisor.DataSource = ccp.GetAllCommunityPartnerPeople();
            //ddlSupervisor.DataTextField = "Supervisor";
            //ddlSupervisor.DataValueField = "CPPID";
            //ddlSupervisor.DataBind();
        }
        protected void DataBind_Quarter()
        {
            Quarter focusArea = new Quarter();

            //ddlQuarter.DataSource = focusArea.GetAllQuarters();
            //ddlQuarter.DataTextField = "QuarterName";
            //ddlQuarter.DataValueField = "QuarterId";
            //ddlQuarter.DataBind();
        }
        protected void btnAdd_Click(Object sender, EventArgs e)
        {
            // When the button is clicked,
            // change the button text, and disable it.

            Button clickedButton = (Button)sender;
            clickedButton.Text = "...Processing...";
            clickedButton.Enabled = false;

            // Save to database
            //Opportunity opp = new Opportunity();
            //opp.Name = tbName.Text;
            //opp.Location = tbThisLocation.Text;
            //opp.JobDescription = tbJobDescription.Text;
            //opp.Requirement = tbRequirement.Text;
            //opp.DateApproved = DateTime.Now;
            //opp.OpportunityTypeId = Convert.ToInt32(ddlType.SelectedItem.Value);
            //opp.CPId = 1;
            //opp.CPPId = Convert.ToInt32(ddlSupervisor.SelectedItem.Value);
            //opp.QuarterId = Convert.ToInt32(ddlQuarter.SelectedItem.Value);
            //opp.JobHours = tbJobHours.Text;
            //opp.MinimumAge = rblAge.SelectedValue;
            //opp.ResumeRequired = rblResume.SelectedValue;
            //opp.CrcRequiredByPartner = rblCRC.SelectedValue;
            //opp.DistanceFromSU = tbDistance.Text;
            //opp.LinkToOnlineApp = tbLink.Text;
            //opp.OrientationDate = Convert.ToDateTime(tbDate.Text);
            //opp.TotalNumberSlots = Convert.ToInt32(tbSlot.Text);
            //opp.TimeCommittment = ddlTimeCommitment.SelectedItem.Value;

            //if (Session["OppId"] != null && Session["IsClone"] == null)
            //{
            //    opp.OpportunityId = Convert.ToInt32(Session["OppId"].ToString());
            //    opp.Update();
            //    lblEmpty.Text = "The opportunity was updated successfully. Please refresh the Opportunity page to review. Please close the window.";
            //}
            //else
            //{
            //    opp.Add();
            //    lblEmpty.Text = "New opportunity was added successfully. Please refresh the Opportunity page to review. Please close the window.";
            //}
            //clickedButton.Text = "...done...";
            //Session["OppId"] = null;
            //Session["IsClone"] = null;
        }

        protected void RegistrationConfirmationPage(object sender, EventArgs e)
        {
            int studentId = Convert.ToInt32(Session["Student_StudentID"]);
            int opportunityId = Convert.ToInt32(Session["Student_SelectedOpportunityID"]);
            //Response.Write("<script>window.open('RegistrationConfirmation.aspx','_blank');</script>");
            //this.ClientScript.RegisterClientScriptBlock(this.GetType(), "Close", "window.close()", true);
            OpportunityRegistered opportunityRegistered = new OpportunityRegistered();
            bool registrationResult = opportunityRegistered.RegisterOpportunity(studentId, opportunityId);

            if (registrationResult)
            {
                Response.Write("<script>window.open('RegistrationConfirmation.aspx','_blank');</script>");
                this.ClientScript.RegisterClientScriptBlock(this.GetType(), "Close", "window.close()", true);
            }
            else
            {
                lblAgreementCheckboxFullLegalNameWarning.Text = "Something went wrong with registration for this opportunity. Please check with administrator.";
            }
        }

        protected void ClosePage(object sender, EventArgs e)
        {
            this.ClientScript.RegisterClientScriptBlock(this.GetType(), "Close", "window.close()", true);
        }
        protected void Check_Clicked(Object sender, EventArgs e)
        {
            validation();
        }
        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            validation();
        }
        protected void validation()
        {
            int studentID = Convert.ToInt32(Session["Student_StudentID"]);
            Profile studentProfile = new Profile().GetStudentProfile(studentID);
            string studentFullLegalName = studentProfile.FirstName + " " + studentProfile.LastName;

            if (cboxReadAgreement.Checked == true && tboxFullLegalName.Text == studentFullLegalName)
            {
                btnConfirm.Enabled = true;
                lblAgreementCheckboxFullLegalNameWarning.Text = "";
            }
            else
            {
                btnConfirm.Enabled = false;
                cboxReadAgreement.Checked = false;
                lblAgreementCheckboxFullLegalNameWarning.Text = "Please select checkbox and enter full legal name correctly!";
            }
        }
    }
}