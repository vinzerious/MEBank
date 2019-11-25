USE [MEBANK]
GO

/****** Object:  StoredProcedure [dbo].[SPR_getCustomerID]    Script Date: 25/11/2562 11:09:15 ******/
SET ANSI_NULLS OFF
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPR_getCustomerID]
(
	@CustomerID		VARCHAR (50) OUTPUT,
	@Result			int OUTPUT,
	@ErrorMsg		VARCHAR(1000) OUTPUT
)
AS
DECLARE @Number VARCHAR(50);
BEGIN
	SET @Number = (IsNull((SELECT RIGHT(REPLICATE('0',10) + MAX(IsNull(RIGHT(CustomerID,10),0)),10)
					From Customer),0) + 1)

	SET @CustomerID = (SELECT 'MB' + RIGHT(REPLICATE('0',10) + @Number, 10))
	SET @Result = 0
END
GO

