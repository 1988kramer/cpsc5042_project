USE [eServe]
GO
/****** Object:  Table [dbo].[CommunityPartnersPeople]    Script Date: 3/24/2015 11:11:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CommunityPartnersPeople](
	[CPPID] [int] IDENTITY(1,1) NOT NULL,
	[CPID] [int] NOT NULL,
	[FirstName] [nvarchar](15) NOT NULL,
	[LastName] [nvarchar](15) NOT NULL,
	[Title] [nvarchar](15) NOT NULL,
	[Phone] [nvarchar](13) NOT NULL,
	[EmailID] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](10) NULL,
 CONSTRAINT [PK_CPPID] PRIMARY KEY CLUSTERED 
(
	[CPPID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON),
 CONSTRAINT [UQ_PartnerPeople] UNIQUE NONCLUSTERED 
(
	[FirstName] ASC,
	[LastName] ASC,
	[Phone] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO
ALTER TABLE [dbo].[CommunityPartnersPeople]  WITH CHECK ADD  CONSTRAINT [FK_CPID] FOREIGN KEY([CPID])
REFERENCES [dbo].[CommunityPartners] ([CPID])
GO
ALTER TABLE [dbo].[CommunityPartnersPeople] CHECK CONSTRAINT [FK_CPID]
GO
