USE [eServe]
GO
/****** Object:  StoredProcedure [dbo].[spOpportunity_FocusArea]    Script Date: 3/24/2015 11:11:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 Create Procedure [dbo].[spOpportunity_FocusArea]
		 (
		 @OpportunityID int,
		 @FocusAreaID int
		 )
		 As
		 Insert into [Opportunity_FocusArea]
		 Values ( @OpportunityID,@FocusAreaID)
		 
GO
