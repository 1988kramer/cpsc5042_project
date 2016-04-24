using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eServeSU
{
    public partial class FacultyCourseOpportunity : System.Web.UI.Page
    {
        private int _professorId = 1; //need change to login professor id

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                DataBind();
            }
        }
        private void DataBind()
        {
            Faculty fac = new Faculty();
            List<Faculty> facList = fac.GetStudentCourseOppListForFaculty(_professorId);
            if (facList.Count == 0)
            {
                Faculty facS = new Faculty();
                facList.Add(facS);
                gvOpportunityFaculty.DataSource = facList;
                gvOpportunityFaculty.DataBind();
                gvOpportunityFaculty.Rows[0].Visible = false;
            }
            else
            {
                gvOpportunityFaculty.DataSource = facList;
                gvOpportunityFaculty.DataBind();
            }
        }

        protected void ViewPartnerEvaluation(object sender, EventArgs e)
        {
            //Get the button that raised the event
            LinkButton lnkEvaluation = (LinkButton)sender;
            //Get the row that contains this button
            GridViewRow gvr = (GridViewRow)lnkEvaluation.NamingContainer;
            Label lblOppId = (Label)gvr.FindControl("lblOppId");
            Label lblStudentId = (Label)gvr.FindControl("lblStudentId");
            Label lblOppStudentId = (Label)gvr.FindControl("lblOppStudentId");

            Session["FacultyOppStudentId"] = lblOppStudentId.Text;
            Response.Write("<script>window.open('FacultyOppStudentEvaluation.aspx','_blank');</script>");
        }

        protected void ViewStudentEvaluation(object sender, EventArgs e)
        {
            //Get the button that raised the event
            LinkButton lnkSEvaluation = (LinkButton)sender;
            //Get the row that contains this button
            GridViewRow gvr = (GridViewRow)lnkSEvaluation.NamingContainer;
            Label lblOppId = (Label)gvr.FindControl("lblOppId");
            Label lblStudentId = (Label)gvr.FindControl("lblStudentId");
            Label lblOppStudentId = (Label)gvr.FindControl("lblOppStudentId");

            Session["FacultyOppId"] = lblOppStudentId.Text;
            Response.Write("<script>window.open('FacultyOppPartnerEvaluation.aspx','_blank');</script>");
        }
    }
}