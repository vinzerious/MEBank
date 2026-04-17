USE [MEBANK]
GO

SET ANSI_NULLS OFF
GO

SET QUOTED_IDENTIFIER ON
GO

-- Returns all loan requests for a specific customer
CREATE PROCEDURE [dbo].[SPL_getMyLoanRequests]
(
    @CustomerID VARCHAR(50),
    @Result     INT           OUTPUT,
    @ErrorMsg   VARCHAR(1000) OUTPUT
)
AS
BEGIN
    SELECT
        LoanRequestID,
        LoanAmount,
        LoanPurpose,
        LoanTermMonths,
        MonthlySalary,
        MaxLoanEligible,
        FinancialScore,
        ScoreGrade,
        DocumentDescription,
        Status,
        RequestDate,
        ReviewDate,
        ReviewUser,
        ReviewNotes
    FROM LoanRequest
    WHERE CustomerID = @CustomerID
    ORDER BY RequestDate DESC;

    SET @Result = 0;
END
GO
