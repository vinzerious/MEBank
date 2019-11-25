USE [MEBANK]
GO

/****** Object:  Table [dbo].[BankAccount]    Script Date: 25/11/2562 11:04:42 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[BankAccount](
	[IBANNo] [varchar](20) NOT NULL,
	[CustomerID] [varchar](20) NOT NULL,
	[AccountType] [varchar](20) NOT NULL,
	[Amount] [money] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatedUser] [varchar](50) NOT NULL,
	[LastUpdatedDate] [datetime] NULL,
	[LastUpdatedUser] [varchar](50) NULL
) ON [PRIMARY]
GO

