
CREATE TABLE [dbo].[CategoryList](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NOT NULL,
 CONSTRAINT [PK_CategoryList] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CompanyNameTable]    Script Date: 12/24/2017 4:17:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CompanyNameTable](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[CompanyName] [varchar](100) NOT NULL,
 CONSTRAINT [PK_CompanyNameTable] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ItemTable]    Script Date: 12/24/2017 4:17:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ItemTable](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[itemName] [varchar](100) NOT NULL,
	[reorderLevel] [int] NOT NULL,
	[availableQuantity] [int] NOT NULL,
	[companyId] [int] NOT NULL,
	[categoryId] [int] NOT NULL,
 CONSTRAINT [PK_ItemTable] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[StockOutTable]    Script Date: 12/24/2017 4:17:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[StockOutTable](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[item] [varchar](100) NOT NULL,
	[company] [varchar](100) NOT NULL,
	[quantity] [int] NOT NULL,
	[condition] [varchar](50) NOT NULL,
	[timeStamp] [varchar](100) NULL,
 CONSTRAINT [PK_StockOutTable] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UserTable]    Script Date: 12/24/2017 4:17:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UserTable](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[userID] [varchar](50) NOT NULL,
	[password] [varchar](100) NOT NULL,
 CONSTRAINT [PK_UserTable] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[CategoryList] ON 

INSERT [dbo].[CategoryList] ([id], [Name]) VALUES (2, N'Cosmetic')
INSERT [dbo].[CategoryList] ([id], [Name]) VALUES (9, N'Electronics')
INSERT [dbo].[CategoryList] ([id], [Name]) VALUES (3, N'Food')
INSERT [dbo].[CategoryList] ([id], [Name]) VALUES (1, N'Stationary')
SET IDENTITY_INSERT [dbo].[CategoryList] OFF
SET IDENTITY_INSERT [dbo].[CompanyNameTable] ON 

INSERT [dbo].[CompanyNameTable] ([id], [CompanyName]) VALUES (3, N'Nova')
INSERT [dbo].[CompanyNameTable] ([id], [CompanyName]) VALUES (1, N'RFL')
INSERT [dbo].[CompanyNameTable] ([id], [CompanyName]) VALUES (9, N'Samsung')
INSERT [dbo].[CompanyNameTable] ([id], [CompanyName]) VALUES (6, N'Sony')
INSERT [dbo].[CompanyNameTable] ([id], [CompanyName]) VALUES (2, N'Unileaver')
INSERT [dbo].[CompanyNameTable] ([id], [CompanyName]) VALUES (4, N'Walton')
SET IDENTITY_INSERT [dbo].[CompanyNameTable] OFF
SET IDENTITY_INSERT [dbo].[ItemTable] ON 

INSERT [dbo].[ItemTable] ([id], [itemName], [reorderLevel], [availableQuantity], [companyId], [categoryId]) VALUES (1, N'Pen', 5, 0, 1, 1)
INSERT [dbo].[ItemTable] ([id], [itemName], [reorderLevel], [availableQuantity], [companyId], [categoryId]) VALUES (3, N'Rubber', 10, 13, 1, 1)
INSERT [dbo].[ItemTable] ([id], [itemName], [reorderLevel], [availableQuantity], [companyId], [categoryId]) VALUES (6, N'Tv-32"', 5, 0, 9, 9)
INSERT [dbo].[ItemTable] ([id], [itemName], [reorderLevel], [availableQuantity], [companyId], [categoryId]) VALUES (7, N'Tv-40"', 6, 7, 9, 9)
INSERT [dbo].[ItemTable] ([id], [itemName], [reorderLevel], [availableQuantity], [companyId], [categoryId]) VALUES (8, N'Iron-1200Watt', 6, 9, 9, 9)
INSERT [dbo].[ItemTable] ([id], [itemName], [reorderLevel], [availableQuantity], [companyId], [categoryId]) VALUES (11, N'Iron-1250Watt', 6, 0, 1, 9)
SET IDENTITY_INSERT [dbo].[ItemTable] OFF
SET IDENTITY_INSERT [dbo].[StockOutTable] ON 

INSERT [dbo].[StockOutTable] ([id], [item], [company], [quantity], [condition], [timeStamp]) VALUES (4, N'Rubber', N'RFL', 5, N'Sell', N'2017-12-23')
INSERT [dbo].[StockOutTable] ([id], [item], [company], [quantity], [condition], [timeStamp]) VALUES (5, N'Rubber', N'RFL', 5, N'Sell', N'2017-12-23')
INSERT [dbo].[StockOutTable] ([id], [item], [company], [quantity], [condition], [timeStamp]) VALUES (6, N'Rubber', N'RFL', 2, N'Sell', N'2017-12-23-15-39-34')
INSERT [dbo].[StockOutTable] ([id], [item], [company], [quantity], [condition], [timeStamp]) VALUES (7, N'Rubber', N'RFL', 1, N'Demage', N'2017-12-23-15-41-58')
INSERT [dbo].[StockOutTable] ([id], [item], [company], [quantity], [condition], [timeStamp]) VALUES (8, N'Rubber', N'RFL', 1, N'Lost', N'2017-12-23-15-45-46')
INSERT [dbo].[StockOutTable] ([id], [item], [company], [quantity], [condition], [timeStamp]) VALUES (9, N'Rubber', N'RFL', 4, N'Sell', N'2017-12-23-16-02-13')
INSERT [dbo].[StockOutTable] ([id], [item], [company], [quantity], [condition], [timeStamp]) VALUES (10, N'Pen', N'RFL', 1, N'Demage', N'2017-12-23-16-02-48')
INSERT [dbo].[StockOutTable] ([id], [item], [company], [quantity], [condition], [timeStamp]) VALUES (11, N'Rubber', N'RFL', 1, N'Demage', N'2017-12-23-16-02-55')
INSERT [dbo].[StockOutTable] ([id], [item], [company], [quantity], [condition], [timeStamp]) VALUES (12, N'Tv-40"', N'Samsung', 2, N'Sell', N'2017-12-24-15-57-48')
INSERT [dbo].[StockOutTable] ([id], [item], [company], [quantity], [condition], [timeStamp]) VALUES (13, N'Iron-1200Watt', N'Samsung', 1, N'Sell', N'2017-12-24-15-57-51')
INSERT [dbo].[StockOutTable] ([id], [item], [company], [quantity], [condition], [timeStamp]) VALUES (14, N'Rubber', N'RFL', 2, N'Sell', N'2017-12-24-15-57-53')
INSERT [dbo].[StockOutTable] ([id], [item], [company], [quantity], [condition], [timeStamp]) VALUES (15, N'Rubber', N'RFL', 1, N'Sell', N'2017-12-24-16-00-27')
INSERT [dbo].[StockOutTable] ([id], [item], [company], [quantity], [condition], [timeStamp]) VALUES (16, N'Tv-40"', N'Samsung', 1, N'Sell', N'2017-12-24-16-00-27')
SET IDENTITY_INSERT [dbo].[StockOutTable] OFF
SET IDENTITY_INSERT [dbo].[UserTable] ON 

INSERT [dbo].[UserTable] ([id], [userID], [password]) VALUES (1, N'admin', N'admin')
SET IDENTITY_INSERT [dbo].[UserTable] OFF
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_CategoryList]    Script Date: 12/24/2017 4:17:42 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_CategoryList] ON [dbo].[CategoryList]
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_CompanyNameTable]    Script Date: 12/24/2017 4:17:42 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_CompanyNameTable] ON [dbo].[CompanyNameTable]
(
	[CompanyName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_ItemTable]    Script Date: 12/24/2017 4:17:42 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_ItemTable] ON [dbo].[ItemTable]
