USE [eServe]
GO
/****** Object:  Table [dbo].[Opportunity_Section]    Script Date: 3/24/2015 11:11:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Opportunity_Section](
	[OpportunityID] [int] NOT NULL,
	[SectionID] [int] NOT NULL,
 CONSTRAINT [PK_SectionOpportunity] PRIMARY KEY CLUSTERED 
(
	[OpportunityID] ASC,
	[SectionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO
