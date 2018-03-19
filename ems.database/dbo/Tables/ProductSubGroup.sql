CREATE TABLE [dbo].[ProductSubGroup] (
    [prdSGId]      INT            IDENTITY (1, 1) NOT NULL,
    [prdSGCode]    VARCHAR (50)   NOT NULL,
    [prdSGName]    VARCHAR (250)  NOT NULL,
    [prdMGId]      INT            NOT NULL,
    [gstId]        INT            NULL,
    [prdSGRemarks] VARCHAR (5000) NULL,
    CONSTRAINT [PK_ProductSubGroup] PRIMARY KEY CLUSTERED ([prdSGId] ASC)
);

