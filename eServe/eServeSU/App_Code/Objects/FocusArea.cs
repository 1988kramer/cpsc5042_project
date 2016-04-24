using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace eServeSU
{
    /// <summary>
    /// Summary description for FocusArea
    /// </summary>
    public class FocusArea
    {
        public FocusArea()
        {
            //
            // TODO: Add constructor logic here
            //
            dbHelper = new DatabaseHelper();
            dbHelper.DbConnection = ConfigurationManager.ConnectionStrings["eServeConnection"].ConnectionString;
        }

        private String areaName;
        private int focusAreaId;

        private DatabaseHelper dbHelper;

        public String AreaName
        {
            get { return this.areaName; }
            set
            {
                try
                {
                    this.areaName = value;

                    if (this.areaName == "")
                    {
                        throw new Exception(
                            "Please provide area name ...");
                    }
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
        }

        public int FocusAreaId
        {
            get { return this.focusAreaId; }
            set
            {
                this.focusAreaId = value;
                if (this.focusAreaId == 0)
                {
                    throw new Exception("Please provide focus area Id ...");
                }
            }
        }

        public List<FocusArea> GetAllFocusAreas()
        {
            var reader = dbHelper.GetFocusArea(Constant.SP_GetFocusArea);

            List<FocusArea> focusAreaList = new List<FocusArea>();
            FocusArea focusArea = null;

            while (reader.Read())
            {
                focusArea = new FocusArea();
                focusArea.FocusAreaId = Convert.ToInt32(reader["FocusAreaId"]);
                focusArea.AreaName = reader["AreaName"].ToString();

                focusAreaList.Add(focusArea);
            }

            return focusAreaList;
        }

        public void DeleteAllStudentFocusAreas(int studentId)
        {
            dbHelper.DeleteAllStudentFocusAreas(Constant.SP_DeleteAllStudentFocusAreas, studentId);
        }

        public void AddStudentFocusArea(int studentID, int focusAreaID)
        {
            dbHelper.AddStudentFocusArea(Constant.SP_AddStudentFocusArea, studentID, focusAreaID);
        }
    }
}
