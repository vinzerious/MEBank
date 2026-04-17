USE [MEBANK]
GO

SET ANSI_NULLS OFF
GO

SET QUOTED_IDENTIFIER ON
GO

-- Returns all Pending loan requests for the Loan Approver dashboard
CREATE PROCEDURE [dbo].[SPL_getLoanRequests]
(
    @Result     INT           OUTPUT,
    @ErrorMsg   VARCHAR(1000) OUTPUT
)
AS
BEGIN
    SELECT
        lr.LoanRequestID,
        lr.CustomerID,
        c.Name + ' ' + c.Surname            AS CustomerName,
        lr.LoanAmount,
        lr.LoanPurpose,
        lr.LoanTermMonths,
        lr.MonthlySalary,
        lr.MaxLoanEligible,
        lr.FinancialScore,
        lr.ScoreGrade,
        lr.DocumentDescription,
        lr.Status,
        lr.RequestDate,
        lr.RequestUser,
        lr.ReviewDate,
        lr.ReviewUser,
        lr.ReviewNotes
    FROM LoanRequest lr
    INNER JOIN Customer c ON c.CustomerID = lr.CustomerID
    WHERE lr.Status = 'Pending'
    ORDER BY lr.RequestDate ASC;

    SET @Result = 0;
END
GO
