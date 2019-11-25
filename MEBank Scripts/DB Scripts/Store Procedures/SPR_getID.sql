USE [MEBANK]
GO

/****** Object:  StoredProcedure [dbo].[SPR_getID]    Script Date: 25/11/2562 11:09:34 ******/
SET ANSI_NULLS OFF
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPR_getID]
(
	@AccountType	VARCHAR (10),
	@ID				VARCHAR (50) OUTPUT,
	@Result			int OUTPUT,
	@ErrorMsg		VARCHAR(1000) OUTPUT
)
AS
DECLARE @Number VARCHAR(50);
BEGIN
	IF @AccountType = 'Admin'
		BEGIN
			SET @Number = (IsNull((SELECT RIGHT(REPLICATE('0',10) + MAX(IsNull(RIGHT(CustomerID,10),0)),10)
					From IMEBank WHERE AccountType = @AccountType),0) + 1)
			SET @ID = (SELECT 'AD' + RIGHT(REPLICATE('0',10) + @Number, 10));
		END
	ELSE IF @AccountType = 'Bank'
		BEGIN
			SET @Number = (IsNull((SELECT RIGHT(REPLICATE('0',10) + MAX(IsNull(RIGHT(CustomerID,10),0)),10)
					From IMEBank WHERE AccountType = @AccountType),0) + 1)
			SET @ID = (SELECT 'BO' + RIGHT(REPLICATE('0',10) + @Number, 10));
		END
	ELSE IF @AccountType = 'Business'
		BEGIN
			SET @Number = (IsNull((SELECT RIGHT(REPLICATE('0',10) + MAX(IsNull(RIGHT(CustomerID,10),0)),10)
					From BankAccount WHERE AccountType = @AccountType),0) + 1)
			SET @ID = (SELECT 'BU' + RIGHT(REPLICATE('0',10) + @Number, 10));
		END

	SET @Result = 0;
END
GO

