USE [eServe]
GO
/****** Object:  StoredProcedure [dbo].[spUpdateCommunityPartnersPeople]    Script Date: 3/24/2015 11:11:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[spUpdateCommunityPartnersPeople]
@CPPID int,
@FirstName nvarchar (15),
@LastName nvarchar (15),
@Title nvarchar (15),
@Phone nvarchar (15),
@EmailID nvarchar (50)
As
Begin
Update CommunityPartnersPeople Set FirstName = @FirstName,
LastName = @LastName,
Title = @Title,
Phone = @Phone,
EmailID = @EmailID
where 
CPPID = @CPPID
End

GO
