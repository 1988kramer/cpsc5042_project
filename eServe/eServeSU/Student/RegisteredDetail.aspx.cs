using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using eServeSU;

namespace eServeSU
{
    public partial class RegisteredDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblOpportunityName.Text = "Timesheet for " + Session["Student_SelectedOpportunityName"].ToString();
            string ddd = Request.QueryString["studentid"];

            if (!IsPostBack)
            {
                DataBind();
                CheckEvaluationSubmitted();
                CheckReflectionSubmitted();
                //Session["Student_StudentID"] = 101946;
                //Session["Student_OpportunityID"] = 5;                
            }
        }
        private void DataBind()
        {            
            int studentId = Convert.ToInt32(Session["Student_StudentID"]);
            int opportunityId = Convert.ToInt32(Session["Student_SelectedOpportunityID"]);
            StudentTimeEntry studentTimeEntry = new StudentTimeEntry();
            List<StudentTimeEntry> studentTimeEntryList = studentTimeEntry.GetStudentTimeEntriesByOpportunityId(studentId, opportunityId);

            if (studentTimeEntryList.Count == 0)
            {
                StudentTimeEntry timeEntry = new StudentTimeEntry();
                studentTimeEntryList.Add(timeEntry);
                gvTimeEntry.DataSource = studentTimeEntryList;
                gvTimeEntry.DataBind();
                gvTimeEntry.Rows[0].Visible = false;
            }
            else
            {
                gvTimeEntry.DataSource = studentTimeEntryList;
                gvTimeEntry.DataBind();
            }
        }

        private void CheckEvaluationSubmitted()
        {
            int studentId = Convert.ToInt32(Session["Student_StudentID"]);
            int opportunityId = Convert.ToInt32(Session["Student_SelectedOpportunityID"]);
            StudentSubmission studentSubmission = new StudentSubmission();
            bool isSubmitted = studentSubmission.CheckStudentEvaluationSubmitted(studentId, opportunityId);

            if (isSubmitted == true)
            {
                btnSubmitEvaluation.Enabled = false;
            }
        }

        private void CheckReflectionSubmitted()
        {
            int studentId = Convert.ToInt32(Session["Student_StudentID"]);
            int opportunityId = Convert.ToInt32(Session["Student_SelectedOpportunityID"]);
            StudentSubmission studentSubmission = new StudentSubmission();
            bool isSubmitted = studentSubmission.CheckStudentReflectionSubmitted(studentId, opportunityId);

            if (isSubmitted == true)
            {
                btnSubmitReflection.Enabled = false;
            }
        }

        protected void btnSubmitEvaluation_Click(Object sender, EventArgs e)
        {
            Response.Write("<script>window.open('StudentOpportunityEvaluation.aspx','_blank');</script>");
            this.ClientScript.RegisterClientScriptBlock(this.GetType(), "Close", "window.close()", true);
        }

        protected void btnSubmitReflection_Click(Object sender, EventArgs e)
        {
            Response.Write("<script>window.open('StudentReflection.aspx','_blank');</script>");
            this.ClientScript.RegisterClientScriptBlock(this.GetType(), "Close", "window.close()", true);
        }

        protected void btnSubmitHours_Click(Object sender, EventArgs e)
        {
            validation();

            tboxDateVolunteered.Text = string.Empty;
            tboxHoursVolunteered.Text = string.Empty;
            DataBind();
        }
        protected void validation()
        {
            if (tboxDateVolunteered.Text == "" || tboxHoursVolunteered.Text == "")
            {
                lblTimeEntryWarning.Text = "Please entry a date and volunteered hour(s)";
            }
            else
            {
                lblTimeEntryWarning.Text = "";

                StudentTimeEntry studentTimeEntry = new StudentTimeEntry();
                studentTimeEntry.WorkDate = tboxDateVolunteered.Text;
                studentTimeEntry.OpportunityID = Convert.ToInt32(Session["Student_SelectedOpportunityID"]);
                studentTimeEntry.StudentID = Convert.ToInt32(Session["Student_StudentID"]);
                studentTimeEntry.CPPID = 2;
                studentTimeEntry.PartnerApprovedHours = 0;
                studentTimeEntry.TimeEntryDate = DateTime.Today.ToShortDateString();
                studentTimeEntry.HoursVolunteered = Convert.ToInt32(tboxHoursVolunteered.Text);

                studentTimeEntry.SubmitStudentTimeEntry(studentTimeEntry);    
            }
        }
        protected void gvTimeEntry_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            //Get the new Values.
            GridViewRow row = gvTimeEntry.Rows[e.RowIndex];
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
            gvTimeEntry.EditIndex = -1;
            //Bind data to the GridView control.
            DataBind();
        }

        protected void gvTimeEntry_RowEditing(object sender, GridViewEditEventArgs e)
        {
            //Set the edit index.
            gvTimeEntry.EditIndex = e.NewEditIndex;
            //Bind data to the GridView control.
            DataBind();
        }
        protected void gvTimeEntry_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            //Reset the edit index.
            gvTimeEntry.EditIndex = -1;
            //Bind data to the GridView control.
            DataBind();
        }
    }
}