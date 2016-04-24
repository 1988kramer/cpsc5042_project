using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eServeSU
{
    public partial class StudentRegistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {            
            //if (!IsPostBack)
            //{
            //Session["Student_StudentID"] = 106288;
            DataBind();                
                //Session["Student_SelectedOpportunityID"] = null;
            //}
        }

        private void DataBind()
        {
            int studentId = Convert.ToInt32(Session["Student_StudentID"]);
            OpportunityRegistration opportunityRegistration = new OpportunityRegistration();

            List<OpportunityRegistration> oppList = opportunityRegistration.GetOpportunityListByStudentId(studentId);
            if (oppList.Count == 0)
            {
                OpportunityRegistration oppS = new OpportunityRegistration();
                oppList.Add(oppS);
                gvOpportunity.DataSource = oppList;
                gvOpportunity.DataBind();
                gvOpportunity.Rows[0].Visible = false;
            }
            else
            {
                gvOpportunity.DataSource = oppList;
                gvOpportunity.DataBind();
            }
        }

        protected void gvOpportunity_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            //Get the new Values.
            GridViewRow row = gvOpportunity.Rows[e.RowIndex];
            TextBox tbName = (TextBox)row.FindControl("tbName");
            TextBox tbLocation = (TextBox)row.FindControl("tbLocation");
            TextBox tbJobDes = (TextBox)row.FindControl("tbJobDes");
            Label lblOppId = (Label)row.FindControl("lblOppId");

            // Code to update the DataSource.
            Opportunity opp = new Opportunity();
            opp.Name = tbName.Text;
            opp.Location = tbLocation.Text;
            opp.JobDescription = tbJobDes.Text;
            opp.OpportunityId = Convert.ToInt32(lblOppId.Text);

            opp.Update();

            //Reset the edit index.
            gvOpportunity.EditIndex = -1;
            //Bind data to the GridView control.
            DataBind();
        }

        protected void gvOpportunity_RowEditing(object sender, GridViewEditEventArgs e)
        {
            //Set the edit index.
            gvOpportunity.EditIndex = e.NewEditIndex;
            //Bind data to the GridView control.
            DataBind();
        }
        protected void gvOpportunity_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            //Reset the edit index.
            gvOpportunity.EditIndex = -1;
            //Bind data to the GridView control.
            DataBind();
        }
        protected void ViewOpportunityDetails(object sender, EventArgs e)
        {
            //Get the button that raised the event
            LinkButton lnkEditView = (LinkButton)sender;
            //Get the row that contains this button
            GridViewRow gvr = (GridViewRow)lnkEditView.NamingContainer;
            Label lblOppId = (Label)gvr.FindControl("lblOppId");

            //Session["OppId"] = lblOppId.Text;
            //Session["IsClone"] = null;
            Session["Student_SelectedOpportunityID"] = lblOppId.Text; 
            Response.Write("<script>window.open('RegistrationDetail.aspx','_blank');</script>");
        }
        //protected void ViewOpportunityDetails(object sender, EventArgs e)
        //{
        //    //Get the button that raised the event
        //    LinkButton lnkRegister = (LinkButton)sender;
        //    //Get the row that contains this button
        //    GridViewRow gvr = (GridViewRow)lnkRegister.NamingContainer;
        //    Label lblOppId = (Label)gvr.FindControl("lblOppId");

        //    //Session["OppId"] = lblOppId.Text;
        //    //Session["IsClone"] = true;            
        //    Session["Student_OpportunityID"] = lblOppId.Text; 
        //    Response.Write("<script>window.open('Opportunity.aspx','_blank');</script>");
        //}
    }
}