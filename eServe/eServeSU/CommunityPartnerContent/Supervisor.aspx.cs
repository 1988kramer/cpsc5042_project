using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eServeSU.CommunityPartnerContent
{
    public partial class Supervisor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        
            if(!IsPostBack)
            {
                if (Session["CPPID"] != null)
                {
                    CommunityPartnersPeople cpp = new CommunityPartnersPeople();
                    cpp = cpp.GetSupervisor(Convert.ToInt32(Session["CPPID"]));
                    DataBind(cpp);
                }

            }
        
        }

        private void DataBind(CommunityPartnersPeople cpp)
        {
            tbFirstName.Text = cpp.FirstName;
            tbLastName.Text = cpp.LastName;
            tbTitle.Text = cpp.Title;
            tbEmailID.Text = cpp.EmailID;
            tbPhone.Text = cpp.Phone;
            
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Session["CPPID"] != null)
            {
                CommunityPartnersPeople cpp = new CommunityPartnersPeople();
                cpp.CPPID = Convert.ToInt32(Session["CPPID"]);
                cpp.FirstName = tbFirstName.Text;
                cpp.LastName = tbLastName.Text;
                cpp.Title = tbTitle.Text;
                cpp.EmailID = tbEmailID.Text;
                cpp.Phone = tbPhone.Text;
                cpp.UpdateSupervisor();
                lblOutput.Visible = true;
                btnUpdate.Enabled = false;
                
                
            }

        }
    }
}