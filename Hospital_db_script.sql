USE [master]
GO
/****** Object:  Database [Hospital]    Script Date: 17.01.2022 16:58:58 ******/
CREATE DATABASE [Hospital]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Hospital', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Hospital.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Hospital_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Hospital_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Hospital] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Hospital].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Hospital] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Hospital] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Hospital] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Hospital] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Hospital] SET ARITHABORT OFF 
GO
ALTER DATABASE [Hospital] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Hospital] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Hospital] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Hospital] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Hospital] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Hospital] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Hospital] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Hospital] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Hospital] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Hospital] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Hospital] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Hospital] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Hospital] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Hospital] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Hospital] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Hospital] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Hospital] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Hospital] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Hospital] SET  MULTI_USER 
GO
ALTER DATABASE [Hospital] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Hospital] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Hospital] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Hospital] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Hospital] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Hospital] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Hospital] SET QUERY_STORE = OFF
GO
USE [Hospital]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 17.01.2022 16:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[ID] [tinyint] IDENTITY(1,1) NOT NULL,
	[AdminTCNo] [nvarchar](11) NOT NULL,
	[AdminSifre] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Admin] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DoktorBilgi]    Script Date: 17.01.2022 16:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DoktorBilgi](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[DoktorTCNo] [nvarchar](11) NOT NULL,
	[DoktorUnvan] [nvarchar](20) NOT NULL,
	[DoktorAdi] [nvarchar](50) NOT NULL,
	[DoktorSoyadi] [nvarchar](50) NOT NULL,
	[DoktorTelefon] [nvarchar](20) NOT NULL,
	[DoktorSifre] [nvarchar](50) NOT NULL,
	[DoktorKlinikID] [int] NOT NULL,
 CONSTRAINT [PK_Doktorlar] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GecmisRandevular]    Script Date: 17.01.2022 16:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GecmisRandevular](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[HastaID] [int] NOT NULL,
	[DoktorID] [int] NOT NULL,
	[KlinikID] [int] NOT NULL,
	[RandevuTarihi] [nvarchar](15) NOT NULL,
	[RandevuSaati] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_GecmisRandevular] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HastaBilgi]    Script Date: 17.01.2022 16:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HastaBilgi](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[HastaTCNo] [nvarchar](11) NOT NULL,
	[HastaAdi] [nvarchar](50) NOT NULL,
	[HastaSoyadi] [nvarchar](50) NOT NULL,
	[HastaCinsiyetID] [int] NOT NULL,
	[HastaKanGrubuID] [int] NOT NULL,
	[HastaEmail] [nvarchar](50) NOT NULL,
	[HastaTelefon] [nvarchar](15) NOT NULL,
	[HastaSifre] [nvarchar](30) NOT NULL,
	[HastaDogumYeriID] [int] NOT NULL,
	[HastaDogumTarihi] [nvarchar](15) NOT NULL,
 CONSTRAINT [PK_HastaKayit] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NakilIslemleri]    Script Date: 17.01.2022 16:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NakilIslemleri](
	[ID] [tinyint] IDENTITY(1,1) NOT NULL,
	[HastaID] [tinyint] NOT NULL,
	[PoliklinikID] [tinyint] NOT NULL,
	[DoktorID] [tinyint] NOT NULL,
	[NakilYeri] [text] NOT NULL,
	[NakilTarih] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_NakilIslemleri] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[prmCinsiyet]    Script Date: 17.01.2022 16:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[prmCinsiyet](
	[Id] [tinyint] IDENTITY(1,1) NOT NULL,
	[Cinsiyet] [nvarchar](5) NOT NULL,
 CONSTRAINT [PK_Cinsiyet] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[prmIller]    Script Date: 17.01.2022 16:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[prmIller](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Iller] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_aaa] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[prmKanGrubu]    Script Date: 17.01.2022 16:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[prmKanGrubu](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[KanGrubu] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_kangrubu_1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[prmPoliklinik]    Script Date: 17.01.2022 16:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[prmPoliklinik](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[PoliklinikAdi] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Poliklinik] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Randevular]    Script Date: 17.01.2022 16:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Randevular](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[HastaID] [int] NOT NULL,
	[DoktorID] [int] NOT NULL,
	[PoliklinikID] [int] NOT NULL,
	[RandevuTarihi] [nvarchar](20) NOT NULL,
	[RandevuSaati] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_Randevula] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaburcuOlanHastalar]    Script Date: 17.01.2022 16:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaburcuOlanHastalar](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[HastaID] [int] NOT NULL,
	[DoktorID] [int] NOT NULL,
	[PoliklinikID] [int] NOT NULL,
	[YatisTarihi] [nvarchar](20) NOT NULL,
	[TaburcuTarihi] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_TaburcuOlanHastalar] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaburcuOlmusHastalar]    Script Date: 17.01.2022 16:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaburcuOlmusHastalar](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[HastaID] [int] NOT NULL,
	[DoktorID] [int] NOT NULL,
	[PoliklinikID] [int] NOT NULL,
	[YatisTarihi] [nvarchar](20) NOT NULL,
	[TaburcuTarihi] [nvarchar](20) NOT NULL,
	[Fiyat] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_TaburcuOlmusHastalar] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[YatanHastalar]    Script Date: 17.01.2022 16:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[YatanHastalar](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[HastaID] [int] NOT NULL,
	[DoktorID] [int] NOT NULL,
	[KlinikID] [int] NOT NULL,
	[YatisTarihi] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_YatanHastalar] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Admin] ON 

INSERT [dbo].[Admin] ([ID], [AdminTCNo], [AdminSifre]) VALUES (1, N'11111111111', N'1234')
SET IDENTITY_INSERT [dbo].[Admin] OFF
GO
SET IDENTITY_INSERT [dbo].[DoktorBilgi] ON 

