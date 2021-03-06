USE [eServe]
GO
/****** Object:  StoredProcedure [dbo].[spAddTimeEntries]    Script Date: 3/24/2015 11:11:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

   Create Procedure [dbo].[spAddTimeEntries]
   
   @Date date,
   @OpportunityID int,
   @StudentID int,
   @CPPID int,
   @HoursApprovedByPartner nvarchar (1), 
   @WorkDateEntry date,
   @HoursVolunteered int
   
   As
   Begin
   Insert into TimeEntries
   ( Date,OpportunityID,StudentID,CPPID,HoursApprovedByPartner,WorkDateEntry,HoursVolunteered )
   Values (@Date,@OpportunityID,@StudentID,@CPPID,@HoursApprovedByPartner,@WorkDateEntry,@HoursVolunteered)
   end

GO
