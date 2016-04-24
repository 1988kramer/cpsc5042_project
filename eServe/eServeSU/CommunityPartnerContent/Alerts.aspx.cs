using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eServeSU
{
    public partial class Alerts : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                Session["CPID"] = 1;
                DataBind();
        }

        public void DataBind()
        {
            CommunityAlert ca = new CommunityAlert();
            List<CommunityAlert> caList = ca.GetAllCommunityPartnerAlertView();
            gvAlerts.DataSource = caList;
            gvAlerts.DataBind();

        }
        protected void gvAlerts_OnRowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                Label lblAlertID = ((Label)e.Row.FindControl("lblAlertID"));
                Label lblCPID = ((Label)e.Row.FindControl("lblCPID"));
                Label Message = ((Label)e.Row.FindControl("lblMessage"));
                Label Date = ((Label)e.Row.FindControl("lblDate"));


            }

        }

        protected void DeleteAlert(object sender , EventArgs e)
        {    
            //Get the button that raised the event
            Button Delete = (Button)sender;

            //Get the row that contains this event
            GridViewRow gvr = (GridViewRow)Delete.NamingContainer;
            Label lblAlertID = ((Label)gvr.FindControl("lblAlertID"));
            Label lblCPID = ((Label)gvr.FindControl("lblCPID"));
            Label Message = ((Label)gvr.FindControl("lblMessage"));
            Label Date = ((Label)gvr.FindControl("lblDate"));
            //Datasource
            CommunityAlert ca = new CommunityAlert();
            ca.AlertID = Convert.ToInt32(lblAlertID.Text);
            ca.DeleteAlertMessage();
                //DataBind
                DataBind();

        }





    }
}
