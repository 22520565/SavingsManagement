USE [master]
GO
/****** Object:  Database [SavingsManagement]    Script Date: 29/04/24 20:56:50 ******/
CREATE DATABASE [SavingsManagement]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SavingsManagement', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\SavingsManagement.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SavingsManagement_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\SavingsManagement_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [SavingsManagement] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SavingsManagement].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SavingsManagement] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SavingsManagement] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SavingsManagement] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SavingsManagement] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SavingsManagement] SET ARITHABORT OFF 
GO
ALTER DATABASE [SavingsManagement] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SavingsManagement] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SavingsManagement] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SavingsManagement] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SavingsManagement] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SavingsManagement] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SavingsManagement] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SavingsManagement] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SavingsManagement] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SavingsManagement] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SavingsManagement] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SavingsManagement] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SavingsManagement] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SavingsManagement] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SavingsManagement] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SavingsManagement] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SavingsManagement] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SavingsManagement] SET RECOVERY FULL 
GO
ALTER DATABASE [SavingsManagement] SET  MULTI_USER 
GO
ALTER DATABASE [SavingsManagement] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SavingsManagement] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SavingsManagement] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SavingsManagement] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SavingsManagement] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SavingsManagement] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'SavingsManagement', N'ON'
GO
ALTER DATABASE [SavingsManagement] SET QUERY_STORE = ON
GO
ALTER DATABASE [SavingsManagement] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [SavingsManagement]
GO
/****** Object:  Table [dbo].[CashFlows]    Script Date: 29/04/24 20:56:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CashFlows](
	[Id] [int] IDENTITY(0,1) NOT NULL,
	[Time] [datetimeoffset](7) NOT NULL,
	[CustomerId] [int] NOT NULL,
	[CustomerName] [nvarchar](300),
	[BalanceChanging] [money] NOT NULL,
	[Content] [nvarchar](300) NOT NULL,
 CONSTRAINT [PK_CashFlows] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CustomerAccounts]    Script Date: 29/04/24 20:56:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CustomerAccounts](
	[Id] [int] IDENTITY(0,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[IsMale] [bit] NOT NULL,
	[CicNumber] [varchar](20) NOT NULL,
	[BirthDate] [date] NOT NULL,
	[PhoneNumber] [varchar](20) NOT NULL,
	[Address] [nvarchar](50) NOT NULL,
	[Email] [varchar](50) NULL,
	[Username] [varchar](50) NOT NULL,
	[HashedPassword] [nvarchar](MAX) NOT NULL,
	[Balance] [money] NOT NULL,
	[IsDisabled] [bit] NOT NULL,
 CONSTRAINT [PK_CustomerAccounts] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SavingInterestRates]    Script Date: 29/04/24 20:56:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SavingInterestRates](
	[PeriodInMonths] [tinyint] NOT NULL,
	[AnnualInterestRate] [decimal](10, 8) NOT NULL,
 CONSTRAINT [PK_AnnualInterestRates] PRIMARY KEY CLUSTERED 
(
	[PeriodInMonths] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Savings]    Script Date: 29/04/24 20:56:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Savings](
	[Id] [int] IDENTITY(0,1) NOT NULL,
	[CustomerId] [int] NOT NULL,
	[Balance] [money] NOT NULL,
	[AnnualInterestRate] [decimal](10, 8) NOT NULL,
	[PeriodInMonths] [int] NOT NULL,
	[OpeningDateTime] [datetimeoffset](7) NOT NULL,
 CONSTRAINT [PK_Savings] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StaffAccounts]    Script Date: 29/04/24 20:56:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StaffAccounts](
	[Id] [int] IDENTITY(0,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[IsMale] [bit] NOT NULL,
	[BirthDate] [date] NOT NULL,
	[PhoneNumber] [varchar](20) NOT NULL,
	[Address] [nvarchar](50) NOT NULL,
	[Email] [varchar](50) NULL,
	[Position] [nvarchar](50) NOT NULL,
	[Username] [varchar](50) NOT NULL,
	[HashedPassword] [nvarchar](MAX) NOT NULL,
	[PermissionId] [int] NOT NULL,
	[IsDisabled] [bit] NOT NULL,
 CONSTRAINT [PK_StaffAccounts] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StaffPermissions]    Script Date: 29/04/24 20:56:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StaffPermissions](
	[Id] [int] NOT NULL,
	[Name] [varchar](20) NOT NULL,
 CONSTRAINT [PK_Permissions] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Configurations]    Script Date: 08/06/24 17:32:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Configurations](
	[ID] [tinyint] NOT NULL,
	[MaxAmountOpeningSaving] [money] NOT NULL,
	[MinAmountOpeningSaving] [money] NOT NULL,
	[MaxAmountDepositing] [money] NOT NULL,
	[MinAmountDepositing] [money] NOT NULL,
	[MaxAmountWithdrawing] [money] NOT NULL,
	[MinAmountWithdrawing] [money] NOT NULL,
 CONSTRAINT [PK_Configurations] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Configurations] ([ID], [MaxAmountOpeningSaving], [MinAmountOpeningSaving], [MaxAmountDepositing], [MinAmountDepositing], [MaxAmountWithdrawing], [MinAmountWithdrawing]) VALUES (0, 200000.0000, 50.0000, 200000.0000, 50.0000, 200000.0000, 50.0000)
GO
ALTER TABLE [dbo].[Configurations] ADD  CONSTRAINT [DF_Configuration_ID]  DEFAULT ((0)) FOR [ID]
GO
ALTER TABLE [dbo].[Configurations]  WITH CHECK ADD  CONSTRAINT [CK_Configurations_MaxAmountDepositing] CHECK  (([MaxAmountDepositing]>=(0)))
GO
ALTER TABLE [dbo].[Configurations] CHECK CONSTRAINT [CK_Configurations_MaxAmountDepositing]
GO
ALTER TABLE [dbo].[Configurations]  WITH CHECK ADD  CONSTRAINT [CK_Configurations_MaxAmountOpeningSaving] CHECK  (([MaxAmountOpeningSaving]>=(0)))
GO
ALTER TABLE [dbo].[Configurations] CHECK CONSTRAINT [CK_Configurations_MaxAmountOpeningSaving]
GO
ALTER TABLE [dbo].[Configurations]  WITH CHECK ADD  CONSTRAINT [CK_Configurations_MaxAmountWithdrawing] CHECK  (([MaxAmountWithdrawing]>=(0)))
GO
ALTER TABLE [dbo].[Configurations] CHECK CONSTRAINT [CK_Configurations_MaxAmountWithdrawing]
GO
ALTER TABLE [dbo].[Configurations]  WITH CHECK ADD  CONSTRAINT [CK_Configurations_MinAmountDepositing] CHECK  (([MinAmountDepositing]>=(0)))
GO
ALTER TABLE [dbo].[Configurations] CHECK CONSTRAINT [CK_Configurations_MinAmountDepositing]
GO
ALTER TABLE [dbo].[Configurations]  WITH CHECK ADD  CONSTRAINT [CK_Configurations_MinAmountOpeningSaving] CHECK  (([MinAmountOpeningSaving]>=(0)))
GO
ALTER TABLE [dbo].[Configurations] CHECK CONSTRAINT [CK_Configurations_MinAmountOpeningSaving]
GO
ALTER TABLE [dbo].[Configurations]  WITH CHECK ADD  CONSTRAINT [CK_Configurations_MinAmountWithdrawing] CHECK  (([MinAmountWithdrawing]>=(0)))
GO
ALTER TABLE [dbo].[Configurations] CHECK CONSTRAINT [CK_Configurations_MinAmountWithdrawing]
GO
ALTER TABLE [dbo].[Configurations]  WITH CHECK ADD  CONSTRAINT [CK_Configurations_MinMaxAmountDepositing] CHECK  (([MaxAmountDepositing]>=[MinAmountDepositing]))
GO
ALTER TABLE [dbo].[Configurations] CHECK CONSTRAINT [CK_Configurations_MinMaxAmountDepositing]
GO
ALTER TABLE [dbo].[Configurations]  WITH CHECK ADD  CONSTRAINT [CK_Configurations_MinMaxAmountOpeningSaving] CHECK  (([MaxAmountOpeningSaving]>=[MinAmountOpeningSaving]))
GO
ALTER TABLE [dbo].[Configurations] CHECK CONSTRAINT [CK_Configurations_MinMaxAmountOpeningSaving]
GO
ALTER TABLE [dbo].[Configurations]  WITH CHECK ADD  CONSTRAINT [CK_Configurations_MinMaxAmountWithdrawing] CHECK  (([MaxAmountWithdrawing]>=[MinAmountWithdrawing]))
GO
ALTER TABLE [dbo].[Configurations] CHECK CONSTRAINT [CK_Configurations_MinMaxAmountWithdrawing]
GO
ALTER TABLE [dbo].[Configurations]  WITH CHECK ADD  CONSTRAINT [CK_Configurations_OnlyOneRow] CHECK  (([ID]=(0)))
GO
ALTER TABLE [dbo].[Configurations] CHECK CONSTRAINT [CK_Configurations_OnlyOneRow]
GO
SET IDENTITY_INSERT [dbo].[CashFlows] ON 
GO
INSERT [dbo].[CashFlows] ([Id], [Time], [CustomerId], [BalanceChanging], [Content]) VALUES (2, CAST(N'2024-04-18T20:39:33.8246013+07:00' AS DateTimeOffset), 10, -2.0000, N'Deposit to saving ID: 26, periods: 3 months, annual interest rate: 0.020%/year')
GO
INSERT [dbo].[CashFlows] ([Id], [Time], [CustomerId], [BalanceChanging], [Content]) VALUES (3, CAST(N'2024-04-18T20:53:00.0135643+07:00' AS DateTimeOffset), 10, -2.0000, N'Deposit to saving ID: 27, periods: 6 months, annual interest rate: 0.040%/year')
GO
INSERT [dbo].[CashFlows] ([Id], [Time], [CustomerId], [BalanceChanging], [Content]) VALUES (4, CAST(N'2024-04-18T20:59:35.4386952+07:00' AS DateTimeOffset), 10, -1.0000, N'Deposit to saving ID: 28, periods: 6 months, annual interest rate: 0.040%/year')
GO
INSERT [dbo].[CashFlows] ([Id], [Time], [CustomerId], [BalanceChanging], [Content]) VALUES (5, CAST(N'2024-04-18T21:10:30.7534134+07:00' AS DateTimeOffset), 10, 0.0000, N'Deposit saving: 29, periods: 12 months, annual interest rate: 5.000%/year')
GO
INSERT [dbo].[CashFlows] ([Id], [Time], [CustomerId], [BalanceChanging], [Content]) VALUES (6, CAST(N'2024-04-18T21:14:05.8025713+07:00' AS DateTimeOffset), 10, -1.0000, N'Deposit saving: 30, periods: 6 months, annual interest rate: 4.000%/year')
GO
INSERT [dbo].[CashFlows] ([Id], [Time], [CustomerId], [BalanceChanging], [Content]) VALUES (7, CAST(N'2024-04-19T10:08:25.1848135+07:00' AS DateTimeOffset), 10, 0.0000, N'Deposit saving: 31, periods: 3 months, annual interest rate: 3.000%/year')
GO
INSERT [dbo].[CashFlows] ([Id], [Time], [CustomerId], [BalanceChanging], [Content]) VALUES (9, CAST(N'2024-04-19T10:46:41.0133723+07:00' AS DateTimeOffset), 10, 0.5000, N'Salary')
GO
INSERT [dbo].[CashFlows] ([Id], [Time], [CustomerId], [BalanceChanging], [Content]) VALUES (16, CAST(N'2024-04-19T11:02:11.1717412+07:00' AS DateTimeOffset), 10, -1.0000, N'Deposit saving: 39, periods: 3 months, annual interest rate: 3.000%/year')
GO
INSERT [dbo].[CashFlows] ([Id], [Time], [CustomerId], [BalanceChanging], [Content]) VALUES (17, CAST(N'2024-04-19T11:07:48.9377733+07:00' AS DateTimeOffset), 10, -1.0000, N'Deposit saving: 40, periods: 3 months, annual interest rate: 3.000%/year')
GO
INSERT [dbo].[CashFlows] ([Id], [Time], [CustomerId], [BalanceChanging], [Content]) VALUES (18, CAST(N'2024-04-19T11:11:01.5937430+07:00' AS DateTimeOffset), 10, 5.0000, N'Salary')
GO
INSERT [dbo].[CashFlows] ([Id], [Time], [CustomerId], [BalanceChanging], [Content]) VALUES (19, CAST(N'2024-04-19T11:11:41.5764570+07:00' AS DateTimeOffset), 10, -0.5000, N'Penalty')
GO
INSERT [dbo].[CashFlows] ([Id], [Time], [CustomerId], [BalanceChanging], [Content]) VALUES (20, CAST(N'2024-04-19T11:13:05.8222746+07:00' AS DateTimeOffset), 10, -1.0000, N'Deposit saving: 41, periods: 3 months, annual interest rate: 3.000%/year')
GO
INSERT [dbo].[CashFlows] ([Id], [Time], [CustomerId], [BalanceChanging], [Content]) VALUES (21, CAST(N'2024-04-19T11:13:14.9156983+07:00' AS DateTimeOffset), 10, -2.0000, N'Deposit saving: 42, periods: 3 months, annual interest rate: 3.000%/year')
GO
INSERT [dbo].[CashFlows] ([Id], [Time], [CustomerId], [BalanceChanging], [Content]) VALUES (22, CAST(N'2024-04-19T11:14:05.8273357+07:00' AS DateTimeOffset), 10, 100.0000, N'Salary')
GO
INSERT [dbo].[CashFlows] ([Id], [Time], [CustomerId], [BalanceChanging], [Content]) VALUES (23, CAST(N'2024-04-19T11:14:18.8551613+07:00' AS DateTimeOffset), 10, -5.0000, N'Deposit saving: 43, periods: 3 months, annual interest rate: 3.000%/year')
GO
INSERT [dbo].[CashFlows] ([Id], [Time], [CustomerId], [BalanceChanging], [Content]) VALUES (24, CAST(N'2024-04-19T11:14:37.6190065+07:00' AS DateTimeOffset), 10, -1.0000, N'Deposit saving: 44, periods: 3 months, annual interest rate: 3.000%/year')
GO
INSERT [dbo].[CashFlows] ([Id], [Time], [CustomerId], [BalanceChanging], [Content]) VALUES (25, CAST(N'2024-04-19T11:15:21.2167079+07:00' AS DateTimeOffset), 10, -1.0000, N'Deposit saving: 45, periods: 3 months, annual interest rate: 3.000%/year')
GO
INSERT [dbo].[CashFlows] ([Id], [Time], [CustomerId], [BalanceChanging], [Content]) VALUES (26, CAST(N'2024-04-19T11:16:08.7875129+07:00' AS DateTimeOffset), 10, -1.0000, N'Deposit saving: 46 amount:1, periods: 3 months, annual interest rate: 3.000%/year')
GO
INSERT [dbo].[CashFlows] ([Id], [Time], [CustomerId], [BalanceChanging], [Content]) VALUES (27, CAST(N'2024-04-19T11:16:54.9668085+07:00' AS DateTimeOffset), 10, -0.5000, N'Deposit saving: 47, periods: 3 months, annual interest rate: 3.000%/year')
GO
INSERT [dbo].[CashFlows] ([Id], [Time], [CustomerId], [BalanceChanging], [Content]) VALUES (28, CAST(N'2024-04-19T11:21:13.9266357+07:00' AS DateTimeOffset), 10, -10.0000, N'Deposit saving: 48, periods: 3 months, annual interest rate: 3.000%/year')
GO
INSERT [dbo].[CashFlows] ([Id], [Time], [CustomerId], [BalanceChanging], [Content]) VALUES (29, CAST(N'2024-04-19T13:47:30.7158295+07:00' AS DateTimeOffset), 10, -4.0000, N'Deposit saving: 49, periods: 12 months, annual interest rate: 5.000%/year')
GO
INSERT [dbo].[CashFlows] ([Id], [Time], [CustomerId], [BalanceChanging], [Content]) VALUES (30, CAST(N'2024-04-19T15:50:58.9920950+07:00' AS DateTimeOffset), 10, -1.0000, N'Deposit saving: 50, periods: 6 months, annual interest rate: 4.000%/year')
GO
INSERT [dbo].[CashFlows] ([Id], [Time], [CustomerId], [BalanceChanging], [Content]) VALUES (31, CAST(N'2024-04-19T18:27:53.5868501+07:00' AS DateTimeOffset), 10, 0.5076, N'Withdraw saving: 45, periods: 3 months')
GO
INSERT [dbo].[CashFlows] ([Id], [Time], [CustomerId], [BalanceChanging], [Content]) VALUES (32, CAST(N'2024-04-19T18:29:07.2809593+07:00' AS DateTimeOffset), 10, 2.0556, N'Withdraw saving: 26, periods: 3 months')
GO
INSERT [dbo].[CashFlows] ([Id], [Time], [CustomerId], [BalanceChanging], [Content]) VALUES (33, CAST(N'2024-04-19T18:30:47.4206104+07:00' AS DateTimeOffset), 10, 0.0000, N'Withdraw saving: 31, periods: 3 months')
GO
INSERT [dbo].[CashFlows] ([Id], [Time], [CustomerId], [BalanceChanging], [Content]) VALUES (34, CAST(N'2024-04-19T18:31:21.1095013+07:00' AS DateTimeOffset), 10, 1.0404, N'Withdraw saving: 28, periods: 6 months')
GO
INSERT [dbo].[CashFlows] ([Id], [Time], [CustomerId], [BalanceChanging], [Content]) VALUES (35, CAST(N'2024-04-19T18:36:11.8278354+07:00' AS DateTimeOffset), 10, 2.0301, N'Withdraw saving: 42, periods: 3 months')
GO
INSERT [dbo].[CashFlows] ([Id], [Time], [CustomerId], [BalanceChanging], [Content]) VALUES (36, CAST(N'2024-04-19T18:36:54.8491661+07:00' AS DateTimeOffset), 10, 0.5076, N'Withdraw saving: 39, periods: 3 months')
GO
INSERT [dbo].[CashFlows] ([Id], [Time], [CustomerId], [BalanceChanging], [Content]) VALUES (37, CAST(N'2024-04-19T18:38:23.6203166+07:00' AS DateTimeOffset), 10, 0.5076, N'Withdraw saving: 41, periods: 3 months')
GO
INSERT [dbo].[CashFlows] ([Id], [Time], [CustomerId], [BalanceChanging], [Content]) VALUES (38, CAST(N'2024-04-19T18:43:38.2691660+07:00' AS DateTimeOffset), 10, 0.5076, N'Withdraw saving: 40, periods: 3 months')
GO
INSERT [dbo].[CashFlows] ([Id], [Time], [CustomerId], [BalanceChanging], [Content]) VALUES (39, CAST(N'2024-04-19T18:44:18.1897967+07:00' AS DateTimeOffset), 10, 1.0404, N'Withdraw saving: 30, periods: 6 months')
GO
INSERT [dbo].[CashFlows] ([Id], [Time], [CustomerId], [BalanceChanging], [Content]) VALUES (40, CAST(N'2024-04-20T19:03:20.7683143+07:00' AS DateTimeOffset), 10, 2.1224, N'Withdraw saving: 27, periods: 6 months')
GO
INSERT [dbo].[CashFlows] ([Id], [Time], [CustomerId], [BalanceChanging], [Content]) VALUES (41, CAST(N'2024-04-20T19:04:19.0094964+07:00' AS DateTimeOffset), 10, -88.8193, N'Deposit saving: 51, periods: 9 months, annual interest rate: 4.500%/year')
GO
INSERT [dbo].[CashFlows] ([Id], [Time], [CustomerId], [BalanceChanging], [Content]) VALUES (42, CAST(N'2024-04-20T19:36:10.8161623+07:00' AS DateTimeOffset), 10, 88.8193, N'Withdraw saving: 51, periods: 9 months')
GO
INSERT [dbo].[CashFlows] ([Id], [Time], [CustomerId], [BalanceChanging], [Content]) VALUES (43, CAST(N'2024-04-20T19:44:10.1049097+07:00' AS DateTimeOffset), 10, -7.0000, N'Deposit saving: 52, periods: 6 months, annual interest rate: 4.000%/year')
GO
INSERT [dbo].[CashFlows] ([Id], [Time], [CustomerId], [BalanceChanging], [Content]) VALUES (44, CAST(N'2024-04-20T20:00:08.1113187+07:00' AS DateTimeOffset), 10, -43.0000, N'Deposit saving: 53, periods: 9 months, annual interest rate: 4.500%/year')
GO
INSERT [dbo].[CashFlows] ([Id], [Time], [CustomerId], [BalanceChanging], [Content]) VALUES (45, CAST(N'2024-04-20T20:00:24.5031374+07:00' AS DateTimeOffset), 10, 0.5076, N'Withdraw saving: 46, periods: 3 months')
GO
INSERT [dbo].[CashFlows] ([Id], [Time], [CustomerId], [BalanceChanging], [Content]) VALUES (46, CAST(N'2024-04-20T20:04:01.2128962+07:00' AS DateTimeOffset), 10, 43.0000, N'Withdraw saving: 53, periods: 9 months')
GO
INSERT [dbo].[CashFlows] ([Id], [Time], [CustomerId], [BalanceChanging], [Content]) VALUES (47, CAST(N'2024-04-20T20:11:45.4072392+07:00' AS DateTimeOffset), 10, -21.4500, N'Deposit saving: 54, periods: 9 months, annual interest rate: 4.500%/year')
GO
INSERT [dbo].[CashFlows] ([Id], [Time], [CustomerId], [BalanceChanging], [Content]) VALUES (48, CAST(N'2024-04-20T20:12:07.8992982+07:00' AS DateTimeOffset), 10, 0.5076, N'Withdraw saving: 47, periods: 3 months')
GO
INSERT [dbo].[CashFlows] ([Id], [Time], [CustomerId], [BalanceChanging], [Content]) VALUES (49, CAST(N'2024-04-20T20:15:01.3246550+07:00' AS DateTimeOffset), 10, -11.5400, N'Deposit saving: 55, periods: 9 months, annual interest rate: 4.500%/year')
GO
INSERT [dbo].[CashFlows] ([Id], [Time], [CustomerId], [BalanceChanging], [Content]) VALUES (50, CAST(N'2024-04-20T20:15:27.4412934+07:00' AS DateTimeOffset), 10, 21.4500, N'Withdraw saving: 54, periods: 9 months')
GO
INSERT [dbo].[CashFlows] ([Id], [Time], [CustomerId], [BalanceChanging], [Content]) VALUES (51, CAST(N'2024-04-29T15:56:32.5249794+07:00' AS DateTimeOffset), 10, 10.2267, N'Closing saving: 48, period: 3 months')
GO
SET IDENTITY_INSERT [dbo].[CashFlows] OFF
GO
SET IDENTITY_INSERT [dbo].[CustomerAccounts] ON 
GO
INSERT [dbo].[CustomerAccounts] ([Id], [Name], [IsMale], [CicNumber], [BirthDate], [PhoneNumber], [Address], [Email], [Username], [HashedPassword], [Balance], [IsDisabled]) VALUES (1, N'Nguyễn Văn B', 1, N'045434658135', CAST(N'2024-11-04' AS Date), N'5404454665', N'Việt Nam', N'a', N'krsgvn10', N'jearjvnsjebvnservjnsdebnrekdibjmreksagvarebjersbrv                                  ', 0.0000, 0)
GO
INSERT [dbo].[CustomerAccounts] ([Id], [Name], [IsMale], [CicNumber], [BirthDate], [PhoneNumber], [Address], [Email], [Username], [HashedPassword], [Balance], [IsDisabled]) VALUES (8, N'Nguyễn Văn B', 1, N'045434658135', CAST(N'2024-11-04' AS Date), N'5404454665', N'Việt Nam', N'b', N'krsgvn17', N'jearjvnsjebvnservjnsdebnrekdibjmreksagvarebjersbrv                                  ', 0.0000, 0)
GO
INSERT [dbo].[CustomerAccounts] ([Id], [Name], [IsMale], [CicNumber], [BirthDate], [PhoneNumber], [Address], [Email], [Username], [HashedPassword], [Balance], [IsDisabled]) VALUES (10, N'Nguyễn Văn C', 1, N'3o94ot9', CAST(N'2024-04-17' AS Date), N'20395', N'Tiy', N'c', N'Test', N'AQAAAAIAAYagAAAAEHJxYRqg4BjiBmbDmOzAnboopsH+MGFxLSVSU7wc7ucW4msTPx8na2i6nsSUCr9cJA==', 81.5212, 0)
GO
SET IDENTITY_INSERT [dbo].[CustomerAccounts] OFF
GO
INSERT [dbo].[SavingInterestRates] ([PeriodInMonths], [AnnualInterestRate]) VALUES (0, CAST(0.00100000 AS Decimal(10, 8)))
GO
INSERT [dbo].[SavingInterestRates] ([PeriodInMonths], [AnnualInterestRate]) VALUES (1, CAST(0.02000000 AS Decimal(10, 8)))
GO
INSERT [dbo].[SavingInterestRates] ([PeriodInMonths], [AnnualInterestRate]) VALUES (3, CAST(0.03000000 AS Decimal(10, 8)))
GO
INSERT [dbo].[SavingInterestRates] ([PeriodInMonths], [AnnualInterestRate]) VALUES (6, CAST(0.04000000 AS Decimal(10, 8)))
GO
INSERT [dbo].[SavingInterestRates] ([PeriodInMonths], [AnnualInterestRate]) VALUES (9, CAST(0.04500000 AS Decimal(10, 8)))
GO
INSERT [dbo].[SavingInterestRates] ([PeriodInMonths], [AnnualInterestRate]) VALUES (12, CAST(0.05000000 AS Decimal(10, 8)))
GO
SET IDENTITY_INSERT [dbo].[Savings] ON 
GO
INSERT [dbo].[Savings] ([Id], [CustomerId], [Balance], [AnnualInterestRate], [PeriodInMonths], [OpeningDateTime]) VALUES (29, 10, 0.0551, CAST(0.05000000 AS Decimal(10, 8)), 12, CAST(N'2024-04-19T14:56:22.0773698+07:00' AS DateTimeOffset))
GO
INSERT [dbo].[Savings] ([Id], [CustomerId], [Balance], [AnnualInterestRate], [PeriodInMonths], [OpeningDateTime]) VALUES (43, 10, 5.0753, CAST(0.03000000 AS Decimal(10, 8)), 3, CAST(N'2024-04-19T14:56:22.0773698+07:00' AS DateTimeOffset))
GO
INSERT [dbo].[Savings] ([Id], [CustomerId], [Balance], [AnnualInterestRate], [PeriodInMonths], [OpeningDateTime]) VALUES (44, 10, 1.0151, CAST(0.03000000 AS Decimal(10, 8)), 3, CAST(N'2024-04-19T14:56:22.0773698+07:00' AS DateTimeOffset))
GO
INSERT [dbo].[Savings] ([Id], [CustomerId], [Balance], [AnnualInterestRate], [PeriodInMonths], [OpeningDateTime]) VALUES (49, 10, 4.8119, CAST(0.04500000 AS Decimal(10, 8)), 9, CAST(N'2024-04-29T15:24:51.9852091+07:00' AS DateTimeOffset))
GO
INSERT [dbo].[Savings] ([Id], [CustomerId], [Balance], [AnnualInterestRate], [PeriodInMonths], [OpeningDateTime]) VALUES (50, 10, 1.0200, CAST(0.04000000 AS Decimal(10, 8)), 6, CAST(N'2024-04-29T15:13:41.9838416+07:00' AS DateTimeOffset))
GO
INSERT [dbo].[Savings] ([Id], [CustomerId], [Balance], [AnnualInterestRate], [PeriodInMonths], [OpeningDateTime]) VALUES (52, 10, 7.0000, CAST(0.04000000 AS Decimal(10, 8)), 6, CAST(N'2024-04-20T19:44:10.1049097+07:00' AS DateTimeOffset))
GO
INSERT [dbo].[Savings] ([Id], [CustomerId], [Balance], [AnnualInterestRate], [PeriodInMonths], [OpeningDateTime]) VALUES (55, 10, 11.5400, CAST(0.04500000 AS Decimal(10, 8)), 9, CAST(N'2024-04-20T20:15:01.3246550+07:00' AS DateTimeOffset))
GO
SET IDENTITY_INSERT [dbo].[Savings] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ_Customer]    Script Date: 29/04/24 20:56:50 ******/
ALTER TABLE [dbo].[CustomerAccounts] ADD  CONSTRAINT [UQ_Customer] UNIQUE NONCLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ_Email]    Script Date: 29/04/24 20:56:50 ******/
ALTER TABLE [dbo].[CustomerAccounts] ADD  CONSTRAINT [UQ_Email] UNIQUE NONCLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__StaffAcc__F3DBC572752A95C1]    Script Date: 29/04/24 20:56:50 ******/
ALTER TABLE [dbo].[StaffAccounts] ADD  CONSTRAINT [UQ__StaffAcc__F3DBC572752A95C1] UNIQUE NONCLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CashFlows] ADD  CONSTRAINT [DF_CashFlows_Time]  DEFAULT (sysdatetimeoffset()) FOR [Time]
GO
ALTER TABLE [dbo].[CustomerAccounts] ADD  CONSTRAINT [DF_CUSTOMER_Male]  DEFAULT ((1)) FOR [IsMale]
GO
ALTER TABLE [dbo].[CustomerAccounts] ADD  CONSTRAINT [DF_CustomerAccounts_StatusId]  DEFAULT ((0)) FOR [IsDisabled]
GO
ALTER TABLE [dbo].[Savings] ADD  CONSTRAINT [DF_Savings_OpenDate]  DEFAULT (sysdatetimeoffset()) FOR [OpeningDateTime]
GO
ALTER TABLE [dbo].[CashFlows]  WITH CHECK ADD  CONSTRAINT [FK_CashFlows_CustomerAccounts] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[CustomerAccounts] ([Id])
GO
ALTER TABLE [dbo].[CashFlows] CHECK CONSTRAINT [FK_CashFlows_CustomerAccounts]
GO
ALTER TABLE [dbo].[Savings]  WITH CHECK ADD  CONSTRAINT [FK_Savings_CustomerAccounts] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[CustomerAccounts] ([Id])
GO
ALTER TABLE [dbo].[Savings] CHECK CONSTRAINT [FK_Savings_CustomerAccounts]
GO
ALTER TABLE [dbo].[StaffAccounts]  WITH CHECK ADD  CONSTRAINT [FK_StaffAccounts_StaffPermissions] FOREIGN KEY([PermissionId])
REFERENCES [dbo].[StaffPermissions] ([Id])
GO
ALTER TABLE [dbo].[StaffAccounts] CHECK CONSTRAINT [FK_StaffAccounts_StaffPermissions]
GO
ALTER TABLE [dbo].[SavingInterestRates]  WITH CHECK ADD  CONSTRAINT [CK_SavingInterestRates_PeriodInMonths] CHECK  (([PeriodInMonths]>=(0)))
GO
ALTER TABLE [dbo].[SavingInterestRates] CHECK CONSTRAINT [CK_SavingInterestRates_PeriodInMonths]
GO
/****** Object:  Trigger [dbo].[UpdateCustomerBalance]    Script Date: 29/04/24 20:56:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[UpdateCustomerBalance] ON [dbo].[CashFlows] AFTER INSERT AS
BEGIN
    SET NOCOUNT ON;
	DECLARE @customerId INT = 0;
	DECLARE @balanceChanging MONEY = 0.0;

	DECLARE insertedCursor CURSOR LOCAL READ_ONLY FOR SELECT [CustomerId], [BalanceChanging] FROM inserted;
	OPEN insertedCursor;
	
	BEGIN TRANSACTION;
	FETCH NEXT FROM insertedCursor INTO @customerId, @balanceChanging;
	WHILE @@FETCH_STATUS = 0
	BEGIN
		BEGIN TRY
			UPDATE [CustomerAccounts]
			SET [CustomerAccounts].[Balance] += @balanceChanging
			WHERE [CustomerAccounts].[Id] = @customerId;
		END TRY
		BEGIN CATCH
			IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION;
		END CATCH;
		FETCH NEXT FROM insertedCursor INTO @customerId, @balanceChanging;
	END;
	IF @@TRANCOUNT > 0 COMMIT TRANSACTION;

	BEGIN TRY
		CLOSE insertedCursor;
		DEALLOCATE insertedCursor;
	END TRY
	BEGIN CATCH
		-- Ignore Exception --
	END CATCH;
END;
GO
ALTER TABLE [dbo].[CashFlows] ENABLE TRIGGER [UpdateCustomerBalance]
GO
/****** Object:  Trigger [dbo].[CloseSavingInsertCashFlow]    Script Date: 29/04/24 20:56:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[CloseSavingInsertCashFlow] ON [dbo].[Savings] AFTER DELETE AS 
BEGIN
	SET NOCOUNT ON;
	DECLARE @savingId INT = 0;
	DECLARE @customerId INT = 0;
	DECLARE @amountToReceive MONEY = 0.0;
	DECLARE @annualInterestRate DECIMAL(10,8) = 0.0;
	DECLARE @periodInMonths INT = 0;
	DECLARE @openingDateTime DATETIMEOFFSET(7) = SYSDATETIMEOFFSET();
	DECLARE @currentDate DATE = CONVERT(DATE, SWITCHOFFSET(@openingDateTime, '+00:00'));

	DECLARE deletedTableCursor CURSOR LOCAL READ_ONLY FOR SELECT [Id], [CustomerId], [Balance], [AnnualInterestRate], [PeriodInMonths], [OpeningDateTime] FROM deleted;
	OPEN deletedTableCursor;
	
	BEGIN TRANSACTION;
	FETCH NEXT FROM deletedTableCursor INTO @savingId, @customerId, @amountToReceive, @annualInterestRate, @periodInMonths, @openingDateTime;
	WHILE @@FETCH_STATUS = 0
	BEGIN
		DECLARE @openingDate DATE = CONVERT(DATE, SWITCHOFFSET(@openingDateTime, '+00:00'));
		DECLARE @maturityDate DATE = CONVERT(DATE,SWITCHOFFSET(DATEADD(MONTH, @periodInMonths, @openingDate), '+00:00'));
		BEGIN TRY
			IF @maturityDate <= @currentDate
				SET @amountToReceive += @amountToReceive * @annualInterestRate * (@periodInMonths / 12.0);
			ELSE IF @currentDate > @openingDate
			BEGIN
				SELECT @annualInterestRate = [SavingInterestRates].[AnnualInterestRate] FROM [SavingInterestRates] WHERE [SavingInterestRates].[PeriodInMonths] = 0;
				SET @amountToReceive += @amountToReceive * @annualInterestRate * ((DATEDIFF(DAY, @openingDate, @currentDate) - 1) / 365.0);
			END

			INSERT INTO CashFlows([CustomerId], [BalanceChanging], [Content])
			VALUES(@customerId, @amountToReceive,
			CONCAT(N'Closing saving: ', @savingId, N', period: ', @periodInMonths, N' months'));
		END TRY
		BEGIN CATCH
			IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION;
		END CATCH;
		FETCH NEXT FROM deletedTableCursor INTO @savingId, @customerId, @amountToReceive, @annualInterestRate, @periodInMonths, @openingDateTime;
	END;
	IF @@TRANCOUNT > 0 COMMIT TRANSACTION;
	
	BEGIN TRY
		CLOSE deletedTableCursor;
		DEALLOCATE deletedTableCursor;
	END TRY
	BEGIN CATCH
		-- Ignore Exception --
	END CATCH;
END;
GO
ALTER TABLE [dbo].[Savings] ENABLE TRIGGER [CloseSavingInsertCashFlow]
GO
/****** Object:  Trigger [dbo].[OpenSavingInsertCashFlow]    Script Date: 29/04/24 20:56:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[OpenSavingInsertCashFlow] ON [dbo].[Savings] AFTER INSERT AS 
BEGIN
	SET NOCOUNT ON;
	DECLARE @savingId INT = 0;
	DECLARE @customerId INT = 0;
	DECLARE @amountDeposit MONEY = 0.0;
	DECLARE @annualInterestRate DECIMAL(10,8) = 0.0;
	DECLARE @periodInMonths INT = 0;

	DECLARE insertedTableCursor CURSOR LOCAL READ_ONLY FOR SELECT [Id], [CustomerId], [Balance], [AnnualInterestRate], [PeriodInMonths] FROM inserted;
	OPEN insertedTableCursor;
	
	BEGIN TRANSACTION;
	FETCH NEXT FROM insertedTableCursor INTO @savingId, @customerId, @amountDeposit, @annualInterestRate, @periodInMonths;
	WHILE @@FETCH_STATUS = 0
	BEGIN
		BEGIN TRY
			INSERT INTO CashFlows([CustomerId], [BalanceChanging], [Content])
				VALUES(@customerId, -@amountDeposit,
				CONCAT(N'Opening saving: ', @savingId, N', period: ', @periodInMonths, N' months, annual interest rate: ', @annualInterestRate * 100, N'%/year'));
		END TRY
		BEGIN CATCH
			IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION;
		END CATCH;
		FETCH NEXT FROM insertedTableCursor INTO @savingId, @customerId, @amountDeposit, @annualInterestRate, @periodInMonths;
	END;
	IF @@TRANCOUNT > 0 COMMIT TRANSACTION;

	BEGIN TRY
		CLOSE insertedTableCursor;
		DEALLOCATE insertedTableCursor;
	END TRY
	BEGIN CATCH
		-- Ignore Exception --
	END CATCH;
END;
GO
ALTER TABLE [dbo].[Savings] ENABLE TRIGGER [OpenSavingInsertCashFlow]
GO
USE [master]
GO
ALTER DATABASE [SavingsManagement] SET  READ_WRITE 
GO

USE [msdb]
GO

/****** Object:  Job [RefreshDaily]    Script Date: 11/06/24 08:50:29 ******/
BEGIN TRANSACTION
DECLARE @ReturnCode INT
SELECT @ReturnCode = 0
/****** Object:  JobCategory [[Uncategorized (Local)]]    Script Date: 11/06/24 08:50:29 ******/
IF NOT EXISTS (SELECT name FROM msdb.dbo.syscategories WHERE name=N'[Uncategorized (Local)]' AND category_class=1)
BEGIN
EXEC @ReturnCode = msdb.dbo.sp_add_category @class=N'JOB', @type=N'LOCAL', @name=N'[Uncategorized (Local)]'
IF (@@ERROR <> 0 OR @ReturnCode <> 0) GOTO QuitWithRollback

