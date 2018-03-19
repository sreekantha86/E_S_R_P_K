CREATE TABLE [dbo].[ServiceIncomeDT](
	[SerInvRowId] [int] IDENTITY(1,1) NOT NULL,
	[SerInvId] [int] NOT NULL,
	[SerId] [int] NOT NULL,
	[RowRemarks] [varchar](5000) NULL,
	[Amount] [decimal](18, 2) NOT NULL,
	[GSTPer] [decimal](18, 2) NOT NULL,
	[SGSTPer] [decimal](18, 2) NOT NULL,
	[SGSTAmount] [decimal](18, 2) NOT NULL,
	[CGSTPer] [decimal](18, 2) NOT NULL,
	[CGSTAmount] [decimal](18, 2) NOT NULL,
	[TotalAmount] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_ServiceIncomeDT] PRIMARY KEY CLUSTERED 
(
	[SerInvRowId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY], 
    CONSTRAINT [FK_ServiceIncomeDT_ServiceIncomeHD] FOREIGN KEY ([SerInvId]) REFERENCES [ServiceIncomeHD]([SerInvId]), 
    CONSTRAINT [FK_ServiceIncomeDT_ServiceExpense] FOREIGN KEY ([SerId]) REFERENCES [ServiceExpense]([SerId])
) ON [PRIMARY]

GO