INSERT [dbo].[DoktorBilgi] ([ID], [DoktorTCNo], [DoktorUnvan], [DoktorAdi], [DoktorSoyadi], [DoktorTelefon], [DoktorSifre], [DoktorKlinikID]) VALUES (1, N'11111111111', N'Prof.Dr.', N'Mustafa', N'Gedik', N'(545) 555-1111', N'1234', 1)
INSERT [dbo].[DoktorBilgi] ([ID], [DoktorTCNo], [DoktorUnvan], [DoktorAdi], [DoktorSoyadi], [DoktorTelefon], [DoktorSifre], [DoktorKlinikID]) VALUES (2, N'22222222222', N'Doç.Dr.', N'Demet', N'Bayrak', N'(545) 555-1121', N'1234', 2)
INSERT [dbo].[DoktorBilgi] ([ID], [DoktorTCNo], [DoktorUnvan], [DoktorAdi], [DoktorSoyadi], [DoktorTelefon], [DoktorSifre], [DoktorKlinikID]) VALUES (3, N'33333333333', N'Op.Dr.', N'Reyhan', N'Taşdemir', N'(545) 555-1222', N'1234', 3)
INSERT [dbo].[DoktorBilgi] ([ID], [DoktorTCNo], [DoktorUnvan], [DoktorAdi], [DoktorSoyadi], [DoktorTelefon], [DoktorSifre], [DoktorKlinikID]) VALUES (4, N'44444444444', N'Uzm.Dr.', N'Kerem', N'Bilgiç', N'(545) 555-1225', N'1234', 4)
INSERT [dbo].[DoktorBilgi] ([ID], [DoktorTCNo], [DoktorUnvan], [DoktorAdi], [DoktorSoyadi], [DoktorTelefon], [DoktorSifre], [DoktorKlinikID]) VALUES (5, N'55555555555', N'Dr.', N'Buse', N'Alkan', N'(545) 555-1224', N'1234', 5)
INSERT [dbo].[DoktorBilgi] ([ID], [DoktorTCNo], [DoktorUnvan], [DoktorAdi], [DoktorSoyadi], [DoktorTelefon], [DoktorSifre], [DoktorKlinikID]) VALUES (6, N'66666666666', N'Dr.', N'Hayri', N'Öztürk', N'(545) 555-1457', N'1234', 6)
INSERT [dbo].[DoktorBilgi] ([ID], [DoktorTCNo], [DoktorUnvan], [DoktorAdi], [DoktorSoyadi], [DoktorTelefon], [DoktorSifre], [DoktorKlinikID]) VALUES (7, N'77777777777', N'Dr.', N'Osman', N'Sivrikaya', N'(545) 555-1258', N'1234', 7)
INSERT [dbo].[DoktorBilgi] ([ID], [DoktorTCNo], [DoktorUnvan], [DoktorAdi], [DoktorSoyadi], [DoktorTelefon], [DoktorSifre], [DoktorKlinikID]) VALUES (8, N'88888888888', N'Dr.', N'Adem', N'Şimşek', N'(545) 555-1875', N'1234', 8)
INSERT [dbo].[DoktorBilgi] ([ID], [DoktorTCNo], [DoktorUnvan], [DoktorAdi], [DoktorSoyadi], [DoktorTelefon], [DoktorSifre], [DoktorKlinikID]) VALUES (9, N'99999999999', N'Dr.', N'Tuğcan', N'Ergün', N'(545) 555-7895', N'1234', 9)
INSERT [dbo].[DoktorBilgi] ([ID], [DoktorTCNo], [DoktorUnvan], [DoktorAdi], [DoktorSoyadi], [DoktorTelefon], [DoktorSifre], [DoktorKlinikID]) VALUES (10, N'10101010101', N'Dr.', N'Özgün', N'Erbudak', N'(545) 555-7845', N'1234', 10)
INSERT [dbo].[DoktorBilgi] ([ID], [DoktorTCNo], [DoktorUnvan], [DoktorAdi], [DoktorSoyadi], [DoktorTelefon], [DoktorSifre], [DoktorKlinikID]) VALUES (11, N'11221122112', N'Dr.', N'Ece', N'Dinçer', N'(545) 555-7456', N'1234', 11)
INSERT [dbo].[DoktorBilgi] ([ID], [DoktorTCNo], [DoktorUnvan], [DoktorAdi], [DoktorSoyadi], [DoktorTelefon], [DoktorSifre], [DoktorKlinikID]) VALUES (12, N'13122121212', N'Dr.', N'Burak', N'İnce', N'(545) 888-1234', N'1234', 12)
INSERT [dbo].[DoktorBilgi] ([ID], [DoktorTCNo], [DoktorUnvan], [DoktorAdi], [DoktorSoyadi], [DoktorTelefon], [DoktorSifre], [DoktorKlinikID]) VALUES (15, N'12121212121', N'Dr.', N'Meryem Can', N'Doğan', N'(111) 111-1111', N'1234', 14)
SET IDENTITY_INSERT [dbo].[DoktorBilgi] OFF
GO
SET IDENTITY_INSERT [dbo].[GecmisRandevular] ON 

INSERT [dbo].[GecmisRandevular] ([ID], [HastaID], [DoktorID], [KlinikID], [RandevuTarihi], [RandevuSaati]) VALUES (1, 1, 1, 1, N'17.12.2021', N'08:30')
INSERT [dbo].[GecmisRandevular] ([ID], [HastaID], [DoktorID], [KlinikID], [RandevuTarihi], [RandevuSaati]) VALUES (2, 1, 1, 1, N'17.12.2021', N'11:30')
SET IDENTITY_INSERT [dbo].[GecmisRandevular] OFF
GO
SET IDENTITY_INSERT [dbo].[HastaBilgi] ON 

