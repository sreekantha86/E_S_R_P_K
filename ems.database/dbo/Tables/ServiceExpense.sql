CREATE TABLE [dbo].[ServiceExpense] (
    [SerId]      INT            IDENTITY (1, 1) NOT NULL,
    [SerSAC]     VARCHAR (50)   NOT NULL,
    [SerName]    VARCHAR (250)  NOT NULL,
    [gstId]      INT            NOT NULL,
    [SerOrExp]   VARCHAR (5)    NOT NULL,
    [SerRemarks] VARCHAR (5000) NULL,
    CONSTRAINT [PK_ServiceExpense] PRIMARY KEY CLUSTERED ([SerId] ASC)
);