(
	[itemName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ItemTable]  WITH CHECK ADD  CONSTRAINT [FK_ItemTable_CompanyNameTable] FOREIGN KEY([companyId])
REFERENCES [dbo].[CompanyNameTable] ([id])
GO
ALTER TABLE [dbo].[ItemTable] CHECK CONSTRAINT [FK_ItemTable_CompanyNameTable]
GO
ALTER TABLE [dbo].[ItemTable]  WITH CHECK ADD  CONSTRAINT [FK_ItemTable_ItemTable] FOREIGN KEY([categoryId])
REFERENCES [dbo].[CategoryList] ([id])
GO
ALTER TABLE [dbo].[ItemTable] CHECK CONSTRAINT [FK_ItemTable_ItemTable]
GO
ALTER TABLE [dbo].[StockOutTable]  WITH CHECK ADD  CONSTRAINT [FK_StockOutTable_CompanyNameTable] FOREIGN KEY([company])
REFERENCES [dbo].[CompanyNameTable] ([CompanyName])
GO
ALTER TABLE [dbo].[StockOutTable] CHECK CONSTRAINT [FK_StockOutTable_CompanyNameTable]
GO
ALTER TABLE [dbo].[StockOutTable]  WITH CHECK ADD  CONSTRAINT [FK_StockOutTable_StockOutTable] FOREIGN KEY([item])
REFERENCES [dbo].[ItemTable] ([itemName])
GO
ALTER TABLE [dbo].[StockOutTable] CHECK CONSTRAINT [FK_StockOutTable_StockOutTable]
GO
USE [master]
GO
ALTER DATABASE [ShopManagementDB] SET  READ_WRITE 
GO