END

DECLARE @jobId BINARY(16)
EXEC @ReturnCode =  msdb.dbo.sp_add_job @job_name=N'RefreshDaily', 
		@enabled=1, 
		@notify_level_eventlog=0, 
		@notify_level_email=0, 
		@notify_level_netsend=0, 
		@notify_level_page=0, 
		@delete_level=0, 
		@description=N'Refesh daily. Backup database. Update savings'' balance, open day, and interest rate when it''s after their maturity day.', 
		@category_name=N'[Uncategorized (Local)]', 
		@owner_login_name=N'sa', @job_id = @jobId OUTPUT
IF (@@ERROR <> 0 OR @ReturnCode <> 0) GOTO QuitWithRollback
/****** Object:  Step [Backup]    Script Date: 11/06/24 08:50:29 ******/
EXEC @ReturnCode = msdb.dbo.sp_add_jobstep @job_id=@jobId, @step_name=N'Backup', 
		@step_id=1, 
		@cmdexec_success_code=0, 
		@on_success_action=3, 
		@on_success_step_id=0, 
		@on_fail_action=2, 
		@on_fail_step_id=0, 
		@retry_attempts=0, 
		@retry_interval=0, 
		@os_run_priority=0, @subsystem=N'TSQL', 
		@command=N'BACKUP DATABASE [SavingsManagement] TO  DISK = N''C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\Backup\SavingsManagement.bak'' WITH  RETAINDAYS = 14, NOFORMAT, NOINIT,  NAME = N''SavingsManagement-Full Database Backup'', SKIP, NOREWIND, NOUNLOAD,  STATS = 10
