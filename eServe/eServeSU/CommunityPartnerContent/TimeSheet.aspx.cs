using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eServeSU
{
    public partial class TimeSheet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            
            if (!IsPostBack)

                DataBind();
            Session["StudentID"] = 101946;
            Session["OpportunityID"] = 5;
            //Session["WorkDate"] = 2 / 13 / 2014;
        }

        public void DataBind()
        {
            
           // int OpportunityID = Convert.ToInt32(Session["OpportunityID"]);
            //int StudentID = Convert.ToInt32(Session["StudentID"]);
            //int CPPID = Convert.ToInt32(Session["CPPID"]);
             StudentTimeEntry Ste = new StudentTimeEntry();
             List<StudentTimeEntry> Lste = Ste.GetTimeEntries(101946,5);
             if (Lste.Count == 0)
             {
                 StudentTimeEntry TimeEntry = new StudentTimeEntry();
                 Lste.Add(TimeEntry);
                 gvTimeSheet.DataSource = Lste;
                 gvTimeSheet.DataBind();
                 gvTimeSheet.Rows[0].Visible = false;
             }
             else
            
                gvTimeSheet.DataSource = Lste;
                gvTimeSheet.DataBind();
            
        }
        protected void gvTimeSheet_OnRowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                Label lblWorkDate = (Label)e.Row.FindControl("WorkDate");
                Label lblHours = ((Label)e.Row.FindControl("lblHours"));
                Label lblPartnerHours = (Label)e.Row.FindControl("lblPartnerHours");
                Label lblOpportunityID = (Label)e.Row.FindControl("lblOpportunityID");
                Label lblStudentID = (Label)e.Row.FindControl("lblStudentID");
                TextBox tbPartnerHours = (TextBox)e.Row.FindControl("tbPartnerHours");
                Button btnEdit = (Button)e.Row.FindControl("btnEdit");
                
          
            }

        }


        protected void gvTimeSheet_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            //Get the new Values.
          GridViewRow row = gvTimeSheet.Rows[e.RowIndex];
          Label  lblWorkDate = (Label)row.FindControl("lblWorkDate");
          Label lblHours = (Label)row.FindControl("lblHours");
          Label lblPartnerHours = (Label)row.FindControl("lblPartnerHours");
          TextBox tbPartnerHours = (TextBox)row.FindControl("tbPartnerHours");
          Label lblOpportunityID = (Label)row.FindControl("lblOpportunityID");
          Label lblStudentID = (Label)row.FindControl("lblStudentID");

            // Code to update the DataSource.
            StudentTimeEntry Ste = new StudentTimeEntry();
            Ste.PartnerApprovedHours = Convert.ToInt32(tbPartnerHours.Text);
            Ste.OpportunityID = Convert.ToInt32(Session["OpportunityID"]);
            Ste.StudentID = Convert.ToInt32(Session["StudentID"]);
            Ste.WorkDate = lblWorkDate.Text;

            Ste.UpdatePartnerHours();

            //Reset the edit index.
            gvTimeSheet.EditIndex = -1;
            //Bind data to the GridView control.
            DataBind();
        }



        protected void gvTimeSheet_RowEditing(object sender, GridViewEditEventArgs e)
        {
            //Set the edit index.
            gvTimeSheet.EditIndex = e.NewEditIndex;
            //Bind data to the GridView control.
            DataBind();
        }

        protected void gvTimeSheet_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            //Reset the edit index.
            gvTimeSheet.EditIndex = -1;
            //Bind data to the GridView control.
            DataBind();
        }

        protected void EditUpdatePartnerHours(object sender, EventArgs e)
        {// Get the button that raised this event
            Button btnEdit = (Button) sender;

            //Get the button that raised this event
            GridViewRow gvr = (GridViewRow)btnEdit.NamingContainer;
            Label lblWorkDate = (Label)gvr.FindControl("lblWorkDate");
            Label lblHours = (Label)gvr.FindControl("lblHours");
            Label lblPartnerHours = (Label)gvr.FindControl("lblPartnerHours");
            TextBox tbPartnerHours = (TextBox)gvr.FindControl("tbPartnerHours");
            Label lblOpportunityID = (Label)gvr.FindControl("lblOpportunityID");
            Label lblStudentID = (Label)gvr.FindControl("lblStudentID");
            Session["OpportunityID"] = lblOpportunityID.Text;
            Session["StudentID"] = lblStudentID.Text;
            Session["WorkDate"] = Convert.ToDateTime (lblWorkDate.Text);

        }

        protected void gvTimeSheet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    
        }
    }
