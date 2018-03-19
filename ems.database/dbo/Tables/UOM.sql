CREATE TABLE [dbo].[UOM] (
    [uomId]        INT           NOT NULL,
    [uomName]      VARCHAR (500) NOT NULL,
    [uomShortName] VARCHAR (50)  NOT NULL,
    CONSTRAINT [PK_UOM] PRIMARY KEY CLUSTERED ([uomId] ASC)
);

