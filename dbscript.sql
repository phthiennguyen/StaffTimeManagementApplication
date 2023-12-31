USE [master]
GO
/****** Object:  Database [StaffTimeManagementDB]    Script Date: 12/13/2023 10:19:51 AM ******/
CREATE DATABASE [StaffTimeManagementDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'StaffTimeManagementDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\StaffTimeManagementDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'StaffTimeManagementDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\StaffTimeManagementDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [StaffTimeManagementDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [StaffTimeManagementDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [StaffTimeManagementDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [StaffTimeManagementDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [StaffTimeManagementDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [StaffTimeManagementDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [StaffTimeManagementDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [StaffTimeManagementDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [StaffTimeManagementDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [StaffTimeManagementDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [StaffTimeManagementDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [StaffTimeManagementDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [StaffTimeManagementDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [StaffTimeManagementDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [StaffTimeManagementDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [StaffTimeManagementDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [StaffTimeManagementDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [StaffTimeManagementDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [StaffTimeManagementDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [StaffTimeManagementDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [StaffTimeManagementDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [StaffTimeManagementDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [StaffTimeManagementDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [StaffTimeManagementDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [StaffTimeManagementDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [StaffTimeManagementDB] SET  MULTI_USER 
GO
ALTER DATABASE [StaffTimeManagementDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [StaffTimeManagementDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [StaffTimeManagementDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [StaffTimeManagementDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [StaffTimeManagementDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [StaffTimeManagementDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [StaffTimeManagementDB] SET QUERY_STORE = OFF
GO
USE [StaffTimeManagementDB]
GO
/****** Object:  Table [dbo].[Admins]    Script Date: 12/13/2023 10:19:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admins](
	[adminId] [nvarchar](50) NOT NULL,
	[firstName] [nvarchar](50) NULL,
	[lastName] [nvarchar](50) NULL,
	[email] [nvarchar](50) NULL,
	[phoneNumber] [nvarchar](50) NULL,
 CONSTRAINT [PK_Admins] PRIMARY KEY CLUSTERED 
(
	[adminId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Managers]    Script Date: 12/13/2023 10:19:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Managers](
	[managerId] [nvarchar](50) NOT NULL,
	[firstName] [nvarchar](50) NULL,
	[lastName] [nvarchar](50) NULL,
	[email] [nvarchar](50) NULL,
	[phoneNumber] [nvarchar](50) NULL,
 CONSTRAINT [PK_Managers] PRIMARY KEY CLUSTERED 
(
	[managerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Message_Staff_Manager]    Script Date: 12/13/2023 10:19:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Message_Staff_Manager](
	[messageId] [int] NOT NULL,
	[message] [nvarchar](100) NULL,
	[staffId] [nvarchar](50) NULL,
	[managerId] [nvarchar](50) NULL,
 CONSTRAINT [PK_Message_Staff_Manager] PRIMARY KEY CLUSTERED 
(
	[messageId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Staffs]    Script Date: 12/13/2023 10:19:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staffs](
	[staffId] [nvarchar](50) NOT NULL,
	[firstName] [nvarchar](50) NULL,
	[lastName] [nvarchar](50) NULL,
	[email] [nvarchar](50) NULL,
	[phoneNumber] [nvarchar](50) NULL,
 CONSTRAINT [PK_Staffs] PRIMARY KEY CLUSTERED 
(
	[staffId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StaffWorkHours]    Script Date: 12/13/2023 10:19:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StaffWorkHours](
	[entryId] [int] IDENTITY(1,1) NOT NULL,
	[timeIn] [datetime] NULL,
	[timeOut] [datetime] NULL,
	[staffId] [nvarchar](50) NULL,
	[date] [date] NULL,
 CONSTRAINT [PK_StaffWorkHours] PRIMARY KEY CLUSTERED 
(
	[entryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users_Admins]    Script Date: 12/13/2023 10:19:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users_Admins](
	[userName] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NULL,
	[adminId] [nvarchar](50) NULL,
 CONSTRAINT [PK_Users_Admins] PRIMARY KEY CLUSTERED 
(
	[userName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users_Managers]    Script Date: 12/13/2023 10:19:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users_Managers](
	[userName] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NULL,
	[managerId] [nvarchar](50) NULL,
 CONSTRAINT [PK_Users_Managers] PRIMARY KEY CLUSTERED 
(
	[userName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users_Staffs]    Script Date: 12/13/2023 10:19:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users_Staffs](
	[userName] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NULL,
	[staffId] [nvarchar](50) NULL,
 CONSTRAINT [PK_Users_Staffs] PRIMARY KEY CLUSTERED 
(
	[userName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Message_Staff_Manager]  WITH CHECK ADD  CONSTRAINT [FK_Message_Staff_Manager_Managers] FOREIGN KEY([managerId])
REFERENCES [dbo].[Managers] ([managerId])
GO
ALTER TABLE [dbo].[Message_Staff_Manager] CHECK CONSTRAINT [FK_Message_Staff_Manager_Managers]
GO
ALTER TABLE [dbo].[Message_Staff_Manager]  WITH CHECK ADD  CONSTRAINT [FK_Message_Staff_Manager_Staffs] FOREIGN KEY([staffId])
REFERENCES [dbo].[Staffs] ([staffId])
GO
ALTER TABLE [dbo].[Message_Staff_Manager] CHECK CONSTRAINT [FK_Message_Staff_Manager_Staffs]
GO
ALTER TABLE [dbo].[StaffWorkHours]  WITH CHECK ADD  CONSTRAINT [FK_StaffWorkHours_Staffs] FOREIGN KEY([staffId])
REFERENCES [dbo].[Staffs] ([staffId])
GO
ALTER TABLE [dbo].[StaffWorkHours] CHECK CONSTRAINT [FK_StaffWorkHours_Staffs]
GO
USE [master]
GO
ALTER DATABASE [StaffTimeManagementDB] SET  READ_WRITE 
GO
