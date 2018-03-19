CREATE TABLE [dbo].[Currency] (
    [CurId]        INT          NOT NULL,
    [CurName]      VARCHAR (50) NOT NULL,
    [CurShortName] VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Currency] PRIMARY KEY CLUSTERED ([CurId] ASC)
);

