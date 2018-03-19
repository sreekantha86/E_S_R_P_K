CREATE TABLE [dbo].[Vendor] (
    [VendorId]      INT           IDENTITY (1, 1) NOT NULL,
    [VendorCode]    VARCHAR (50)  NULL,
    [VendorName]    VARCHAR (50)  NOT NULL,
    [Address]       VARCHAR (500) NULL,
    [PhoneNumber]   VARCHAR (50)  NULL,
    [City]          VARCHAR (50)  NULL,
    [District]      VARCHAR (50)  NULL,
    [PAN]           VARCHAR (10)  NULL,
    [ContactPerson] VARCHAR (50)  NULL,
    [Email]         VARCHAR (50)  NULL,
    [VendorTypeId]  INT           NULL,
    [CountryId]     INT           NULL,
    [GSTRegistered] BIT           NOT NULL,
    [GSTRegNo]      VARCHAR (50)  NULL,
    CONSTRAINT [PK_Vendor] PRIMARY KEY CLUSTERED ([VendorId] ASC),
    CONSTRAINT [FK_Vendor_Country] FOREIGN KEY ([CountryId]) REFERENCES [dbo].[Country] ([CountryId]),
    CONSTRAINT [FK_Vendor_VendorType] FOREIGN KEY ([VendorTypeId]) REFERENCES [dbo].[VendorType] ([VendorTypeId])
);

