using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eServeSU
{
    public partial class CommunityPartnerStudentView : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e) //triggered upon load of page - calls databind
        {
            if (!IsPostBack)
                DataBind();
            Session["OpportunityID"] = 11;
            Session["StudentID"] = 106288;
        }

        public void DataBind()
        {
            CommunityPartnerStudentViews Cpsv = new CommunityPartnerStudentViews();
            List<CommunityPartnerStudentViews> CpsvList = Cpsv.GetAllCommunityPartnerStudentView(); //calls sql statements from this class which are returned as list


            if (CpsvList.Count == 0) //if no rows returned
            {
                CommunityPartnerStudentViews cpsv = new CommunityPartnerStudentViews();
                CpsvList.Add(cpsv);
                gvCommunityPartnerStudentView.DataSource = CpsvList;
                gvCommunityPartnerStudentView.DataBind();
                gvCommunityPartnerStudentView.Rows[0].Visible = false;

            }
            else
            {
                gvCommunityPartnerStudentView.DataSource = CpsvList;
                gvCommunityPartnerStudentView.DataBind();
            }
        }

        protected void gvCommunityPartnerStudentView_OnRowDataBound(object sender, GridViewRowEventArgs e)
        {
             if (e.Row.RowType == DataControlRowType.DataRow)
             {
                 LinkButton lbtnStudent = (LinkButton)e.Row.FindControl("lbtnStudent");
                 HyperLink  lbtnProfessor = (HyperLink)e.Row.FindControl("lbtnProfessor");
                 DropDownList lblSignUpStatus = ((DropDownList)e.Row.FindControl("lblSignUpStatus"));
                 TextBox tbSignUpStatus = (TextBox)e.Row.FindControl("tbSignUpStatus");
                 LinkButton lbtnEdit = (LinkButton)e.Row.FindControl("lbtnEdit");
                 LinkButton  lbtnPartnerEval = (LinkButton )e.Row.FindControl("lbtnPartnerEval");


            }


        }

        protected void gvCommunityPartnerStudentView_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            //Get the new values
            GridViewRow row = gvCommunityPartnerStudentView.Rows[e.RowIndex];
            RadioButton   RadbtnToggle = (RadioButton  )row.FindControl("ddlSignUpStatus");
            Label lblOpportunityID = (Label)row.FindControl("lblOpportunityID");
            Label lblStudentID = (Label)row.FindControl("lblStudentID");
            Label lblCPPID = (Label)row.FindControl("lblCPPID");
            Label lblCPID = (Label)row.FindControl("lblCPID");

            SignUpFor signUpFor = new SignUpFor();
            
            signUpFor.StudentID = Convert.ToInt32(lblStudentID.Text);
            signUpFor.OpportunityID = Convert.ToInt32(lblOpportunityID.Text);
            signUpFor.CPPID = Convert.ToInt32(lblCPPID.Text);
            signUpFor.UpdateSignUpFor();

            //Reset the edit index.
            gvCommunityPartnerStudentView.EditIndex = -1;
            //Bind data to the GridView control.
            DataBind();



        }
        protected void gvCommunityPartnerStudentView_RowEditing(object sender, GridViewEditEventArgs e)
        {
            //Set the edit index.
            gvCommunityPartnerStudentView.EditIndex = e.NewEditIndex;
            //Bind data to the GridView control.
            DataBind();
        }
        protected void gvCommunityPartnerStudentView_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            //Reset the edit index.
            gvCommunityPartnerStudentView.EditIndex = -1;
            //Bind data to the GridView control.
            DataBind();
        }

        protected void EditSignUpStatus(object sender, EventArgs e)
        {
            //Get the button that raised this event
            DropDownList lblSignUpStatus = (DropDownList)sender; //changed - Hassan 6/2/16
            //Get the row that contains this button
            GridViewRow gvr = (GridViewRow)lblSignUpStatus.NamingContainer;
            
            Label lblOpportunityID = (Label)gvr.FindControl("lblOpportunityID");
            Label lblStudentID = (Label)gvr.FindControl("lblStudentID");
            Label lblProfessorID = (Label)gvr.FindControl("lblProfessorID");
            Label lblSectionID = (Label)gvr.FindControl("lblSectionID");
            Label lblCPPID = (Label)gvr.FindControl("lblCPPID");
            Label lblCPID = (Label)gvr.FindControl("lblCPID");
            Session["OpportunityID"] = lblOpportunityID.Text;
            Session["StudentID"] = lblStudentID.Text;
            Session["ProfessorID"] = lblProfessorID.Text;
            Session["CPPID"] = lblCPPID.Text;
            Session["CPID"] = lblCPID.Text;

            SignUpFor signUpFor = new SignUpFor();

            //commented out by Hassan 6/2/16

            //if (lblSignUpStatus.Text.Equals("Pending",StringComparison.OrdinalIgnoreCase))
            //    lblSignUpStatus.Text = "Approved";
            //else lblSignUpStatus.Text = "Pending";

            signUpFor.SignUpStatus = lblSignUpStatus.Text;

            signUpFor.StudentID = Convert.ToInt32(lblStudentID.Text);
            signUpFor.OpportunityID = Convert.ToInt32(lblOpportunityID.Text);
            signUpFor.CPPID = Convert.ToInt32(lblCPPID.Text);
            signUpFor.UpdateSignUpFor();
        }

        protected void GetStudentProfile(object sender, EventArgs e)
        {
            //Get the button that raised the event
            HyperLink  hlnkStudent = (HyperLink )sender;
            //Get the row that contains this button
            GridViewRow gvr = (GridViewRow)hlnkStudent.NamingContainer;
            Label lblOpportunityID = (Label)gvr.FindControl("lblOpportunityID");
            Label lblStudentID = (Label)gvr.FindControl("lblStudentID");
            Label lblProfessorID = (Label)gvr.FindControl("lblProfessorID");
            Label lblSectionID = (Label)gvr.FindControl("lblSectionID");
            Session["OpportunityID"] = lblOpportunityID.Text;
            Session["StudentID"] = lblStudentID.Text;
            Session["ProfessorID"] = lblProfessorID.Text;
           
            Response.Write("<script>window.open('~/Student/StudentProfile.aspx?StudentID=106288');</script>");


        }


        protected void GetProfessorEmail(object sender, EventArgs e)
        {
            //Get the button that raised the event
            HyperLink hlnkProfessor = (HyperLink )sender;
            //Get the row that contains this button
            GridViewRow gvr = (GridViewRow)hlnkProfessor.NamingContainer;
            Label lblOpportunityID = (Label)gvr.FindControl("lblOpportunityID");
            Label lblStudentID = (Label)gvr.FindControl("lblStudentID");
            Label lblProfessorID = (Label)gvr.FindControl("lblProfessorID");
            Label lblSectionID = (Label)gvr.FindControl("lblSectionID");
            Session["OpportunityID"] = lblOpportunityID.Text;
            Session["StudentID"] = lblStudentID.Text;
            Session["ProfessorID"] = lblProfessorID.Text;
            


        }
        protected void SubmitPartnerEvaluation(object sender, EventArgs e)
        {
            //Get the button that raised the event
            LinkButton lbtnPartnerEval = (LinkButton)sender;
            //Get the row that contains this button
            GridViewRow gvr = (GridViewRow)lbtnPartnerEval.NamingContainer;
            Label lblOpportunityID = (Label)gvr.FindControl("lblOpportunityID");
            Label lblStudentID = (Label)gvr.FindControl("lblStudentID");
            Label lblCPPID = (Label)gvr.FindControl("lblCPPID");
            Label lblCPID = (Label)gvr.FindControl("lblCPID");
           

            Session["OpportunityID"] = lblOpportunityID.Text;
            Session["StudentID"] = lblStudentID.Text;
            Session["CPPID"] = lblCPPID.Text;
            Session["CPID"] = lblCPID.Text;
            Response.Write("<script>window.open('PartnerEvaluation.aspx','targetwindow');</script>");
            

        }

        protected void gvCommunityPartnerStudentView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        


        



    }
}