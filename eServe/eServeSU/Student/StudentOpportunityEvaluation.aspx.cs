using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eServeSU
{
    public partial class StudentOpportunityEvaluation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblOpportunityAndCPName.Text = Session["Student_SelectedOpportunityName"].ToString() + " at " + Session["Student_SelectedOrganizationName"];
            lblOrganizationName.Text = Session["Student_SelectedOrganizationName"].ToString();
        }

        private void DataBind()
        {
            
        }

        protected void btnSubmitEvaluation_Click(Object sender, EventArgs e)
        {
            OpportunityEvaluation opportunityEvaluation = new OpportunityEvaluation();
            opportunityEvaluation.StudentID = Convert.ToInt32(Session["Student_StudentID"]);
            opportunityEvaluation.OpportunityID = Convert.ToInt32(Session["Student_SelectedOpportunityID"]);
            opportunityEvaluation.OrganizationName = Session["Student_SelectedOrganizationName"].ToString();
            opportunityEvaluation.Answer1 = tboxQuestion01.Text;
            opportunityEvaluation.Answer2 = tboxQuestion02.Text;
            opportunityEvaluation.Answer3 = tboxQuestion03.Text;
            opportunityEvaluation.Answer4 = RadioButtonList7.SelectedValue;
            opportunityEvaluation.Rate1 = RadioButtonList1.SelectedValue;
            opportunityEvaluation.Rate2 = RadioButtonList2.SelectedValue;
            opportunityEvaluation.Rate3 = RadioButtonList3.SelectedValue;
            opportunityEvaluation.Rate4 = RadioButtonList4.SelectedValue;
            opportunityEvaluation.Rate5 = RadioButtonList5.SelectedValue;
            opportunityEvaluation.Rate6 = RadioButtonList6.SelectedValue;
            opportunityEvaluation.Comments = tboxShareComment.Text;

            opportunityEvaluation.SubmitOpportunityEvaluation(opportunityEvaluation);

            this.ClientScript.RegisterClientScriptBlock(this.GetType(), "Close", "window.close()", true);
            Response.Write("<script>window.open('RegisteredDetail.aspx','_blank');</script>");
        }
    }
}