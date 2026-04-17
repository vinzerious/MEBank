USE [MEBANK]
GO

SET ANSI_NULLS OFF
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPR_setParentalControl]
(
	@KidsIBANNo			VARCHAR(20),
	@ParentCustomerID	VARCHAR(20),
	@TransactionLimit	MONEY,
	@RequireApproval	BIT,
	@CreatedUser		VARCHAR(50),
	@Result				INT OUTPUT,
	@ErrorMsg			VARCHAR(1000) OUTPUT
)
AS
DECLARE @ControlID VARCHAR(50);
DECLARE @Number VARCHAR(50);
BEGIN
	IF NOT EXISTS (SELECT IBANNo FROM BankAccount WHERE IBANNo = @KidsIBANNo AND AccountType = 'Kids')
	BEGIN
		SET @Result = -1;
		SET @ErrorMsg = 'Account not found or is not a Kids account';
		RETURN;
	END

	IF NOT EXISTS (SELECT CustomerID FROM Customer WHERE CustomerID = @ParentCustomerID)
	BEGIN
		SET @Result = -1;
		SET @ErrorMsg = 'Parent Customer ID not found';
		RETURN;
	END

	IF EXISTS (SELECT KidsIBANNo FROM ParentalControl WHERE KidsIBANNo = @KidsIBANNo)
	BEGIN
		UPDATE ParentalControl
		SET ParentCustomerID	= @ParentCustomerID,
			TransactionLimit	= @TransactionLimit,
			RequireApproval		= @RequireApproval,
			LastUpdatedDate		= GETDATE(),
			LastUpdatedUser		= @CreatedUser
		WHERE KidsIBANNo = @KidsIBANNo;
	END
	ELSE
	BEGIN
		SET @Number = (ISNULL((SELECT RIGHT(REPLICATE('0',20) + MAX(ISNULL(RIGHT(ControlID,20),0)),20)
						FROM ParentalControl),0) + 1)
		SET @ControlID = 'MBC' + RIGHT(REPLICATE('0',20) + @Number, 20)

		INSERT INTO ParentalControl(ControlID, KidsIBANNo, ParentCustomerID, TransactionLimit, RequireApproval, CreatedDate, CreatedUser)
		VALUES (@ControlID, @KidsIBANNo, @ParentCustomerID, @TransactionLimit, @RequireApproval, GETDATE(), @CreatedUser);
	END

	SET @Result = 0;
END
GO
