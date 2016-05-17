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
12345,
'1999-1-10',
'Hassan',
'Sajwani',
'Matt',
'hassan.m.sajwani@gmail.com',
'129280Eserve;',
'male',
'no',
'2016-5-16')
GO
