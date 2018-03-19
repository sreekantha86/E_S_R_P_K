CREATE TABLE [dbo].[Company] (
    [ComanyId]        INT           IDENTITY (1, 1) NOT NULL,
    [CompanyName]     VARCHAR (50)  NOT NULL,
    [CompanyWebsite]  VARCHAR (50)  NULL,
    [ContactNumbers]  VARCHAR (50)  NULL,
    [CompanyMailId]   VARCHAR (50)  NULL,
    [CompanyAddress1] VARCHAR (500) NULL,
    [CompanyAddress2] VARCHAR (500) NULL,
    [CompanyAddress3] VARCHAR (500) NULL,
    [TIN]             VARCHAR (50)  NULL,
    [PAN]             VARCHAR (50)  NULL,
    [IECode]          VARCHAR (50)  NULL,
    [GSTRegistered]   BIT           NULL,
    [GSTNo]           VARCHAR (25)  NULL,
    CONSTRAINT [PK_Company] PRIMARY KEY CLUSTERED ([ComanyId] ASC)
);

