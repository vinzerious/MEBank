USE [MEBANK]
GO

INSERT INTO [dbo].[BankAccount]
           ([IBANNo]
           ,[CustomerID]
           ,[AccountType]
           ,[Amount]
           ,[CreatedDate]
           ,[CreatedUser]
           ,[LastUpdatedDate]
           ,[LastUpdatedUser])
     VALUES
           ('B00001','B00001','Fee','0',getDate(),'Admin',null,null)
GO