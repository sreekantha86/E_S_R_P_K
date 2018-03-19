CREATE TABLE [dbo].[VendorType] (
    [VendorTypeId]   INT          NOT NULL,
    [VendorTypeName] VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_VendorType] PRIMARY KEY CLUSTERED ([VendorTypeId] ASC)
);

