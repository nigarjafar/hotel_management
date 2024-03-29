USE [master]
GO
/****** Object:  Database [hotel_management]    Script Date: 31.05.2017 18:21:47 ******/
CREATE DATABASE [hotel_management]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'hotel_management', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\hotel_management.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'hotel_management_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\hotel_management_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [hotel_management] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [hotel_management].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [hotel_management] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [hotel_management] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [hotel_management] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [hotel_management] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [hotel_management] SET ARITHABORT OFF 
GO
ALTER DATABASE [hotel_management] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [hotel_management] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [hotel_management] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [hotel_management] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [hotel_management] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [hotel_management] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [hotel_management] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [hotel_management] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [hotel_management] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [hotel_management] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [hotel_management] SET  DISABLE_BROKER 
GO
ALTER DATABASE [hotel_management] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [hotel_management] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [hotel_management] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [hotel_management] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [hotel_management] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [hotel_management] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [hotel_management] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [hotel_management] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [hotel_management] SET  MULTI_USER 
GO
ALTER DATABASE [hotel_management] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [hotel_management] SET DB_CHAINING OFF 
GO
ALTER DATABASE [hotel_management] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [hotel_management] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [hotel_management]
GO
/****** Object:  Table [dbo].[cash]    Script Date: 31.05.2017 18:21:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[cash](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[reservation_id] [int] NOT NULL,
	[name] [varchar](100) NOT NULL,
	[cash_date] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[cities]    Script Date: 31.05.2017 18:21:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[cities](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[country_id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[countries]    Script Date: 31.05.2017 18:21:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[countries](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[credit_card_cash]    Script Date: 31.05.2017 18:21:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[credit_card_cash](
	[id] [int] NOT NULL,
	[date] [varchar](10) NULL,
	[cvc] [varchar](10) NULL,
	[reservation_id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[food]    Script Date: 31.05.2017 18:21:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[food](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[type] [varchar](50) NOT NULL,
	[price] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[food_reserve]    Script Date: 31.05.2017 18:21:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[food_reserve](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[reservation_id] [int] NOT NULL,
	[food_id] [int] NOT NULL,
	[number] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[guests]    Script Date: 31.05.2017 18:21:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[guests](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](100) NOT NULL,
	[surname] [varchar](100) NULL,
	[birthDate] [datetime] NOT NULL,
	[gender] [varchar](10) NOT NULL,
	[phone] [varchar](30) NOT NULL,
	[email] [varchar](100) NOT NULL,
	[country_id] [int] NOT NULL,
	[city_id] [int] NOT NULL,
	[street_address] [varchar](150) NULL,
	[zip_code] [int] NULL,
	[pasport_id] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[payment_method]    Script Date: 31.05.2017 18:21:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[payment_method](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[method] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[reservation]    Script Date: 31.05.2017 18:21:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[reservation](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[guest_id] [int] NOT NULL,
	[room_id] [int] NOT NULL,
	[number_of_guests] [int] NOT NULL,
	[entry_date] [datetime] NOT NULL,
	[departure_date] [datetime] NOT NULL,
	[payment_method] [int] NULL,
	[total_payment] [int] NULL,
 CONSTRAINT [PK__reservat__3213E83FD0C8DC9F] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[room_type]    Script Date: 31.05.2017 18:21:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[room_type](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[type] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[rooms]    Script Date: 31.05.2017 18:21:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[rooms](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[floor] [int] NOT NULL,
	[room_type_id] [int] NOT NULL,
	[price_per_day] [int] NOT NULL,
	[room_capacity] [int] NOT NULL,
	[room_number] [int] NULL,
	[is_empty] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[service_reserve]    Script Date: 31.05.2017 18:21:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[service_reserve](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[reservation_id] [int] NOT NULL,
	[service_id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[services]    Script Date: 31.05.2017 18:21:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[services](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[servic_name] [varchar](20) NOT NULL,
	[price] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
USE [master]
GO
ALTER DATABASE [hotel_management] SET  READ_WRITE 
GO
