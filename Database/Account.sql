CREATE TABLE [dbo].[Account] (
    [AccountID] INT           NOT NULL,
    [Name]      VARCHAR (MAX) NOT NULL,
    [Type]      INT           DEFAULT 0 NOT NULL,
    PRIMARY KEY CLUSTERED ([AccountID] ASC)
)