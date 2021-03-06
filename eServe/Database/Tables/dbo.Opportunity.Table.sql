USE [eServe]
GO
/****** Object:  Table [dbo].[Opportunity]    Script Date: 3/24/2015 11:11:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Opportunity](
	[OpportunityID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Location] [nvarchar](50) NOT NULL,
	[DateOfCreation] [date] NOT NULL,
	[JobDescription] [varchar](max) NOT NULL,
	[Requirements] [varchar](1000) NOT NULL,
	[TimeCommittment] [varchar](9) NOT NULL,
	[TotalNumberOfSlots] [int] NOT NULL,
	[OrientationDate] [datetime2](7) NOT NULL,
	[Status] [varchar](50) NOT NULL,
	[ResumeRequired] [varchar](3) NOT NULL,
	[MinimumAge] [varchar](8) NOT NULL,
	[CRCRequiredByPartner] [varchar](3) NOT NULL,
	[CRCRequiredBySU] [varchar](3) NOT NULL,
	[LinkToOnlineApp] [varchar](200) NOT NULL,
	[SupervisorEmail] [nvarchar](50) NOT NULL,
	[TypeID] [int] NOT NULL,
	[CPID] [int] NOT NULL,
	[QuarterID] [int] NOT NULL,
	[CPPID] [int] NOT NULL,
	[JobHours] [varchar](20) NOT NULL,
	[DistanceFromSU] [varchar](8) NULL,
 CONSTRAINT [PK_OpportunityID] PRIMARY KEY CLUSTERED 
(
	[OpportunityID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Opportunity] ADD  CONSTRAINT [DF_Status]  DEFAULT ('Pending') FOR [Status]
GO
ALTER TABLE [dbo].[Opportunity]  WITH CHECK ADD  CONSTRAINT [FK_CommunityPartnerID] FOREIGN KEY([CPID])
REFERENCES [dbo].[CommunityPartners] ([CPID])
GO
ALTER TABLE [dbo].[Opportunity] CHECK CONSTRAINT [FK_CommunityPartnerID]
GO
ALTER TABLE [dbo].[Opportunity]  WITH CHECK ADD  CONSTRAINT [FK_CommunityPartnerPeopleID] FOREIGN KEY([CPPID])
REFERENCES [dbo].[CommunityPartnersPeople] ([CPPID])
GO
ALTER TABLE [dbo].[Opportunity] CHECK CONSTRAINT [FK_CommunityPartnerPeopleID]
GO
ALTER TABLE [dbo].[Opportunity]  WITH CHECK ADD  CONSTRAINT [FK_Quarter] FOREIGN KEY([QuarterID])
REFERENCES [dbo].[Quarter] ([QuarterID])
GO
ALTER TABLE [dbo].[Opportunity] CHECK CONSTRAINT [FK_Quarter]
GO
ALTER TABLE [dbo].[Opportunity]  WITH CHECK ADD  CONSTRAINT [FK_TypeID] FOREIGN KEY([TypeID])
REFERENCES [dbo].[OpportunityType] ([TypeID])
GO
ALTER TABLE [dbo].[Opportunity] CHECK CONSTRAINT [FK_TypeID]
GO
