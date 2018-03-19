CREATE TABLE [dbo].[ServiceIncomeHD](
	[SerInvId] [int] IDENTITY(1,1) NOT NULL,
	[SerInvPrefix] [varchar](50) NOT NULL,
	[SerInvNo] [int] NOT NULL,
	[SerInvDate] [datetime] NOT NULL,
	[SerinvJobNo] [varchar](500) NULL,
	[SerInvItems] [varchar](5000) NULL,
	[SerInvSEBENo] [varchar](500) NULL,
	[SerInvSEBEDate] [datetime] NULL,
	[SerInvNoContaier] [varchar](500) NULL,
	[SerInvInvoiceNo] [varchar](500) NULL,
	[SerInvInvoiceDate] [datetime] NULL,
	[SerInvNoPackages] [varchar](500) NULL,
	[SerInvBLNo] [varchar](50) NULL,
	[SerInvBLDate] [datetime] NULL,
	[SerDescription] [varchar](5000) NULL,
	[CusId] [int] NOT NULL,
	[SerInvTotalAmount] [decimal](18, 2) NOT NULL,
	[SerInvTotalCGST] [decimal](18, 2) NOT NULL,
	[SerInvTotalSGST] [decimal](18, 2) NOT NULL,
	[SerInvDeduction] [decimal](18, 2) NOT NULL,
	[SerInvDeductionRemark] [varchar](5000) NOT NULL,
	[SerInvNetPayable] [decimal](18, 2) NOT NULL,
	[SerInvRemarks] [varchar](5000) NULL,
	[SerInvDueDate] [datetime] NOT NULL,
	[ComanyId] [int] NOT NULL,
	[FyID] [int] NOT NULL,
 CONSTRAINT [PK_ServiceIncomeHD] PRIMARY KEY CLUSTERED 
(
	[SerInvId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY], 
    CONSTRAINT [FK_ServiceIncomeHD_Customer] FOREIGN KEY ([CusId]) REFERENCES [Customer]([CusId]), 
    CONSTRAINT [FK_ServiceIncomeHD_Company] FOREIGN KEY ([ComanyId]) REFERENCES [Company]([ComanyId]), 
    CONSTRAINT [FK_ServiceIncomeHD_FinancialYear] FOREIGN KEY ([FyID]) REFERENCES [FinancialYear]([FyID]), 
) ON [PRIMARY]

GO

