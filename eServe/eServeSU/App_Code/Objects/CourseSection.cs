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
    /// Summary description for Course Section
    /// </summary>
    public class CourseSection
    {
        public CourseSection()
        {
            //
            // TODO: Add constructor logic here
            //
            dbHelper = new DatabaseHelper();
            dbHelper.DbConnection = ConfigurationManager.ConnectionStrings["eServeConnection"].ConnectionString;
        }

        private string courseShortName;
        private string courseName;
        private int courseId;
        private int sectionId;
        private string roomNumber;
        private string classHours;
        private int numberOfSlots;
        private string quarterName;
        private string quarterShortName;
        private string sectionName;

        private DatabaseHelper dbHelper;

        public String CourseName
        {
            get { return this.courseName; }
            set
            {
                try
                {
                    this.courseName = value;

                    if (this.courseName == "")
                    {
                        throw new Exception(
                            "Please provide course name ...");
                    }
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
        }

        public String CourseShortName
        {
            get { return this.courseShortName; }
            set
            {
                try
                {
                    this.courseShortName = value;

                    if (this.courseShortName == "")
                    {
                        throw new Exception(
                            "Please provide course short name ...");
                    }
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
        }

        public String QuarterName
        {
            get { return this.quarterName; }
            set
            {
                try
                {
                    this.quarterName = value;

                    if (this.quarterName == "")
                    {
                        throw new Exception(
                            "Please provide quarter name ...");
                    }
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
        }

        public String QuarterShortName
        {
            get { return this.quarterShortName; }
            set
            {
                try
                {
                    this.quarterShortName = value;

                    if (this.quarterShortName == "")
                    {
                        throw new Exception(
                            "Please provide quarter short name ...");
                    }
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
        }

        public String RoomNumber
        {
            get { return this.roomNumber; }
            set
            {
                try
                {
                    this.roomNumber = value;

                    if (this.roomNumber == "")
                    {
                        throw new Exception(
                            "Please provide room name ...");
                    }
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
        }

        public String ClassHours
        {
            get { return this.classHours; }
            set
            {
                try
                {
                    this.classHours = value;

                    if (this.classHours == "")
                    {
                        throw new Exception(
                            "Please provide class Hours ...");
                    }
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
        }

        public int CourseId
        {
            get { return this.courseId; }
            set
            {
                this.courseId = value;
                if (this.courseId == 0)
                {
                    throw new Exception("Please provide course Id ...");
                }
            }
        }

        public int NumberOfSlots
        {
            get { return this.numberOfSlots; }
            set
            {
                this.numberOfSlots = value;
                if (this.numberOfSlots == 0)
                {
                    throw new Exception("Please provide number of slots ...");
                }
            }
        }
        public string CourseSectionDisplayName
        {
            get { return this.SectionName + "_" + this.QuarterShortName; }
        }
        public int SectionId
        {
            get { return this.sectionId; }
            set
            {
                this.sectionId = value;
                if (this.sectionId == 0)
                {
                    throw new Exception("Please provide section Id ...");
                }
            }
        }

        public String SectionName
        {
            get { return this.sectionName; }
            set
            {
                try
                {
                    this.sectionName = value;

                    if (this.sectionName == "")
                    {
                        throw new Exception(
                            "Please provide section name ...");
                    }
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
        }

        public List<CourseSection> GetUnAssignedCourseSection(int opportunityId)
        {
            var reader = dbHelper.GetUnAssignedCourseSection(Constant.SP_GetUnAssignedCourseSection, opportunityId);

            List<CourseSection> courseSectionList = new List<CourseSection>();
            CourseSection courseSection = null;

            while (reader.Read())
            {
                courseSection = new CourseSection();
                courseSection.CourseId = Convert.ToInt32(reader["CourseId"]);
                courseSection.SectionId = Convert.ToInt32(reader["SectionId"]);
                courseSection.CourseName = reader["CourseName"].ToString();
                courseSection.CourseShortName = reader["CourseShortName"].ToString();
                courseSection.QuarterShortName = reader["QuarterShortName"].ToString();
                courseSection.QuarterName = reader["QuarterName"].ToString();
                courseSection.RoomNumber = reader["RoomNumber"].ToString();
                courseSection.ClassHours = reader["ClassHours"].ToString();
                courseSection.NumberOfSlots = Convert.ToInt32(reader["NumberOfSlots"]);
                courseSection.SectionName = reader["SectionName"].ToString();

                courseSectionList.Add(courseSection);
            }

            return courseSectionList;
        }

        public List<CourseSection> GetAssignedCourseSection(int opportunityId)
        {
            var reader = dbHelper.GetAssignedCourseSection(Constant.SP_GetAssignedCourseSection, opportunityId);

            List<CourseSection> courseSectionList = new List<CourseSection>();
            CourseSection courseSection = null;

            while (reader.Read())
            {
                courseSection = new CourseSection();
                courseSection.CourseId = Convert.ToInt32(reader["CourseId"]);
                courseSection.SectionId = Convert.ToInt32(reader["SectionId"]);
                courseSection.CourseName = reader["CourseName"].ToString();
                courseSection.CourseShortName = reader["CourseShortName"].ToString();
                courseSection.QuarterShortName = reader["QuarterShortName"].ToString();
                courseSection.QuarterName = reader["QuarterName"].ToString();
                courseSection.RoomNumber = reader["RoomNumber"].ToString();
                courseSection.ClassHours = reader["ClassHours"].ToString();
                courseSection.NumberOfSlots = Convert.ToInt32(reader["NumberOfSlots"]);
                courseSection.SectionName = reader["SectionName"].ToString();

                courseSectionList.Add(courseSection);
            }

            return courseSectionList;
        }

        public void AddCourseSectionToOpportunity(int opportunityID, string courseSectionIDs)
        {
            dbHelper.AddCourseSectionToOpportunity(Constant.SP_AddCourseSectionToOpportunity, opportunityID, courseSectionIDs);
        }

        public void RemoveCourseSectionFromOpportunity(int opportunityID, string courseSectionIDs)
        {
            dbHelper.RemoveCourseSectionFromOpportunity(Constant.SP_RemoveCourseSectionFromOpportunity, opportunityID, courseSectionIDs);
        }
    }
}
