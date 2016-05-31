USE [eServe]
GO
/****** Object:  StoredProcedure [dbo].[spGetCommunityPartnerStudentView]    Script Date: 5/30/2016 7:48:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[spGetCommunityPartnerStudentView]
As
Begin
Set NoCount On
Select
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
p.FirstName as ProfessorFirstName,
p.LastName as ProfessorLastName,
vt.TotalHours as TotalHoursVolunteered,
PartnerApprovedHours
from vwTotalVolunteeredHours vt
inner join
SignUpFor
on vt.OpportunityID = SignUpFor.OpportunityID
and vt.StudentID = SignUpFor.StudentID
inner join
Student s
on SignUpFor.StudentID = s.StudentID
   
inner join 
Opportunity o
on SignUpFor.OpportunityID = o.OpportunityID
inner join
Opportunity_Section
on o.OpportunityID = Opportunity_Section.OpportunityID
inner join
Section ss
on Opportunity_Section.SectionID = ss.SectionID
inner join
Professor p
on ss.ProfessorID = p.ProfessorID
 end

GO