USE [eServe]
GO
/****** Object:  StoredProcedure [dbo].[spGetProfile]    Script Date: 3/24/2015 11:11:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spGetProfile]	
	@StudentId int  
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT S.[StudentID]
      ,[FirstName]
      ,[LastName]      
	  ,[PreferedName]
	  ,[DateOfBirth]
      ,[Gender]
	  --,E.Description As 'Ethinicity'      
	  --,FA.AreaName
      ,[InternationalStudent]
      ,[LastBackgroundCheck]
  FROM [dbo].[Student] S 
  --LEFT JOIN [dbo].[Student_Ethinicity] SE ON (SE.StudentID=S.StudentID)
  --INNER JOIN [dbo].[Ethinicity] E ON (E.EthinicityID=SE.EthinicityID) 
  --LEFT JOIN [dbo].[Student_FocusArea] SFA ON (SFA.StudentID=S.StudentID) 
  --INNER JOIN [dbo].[FocusArea] FA ON (FA.FocusAreaID=SFA.FocusAreaID)  
  where StudentID=@StudentId
	
END








GO
