USE [MEBANK]
GO

/****** Object:  StoredProcedure [dbo].[SPL_checkLogin]    Script Date: 25/11/2562 11:08:05 ******/
SET ANSI_NULLS OFF
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPL_checkLogin]
(
	@usr			VARCHAR (20),
	@pwd			VARCHAR (30),
	@AccountType	VARCHAR (10) OUTPUT,
	@CustomerID		VARCHAR (50) OUTPUT,
	@Result			int OUTPUT,
	@ErrorMsg		VARCHAR(1000) OUTPUT
)
AS
BEGIN
	SELECT TOP 1 @AccountType = AccountType, @CustomerID = CustomerID
	From IMEBank
	WHERE UserID = @usr
	AND Password = @pwd

	If @@RowCount = 0
		Begin
			Set @ErrorMsg = 'Username or password is incorrect.'
			Set @Result = -1
		End
	Else
		BEGIN
			UPDATE IMEBank
			SET LastLogin = getDate()

			Set @Result =  0
		END
END
GO

