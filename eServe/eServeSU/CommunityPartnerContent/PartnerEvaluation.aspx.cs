using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eServeSU
{
    public partial class PartnerEval : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
             
                DataBind();
        }

        protected void DataBind()
           
        {
            PartnerEvaluation Eval = new PartnerEvaluation ();
            if (Eval != null)
            {
                Eval.CPPID = Convert.ToInt32(Session["CPPID"]);
                Eval.CPID = Convert.ToInt32(Session["CPID"]);
                Eval.StudentID = Convert.ToInt32(Session["StudentID"]);
                Eval.OpportunityID = Convert.ToInt32(Session["OpportunityID"]);

                //Eval.CPPID = 2;
                //Eval.CPID = 1;
                //Eval.StudentID = 101946;
                //Eval.OpportunityID = 9;

                Eval.AutoPopulatePartnerEval();
                tbOrgName.Text = Eval.OrganizationName;
                tbSupervisorFirstName.Text = Eval.SupervisorFirstName;
                tbSupervisorLastName.Text = Eval.SupervisorLastName;
                tbStudentFirstName.Text = Eval.StudentFirstName;
                tbStudentLastName.Text = Eval.StudentLastName;
            }
                
                    
        }


        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            // When the button is clicked,
            // change the button text, and disable it.
            bool flag = true;
            if (clickedButton.Text == "Submit")
            {
                clickedButton.Text = "....Processing...";
                clickedButton.Enabled = false;
                lblEmpty.Visible = true;
                //Save to the database
                PartnerEvaluation Eval = new PartnerEvaluation();
                Eval.OrganizationName = tbOrgName.Text;
                Eval.SupervisorFirstName = tbSupervisorFirstName.Text;
                Eval.SupervisorLastName = tbSupervisorLastName.Text;
                Eval.StudentFirstName = tbStudentFirstName.Text;
                Eval.StudentLastName = tbStudentLastName.Text;
                if (!String.IsNullOrEmpty(tbHours.Text))
                    Eval.HoursCompleted = tbHours.Text;
                else
                {
                    lblHours.Visible = true;
                    flag = false;
                }
                Eval.Question1 = ddlHours.SelectedItem.Value;
                Eval.Rate1 = RblRate1.SelectedItem.Value;
                Eval.Rate2 = RblRate2.SelectedItem.Value;
                Eval.Rate3 = RblRate3.SelectedItem.Value;
                Eval.Rate4 = RblRate4.SelectedItem.Value;
                Eval.Rate5 = RblRate5.SelectedItem.Value;
                Eval.Rate6 = RblRate6.SelectedItem.Value;
                if (!String.IsNullOrEmpty(tbQuestion2.Text))
                    Eval.Question2 = tbQuestion2.Text;
                else
                {
                    lblQuestion2.Visible = true;
                    flag = false;
                }
                if (!String.IsNullOrEmpty(tbQuestion3.Text))
                    Eval.Question3 = tbQuestion3.Text;
                else
                {
                    lblQuestion3.Visible = true;
                    flag = false;
                }
                if (!String.IsNullOrEmpty(tbQuestion4.Text))
                    Eval.Question4 = tbQuestion4.Text;
                else
                {
                    lblQuestion4.Visible = true;
                    flag = false;
                }

                Eval.CPPID = Convert.ToInt32(Session["CPPID"]);
                Eval.OpportunityID = Convert.ToInt32(Session["OpportunityID"]);
                Eval.StudentID = Convert.ToInt32(Session["StudentID"]);

                // Eval.CPPID = 2;
                if (flag)
                {
                    Eval.AddEvaluation();
                    clickedButton.Text = "Close";
                    clickedButton.Enabled = true;
                    lblEmpty.Text = "Evaluation is submitted successfully. Please close the window.";
                }
                else
                {
                    clickedButton.Enabled = true;
                    clickedButton.Text = "Submit";
                }
            }
            else
            {
                if (clickedButton.Text == "Close")
                {
                    string close = @"<script type='text/javascript'>
                                window.returnValue = true;
                                window.close();
                                </script>";
                    base.Response.Write(close);
                }
            }
        }
    }
}