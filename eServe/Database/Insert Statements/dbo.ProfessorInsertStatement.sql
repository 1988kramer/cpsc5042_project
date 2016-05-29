USE [eServe]
GO
/* */
SET ANSI_NULLS ON
SET ANSI_WARNINGS OFF
GO
SET QUOTED_IDENTIFIER ON
GO
INSERT INTO [dbo].[Professor]
(
	FirstName,
	LastName,
	EmailID,
	Phone
)
VALUES
(
	'George',
	'Sinclair',
	'george.sinclair@sqUni.edu',
	'2062961000'
)
GO