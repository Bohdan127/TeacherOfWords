CREATE TABLE [dbo].[LinkedWord] (
    [Id]    BIGINT      IDENTITY (1, 1) NOT NULL,
    [Word]  NCHAR (200) NOT NULL,
    [ParId] BIGINT      NULL,
    [Language] NCHAR(2) NOT NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
GO