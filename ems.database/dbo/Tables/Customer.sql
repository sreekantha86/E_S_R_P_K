CREATE TABLE [dbo].[Customer] (
    [CusId]         INT            IDENTITY (1, 1) NOT NULL,
    [CusCode]       VARCHAR (50)   NULL,
    [CusName]       VARCHAR (250)  NOT NULL,
    [Phone]         VARCHAR (50)   NULL,
    [Fax]           VARCHAR (50)   NULL,
    [Email]         VARCHAR (50)   NULL,
    [ContactPerson] VARCHAR (150)  NULL,
    [Address]       VARCHAR (5000) NULL,
    [GSTNo]         VARCHAR (50)   NULL,
    CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED ([CusId] ASC)
);

