using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using eServeSU.CommunityPartnerContent;

namespace eServeSU
{
    public partial class CommunityPartnerView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                if (Session["UserName"] != null)
                {
                    Session["CPID"] = "1";
                }
            }

        }

 
        protected void gvEvaluations_SelectedIndexChanged(object sender, EventArgs e)
        {
            StudentCourseEvaluation sce = new StudentCourseEvaluation();



        }


    }
}