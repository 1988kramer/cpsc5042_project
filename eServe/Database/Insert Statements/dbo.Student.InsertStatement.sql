USE [eServe]
GO
/* */
SET ANSI_NULLS ON
SET ANSI_WARNINGS OFF
GO
SET QUOTED_IDENTIFIER ON
GO
INSERT INTO [dbo].[Student](
StudentID, 
DateOfBirth, 
FirstName, 
LastName, 
PreferedName,
EmailID,
Password,
Gender,
InternationalStudent,
LastBackgroundCheck)
VALUES(
106288,
'1999-1-10',
'Admin',
'Account',
'Admin',
'Student@eServeSU.net',
'129280;',
'male',
'no',
'2016-5-16')
GO
