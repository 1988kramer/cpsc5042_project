using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eServeSU
{
    public partial class Opportunity_OpportunitySignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if ((Constant.UserType)Session["UserName"] != Constant.UserType.Student)
                {
                    tbSignUp.Visible = false;
                }
            }
        }
    }
}