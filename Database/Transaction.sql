CREATE TABLE [dbo].[Transaction] (
    [TransactionID] INT           NOT NULL,
    [AccountID]     INT           NOT NULL,
    [DateTime]      DATETIME      NOT NULL,
    [Category]      INT           NULL DEFAULT 0,
    [Memo]          VARCHAR (MAX) NULL,
    [Amount]        FLOAT (53)    NOT NULL,
    PRIMARY KEY CLUSTERED ([TransactionID] ASC)
)