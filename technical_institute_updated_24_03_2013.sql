USE [technical_institute]
GO
/****** Object:  Table [dbo].[student_tbl]    Script Date: 04/24/2013 22:44:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[student_tbl](
	[student_id] [bigint] NOT NULL,
	[register_no] [varchar](50) NULL,
	[student_name] [varchar](50) NULL,
	[father_name] [varchar](50) NULL,
	[last_name] [varchar](50) NULL,
	[father_full_name] [varchar](50) NULL,
	[mother_name] [varchar](50) NULL,
	[date_of_birth] [varchar](50) NULL,
	[age] [varchar](50) NULL,
	[gender] [varchar](50) NULL,
	[category] [varchar](50) NULL,
	[religion] [varchar](50) NULL,
	[caste] [varchar](50) NULL,
	[sub_cast] [varchar](50) NULL,
	[marital_status] [varchar](50) NULL,
	[admission_date] [varchar](50) NULL,
	[father_occupation] [varchar](50) NULL,
	[aadhar_id] [varchar](50) NULL,
	[contact_no] [varchar](50) NULL,
	[alternate_no] [varchar](50) NULL,
	[email_id] [varchar](50) NULL,
	[photo] [varchar](150) NULL,
	[nationality] [varchar](150) NULL,
	[trade_name] [varchar](150) NULL,
 CONSTRAINT [PK_student_personel_info_tbl] PRIMARY KEY CLUSTERED 
(
	[student_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[student_enquiry_tbl]    Script Date: 04/24/2013 22:44:28 ******/
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
	[date] [varchar](50) NULL,
	[month] [varchar](50) NULL,
	[year] [varchar](50) NULL,
	[city] [varchar](150) NULL,
 CONSTRAINT [PK_student_enquiry_tbl] PRIMARY KEY CLUSTERED 
(
	[enquiry_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[address_tbl]    Script Date: 04/24/2013 22:44:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[address_tbl](
	[address_id] [bigint] IDENTITY(1,1) NOT NULL,
	[student_id] [bigint] NOT NULL,
	[local_address] [varchar](150) NULL,
	[local_city] [varchar](150) NULL,
	[local_taluka] [varchar](50) NULL,
	[local_district] [varchar](150) NULL,
	[local_state] [varchar](150) NULL,
	[local_pin] [varchar](50) NULL,
	[permanent_address] [varchar](150) NULL,
	[permanent_city] [varchar](150) NULL,
	[permanent_taluka] [varchar](50) NULL,
	[permanent_district] [varchar](150) NULL,
	[permanent_state] [varchar](150) NULL,
	[permanent_pin] [varchar](50) NULL,
	[nationality] [varchar](50) NULL,
 CONSTRAINT [PK_address_tbl] PRIMARY KEY CLUSTERED 
(
	[address_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[academic_year_tbl]    Script Date: 04/24/2013 22:44:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[academic_year_tbl](
	[academic_year_id] [bigint] IDENTITY(1,1) NOT NULL,
	[academic_year] [varchar](150) NULL,
 CONSTRAINT [PK_academic_year_tbl] PRIMARY KEY CLUSTERED 
(
	[academic_year_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[user_tbl]    Script Date: 04/24/2013 22:44:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[user_tbl](
	[use_name] [varchar](50) NULL,
	[password] [varchar](50) NULL,
	[security_question] [varchar](50) NULL,
	[security_answer] [varchar](50) NULL,
	[contact_number] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[trade_tbl]    Script Date: 04/24/2013 22:44:28 ******/
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
/****** Object:  Table [dbo].[trade_info_tbl]    Script Date: 04/24/2013 22:44:28 ******/
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
/****** Object:  ForeignKey [fk_trade_id_on_trade_info_id_key]    Script Date: 04/24/2013 22:44:28 ******/
ALTER TABLE [dbo].[trade_info_tbl]  WITH CHECK ADD  CONSTRAINT [fk_trade_id_on_trade_info_id_key] FOREIGN KEY([trade_id])
REFERENCES [dbo].[trade_tbl] ([trade_id])
GO
ALTER TABLE [dbo].[trade_info_tbl] CHECK CONSTRAINT [fk_trade_id_on_trade_info_id_key]
GO
