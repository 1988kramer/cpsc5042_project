USE [eServe]
GO
/****** Object:  StoredProcedure [dbo].[spGetCommunityPartnerStudentView]    Script Date: 5/30/2016 7:48:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spGetCommunityPartnerStudentView]
AS
BEGIN
SET NoCount On
SELECT
o.OpportunityID,
o.Name,
o.CPPID,
o.CPID,
s.StudentID,
s.FirstName,
s.LastName,
SignUpStatus,
PartnerEvaluation,
ss.SectionID,
ss.SectionName,
p.ProfessorID,
p.EmailID AS ProfessorEmail,
p.FirstName AS ProfessorFirstName,
p.LastName AS ProfessorLastName,
vt.TotalHours AS TotalHoursVolunteered,
PartnerApprovedHours

FROM vwTotalVolunteeredHours vt

INNER JOIN
SignUpFor
ON vt.OpportunityID = SignUpFor.OpportunityID

and vt.StudentID = SignUpFor.StudentID
INNER JOIN
Student s
ON SignUpFor.StudentID = s.StudentID  
 
INNER JOIN 
Opportunity o
ON SignUpFor.OpportunityID = o.OpportunityID

INNER JOIN
Opportunity_Section
ON o.OpportunityID = Opportunity_Section.OpportunityID

INNER JOIN
Section ss
ON Opportunity_Section.SectionID = ss.SectionID

INNER JOIN
Professor p
ON ss.ProfessorID = p.ProfessorID

END

GO