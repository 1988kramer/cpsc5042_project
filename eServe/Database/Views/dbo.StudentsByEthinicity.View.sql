USE [eServe]
GO
/****** Object:  View [dbo].[StudentsByEthinicity]    Script Date: 3/24/2015 11:11:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create view [dbo].[StudentsByEthinicity]
as
select Student.StudentID as StudentID, InternationalStudent, Ethinicity.EthinicityID as EthinicityID ,Description from Student
Join Student_Ethinicity
on Student.StudentID = Student_Ethinicity.StudentID
join Ethinicity
on Student_Ethinicity.EthinicityID = Ethinicity.EthinicityID
GO
