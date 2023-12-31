USE [LaundryManagementPRN]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 28/10/2023 6:52:05 CH ******/
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
/****** Object:  Table [dbo].[Order]    Script Date: 28/10/2023 6:52:05 CH ******/
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
/****** Object:  Table [dbo].[OrderDetail]    Script Date: 28/10/2023 6:52:05 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetail](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[OrderId] [int] NULL,
	[ServiceDetailId] [int] NULL,
	[Weight] [float] NULL,
	[UnitPrice] [float] NULL,
	[Price] [float] NULL,
 CONSTRAINT [PK_OrderDetail] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Service]    Script Date: 28/10/2023 6:52:05 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Service](
	[ServiceId] [int] IDENTITY(1,1) NOT NULL,
	[StoreId] [int] NULL,
	[Name] [nvarchar](50) NULL,
	[Description] [nvarchar](100) NULL,
	[Status] [bit] NULL,
 CONSTRAINT [PK__Service__C51BB00AFAE92481] PRIMARY KEY CLUSTERED 
(
	[ServiceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ServiceDetail]    Script Date: 28/10/2023 6:52:05 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ServiceDetail](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ServiceId] [int] NULL,
	[TypeName] [nvarchar](60) NULL,
	[Type] [nvarchar](50) NULL,
	[WashOption] [nvarchar](20) NULL,
	[Duration] [time](7) NULL,
	[PricePerUnit] [float] NULL,
	[Status] [bit] NULL,
 CONSTRAINT [PK_ServiceDetail] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Store]    Script Date: 28/10/2023 6:52:05 CH ******/
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
INSERT [dbo].[Account] ([AccountId], [Email], [Password], [FullName], [Address], [PhoneNumber], [DateOfBirth], [Role], [Status]) VALUES (5, N'baodt@fpt.com', N'1', N'Duong Ton Bao', N'Vung Tau', N'0909113114', CAST(N'2003-08-21' AS Date), N'Store', 1)
INSERT [dbo].[Account] ([AccountId], [Email], [Password], [FullName], [Address], [PhoneNumber], [DateOfBirth], [Role], [Status]) VALUES (6, N'anluon@gmail.com', N'1', N'Luong Minh An', N'Thu Duc', N'0921921727', CAST(N'2004-05-02' AS Date), N'User', 1)
INSERT [dbo].[Account] ([AccountId], [Email], [Password], [FullName], [Address], [PhoneNumber], [DateOfBirth], [Role], [Status]) VALUES (7, N'duongbao2k3@gmail.com', N'1', N'Duong Bao', N'Vung Tau', N'0909133144', CAST(N'2023-10-25' AS Date), N'User', 0)
SET IDENTITY_INSERT [dbo].[Account] OFF
GO
SET IDENTITY_INSERT [dbo].[Service] ON 

INSERT [dbo].[Service] ([ServiceId], [StoreId], [Name], [Description], [Status]) VALUES (1, 1, N'Giặt quần áo thường', N'Giúp bạn tiết kiệm rất nhiều thời gian', 1)
INSERT [dbo].[Service] ([ServiceId], [StoreId], [Name], [Description], [Status]) VALUES (2, 1, N'Giặt áo khoát dày', N'No', 1)
INSERT [dbo].[Service] ([ServiceId], [StoreId], [Name], [Description], [Status]) VALUES (3, 1, N'Giặt chăn màn', N'Bao sạch bao thơm', 1)
INSERT [dbo].[Service] ([ServiceId], [StoreId], [Name], [Description], [Status]) VALUES (7, 1, N'Giặt áo vest', N'Nhanh, tiết kiệm', 1)
INSERT [dbo].[Service] ([ServiceId], [StoreId], [Name], [Description], [Status]) VALUES (8, 1, N'Giặt đồ Jean', N'Sạch, bền, thơm', 1)
SET IDENTITY_INSERT [dbo].[Service] OFF
GO
SET IDENTITY_INSERT [dbo].[ServiceDetail] ON 