INSERT [dbo].[HastaBilgi] ([ID], [HastaTCNo], [HastaAdi], [HastaSoyadi], [HastaCinsiyetID], [HastaKanGrubuID], [HastaEmail], [HastaTelefon], [HastaSifre], [HastaDogumYeriID], [HastaDogumTarihi]) VALUES (1, N'11111111111', N'Mustafa', N'Gedik', 1, 7, N'abc@gmail.com', N'(111) 111-1111', N'1234', 77, N'03.09.1996')
INSERT [dbo].[HastaBilgi] ([ID], [HastaTCNo], [HastaAdi], [HastaSoyadi], [HastaCinsiyetID], [HastaKanGrubuID], [HastaEmail], [HastaTelefon], [HastaSifre], [HastaDogumYeriID], [HastaDogumTarihi]) VALUES (2, N'22222222222', N'Reyhan', N'Taşdemir', 2, 3, N'acb@gmail.com', N'(545) 555-1254', N'1234', 25, N'09.08.1996')
INSERT [dbo].[HastaBilgi] ([ID], [HastaTCNo], [HastaAdi], [HastaSoyadi], [HastaCinsiyetID], [HastaKanGrubuID], [HastaEmail], [HastaTelefon], [HastaSifre], [HastaDogumYeriID], [HastaDogumTarihi]) VALUES (3, N'45877445465', N'Hayri', N'Öztürk', 1, 5, N'abc@hotmail.com', N'(545) 145-2356', N'1234', 34, N'09.07.1996')
INSERT [dbo].[HastaBilgi] ([ID], [HastaTCNo], [HastaAdi], [HastaSoyadi], [HastaCinsiyetID], [HastaKanGrubuID], [HastaEmail], [HastaTelefon], [HastaSifre], [HastaDogumYeriID], [HastaDogumTarihi]) VALUES (4, N'24545478448', N'Osman', N'Sivrikaya', 1, 2, N'aaa@yandex.com', N'(545) 145-2578', N'1234', 74, N'03.12.1998')
INSERT [dbo].[HastaBilgi] ([ID], [HastaTCNo], [HastaAdi], [HastaSoyadi], [HastaCinsiyetID], [HastaKanGrubuID], [HastaEmail], [HastaTelefon], [HastaSifre], [HastaDogumYeriID], [HastaDogumTarihi]) VALUES (5, N'57845448448', N'Demet', N'Taşbilek', 2, 1, N'bbb@outlook.com', N'(538) 145-5247', N'1234', 6, N'04.10.1997')
INSERT [dbo].[HastaBilgi] ([ID], [HastaTCNo], [HastaAdi], [HastaSoyadi], [HastaCinsiyetID], [HastaKanGrubuID], [HastaEmail], [HastaTelefon], [HastaSifre], [HastaDogumYeriID], [HastaDogumTarihi]) VALUES (6, N'11111111112', N'Adasd', N'Soyadasda', 2, 1, N'E-Mail', N'(555) 555-5555', N'adadd', 26, N'11.11.2000')
SET IDENTITY_INSERT [dbo].[HastaBilgi] OFF
GO
SET IDENTITY_INSERT [dbo].[NakilIslemleri] ON 

INSERT [dbo].[NakilIslemleri] ([ID], [HastaID], [PoliklinikID], [DoktorID], [NakilYeri], [NakilTarih]) VALUES (1, 1, 4, 4, N'Acıbadem Hastanesi', N'17.12.2021')
SET IDENTITY_INSERT [dbo].[NakilIslemleri] OFF
GO
SET IDENTITY_INSERT [dbo].[prmCinsiyet] ON 

INSERT [dbo].[prmCinsiyet] ([Id], [Cinsiyet]) VALUES (1, N'Erkek')
INSERT [dbo].[prmCinsiyet] ([Id], [Cinsiyet]) VALUES (2, N'Kadın')
SET IDENTITY_INSERT [dbo].[prmCinsiyet] OFF
GO
SET IDENTITY_INSERT [dbo].[prmIller] ON 

