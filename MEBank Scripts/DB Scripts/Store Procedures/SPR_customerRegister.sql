USE [MEBANK]
GO

/****** Object:  StoredProcedure [dbo].[SPR_customerRegister]    Script Date: 25/11/2562 11:08:56 ******/
SET ANSI_NULLS OFF
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPR_customerRegister]
(
	@Name			VARCHAR (100),
	@MiddleName		VARCHAR (100),
	@Surname		VARCHAR (100),
	@IDNo			VARCHAR (50),
	@Address		VARCHAR (500),
	@TelNo			INT,
	@AccountCreated	VARCHAR(20),
	@CustomerID		VARCHAR (100) OUTPUT,
	@Result			int OUTPUT,
	@ErrorMsg		VARCHAR(1000) OUTPUT
)
AS
BEGIN
	IF EXISTS (SELECT IDNo FROM Customer WHERE IDNo = @IDNo)
		BEGIN
			SET @Result = -1
			SET @ErrorMsg = 'Only 1 ID Number per customer registration'
			RETURN;
		END

	IF EXISTS (SELECT TelNo FROM Customer WHERE TelNo = @TelNo)
		BEGIN
			SET @Result = -1
			SET @ErrorMsg = 'Only 1 Telephone Number per customer registration'
			RETURN;
		END

	EXEC SPR_getCustomerID @CustomerID = @CustomerID OUTPUT, @Result = @Result OUTPUT, @ErrorMsg = @ErrorMsg OUTPUT;

	INSERT INTO Customer(CustomerID, Name, MiddleName, Surname, IDNo, Address, TelNo, CreatedDate, CreatedUser, LastUpdatedDate, LastUpdatedUser)
	VALUES (@CustomerID, @Name, @MiddleName, @Surname, @IDNo, @Address, @TelNo, getDate(), @AccountCreated, null, null)

	SET @Result = 0
END
GO

