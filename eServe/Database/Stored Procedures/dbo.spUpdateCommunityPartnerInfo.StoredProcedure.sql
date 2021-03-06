USE [eServe]
GO
/****** Object:  StoredProcedure [dbo].[spUpdateCommunityPartnerInfo]    Script Date: 3/24/2015 11:11:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[spUpdateCommunityPartnerInfo]
 
@CPID int,
@OrganizationName nvarchar (150),
@Address nvarchar (500),
@Website nvarchar(500),
@MainPhone nvarchar (10),
@MissionStatement nvarchar (50),
@WorkDescription nvarchar (500)
As
Begin
Update communitypartners Set OrganizationName = @OrganizationName,
Address = @Address,
Website = @Website,
MainPhone = @MainPhone,
MissionStatement = @MissionStatement,
WorkDescription = @WorkDescription
where @CPID = CPID
END

GO
