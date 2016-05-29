using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using eServeSU;

namespace eServeSU
{
    public partial class StudentRegistered : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {            
            loadDataTable();
            Session["Student_StudentID"] = 106288;
            DataBind();            
            Session["Student_OpportunityIDForSubmittingHours"] = null;
        }
        public override void DataBind()
        {           
            int studentId = Convert.ToInt32(Session["Student_StudentID"]);            
            OpportunityRegistered opportunityRegistered = new OpportunityRegistered();
            List<OpportunityRegistered> result = opportunityRegistered.GetOpportunityRegisteredByStudentId(studentId);
            StudentHours studenthours = new StudentHours();
            for (int i = 0; i < result.Count; i++)
            {
                StudentHours hours = studenthours.GetVolunteeredAndPartnerApprovedHours(result[i].StudentId, result[i].OpportunityID);
                result[i].HoursVolunteered = hours.HoursVolunteered + " / " + hours.PartnerApprovedHours;
            }

            Quarter quarter = new Quarter();
            string currentQuarter = quarter.GetCurrentQuarterName();
            string filterItem = DropDownList1.SelectedItem.Text;
            if (filterItem == "Current")
            {
                for (int i = 0; i < result.Count; i++)
                {
                    if (result[i].Quarter != currentQuarter)
                    {
                        result.Remove(result[i]);
                    }
                }
            }            

            if (result.Count == 0)
            {
                OpportunityRegistered oppS = new OpportunityRegistered();
                result.Add(oppS);
                gvOpportunity.DataSource = result;
                gvOpportunity.DataBind();
                gvOpportunity.Rows[0].Visible = false;
            }
            else
            {
                gvOpportunity.DataSource = result;
                gvOpportunity.DataBind();
            }
        }
        protected void EditViewRegistered(object sender, EventArgs e)
        {
            //Get the button that raised the event
            LinkButton lnkEditView = (LinkButton)sender;
            //Get the row that contains this button
            GridViewRow gvr = (GridViewRow)lnkEditView.NamingContainer;
            Label selectedOpportunityID = (Label)gvr.FindControl("lblOppId");
            Label selectedOpportunityName = (Label)gvr.FindControl("lblOpportunity");
            Label selectedOrganizationName = (Label)gvr.FindControl("lblOrganization");

            Session["Student_SelectedOpportunityID"] = selectedOpportunityID.Text;
            Session["Student_SelectedOpportunityName"] = selectedOpportunityName.Text;
            Session["Student_SelectedOrganizationName"] = selectedOrganizationName.Text;      
            //Response.Write("<script>window.open('RegisteredDetail.aspx','_blank');</script>");
            Response.Write("<script>window.open('RegisteredDetail.aspx?studentid="+106288+"','_blank');</script>");
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

        private void loadDataTable()
        {
            int studentId = 106288;
            
            OpportunityRegistered opportunityRegistered = new OpportunityRegistered();

            List<OpportunityRegistered> result = opportunityRegistered.GetOpportunityRegisteredByStudentId(studentId);

            DataColumn academicTerm = new DataColumn("Quarter", Type.GetType("System.String"));
            DataColumn course = new DataColumn("Course", Type.GetType("System.String"));
            DataColumn organization = new DataColumn("Organization", Type.GetType("System.String"));
            DataColumn emailId = new DataColumn("EmailId", Type.GetType("System.String"));
            DataColumn status = new DataColumn("Status", Type.GetType("System.String"));
            DataColumn hoursVolunteered = new DataColumn("Hours Volunteered", Type.GetType("System.String"));
            DataColumn partnerEvaluation = new DataColumn("Partner Evaluation", Type.GetType("System.String"));
            DataColumn studentEvaluation = new DataColumn("Student Evaluation", Type.GetType("System.String"));
            DataColumn studentReflection = new DataColumn("Student Reflection", Type.GetType("System.String"));

            DataTable dt = new DataTable();
            dt.Columns.Add(academicTerm);
            dt.Columns.Add(course);
            dt.Columns.Add(organization);
            dt.Columns.Add(emailId);
            dt.Columns.Add(status);
            dt.Columns.Add(hoursVolunteered);
            dt.Columns.Add(partnerEvaluation);
            dt.Columns.Add(studentEvaluation);
            dt.Columns.Add(studentReflection);

            for (int i = 0; i < result.Count; i++)
            {
                DataRow dr = dt.NewRow();

                dr["OpportunityID"] = result[i].OpportunityID;
                dr["Quarter"] = result[i].Quarter;
                dr["Course"] = result[i].Course;
                dr["Organization"] = result[i].Organization;
                dr["EmailId"] = result[i].EmailId;
                dr["Status"] = result[i].Status;
                dr["Hours Volunteered"] = result[i].HoursVolunteered; 
                dr["Partner Evaluation"] = result[i].ParternEvaluation; 
                dr["Student Evaluation"] = result[i].StudentEvaluation; 
                dr["Student Reflection"] = result[i].StudentReflection; 

                dt.Rows.Add(dr);
            }

            DataSet ds = new DataSet();
            ds.Tables.Add(dt);

            gvOpportunity.DataSource = ds.Tables[0];
            gvOpportunity.DataBind();
        }


    }
}