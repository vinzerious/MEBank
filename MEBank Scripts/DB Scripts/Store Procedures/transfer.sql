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
	@Status				VARCHAR (20) OUTPUT,
	@Result				int OUTPUT,
	@ErrorMsg			VARCHAR(1000) OUTPUT
)
AS
DECLARE @TransactionNo		VARCHAR(50);
DECLARE @Number				VARCHAR(50);
DECLARE @SourceAccountType	VARCHAR(20);
DECLARE @TransactionLimit	MONEY;
DECLARE @RequireApproval	BIT;
DECLARE @PendingID			VARCHAR(50);
DECLARE @PendingNumber		VARCHAR(50);
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

	-- Parental control check for Kids accounts
	SET @SourceAccountType = (SELECT AccountType FROM BankAccount WHERE IBANNo = @TransferFrom);

	IF @SourceAccountType = 'Kids'
	BEGIN
		SELECT @TransactionLimit = TransactionLimit, @RequireApproval = RequireApproval
		FROM ParentalControl
		WHERE KidsIBANNo = @TransferFrom;

		IF @TransactionLimit IS NOT NULL AND @Amount > @TransactionLimit
		BEGIN
			SET @Result = -1;
			SET @ErrorMsg = 'Transaction exceeds parental limit of ' + CAST(@TransactionLimit AS VARCHAR(30));
			RETURN;
		END

		IF @RequireApproval = 1
		BEGIN
			SET @PendingNumber = (ISNULL((SELECT RIGHT(REPLICATE('0',20) + MAX(ISNULL(RIGHT(PendingTransactionID,20),0)),20)
							FROM PendingTransaction),0) + 1)
			SET @PendingID = 'MBP' + RIGHT(REPLICATE('0',20) + @PendingNumber, 20)

			INSERT INTO PendingTransaction(PendingTransactionID, KidsIBANNo, DestIBANNo, TransactionType, Amount, Status, RequestDate, RequestUser)
			VALUES (@PendingID, @TransferFrom, @TransferTo, 'Transfer', @Amount, 'Pending', GETDATE(), @TransactionCreated);

			SET @Status = 'Pending';
			SET @Result = 0;
			SET @ErrorMsg = 'Transaction submitted for parent approval';
			RETURN;
		END
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

	SET @Status = 'Success';
	SET @Result = 0
END
GO
