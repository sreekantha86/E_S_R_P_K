CREATE TABLE [dbo].[Warehouse] (
    [whId]            INT            IDENTITY (1, 1) NOT NULL,
    [whCode]          VARCHAR (50)   NOT NULL,
    [whName]          VARCHAR (50)   NOT NULL,
    [whAddress]       VARCHAR (5000) NULL,
    [whTel]           VARCHAR (50)   NULL,
    [whMob]           VARCHAR (50)   NULL,
    [whEmail]         VARCHAR (50)   NULL,
    [whContactPerson] VARCHAR (150)  NULL,
    CONSTRAINT [PK_Warehouse] PRIMARY KEY CLUSTERED ([whId] ASC)
);

