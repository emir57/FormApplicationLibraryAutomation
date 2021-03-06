USE [library]
GO
/****** Object:  Table [dbo].[Emanetler]    Script Date: 20.08.2021 20:21:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Emanetler](
	[EmanetNo] [int] IDENTITY(1,1) NOT NULL,
	[UyeNo] [int] NOT NULL,
	[KitapNo] [int] NOT NULL,
	[EmanetVermeTarih] [date] NULL,
	[EmanetGeriAlmaTarih] [date] NULL,
	[EmanetIslemTarih] [date] NULL,
	[EmanetNot] [varchar](50) NULL,
	[EmanetTeslimEdildi] [varchar](20) NULL,
 CONSTRAINT [PK_Emanetler] PRIMARY KEY CLUSTERED 
(
	[EmanetNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kitaplar]    Script Date: 20.08.2021 20:21:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kitaplar](
	[KitapNo] [int] IDENTITY(1,1) NOT NULL,
	[KitapAd] [varchar](50) NULL,
	[KitapYazari] [nvarchar](50) NULL,
	[KitapBaskiYil] [smallint] NULL,
	[KitapSayfaSayi] [smallint] NULL,
	[KitapDil] [varchar](30) NULL,
	[KitapYayinEvi] [varchar](30) NULL,
	[KitapAciklama] [varchar](50) NULL,
 CONSTRAINT [PK_Kitaplar] PRIMARY KEY CLUSTERED 
(
	[KitapNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Uyeler]    Script Date: 20.08.2021 20:21:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Uyeler](
	[UyeNo] [int] IDENTITY(1,1) NOT NULL,
	[UyeAd] [varchar](20) NULL,
	[UyeSoyad] [varchar](20) NULL,
	[UyeTelefon] [nvarchar](50) NULL,
	[UyeEposta] [varchar](50) NULL,
	[UyeAdres] [varchar](200) NULL,
 CONSTRAINT [PK_Uyeler] PRIMARY KEY CLUSTERED 
(
	[UyeNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Emanetler] ADD  CONSTRAINT [DF_Emanetler_EmanetIslemTarih]  DEFAULT (getdate()) FOR [EmanetIslemTarih]
GO
