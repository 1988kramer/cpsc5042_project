USE [eServe]
GO
/****** Object:  View [dbo].[vwOpportunityBySection]    Script Date: 3/24/2015 11:11:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create View [dbo].[vwOpportunityBySection]
as
select Opportunity.OpportunityId as OpportunityId,Name, Section.SectionID as SectionID,class.CourseID as CourseID,class.CourseName as CourseName from Opportunity
join Opportunity_Section
on Opportunity.OpportunityId = Opportunity_Section.OpportunityId
join Section
on Section.SectionID = Opportunity_Section.SectionID
join Class
on Class.CourseID = Section.CourseID
GO
