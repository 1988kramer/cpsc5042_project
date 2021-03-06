USE [eServe]
GO
/****** Object:  StoredProcedure [dbo].[spGetOpportunityRegisteredByStudentId]    Script Date: 3/24/2015 11:11:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE Procedure [dbo].[spGetOpportunityRegisteredByStudentId]
	@StudentId int
AS
Begin
  SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT O.OpportunityID
	  ,SUF.[StudentId]
	  ,O.Name 'Opportunity'
	  ,C.[CourseName]
	  ,Q.QuarterName 'Quarter'
	  ,CP.OrganizationName 'Organization'
	  ,CPP.EmailId
      ,[SignUpStatus] 'Status'		
	  ,'NEED' [HoursVolunteered]
      ,'NEED' [PartnerEvaluation]
	  ,'NEED' [StudentEvaluation]
	  ,'NEED' [StudentReflection]      	  
  FROM [dbo].[SignUpFor] SUF
  INNER JOIN [dbo].[Opportunity] O ON (O.OpportunityID=SUF.OpportunityID)  
  INNER JOIN [dbo].[Opportunity_Section] OS ON (OS.OpportunityID=O.OpportunityID)
  INNER JOIN [dbo].[CommunityPartnersPeople] CPP ON (CPP.CPPID=SUF.CPPID)
  INNER JOIN [dbo].[CommunityPartners] CP ON (CP.CPID=CPP.CPID)
  RIGHT JOIN [dbo].[Quarter] Q ON (Q.QuarterID=O.QuarterID)   
  RIGHT JOIN [dbo].[Section] S ON (S.SectionID=OS.SectionID)
  RIGHT JOIN [dbo].[Class] C ON (C.CourseID=S.CourseID)
  WHERE StudentID=@StudentId AND OS.SectionID=1
END






GO
