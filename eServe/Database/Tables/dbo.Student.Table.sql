USE [eServe]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 3/24/2015 11:11:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[StudentID] [int] NOT NULL,
	[DateOfBirth] [date] NOT NULL,
	[FirstName] [nvarchar](15) NOT NULL,
	[LastName] [nvarchar](15) NOT NULL,
	[PreferedName] [nvarchar](10) NULL,
	[EmailID] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](10) NOT NULL,
	[Gender] [nvarchar](25) NULL,
	[InternationalStudent] [nvarchar](3) NOT NULL,
	[LastBackgroundCheck] [date] NULL,
 CONSTRAINT [PK_StudentID] PRIMARY KEY CLUSTERED 
(
	[StudentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO
ALTER TABLE [dbo].[Student] ADD  CONSTRAINT [DF_Student_Gender]  DEFAULT ('Prefer not to answer') FOR [Gender]
GO
