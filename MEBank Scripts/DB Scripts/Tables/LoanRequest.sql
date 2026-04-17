USE [MEBANK]
GO

-- Extend AccountType column to support 'LoanApprover' role
ALTER TABLE [dbo].[IMEBank]
ALTER COLUMN [AccountType] [varchar](20) NOT NULL;
GO

CREATE TABLE [dbo].[LoanRequest](
    [LoanRequestID]      [varchar](50)    NOT NULL,
    [CustomerID]         [varchar](50)    NOT NULL,
    [LoanAmount]         [money]          NOT NULL,
    [LoanPurpose]        [varchar](500)   NOT NULL,
    [LoanTermMonths]     [int]            NOT NULL,
    [MonthlySalary]      [money]          NOT NULL,
    [MaxLoanEligible]    [money]          NOT NULL,
    [FinancialScore]     [decimal](5, 2)  NOT NULL,
    [ScoreGrade]         [varchar](10)    NOT NULL,
    [DocumentDescription][varchar](1000)  NULL,
    [Status]             [varchar](20)    NOT NULL,
    [RequestDate]        [datetime]       NOT NULL,
    [RequestUser]        [varchar](50)    NOT NULL,
    [ReviewDate]         [datetime]       NULL,
    [ReviewUser]         [varchar](50)    NULL,
    [ReviewNotes]        [varchar](1000)  NULL,
    CONSTRAINT [PK_LoanRequest] PRIMARY KEY CLUSTERED ([LoanRequestID] ASC)
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[LoanRequest]
    ADD CONSTRAINT [FK_LoanRequest_Customer]
    FOREIGN KEY ([CustomerID]) REFERENCES [dbo].[Customer]([CustomerID]);
GO
