USE [Exams]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 5/27/2020 8:35:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[CustomerID] [int] NOT NULL,
	[Name] [varchar](255) NULL,
	[Age] [int] NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetailLegacy]    Script Date: 5/27/2020 8:35:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetailLegacy](
	[Name] [varchar](255) NULL,
	[Age] [int] NULL,
	[Total Price] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetails]    Script Date: 5/27/2020 8:35:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetails](
	[OrderID] [varchar](10) NOT NULL,
	[ProductID] [int] NOT NULL,
	[Quantity] [int] NULL,
 CONSTRAINT [PK_OrderDetails] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC,
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 5/27/2020 8:35:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderID] [varchar](10) NOT NULL,
	[CustomerID] [int] NULL,
	[OrderDate] [datetime] NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 5/27/2020 8:35:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ProductID] [int] NOT NULL,
	[Name] [varchar](255) NULL,
	[Price] [int] NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Customers] ([CustomerID], [Name], [Age]) VALUES (1, N'Siwat Jirawiwatpat', 25)
GO
INSERT [dbo].[Customers] ([CustomerID], [Name], [Age]) VALUES (2, N'Ajaree Chawengwongwan', 24)
GO
INSERT [dbo].[Customers] ([CustomerID], [Name], [Age]) VALUES (3, N'Thipharat Anyapornsuk', 26)
GO
INSERT [dbo].[Customers] ([CustomerID], [Name], [Age]) VALUES (4, N'Pakpoom Tiyasangthong', 24)
GO
INSERT [dbo].[OrderDetailLegacy] ([Name], [Age], [Total Price]) VALUES (N'Siwat Jirawiwatpat', 25, 2000)
GO
INSERT [dbo].[OrderDetailLegacy] ([Name], [Age], [Total Price]) VALUES (N'Ajaree Chawengwongwan', 24, 1500)
GO
INSERT [dbo].[OrderDetailLegacy] ([Name], [Age], [Total Price]) VALUES (N'Thipharat Anyapornsuk', 26, 2500)
GO
INSERT [dbo].[OrderDetailLegacy] ([Name], [Age], [Total Price]) VALUES (N'Pakpoom Tiyasangthong', 24, 500)
GO
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [Quantity]) VALUES (N'Q001', 1, 3)
GO
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [Quantity]) VALUES (N'Q001', 2, 2)
GO
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [Quantity]) VALUES (N'Q001', 3, 1)
GO
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [Quantity]) VALUES (N'Q002', 4, 2)
GO
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [Quantity]) VALUES (N'Q003', 2, 3)
GO
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [Quantity]) VALUES (N'Q003', 3, 1)
GO
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [Quantity]) VALUES (N'Q004', 1, 1)
GO
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [Quantity]) VALUES (N'Q004', 4, 5)
GO
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [Quantity]) VALUES (N'Q005', 4, 1)
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [OrderDate]) VALUES (N'Q001', 1, CAST(N'2009-01-05T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [OrderDate]) VALUES (N'Q002', 2, CAST(N'2009-02-02T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [OrderDate]) VALUES (N'Q003', 3, CAST(N'2009-05-16T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [OrderDate]) VALUES (N'Q004', 1, CAST(N'2009-10-06T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [OrderDate]) VALUES (N'Q005', 1, CAST(N'2009-12-12T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Products] ([ProductID], [Name], [Price]) VALUES (1, N'Yakult', 6)
GO
INSERT [dbo].[Products] ([ProductID], [Name], [Price]) VALUES (2, N'Nesvita', 10)
GO
INSERT [dbo].[Products] ([ProductID], [Name], [Price]) VALUES (3, N'Lays', 20)
GO
INSERT [dbo].[Products] ([ProductID], [Name], [Price]) VALUES (4, N'Lotte Xylitol', 30)
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Orders] FOREIGN KEY([OrderID])
REFERENCES [dbo].[Orders] ([OrderID])
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Orders]
GO
