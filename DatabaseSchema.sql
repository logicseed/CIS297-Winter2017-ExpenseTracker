CREATE TABLE [dbo].[Account] (
    [AccountID] INT           NOT NULL,
    [Name]      VARCHAR (MAX) NOT NULL,
    [Type]      INT           DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([AccountID] ASC)
);

CREATE TABLE [dbo].[Budget] (
    [BudgetID] INT  NOT NULL,
    [Month]    DATE NOT NULL,
    PRIMARY KEY CLUSTERED ([BudgetID] ASC)
);

CREATE TABLE [dbo].[Goal] (
    [GoalID]   INT        NOT NULL,
    [BudgetID] INT        NOT NULL,
    [Category] INT        NOT NULL,
    [Amount]   FLOAT (53) NOT NULL,
    PRIMARY KEY CLUSTERED ([GoalID] ASC)
);

CREATE TABLE [dbo].[Transaction] (
    [TransactionID] INT           NOT NULL,
    [AccountID]     INT           NOT NULL,
    [DateTime]      DATETIME      NOT NULL,
    [Category]      INT           NULL,
    [Memo]          VARCHAR (MAX) NULL,
    [Amount]        FLOAT (53)    NOT NULL,
    PRIMARY KEY CLUSTERED ([TransactionID] ASC)
);