INSERT [dbo].[prmIller] ([ID], [Iller]) VALUES (1, N'Adana')
INSERT [dbo].[prmIller] ([ID], [Iller]) VALUES (2, N'Adıyaman')
INSERT [dbo].[prmIller] ([ID], [Iller]) VALUES (3, N'Afyonkarahisar')
INSERT [dbo].[prmIller] ([ID], [Iller]) VALUES (4, N'Ağrı')
INSERT [dbo].[prmIller] ([ID], [Iller]) VALUES (5, N'Amasya')
INSERT [dbo].[prmIller] ([ID], [Iller]) VALUES (6, N'Ankara')
INSERT [dbo].[prmIller] ([ID], [Iller]) VALUES (7, N'Antalya')
INSERT [dbo].[prmIller] ([ID], [Iller]) VALUES (8, N'Artvin')
INSERT [dbo].[prmIller] ([ID], [Iller]) VALUES (9, N'Aydın')
INSERT [dbo].[prmIller] ([ID], [Iller]) VALUES (10, N'Balıkesir')
INSERT [dbo].[prmIller] ([ID], [Iller]) VALUES (11, N'Bilecik')
INSERT [dbo].[prmIller] ([ID], [Iller]) VALUES (12, N'Bingöl')
INSERT [dbo].[prmIller] ([ID], [Iller]) VALUES (13, N'Bitlis')
INSERT [dbo].[prmIller] ([ID], [Iller]) VALUES (14, N'Bolu')
INSERT [dbo].[prmIller] ([ID], [Iller]) VALUES (15, N'Burdur')
INSERT [dbo].[prmIller] ([ID], [Iller]) VALUES (16, N'Bursa')
INSERT [dbo].[prmIller] ([ID], [Iller]) VALUES (17, N'Çanakkale')
INSERT [dbo].[prmIller] ([ID], [Iller]) VALUES (18, N'Çankırı')
INSERT [dbo].[prmIller] ([ID], [Iller]) VALUES (19, N'Çorum')
INSERT [dbo].[prmIller] ([ID], [Iller]) VALUES (20, N'Denizli')
INSERT [dbo].[prmIller] ([ID], [Iller]) VALUES (21, N'Diyarbakır')
INSERT [dbo].[prmIller] ([ID], [Iller]) VALUES (22, N'Edirne')
INSERT [dbo].[prmIller] ([ID], [Iller]) VALUES (23, N'Elazığ')
INSERT [dbo].[prmIller] ([ID], [Iller]) VALUES (24, N'Erzincan')
INSERT [dbo].[prmIller] ([ID], [Iller]) VALUES (25, N'Erzurum')
INSERT [dbo].[prmIller] ([ID], [Iller]) VALUES (26, N'Eskişehir')
INSERT [dbo].[prmIller] ([ID], [Iller]) VALUES (27, N'Gaziantep')
INSERT [dbo].[prmIller] ([ID], [Iller]) VALUES (28, N'Giresun')
INSERT [dbo].[prmIller] ([ID], [Iller]) VALUES (29, N'Gümüşhane')
INSERT [dbo].[prmIller] ([ID], [Iller]) VALUES (30, N'Hakkari')
INSERT [dbo].[prmIller] ([ID], [Iller]) VALUES (31, N'Hatay')
INSERT [dbo].[prmIller] ([ID], [Iller]) VALUES (32, N'Isparta')
INSERT [dbo].[prmIller] ([ID], [Iller]) VALUES (33, N'Mersin')
INSERT [dbo].[prmIller] ([ID], [Iller]) VALUES (34, N'İstanbul')
INSERT [dbo].[prmIller] ([ID], [Iller]) VALUES (35, N'İzmir')
INSERT [dbo].[prmIller] ([ID], [Iller]) VALUES (36, N'Kars')
INSERT [dbo].[prmIller] ([ID], [Iller]) VALUES (37, N'Kastamonu')
INSERT [dbo].[prmIller] ([ID], [Iller]) VALUES (38, N'Kayseri')
INSERT [dbo].[prmIller] ([ID], [Iller]) VALUES (39, N'Kırklareli')
INSERT [dbo].[prmIller] ([ID], [Iller]) VALUES (40, N'Kırşehir')
INSERT [dbo].[prmIller] ([ID], [Iller]) VALUES (41, N'Kocaeli')
INSERT [dbo].[prmIller] ([ID], [Iller]) VALUES (42, N'Konya')
INSERT [dbo].[prmIller] ([ID], [Iller]) VALUES (43, N'Kütahya')
INSERT [dbo].[prmIller] ([ID], [Iller]) VALUES (44, N'Malatya')
INSERT [dbo].[prmIller] ([ID], [Iller]) VALUES (45, N'Manisa')
INSERT [dbo].[prmIller] ([ID], [Iller]) VALUES (46, N'Kahramanmaraş')
INSERT [dbo].[prmIller] ([ID], [Iller]) VALUES (47, N'Mardin')
INSERT [dbo].[prmIller] ([ID], [Iller]) VALUES (48, N'Muğla')
INSERT [dbo].[prmIller] ([ID], [Iller]) VALUES (49, N'Muş')
INSERT [dbo].[prmIller] ([ID], [Iller]) VALUES (50, N'Nevşehir')
INSERT [dbo].[prmIller] ([ID], [Iller]) VALUES (51, N'Niğde')
INSERT [dbo].[prmIller] ([ID], [Iller]) VALUES (52, N'Ordu')
INSERT [dbo].[prmIller] ([ID], [Iller]) VALUES (53, N'Rize')
INSERT [dbo].[prmIller] ([ID], [Iller]) VALUES (54, N'Sakarya')
INSERT [dbo].[prmIller] ([ID], [Iller]) VALUES (55, N'Samsun')
INSERT [dbo].[prmIller] ([ID], [Iller]) VALUES (56, N'Siirt')
INSERT [dbo].[prmIller] ([ID], [Iller]) VALUES (57, N'Sinop')
INSERT [dbo].[prmIller] ([ID], [Iller]) VALUES (58, N'Sivas')
INSERT [dbo].[prmIller] ([ID], [Iller]) VALUES (59, N'Tekirdağ')
INSERT [dbo].[prmIller] ([ID], [Iller]) VALUES (60, N'Tokat')
INSERT [dbo].[prmIller] ([ID], [Iller]) VALUES (61, N'Trabzon')
INSERT [dbo].[prmIller] ([ID], [Iller]) VALUES (62, N'Tunceli')
INSERT [dbo].[prmIller] ([ID], [Iller]) VALUES (63, N'Şanlıurfa')
INSERT [dbo].[prmIller] ([ID], [Iller]) VALUES (64, N'Uşak')
INSERT [dbo].[prmIller] ([ID], [Iller]) VALUES (65, N'Van')
INSERT [dbo].[prmIller] ([ID], [Iller]) VALUES (66, N'Yozgat')
INSERT [dbo].[prmIller] ([ID], [Iller]) VALUES (67, N'Zonguldak')
INSERT [dbo].[prmIller] ([ID], [Iller]) VALUES (68, N'Aksaray')
INSERT [dbo].[prmIller] ([ID], [Iller]) VALUES (69, N'Bayburt')
INSERT [dbo].[prmIller] ([ID], [Iller]) VALUES (70, N'Karaman')
INSERT [dbo].[prmIller] ([ID], [Iller]) VALUES (71, N'Kırıkkale')
INSERT [dbo].[prmIller] ([ID], [Iller]) VALUES (72, N'Batman')
INSERT [dbo].[prmIller] ([ID], [Iller]) VALUES (73, N'Şırnak')
INSERT [dbo].[prmIller] ([ID], [Iller]) VALUES (74, N'Bartın')
INSERT [dbo].[prmIller] ([ID], [Iller]) VALUES (75, N'Ardahan')
INSERT [dbo].[prmIller] ([ID], [Iller]) VALUES (76, N'Iğdır')
INSERT [dbo].[prmIller] ([ID], [Iller]) VALUES (77, N'Yalova')
INSERT [dbo].[prmIller] ([ID], [Iller]) VALUES (78, N'Karabük')
INSERT [dbo].[prmIller] ([ID], [Iller]) VALUES (79, N'Kilis')
INSERT [dbo].[prmIller] ([ID], [Iller]) VALUES (80, N'Osmaniye')
INSERT [dbo].[prmIller] ([ID], [Iller]) VALUES (81, N'Düzce')
SET IDENTITY_INSERT [dbo].[prmIller] OFF
GO
SET IDENTITY_INSERT [dbo].[prmKanGrubu] ON 

INSERT [dbo].[prmKanGrubu] ([ID], [KanGrubu]) VALUES (1, N'A rh(-)')
INSERT [dbo].[prmKanGrubu] ([ID], [KanGrubu]) VALUES (2, N'A rh(+)')
INSERT [dbo].[prmKanGrubu] ([ID], [KanGrubu]) VALUES (3, N'B rh(-)')
INSERT [dbo].[prmKanGrubu] ([ID], [KanGrubu]) VALUES (4, N'B rh(+)')
INSERT [dbo].[prmKanGrubu] ([ID], [KanGrubu]) VALUES (5, N'AB rh(-)')
INSERT [dbo].[prmKanGrubu] ([ID], [KanGrubu]) VALUES (6, N'AB rh(+)')
INSERT [dbo].[prmKanGrubu] ([ID], [KanGrubu]) VALUES (7, N'0 rh(-)')
INSERT [dbo].[prmKanGrubu] ([ID], [KanGrubu]) VALUES (8, N'0 rh(+)')
SET IDENTITY_INSERT [dbo].[prmKanGrubu] OFF
GO
SET IDENTITY_INSERT [dbo].[prmPoliklinik] ON 

