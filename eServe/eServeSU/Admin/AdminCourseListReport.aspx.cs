using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DocumentFormat.OpenXml.Packaging;

namespace eServeSU
{
    public partial class AdminCourseList : System.Web.UI.Page
    {
        private List<OpportunitySectionStudent> oppList = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                QuarterDataBind();
                GridViewDataBind();
            }
        }

        private void QuarterDataBind()
        {
            Quarter quarter = new Quarter();
            
            ddlQuarters.DataSource = quarter.GetAllQuarters();
            ddlQuarters.DataTextField = "QuarterName";
            ddlQuarters.DataValueField = "QuarterID";
            ddlQuarters.DataBind();

            ddlQuarters.Items.Add(new ListItem("All", "0"));
            
            ddlQuarters.SelectedValue = quarter.GetCurrentQuarterId().ToString();
        }

        private void GridViewDataBind()
        {
            DataBind();

            gvOppSecAdmin.DataSource = oppList;
            gvOppSecAdmin.DataBind();
        }

        private void DataBind()
        {
            int quarterID = Convert.ToInt32(ddlQuarters.SelectedValue);

            OpportunitySectionStudent opp = new OpportunitySectionStudent();
            oppList = opp.GetOpportunityStudentListReport(quarterID);
        }

        protected void btnReport_Click(Object sender, EventArgs e)
        {
            GridViewDataBind();
        }

        protected void btnExport_Click(Object sender, EventArgs e)
        {
            //var invalidChars = Path.GetInvalidFileNameChars();
            string path = Server.MapPath("~/");
            DataBind();
            path += @"Admin\Report.xlsx";
            
            using (var workbook = SpreadsheetDocument.Create(path, DocumentFormat.OpenXml.SpreadsheetDocumentType.Workbook))
            {
                var workbookPart = workbook.AddWorkbookPart();

                workbook.WorkbookPart.Workbook = new DocumentFormat.OpenXml.Spreadsheet.Workbook();

                workbook.WorkbookPart.Workbook.Sheets = new DocumentFormat.OpenXml.Spreadsheet.Sheets();

                var table = ToDataTable(oppList);

                var sheetPart = workbook.WorkbookPart.AddNewPart<WorksheetPart>();
                var sheetData = new DocumentFormat.OpenXml.Spreadsheet.SheetData();
                sheetPart.Worksheet = new DocumentFormat.OpenXml.Spreadsheet.Worksheet(sheetData);

                DocumentFormat.OpenXml.Spreadsheet.Sheets sheets = workbook.WorkbookPart.Workbook.GetFirstChild<DocumentFormat.OpenXml.Spreadsheet.Sheets>();
                string relationshipId = workbook.WorkbookPart.GetIdOfPart(sheetPart);

                uint sheetId = 1;
                if (sheets.Elements<DocumentFormat.OpenXml.Spreadsheet.Sheet>().Count() > 0)
                {
                    sheetId =
                        sheets.Elements<DocumentFormat.OpenXml.Spreadsheet.Sheet>().Select(s => s.SheetId.Value).Max() + 1;
                }

                DocumentFormat.OpenXml.Spreadsheet.Sheet sheet = new DocumentFormat.OpenXml.Spreadsheet.Sheet() { Id = relationshipId, SheetId = sheetId, Name = table.TableName };
                sheets.Append(sheet);

                DocumentFormat.OpenXml.Spreadsheet.Row headerRow = new DocumentFormat.OpenXml.Spreadsheet.Row();

                List<String> columns = new List<string>();
                foreach (System.Data.DataColumn column in table.Columns)
                {
                    columns.Add(column.ColumnName);

                    DocumentFormat.OpenXml.Spreadsheet.Cell cell = new DocumentFormat.OpenXml.Spreadsheet.Cell();
                    cell.DataType = DocumentFormat.OpenXml.Spreadsheet.CellValues.String;
                    cell.CellValue = new DocumentFormat.OpenXml.Spreadsheet.CellValue(column.ColumnName);
                    headerRow.AppendChild(cell);
                }


                sheetData.AppendChild(headerRow);

                foreach (System.Data.DataRow dsrow in table.Rows)
                {
                    DocumentFormat.OpenXml.Spreadsheet.Row newRow = new DocumentFormat.OpenXml.Spreadsheet.Row();
                    foreach (String col in columns)
                    {
                        DocumentFormat.OpenXml.Spreadsheet.Cell cell = new DocumentFormat.OpenXml.Spreadsheet.Cell();
                        cell.DataType = DocumentFormat.OpenXml.Spreadsheet.CellValues.String;
                        cell.CellValue = new DocumentFormat.OpenXml.Spreadsheet.CellValue(dsrow[col].ToString()); 
                        newRow.AppendChild(cell);
                    }

                    sheetData.AppendChild(newRow);
                }                
                }

            FileInfo file = new FileInfo(path);
            if (file.Exists)
            {
                Response.Clear();
                Response.ClearHeaders();
                Response.ClearContent();
                Response.AddHeader("content-disposition", "attachment; filename=Report.xlsx");
                Response.AddHeader("Content-Type", "application/Excel");
                Response.ContentType = "application/vnd.xls";
                Response.AddHeader("Content-Length", file.Length.ToString());
                Response.WriteFile(file.FullName);
                Response.End();
            }
            else
            {
                Response.Write("This file does not exist.");
            }

            //LaunchFolderView(path);
            
        }

        private static DataTable ToDataTable<OpportunitySectionStudent>(List<OpportunitySectionStudent> items)
        {
            DataTable dataTable = new DataTable(typeof(OpportunitySectionStudent).Name);

            //Get all the properties
            PropertyInfo[] Props = typeof(OpportunitySectionStudent).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Setting column names as Property names
                dataTable.Columns.Add(prop.Name);
            }
            foreach (OpportunitySectionStudent item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            //put a breakpoint here and check datatable
            return dataTable;
        }

        private void LaunchFolderView(string p_Filename)
        {
            // Check the file exists
            if (File.Exists(p_Filename))
            {
                // Check the folder we get from the file exists
                // this function would just get "C:\Hello" from
                // an input of "C:\Hello\World.txt"
                string l_folder = Path.GetDirectoryName(p_Filename);

                // Check the folder exists
                if (Directory.Exists(l_folder))
                {
                    try
                    {
                       //  Start a new process for explorer
                       //  in this location     
                        ProcessStartInfo l_psi = new ProcessStartInfo();
                        l_psi.FileName = "explorer";
                        l_psi.Arguments = string.Format("/root,{0} /select,{1}", l_folder, p_Filename);
                        //l_psi.Arguments = string.Format("/root,{0} /select,{1}", @"c:\temp\", "temp1.xlsx");
                        l_psi.UseShellExecute = true;

                        Process l_newProcess = new Process();
                        l_newProcess.StartInfo = l_psi;
                        l_newProcess.Start();
                       
                    }
                    catch (Exception exception)
                    {
                        throw new Exception("Error in 'LaunchFolderView'.", exception);
                    }
                }
            }
        }
    }
}