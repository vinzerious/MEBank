USE [MEBANK]
GO

/****** Object:  Table [dbo].[Transaction]    Script Date: 25/11/2562 11:07:04 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Transaction](
	[TransactionID] [varchar](50) NOT NULL,
	[SourceIBANNo] [varchar](20) NOT NULL,
	[DestIBANNo] [varchar](20) NOT NULL,
	[TransactionType] [varchar](20) NOT NULL,
	[Amount] [money] NOT NULL,
	[Fee] [money] NOT NULL,
	[TransactionDate] [datetime] NOT NULL,
	[TransactionUser] [varchar](50) NOT NULL
) ON [PRIMARY]
GO

