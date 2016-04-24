using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eServeSU
{
    public partial class FacultyOppPartnerEvaluation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["FacultyOppId"] != null)
            {
                Faculty thisFaculty = new Faculty();
                string[] oppStudentId = Session["FacultyOppId"].ToString().Split('_');
                
                thisFaculty = thisFaculty.GetStudentEvaluation(Convert.ToInt32(oppStudentId[1]), Convert.ToInt32(oppStudentId[0]));
                DataBind(thisFaculty);
            }
        }

        protected void DataBind(Faculty fac)
        {
            if (fac != null)
            {
                lblNameValue.Text = fac.OrganizationName;
                lblQuestionValue1.Text = fac.Question1;
                lblQuestionValue2.Text = fac.Question2;
                lblQuestionValue3.Text = fac.Question3;
                lblQuestionValue4.Text = fac.Question4;
                lblRateValue1.Text = fac.Rate1;
                lblRateValue2.Text = fac.Rate2;
                lblRateValue3.Text = fac.Rate3;
                lblRateValue4.Text = fac.Rate4;
                lblRateValue5.Text = fac.Rate5;
                lblRateValue6.Text = fac.Rate6;
                lblCommentsValue.Text = fac.Comments;
            }
        }
    }
}