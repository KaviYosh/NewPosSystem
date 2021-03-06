USE [master]
GO
/****** Object:  Database [POSdb]    Script Date: 6/6/2021 2:30:04 PM ******/
CREATE DATABASE [POSdb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'POSdb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\POSdb.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'POSdb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\POSdb_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [POSdb] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [POSdb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [POSdb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [POSdb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [POSdb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [POSdb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [POSdb] SET ARITHABORT OFF 
GO
ALTER DATABASE [POSdb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [POSdb] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [POSdb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [POSdb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [POSdb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [POSdb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [POSdb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [POSdb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [POSdb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [POSdb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [POSdb] SET  DISABLE_BROKER 
GO
ALTER DATABASE [POSdb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [POSdb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [POSdb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [POSdb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [POSdb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [POSdb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [POSdb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [POSdb] SET RECOVERY FULL 
GO
ALTER DATABASE [POSdb] SET  MULTI_USER 
GO
ALTER DATABASE [POSdb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [POSdb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [POSdb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [POSdb] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'POSdb', N'ON'
GO
USE [POSdb]
GO
/****** Object:  Table [dbo].[CustomerDetails]    Script Date: 6/6/2021 2:30:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CustomerDetails](
	[CustomerID] [int] IDENTITY(1,70) NOT NULL,
	[FirstName] [varchar](250) NULL,
	[LastName] [varchar](250) NULL,
	[NIC] [varchar](50) NULL,
	[AddressLine_1] [varchar](max) NULL,
	[AddressLine_2] [varchar](max) NULL,
	[TeleNo] [varchar](15) NULL,
	[CreatedBy] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[CreateMachine] [varchar](50) NULL,
	[ModifyBy] [int] NULL,
	[ModifyDate] [datetime] NULL,
	[Active] [smallint] NULL,
 CONSTRAINT [PK_CustomerDetails] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DiscountPay]    Script Date: 6/6/2021 2:30:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DiscountPay](
	[DisID] [int] IDENTITY(1,50) NOT NULL,
	[DisRate] [int] NULL,
	[Amount] [decimal](18, 0) NULL,
	[CreatedBy] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[CreateMachine] [varchar](50) NULL,
	[ModifyBy] [int] NULL,
	[ModifyDate] [datetime] NULL,
	[Active] [smallint] NULL,
 CONSTRAINT [PK_DiscountPay] PRIMARY KEY CLUSTERED 
(
	[DisID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Items]    Script Date: 6/6/2021 2:30:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Items](
	[ItemID] [int] NOT NULL,
	[ItemName] [varchar](max) NULL,
	[PurchasedPrice] [decimal](18, 0) NULL,
	[SalesPrice] [decimal](18, 0) NULL,
	[Discount] [int] NULL,
	[DOQ] [date] NULL,
	[SupCatID] [int] NULL,
	[MainCatID] [int] NULL,
	[DateFrom] [date] NULL,
	[DateTo] [date] NULL,
	[CreatedBy] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[CreateMachine] [varchar](50) NULL,
	[ModifyBy] [int] NULL,
	[ModifyDate] [datetime] NULL,
	[Active] [smallint] NULL,
 CONSTRAINT [PK_Items] PRIMARY KEY CLUSTERED 
(
	[ItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Location]    Script Date: 6/6/2021 2:30:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Location](
	[LocationID] [int] IDENTITY(1,70) NOT NULL,
	[LocationName] [varchar](150) NULL,
	[AddressLine1] [varchar](150) NULL,
	[AddressLine2] [varchar](150) NULL,
	[AddressLine3] [varchar](150) NULL,
	[AddressLine4] [varchar](150) NULL,
	[CreatedBy] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[CreateMachine] [varchar](50) NULL,
	[ModifyBy] [int] NULL,
	[ModifyDate] [datetime] NULL,
	[Active] [smallint] NULL,
 CONSTRAINT [PK_Location] PRIMARY KEY CLUSTERED 
(
	[LocationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LoyalityCustomer]    Script Date: 6/6/2021 2:30:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LoyalityCustomer](
	[LCusID] [int] IDENTITY(1,20) NOT NULL,
	[CusID] [int] NULL,
	[MobileNo] [varchar](15) NULL,
	[CardNo] [varchar](200) NULL,
	[CreatedBy] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[CreateMachine] [varchar](50) NULL,
	[ModifyBy] [int] NULL,
	[ModifyDate] [datetime] NULL,
	[Active] [smallint] NULL,
 CONSTRAINT [PK_LoyalityCustomer] PRIMARY KEY CLUSTERED 
(
	[LCusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MainCategory]    Script Date: 6/6/2021 2:30:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MainCategory](
	[MainCatID] [varchar](100) NOT NULL,
	[CatName] [varchar](max) NULL,
	[CreatedBy] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[CreateMachine] [varchar](50) NULL,
	[ModifyBy] [int] NULL,
	[ModifyDate] [datetime] NULL,
	[Active] [smallint] NULL,
 CONSTRAINT [PK_MainCategory] PRIMARY KEY CLUSTERED 
(
	[MainCatID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SalesReturn]    Script Date: 6/6/2021 2:30:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SalesReturn](
	[SalesRetID] [int] NOT NULL,
	[StockOutID] [int] NULL,
	[Qty] [int] NULL,
	[ReturnInvoiceNo] [varchar](250) NULL,
	[CreatedBy] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[CreateMachine] [varchar](50) NULL,
	[ModifyBy] [int] NULL,
	[ModifyDate] [datetime] NULL,
	[Active] [smallint] IDENTITY(1,30) NOT NULL,
 CONSTRAINT [PK_SalesReturn] PRIMARY KEY CLUSTERED 
(
	[SalesRetID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ShopName]    Script Date: 6/6/2021 2:30:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ShopName](
	[ShopID] [int] IDENTITY(1,30) NOT NULL,
	[ShopFIrstName] [varchar](250) NULL,
	[ShopSecondName] [varchar](250) NULL,
	[ShopLastName] [varchar](250) NULL,
	[CreatedBy] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[CreateMachine] [varchar](50) NULL,
	[ModifyBy] [int] NULL,
	[ModifyDate] [datetime] NULL,
	[Active] [smallint] NULL,
 CONSTRAINT [PK_ShopName] PRIMARY KEY CLUSTERED 
(
	[ShopID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[StockIn]    Script Date: 6/6/2021 2:30:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[StockIn](
	[StockInID] [int] IDENTITY(1,80) NOT NULL,
	[ItemID] [varchar](150) NULL,
	[StockInDate] [date] NULL,
	[SubID] [int] NULL,
	[GRNNo] [varchar](250) NULL,
	[CreatedBy] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[CreateMachine] [varchar](50) NULL,
	[ModifyBy] [int] NULL,
	[ModifyDate] [datetime] NULL,
	[Active] [smallint] NULL,
 CONSTRAINT [PK_StockIn] PRIMARY KEY CLUSTERED 
(
	[StockInID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[StockOut]    Script Date: 6/6/2021 2:30:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[StockOut](
	[StockOutID] [int] IDENTITY(1,90) NOT NULL,
	[InvoiceNo] [varchar](250) NULL,
	[CustomerID] [int] NULL,
	[Qty] [int] NULL,
	[TransactionID] [int] NULL,
	[DiscountID] [int] NULL,
	[StockInID] [int] NULL,
	[StockOutDate] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[CreateMachine] [varchar](50) NULL,
	[ModifyBy] [int] NULL,
	[ModifyDate] [datetime] NULL,
	[Active] [smallint] NULL,
 CONSTRAINT [PK_StockOut] PRIMARY KEY CLUSTERED 
(
	[StockOutID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[StockReturns]    Script Date: 6/6/2021 2:30:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[StockReturns](
	[StockReturnID] [int] IDENTITY(1,80) NOT NULL,
	[StockID] [nchar](10) NULL,
	[ReturnQty] [int] NULL,
	[ReturnReason] [varchar](max) NULL,
	[CreatedBy] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[CreateMachine] [varchar](50) NULL,
	[ModifyBy] [int] NULL,
	[ModifyDate] [datetime] NULL,
	[Active] [smallint] NULL,
 CONSTRAINT [PK_StockReturns] PRIMARY KEY CLUSTERED 
(
	[StockReturnID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SubCategory]    Script Date: 6/6/2021 2:30:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SubCategory](
	[SubCatID] [int] IDENTITY(1,60) NOT NULL,
	[SubName] [varchar](max) NULL,
	[MainCatID] [varchar](250) NULL,
	[CreatedBy] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[CreateMachine] [varchar](50) NULL,
	[ModifyBy] [int] NULL,
	[ModifyDate] [datetime] NULL,
	[Active] [int] NULL,
 CONSTRAINT [PK_SubCategory] PRIMARY KEY CLUSTERED 
(
	[SubCatID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Supplier]    Script Date: 6/6/2021 2:30:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Supplier](
	[SupID] [int] IDENTITY(1,1) NOT NULL,
	[SupName] [varchar](max) NULL,
	[SupAddressLine1] [varchar](max) NULL,
	[SupAddressLine2] [varchar](max) NULL,
	[SupAddressLine3] [varchar](max) NULL,
	[TeleNoLand] [varchar](15) NULL,
	[MobileNo] [varchar](15) NULL,
	[FaxNo] [varchar](15) NULL,
	[CreatedBy] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[CreateMachine] [varchar](50) NULL,
	[ModifyBy] [int] NULL,
	[ModifyDate] [datetime] NULL,
	[Active] [smallint] NULL,
 CONSTRAINT [PK_Supplier] PRIMARY KEY CLUSTERED 
(
	[SupID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SupplierContactPersonInfo]    Script Date: 6/6/2021 2:30:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SupplierContactPersonInfo](
	[SPID] [int] IDENTITY(10,1) NOT NULL,
	[SupID] [int] NULL,
	[PersonName] [varchar](200) NULL,
	[Designation] [varchar](200) NULL,
	[PersonOfficeNumber] [varchar](15) NULL,
	[PersonMobileNo] [varchar](15) NULL,
	[Remarks] [nchar](10) NULL,
	[CreatedBy] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[CreateMachine] [varchar](50) NULL,
	[ModifyBy] [int] NULL,
	[ModifyDate] [datetime] NULL,
	[Active] [smallint] NULL,
 CONSTRAINT [PK_SupplierContactPersonInfo] PRIMARY KEY CLUSTERED 
(
	[SPID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SupplierPayment]    Script Date: 6/6/2021 2:30:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SupplierPayment](
	[SupPayID] [int] IDENTITY(1,40) NOT NULL,
	[SupID] [int] NULL,
	[PaymentDate] [datetime] NULL,
	[Amount] [decimal](18, 0) NULL,
	[CreatedBy] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[CreateMachine] [varchar](50) NULL,
	[ModifyBy] [int] NULL,
	[ModifyDate] [datetime] NULL,
	[Active] [smallint] NULL,
 CONSTRAINT [PK_SupplierPayment] PRIMARY KEY CLUSTERED 
(
	[SupPayID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TransactionType]    Script Date: 6/6/2021 2:30:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TransactionType](
	[TransID] [int] IDENTITY(1,10) NOT NULL,
	[Type] [varchar](50) NULL,
	[CreatedBy] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[CreateMachine] [varchar](50) NULL,
	[ModifyBy] [int] NULL,
	[ModifyDate] [datetime] NULL,
	[Active] [smallint] NULL,
 CONSTRAINT [PK_TransactionType] PRIMARY KEY CLUSTERED 
(
	[TransID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UserDetails]    Script Date: 6/6/2021 2:30:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UserDetails](
	[UDID] [int] IDENTITY(40,1) NOT NULL,
	[FirstName] [varchar](110) NULL,
	[LastName] [varchar](110) NULL,
	[AddressLine1] [varchar](100) NULL,
	[AddressLine2] [varchar](100) NULL,
	[MobileNo1] [varchar](20) NULL,
	[MobileNo2] [varchar](20) NULL,
	[HomePhoneNo] [varchar](20) NULL,
	[NICNo] [varchar](30) NULL,
	[ServiceLocation] [varchar](100) NULL,
	[Gender] [int] NULL,
	[DateOfBirth] [date] NULL,
	[CreatedBy] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[CreateMachine] [varchar](50) NULL,
	[ModifyBy] [int] NULL,
	[ModifyDate] [datetime] NULL,
	[Active] [smallint] NOT NULL,
 CONSTRAINT [PK_UserDetails] PRIMARY KEY CLUSTERED 
(
	[UDID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UserLoginInfo]    Script Date: 6/6/2021 2:30:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UserLoginInfo](
	[ULIID] [int] IDENTITY(30,1) NOT NULL,
	[UDID] [int] NULL,
	[URID] [int] NULL,
	[UserName] [varchar](100) NOT NULL,
	[Password] [text] NOT NULL,
	[CreatedBy] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[CreateMachine] [varchar](50) NULL,
	[ModifyBy] [int] NULL,
	[ModifyDate] [datetime] NULL,
	[Active] [smallint] NOT NULL,
 CONSTRAINT [PK_UserLoginInfo] PRIMARY KEY CLUSTERED 
(
	[ULIID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UserRole]    Script Date: 6/6/2021 2:30:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UserRole](
	[URID] [int] IDENTITY(20,1) NOT NULL,
	[RoleName] [varchar](100) NULL,
	[RoleType] [varchar](100) NULL,
	[CreatedBy] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[CreateMachine] [varchar](50) NULL,
	[ModifyBy] [int] NULL,
	[ModifyDate] [datetime] NULL,
	[Active] [smallint] NOT NULL,
 CONSTRAINT [PK_UserRole] PRIMARY KEY CLUSTERED 
(
	[URID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
USE [master]
GO
ALTER DATABASE [POSdb] SET  READ_WRITE 
GO
