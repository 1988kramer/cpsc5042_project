USE [eServe]
GO
/****** Object:  StoredProcedure [dbo].[spUppdateTimeEntries]    Script Date: 3/24/2015 11:11:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 Create Procedure [dbo].[spUppdateTimeEntries]
   @OpportunityID int,
   @StudentID int,
   @Date date,
   @CPPID int,
   @HoursApprovedByPartner nvarchar (10),
   @WorkDateEntry date,
   @HoursVolunteered int
   As
   Begin
   Update TimeEntries SET HoursApprovedByPartner = @HoursApprovedByPartner,
   WorkDateEntry = @WorkDateEntry,
   HoursVolunteered = @HoursVolunteered
   where
OpportunityID = @OpportunityID  and
  StudentID   = @StudentID and
   Date    = @Date and
  CPPID  = @CPPID
  End

GO
