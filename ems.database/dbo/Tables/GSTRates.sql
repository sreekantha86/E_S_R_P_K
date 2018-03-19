CREATE TABLE [dbo].[GSTRates] (
    [gstId]        INT             IDENTITY (1, 1) NOT NULL,
    [gstName]      VARCHAR (150)   NOT NULL,
    [gstRate]      DECIMAL (18, 2) NOT NULL,
    [gstSgstRate]  DECIMAL (18, 2) NOT NULL,
    [gstCgstRate]  DECIMAL (18, 2) NOT NULL,
    [gstSpRemarks] VARCHAR (500)   NULL,
    CONSTRAINT [PK_GSTRates] PRIMARY KEY CLUSTERED ([gstId] ASC)
);

