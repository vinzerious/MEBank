USE [MEBANK]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ParentalControl](
	[ControlID]			[varchar](50)	NOT NULL,
	[KidsIBANNo]		[varchar](20)	NOT NULL,
	[ParentCustomerID]	[varchar](20)	NOT NULL,
	[TransactionLimit]	[money]			NULL,
	[RequireApproval]	[bit]			NOT NULL CONSTRAINT [DF_ParentalControl_RequireApproval] DEFAULT (0),
	[CreatedDate]		[datetime]		NOT NULL,
	[CreatedUser]		[varchar](50)	NOT NULL,
	[LastUpdatedDate]	[datetime]		NULL,
	[LastUpdatedUser]	[varchar](50)	NULL,
	CONSTRAINT [PK_ParentalControl] PRIMARY KEY ([ControlID]),
	CONSTRAINT [UQ_ParentalControl_KidsIBANNo] UNIQUE ([KidsIBANNo])
) ON [PRIMARY]
GO
