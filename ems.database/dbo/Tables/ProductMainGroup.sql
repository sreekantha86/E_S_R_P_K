CREATE TABLE [dbo].[ProductMainGroup] (
    [prdMGId]      INT            IDENTITY (1, 1) NOT NULL,
    [prdMGHSN]     VARCHAR (250)  NULL,
    [prdMGName]    VARCHAR (250)  NOT NULL,
    [prdTypeId]    INT            NOT NULL,
    [prdMGRemarks] VARCHAR (5000) NULL,
    CONSTRAINT [PK_ProductMainGroup] PRIMARY KEY CLUSTERED ([prdMGId] ASC)
);

