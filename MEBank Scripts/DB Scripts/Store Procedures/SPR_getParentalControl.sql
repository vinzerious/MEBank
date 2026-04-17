USE [MEBANK]
GO

SET ANSI_NULLS OFF
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPR_getParentalControl]
(
	@KidsIBANNo		VARCHAR(20),
	@Result			INT OUTPUT,
	@ErrorMsg		VARCHAR(1000) OUTPUT
)
AS
BEGIN
	SELECT
		pc.ControlID,
		pc.KidsIBANNo,
		pc.ParentCustomerID,
		ISNULL(CAST(pc.TransactionLimit AS VARCHAR(30)), '') AS TransactionLimit,
		CAST(pc.RequireApproval AS VARCHAR(5)) AS RequireApproval,
		c.Name + ' ' + c.Surname AS ParentName
	FROM ParentalControl pc
	INNER JOIN Customer c ON pc.ParentCustomerID = c.CustomerID
	WHERE pc.KidsIBANNo = @KidsIBANNo;

	SET @Result = 0;
END
GO
