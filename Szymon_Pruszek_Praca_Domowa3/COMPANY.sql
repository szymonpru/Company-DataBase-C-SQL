USE [master]
GO
/****** Object:  Database [COMPANY]    Script Date: 16/04/2017 21:39:18 ******/
CREATE DATABASE [COMPANY]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'COMPANY', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\COMPANY.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'COMPANY_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\COMPANY_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [COMPANY] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [COMPANY].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [COMPANY] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [COMPANY] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [COMPANY] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [COMPANY] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [COMPANY] SET ARITHABORT OFF 
GO
ALTER DATABASE [COMPANY] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [COMPANY] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [COMPANY] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [COMPANY] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [COMPANY] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [COMPANY] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [COMPANY] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [COMPANY] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [COMPANY] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [COMPANY] SET  DISABLE_BROKER 
GO
ALTER DATABASE [COMPANY] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [COMPANY] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [COMPANY] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [COMPANY] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [COMPANY] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [COMPANY] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [COMPANY] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [COMPANY] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [COMPANY] SET  MULTI_USER 
GO
ALTER DATABASE [COMPANY] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [COMPANY] SET DB_CHAINING OFF 
GO
ALTER DATABASE [COMPANY] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [COMPANY] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [COMPANY] SET DELAYED_DURABILITY = DISABLED 
GO
USE [COMPANY]
GO
/****** Object:  Table [dbo].[County]    Script Date: 16/04/2017 21:39:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[County](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Capital] [nvarchar](50) NOT NULL,
	[VoivodeshipID] [int] NOT NULL,
 CONSTRAINT [PK_County2] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Department]    Script Date: 16/04/2017 21:39:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Department](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Department] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Employment]    Script Date: 16/04/2017 21:39:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employment](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Salary] [int] NOT NULL,
	[Date_of_employment] [date] NOT NULL,
	[Date_of_release] [date] NULL,
	[PersonID] [int] NULL,
	[DepartmentID] [int] NOT NULL,
	[PositionID] [int] NOT NULL,
 CONSTRAINT [PK_Employment] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Person]    Script Date: 16/04/2017 21:39:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Person](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Surname] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Age] [int] NOT NULL,
	[Education] [nvarchar](50) NOT NULL,
	[CountyID] [int] NOT NULL,
 CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Position]    Script Date: 16/04/2017 21:39:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Position](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Position] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Voivodeship]    Script Date: 16/04/2017 21:39:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Voivodeship](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Capital] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Voivodeship] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[County] ON 

INSERT [dbo].[County] ([ID], [Name], [Capital], [VoivodeshipID]) VALUES (1, N'bolesławiecki ', N'Bolesławiec', 1)
INSERT [dbo].[County] ([ID], [Name], [Capital], [VoivodeshipID]) VALUES (2, N'brodnicki', N'Brodnica', 2)
INSERT [dbo].[County] ([ID], [Name], [Capital], [VoivodeshipID]) VALUES (3, N'chełmski', N'Chełm', 3)
INSERT [dbo].[County] ([ID], [Name], [Capital], [VoivodeshipID]) VALUES (4, N'janowski', N'Janów Lubelski', 3)
INSERT [dbo].[County] ([ID], [Name], [Capital], [VoivodeshipID]) VALUES (5, N'łaski', N'Łask', 4)
INSERT [dbo].[County] ([ID], [Name], [Capital], [VoivodeshipID]) VALUES (6, N'lubelski', N'Lublin', 3)
INSERT [dbo].[County] ([ID], [Name], [Capital], [VoivodeshipID]) VALUES (7, N'opolski', N'Opolskie', 3)
INSERT [dbo].[County] ([ID], [Name], [Capital], [VoivodeshipID]) VALUES (8, N'miechowski', N'Michów', 5)
INSERT [dbo].[County] ([ID], [Name], [Capital], [VoivodeshipID]) VALUES (9, N'włocławski', N'Włocławek', 2)
INSERT [dbo].[County] ([ID], [Name], [Capital], [VoivodeshipID]) VALUES (10, N'krakowski', N'Kraków', 5)
INSERT [dbo].[County] ([ID], [Name], [Capital], [VoivodeshipID]) VALUES (11, N'rypiński ', N'Rypin', 2)
INSERT [dbo].[County] ([ID], [Name], [Capital], [VoivodeshipID]) VALUES (12, N'toruński', N'Toruń', 2)
INSERT [dbo].[County] ([ID], [Name], [Capital], [VoivodeshipID]) VALUES (17, N'zamojski ', N'Zamość', 3)
INSERT [dbo].[County] ([ID], [Name], [Capital], [VoivodeshipID]) VALUES (18, N'białobrzeski', N'Białobrzegi', 6)
INSERT [dbo].[County] ([ID], [Name], [Capital], [VoivodeshipID]) VALUES (19, N'mławski', N'Mława', 6)
INSERT [dbo].[County] ([ID], [Name], [Capital], [VoivodeshipID]) VALUES (20, N'oleski', N'Olesno', 7)
INSERT [dbo].[County] ([ID], [Name], [Capital], [VoivodeshipID]) VALUES (21, N'jasielski', N'Jasło', 8)
INSERT [dbo].[County] ([ID], [Name], [Capital], [VoivodeshipID]) VALUES (22, N'moniecki', N'Mońsk', 9)
INSERT [dbo].[County] ([ID], [Name], [Capital], [VoivodeshipID]) VALUES (24, N'częstochowski', N'Częstochowa', 11)
SET IDENTITY_INSERT [dbo].[County] OFF
SET IDENTITY_INSERT [dbo].[Department] ON 

INSERT [dbo].[Department] ([ID], [Name]) VALUES (1, N'Prawny')
INSERT [dbo].[Department] ([ID], [Name]) VALUES (2, N'Księgowości')
INSERT [dbo].[Department] ([ID], [Name]) VALUES (3, N'HR')
INSERT [dbo].[Department] ([ID], [Name]) VALUES (4, N'Rozwoju')
INSERT [dbo].[Department] ([ID], [Name]) VALUES (5, N'Logistyki')
INSERT [dbo].[Department] ([ID], [Name]) VALUES (6, N'Handlowy')
SET IDENTITY_INSERT [dbo].[Department] OFF
SET IDENTITY_INSERT [dbo].[Employment] ON 

INSERT [dbo].[Employment] ([ID], [Salary], [Date_of_employment], [Date_of_release], [PersonID], [DepartmentID], [PositionID]) VALUES (2, 3550, CAST(N'1994-07-21' AS Date), CAST(N'2005-03-20' AS Date), 2, 2, 2)
INSERT [dbo].[Employment] ([ID], [Salary], [Date_of_employment], [Date_of_release], [PersonID], [DepartmentID], [PositionID]) VALUES (4, 3050, CAST(N'2004-06-02' AS Date), NULL, 3, 1, 3)
INSERT [dbo].[Employment] ([ID], [Salary], [Date_of_employment], [Date_of_release], [PersonID], [DepartmentID], [PositionID]) VALUES (5, 6050, CAST(N'2013-01-20' AS Date), NULL, 4, 4, 4)
INSERT [dbo].[Employment] ([ID], [Salary], [Date_of_employment], [Date_of_release], [PersonID], [DepartmentID], [PositionID]) VALUES (6, 6550, CAST(N'2015-03-12' AS Date), NULL, 5, 4, 4)
INSERT [dbo].[Employment] ([ID], [Salary], [Date_of_employment], [Date_of_release], [PersonID], [DepartmentID], [PositionID]) VALUES (9, 4050, CAST(N'2012-01-20' AS Date), NULL, 6, 5, 5)
INSERT [dbo].[Employment] ([ID], [Salary], [Date_of_employment], [Date_of_release], [PersonID], [DepartmentID], [PositionID]) VALUES (10, 5050, CAST(N'2015-12-19' AS Date), NULL, 7, 6, 6)
INSERT [dbo].[Employment] ([ID], [Salary], [Date_of_employment], [Date_of_release], [PersonID], [DepartmentID], [PositionID]) VALUES (11, 2550, CAST(N'2013-11-15' AS Date), CAST(N'2015-12-19' AS Date), 8, 5, 7)
INSERT [dbo].[Employment] ([ID], [Salary], [Date_of_employment], [Date_of_release], [PersonID], [DepartmentID], [PositionID]) VALUES (12, 6050, CAST(N'2011-10-19' AS Date), NULL, 9, 4, 4)
INSERT [dbo].[Employment] ([ID], [Salary], [Date_of_employment], [Date_of_release], [PersonID], [DepartmentID], [PositionID]) VALUES (13, 6350, CAST(N'2011-10-19' AS Date), NULL, 10, 4, 4)
INSERT [dbo].[Employment] ([ID], [Salary], [Date_of_employment], [Date_of_release], [PersonID], [DepartmentID], [PositionID]) VALUES (14, 2050, CAST(N'2010-12-05' AS Date), NULL, 11, 6, 7)
INSERT [dbo].[Employment] ([ID], [Salary], [Date_of_employment], [Date_of_release], [PersonID], [DepartmentID], [PositionID]) VALUES (15, 7050, CAST(N'2010-05-28' AS Date), NULL, 12, 3, 6)
INSERT [dbo].[Employment] ([ID], [Salary], [Date_of_employment], [Date_of_release], [PersonID], [DepartmentID], [PositionID]) VALUES (19, 5000, CAST(N'2010-06-16' AS Date), CAST(N'2010-06-30' AS Date), 25, 1, 1)
INSERT [dbo].[Employment] ([ID], [Salary], [Date_of_employment], [Date_of_release], [PersonID], [DepartmentID], [PositionID]) VALUES (20, 3000, CAST(N'2002-09-17' AS Date), CAST(N'2010-06-30' AS Date), 26, 6, 7)
INSERT [dbo].[Employment] ([ID], [Salary], [Date_of_employment], [Date_of_release], [PersonID], [DepartmentID], [PositionID]) VALUES (21, 3200, CAST(N'2010-06-16' AS Date), NULL, 27, 6, 7)
INSERT [dbo].[Employment] ([ID], [Salary], [Date_of_employment], [Date_of_release], [PersonID], [DepartmentID], [PositionID]) VALUES (22, 6000, CAST(N'2008-04-14' AS Date), NULL, 28, 4, 4)
INSERT [dbo].[Employment] ([ID], [Salary], [Date_of_employment], [Date_of_release], [PersonID], [DepartmentID], [PositionID]) VALUES (23, 10000, CAST(N'2000-01-13' AS Date), NULL, 30, 3, 6)
INSERT [dbo].[Employment] ([ID], [Salary], [Date_of_employment], [Date_of_release], [PersonID], [DepartmentID], [PositionID]) VALUES (24, 9999, CAST(N'2001-06-17' AS Date), NULL, 31, 3, 6)
INSERT [dbo].[Employment] ([ID], [Salary], [Date_of_employment], [Date_of_release], [PersonID], [DepartmentID], [PositionID]) VALUES (25, 3400, CAST(N'2007-11-01' AS Date), CAST(N'2010-06-16' AS Date), 29, 5, 1)
SET IDENTITY_INSERT [dbo].[Employment] OFF
SET IDENTITY_INSERT [dbo].[Person] ON 

INSERT [dbo].[Person] ([ID], [Surname], [Name], [Age], [Education], [CountyID]) VALUES (2, N'Tałaj', N'Marek', 24, N'wyższe', 2)
INSERT [dbo].[Person] ([ID], [Surname], [Name], [Age], [Education], [CountyID]) VALUES (3, N'Nowak', N'Jan', 34, N'średnie', 3)
INSERT [dbo].[Person] ([ID], [Surname], [Name], [Age], [Education], [CountyID]) VALUES (4, N'Ryszkowski', N'Mateusz', 28, N'podstawowe', 4)
INSERT [dbo].[Person] ([ID], [Surname], [Name], [Age], [Education], [CountyID]) VALUES (5, N'Bohdan', N'Artur', 51, N'zasadnicze', 5)
INSERT [dbo].[Person] ([ID], [Surname], [Name], [Age], [Education], [CountyID]) VALUES (6, N'Żmija', N'Janusz', 32, N'zasadnicze', 6)
INSERT [dbo].[Person] ([ID], [Surname], [Name], [Age], [Education], [CountyID]) VALUES (7, N'Kowalski', N'Brajan', 24, N'podstawowe', 7)
INSERT [dbo].[Person] ([ID], [Surname], [Name], [Age], [Education], [CountyID]) VALUES (8, N'Konieczny', N'Filip', 54, N'wyższe', 8)
INSERT [dbo].[Person] ([ID], [Surname], [Name], [Age], [Education], [CountyID]) VALUES (9, N'Anusiak', N'Maciej', 37, N'średnie', 9)
INSERT [dbo].[Person] ([ID], [Surname], [Name], [Age], [Education], [CountyID]) VALUES (10, N'Konieczna', N'Barbara', 62, N'zasadnicze', 10)
INSERT [dbo].[Person] ([ID], [Surname], [Name], [Age], [Education], [CountyID]) VALUES (11, N'Ciastek', N'Katarzyna', 27, N'wyższe', 11)
INSERT [dbo].[Person] ([ID], [Surname], [Name], [Age], [Education], [CountyID]) VALUES (12, N'Bugała', N'Anna', 30, N'średnie', 12)
INSERT [dbo].[Person] ([ID], [Surname], [Name], [Age], [Education], [CountyID]) VALUES (25, N'Pruszek', N'Weronika', 23, N'podstawowe', 1)
INSERT [dbo].[Person] ([ID], [Surname], [Name], [Age], [Education], [CountyID]) VALUES (26, N'Akbar', N'Aladeen', 30, N'podstawowe', 1)
INSERT [dbo].[Person] ([ID], [Surname], [Name], [Age], [Education], [CountyID]) VALUES (27, N'Adrian', N'Stolarski', 34, N'wyższe', 6)
INSERT [dbo].[Person] ([ID], [Surname], [Name], [Age], [Education], [CountyID]) VALUES (28, N'Dawid', N'Bednarczyk', 21, N'średnie', 9)
INSERT [dbo].[Person] ([ID], [Surname], [Name], [Age], [Education], [CountyID]) VALUES (29, N'Konrad', N'Lampa', 40, N'zasadnicze', 12)
INSERT [dbo].[Person] ([ID], [Surname], [Name], [Age], [Education], [CountyID]) VALUES (30, N'Adolf', N'Hitler', 50, N'wyższe', 17)
INSERT [dbo].[Person] ([ID], [Surname], [Name], [Age], [Education], [CountyID]) VALUES (31, N'Józef', N'Stalin', 51, N'podstawowe', 12)
SET IDENTITY_INSERT [dbo].[Person] OFF
SET IDENTITY_INSERT [dbo].[Position] ON 

INSERT [dbo].[Position] ([ID], [Name]) VALUES (1, N'Księgowy')
INSERT [dbo].[Position] ([ID], [Name]) VALUES (2, N'Administrator Serwerów')
INSERT [dbo].[Position] ([ID], [Name]) VALUES (3, N'Analityk Danych')
INSERT [dbo].[Position] ([ID], [Name]) VALUES (4, N'Programista')
INSERT [dbo].[Position] ([ID], [Name]) VALUES (5, N'Dyrektor')
INSERT [dbo].[Position] ([ID], [Name]) VALUES (6, N'Menager')
INSERT [dbo].[Position] ([ID], [Name]) VALUES (7, N'Dozorca')
SET IDENTITY_INSERT [dbo].[Position] OFF
SET IDENTITY_INSERT [dbo].[Voivodeship] ON 

INSERT [dbo].[Voivodeship] ([ID], [Name], [Capital]) VALUES (1, N'dolnośląskie', N'Wrocław')
INSERT [dbo].[Voivodeship] ([ID], [Name], [Capital]) VALUES (2, N'kujawsko-pomorskie', N'Bydgoszcz')
INSERT [dbo].[Voivodeship] ([ID], [Name], [Capital]) VALUES (3, N'lubelskie', N'Lublin')
INSERT [dbo].[Voivodeship] ([ID], [Name], [Capital]) VALUES (4, N'łódzkie', N'Lódź')
INSERT [dbo].[Voivodeship] ([ID], [Name], [Capital]) VALUES (5, N'małopolskie', N'Kraków')
INSERT [dbo].[Voivodeship] ([ID], [Name], [Capital]) VALUES (6, N'mazowieckie', N'Warszawa')
INSERT [dbo].[Voivodeship] ([ID], [Name], [Capital]) VALUES (7, N'opolskie', N'Opole')
INSERT [dbo].[Voivodeship] ([ID], [Name], [Capital]) VALUES (8, N'podkarpackie', N'Rzeszów')
INSERT [dbo].[Voivodeship] ([ID], [Name], [Capital]) VALUES (9, N'podlaskie', N'Białystok')
INSERT [dbo].[Voivodeship] ([ID], [Name], [Capital]) VALUES (11, N'śląskie', N'Katowice')
SET IDENTITY_INSERT [dbo].[Voivodeship] OFF
ALTER TABLE [dbo].[County]  WITH CHECK ADD  CONSTRAINT [FK_County2_Voivodeship] FOREIGN KEY([VoivodeshipID])
REFERENCES [dbo].[Voivodeship] ([ID])
GO
ALTER TABLE [dbo].[County] CHECK CONSTRAINT [FK_County2_Voivodeship]
GO
ALTER TABLE [dbo].[Employment]  WITH CHECK ADD  CONSTRAINT [FK_Employment_Department] FOREIGN KEY([DepartmentID])
REFERENCES [dbo].[Department] ([ID])
GO
ALTER TABLE [dbo].[Employment] CHECK CONSTRAINT [FK_Employment_Department]
GO
ALTER TABLE [dbo].[Employment]  WITH CHECK ADD  CONSTRAINT [FK_Employment_Person] FOREIGN KEY([PersonID])
REFERENCES [dbo].[Person] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Employment] CHECK CONSTRAINT [FK_Employment_Person]
GO
ALTER TABLE [dbo].[Employment]  WITH CHECK ADD  CONSTRAINT [FK_Employment_Position] FOREIGN KEY([PositionID])
REFERENCES [dbo].[Position] ([ID])
GO
ALTER TABLE [dbo].[Employment] CHECK CONSTRAINT [FK_Employment_Position]
GO
ALTER TABLE [dbo].[Person]  WITH CHECK ADD  CONSTRAINT [FK_Person_County2] FOREIGN KEY([CountyID])
REFERENCES [dbo].[County] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Person] CHECK CONSTRAINT [FK_Person_County2]
GO
USE [master]
GO
ALTER DATABASE [COMPANY] SET  READ_WRITE 
GO
