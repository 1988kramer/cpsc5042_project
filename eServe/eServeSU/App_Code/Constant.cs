using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eServeSU
{
    /// <summary>
    /// Summary description for Constant
    /// </summary>
    public class Constant
    {
        public Constant()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public const string SP_GetStudentEvaluationCountByOpportunityID = "spGetStudentEvaluationCountByOpportunityID";
        public const string SP_GetStudentReflectionCountByOpportunityID = "spGetStudentReflectionCountByOpportunityID";
        public const string SP_AddOpportunityEvaluation = "spAddOpportunityEvaluation";
        public const string SP_AddOpportunityStudentReflection = "spAddOpportunityStudentReflection";
        public const string SP_GetCurrentQuarter = "spGetCurrentQuarter";
        public const string SP_AddTimeEntries = "spAddTimeEntries";
        public const string SP_GetStudentTimeEntriesByOpportunityID = "spGetStudentTimeEntriesByOpportunityID";
        public const string SP_RegisterStudentOpportunity = "spRegisterStudentOpportunity";
        public const string SP_GetStudentVolunteeredPartnerApprovedHoursByOpportunityId = "spGetStudentVolunteeredPartnerApprovedHoursByOpportunityId";
        public const string SP_GetOpportunityDetailByOpportunityId = "spGetOpportunityDetailByOpportunityId";
        public const string SP_GetOpportunityListByStudentId = "spGetOpportunityListByStudentId";
        public const string SP_GetOpportunityRegisteredByStudentId = "spGetOpportunityRegisteredByStudentId";
        public const string SP_GetOpportunityList = "spGetOpportunityList";
        public const string SP_AddOpportunit = "spAddOpportunity";
        public const string SP_UpdateOpportunit = "spUpdateOpportunity";
        public const string SP_DeleteOpportunit = "spDeleteOpportunity";
        public const string SP_GetOpportunityById = "spGetOpportunityById";

        public const string SP_GetOpportunityType = "spGetOpportunityType";
        public const string SP_GetFocusArea = "spGetFocusArea";
        public const string SP_GetCommunityPartner = "spGetCommunityPartners";
        public const string SP_GetCommunityPartnerProfile = "spGetCommunityPartnerProfile";
        public const string SP_GetCommunityPartnerPeople = "spGetCommunityPartnerPeople";
        public const string SP_GetSupervisor = "spGetSupervisor";
        public const string SP_UpdateSupervisor = "spUpdateCommunityPartnersPeople";
        public const string SP_UpdateCommunityPartnerProfile = "spUpdateCommunityPartnerInfo";
        public const string SP_DeleteCommunityPartnerPeople = "spDeleteCommunityPartnerPeople";
        public const string SP_GetAutoPopulate = "spGetAutoPopulate";

        public const string SP_GetCourseEvaluationByStudent = "spGetCourseEvaluationByStudent";
        public const string SP_GetCommunityPartnerStudentView = "spGetCommunityPartnerStudentView";
        public const string SP_UpdateSignUpStatus = "spUpdateSignUpFor";
        public const string SP_CommunityPartnerAlertView = "spGetCommunityPartnerAlertview";
        public const string SP_DeleteCommunityPartnerAlert = "spDeleteCommunityPartnerAlert";
        public const string SP_PartnerEvaluation = "spAddPartnerEvaluation";
        public const string SP_GetStudentEvaluation = "spGetStudentEvaluation";
        public const string SP_GetTimeEntries = "spGetTimeEntries";
        public const string SP_UpdateTimeEntries = "spUpdateTimeEntries";


        public const string SP_GetQuarter = "spGetQuarter";

        public const string SP_GetStudentList = "GetStudentList";

        public const string SP_DeleteAllStudentFocusAreas = "spDeleteAllStudentFocusAreas";
        public const string SP_AddStudentFocusArea = "spStudent_FocusArea";
        public const string SP_UpdateStudentProfile = "spUpdateStudentProfile";        
        public const string SP_GetStudentProfile = "spGetStudentProfile";
        public const string SP_GetProfileEthinicity = "spGetProfileEthinicity";
        public const string SP_GetProfileFocusAreas = "spGetProfileFocusAreas";

        public const string SP_GetUnAssignedCourseSection = "spGetUnAssignedCourseSection";
        public const string SP_GetAssignedCourseSection = "spGetAssignedCourseSection";
        public const string SP_AddCourseSectionToOpportunity = "spAddCourseSectionToOpportunity";
        public const string SP_RemoveCourseSectionFromOpportunity = "spRemoveCourseSectionFromOpportunity";
        public const string SP_GetOpportunityListForAdmin = "spGetOpportunityListForAdmin";
        public const string sp_GetOpportunityStudentListReport = "spGetOpportunityStudentListReport";

        public const string SP_AppoveOpportunityByAdmin = "spApproveOpportunityByAdmin";
        public const string sp_AssignOpportunityToStudentByAdmin = "spAssignOpportunityToStudentByAdmin";

        public const string sp_GetStudentCourseOppDetailForFaculty = "spGetStudentCourseOppDetailForFaculty";
        public const string sp_GetPartnerEvaluationByStudentIDOppID = "spGetPartnerEvaluationByStudentIDOppID";
        public const string SP_GetOpportunityListForFaculty = "spGetOpportunityListForFaculty";
        public const string sp_GetStudentEvaluationByStudentIDOppID = "spGetStudentEvaluationByStudentIDOppID";
        

        public enum UserType
        {
            Partner,
            Student,
            Faculty,
            Administrator
        }
    }
}