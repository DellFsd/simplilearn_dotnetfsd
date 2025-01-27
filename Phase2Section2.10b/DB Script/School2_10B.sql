USE [master]
GO
/****** Object:  Database [School2_10B]    Script Date: 11/17/2021 4:00:24 PM ******/
CREATE DATABASE [School2_10B]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'School2_10B', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\School2_10B.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'School2_10B_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\School2_10B_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [School2_10B] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [School2_10B].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [School2_10B] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [School2_10B] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [School2_10B] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [School2_10B] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [School2_10B] SET ARITHABORT OFF 
GO
ALTER DATABASE [School2_10B] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [School2_10B] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [School2_10B] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [School2_10B] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [School2_10B] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [School2_10B] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [School2_10B] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [School2_10B] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [School2_10B] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [School2_10B] SET  DISABLE_BROKER 
GO
ALTER DATABASE [School2_10B] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [School2_10B] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [School2_10B] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [School2_10B] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [School2_10B] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [School2_10B] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [School2_10B] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [School2_10B] SET RECOVERY FULL 
GO
ALTER DATABASE [School2_10B] SET  MULTI_USER 
GO
ALTER DATABASE [School2_10B] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [School2_10B] SET DB_CHAINING OFF 
GO
ALTER DATABASE [School2_10B] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [School2_10B] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [School2_10B] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [School2_10B] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'School2_10B', N'ON'
GO
ALTER DATABASE [School2_10B] SET QUERY_STORE = OFF
GO
USE [School2_10B]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 11/17/2021 4:00:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[Address] [varchar](100) NOT NULL,
	[Email] [varchar](75) NOT NULL,
	[Course] [varchar](5) NOT NULL
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [School2_10B] SET  READ_WRITE 
GO
