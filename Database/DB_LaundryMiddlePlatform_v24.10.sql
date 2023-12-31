USE [LaundryManagementPRN]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 24/10/2023 11:00:11 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[AccountId] [int] IDENTITY(1,1) NOT NULL,
	[Email] [nvarchar](50) NULL,
	[Password] [nvarchar](20) NULL,
	[FullName] [nvarchar](50) NULL,
	[Address] [nvarchar](50) NULL,
	[PhoneNumber] [varchar](10) NULL,
	[DateOfBirth] [date] NULL,
	[Role] [nvarchar](10) NULL,
	[Status] [bit] NULL,
 CONSTRAINT [PK__Account__349DA5A69C8C52D0] PRIMARY KEY CLUSTERED 
(
	[AccountId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 24/10/2023 11:00:11 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[OrderId] [int] IDENTITY(1,1) NOT NULL,
	[StoreId] [int] NULL,
	[CustomerId] [int] NULL,
	[CreateDate] [datetime] NULL,
	[StaffId] [int] NULL,
	[Status] [nvarchar](10) NULL,
	[TotalPrice] [float] NULL,
	[PaymentDate] [datetime] NULL,
 CONSTRAINT [PK__Order__C3905BCF7831D705] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetail]    Script Date: 24/10/2023 11:00:11 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetail](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[OrderId] [int] NULL,
	[ServiceId] [int] NULL,
	[Weight] [float] NULL,
	[UnitPrice] [float] NULL,
	[Price] [float] NULL,
 CONSTRAINT [PK_OrderDetail] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Service]    Script Date: 24/10/2023 11:00:11 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Service](
	[ServiceId] [int] IDENTITY(1,1) NOT NULL,
	[StoreId] [int] NULL,
	[Name] [nvarchar](50) NULL,
	[PricePerWeight] [float] NULL,
	[WashType] [nvarchar](50) NULL,
	[WashOption] [nvarchar](50) NULL,
	[Duration] [nchar](10) NULL,
	[Description] [nvarchar](100) NULL,
	[Status] [bit] NULL,
 CONSTRAINT [PK__Service__C51BB00AFAE92481] PRIMARY KEY CLUSTERED 
(
	[ServiceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Store]    Script Date: 24/10/2023 11:00:11 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Store](
	[StoreId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Address] [nvarchar](100) NULL,
	[PhoneNumber] [varchar](10) NULL,
	[ManagementId] [int] NULL,
	[IsAvailable] [bit] NULL,
	[Status] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[StoreId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Account] ON 

INSERT [dbo].[Account] ([AccountId], [Email], [Password], [FullName], [Address], [PhoneNumber], [DateOfBirth], [Role], [Status]) VALUES (1, N'giaducdang@gmail.com', N'1', N'Dang Gia Duc', N'Thu Duc', N'0917094920', CAST(N'2003-02-17' AS Date), N'Admin', 1)
INSERT [dbo].[Account] ([AccountId], [Email], [Password], [FullName], [Address], [PhoneNumber], [DateOfBirth], [Role], [Status]) VALUES (2, N'hieuth@gmai.com', N'1', N'Tran Hoa Hieu', N'Thu Duc', N'0909113114', CAST(N'2003-01-01' AS Date), N'Staff', 1)
INSERT [dbo].[Account] ([AccountId], [Email], [Password], [FullName], [Address], [PhoneNumber], [DateOfBirth], [Role], [Status]) VALUES (3, N'phungdny@gmail.com', N'1', N'Do Nguyen Yen Phung', N'Thu Duc', N'0989899998', CAST(N'2003-01-01' AS Date), N'User', 1)
INSERT [dbo].[Account] ([AccountId], [Email], [Password], [FullName], [Address], [PhoneNumber], [DateOfBirth], [Role], [Status]) VALUES (4, N'anlnm@fpt.com', N'1', N'An Luon', N'Thu Duc', N'0902819382', CAST(N'2004-01-01' AS Date), N'Store', 1)
INSERT [dbo].[Account] ([AccountId], [Email], [Password], [FullName], [Address], [PhoneNumber], [DateOfBirth], [Role], [Status]) VALUES (5, N'baodt@fpt.com', N'1', N'Duong Bao', N'Vung Tau', N'0909113114', CAST(N'2003-08-21' AS Date), N'Store', 1)
SET IDENTITY_INSERT [dbo].[Account] OFF
GO
SET IDENTITY_INSERT [dbo].[Store] ON 

INSERT [dbo].[Store] ([StoreId], [Name], [Address], [PhoneNumber], [ManagementId], [IsAvailable], [Status]) VALUES (1, N'Store 1', N'Vinhomes', N'0989434837', 4, 1, 1)
INSERT [dbo].[Store] ([StoreId], [Name], [Address], [PhoneNumber], [ManagementId], [IsAvailable], [Status]) VALUES (2, N'Store 2', N'Thu Duc', N'0909113114', 5, 1, 1)
SET IDENTITY_INSERT [dbo].[Store] OFF
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Account] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Account] ([AccountId])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Account]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Staff] FOREIGN KEY([StaffId])
REFERENCES [dbo].[Account] ([AccountId])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Staff]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Store] FOREIGN KEY([StoreId])
REFERENCES [dbo].[Store] ([StoreId])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Store]
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetail_Order] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Order] ([OrderId])
GO
ALTER TABLE [dbo].[OrderDetail] CHECK CONSTRAINT [FK_OrderDetail_Order]
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetail_Service] FOREIGN KEY([ServiceId])
REFERENCES [dbo].[Service] ([ServiceId])
GO
ALTER TABLE [dbo].[OrderDetail] CHECK CONSTRAINT [FK_OrderDetail_Service]
GO
ALTER TABLE [dbo].[Service]  WITH CHECK ADD  CONSTRAINT [FK_Service_Store] FOREIGN KEY([StoreId])
REFERENCES [dbo].[Store] ([StoreId])
GO
ALTER TABLE [dbo].[Service] CHECK CONSTRAINT [FK_Service_Store]
GO
