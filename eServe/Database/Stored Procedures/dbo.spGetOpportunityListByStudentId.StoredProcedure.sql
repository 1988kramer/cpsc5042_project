USE [eServe]
GO
/****** Object:  StoredProcedure [dbo].[spGetOpportunityListByStudentId]    Script Date: 3/24/2015 11:11:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE Procedure [dbo].[spGetOpportunityListByStudentId]
	@StudentId int
AS
Begin
  SET NOCOUNT ON;
  
    -- Insert statements for procedure here
	SELECT O.[OpportunityID]
      ,[Name] 'Position'
	  ,CP.[OrganizationName] 'Organization'
	  ,5 'SlotsAvailable'
	  ,O.[DistanceFromSU] + ' miles' As 'DistanceFromSU'
      ,[Location]
      ,[TimeCommittment]
      ,[MinimumAge]
      ,CASE 
	    WHEN [CRCRequiredByPartner] = 'Yes' OR [CRCRequiredBySU] = 'Yes' THEN 'Yes' 
		ELSE 'No'
		END AS 'CRCRequired'
	  ,[JobDescription]
  FROM [dbo].[Opportunity] O
  INNER JOIN [dbo].[CommunityPartners] CP ON (CP.CPID=O.CPID) 
  INNER JOIN [dbo].[Opportunity_Section] OS ON (OS.OpportunityID=O.OpportunityID)
  INNER JOIN [dbo].[Student_Section] SS ON (SS.SectionID=OS.SectionID)
  WHERE O.Status<>'pending' AND StudentID=@StudentId

End


GO
