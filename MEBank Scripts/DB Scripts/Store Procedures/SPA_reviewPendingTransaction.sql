USE [MEBANK]
GO

SET ANSI_NULLS OFF
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPA_reviewPendingTransaction]
(
	@PendingTransactionID	VARCHAR(50),
	@Action					VARCHAR(10),
	@ReviewUser				VARCHAR(50),
	@Notes					VARCHAR(500),
	@Result					INT OUTPUT,
	@ErrorMsg				VARCHAR(1000) OUTPUT
)
AS
DECLARE @TransactionNo		VARCHAR(50);
DECLARE @Number				VARCHAR(50);
DECLARE @KidsIBANNo			VARCHAR(20);
DECLARE @DestIBANNo			VARCHAR(20);
DECLARE @Amount				MONEY;
DECLARE @TransactionType	VARCHAR(20);
DECLARE @CurrentBalance		MONEY;
BEGIN
	SELECT
		@KidsIBANNo			= KidsIBANNo,
		@DestIBANNo			= DestIBANNo,
		@Amount				= Amount,
		@TransactionType	= TransactionType
	FROM PendingTransaction
	WHERE PendingTransactionID = @PendingTransactionID AND Status = 'Pending';

	IF @KidsIBANNo IS NULL
	BEGIN
		SET @Result = -1;
		SET @ErrorMsg = 'Pending transaction not found or already reviewed';
		RETURN;
	END

	IF @Action = 'Approve'
	BEGIN
		SET @CurrentBalance = (SELECT Amount FROM BankAccount WHERE IBANNo = @KidsIBANNo);

		IF @CurrentBalance < @Amount
		BEGIN
			SET @Result = -1;
			SET @ErrorMsg = 'Insufficient balance in kids account. Current balance: ' + CAST(@CurrentBalance AS VARCHAR(30));
			RETURN;
		END

		SET @Number = (ISNULL((SELECT RIGHT(REPLICATE('0',20) + MAX(ISNULL(RIGHT(TransactionID,20),0)),20)
						FROM [dbo].[Transaction]),0) + 1)

		IF @TransactionType = 'Transfer'
		BEGIN
			SET @TransactionNo = 'MBT' + RIGHT(REPLICATE('0',20) + @Number, 20)

			UPDATE BankAccount
			SET Amount = Amount - @Amount, LastUpdatedDate = GETDATE(), LastUpdatedUser = @ReviewUser
			WHERE IBANNo = @KidsIBANNo;

			UPDATE BankAccount
			SET Amount = Amount + @Amount, LastUpdatedDate = GETDATE(), LastUpdatedUser = @ReviewUser
			WHERE IBANNo = @DestIBANNo;

			INSERT INTO [dbo].[Transaction](TransactionID, SourceIBANNo, DestIBANNo, TransactionType, Amount, Fee, TransactionDate, TransactionUser)
			VALUES (@TransactionNo, @KidsIBANNo, @DestIBANNo, 'Transfer In (Online)', @Amount, 0, GETDATE(), @ReviewUser);
		END
		ELSE IF @TransactionType = 'Withdrawal'
		BEGIN
			SET @TransactionNo = 'MBW' + RIGHT(REPLICATE('0',20) + @Number, 20)

			UPDATE BankAccount
			SET Amount = Amount - @Amount, LastUpdatedDate = GETDATE(), LastUpdatedUser = @ReviewUser
			WHERE IBANNo = @KidsIBANNo;

			INSERT INTO [dbo].[Transaction](TransactionID, SourceIBANNo, DestIBANNo, TransactionType, Amount, Fee, TransactionDate, TransactionUser)
			VALUES (@TransactionNo, @KidsIBANNo, 'B00001', 'Withdrawal (Counter)', @Amount, 0, GETDATE(), @ReviewUser);
		END
	END
	ELSE IF @Action = 'Reject'
	BEGIN
		-- No financial operation; just update the status
	END
	ELSE
	BEGIN
		SET @Result = -1;
		SET @ErrorMsg = 'Invalid action. Use Approve or Reject';
		RETURN;
	END

	UPDATE PendingTransaction
	SET Status		= CASE WHEN @Action = 'Approve' THEN 'Approved' ELSE 'Rejected' END,
		ReviewDate	= GETDATE(),
		ReviewUser	= @ReviewUser,
		Notes		= @Notes
	WHERE PendingTransactionID = @PendingTransactionID;

	SET @Result = 0;
END
GO
