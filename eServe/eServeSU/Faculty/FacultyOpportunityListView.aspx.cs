using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eServeSU
{
    public partial class FacultyOpportunityListView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                DataBind();
            }
        }
        private void DataBind()
        {
            Opportunity opp = new Opportunity();
            List<Opportunity> oppList = opp.GetOpportunityListForFaculty();
            if (oppList.Count == 0)
            {
                Opportunity oppS = new Opportunity();
                oppList.Add(oppS);
                gvOpportunityFaculty.DataSource = oppList;
                gvOpportunityFaculty.DataBind();
                gvOpportunityFaculty.Rows[0].Visible = false;
            }
            else
            {
                gvOpportunityFaculty.DataSource = oppList;
                gvOpportunityFaculty.DataBind();
            }
        }
      
        protected void ViewOpportunityDetail(object sender, EventArgs e)
        {
            //Get the button that raised the event
            LinkButton lnkViewDetail = (LinkButton)sender;
            //Get the row that contains this button
            GridViewRow gvr = (GridViewRow)lnkViewDetail.NamingContainer;
            Label lblOppId = (Label)gvr.FindControl("lblOppId");

            Session["FacultyOppId"] = lblOppId.Text;
            Response.Write("<script>window.open('FacultyOppDetail.aspx','_blank');</script>");
        }
    }
}