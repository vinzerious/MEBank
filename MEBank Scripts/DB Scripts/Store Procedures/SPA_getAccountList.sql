USE [MEBANK]
GO

/****** Object:  StoredProcedure [dbo].[SPA_getAccountList]    Script Date: 25/11/2562 11:07:30 ******/
SET ANSI_NULLS OFF
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPA_getAccountList]
(
	@CustomerID		VARCHAR(50),
	@Result			int OUTPUT,
	@ErrorMsg		VARCHAR(1000) OUTPUT
)
AS
BEGIN
	SELECT IBANNo
	From BankAccount
	WHERE CustomerID = @CustomerID

	If @@RowCount = 0
		BEGIN
			Set @ErrorMsg = 'Customer ID is wrong'
			Set @Result = -1
			RETURN;
		END
	SET @Result = 0
END
GO

