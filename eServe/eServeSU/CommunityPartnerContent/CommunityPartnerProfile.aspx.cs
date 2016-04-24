using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eServeSU
{
    public partial class CommunityPartnerProfile_CommunityPartnerProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                Session["CPID"] = "1";
                DataBind_Community();
                OutputLabel.Visible = false;
            }
        }

        private void DataBind_Community()
        {

            CommunityPartnersProfile cp = new CommunityPartnersProfile();
            cp.GetcommunityPartnerProfile(Convert.ToInt32(Session["CPID"]));
            tbOrganizationName.Text = cp.OrganizationName;
            tbAddress.Text = cp.Address;
            tbWebsite.Text = cp.Website;
            tbMainPhone.Text = cp.MainPhone;
            tbMissionStatement.Text = cp.MissionStatement;
            tbDescription.Text = cp.WorkDescription;
        }


        protected void btUpdate_Click(object sender, EventArgs e)
        {
            CommunityPartnersProfile cpp = new CommunityPartnersProfile();
            cpp.CommunityPartnerID = Convert.ToInt32(Session["CPID"]);
            cpp.OrganizationName = tbOrganizationName.Text;
            cpp.Address = tbAddress.Text;
            cpp.Website = tbWebsite.Text;
            cpp.MainPhone = tbMainPhone.Text;
            cpp.MissionStatement = tbMissionStatement.Text;
            cpp.WorkDescription = tbDescription.Text;
            cpp.UpdateCommunityPartnerProfile();
            OutputLabel.Visible = true;
            btUpdate.Enabled = false;

        }

    }
}