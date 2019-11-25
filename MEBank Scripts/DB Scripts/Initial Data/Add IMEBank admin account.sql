USE [MEBANK]
GO

INSERT INTO [dbo].[IMEBank]
           ([UserID]
           ,[Password]
           ,[CustomerID]
           ,[LastLogin]
           ,[AccountType]
           ,[CreatedDate]
           ,[CreatedUser]
           ,[LastUpdatedDate]
           ,[LastUpdatedUser])
     VALUES
           ('banksystemadmin'
		   ,'MEBank[00001]'
		   ,'AD0000000001'
		   ,null
		   ,'Admin'
		   ,getDate()
		   ,'Admin'
		   ,null
		   ,null)
GO