GO
', 
		@database_name=N'SavingsManagement', 
		@flags=0
IF (@@ERROR <> 0 OR @ReturnCode <> 0) GOTO QuitWithRollback
/****** Object:  Step [UpdateSavings]    Script Date: 11/06/24 08:50:29 ******/
EXEC @ReturnCode = msdb.dbo.sp_add_jobstep @job_id=@jobId, @step_name=N'UpdateSavings', 
		@step_id=2, 
		@cmdexec_success_code=0, 
		@on_success_action=1, 
		@on_success_step_id=0, 
		@on_fail_action=2, 
		@on_fail_step_id=0, 
		@retry_attempts=0, 
		@retry_interval=0, 
		@os_run_priority=0, @subsystem=N'TSQL', 
		@command=N'DECLARE @currentDateTime DATETIMEOFFSET(7) = SYSDATETIMEOFFSET();
DECLARE @currentDate DATE = CONVERT(DATE, SWITCHOFFSET(@currentDateTime, ''+00:00''));
DECLARE @balance MONEY = 0.0;
DECLARE @annualInterestRate DECIMAL(10,8) = 0.0;
DECLARE @periodInMonths INT = 0;
DECLARE @openingDateTime DATETIMEOFFSET(7) = @currentDateTime;

DECLARE tableCursor CURSOR LOCAL FOR SELECT [PeriodInMonths], [OpeningDateTime] FROM [Savings];
OPEN tableCursor;