INSERT [dbo].[ServiceDetail] ([Id], [ServiceId], [TypeName], [Type], [WashOption], [Duration], [PricePerUnit], [Status]) VALUES (1, 1, N'Giặt thường - Giặt sấy', N'Giặt thường', N'Giặt sấy', CAST(N'08:00:00' AS Time), 30000, 1)
INSERT [dbo].[ServiceDetail] ([Id], [ServiceId], [TypeName], [Type], [WashOption], [Duration], [PricePerUnit], [Status]) VALUES (2, 1, N'Giặt nhanh - Giặt sấy', N'Giặt nhanh', N'Giặt sấy', CAST(N'06:00:00' AS Time), 45000, 1)
INSERT [dbo].[ServiceDetail] ([Id], [ServiceId], [TypeName], [Type], [WashOption], [Duration], [PricePerUnit], [Status]) VALUES (3, 1, N'Giặt siêu tốc - Giặt sấy', N'Giặt siêu tốc', N'Giặt sấy', CAST(N'04:00:00' AS Time), 60000, 1)
INSERT [dbo].[ServiceDetail] ([Id], [ServiceId], [TypeName], [Type], [WashOption], [Duration], [PricePerUnit], [Status]) VALUES (4, 2, N'Giặt thường - Giặt sấy', N'Giặt thường', N'Giặt sấy', CAST(N'08:00:00' AS Time), 50000, 1)
INSERT [dbo].[ServiceDetail] ([Id], [ServiceId], [TypeName], [Type], [WashOption], [Duration], [PricePerUnit], [Status]) VALUES (5, 2, N'Giặt nhanh - Giặt sấy', N'Giặt nhanh', N'Giặt sấy', CAST(N'06:00:00' AS Time), 70000, 1)
INSERT [dbo].[ServiceDetail] ([Id], [ServiceId], [TypeName], [Type], [WashOption], [Duration], [PricePerUnit], [Status]) VALUES (6, 2, N'Giặt siêu tốc - Giặt sấy', N'Giặt siêu tốc', N'Giặt sấy', CAST(N'04:00:00' AS Time), 90000, 1)
INSERT [dbo].[ServiceDetail] ([Id], [ServiceId], [TypeName], [Type], [WashOption], [Duration], [PricePerUnit], [Status]) VALUES (7, 3, N'Giặt thường - Giặt sấy', N'Giặt thường', N'Giặt sấy', CAST(N'06:00:00' AS Time), 80000, 1)
INSERT [dbo].[ServiceDetail] ([Id], [ServiceId], [TypeName], [Type], [WashOption], [Duration], [PricePerUnit], [Status]) VALUES (8, 3, N'Giặt siêu tốc - Giặt sấy', N'Giặt siêu tốc', N'Giặt sấy', CAST(N'04:00:00' AS Time), 120000, 1)
INSERT [dbo].[ServiceDetail] ([Id], [ServiceId], [TypeName], [Type], [WashOption], [Duration], [PricePerUnit], [Status]) VALUES (9, 3, N'Giặt nhanh - Giặt sấy', N'Giặt nhanh', N'Giặt sấy', CAST(N'05:00:00' AS Time), 100000, 1)
INSERT [dbo].[ServiceDetail] ([Id], [ServiceId], [TypeName], [Type], [WashOption], [Duration], [PricePerUnit], [Status]) VALUES (11, 7, N'Giặt thường - Giặt sấy', N'Giặt thường', N'Giặt sấy', CAST(N'05:00:00' AS Time), 10000, 1)
INSERT [dbo].[ServiceDetail] ([Id], [ServiceId], [TypeName], [Type], [WashOption], [Duration], [PricePerUnit], [Status]) VALUES (12, 8, N'Giặt thường - Giặt ướt', N'Giặt thường', N'Giặt ướt', CAST(N'04:00:00' AS Time), 50000, 1)
INSERT [dbo].[ServiceDetail] ([Id], [ServiceId], [TypeName], [Type], [WashOption], [Duration], [PricePerUnit], [Status]) VALUES (13, 8, N'Giặt nhanh - Giặt sấy', N'Giặt nhanh', N'Giặt sấy', CAST(N'03:00:00' AS Time), 80000, 1)
SET IDENTITY_INSERT [dbo].[ServiceDetail] OFF
GO
SET IDENTITY_INSERT [dbo].[Store] ON 

INSERT [dbo].[Store] ([StoreId], [Name], [Address], [PhoneNumber], [ManagementId], [IsAvailable], [Status]) VALUES (1, N'Store 1', N'Vinhomes', N'0989434837', 4, 1, 1)
INSERT [dbo].[Store] ([StoreId], [Name], [Address], [PhoneNumber], [ManagementId], [IsAvailable], [Status]) VALUES (2, N'Store 2', N'Thu Duc', N'0909113114', 5, 1, 1)
SET IDENTITY_INSERT [dbo].[Store] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Account]    Script Date: 28/10/2023 6:52:05 CH ******/
ALTER TABLE [dbo].[Account] ADD  CONSTRAINT [UQ__Account] UNIQUE NONCLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
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
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetail_ServiceDetail] FOREIGN KEY([ServiceDetailId])
REFERENCES [dbo].[ServiceDetail] ([Id])
GO
ALTER TABLE [dbo].[OrderDetail] CHECK CONSTRAINT [FK_OrderDetail_ServiceDetail]
GO
ALTER TABLE [dbo].[Service]  WITH CHECK ADD  CONSTRAINT [FK_Service_Store] FOREIGN KEY([StoreId])
REFERENCES [dbo].[Store] ([StoreId])
GO
ALTER TABLE [dbo].[Service] CHECK CONSTRAINT [FK_Service_Store]
GO
ALTER TABLE [dbo].[ServiceDetail]  WITH CHECK ADD  CONSTRAINT [FK_ServiceDetail_Service] FOREIGN KEY([ServiceId])
REFERENCES [dbo].[Service] ([ServiceId])
GO
ALTER TABLE [dbo].[ServiceDetail] CHECK CONSTRAINT [FK_ServiceDetail_Service]
GO
