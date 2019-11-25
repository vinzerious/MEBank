USE [MEBANK]
GO

/****** Object:  Table [dbo].[IMEBank]    Script Date: 25/11/2562 11:06:27 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[IMEBank](
	[UserID] [varchar](20) NOT NULL,
	[Password] [varchar](30) NOT NULL,
	[CustomerID] [varchar](50) NOT NULL,
	[LastLogin] [datetime] NULL,
	[AccountType] [varchar](10) NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatedUser] [varchar](50) NOT NULL,
	[LastUpdatedDate] [datetime] NULL,
	[LastUpdatedUser] [varchar](50) NULL
) ON [PRIMARY]
GO

