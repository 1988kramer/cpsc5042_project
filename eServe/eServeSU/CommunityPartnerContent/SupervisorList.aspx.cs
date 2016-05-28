using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eServeSU
{
    public partial class Supervisor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                if (Session["CPID"] == null)
                {
                    //THIS IS HARD-CODED BY ORIGINAL AUTHOR
                    //
                    Session["CPID"] = 1;

                    DataBind();
                }
                else
                    DataBind();
                             
            }
        }
        private void DataBind()
        {
            CommunityPartnersPeople cpp = new CommunityPartnersPeople();
            cpp.CPID = Convert.ToInt32(Session["CPID"]);
            List<CommunityPartnersPeople> cpplist = cpp.GetAllCommunityPartnerPeople();

            gvSupervisor.DataSource = cpplist;
            gvSupervisor.DataBind();
            
        }

         protected void gvSupervisor_OnRowDataBound(object sender, GridViewRowEventArgs e)
        {
              if (e.Row.RowType == DataControlRowType.DataRow)
              {
                  LinkButton lbRemove = (LinkButton)e.Row.FindControl("lnkRemove");

              }
        }

         protected void gvSupervisor_RowUpdating(object sender, GridViewUpdateEventArgs e)
         {
             //Get the values
             GridViewRow row = gvSupervisor.Rows[e.RowIndex];
             TextBox tbSupervisor = (TextBox)row.FindControl("tbSupervisorName");
             TextBox tbTitle = (TextBox)row.FindControl("tbTitle");
             TextBox tbPhone = (TextBox)row.FindControl("tbPhone");
             TextBox tbEmailID = (TextBox)row.FindControl("tbEmailID");
             Label lblSupervisorID = (Label)row.FindControl("lblSupervisorID");

             //Update the values
             CommunityPartnersPeople cpp = new CommunityPartnersPeople();
             cpp.Title = tbTitle.Text;
             cpp.FirstName = tbSupervisor.Text;
             cpp.Phone = tbPhone.Text;
             cpp.EmailID = tbEmailID.Text;
             cpp.CPPID = Convert.ToInt32(lblSupervisorID.Text);
             cpp.UpdateSupervisor();
             //Reset the edit index
             gvSupervisor.EditIndex = -1;

             //Bind Data
             DataBind();


         }

         protected void gvSupervisor_RowEditing(object sender, GridViewEditEventArgs e)
         {
             //Set the edit index.
             gvSupervisor.EditIndex = e.NewEditIndex;
             //Bind data to the GridView control.
             DataBind();
         }

         protected void gvSupervisor_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
         {
             //Reset the edit index.
             gvSupervisor.EditIndex = -1;
             //Bind data to the GridView control.
             DataBind();
         }

         protected void EditViewSupervisor(object sender, EventArgs e)
         {
             //Get the button that raised the event
             LinkButton lnkEditView = (LinkButton)sender;
             //Get the row that contains this button
             GridViewRow gvr = (GridViewRow)lnkEditView.NamingContainer;
             Label lblSupervisorID = (Label)gvr.FindControl("lblSupervisorID");

             Session["CPPID"] = lblSupervisorID.Text;
             Response.Write("<script>window.open('Supervisor.aspx','_blank');</script>");
         }

         protected void DeleteSupervisor(object sender, EventArgs e)
         {
             //Get the button that raised the event
             LinkButton lbtn = (LinkButton)sender;
             //Get the row that contains this button
             GridViewRow gvr = (GridViewRow)lbtn.NamingContainer;

             Label lblSupervisorID = (Label)gvr.FindControl("lblSupervisorID");

             //datasource
             CommunityPartnersPeople cpp = new CommunityPartnersPeople();
             cpp.CPPID = Convert.ToInt32(lblSupervisorID.Text);
             cpp.CPID = Convert.ToInt32(Session["CPID"]);
             cpp.DeleteSupervisor();

             DataBind();
         }
         

       

    }
}