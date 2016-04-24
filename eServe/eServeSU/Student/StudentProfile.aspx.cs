using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using eServeSU.Student;

namespace eServeSU
{
    public partial class StudentProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {            
            string studentIDParameter = Request.QueryString["StudentID"];
            if (studentIDParameter != null)
            {
                Session["Student_StudentID"] = studentIDParameter;
            }
            else
            {
                Session["Student_StudentID"] = 106288;
            }

            if (!IsPostBack)
            {
                DataBind();                
            }
        }

        private void DataBind()
        {
            int studentId = Convert.ToInt32(Session["Student_StudentID"]);
            Profile profile = new Profile();
            Profile result = profile.GetStudentProfile(studentId);
            //List<string> studentFocusAreas = profile.GetProfileFocusAreas(studentId);
            
            lblStudentLegalName.Text = result.LastName + ", " + result.FirstName;
            txtPreferName.Text = result.PreferedName;

            string[] dobSplit = result.DateOfBirth.Split(' ');
            lblStudentDOB.Text = dobSplit[0];

            txtGender.Text = result.Gender;

            //for (int i = 0; i < result.Ethinicity.Count; i++)
            //{
            //    for (int j = 0; j < cbxEthinicity.Items.Count; j++)
            //    {
            //        if (result.Ethinicity[i].ToString() == cbxEthinicity.Items[j].ToString())
            //        {
            //            cbxEthinicity.Items[j].Selected = true;
            //        } 
            //    }
            //}
            for (int i = 0; i < cbxFocusAreas.Items.Count; i++)
            {
                for (int j = 0; j < result.FocusAreas.Count; j++)
                {
                    if (cbxFocusAreas.Items[i].ToString() == result.FocusAreas[j].ToString())
                    {
                        cbxFocusAreas.Items[i].Selected = true;
                    }
                }
            }

            if (result.InternationalStudent == "Yes")
            {
                rbtnInternationalStudent.Items[0].Selected = true;
            }
            else
            {
                rbtnInternationalStudent.Items[1].Selected = true;
            }

            string[] lastBackgroundCheckSplit = result.LastBackgroundCheck.Split(' ');
            lblStudentLastBackgroundCheck.Text = lastBackgroundCheckSplit[0];
        }
        protected void UpdateStudentProfile(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            int studentId = Convert.ToInt32(Session["Student_StudentID"]);
            string preferedName = txtPreferName.Text;
            string gender = txtGender.Text;
            string isInternationalStudent = rbtnInternationalStudent.SelectedValue;

            List<int> selectedItems = new List<int>();
            for (int i = 0; i < cbxFocusAreas.Items.Count; i++)
            {
                if (cbxFocusAreas.Items[i].Selected == true)
                {                    
                    selectedItems.Add(i+1);
                }
            }

            FocusArea focusArea = new FocusArea();
            focusArea.DeleteAllStudentFocusAreas(studentId);
            for (int i = 0; i < selectedItems.Count; i++)
            {
                focusArea.AddStudentFocusArea(studentId, selectedItems[i]);
            }

            profile.UpdateStudentProfile(studentId, preferedName, gender, isInternationalStudent);

            DataBind();
        }
    }
}