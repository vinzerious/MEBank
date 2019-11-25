USE [MEBANK]
GO

/****** Object:  StoredProcedure [dbo].[SPR_IMERegister]    Script Date: 25/11/2562 11:09:54 ******/
SET ANSI_NULLS OFF
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPR_IMERegister]
(
	@usr			VARCHAR (20),
	@pwd			VARCHAR (30),
	@CustomerID		VARCHAR (20),
	@AccountType	VARCHAR (10),
	@AccountCreated	VARCHAR (20),
	@ID				VARCHAR (50) OUTPUT,
	@Result			int OUTPUT,
	@ErrorMsg		VARCHAR(1000) OUTPUT
)
AS
BEGIN
	
	IF EXISTS (SELECT UserID FROM IMEBank WHERE UserID = @usr)
		BEGIN
			SET @Result = -1
			SET @ErrorMsg = 'User ID has already used. Please change.'
			RETURN;
		END
	--IF @AccountType = 'New'
	--	BEGIN
	--		SET @ID = @CustomerID
	--	END

	--EXEC SPR_getID @AccountType, @ID = @ID OUTPUT, @Result = @Result OUTPUT, @ErrorMsg = @ErrorMsg OUTPUT;

	INSERT INTO IMEBank(UserID, Password, CustomerID, LastLogin, AccountType, CreatedDate, CreatedUser, LastUpdatedDate, LastUpdatedUser)
	VALUES (@usr, @pwd, @CustomerID, null, @AccountType, getDate(), @AccountCreated, null, null)

	SET @Result = 0
END
GO

