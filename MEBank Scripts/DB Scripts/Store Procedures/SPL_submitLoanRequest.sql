USE [MEBANK]
GO

SET ANSI_NULLS OFF
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPL_submitLoanRequest]
(
    @CustomerID             VARCHAR(50),
    @LoanAmount             MONEY,
    @LoanPurpose            VARCHAR(500),
    @LoanTermMonths         INT,
    @MonthlySalary          MONEY,
    @DocumentDescription    VARCHAR(1000),
    @RequestUser            VARCHAR(50),
    @LoanRequestID          VARCHAR(50) OUTPUT,
    @FinancialScore         DECIMAL(5,2) OUTPUT,
    @ScoreGrade             VARCHAR(10)  OUTPUT,
    @MaxLoanEligible        MONEY        OUTPUT,
    @Result                 INT          OUTPUT,
    @ErrorMsg               VARCHAR(1000) OUTPUT
)
AS
BEGIN
    -- Validate monthly salary
    IF @MonthlySalary <= 0
    BEGIN
        SET @Result   = -1;
        SET @ErrorMsg = 'Monthly salary must be greater than zero.';
        RETURN;
    END

    -- Validate loan amount
    IF @LoanAmount <= 0
    BEGIN
        SET @Result   = -1;
        SET @ErrorMsg = 'Loan amount must be greater than zero.';
        RETURN;
    END

    -- Enforce 5x salary cap
    SET @MaxLoanEligible = @MonthlySalary * 5;
    IF @LoanAmount > @MaxLoanEligible
    BEGIN
        SET @Result   = -1;
        SET @ErrorMsg = 'Loan amount exceeds the maximum eligible amount of ' +
                        CAST(@MaxLoanEligible AS VARCHAR(30)) +
                        ' (5 times monthly salary).';
        RETURN;
    END

    IF @LoanTermMonths <= 0
    BEGIN
        SET @Result   = -1;
        SET @ErrorMsg = 'Loan term must be at least 1 month.';
        RETURN;
    END

    -- Check customer exists
    IF NOT EXISTS (SELECT 1 FROM Customer WHERE CustomerID = @CustomerID)
    BEGIN
        SET @Result   = -1;
        SET @ErrorMsg = 'Customer not found.';
        RETURN;
    END

    -- ── Financial Score Calculation ────────────────────────────────────────
    -- Balance score  (0-40): how well current holdings cover the loan
    DECLARE @TotalBalance MONEY;
    SELECT @TotalBalance = ISNULL(SUM(Amount), 0)
    FROM BankAccount
    WHERE CustomerID = @CustomerID;

    DECLARE @BalanceScore DECIMAL(5,2);
    SET @BalanceScore =
        CASE
            WHEN @TotalBalance >= @LoanAmount * 2 THEN 40
            WHEN @TotalBalance >= @LoanAmount     THEN 30
            WHEN @TotalBalance >= @LoanAmount * 0.5 THEN 15
            ELSE 5
        END;

    -- Salary-to-loan ratio score (0-30): lower ratio = healthier repayment
    DECLARE @LoanToSalaryRatio DECIMAL(10,4);
    SET @LoanToSalaryRatio = @LoanAmount / @MonthlySalary;

    DECLARE @SalaryScore DECIMAL(5,2);
    SET @SalaryScore =
        CASE
            WHEN @LoanToSalaryRatio <= 2 THEN 30
            WHEN @LoanToSalaryRatio <= 3 THEN 20
            WHEN @LoanToSalaryRatio <= 4 THEN 10
            ELSE 5
        END;

    -- Transaction activity score (0-30): active customers are lower risk
    DECLARE @TransactionCount INT;
    SELECT @TransactionCount = COUNT(*)
    FROM [Transaction]
    WHERE SourceIBANNo IN (SELECT IBANNo FROM BankAccount WHERE CustomerID = @CustomerID)
      AND TransactionDate >= DATEADD(MONTH, -6, GETDATE());

    DECLARE @ActivityScore DECIMAL(5,2);
    SET @ActivityScore =
        CASE
            WHEN @TransactionCount >= 10 THEN 30
            WHEN @TransactionCount >= 5  THEN 20
            WHEN @TransactionCount >= 1  THEN 10
            ELSE 0
        END;

    SET @FinancialScore = @BalanceScore + @SalaryScore + @ActivityScore;

    SET @ScoreGrade =
        CASE
            WHEN @FinancialScore >= 70 THEN 'Good'
            WHEN @FinancialScore >= 40 THEN 'Fair'
            ELSE 'Poor'
        END;

    -- ── Generate LoanRequestID ─────────────────────────────────────────────
    DECLARE @Number VARCHAR(50);
    SET @Number = CAST(
        ISNULL(
            (SELECT RIGHT(REPLICATE('0',20) + MAX(ISNULL(RIGHT(LoanRequestID, 20), '0')), 20)
             FROM LoanRequest),
            0) + 1
        AS VARCHAR(50));

    SET @LoanRequestID = 'LNR' + RIGHT(REPLICATE('0', 20) + @Number, 20);

    -- ── Insert loan request ────────────────────────────────────────────────
    INSERT INTO LoanRequest
        (LoanRequestID, CustomerID, LoanAmount, LoanPurpose, LoanTermMonths,
         MonthlySalary, MaxLoanEligible, FinancialScore, ScoreGrade,
         DocumentDescription, Status, RequestDate, RequestUser)
    VALUES
        (@LoanRequestID, @CustomerID, @LoanAmount, @LoanPurpose, @LoanTermMonths,
         @MonthlySalary, @MaxLoanEligible, @FinancialScore, @ScoreGrade,
         @DocumentDescription, 'Pending', GETDATE(), @RequestUser);

    SET @Result = 0;
END
GO
