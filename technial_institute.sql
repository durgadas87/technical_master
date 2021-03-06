USE [technical_institute]
GO
/****** Object:  Table [dbo].[trade_tbl]    Script Date: 04/15/2013 11:57:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[trade_tbl](
	[trade_id] [bigint] NOT NULL,
	[trade_name] [varchar](150) NOT NULL,
 CONSTRAINT [PK_trade_tbl] PRIMARY KEY CLUSTERED 
(
	[trade_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[trade_info_tbl]    Script Date: 04/15/2013 11:57:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[trade_info_tbl](
	[trade_info_id] [bigint] NOT NULL,
	[trade_id] [bigint] NOT NULL,
	[trade_duration] [varchar](50) NOT NULL,
	[trade_fees] [varchar](150) NULL,
 CONSTRAINT [PK_trade_info_tbl] PRIMARY KEY CLUSTERED 
(
	[trade_info_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
