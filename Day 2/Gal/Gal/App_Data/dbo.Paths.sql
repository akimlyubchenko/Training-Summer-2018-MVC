CREATE TABLE [dbo].[Paths] (
    [Id]        INT           IDENTITY (1, 1) NOT NULL,
    [smallPath] NVARCHAR (50) NOT NULL,
    [fullPath]  NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

