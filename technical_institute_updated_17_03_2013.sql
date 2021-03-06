USE [technical_institute]
GO
/****** Object:  Table [dbo].[student_enquiry_tbl]    Script Date: 04/17/2013 10:28:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[student_enquiry_tbl](
	[enquiry_id] [bigint] NOT NULL,
	[student_name] [varchar](150) NULL,
	[address] [varchar](150) NULL,
	[contact_no] [varchar](50) NULL,
	[trade] [varchar](50) NULL,
	[gender] [varchar](50) NULL,
	[education] [varchar](150) NULL,
	[date_of_enquiry] [varchar](150) NULL,
	[email_id] [varchar](150) NULL,
 CONSTRAINT [PK_student_enquiry_tbl] PRIMARY KEY CLUSTERED 
(
	[enquiry_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[trade_tbl]    Script Date: 04/17/2013 10:28:44 ******/
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
/****** Object:  Table [dbo].[trade_info_tbl]    Script Date: 04/17/2013 10:28:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[trade_info_tbl](
	[trade_info_id] [bigint] IDENTITY(1,1) NOT NULL,
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
/****** Object:  ForeignKey [fk_trade_id_on_trade_info_id_key]    Script Date: 04/17/2013 10:28:44 ******/
ALTER TABLE [dbo].[trade_info_tbl]  WITH CHECK ADD  CONSTRAINT [fk_trade_id_on_trade_info_id_key] FOREIGN KEY([trade_id])
REFERENCES [dbo].[trade_tbl] ([trade_id])
GO
ALTER TABLE [dbo].[trade_info_tbl] CHECK CONSTRAINT [fk_trade_id_on_trade_info_id_key]
GO
