USE [eServe]
GO
/****** Object:  Table [dbo].[CommunityPartners]    Script Date: 3/24/2015 11:11:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CommunityPartners](
	[CPID] [int] IDENTITY(1,1) NOT NULL,
	[OrganizationName] [nvarchar](150) NOT NULL,
	[Address] [nvarchar](500) NOT NULL,
	[Website] [nvarchar](500) NOT NULL,
	[MainPhone] [nvarchar](10) NOT NULL,
	[MissionStatement] [nvarchar](50) NULL,
	[WorkDescription] [nvarchar](500) NULL,
 CONSTRAINT [PK_CPID] PRIMARY KEY CLUSTERED 
(
	[CPID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON),
 CONSTRAINT [UQ_OrgName] UNIQUE NONCLUSTERED 
(
	[OrganizationName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO
