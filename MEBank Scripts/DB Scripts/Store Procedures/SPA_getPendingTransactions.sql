USE [MEBANK]
GO

SET ANSI_NULLS OFF
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPA_getPendingTransactions]
(
	@ParentCustomerID	VARCHAR(20),
	@Result				INT OUTPUT,
	@ErrorMsg			VARCHAR(1000) OUTPUT
)
AS
BEGIN
	SELECT
		pt.PendingTransactionID,
		pt.KidsIBANNo,
		pt.DestIBANNo,
		pt.TransactionType,
		CAST(pt.Amount AS VARCHAR(30)) AS Amount,
		pt.Status,
		CONVERT(VARCHAR(20), pt.RequestDate, 120) AS RequestDate,
		pt.RequestUser
	FROM PendingTransaction pt
	INNER JOIN ParentalControl pc ON pt.KidsIBANNo = pc.KidsIBANNo
	WHERE pc.ParentCustomerID = @ParentCustomerID
	  AND pt.Status = 'Pending'
	ORDER BY pt.RequestDate DESC;

	SET @Result = 0;
END
GO