INSERT [dbo].[prmPoliklinik] ([ID], [PoliklinikAdi]) VALUES (1, N'BEYİN VE SİNİR CERRAHİSİ')
INSERT [dbo].[prmPoliklinik] ([ID], [PoliklinikAdi]) VALUES (2, N'ÇOCUK HASTALIKLARI')
INSERT [dbo].[prmPoliklinik] ([ID], [PoliklinikAdi]) VALUES (3, N'CİLDİYE')
INSERT [dbo].[prmPoliklinik] ([ID], [PoliklinikAdi]) VALUES (4, N'ENFEKSİYON HASTALIKLARI')
INSERT [dbo].[prmPoliklinik] ([ID], [PoliklinikAdi]) VALUES (5, N'GENEL CERRAHİ')
INSERT [dbo].[prmPoliklinik] ([ID], [PoliklinikAdi]) VALUES (6, N'GÖĞÜS CERRAHİSİ')
INSERT [dbo].[prmPoliklinik] ([ID], [PoliklinikAdi]) VALUES (7, N'GÖĞÜS HASTALIKLARI')
INSERT [dbo].[prmPoliklinik] ([ID], [PoliklinikAdi]) VALUES (8, N'GÖZ HASTALIKLARI')
INSERT [dbo].[prmPoliklinik] ([ID], [PoliklinikAdi]) VALUES (9, N'İÇ HASTALIKLARI')
INSERT [dbo].[prmPoliklinik] ([ID], [PoliklinikAdi]) VALUES (10, N'KALP VE DAMAR CERRAHİSİ')
INSERT [dbo].[prmPoliklinik] ([ID], [PoliklinikAdi]) VALUES (11, N'KULAK-BURUN-BOĞAZ HASTALIKLARI')
INSERT [dbo].[prmPoliklinik] ([ID], [PoliklinikAdi]) VALUES (12, N'ORTOPEDİ')
INSERT [dbo].[prmPoliklinik] ([ID], [PoliklinikAdi]) VALUES (14, N'PLASTİK CERRAHİ')
SET IDENTITY_INSERT [dbo].[prmPoliklinik] OFF
GO
SET IDENTITY_INSERT [dbo].[TaburcuOlanHastalar] ON 

INSERT [dbo].[TaburcuOlanHastalar] ([ID], [HastaID], [DoktorID], [PoliklinikID], [YatisTarihi], [TaburcuTarihi]) VALUES (1, 1, 6, 6, N'17.12.2021', N'17.12.2021')
SET IDENTITY_INSERT [dbo].[TaburcuOlanHastalar] OFF
GO
SET IDENTITY_INSERT [dbo].[TaburcuOlmusHastalar] ON 

INSERT [dbo].[TaburcuOlmusHastalar] ([ID], [HastaID], [DoktorID], [PoliklinikID], [YatisTarihi], [TaburcuTarihi], [Fiyat]) VALUES (3, 2, 3, 3, N'17.12.2021', N'22.12.2021', N'250 TL')
SET IDENTITY_INSERT [dbo].[TaburcuOlmusHastalar] OFF
GO
SET IDENTITY_INSERT [dbo].[YatanHastalar] ON 

