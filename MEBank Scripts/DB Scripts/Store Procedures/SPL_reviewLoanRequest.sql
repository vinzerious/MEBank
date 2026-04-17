USE [MEBANK]
GO

SET ANSI_NULLS OFF
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPL_reviewLoanRequest]
(
    @LoanRequestID  VARCHAR(50),
    @Action         VARCHAR(10),   -- 'Approve' or 'Reject'
    @ReviewUser     VARCHAR(50),
    @ReviewNotes    VARCHAR(1000),
    @Result         INT           OUTPUT,
    @ErrorMsg       VARCHAR(1000) OUTPUT
)
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM LoanRequest WHERE LoanRequestID = @LoanRequestID AND Status = 'Pending')
    BEGIN
        SET @Result   = -1;
        SET @ErrorMsg = 'Loan request not found or has already been reviewed.';
        RETURN;
    END

    IF @Action NOT IN ('Approve', 'Reject')
    BEGIN
        SET @Result   = -1;
        SET @ErrorMsg = 'Invalid action. Use Approve or Reject.';
        RETURN;
    END

    UPDATE LoanRequest
    SET
        Status      = CASE WHEN @Action = 'Approve' THEN 'Approved' ELSE 'Rejected' END,
        ReviewDate  = GETDATE(),
        ReviewUser  = @ReviewUser,
        ReviewNotes = @ReviewNotes
    WHERE LoanRequestID = @LoanRequestID;

    SET @Result = 0;
END
GO
