USE [DBComputerStore]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 11/25/2019 2:02:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[CategoryID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](30) NULL,
	[Description] [nvarchar](250) NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 11/25/2019 2:02:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[CustomerID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](15) NULL,
	[LastName] [nvarchar](20) NULL,
	[Address] [nvarchar](250) NULL,
	[Phone] [nvarchar](11) NULL,
	[Email] [nvarchar](30) NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetails]    Script Date: 11/25/2019 2:02:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetails](
	[OrderID] [int] NOT NULL,
	[ProductID] [int] NOT NULL,
	[Quantity] [int] NULL,
	[Price] [money] NULL,
	[Amount] [money] NULL,
 CONSTRAINT [PK_OrderDetails] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC,
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 11/25/2019 2:02:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[CustomerID] [int] NULL,
	[OrderID] [int] IDENTITY(1,1) NOT NULL,
	[OrderDate] [datetime] NULL,
	[TotalAmount] [money] NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 11/25/2019 2:02:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[CategoryID] [int] NULL,
	[SupplierID] [int] NULL,
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](150) NULL,
	[ProductImage] [nvarchar](200) NULL,
	[Unit] [nvarchar](30) NULL,
	[Price] [money] NULL,
	[Description] [nvarchar](250) NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ReceiptDetails]    Script Date: 11/25/2019 2:02:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReceiptDetails](
	[ReceiptID] [int] NOT NULL,
	[ProductID] [int] NOT NULL,
	[Quantity] [int] NULL,
	[Price] [money] NULL,
	[Amount] [money] NULL,
 CONSTRAINT [PK_ReceiptDetails] PRIMARY KEY CLUSTERED 
(
	[ReceiptID] ASC,
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Receipts]    Script Date: 11/25/2019 2:02:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Receipts](
	[ReceiptID] [int] IDENTITY(1,1) NOT NULL,
	[SupplierID] [int] NULL,
	[ReceiptDate] [datetime] NULL,
	[TotalAmount] [money] NULL,
 CONSTRAINT [PK_Receipt] PRIMARY KEY CLUSTERED 
(
	[ReceiptID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 11/25/2019 2:02:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[RoleID] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [nvarchar](50) NULL,
 CONSTRAINT [PK_Role_1] PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Suppliers]    Script Date: 11/25/2019 2:02:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Suppliers](
	[SupplierID] [int] IDENTITY(1,1) NOT NULL,
	[CompanyName] [nvarchar](50) NULL,
	[ContactName] [nvarchar](35) NULL,
	[Address] [nvarchar](250) NULL,
	[Phone] [nvarchar](11) NULL,
	[Email] [nvarchar](30) NULL,
 CONSTRAINT [PK_Suppliers] PRIMARY KEY CLUSTERED 
(
	[SupplierID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserRoleRelationship]    Script Date: 11/25/2019 2:02:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserRoleRelationship](
	[UserID] [int] NULL,
	[RoleID] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 11/25/2019 2:02:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [nvarchar](35) NULL,
	[UserName] [nvarchar](20) NULL,
	[Password] [nvarchar](100) NULL,
	[Gender] [nvarchar](10) NULL,
	[Email] [nvarchar](50) NULL,
	[Phone] [nvarchar](50) NULL,
	[Avatar] [nvarchar](50) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Warehouse]    Script Date: 11/25/2019 2:02:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Warehouse](
	[ProductID] [int] NULL,
	[Stock] [int] NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([CategoryID], [CategoryName], [Description]) VALUES (13, N'Laptop Gaming', N'')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName], [Description]) VALUES (14, N'PC Workstation', N'')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName], [Description]) VALUES (15, N'Bàn phím', N'')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName], [Description]) VALUES (17, N'Phần mềm', N'')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName], [Description]) VALUES (18, N'PC Đồ họa', N'')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName], [Description]) VALUES (19, N'Ổ cứng', N'')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName], [Description]) VALUES (20, N'Chuột', N'')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName], [Description]) VALUES (21, N'Tai nghe', N'')
SET IDENTITY_INSERT [dbo].[Categories] OFF
SET IDENTITY_INSERT [dbo].[Customers] ON 

