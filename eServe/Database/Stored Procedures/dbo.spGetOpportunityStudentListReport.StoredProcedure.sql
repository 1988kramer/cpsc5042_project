USE [eServe]
GO
/****** Object:  StoredProcedure [dbo].[spGetOpportunityStudentListReport]    Script Date: 5/28/2016 2:55:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spGetOpportunityStudentListReport]
	@QuarterID int	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT
		o.OpportunityID AS OpportunityID,
		o.Name AS OpportunityName,
		cp.OrganizationName AS OrganizationName,
		ot.Name AS OpportunityTypeName,
		c.ShortName AS CourseShortName,
		q.ShortName AS QuarterShortName,
		p.FirstName + ' ' + p.LastName AS ProfessorName,
		s.FirstName + ' ' + s.LastName AS StudentName,
		s.EmailID AS StudentEmail,
		ti.PartnerApprovedHours AS PartnerApprovedHours		

	FROM
		Opportunity o

	INNER JOIN
		OpportunityType ot
	ON
		o.TypeID = ot.TypeID

	INNER JOIN
		CommunityPartners cp
	ON
		o.CPID = cp.CPID

	INNER JOIN
		TimeEntries ti
	ON
		o.CPPID = ti.CPPID

	INNER JOIN
		[Quarter] q
	ON
		o.QuarterID = q.QuarterID

	INNER JOIN
		Opportunity_Student os
	ON
		o.OpportunityID = os.OpportunityID

	INNER JOIN
		Student s
	ON	
		os.StudentID = s.StudentID

	INNER JOIN
		Student_Section ss
	ON
		s.StudentID = ss.StudentID

	INNER JOIN
		Section sec
	ON
		ss.SectionID = sec.SectionID

	INNER JOIN
		Professor p
	ON
		sec.ProfessorID = p.ProfessorID

	INNER JOIN
		Class c
	ON
		sec.CourseID = c.CourseID

END

GO