BEGIN TRANSACTION;
FETCH NEXT FROM tableCursor INTO @periodInMonths, @openingDateTime;
WHILE @@FETCH_STATUS = 0
BEGIN
	DECLARE @openingDate DATE = CONVERT(DATE, SWITCHOFFSET(@openingDateTime, ''+00:00''));
	DECLARE @maturityDate DATE = CONVERT(DATE, SWITCHOFFSET(DATEADD(MONTH, @periodInMonths, @openingDate), ''+00:00''));
	IF @maturityDate <= @currentDate
	BEGIN TRY
		SELECT TOP(1) [SavingInterestRates].[PeriodInMonths], [SavingInterestRates].[AnnualInterestRate]
			INTO [#NewInterestRate]
			FROM [SavingInterestRates]
			WHERE [SavingInterestRates].[PeriodInMonths] <= @periodInMonths
			ORDER BY [SavingInterestRates].[PeriodInMonths] DESC
		IF (SELECT COUNT(*) FROM #newInterestRate) > 0
			UPDATE [Savings]
				SET [Savings].[Balance] += [Savings].[Balance] * [Savings].[AnnualInterestRate] * ([Savings].[PeriodInMonths] / 12.0),
					[Savings].[OpeningDateTime] = @currentDateTime,
					[Savings].[AnnualInterestRate] = (SELECT [#NewInterestRate].[AnnualInterestRate] FROM [#NewInterestRate]),
					[Savings].[PeriodInMonths] = (SELECT [#NewInterestRate].[PeriodInMonths] FROM [#NewInterestRate])
				WHERE CURRENT OF tableCursor;
		ELSE DELETE [Savings] WHERE CURRENT OF tableCursor;
		DROP TABLE [#NewInterestRate]
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION;
	END CATCH;
	FETCH NEXT FROM tableCursor INTO @periodInMonths, @openingDateTime;
END;
IF @@TRANCOUNT > 0 COMMIT TRANSACTION;

BEGIN TRY
	CLOSE tableCursor;
	DEALLOCATE tableCursor;
END TRY
BEGIN CATCH
	-- Ignore Exception --
END CATCH;

GO
', 
		@database_name=N'SavingsManagement', 
		@output_file_name=N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\Log\UpdateSavingsError.log', 
		@flags=6
IF (@@ERROR <> 0 OR @ReturnCode <> 0) GOTO QuitWithRollback
EXEC @ReturnCode = msdb.dbo.sp_update_job @job_id = @jobId, @start_step_id = 1
IF (@@ERROR <> 0 OR @ReturnCode <> 0) GOTO QuitWithRollback
EXEC @ReturnCode = msdb.dbo.sp_add_jobschedule @job_id=@jobId, @name=N'Daily', 
		@enabled=1, 
		@freq_type=4, 
		@freq_interval=1, 
		@freq_subday_type=1, 
		@freq_subday_interval=0, 
		@freq_relative_interval=0, 
		@freq_recurrence_factor=0, 
		@active_start_date=20240419, 
		@active_end_date=99991231, 
		@active_start_time=0, 
		@active_end_time=235959, 
		@schedule_uid=N'2cc84a3d-75ec-4d24-bc36-a15bb1843b8f'
IF (@@ERROR <> 0 OR @ReturnCode <> 0) GOTO QuitWithRollback
EXEC @ReturnCode = msdb.dbo.sp_add_jobserver @job_id = @jobId, @server_name = N'(local)'
IF (@@ERROR <> 0 OR @ReturnCode <> 0) GOTO QuitWithRollback
COMMIT TRANSACTION
GOTO EndSave
QuitWithRollback:
    IF (@@TRANCOUNT > 0) ROLLBACK TRANSACTION
EndSave:
GO

-- Chạy riêng
use [SavingsManagement]
go
insert into StaffPermissions (Id,Name) values (1, 'Admin')
insert into StaffPermissions (Id,Name) values (2, 'Staff')

insert into StaffAccounts (Name,IsMale,BirthDate,PhoneNumber,Address,Email,Position,Username,HashedPassword,PermissionId, IsDisabled) values 
('Admin', 1,CAST(N'2024-11-04' AS Date), N'5404454665', N'Việt Nam', N'22520248@gmail.com',N'Giám đốc', 'Admin', N'AQAAAAIAAYagAAAAEHJxYRqg4BjiBmbDmOzAnboopsH+MGFxLSVSU7wc7ucW4msTPx8na2i6nsSUCr9cJA==',1, 0)
insert into StaffAccounts (Name,IsMale,BirthDate,PhoneNumber,Address,Email,Position, Username,HashedPassword,PermissionId, IsDisabled) values 
('Staff', 0,CAST(N'2024-11-04' AS Date), N'5404454665', N'Việt Nam', N'a', N'Nhân viên', 'Staff', N'AQAAAAIAAYagAAAAEHJxYRqg4BjiBmbDmOzAnboopsH+MGFxLSVSU7wc7ucW4msTPx8na2i6nsSUCr9cJA==',2, 0)
