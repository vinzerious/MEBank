USE [MEBANK]
GO

/****** Object:  StoredProcedure [dbo].[SPR_openBankAccount]    Script Date: 25/11/2562 11:10:11 ******/
SET ANSI_NULLS OFF
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPR_openBankAccount]
(
	@IBANNo			VARCHAR (20),
	@CustomerID		VARCHAR (20),
	@AccountType	VARCHAR (20),
	@Amount			MONEY,
	@AccountCreated	VARCHAR (20),
	@Result			int OUTPUT,
	@ErrorMsg		VARCHAR(1000) OUTPUT
)
AS
BEGIN
	IF EXISTS (SELECT IBANNo FROM BankAccount WHERE IBANNo = @IBANNo)
		BEGIN
			SET @Result = -1
			SET @ErrorMsg = 'Already have this IBAN No'
			RETURN;
		END

	INSERT INTO BankAccount(IBANNo, CustomerID, AccountType, Amount, CreatedDate, CreatedUser, LastUpdatedDate, LastUpdatedUser)
	VALUES (@IBANNo, @CustomerID, @AccountType, @Amount, getDate(), @AccountCreated, null, null)

	SET @Result = 0
END
GO