INSERT [dbo].[Customers] ([CustomerID], [FirstName], [LastName], [Address], [Phone], [Email]) VALUES (42, N'Trang', N'Vũ', N'Gia Lai', N'0159753456', N'trangvu@gmail.com')
INSERT [dbo].[Customers] ([CustomerID], [FirstName], [LastName], [Address], [Phone], [Email]) VALUES (51, N'Nezuko', N'Kamado', N'Japan', N'0147852369', N'nezuke@gmail.com')
INSERT [dbo].[Customers] ([CustomerID], [FirstName], [LastName], [Address], [Phone], [Email]) VALUES (57, N'Kochou', N'Shinobu', N'Japan', N'0145142255', N'shinobu@gmail.com')
INSERT [dbo].[Customers] ([CustomerID], [FirstName], [LastName], [Address], [Phone], [Email]) VALUES (59, N'Hiền', N'Thái Xuân ', N'Vinh', N'0971359939', N'xtit6789@gmail.com')
INSERT [dbo].[Customers] ([CustomerID], [FirstName], [LastName], [Address], [Phone], [Email]) VALUES (60, N'Ngọc Trinh', N'Trịnh', N'TP HCM', N'0147895623', N'ngoctrinh@gmail.com')
INSERT [dbo].[Customers] ([CustomerID], [FirstName], [LastName], [Address], [Phone], [Email]) VALUES (61, N'Ma', N'Jack', N'Trung Quốc', N'0369875421', N'jackma@gmail.com')
INSERT [dbo].[Customers] ([CustomerID], [FirstName], [LastName], [Address], [Phone], [Email]) VALUES (62, N'Hùng', N'Dương Thanh', N'Vinh', N'0258976431', N'hungdt@gmail.com')
INSERT [dbo].[Customers] ([CustomerID], [FirstName], [LastName], [Address], [Phone], [Email]) VALUES (66, N'Giang', N'Tống', N'Trung Quốc', N'0147986523', N'tonggiang@gmail.com')
INSERT [dbo].[Customers] ([CustomerID], [FirstName], [LastName], [Address], [Phone], [Email]) VALUES (67, N'Nguyễn Thị Thu', N'Phương', N'Thanh Hóa', N'0258976431', N'')
INSERT [dbo].[Customers] ([CustomerID], [FirstName], [LastName], [Address], [Phone], [Email]) VALUES (76, N'Kamado', N'Tanjiro', N'Japan', N'0123456789', N'')
INSERT [dbo].[Customers] ([CustomerID], [FirstName], [LastName], [Address], [Phone], [Email]) VALUES (78, N'', N'', N'', N'0258963147', N'')
SET IDENTITY_INSERT [dbo].[Customers] OFF
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [Quantity], [Price], [Amount]) VALUES (49, 47, 2, 600000.0000, 1200000.0000)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [Quantity], [Price], [Amount]) VALUES (55, 44, 8, 299000.0000, 2392000.0000)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [Quantity], [Price], [Amount]) VALUES (57, 44, 8, 299000.0000, 2392000.0000)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [Quantity], [Price], [Amount]) VALUES (57, 47, 2, 600000.0000, 1200000.0000)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [Quantity], [Price], [Amount]) VALUES (58, 44, 8, 299000.0000, 2392000.0000)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [Quantity], [Price], [Amount]) VALUES (58, 45, 2, 65000000.0000, 130000000.0000)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [Quantity], [Price], [Amount]) VALUES (58, 47, 2, 600000.0000, 1200000.0000)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [Quantity], [Price], [Amount]) VALUES (59, 44, 8, 299000.0000, 2392000.0000)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [Quantity], [Price], [Amount]) VALUES (59, 45, 2, 65000000.0000, 130000000.0000)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [Quantity], [Price], [Amount]) VALUES (59, 46, 5, 29000000.0000, 145000000.0000)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [Quantity], [Price], [Amount]) VALUES (60, 44, 8, 299000.0000, 2392000.0000)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [Quantity], [Price], [Amount]) VALUES (60, 47, 2, 600000.0000, 1200000.0000)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [Quantity], [Price], [Amount]) VALUES (64, 44, 8, 299000.0000, 2392000.0000)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [Quantity], [Price], [Amount]) VALUES (64, 47, 2, 600000.0000, 1200000.0000)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [Quantity], [Price], [Amount]) VALUES (64, 50, 2, 35000000.0000, 70000000.0000)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [Quantity], [Price], [Amount]) VALUES (65, 44, 8, 299000.0000, 2392000.0000)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [Quantity], [Price], [Amount]) VALUES (65, 45, 1, 65000000.0000, 65000000.0000)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [Quantity], [Price], [Amount]) VALUES (65, 49, 2, 60000000.0000, 120000000.0000)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [Quantity], [Price], [Amount]) VALUES (74, 51, 3, 300000.0000, 900000.0000)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [Quantity], [Price], [Amount]) VALUES (74, 52, 5, 350000.0000, 1750000.0000)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [Quantity], [Price], [Amount]) VALUES (74, 54, 2, 480000.0000, 960000.0000)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [Quantity], [Price], [Amount]) VALUES (76, 50, 2, 35000000.0000, 70000000.0000)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [Quantity], [Price], [Amount]) VALUES (76, 52, 2, 350000.0000, 700000.0000)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [Quantity], [Price], [Amount]) VALUES (76, 53, 2, 500000.0000, 1000000.0000)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [Quantity], [Price], [Amount]) VALUES (77, 46, 2, 29000000.0000, 58000000.0000)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [Quantity], [Price], [Amount]) VALUES (77, 47, 2, 600000.0000, 1200000.0000)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [Quantity], [Price], [Amount]) VALUES (78, 44, 5, 299000.0000, 1495000.0000)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [Quantity], [Price], [Amount]) VALUES (78, 52, 2, 350000.0000, 700000.0000)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [Quantity], [Price], [Amount]) VALUES (78, 54, 2, 480000.0000, 960000.0000)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [Quantity], [Price], [Amount]) VALUES (79, 44, 2, 299000.0000, 598000.0000)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [Quantity], [Price], [Amount]) VALUES (79, 49, 1, 60000000.0000, 60000000.0000)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [Quantity], [Price], [Amount]) VALUES (79, 50, 2, 35000000.0000, 70000000.0000)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [Quantity], [Price], [Amount]) VALUES (84, 46, 1, 29000000.0000, 29000000.0000)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [Quantity], [Price], [Amount]) VALUES (84, 49, 1, 60000000.0000, 60000000.0000)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [Quantity], [Price], [Amount]) VALUES (84, 53, 2, 500000.0000, 1000000.0000)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [Quantity], [Price], [Amount]) VALUES (88, 47, 2, 600000.0000, 1200000.0000)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [Quantity], [Price], [Amount]) VALUES (88, 51, 2, 300000.0000, 600000.0000)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [Quantity], [Price], [Amount]) VALUES (88, 54, 2, 480000.0000, 960000.0000)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [Quantity], [Price], [Amount]) VALUES (89, 44, 5, 299000.0000, 1495000.0000)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [Quantity], [Price], [Amount]) VALUES (89, 50, 1, 35000000.0000, 35000000.0000)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [Quantity], [Price], [Amount]) VALUES (89, 54, 1, 480000.0000, 480000.0000)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [Quantity], [Price], [Amount]) VALUES (90, 49, 1, 60000000.0000, 60000000.0000)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [Quantity], [Price], [Amount]) VALUES (90, 51, 2, 300000.0000, 600000.0000)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [Quantity], [Price], [Amount]) VALUES (90, 54, 2, 480000.0000, 960000.0000)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [Quantity], [Price], [Amount]) VALUES (91, 44, 5, 299000.0000, 1495000.0000)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [Quantity], [Price], [Amount]) VALUES (91, 45, 1, 65000000.0000, 65000000.0000)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [Quantity], [Price], [Amount]) VALUES (91, 49, 1, 60000000.0000, 60000000.0000)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [Quantity], [Price], [Amount]) VALUES (91, 50, 2, 35000000.0000, 70000000.0000)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [Quantity], [Price], [Amount]) VALUES (91, 52, 5, 350000.0000, 1750000.0000)
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([CustomerID], [OrderID], [OrderDate], [TotalAmount]) VALUES (42, 40, CAST(N'2019-10-09T19:10:44.267' AS DateTime), 195270000.0000)
INSERT [dbo].[Orders] ([CustomerID], [OrderID], [OrderDate], [TotalAmount]) VALUES (51, 49, CAST(N'2019-12-12T11:33:02.753' AS DateTime), 7790000.0000)
INSERT [dbo].[Orders] ([CustomerID], [OrderID], [OrderDate], [TotalAmount]) VALUES (57, 55, CAST(N'2019-06-11T17:59:11.840' AS DateTime), 471495000.0000)
INSERT [dbo].[Orders] ([CustomerID], [OrderID], [OrderDate], [TotalAmount]) VALUES (59, 57, CAST(N'2019-12-11T18:02:49.983' AS DateTime), 7190000.0000)
INSERT [dbo].[Orders] ([CustomerID], [OrderID], [OrderDate], [TotalAmount]) VALUES (60, 58, CAST(N'2019-07-12T17:01:57.720' AS DateTime), 141990000.0000)
INSERT [dbo].[Orders] ([CustomerID], [OrderID], [OrderDate], [TotalAmount]) VALUES (61, 59, CAST(N'2019-08-12T17:15:35.907' AS DateTime), 419980000.0000)
INSERT [dbo].[Orders] ([CustomerID], [OrderID], [OrderDate], [TotalAmount]) VALUES (62, 60, CAST(N'2019-11-13T21:31:07.637' AS DateTime), 7495000.0000)
INSERT [dbo].[Orders] ([CustomerID], [OrderID], [OrderDate], [TotalAmount]) VALUES (66, 64, CAST(N'2019-11-16T13:26:59.210' AS DateTime), 74495000.0000)
INSERT [dbo].[Orders] ([CustomerID], [OrderID], [OrderDate], [TotalAmount]) VALUES (67, 65, CAST(N'2019-10-16T16:28:27.100' AS DateTime), 186495000.0000)
INSERT [dbo].[Orders] ([CustomerID], [OrderID], [OrderDate], [TotalAmount]) VALUES (67, 74, CAST(N'2019-11-19T11:04:40.633' AS DateTime), 3610000.0000)
INSERT [dbo].[Orders] ([CustomerID], [OrderID], [OrderDate], [TotalAmount]) VALUES (42, 76, CAST(N'2019-11-19T12:30:34.203' AS DateTime), 71700000.0000)
INSERT [dbo].[Orders] ([CustomerID], [OrderID], [OrderDate], [TotalAmount]) VALUES (42, 77, CAST(N'2019-11-19T12:33:05.290' AS DateTime), 130900000.0000)
INSERT [dbo].[Orders] ([CustomerID], [OrderID], [OrderDate], [TotalAmount]) VALUES (76, 78, CAST(N'2019-11-19T12:35:43.640' AS DateTime), 3155000.0000)
INSERT [dbo].[Orders] ([CustomerID], [OrderID], [OrderDate], [TotalAmount]) VALUES (67, 79, CAST(N'2019-11-19T12:37:34.747' AS DateTime), 130598000.0000)
INSERT [dbo].[Orders] ([CustomerID], [OrderID], [OrderDate], [TotalAmount]) VALUES (76, 84, CAST(N'2019-11-20T10:37:09.293' AS DateTime), 90000000.0000)
INSERT [dbo].[Orders] ([CustomerID], [OrderID], [OrderDate], [TotalAmount]) VALUES (51, 88, CAST(N'2019-11-22T10:42:24.973' AS DateTime), 2760000.0000)
INSERT [dbo].[Orders] ([CustomerID], [OrderID], [OrderDate], [TotalAmount]) VALUES (51, 89, CAST(N'2019-11-22T13:12:12.990' AS DateTime), 36975000.0000)
INSERT [dbo].[Orders] ([CustomerID], [OrderID], [OrderDate], [TotalAmount]) VALUES (60, 90, CAST(N'2019-11-22T13:19:44.203' AS DateTime), 61560000.0000)
INSERT [dbo].[Orders] ([CustomerID], [OrderID], [OrderDate], [TotalAmount]) VALUES (42, 91, CAST(N'2019-12-22T13:25:34.947' AS DateTime), 198245000.0000)
SET IDENTITY_INSERT [dbo].[Orders] OFF
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([CategoryID], [SupplierID], [ProductID], [ProductName], [ProductImage], [Unit], [Price], [Description]) VALUES (17, 21, 44, N'Bkav Pro', N'F:\Software\ComputerStore\ComputerStore\GUI\bin\Debug\Resources\bkavpro.png', N'Gói', 299000.0000, N'Phần mềm diệt Virus')
INSERT [dbo].[Products] ([CategoryID], [SupplierID], [ProductID], [ProductName], [ProductImage], [Unit], [Price], [Description]) VALUES (14, 24, 45, N'iMac 2019', N'F:\Software\ComputerStore\ComputerStore\GUI\bin\Debug\Resources\workstation4.png', N'Bộ', 65000000.0000, N'Core i7,  RAM 16GB SSD 521GB')
INSERT [dbo].[Products] ([CategoryID], [SupplierID], [ProductID], [ProductName], [ProductImage], [Unit], [Price], [Description]) VALUES (13, 22, 46, N'MSI 2018', N'F:\Software\ComputerStore\ComputerStore\GUI\bin\Debug\Resources\gaming2.png', N'Chiếc', 29000000.0000, N'Core i7, RAM 8GB, HDD 1TB')
INSERT [dbo].[Products] ([CategoryID], [SupplierID], [ProductID], [ProductName], [ProductImage], [Unit], [Price], [Description]) VALUES (15, 22, 47, N'Bàn phím cơ LED RGB', N'F:\Software\ComputerStore\ComputerStore\GUI\bin\Debug\Resources\keyboard3.png', N'Chiếc', 600000.0000, N'16 Triệu màu')
INSERT [dbo].[Products] ([CategoryID], [SupplierID], [ProductID], [ProductName], [ProductImage], [Unit], [Price], [Description]) VALUES (18, 27, 49, N'PC 2019', N'F:\Software\ComputerStore\ComputerStore\GUI\bin\Debug\Resources\pcgraphic1.png', N'Bộ', 60000000.0000, N'Core i9, RAM 16GB')
INSERT [dbo].[Products] ([CategoryID], [SupplierID], [ProductID], [ProductName], [ProductImage], [Unit], [Price], [Description]) VALUES (13, 22, 50, N'Acer Predator 2018', N'F:\Software\ComputerStore\ComputerStore\GUI\bin\Debug\Resources\gaming4.png', N'Chiếc', 35000000.0000, N'Core i7, RAM 12GB, HDD 1TB')
INSERT [dbo].[Products] ([CategoryID], [SupplierID], [ProductID], [ProductName], [ProductImage], [Unit], [Price], [Description]) VALUES (21, 28, 51, N'Tai Nghe Audio', N'F:\Software\ComputerStore\ComputerStore\GUI\bin\Debug\Resources\headphone2.png', N'Chiếc', 300000.0000, N'Màu Green')
INSERT [dbo].[Products] ([CategoryID], [SupplierID], [ProductID], [ProductName], [ProductImage], [Unit], [Price], [Description]) VALUES (20, 28, 52, N'Chuột ROG', N'F:\Software\ComputerStore\ComputerStore\GUI\bin\Debug\Resources\mouse1.png', N'Chiếc', 350000.0000, N'Led 1 Màu')
INSERT [dbo].[Products] ([CategoryID], [SupplierID], [ProductID], [ProductName], [ProductImage], [Unit], [Price], [Description]) VALUES (19, 21, 53, N'Ổ cứng HDD 1TB', N'F:\Software\ComputerStore\ComputerStore\GUI\bin\Debug\Resources\hdd3.png', N'Chiếc', 500000.0000, N'Hãng Adata')
INSERT [dbo].[Products] ([CategoryID], [SupplierID], [ProductID], [ProductName], [ProductImage], [Unit], [Price], [Description]) VALUES (19, 21, 54, N'Ổ cứng SSD 128', N'F:\Software\ComputerStore\ComputerStore\GUI\bin\Debug\Resources\ssd3.jpg', N'Chiếc', 480000.0000, N'Hãng WD Blue')
SET IDENTITY_INSERT [dbo].[Products] OFF
INSERT [dbo].[ReceiptDetails] ([ReceiptID], [ProductID], [Quantity], [Price], [Amount]) VALUES (8, 51, 2, 300000.0000, 600000.0000)
INSERT [dbo].[ReceiptDetails] ([ReceiptID], [ProductID], [Quantity], [Price], [Amount]) VALUES (8, 52, 7, 350000.0000, 2450000.0000)
INSERT [dbo].[ReceiptDetails] ([ReceiptID], [ProductID], [Quantity], [Price], [Amount]) VALUES (9, 46, 2, 29000000.0000, 58000000.0000)
INSERT [dbo].[ReceiptDetails] ([ReceiptID], [ProductID], [Quantity], [Price], [Amount]) VALUES (9, 47, 5, 600000.0000, 3000000.0000)
INSERT [dbo].[ReceiptDetails] ([ReceiptID], [ProductID], [Quantity], [Price], [Amount]) VALUES (9, 50, 1, 35000000.0000, 35000000.0000)
INSERT [dbo].[ReceiptDetails] ([ReceiptID], [ProductID], [Quantity], [Price], [Amount]) VALUES (11, 45, 5, 65000000.0000, 325000000.0000)
INSERT [dbo].[ReceiptDetails] ([ReceiptID], [ProductID], [Quantity], [Price], [Amount]) VALUES (20, 44, 8, 299000.0000, 2392000.0000)
INSERT [dbo].[ReceiptDetails] ([ReceiptID], [ProductID], [Quantity], [Price], [Amount]) VALUES (20, 53, 5, 500000.0000, 2500000.0000)
INSERT [dbo].[ReceiptDetails] ([ReceiptID], [ProductID], [Quantity], [Price], [Amount]) VALUES (20, 54, 5, 480000.0000, 2400000.0000)
INSERT [dbo].[ReceiptDetails] ([ReceiptID], [ProductID], [Quantity], [Price], [Amount]) VALUES (21, 44, 2, 299000.0000, 598000.0000)
INSERT [dbo].[ReceiptDetails] ([ReceiptID], [ProductID], [Quantity], [Price], [Amount]) VALUES (21, 53, 2, 500000.0000, 1000000.0000)
INSERT [dbo].[ReceiptDetails] ([ReceiptID], [ProductID], [Quantity], [Price], [Amount]) VALUES (21, 54, 2, 480000.0000, 960000.0000)
INSERT [dbo].[ReceiptDetails] ([ReceiptID], [ProductID], [Quantity], [Price], [Amount]) VALUES (22, 51, 5, 300000.0000, 1500000.0000)
INSERT [dbo].[ReceiptDetails] ([ReceiptID], [ProductID], [Quantity], [Price], [Amount]) VALUES (22, 52, 2, 350000.0000, 700000.0000)
INSERT [dbo].[ReceiptDetails] ([ReceiptID], [ProductID], [Quantity], [Price], [Amount]) VALUES (24, 46, 2, 29000000.0000, 58000000.0000)
INSERT [dbo].[ReceiptDetails] ([ReceiptID], [ProductID], [Quantity], [Price], [Amount]) VALUES (24, 47, 5, 600000.0000, 3000000.0000)
INSERT [dbo].[ReceiptDetails] ([ReceiptID], [ProductID], [Quantity], [Price], [Amount]) VALUES (24, 50, 3, 35000000.0000, 105000000.0000)
SET IDENTITY_INSERT [dbo].[Receipts] ON 

