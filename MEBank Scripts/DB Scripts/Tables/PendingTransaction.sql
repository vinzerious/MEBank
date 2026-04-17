USE [MEBANK]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[PendingTransaction](
	[PendingTransactionID]	[varchar](50)	NOT NULL,
	[KidsIBANNo]			[varchar](20)	NOT NULL,
	[DestIBANNo]			[varchar](20)	NOT NULL,
	[TransactionType]		[varchar](20)	NOT NULL,
	[Amount]				[money]			NOT NULL,
	[Status]				[varchar](20)	NOT NULL CONSTRAINT [DF_PendingTransaction_Status] DEFAULT ('Pending'),
	[RequestDate]			[datetime]		NOT NULL,
	[RequestUser]			[varchar](50)	NOT NULL,
	[ReviewDate]			[datetime]		NULL,
	[ReviewUser]			[varchar](50)	NULL,
	[Notes]					[varchar](500)	NULL,
	CONSTRAINT [PK_PendingTransaction] PRIMARY KEY ([PendingTransactionID])
) ON [PRIMARY]
GO
