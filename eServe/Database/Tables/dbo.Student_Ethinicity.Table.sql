USE [eServe]
GO
/****** Object:  Table [dbo].[Student_Ethinicity]    Script Date: 3/24/2015 11:11:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student_Ethinicity](
	[StudentID] [int] NOT NULL,
	[EthinicityID] [int] NOT NULL,
 CONSTRAINT [PK_StudentEthinicity] PRIMARY KEY CLUSTERED 
(
	[StudentID] ASC,
	[EthinicityID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO
