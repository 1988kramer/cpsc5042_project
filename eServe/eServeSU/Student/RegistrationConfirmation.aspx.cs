using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eServeSU
{
    public partial class RegistrationConfirmation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataBind();
            }
        }

        private void DataBind()
        {
            int opportunityID = Convert.ToInt32(Session["Student_SelectedOpportunityID"]);
            OpportunityDetail opportunityDetail = new OpportunityDetail();
            OpportunityDetail detail = opportunityDetail.GetOpportunityDetailById(opportunityID);

            lblPositionAtOrganization.Text = detail.OpportunityName + " at " + detail.OrganizationName;
            lblOpportunityDesc.Text = detail.OpportunityName + " " + detail.OrganizationDesc;
            lblLocationValue.Text = detail.Location;
            lblTimeCommitmentValue.Text = detail.TimeCommittment;
            lblSiteSuperVisotrNameandAddressValue.Text = detail.SiteSupervisorName + ", " + detail.SiteSupervisorEmail;
            lblBackgroundCheckRequiredValue.Text = detail.BackgroundCheck;
            lblMinimumAgeValue.Text = detail.MinimumAge;
            lblLinkValue.Text = detail.Link;
            lblOtherRequirementsValue.Text = detail.OtherRequirements;
        }
        protected void ClosePage(object sender, EventArgs e)
        {
            this.ClientScript.RegisterClientScriptBlock(this.GetType(), "Close", "window.close()", true);
            Response.Write("<script>window.open('StudentRegistered.aspx','_blank');</script>");
        }
    }
}