INSERT [dbo].[YatanHastalar] ([ID], [HastaID], [DoktorID], [KlinikID], [YatisTarihi]) VALUES (2, 1, 1, 1, N'17.12.2021')
SET IDENTITY_INSERT [dbo].[YatanHastalar] OFF
GO
/****** Object:  StoredProcedure [dbo].[prc_Admin_Getir]    Script Date: 17.01.2022 16:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[prc_Admin_Getir]
AS

SELECT AdminTCNo, AdminSifre FROM [Admin]
GO
/****** Object:  StoredProcedure [dbo].[prc_AdminOnaylama_Getir]    Script Date: 17.01.2022 16:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[prc_AdminOnaylama_Getir]
AS

SELECT HastaBilgi.HastaTCNo, HastaBilgi.HastaAdi, HastaBilgi.HastaSoyadi,
	   prmPoliklinik.PoliklinikAdi,
	   DoktorBilgi.DoktorUnvan, DoktorBilgi.DoktorAdi, DoktorBilgi.DoktorSoyadi,
       OnayTipi

FROM AdminDogrulama

INNER JOIN HastaBilgi ON (HastaBilgi.ID = AdminDogrulama.HastaID)
INNER JOIN prmPoliklinik ON (prmPoliklinik.ID = AdminDogrulama.PoliklinikID)
INNER JOIN DoktorBilgi ON (DoktorBilgi.ID = AdminDogrulama.DoktorID)
GO
/****** Object:  StoredProcedure [dbo].[prc_AdminOnaylama_Kaydet]    Script Date: 17.01.2022 16:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[prc_AdminOnaylama_Kaydet]
@HastaID tinyint, 
@PoliklinikID tinyint,
@DoktorID tinyint,
@OnayTipi nvarchar(10)
AS

INSERT INTO HastaDurumu VALUES(@HastaID, @PoliklinikID, @DoktorID, @OnayTipi)
GO
/****** Object:  StoredProcedure [dbo].[prc_DoktorBilgi_Getir]    Script Date: 17.01.2022 16:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[prc_DoktorBilgi_Getir]
@DoktorTCNo NVARCHAR(11)
AS

SELECT D.ID, D.DoktorUnvan, D.DoktorAdi, D.DoktorSoyadi, 
prmPoliklinik.PoliklinikAdi , DoktorTCNo, DoktorSifre FROM DoktorBilgi D 

INNER JOIN prmPoliklinik ON (D.DoktorKlinikID = prmPoliklinik.ID)

WHERE DoktorTCNo = @DoktorTCNo
GO
/****** Object:  StoredProcedure [dbo].[prc_DoktorBilgi_Guncelle]    Script Date: 17.01.2022 16:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[prc_DoktorBilgi_Guncelle]
@DoktorID int,
@DoktorTCNo nvarchar(11),
@DoktorUnvan nvarchar(20),
@DoktorAdi nvarchar(50),
@DoktorSoyadi nvarchar(50),
@DoktorTelefon nvarchar(20),
@DoktorSifre nvarchar(50),
@DoktorKlinikID int
AS

UPDATE DoktorBilgi SET DoktorTCNo = @DoktorTCNo,
					   DoktorUnvan = @DoktorUnvan, 
					   DoktorAdi = @DoktorAdi, 
					   DoktorSoyadi = @DoktorSoyadi,
					   DoktorTelefon = @DoktorTelefon,
					   DoktorSifre = @DoktorSifre,
					   DoktorKlinikID = @DoktorKlinikID
WHERE ID = @DoktorID
GO
/****** Object:  StoredProcedure [dbo].[prc_DoktorBilgi_Kaydet]    Script Date: 17.01.2022 16:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[prc_DoktorBilgi_Kaydet]
@DoktorTCNo NVARCHAR(11),
@DoktorUnvan nvarchar(20),
@DoktorAdi nvarchar(50),
@DoktorSoyadi nvarchar(50),
@DoktorTelefon nvarchar(20),
@DoktorSifre nvarchar(50),
@DoktorKlinikID int

AS

INSERT INTO DoktorBilgi 
VALUES (@DoktorTCNo,
		@DoktorUnvan,
		@DoktorAdi,
		@DoktorSoyadi,
		@DoktorTelefon,
		@DoktorSifre,
		@DoktorKlinikID)
GO
/****** Object:  StoredProcedure [dbo].[prc_DoktorBilgi_Sil]    Script Date: 17.01.2022 16:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[prc_DoktorBilgi_Sil]
@DoktorID int
AS

DELETE FROM DoktorBilgi WHERE ID = @DoktorID
GO
/****** Object:  StoredProcedure [dbo].[prc_DoktorRandevu_Getir]    Script Date: 17.01.2022 16:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[prc_DoktorRandevu_Getir]
@DoktorID int,
@RandevuTarihi nvarchar(20)
as

SELECT HastaBilgi.HastaTCNo, 
	   (HastaBilgi.HastaAdi + ' ' +  HastaBilgi.HastaSoyadi), 
	   (DoktorBilgi.DoktorUnvan + ' ' + DoktorBilgi.DoktorAdi + ' ' + DoktorBilgi.DoktorSoyadi), 
	   prmPoliklinik.PoliklinikAdi,
	   Randevular.RandevuTarihi, 
	   Randevular.RandevuSaati 

FROM Randevular

INNER JOIN HastaBilgi ON (HastaBilgi.ID = Randevular.HastaID)
INNER JOIN DoktorBilgi ON (DoktorBilgi.ID = Randevular.DoktorID)
INNER JOIN prmPoliklinik ON (prmPoliklinik.ID = Randevular.PoliklinikID)

WHERE Randevular.DoktorID = @DoktorID AND Randevular.RandevuTarihi = @RandevuTarihi;
GO
/****** Object:  StoredProcedure [dbo].[prc_DoktorTCNoSorgulama]    Script Date: 17.01.2022 16:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[prc_DoktorTCNoSorgulama]
@DoktorTCNo nvarchar(11)
as
select count(DoktorTCNo) from DoktorBilgi where DoktorTCNo = @DoktorTCNo
GO
/****** Object:  StoredProcedure [dbo].[prc_DoktorTumBilgileri_Getir]    Script Date: 17.01.2022 16:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[prc_DoktorTumBilgileri_Getir]
AS

SELECT D.ID, D.DoktorTCNo, prmPoliklinik.PoliklinikAdi, D.DoktorUnvan, D.DoktorAdi, D.DoktorSoyadi, 
D.DoktorTelefon, D.DoktorSifre FROM DoktorBilgi D 
INNER JOIN prmPoliklinik ON (D.DoktorKlinikID = prmPoliklinik.ID)
GO
/****** Object:  StoredProcedure [dbo].[prc_GecmisRandevular_Getir]    Script Date: 17.01.2022 16:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[prc_GecmisRandevular_Getir]
@HastaID int
AS 

SELECT HastaBilgi.HastaTCNo, 
	   (HastaBilgi.HastaAdi + ' ' +  HastaBilgi.HastaSoyadi), 
	   (DoktorBilgi.DoktorUnvan + ' ' + DoktorBilgi.DoktorAdi + ' ' + DoktorBilgi.DoktorSoyadi), 
	   prmPoliklinik.PoliklinikAdi,
	   GecmisRandevular.RandevuTarihi, 
	   GecmisRandevular.RandevuSaati 

FROM GecmisRandevular

INNER JOIN HastaBilgi ON (HastaBilgi.ID = GecmisRandevular.HastaID)
INNER JOIN DoktorBilgi ON (DoktorBilgi.ID = GecmisRandevular.DoktorID)
INNER JOIN prmPoliklinik ON (prmPoliklinik.ID = GecmisRandevular.KlinikID)

WHERE GecmisRandevular.HastaID = @HastaID;
GO
/****** Object:  StoredProcedure [dbo].[prc_HastaBilgi_Getir]    Script Date: 17.01.2022 16:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[prc_HastaBilgi_Getir]
@HastaTCNo NVARCHAR(11)
AS

SELECT ID, HastaTCNo, HastaSifre, HastaAdi, HastaSoyadi FROM HastaBilgi WHERE HastaTCNo = @HastaTCNo
GO
/****** Object:  StoredProcedure [dbo].[prc_HastaBilgi_Guncelle]    Script Date: 17.01.2022 16:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[prc_HastaBilgi_Guncelle]
@HastaID int,
@HastaTCNo NVARCHAR(11),
@HastaAdi NVARCHAR(50),
@HastaSoyadi NVARCHAR(50),
@HastaCinsiyetID Int, 
@HastaKanGrubuID Int,
@HastaEmail NVARCHAR(50),
@HastaTelefon NVARCHAR(15),
@HastaSifre NVARCHAR(30),
@HastaDogumYeriID Int,
@HastaDogumTarihi NVARCHAR(15)
AS

UPDATE HastaBilgi SET  HastaTCNo = @HastaTCNo, 
					   HastaAdi = @HastaAdi, 
					   HastaSoyadi = @HastaSoyadi,
					   HastaCinsiyetID = @HastaCinsiyetID,
					   HastaKanGrubuID = @HastaKanGrubuID,
					   HastaEmail = @HastaEmail,
					   HastaTelefon = @HastaTelefon,
					   HastaSifre = @HastaSifre,
					   HastaDogumYeriID = @HastaDogumYeriID,
					   HastaDogumTarihi = @HastaDogumTarihi
WHERE ID = @HastaID
GO
/****** Object:  StoredProcedure [dbo].[prc_HastaBilgi_Kaydet]    Script Date: 17.01.2022 16:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[prc_HastaBilgi_Kaydet]

@HastaTCNo NVARCHAR(11),
@HastaAdi NVARCHAR(50),
@HastaSoyadi NVARCHAR(50),
@HastaCinsiyetID TINYINT, 
@HastaKanGrubuID TINYINT,
@HastaEmail NVARCHAR(50),
@HastaTelefon NVARCHAR(15),
@HastaSifre NVARCHAR(30),
@HastaDogumYeriID TINYINT,
@HastaDogumTarihi NVARCHAR(15)

AS

INSERT INTO HastaBilgi
VALUES(@HastaTCNo, 
	   @HastaAdi, 
	   @HastaSoyadi, 
	   @HastaCinsiyetID, 
	   @HastaKanGrubuID, 
	   @HastaEmail, 
	   @HastaTelefon,
	   @HastaSifre,
	   @HastaDogumYeriID,
	   @HastaDogumTarihi)
GO
/****** Object:  StoredProcedure [dbo].[prc_HastaDurumu]    Script Date: 17.01.2022 16:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[prc_HastaDurumu]
@HastaDurum nvarchar(10)
AS

SELECT HastaBilgi.HastaTCNo, HastaBilgi.HastaAdi, HastaBilgi.HastaSoyadi, 
	   prmPoliklinik.PoliklinikAdi,
	   DoktorBilgi.DoktorUnvan, DoktorBilgi.DoktorAdi, DoktorBilgi.DoktorSoyadi, 
	   HastaDurumu.HastaDurum
	   
FROM HastaDurumu 
INNER JOIN DoktorBilgi ON (DoktorBilgi.ID = HastaDurumu.DoktorID)
INNER JOIN prmPoliklinik ON (prmPoliklinik.ID = HastaDurumu.PoliklinikID)
INNER JOIN HastaBilgi ON (HastaBilgi.ID = HastaDurumu.HastaID)

WHERE HastaDurumu.HastaDurum = @HastaDurum
GO
/****** Object:  StoredProcedure [dbo].[prc_HastaTCNoSorgulama]    Script Date: 17.01.2022 16:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[prc_HastaTCNoSorgulama]
@HastaTCNo NVARCHAR(11)
AS

SELECT COUNT(HastaTCNo) FROM HastaBilgi WHERE HastaTCNo = @HastaTCNo
GO
/****** Object:  StoredProcedure [dbo].[prc_HastaTumBilgi_Getir]    Script Date: 17.01.2022 16:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[prc_HastaTumBilgi_Getir]
@HastaTCNo nvarchar(11)
AS

SELECT H.ID, H.HastaTCNo, H.HastaAdi, H.HastaSoyadi, 
	   prmCinsiyet.Cinsiyet, prmKanGrubu.KanGrubu, 
	   H.HastaEmail, H.HastaTelefon, H.HastaSifre, prmIller.Iller, H.HastaDogumTarihi
FROM HastaBilgi H

INNER JOIN prmCinsiyet ON (prmCinsiyet.Id = H.HastaCinsiyetID)
INNER JOIN prmKanGrubu ON (prmKanGrubu.Id = H.HastaKanGrubuID)
INNER JOIN prmIller ON (prmIller.Id = H.HastaDogumYeriID)

WHERE H.HastaTCNo = @HastaTCNo
GO
/****** Object:  StoredProcedure [dbo].[prc_KlinigeGoreDoktor_Getir]    Script Date: 17.01.2022 16:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[prc_KlinigeGoreDoktor_Getir]
@DoktorKlinikID TINYINT
AS

SELECT ID, DoktorUnvan + ' ' + DoktorAdi + ' ' + DoktorSoyadi FROM DoktorBilgi
WHERE DoktorKlinikID = @DoktorKlinikID
GO
/****** Object:  StoredProcedure [dbo].[prc_NakilIslemleri_Getir]    Script Date: 17.01.2022 16:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[prc_NakilIslemleri_Getir]
AS

SELECT HastaBilgi.HastaTCNo, HastaBilgi.HastaAdi, HastaBilgi.HastaSoyadi,
	   prmPoliklinik.PoliklinikAdi,
	   DoktorBilgi.DoktorUnvan, DoktorBilgi.DoktorAdi, DoktorBilgi.DoktorSoyadi,
       NakilYeri, NakilTarih FROM NakilIslemleri

INNER JOIN HastaBilgi ON (HastaBilgi.ID = NakilIslemleri.HastaID)
INNER JOIN prmPoliklinik ON (prmPoliklinik.ID = NakilIslemleri.PoliklinikID)
INNER JOIN DoktorBilgi ON (DoktorBilgi.ID = NakilIslemleri.DoktorID)
GO
/****** Object:  StoredProcedure [dbo].[prc_PoliklinikID_Getir]    Script Date: 17.01.2022 16:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[prc_PoliklinikID_Getir]
@PoliklinikAdi NVARCHAR(100)
AS

SELECT ID FROM prmPoliklinik WHERE PoliklinikAdi = @PoliklinikAdi
GO
/****** Object:  StoredProcedure [dbo].[prc_prmCinsiyet_Getir]    Script Date: 17.01.2022 16:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[prc_prmCinsiyet_Getir]
AS

SELECT Cinsiyet FROM prmCinsiyet
GO
/****** Object:  StoredProcedure [dbo].[prc_prmIller_Getir]    Script Date: 17.01.2022 16:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[prc_prmIller_Getir]
AS

SELECT Iller FROM prmIller
GO
/****** Object:  StoredProcedure [dbo].[prc_prmIllerID_Getir]    Script Date: 17.01.2022 16:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[prc_prmIllerID_Getir]
@Iller nvarchar(50)
AS

SELECT ID FROM prmIller WHERE Iller = @Iller
GO
/****** Object:  StoredProcedure [dbo].[prc_prmKanGrubu_Getir]    Script Date: 17.01.2022 16:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[prc_prmKanGrubu_Getir]
AS

SELECT KanGrubu FROM prmKanGrubu
GO
/****** Object:  StoredProcedure [dbo].[prc_prmKanGrubuID_Getir]    Script Date: 17.01.2022 16:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[prc_prmKanGrubuID_Getir]
@KanGrubu NVARCHAR(20)
AS

SELECT ID FROM prmKanGrubu WHERE KanGrubu = @KanGrubu
GO
/****** Object:  StoredProcedure [dbo].[prc_prmPoliklinik_Getir]    Script Date: 17.01.2022 16:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[prc_prmPoliklinik_Getir]
AS

SELECT ID, PoliklinikAdi FROM prmPoliklinik
GO
/****** Object:  StoredProcedure [dbo].[prc_prmPoliklinik_Guncelle]    Script Date: 17.01.2022 16:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create procedure  [dbo].[prc_prmPoliklinik_Guncelle]
 
 @PoliklinikAdi nvarchar(100),
  @PoliklinikAdi2 nvarchar(100)
 
as

 UPDATE prmPoliklinik SET PoliklinikAdi = @PoliklinikAdi where  PoliklinikAdi = @PoliklinikAdi2

     
 
GO
/****** Object:  StoredProcedure [dbo].[prc_prmPoliklinik_Kaydet]    Script Date: 17.01.2022 16:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[prc_prmPoliklinik_Kaydet]
@PoliklinikAdi NVARCHAR(100)
AS
INSERT INTO prmPoliklinik VALUES(@PoliklinikAdi)
GO
/****** Object:  StoredProcedure [dbo].[prc_prmPoliklinik_Sil]    Script Date: 17.01.2022 16:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create procedure   [dbo].[prc_prmPoliklinik_Sil]
 @PoliklinikAdi nvarchar(100)
 AS
 DELETE FROM prmPoliklinik where PoliklinikAdi=@PoliklinikAdi
GO
/****** Object:  StoredProcedure [dbo].[prc_Randevular_Getir]    Script Date: 17.01.2022 16:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[prc_Randevular_Getir]
@HastaID int
AS 

SELECT HastaBilgi.HastaTCNo, 
	   (HastaBilgi.HastaAdi + ' ' +  HastaBilgi.HastaSoyadi), 
	   (DoktorBilgi.DoktorUnvan + ' ' + DoktorBilgi.DoktorAdi + ' ' + DoktorBilgi.DoktorSoyadi), 
	   prmPoliklinik.PoliklinikAdi,
	   Randevular.RandevuTarihi, 
	   Randevular.RandevuSaati 

FROM Randevular

INNER JOIN HastaBilgi ON (HastaBilgi.ID = Randevular.HastaID)
INNER JOIN DoktorBilgi ON (DoktorBilgi.ID = Randevular.DoktorID)
INNER JOIN prmPoliklinik ON (prmPoliklinik.ID = Randevular.PoliklinikID)

WHERE Randevular.HastaID = @HastaID;
GO
/****** Object:  StoredProcedure [dbo].[prc_Randevular_Kaydet]    Script Date: 17.01.2022 16:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[prc_Randevular_Kaydet]
@HastaID TINYINT,
@DoktorID TINYINT,
@PoliklinikID TINYINT,
@RandevuTarihi NVARCHAR(15),
@RandevuSaati NVARCHAR(10)
AS

INSERT INTO Randevular VALUES(@HastaID, @DoktorID, @PoliklinikID, @RandevuTarihi, @RandevuSaati)
								
GO
/****** Object:  StoredProcedure [dbo].[prc_Randevular_Kontrol]    Script Date: 17.01.2022 16:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[prc_Randevular_Kontrol]
@DoktorID int,
@PoliklinikID int,
@RandevuTarihi nvarchar(20)
AS

SELECT RandevuSaati FROM Randevular 
WHERE DoktorID = @DoktorID AND PoliklinikID = @PoliklinikID AND RandevuTarihi = @RandevuTarihi
GO
/****** Object:  StoredProcedure [dbo].[prc_TaburcuFiyat]    Script Date: 17.01.2022 16:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[prc_TaburcuFiyat]
AS

SELECT H.ID, H.HastaTCNo, (H.HastaAdi + ' ' + H.HastaSoyadi), 
	   (D.DoktorUnvan + ' ' + D.DoktorAdi + ' ' + D.DoktorSoyadi), 
	   P.PoliklinikAdi,
	   T.YatisTarihi, T.TaburcuTarihi, T.DoktorID, T.PoliklinikID

FROM TaburcuOlanHastalar T

INNER JOIN HastaBilgi H ON(T.HastaID = H.ID)
INNER JOIN DoktorBilgi D ON(T.DoktorID = D.ID)
INNER JOIN prmPoliklinik P ON(T.PoliklinikID = P.ID)
GO
/****** Object:  StoredProcedure [dbo].[prc_TaburcuOlmusHastalar]    Script Date: 17.01.2022 16:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

cREATE PROCEDURE [dbo].[prc_TaburcuOlmusHastalar]
AS

SELECT H.HastaTCNo, (H.HastaAdi + ' ' + H.HastaSoyadi), 
	   (D.DoktorUnvan + ' ' + D.DoktorAdi + ' ' + D.DoktorSoyadi), 
	   P.PoliklinikAdi,
	   TOS.YatisTarihi, TOS.TaburcuTarihi, TOS.Fiyat

FROM TaburcuOlmusHastalar TOS

INNER JOIN HastaBilgi H ON(TOS.HastaID = H.ID)
INNER JOIN DoktorBilgi D ON(TOS.DoktorID = D.ID)
INNER JOIN prmPoliklinik P ON(TOS.PoliklinikID = P.ID)
GO
/****** Object:  StoredProcedure [dbo].[prc_YatanHastaTaburcu]    Script Date: 17.01.2022 16:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[prc_YatanHastaTaburcu]
AS

SELECT H.HastaTCNo, (H.HastaAdi + ' ' + H.HastaSoyadi), 
	   (D.DoktorUnvan + ' ' + D.DoktorAdi + ' ' + D.DoktorSoyadi), 
	   P.PoliklinikAdi,
	   Y.YatisTarihi 
FROM YatanHastalar Y

INNER JOIN HastaBilgi H ON(Y.HastaID = H.ID)
INNER JOIN DoktorBilgi D ON(Y.DoktorID = D.ID)
INNER JOIN prmPoliklinik P ON(Y.KlinikID = P.ID)
GO
USE [master]
GO
ALTER DATABASE [Hospital] SET  READ_WRITE 
GO
