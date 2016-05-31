USE [eServe]
GO
/* */
SET ANSI_NULLS ON
SET ANSI_WARNINGS OFF
GO
SET QUOTED_IDENTIFIER ON
GO
INSERT INTO [dbo].[Section]
(
CourseID,
ProfessorID,
QuarterID,
RoomNumber,
ClassHours,
NumberOfSlots,
SectionName
)
VALUES(
2,
1,
1,
'303',
'6:00p-8:45p',
3,
'01'
)
GO