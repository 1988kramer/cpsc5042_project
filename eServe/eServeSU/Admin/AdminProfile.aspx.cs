using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Saplin.Controls;

namespace eServeSU
{
    public partial class AdminProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                DataBind();
                OtherOpportunityDataBind();
            }
        }
        private void DataBind()
        {   
            Opportunity opp = new Opportunity();
            List<Opportunity> oppList = opp.GetOpportunityListForAdmin();
            if (oppList.Count == 0)
            {
                Opportunity oppS = new Opportunity();
                oppList.Add(oppS);
                gvOpportunityAdmin.DataSource = oppList;
                gvOpportunityAdmin.DataBind();
                gvOpportunityAdmin.Rows[0].Visible = false;
            }
            else
            {
                gvOpportunityAdmin.DataSource = oppList;
                gvOpportunityAdmin.DataBind();
            }
        }

        private void OtherOpportunityDataBind()
        {
            Opportunity opp = new Opportunity();

            ddlOtherOpportunity.DataSource = opp.GetAllOpportunities();
            ddlOtherOpportunity.DataTextField = "Name";
            ddlOtherOpportunity.DataValueField = "OpportunityID";
            ddlOtherOpportunity.DataBind();
        }

        protected void gvOpportunityAdmin_OnRowDataBound(object sender, GridViewRowEventArgs e)
        {
           CourseSection cs = new CourseSection();
            
            if (e.Row.RowType == DataControlRowType.DataRow)
            {   
                Label lblStatus = ((Label)e.Row.FindControl("lblStatus"));
                Label lblOppId = ((Label)e.Row.FindControl("lblOppId"));
                
                string status = lblStatus.Text.Trim();
                if (status == "Pending")
                    lblStatus.ForeColor = System.Drawing.Color.Red;

                DropDownCheckBoxes ddckAddCourseSections = ((DropDownCheckBoxes)e.Row.FindControl("ddckAddCourseSections"));
                ddckAddCourseSections.DataSource = cs.GetUnAssignedCourseSection(Convert.ToInt32(lblOppId.Text));
                ddckAddCourseSections.DataTextField = "CourseSectionDisplayName";
                ddckAddCourseSections.DataValueField = "SectionID";
                ddckAddCourseSections.DataBind();

                DropDownCheckBoxes ddckRemoveCourseSections = ((DropDownCheckBoxes)e.Row.FindControl("ddckRemoveCourseSections"));
                ddckRemoveCourseSections.DataSource = cs.GetAssignedCourseSection(Convert.ToInt32(lblOppId.Text));
                ddckRemoveCourseSections.DataTextField = "CourseSectionDisplayName";
                ddckRemoveCourseSections.DataValueField = "SectionID";
                ddckRemoveCourseSections.DataBind();
            }
        }

        protected void ViewOpportunityDetail(object sender, EventArgs e)
        {
            //Get the button that raised the event
            LinkButton lnkViewDetail = (LinkButton)sender;
            //Get the row that contains this button
            GridViewRow gvr = (GridViewRow)lnkViewDetail.NamingContainer;
            Label lblOppId = (Label)gvr.FindControl("lblOppId");

            Session["AdminOppId"] = lblOppId.Text;
            Response.Write("<script>window.open('AdminApproval.aspx','_blank');</script>");
        }

        protected void checkBoxesAdd_SelcetedIndexChanged(object sender, EventArgs e)
        {
            //Get the button that raised the event
            ListControl ddcbListControl = (ListControl) sender;
            //Get the row that contains this button
            GridViewRow gvr = (GridViewRow) ddcbListControl.NamingContainer;
            Label lblOppId = (Label) gvr.FindControl("lblOppId");

            int oppId = Convert.ToInt32(lblOppId.Text);
            string courseSectionIDs = string.Empty;

            foreach (ListItem item in (sender as ListControl).Items)
            {
                if (item.Selected)
                    courseSectionIDs += ";" + item.Value;
            }
            if (!string.IsNullOrEmpty(courseSectionIDs) && courseSectionIDs.Length > 1)
            {
                courseSectionIDs = courseSectionIDs.Substring(1);
                CourseSection cs = new CourseSection();
                cs.AddCourseSectionToOpportunity(oppId, courseSectionIDs);
                DataBind();
            }
        }
        protected void checkBoxesRemove_SelcetedIndexChanged(object sender, EventArgs e)
        {
            //Get the button that raised the event
            ListControl ddcbListControl = (ListControl)sender;
            //Get the row that contains this button
            GridViewRow gvr = (GridViewRow)ddcbListControl.NamingContainer;
            Label lblOppId = (Label)gvr.FindControl("lblOppId");

            int oppId = Convert.ToInt32(lblOppId.Text);
            string courseSectionIDs = string.Empty;

            foreach (ListItem item in (sender as ListControl).Items)
            {
                if (item.Selected)
                    courseSectionIDs += ";" + item.Value;
            }

            if (!string.IsNullOrEmpty(courseSectionIDs) && courseSectionIDs.Length > 1)
            {
                courseSectionIDs = courseSectionIDs.Substring(1);
                CourseSection cs = new CourseSection();
                cs.RemoveCourseSectionFromOpportunity(oppId, courseSectionIDs);
                DataBind();
            }
        }

        protected void tbnClick_Assign(Object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            int opportunityID = Convert.ToInt32(ddlOtherOpportunity.SelectedValue);
            string studentEmail = tbStudentEmail.Text;

            OpportunitySectionStudent oss = new OpportunitySectionStudent();
            oss.AssignOpportunityToStudentByAdmin(opportunityID, studentEmail);

            tbLabel.Text = "Succeed!";
        }
    }
}