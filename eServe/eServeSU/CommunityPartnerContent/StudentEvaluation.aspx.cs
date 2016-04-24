using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eServeSU
{
    public partial class StudentEvaluation : System.Web.UI.Page
    {
        string studentIDParameter;
        string opportunityIDParameter;
        protected void Page_Load(object sender, EventArgs e)
        {

            studentIDParameter = Request.QueryString["StudentID"];
            opportunityIDParameter = Request.QueryString["OpportunityID"];
            if (!IsPostBack)
                DataBind();
        }
    public void DataBind()
        {
            OpportunityEvaluation OppEval = new OpportunityEvaluation();
            //OppEval.StudentID = Convert.ToInt32(studentIDParameter);
            //OppEval.OpportunityID = Convert.ToInt32(opportunityIDParameter);
            OppEval.StudentID = 101946;
            OppEval.OpportunityID = 5;

            OppEval.GetStudentEvaluation();
            tbOrgName.Text = OppEval.OrganizationName;
            tblike.Text = OppEval.Answer1;
            tbleast.Text = OppEval.Answer2;
            tbContinue.Text = OppEval.Answer3;
            tbRecommend.Text = OppEval.Answer4;
            tbRate1.Text = OppEval.Rate1;
            tbRate2.Text = OppEval.Rate2;
            tbRate3.Text = OppEval.Rate3;
            tbRate4.Text = OppEval.Rate4;
            tbRate5.Text = OppEval.Rate5;
            tbRate6.Text = OppEval.Rate6;
            tbComments.Text = OppEval.Comments;
            
        }

    
    }
}