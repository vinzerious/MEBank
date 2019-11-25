USE [MEBANK]
GO

/****** Object:  Table [dbo].[Customer]    Script Date: 25/11/2562 11:05:53 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Customer](
	[CustomerID] [varchar](50) NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[MiddleName] [varchar](100) NULL,
	[Surname] [varchar](100) NOT NULL,
	[IDNo] [varchar](50) NOT NULL,
	[Address] [varchar](500) NOT NULL,
	[TelNo] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatedUser] [varchar](50) NOT NULL,
	[LastUpdatedDate] [datetime] NULL,
	[LastUpdatedUser] [varchar](50) NULL
) ON [PRIMARY]
GO

