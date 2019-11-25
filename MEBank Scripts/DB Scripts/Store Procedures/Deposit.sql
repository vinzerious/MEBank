USE [MEBANK]
GO

/****** Object:  StoredProcedure [dbo].[SPA_Deposit]    Script Date: 25/11/2562 11:13:51 ******/
SET ANSI_NULLS OFF
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPA_Deposit]
(
	@IBANNo				VARCHAR (20),
	@Amount				MONEY,
	@TransactionCreated	VARCHAR (20),
	@Result				int OUTPUT,
	@ErrorMsg			VARCHAR(1000) OUTPUT
)
AS
DECLARE @TransactionNo VARCHAR(50);
DECLARE @Number VARCHAR(50);
DECLARE @Fee MONEY;
BEGIN
	SET @Number = (IsNull((SELECT RIGHT(REPLICATE('0',20) + MAX(IsNull(RIGHT(TransactionID,20),0)),20)
					From [dbo].[Transaction]),0) + 1)

	SET @TransactionNo = (SELECT 'MBD' + RIGHT(REPLICATE('0',20) + @Number, 20))

	SET @Fee = @Amount * 0.001;

	--Add amount (after fee deducted) to account.
	UPDATE BankAccount
	SET Amount = Amount + (@Amount - @Fee),
		LastUpdatedDate = getDate(),
		LastUpdatedUser = @TransactionCreated
	WHERE IBANNo = @IBANNo;

	--Add fee to bank account
	UPDATE BankAccount
	SET Amount = @Fee,
		LastUpdatedDate = getDate(),
		LastUpdatedUser = @TransactionCreated
	WHERE IBANNo = 'B00001';

	-- Add transaction for deposit
	INSERT INTO [dbo].[Transaction](TransactionID, SourceIBANNo, DestIBANNo, TransactionType, Amount, Fee, TransactionDate, TransactionUser)
	VALUES (@TransactionNo, 'B00001', @IBANNo, 'Deposit (Counter)', @Amount, @Fee, getDate(), @TransactionCreated)

	--Add fee transaction to bank account
	INSERT INTO [dbo].[Transaction](TransactionID, SourceIBANNo, DestIBANNo, TransactionType, Amount, Fee, TransactionDate, TransactionUser)
	VALUES (@TransactionNo, @IBANNo, 'B00001', 'Deposit (Counter)', @Fee, 0, getDate(), @TransactionCreated)

	SET @Result = 0
END
GO

