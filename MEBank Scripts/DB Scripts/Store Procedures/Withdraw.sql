USE [MEBANK]
GO

/****** Object:  StoredProcedure [dbo].[SPA_Withdraw]    Script Date: 07/03/2026 ******/
SET ANSI_NULLS OFF
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPA_Withdraw]
(
	@IBANNo				VARCHAR (20),
	@Amount				MONEY,
	@TransactionCreated	VARCHAR (20),
	@Status				VARCHAR (20) OUTPUT,
	@Result				int OUTPUT,
	@ErrorMsg			VARCHAR(1000) OUTPUT
)
AS
DECLARE @TransactionNo		VARCHAR(50);
DECLARE @Number				VARCHAR(50);
DECLARE @CurrentBalance		MONEY;
DECLARE @AccountType		VARCHAR(20);
DECLARE @TransactionLimit	MONEY;
DECLARE @RequireApproval	BIT;
DECLARE @PendingID			VARCHAR(50);
DECLARE @PendingNumber		VARCHAR(50);
BEGIN
	SET @CurrentBalance = (SELECT Amount FROM BankAccount WHERE IBANNo = @IBANNo);

	IF @CurrentBalance < @Amount
	BEGIN
		SET @Result = -1;
		SET @ErrorMsg = 'Insufficient balance. Current balance: ' + CAST(@CurrentBalance AS VARCHAR(30));
		RETURN;
	END

	-- Parental control check for Kids accounts
	SET @AccountType = (SELECT AccountType FROM BankAccount WHERE IBANNo = @IBANNo);

	IF @AccountType = 'Kids'
	BEGIN
		SELECT @TransactionLimit = TransactionLimit, @RequireApproval = RequireApproval
		FROM ParentalControl
		WHERE KidsIBANNo = @IBANNo;

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
			VALUES (@PendingID, @IBANNo, 'B00001', 'Withdrawal', @Amount, 'Pending', GETDATE(), @TransactionCreated);

			SET @Status = 'Pending';
			SET @Result = 0;
			SET @ErrorMsg = 'Withdrawal submitted for parent approval';
			RETURN;
		END
	END

	SET @Number = (IsNull((SELECT RIGHT(REPLICATE('0',20) + MAX(IsNull(RIGHT(TransactionID,20),0)),20)
					From [dbo].[Transaction]),0) + 1)

	SET @TransactionNo = (SELECT 'MBW' + RIGHT(REPLICATE('0',20) + @Number, 20))

	-- Deduct amount from account
	UPDATE BankAccount
	SET Amount = Amount - @Amount,
		LastUpdatedDate = getDate(),
		LastUpdatedUser = @TransactionCreated
	WHERE IBANNo = @IBANNo;

	-- Insert withdrawal transaction record
	INSERT INTO [dbo].[Transaction](TransactionID, SourceIBANNo, DestIBANNo, TransactionType, Amount, Fee, TransactionDate, TransactionUser)
	VALUES (@TransactionNo, @IBANNo, 'B00001', 'Withdrawal (Counter)', @Amount, 0, getDate(), @TransactionCreated)

	SET @Status = 'Success';
	SET @Result = 0
END
GO
