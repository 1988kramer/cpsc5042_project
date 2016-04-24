using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eServeSU
{
    public partial class StudentHistory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            loadDataTable();
        }
        private void loadDataTable()
        {
            DataSet ds = new DataSet();

            DataColumn academicTerm = new DataColumn("AcademicTerm", Type.GetType("System.String"));
            DataColumn course = new DataColumn("Course", Type.GetType("System.String"));
            DataColumn communityPartner = new DataColumn("Community_Partner", Type.GetType("System.String"));
            DataColumn contactSiteSupervisor = new DataColumn("ContactSiteSupervisor", Type.GetType("System.String"));
            DataColumn opportunity = new DataColumn("Opportunity_Name", Type.GetType("System.String"));
            DataColumn hoursVolunteered = new DataColumn("Hours_Volunteered", Type.GetType("System.String"));
            DataColumn partnerEvaluation = new DataColumn("Partner_Evaluation", Type.GetType("System.String"));
            DataColumn studentEvaluation = new DataColumn("Student_Evaluation", Type.GetType("System.String"));
            DataColumn studentReflection = new DataColumn("Student_Reflection", Type.GetType("System.String"));

            DataTable dt = new DataTable();
            dt.Columns.Add(academicTerm);
            dt.Columns.Add(course);
            dt.Columns.Add(communityPartner);
            dt.Columns.Add(contactSiteSupervisor);
            dt.Columns.Add(opportunity);
            dt.Columns.Add(hoursVolunteered);
            dt.Columns.Add(partnerEvaluation);
            dt.Columns.Add(studentEvaluation);
            dt.Columns.Add(studentReflection);

            DataRow dr = dt.NewRow();
            //dr["AcademicTerm"] = "Spring 2014";
            //dr["Course"] = "PSYC 120 Introduction to Psychology";
            //dr["Community_Partner"] = "Community Partner 1";
            //dr["ContactSiteSupervisor"] = "Joe Friendly (joef@partner1.com)";
            //dr["Opportunity_Name"] = "Opportunity 1";
            //dr["Hours_Volunteered"] = "20";    
            //dr["Partner_Evaluation"] = "Completed";
            //dr["Student_Evaluation"] = "Completed";
            //dr["Student_Reflection"] = "Completed";
            //dt.Rows.Add(dr);
            //dr = dt.NewRow();
            //dr["AcademicTerm"] = "Autumn 2014";
            //dr["Course"] = "FINC 143: Financial Institutions and Markets";
            //dr["Community_Partner"] = "Community Partner 2";
            //dr["ContactSiteSupervisor"] = "John Friendly (johnf@partner2.com)";
            //dr["Opportunity_Name"] = "Opportunity 2-3";
            //dr["Hours_Volunteered"] = "20";    
            //dr["Partner_Evaluation"] = "Completed";
            //dr["Student_Evaluation"] = "Completed";
            //dr["Student_Reflection"] = "Completed";  
            //dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["AcademicTerm"] = "Spring 2014";
            dr["Course"] = "FINC 243: Financial Institutions and Markets";
            dr["Community_Partner"] = "Community Partner 2";
            dr["ContactSiteSupervisor"] = "John Friendly (johnf@partner2.com)";
            dr["Opportunity_Name"] = "Opportunity 2-2";
            dr["Hours_Volunteered"] = "20";
            dr["Partner_Evaluation"] = "View Evaluation";
            dr["Student_Evaluation"] = "View Evaluation";
            dr["Student_Reflection"] = "View Reflection";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["AcademicTerm"] = "Winter 2013";
            dr["Course"] = "FINC 343: Financial Institutions and Markets";
            dr["Community_Partner"] = "Community Partner 2";
            dr["ContactSiteSupervisor"] = "John Friendly (johnf@partner2.com)";
            dr["Opportunity_Name"] = "Opportunity 2-1";
            dr["Hours_Volunteered"] = "20";
            dr["Partner_Evaluation"] = "View Evaluation";
            dr["Student_Evaluation"] = "View Evaluation";
            dr["Student_Reflection"] = "View Reflection";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["AcademicTerm"] = "Autumn 2012";
            dr["Course"] = "BUSI 215: Business Economics";
            dr["Community_Partner"] = "Community Partner 3";
            dr["ContactSiteSupervisor"] = "John Friendly (johnf@partner2.com)";
            dr["Opportunity_Name"] = "Opportunity 3";
            dr["Hours_Volunteered"] = "20";
            dr["Partner_Evaluation"] = "View Evaluation";
            dr["Student_Evaluation"] = "View Evaluation";
            dr["Student_Reflection"] = "View Reflection";
            dt.Rows.Add(dr);
            ds.Tables.Add(dt);

            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
        }
    }
}