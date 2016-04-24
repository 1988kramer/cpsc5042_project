using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eServeSU
{
    public partial class Site : System.Web.UI.MasterPage
    {
        private const string AntiXsrfTokenKey = "__AntiXsrfToken";
        private const string AntiXsrfUserNameKey = "__AntiXsrfUserName";
        private string _antiXsrfTokenValue;

        protected void Page_Init(object sender, EventArgs e)
        {
            // The code below helps to protect against XSRF attacks
            var requestCookie = Request.Cookies[AntiXsrfTokenKey];
            Guid requestCookieGuidValue;
            if (requestCookie != null && Guid.TryParse(requestCookie.Value, out requestCookieGuidValue))
            {
                // Use the Anti-XSRF token from the cookie
                _antiXsrfTokenValue = requestCookie.Value;
                Page.ViewStateUserKey = _antiXsrfTokenValue;
            }
            else
            {
                // Generate a new Anti-XSRF token and save to the cookie
                _antiXsrfTokenValue = Guid.NewGuid().ToString("N");
                Page.ViewStateUserKey = _antiXsrfTokenValue;

                var responseCookie = new HttpCookie(AntiXsrfTokenKey)
                {
                    HttpOnly = true,
                    Value = _antiXsrfTokenValue
                };
                if (FormsAuthentication.RequireSSL && Request.IsSecureConnection)
                {
                    responseCookie.Secure = true;
                }
                Response.Cookies.Set(responseCookie);
            }

            Page.PreLoad += master_Page_PreLoad;
        }

        protected void master_Page_PreLoad(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Set Anti-XSRF token
                ViewState[AntiXsrfTokenKey] = Page.ViewStateUserKey;
                ViewState[AntiXsrfUserNameKey] = Context.User.Identity.Name ?? String.Empty;
            }
            else
            {
                // Validate the Anti-XSRF token
                if ((string)ViewState[AntiXsrfTokenKey] != _antiXsrfTokenValue
                    || (string)ViewState[AntiXsrfUserNameKey] != (Context.User.Identity.Name ?? String.Empty))
                {
                    throw new InvalidOperationException("Validation of Anti-XSRF token failed.");
                }
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            hlOpp.Visible = false;

            hlStudentProfile.Visible = false;
            hlStudentRegistered.Visible = false;
            hlStudentRegistration.Visible = false;

            hlAdminCourse.Visible = false;
            hlAdmin.Visible = false;

            hlFaculty.Visible = false;

            Label lblRegister = (Label)lvLogin.FindControl("lblRegister");
            Label lblLogOut = (Label)lvLogin.FindControl("lblLogOut");

            if (Session["UserName"] != null)
            {
                lblRegister.Visible = false;
                lblLogOut.Visible = true;
                switch (Session["UserName"].ToString())
                {
                    case "Partner@eServeSU.net":
                        //hlOpp.Visible = true;
                        h1Opportunities.Visible = true;
                        h1ReadEvaluation.Visible = true;
                        h1CommunityPartnerView.Visible = true;
                        h1CommunityPartnerStudentView.Visible = true;
                       
                        lblLogOut.Visible = true;
                        break;
                    case "Student@eServeSU.net":
                        hlStudentRegistered.Visible = true;
                        hlStudentProfile.Visible = true;
                        hlStudentRegistration.Visible = true;
                        lblLogOut.Visible = true;
                        Session["Student_StudentID"] = 106288; // todo: remove after implement ADFS with SeattleU IT.
                        break;
                    case "Admin@eServeSU.net":
                        hlAdmin.Visible = true;
                        hlAdminCourse.Visible = true;
                        lblLogOut.Visible = true;
                        break;
                    case "Faculty@eServeSU.net":
                        hlFaculty.Visible = true;
                        hlFacultyOpp.Visible = true;
                        lblLogOut.Visible = true;
                        //here should get value for Faculty Id (Professor Id)
                        Session["ProfessorID"] = 2;
                        break;
                    default:
                        break;
                }                
            }
            else
            {
                hlOpp.Visible = false;
                
                hlStudentProfile.Visible = false;
                hlStudentRegistered.Visible = false;
                hlStudentRegistration.Visible = false;

                hlAdminCourse.Visible = false;
                hlAdmin.Visible = false;

                hlFaculty.Visible = false;
                hlFacultyOpp.Visible = false;
                lblRegister.Visible = true;
                lblLogOut.Visible = false;
            }
        }

        protected void Unnamed_LoggingOut(object sender, LoginCancelEventArgs e)
        {
            Context.GetOwinContext().Authentication.SignOut();
        }
    }
}