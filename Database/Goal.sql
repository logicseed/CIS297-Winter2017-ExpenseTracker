CREATE TABLE [dbo].[Goal] (
    [GoalID]   INT        NOT NULL,
    [BudgetID] INT        NOT NULL,
    [Category] INT        NOT NULL,
    [Amount]   FLOAT (53) NOT NULL,
    PRIMARY KEY CLUSTERED ([GoalID] ASC)
)