INSERT [dbo].[Receipts] ([ReceiptID], [SupplierID], [ReceiptDate], [TotalAmount]) VALUES (8, 28, CAST(N'2019-11-21T14:43:27.727' AS DateTime), 1300000.0000)
INSERT [dbo].[Receipts] ([ReceiptID], [SupplierID], [ReceiptDate], [TotalAmount]) VALUES (9, 22, CAST(N'2019-10-21T14:51:40.377' AS DateTime), 96000000.0000)
INSERT [dbo].[Receipts] ([ReceiptID], [SupplierID], [ReceiptDate], [TotalAmount]) VALUES (11, 24, CAST(N'2019-12-21T21:06:12.517' AS DateTime), 325000000.0000)
INSERT [dbo].[Receipts] ([ReceiptID], [SupplierID], [ReceiptDate], [TotalAmount]) VALUES (20, 21, CAST(N'2019-09-21T23:37:14.423' AS DateTime), 7292000.0000)
INSERT [dbo].[Receipts] ([ReceiptID], [SupplierID], [ReceiptDate], [TotalAmount]) VALUES (21, 21, CAST(N'2019-11-21T23:40:02.677' AS DateTime), 2558000.0000)
INSERT [dbo].[Receipts] ([ReceiptID], [SupplierID], [ReceiptDate], [TotalAmount]) VALUES (22, 28, CAST(N'2019-09-22T07:31:41.250' AS DateTime), 2200000.0000)
INSERT [dbo].[Receipts] ([ReceiptID], [SupplierID], [ReceiptDate], [TotalAmount]) VALUES (24, 22, CAST(N'2019-11-22T13:27:25.097' AS DateTime), 166000000.0000)
SET IDENTITY_INSERT [dbo].[Receipts] OFF
SET IDENTITY_INSERT [dbo].[Roles] ON 

