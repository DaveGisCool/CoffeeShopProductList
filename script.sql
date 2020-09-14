USE [master]
GO
/****** Object:  Database [CoffeeLab]    Script Date: 9/14/2020 7:58:18 AM ******/
CREATE DATABASE [CoffeeLab]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CoffeeLab', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\CoffeeLab.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CoffeeLab_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\CoffeeLab_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [CoffeeLab] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CoffeeLab].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CoffeeLab] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CoffeeLab] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CoffeeLab] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CoffeeLab] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CoffeeLab] SET ARITHABORT OFF 
GO
ALTER DATABASE [CoffeeLab] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CoffeeLab] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CoffeeLab] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CoffeeLab] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CoffeeLab] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CoffeeLab] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CoffeeLab] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CoffeeLab] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CoffeeLab] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CoffeeLab] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CoffeeLab] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CoffeeLab] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CoffeeLab] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CoffeeLab] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CoffeeLab] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CoffeeLab] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CoffeeLab] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CoffeeLab] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [CoffeeLab] SET  MULTI_USER 
GO
ALTER DATABASE [CoffeeLab] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CoffeeLab] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CoffeeLab] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CoffeeLab] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CoffeeLab] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [CoffeeLab] SET QUERY_STORE = OFF
GO
USE [CoffeeLab]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 9/14/2020 7:58:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](40) NULL,
	[Description] [ntext] NULL,
	[Price] [money] NULL,
	[Category] [nchar](20) NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Product] ON 
GO
INSERT [dbo].[Product] ([ID], [Name], [Description], [Price], [Category]) VALUES (1, N'Coffee', N'Standard black caffinated coffee', 2.0000, N'Basic               ')
GO
INSERT [dbo].[Product] ([ID], [Name], [Description], [Price], [Category]) VALUES (2, N'Decaf Coffee', N'Standard black decaffinated coffee', 2.0000, N'Basic               ')
GO
INSERT [dbo].[Product] ([ID], [Name], [Description], [Price], [Category]) VALUES (3, N'Cappucino', N'Espresso-based coffee with steamed milk', 3.0000, N'Deluxe              ')
GO
INSERT [dbo].[Product] ([ID], [Name], [Description], [Price], [Category]) VALUES (4, N'Espresso', N'Concentrated coffee', 2.5000, N'Deluxe              ')
GO
INSERT [dbo].[Product] ([ID], [Name], [Description], [Price], [Category]) VALUES (5, N'Hot Chocolate', N'Chocolate melted in steamed milk', 2.0000, N'Basic               ')
GO
INSERT [dbo].[Product] ([ID], [Name], [Description], [Price], [Category]) VALUES (6, N'Latte', N'Espresso-based coffee with steamed milk', 3.0000, N'Deluxe              ')
GO
INSERT [dbo].[Product] ([ID], [Name], [Description], [Price], [Category]) VALUES (7, N'Mochaccino', N'Chocolate infused espresso with steamed milk ', 3.5000, N'Deluxe              ')
GO
SET IDENTITY_INSERT [dbo].[Product] OFF
GO
USE [master]
GO
ALTER DATABASE [CoffeeLab] SET  READ_WRITE 
GO
