USE [eServe]
GO
/****** Object:  StoredProcedure [dbo].[spRemoveCourseSectionFromOpportunity]    Script Date: 3/24/2015 11:11:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spRemoveCourseSectionFromOpportunity]	
	@OpportunityID int,
	@CourseSectionIDs varchar(1000)	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DELETE FROM
		Opportunity_Section
	WHERE 
		OpportunityID = @OpportunityID
	AND
		SectionID in
		(SELECT splitData FROM dbo.fnSplitString(@CourseSectionIDs,';'))

END


GO
