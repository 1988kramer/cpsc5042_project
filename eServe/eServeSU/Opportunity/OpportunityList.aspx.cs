using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eServeSU
{
    public partial class Opportunity_OpportunityList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataBind();
                Session["OppId"] = null;
                Session["IsClone"] = null;
            }
        }

        private void DataBind()
        {
            Opportunity opp = new Opportunity();
            List<Opportunity> oppList = opp.GetAllOpportunities();
            if (oppList.Count == 0)
            {
                Opportunity oppS = new Opportunity();
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

        protected void gvOpportunity_OnRowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                LinkButton lbRemove = (LinkButton)e.Row.FindControl("lnkRemove");
                Label lblStatus = ((Label)e.Row.FindControl("lblStatus"));
                string status = lblStatus.Text.Trim();
                if (status == "Open")
                    lbRemove.Text = "";
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
        protected void DeleteOpportunity(object sender, EventArgs e)
        {
            //Get the button that raised the event
            LinkButton lbtn = (LinkButton)sender;
            //Get the row that contains this button
            GridViewRow gvr = (GridViewRow)lbtn.NamingContainer;

            Label lblOppId = (Label)gvr.FindControl("lblOppId");

            //datasource
            Opportunity opp = new Opportunity();
            opp.OpportunityId = Convert.ToInt32(lblOppId.Text);
            opp.Delete();

            DataBind();
        }
        protected void AddNewOpportunity(object sender, EventArgs e)
        {
            //Get the button that raised the event
            Button btnAdd = (Button)sender;
            Response.Write("<script>window.open('Opportunity.aspx','_blank');</script>");
        }

        protected void EditViewOpportunity(object sender, EventArgs e)
        {
            //Get the button that raised the event
            LinkButton lnkEditView = (LinkButton)sender;
            //Get the row that contains this button
            GridViewRow gvr = (GridViewRow)lnkEditView.NamingContainer;
            Label lblOppId = (Label)gvr.FindControl("lblOppId");

            Session["OppId"] = lblOppId.Text;
            Session["IsClone"] = null;
            Response.Write("<script>window.open('Opportunity.aspx','_blank');</script>");
        }
        protected void CloneOpportunity(object sender, EventArgs e)
        {
            //Get the button that raised the event
            LinkButton lnkClone = (LinkButton)sender;
            //Get the row that contains this button
            GridViewRow gvr = (GridViewRow)lnkClone.NamingContainer;
            Label lblOppId = (Label)gvr.FindControl("lblOppId");

            Session["OppId"] = lblOppId.Text;
            Session["IsClone"] = true;
            Response.Write("<script>window.open('Opportunity.aspx','_blank');</script>");
        }

   
    }
}