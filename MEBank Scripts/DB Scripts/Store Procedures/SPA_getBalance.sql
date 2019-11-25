USE [MEBANK]
GO

/****** Object:  StoredProcedure [dbo].[SPA_getBalance]    Script Date: 25/11/2562 11:07:46 ******/
SET ANSI_NULLS OFF
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPA_getBalance]
(
	@IBANNo			VARCHAR(20),
	@Amount			VARCHAR(50) OUTPUT,
	@Result			int OUTPUT,
	@ErrorMsg		VARCHAR(1000) OUTPUT
)
AS
BEGIN
	SELECT TOP 1 @Amount = Amount
	From BankAccount
	WHERE IBANNo = @IBANNo

	If @@RowCount = 0
		BEGIN
			Set @ErrorMsg = 'IBAN No is wrong'
			Set @Result = -1
			RETURN;
		END
	SET @Result = 0
END
GO

