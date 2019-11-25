USE [MEBANK]
GO

/****** Object:  StoredProcedure [dbo].[SPA_transfer]    Script Date: 25/11/2562 11:14:12 ******/
SET ANSI_NULLS OFF
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPA_transfer]
(
	@TransferFrom		VARCHAR (20),
	@TransferTo			VARCHAR (20),
	@Amount				MONEY,
	@TransactionCreated	VARCHAR (20),
	@Result				int OUTPUT,
	@ErrorMsg			VARCHAR(1000) OUTPUT
)
AS
DECLARE @TransactionNo VARCHAR(50);
DECLARE @Number VARCHAR(50);
BEGIN
	IF EXISTS (SELECT IBANNo FROM BankAccount WHERE IBANNo = @TransferFrom AND Amount < @Amount)
		BEGIN
			SET @Result = -1
			SET @ErrorMsg = 'Insufficient balance'
			RETURN;
		END

	IF NOT EXISTS (SELECT IBANNo FROM BankAccount WHERE IBANNo = @TransferTo)
		BEGIN
			SET @Result = -1
			SET @ErrorMsg = 'IBAN No of recipient is incorrect'
			RETURN;
		END

	SET @Number = (IsNull((SELECT RIGHT(REPLICATE('0',20) + MAX(IsNull(RIGHT(TransactionID,20),0)),20)
					From [dbo].[Transaction]),0) + 1)

	SET @TransactionNo = (SELECT 'MBT' + RIGHT(REPLICATE('0',20) + @Number, 20))

	--Deduct amount from source account no.
	UPDATE BankAccount
	SET Amount = Amount - @Amount,
		LastUpdatedDate = getDate(),
		LastUpdatedUser = @TransactionCreated
	WHERE IBANNo = @TransferFrom;

	--Add amount from recipient account no.
	UPDATE BankAccount
	SET Amount = Amount + @Amount,
		LastUpdatedDate = getDate(),
		LastUpdatedUser = @TransactionCreated
	WHERE IBANNo = @TransferTo;

	INSERT INTO [dbo].[Transaction](TransactionID, SourceIBANNo, DestIBANNo, TransactionType, Amount, Fee, TransactionDate, TransactionUser)
	VALUES (@TransactionNo, @TransferFrom, @TransferTo, 'Transfer In (Online)', @Amount, 0, getDate(), @TransactionCreated)

	SET @Result = 0
END
GO

