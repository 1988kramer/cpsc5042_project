using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using eServeSU.Student;

namespace eServeSU
{
    public partial class RegistrationDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataBind();                
            }
        }

        private void CheckMinimumAgeRequirement(int minimumAgeRequirement)
        {
            int studentID = Convert.ToInt32(Session["Student_StudentID"]);
            Profile studentProfile = new Profile().GetStudentProfile(studentID);                   
            DateTime studentDOB = Convert.ToDateTime(studentProfile.DateOfBirth);
            int studentAge = DateTime.Today.Year - studentDOB.Year;

            if (studentAge < minimumAgeRequirement)
            {
                btnSignup.Enabled = false;
                lblMinimumAgeWarning.Text = "Sorry, you do not meet the minimum age requirement!";
            }
        }
        private void DataBind()
        {
            int opportunityID = Convert.ToInt32(Session["Student_SelectedOpportunityID"]);
            OpportunityDetail opportunityDetail = new OpportunityDetail();
            OpportunityDetail detail = opportunityDetail.GetOpportunityDetailById(opportunityID);

            lblPageTitle.Text = detail.OrganizationName + ": " + detail.OpportunityName;
            lblOrganization.Text = detail.OrganizationName;
            lblOrganizationDesc.Text = detail.OrganizationDesc; 
            lblOpportunity.Text = detail.OpportunityName;
            lblOpportunityDesc.Text = detail.OpportunityDesc;
            lblLocationValue.Text = detail.Location;
            lblTimeCommitmentValue.Text = detail.TimeCommittment;
            lblSiteSuperVisotrNameandAddressValue.Text = detail.SiteSupervisorName + ", " + detail.SiteSupervisorEmail;
            lblBackgroundCheckRequiredValue.Text = detail.BackgroundCheck;
            lblMinimumAgeValue.Text = detail.MinimumAge;
            lblLinkValue.Text = detail.Link;
            lblOtherRequirementsValue.Text = detail.OtherRequirements;

            CheckMinimumAgeRequirement(Convert.ToInt32(detail.MinimumAge));
        }
        protected void SignUpOpportunity(object sender, EventArgs e)
        {
            //Get the button that raised the event
            //LinkButton lnkEditView = (LinkButton)sender;
            //Get the row that contains this button
            //GridViewRow gvr = (GridViewRow)lnkEditView.NamingContainer;
            //Label lblOppId = (Label)gvr.FindControl("lblOppId");

            //Session["OppId"] = lblOppId.Text;
            //Session["IsClone"] = null;
            Response.Write("<script>window.open('RegistrationRiskRelease.aspx','_blank');</script>");
            this.ClientScript.RegisterClientScriptBlock(this.GetType(), "Close", "window.close()", true);
        }

        protected void ClosePage(object sender, EventArgs e)
        {
            this.ClientScript.RegisterClientScriptBlock(this.GetType(), "Close", "window.close()", true);
        }
    }
}