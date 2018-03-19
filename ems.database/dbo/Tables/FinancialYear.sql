﻿
CREATE TABLE [dbo].[FinancialYear](
	[FyID] [int] IDENTITY(1,1) NOT NULL,
	[FyName] [varchar](50) NOT NULL,
	[FyFrom] [datetime] NOT NULL,
	[FyTo] [datetime] NOT NULL,
 CONSTRAINT [PK_FinancialYear] PRIMARY KEY CLUSTERED 
(
	[FyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]