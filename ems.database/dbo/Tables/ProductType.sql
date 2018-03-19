CREATE TABLE [dbo].[ProductType] (
    [prdTypeId]   INT          NOT NULL,
    [prdTypeName] VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_ProductType] PRIMARY KEY CLUSTERED ([prdTypeId] ASC)
);

