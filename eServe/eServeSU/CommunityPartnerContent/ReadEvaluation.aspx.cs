using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eServeSU
{
    public partial class ReadEvaluation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session["CPID"] = null;
                DataBind();
                
                Session["OpportunityID"] = 5;
                Session["StudentID"] = 101946;
            }
        }

        public void DataBind()
        {

            StudentCourseEvaluation sce = new StudentCourseEvaluation();

            List<StudentCourseEvaluation> sceList = new List<StudentCourseEvaluation>();
            sceList = sce.GetAllCourseEvaluation();

            gvEvaluations.DataSource = sceList;
            gvEvaluations.DataBind();

        }

        protected void gvEvaluations_OnRowDataBound(object sender, GridViewRowEventArgs e)
        {
               if (e.Row.RowType == DataControlRowType.DataRow)
               {

                   HyperLink    hlnkEval = (HyperLink    )e.Row.FindControl("hlnkEval");
               }
        }

        protected void gvEvaluations_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        
            //Get the button that raised the event
           HyperLink  hlnkEval = (HyperLink )sender;
           // Get the row that contains this button
            GridViewRow gvr = (GridViewRow)hlnkEval.NamingContainer;
            Label OpportunityID = (Label)gvr.FindControl("lblOpportunityID");
            Label StudentID = (Label)gvr.FindControl("lblStudentID");

            StudentCourseEvaluation sce = new StudentCourseEvaluation();
            sce.OpportunityID = Convert.ToInt32 (Session["OpportunityID"]);
            sce.StudentID = Convert.ToInt32(Session["StudentID"]);




            // Response.Write("<script>window.open('~/CommunityPartnerContent/StudentEvaluation.aspx?OpportunityID='Convert.ToInt32 (Session["OpportunityID"]) ; 'StudentID=' Convert.ToInt32(Session["StudentID"]) );</script>");
            
            

            
            
            
        
        }



        
 
    }
}