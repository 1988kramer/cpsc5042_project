using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eServeSU
{
    public partial class StudentReflection : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblOpportunityAndCPName.Text = Session["Student_SelectedOpportunityName"].ToString() + " at " + Session["Student_SelectedOrganizationName"];         
        }
        protected void btnSubmitReflection_Click(Object sender, EventArgs e)
        {
            OpportunityStudentReflection opportunityStudentReflection = new OpportunityStudentReflection();
            opportunityStudentReflection.StudentID = Convert.ToInt32(Session["Student_StudentID"]);
            opportunityStudentReflection.OpportunityID = Convert.ToInt32(Session["Student_SelectedOpportunityID"]);
            opportunityStudentReflection.StudentReflection = tboxStudentReflection.Text;

            opportunityStudentReflection.SubmitOpportunitySelfReflection(opportunityStudentReflection);

            this.ClientScript.RegisterClientScriptBlock(this.GetType(), "Close", "window.close()", true);
            Response.Write("<script>window.open('RegisteredDetail.aspx','_blank');</script>");
        }
    }
}