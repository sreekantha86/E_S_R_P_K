CREATE TABLE [dbo].[Country] (
    [CountryId]   INT           IDENTITY (1, 1) NOT NULL,
    [CountryName] VARCHAR (500) NOT NULL,
    [Region]      VARCHAR (50)  NOT NULL,
    CONSTRAINT [PK_Country] PRIMARY KEY CLUSTERED ([CountryId] ASC)
);

