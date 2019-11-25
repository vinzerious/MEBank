USE [MEBANK]
GO

/****** Object:  StoredProcedure [dbo].[SPR_checkIDNo]    Script Date: 25/11/2562 11:08:40 ******/
SET ANSI_NULLS OFF
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPR_checkIDNo]
(
	@CustomerID		VARCHAR(20),
	@IDNo			VARCHAR(50),
	@Result			int OUTPUT,
	@ErrorMsg		VARCHAR(1000) OUTPUT
)
AS
BEGIN
	SELECT TOP 1 @CustomerID = CustomerID
	From Customer
	WHERE CustomerID = @CustomerID
	AND IDNo = @IDNo

	If @@RowCount = 0
		BEGIN
			Set @ErrorMsg = 'ID Number not matched with Customer ID'
			Set @Result = -1
			RETURN;
		END
	SET @Result = 0
END
GO

