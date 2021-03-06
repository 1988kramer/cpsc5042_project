USE [eServe]
GO
/****** Object:  StoredProcedure [dbo].[spGetOpportunityByStatus]    Script Date: 3/24/2015 11:11:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spGetOpportunityByStatus]
	-- Add the parameters for the stored procedure here
	@Status nvarchar (8)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT OpportunityId,Name,Status from Opportunity
	where Status = @Status
END

GO
