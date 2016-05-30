USE [eServe]
GO
/****** Object:  StoredProcedure [dbo].[spGetStudentVolunteeredPartnerApprovedHoursByOpportunityId]    Script Date: 5/29/2016 10:41:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE Procedure [dbo].[spGetStudentVolunteeredPartnerApprovedHoursByOpportunityId]
	@StudentId int,
	@OpportunityID int
AS
Begin
  SET NOCOUNT ON;

    -- Insert statements for procedure here
  SELECT 
  [HoursVolunteered],
  [PartnerApprovedHours]     	  
  FROM [dbo].[TimeEntries] 
  WHERE StudentID = @StudentID AND OpportunityID = @OpportunityID

END






GO