INSERT [dbo].[Roles] ([RoleID], [RoleName]) VALUES (1, N'Quản lý')
INSERT [dbo].[Roles] ([RoleID], [RoleName]) VALUES (2, N'Nhân Viên')
INSERT [dbo].[Roles] ([RoleID], [RoleName]) VALUES (3, N'Khách Hàng')
SET IDENTITY_INSERT [dbo].[Roles] OFF
SET IDENTITY_INSERT [dbo].[Suppliers] ON 

INSERT [dbo].[Suppliers] ([SupplierID], [CompanyName], [ContactName], [Address], [Phone], [Email]) VALUES (21, N'Bkav', N'Nguyễn Tử Quảng', N'Hà Nội', N'0147852369', N'bkav@gmail.com')
INSERT [dbo].[Suppliers] ([SupplierID], [CompanyName], [ContactName], [Address], [Phone], [Email]) VALUES (22, N'Thế giới di động', N'Trần Kinh Doanh', N'TP HCM', N'0123456789', N'tgdd@gmail.com')
INSERT [dbo].[Suppliers] ([SupplierID], [CompanyName], [ContactName], [Address], [Phone], [Email]) VALUES (23, N'Surface Viet', N'Nguyễn Bá Đạo', N'Hải Phòng', N'0369852147', N'surfaceviet@gmail.com')
INSERT [dbo].[Suppliers] ([SupplierID], [CompanyName], [ContactName], [Address], [Phone], [Email]) VALUES (24, N'Apple', N'Tim Cook', N'Hoa Kỳ', N'0852963441', N'apple@gmail.com')
INSERT [dbo].[Suppliers] ([SupplierID], [CompanyName], [ContactName], [Address], [Phone], [Email]) VALUES (25, N'Microsoft', N'Satya Nadella', N'Hoa Kỳ', N'0963852741', N'microsoft@gmail.com')
INSERT [dbo].[Suppliers] ([SupplierID], [CompanyName], [ContactName], [Address], [Phone], [Email]) VALUES (27, N'Hachinet', N'Nguyễn Thanh Tuấn', N'Vinh', N'026984713', N'hachinet@gmail.com')
INSERT [dbo].[Suppliers] ([SupplierID], [CompanyName], [ContactName], [Address], [Phone], [Email]) VALUES (28, N'Hà Nội Computer', N'Xuân Hạ', N'Hà Nội', N'0147896325', N'hanoicomputer@gmail.com')
INSERT [dbo].[Suppliers] ([SupplierID], [CompanyName], [ContactName], [Address], [Phone], [Email]) VALUES (29, N'SAMSUNG', N'Kim Mon Tea', N'Korea', N'08888123', N'samsung@gmail.com')
INSERT [dbo].[Suppliers] ([SupplierID], [CompanyName], [ContactName], [Address], [Phone], [Email]) VALUES (30, N'SONY', N'Kana Boon', N'Japan', N'07777456', N'sony@gmail.com')
INSERT [dbo].[Suppliers] ([SupplierID], [CompanyName], [ContactName], [Address], [Phone], [Email]) VALUES (32, N'XTStore', N'Thái Xuân Hiền', N'Vinh', N'09999568', N'xtstore@gmail.com')
SET IDENTITY_INSERT [dbo].[Suppliers] OFF
INSERT [dbo].[UserRoleRelationship] ([UserID], [RoleID]) VALUES (10, 1)
INSERT [dbo].[UserRoleRelationship] ([UserID], [RoleID]) VALUES (11, 2)
INSERT [dbo].[UserRoleRelationship] ([UserID], [RoleID]) VALUES (13, 3)
INSERT [dbo].[UserRoleRelationship] ([UserID], [RoleID]) VALUES (15, 3)
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([UserID], [FullName], [UserName], [Password], [Gender], [Email], [Phone], [Avatar]) VALUES (10, N'Thái Xuân Hiếu', N'admin', N'e10adc3949ba59abbe56e057f20f883e', N'Nam', N'likeafternoonqp@gmail.com', N'0987145299', N'D:\Images\Avatar\thaixuanhieu.png')
INSERT [dbo].[Users] ([UserID], [FullName], [UserName], [Password], [Gender], [Email], [Phone], [Avatar]) VALUES (11, N'Hà An', N'Annameow', N'e10adc3949ba59abbe56e057f20f883e', N'Nữ', N'anpon@gmail.com', N'0147852369', N'D:\Images\Avatar\haan0.png')
INSERT [dbo].[Users] ([UserID], [FullName], [UserName], [Password], [Gender], [Email], [Phone], [Avatar]) VALUES (13, N'Thái Xuân Hiền', N'thaixuanhien', N'd1869bbf422721e03b5f75113fd18b59', N'Nam', N'xtit6789@gmail.com', N'0971359939', N'D:\Images\Avatar\thaixuanhien.png')
INSERT [dbo].[Users] ([UserID], [FullName], [UserName], [Password], [Gender], [Email], [Phone], [Avatar]) VALUES (15, N'Ngô Văn Danh', N'ngovandanh', N'25f9e794323b453885f5181f1b624d0b', N'Nam', N'ngovandanh@gmail.com', N'0987654321', N'D:\Images\Avatar\ngovandanh.jpg')
SET IDENTITY_INSERT [dbo].[Users] OFF
INSERT [dbo].[Warehouse] ([ProductID], [Stock]) VALUES (44, 17)
INSERT [dbo].[Warehouse] ([ProductID], [Stock]) VALUES (45, 5)
INSERT [dbo].[Warehouse] ([ProductID], [Stock]) VALUES (46, 7)
INSERT [dbo].[Warehouse] ([ProductID], [Stock]) VALUES (47, 23)
INSERT [dbo].[Warehouse] ([ProductID], [Stock]) VALUES (49, 0)
INSERT [dbo].[Warehouse] ([ProductID], [Stock]) VALUES (50, 6)
INSERT [dbo].[Warehouse] ([ProductID], [Stock]) VALUES (51, 10)
INSERT [dbo].[Warehouse] ([ProductID], [Stock]) VALUES (52, 14)
INSERT [dbo].[Warehouse] ([ProductID], [Stock]) VALUES (53, 7)
INSERT [dbo].[Warehouse] ([ProductID], [Stock]) VALUES (54, 7)
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Orders] FOREIGN KEY([OrderID])
REFERENCES [dbo].[Orders] ([OrderID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Orders]
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Products] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Products] ([ProductID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Products]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Customers] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customers] ([CustomerID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Customers]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Categories] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Categories] ([CategoryID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Categories]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Suppliers] FOREIGN KEY([SupplierID])
REFERENCES [dbo].[Suppliers] ([SupplierID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Suppliers]
GO
ALTER TABLE [dbo].[ReceiptDetails]  WITH CHECK ADD  CONSTRAINT [FK_ReceiptDetails_Products] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Products] ([ProductID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ReceiptDetails] CHECK CONSTRAINT [FK_ReceiptDetails_Products]
GO
ALTER TABLE [dbo].[ReceiptDetails]  WITH CHECK ADD  CONSTRAINT [FK_ReceiptDetails_Receipts] FOREIGN KEY([ReceiptID])
REFERENCES [dbo].[Receipts] ([ReceiptID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ReceiptDetails] CHECK CONSTRAINT [FK_ReceiptDetails_Receipts]
GO
ALTER TABLE [dbo].[UserRoleRelationship]  WITH CHECK ADD  CONSTRAINT [FK_UserRoleRelationship_Role] FOREIGN KEY([RoleID])
REFERENCES [dbo].[Roles] ([RoleID])
GO
ALTER TABLE [dbo].[UserRoleRelationship] CHECK CONSTRAINT [FK_UserRoleRelationship_Role]
GO
ALTER TABLE [dbo].[UserRoleRelationship]  WITH CHECK ADD  CONSTRAINT [FK_UserRoleRelationship_Users] FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[UserRoleRelationship] CHECK CONSTRAINT [FK_UserRoleRelationship_Users]
GO
ALTER TABLE [dbo].[Warehouse]  WITH CHECK ADD  CONSTRAINT [FK_Warehouse_Products] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Products] ([ProductID])
GO
ALTER TABLE [dbo].[Warehouse] CHECK CONSTRAINT [FK_Warehouse_Products]
GO
