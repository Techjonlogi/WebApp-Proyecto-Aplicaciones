USE [master]
GO
/****** Object:  Database [SpotyWebBD]    Script Date: 11/04/2021 04:26:43 p. m. ******/
CREATE DATABASE [SpotyWebBD]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SpotyWebBD', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\SpotyWebBD.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SpotyWebBD_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\SpotyWebBD_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [SpotyWebBD] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SpotyWebBD].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SpotyWebBD] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SpotyWebBD] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SpotyWebBD] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SpotyWebBD] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SpotyWebBD] SET ARITHABORT OFF 
GO
ALTER DATABASE [SpotyWebBD] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SpotyWebBD] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SpotyWebBD] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SpotyWebBD] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SpotyWebBD] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SpotyWebBD] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SpotyWebBD] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SpotyWebBD] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SpotyWebBD] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SpotyWebBD] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SpotyWebBD] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SpotyWebBD] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SpotyWebBD] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SpotyWebBD] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SpotyWebBD] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SpotyWebBD] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SpotyWebBD] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SpotyWebBD] SET RECOVERY FULL 
GO
ALTER DATABASE [SpotyWebBD] SET  MULTI_USER 
GO
ALTER DATABASE [SpotyWebBD] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SpotyWebBD] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SpotyWebBD] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SpotyWebBD] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SpotyWebBD] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'SpotyWebBD', N'ON'
GO
ALTER DATABASE [SpotyWebBD] SET QUERY_STORE = OFF
GO
USE [SpotyWebBD]
GO
/****** Object:  Table [dbo].[Album]    Script Date: 11/04/2021 04:26:44 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Album](
	[IdAlbum] [nvarchar](50) NOT NULL,
	[Nombre] [nvarchar](50) NULL,
	[Año] [nvarchar](50) NULL,
	[Artista] [nvarchar](50) NULL,
	[Canciones] [nvarchar](50) NULL,
 CONSTRAINT [PK_Album] PRIMARY KEY CLUSTERED 
(
	[IdAlbum] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Album-Cancion]    Script Date: 11/04/2021 04:26:44 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Album-Cancion](
	[Album] [nvarchar](50) NOT NULL,
	[Cancion] [nvarchar](50) NULL,
 CONSTRAINT [PK_Album-Cancion] PRIMARY KEY CLUSTERED 
(
	[Album] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Artista]    Script Date: 11/04/2021 04:26:44 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Artista](
	[idArtista] [int] NOT NULL,
	[NombreArtista] [nvarchar](50) NULL,
	[NumeroAlbumes] [nvarchar](50) NULL,
	[Seguidores] [nvarchar](max) NULL,
	[AñoInicio] [nvarchar](50) NULL,
 CONSTRAINT [PK_Artista] PRIMARY KEY CLUSTERED 
(
	[idArtista] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cancion]    Script Date: 11/04/2021 04:26:44 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cancion](
	[idCancion] [nvarchar](50) NOT NULL,
	[Titulo] [nvarchar](50) NULL,
	[Genero] [nvarchar](50) NULL,
	[Duracion] [nvarchar](10) NULL,
	[Album] [nvarchar](50) NULL,
	[Artista] [int] NULL,
	[RutaRecurso] [nvarchar](100) NULL,
 CONSTRAINT [PK_Cancion] PRIMARY KEY CLUSTERED 
(
	[idCancion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PlayList]    Script Date: 11/04/2021 04:26:44 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PlayList](
	[idPlaylist] [nvarchar](50) NOT NULL,
	[Nombre] [nvarchar](50) NULL,
	[Cancion] [nvarchar](50) NULL,
	[Usuario] [nvarchar](50) NULL,
 CONSTRAINT [PK_PlayList] PRIMARY KEY CLUSTERED 
(
	[idPlaylist] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PlayList-Usuario]    Script Date: 11/04/2021 04:26:44 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PlayList-Usuario](
	[PlayList] [nvarchar](50) NOT NULL,
	[Usuario] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_PlayList-Usuario] PRIMARY KEY CLUSTERED 
(
	[PlayList] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 11/04/2021 04:26:44 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[NickName] [nvarchar](50) NOT NULL,
	[Nombre] [nvarchar](50) NULL,
	[correo] [nvarchar](50) NULL,
	[Contraseña] [nvarchar](50) NULL,
	[follows] [nvarchar](50) NULL,
	[KeySesion] [nvarchar](max) NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[NickName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario-Cancion]    Script Date: 11/04/2021 04:26:44 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario-Cancion](
	[Usuario] [nvarchar](50) NOT NULL,
	[Cancion] [nvarchar](50) NULL,
 CONSTRAINT [PK_Usuario-Cancion] PRIMARY KEY CLUSTERED 
(
	[Usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Album-Cancion]  WITH CHECK ADD  CONSTRAINT [FK_Album-Cancion_Album] FOREIGN KEY([Album])
REFERENCES [dbo].[Album] ([IdAlbum])
GO
ALTER TABLE [dbo].[Album-Cancion] CHECK CONSTRAINT [FK_Album-Cancion_Album]
GO
ALTER TABLE [dbo].[Album-Cancion]  WITH CHECK ADD  CONSTRAINT [FK_Album-Cancion_Cancion] FOREIGN KEY([Cancion])
REFERENCES [dbo].[Cancion] ([idCancion])
GO
ALTER TABLE [dbo].[Album-Cancion] CHECK CONSTRAINT [FK_Album-Cancion_Cancion]
GO
ALTER TABLE [dbo].[Cancion]  WITH CHECK ADD  CONSTRAINT [FK_Cancion_Artista] FOREIGN KEY([Artista])
REFERENCES [dbo].[Artista] ([idArtista])
GO
ALTER TABLE [dbo].[Cancion] CHECK CONSTRAINT [FK_Cancion_Artista]
GO
ALTER TABLE [dbo].[PlayList]  WITH CHECK ADD  CONSTRAINT [FK_PlayList_Cancion] FOREIGN KEY([Cancion])
REFERENCES [dbo].[Cancion] ([idCancion])
GO
ALTER TABLE [dbo].[PlayList] CHECK CONSTRAINT [FK_PlayList_Cancion]
GO
ALTER TABLE [dbo].[PlayList-Usuario]  WITH CHECK ADD  CONSTRAINT [FK_PlayList-Usuario_PlayList] FOREIGN KEY([PlayList])
REFERENCES [dbo].[PlayList] ([idPlaylist])
GO
ALTER TABLE [dbo].[PlayList-Usuario] CHECK CONSTRAINT [FK_PlayList-Usuario_PlayList]
GO
ALTER TABLE [dbo].[PlayList-Usuario]  WITH CHECK ADD  CONSTRAINT [FK_PlayList-Usuario_Usuario] FOREIGN KEY([Usuario])
REFERENCES [dbo].[Usuario] ([NickName])
GO
ALTER TABLE [dbo].[PlayList-Usuario] CHECK CONSTRAINT [FK_PlayList-Usuario_Usuario]
GO
ALTER TABLE [dbo].[Usuario-Cancion]  WITH CHECK ADD  CONSTRAINT [FK_Usuario-Cancion_Cancion] FOREIGN KEY([Cancion])
REFERENCES [dbo].[Cancion] ([idCancion])
GO
ALTER TABLE [dbo].[Usuario-Cancion] CHECK CONSTRAINT [FK_Usuario-Cancion_Cancion]
GO
ALTER TABLE [dbo].[Usuario-Cancion]  WITH CHECK ADD  CONSTRAINT [FK_Usuario-Cancion_Usuario] FOREIGN KEY([Usuario])
REFERENCES [dbo].[Usuario] ([NickName])
GO
ALTER TABLE [dbo].[Usuario-Cancion] CHECK CONSTRAINT [FK_Usuario-Cancion_Usuario]
GO
USE [master]
GO
ALTER DATABASE [SpotyWebBD] SET  READ_WRITE 
GO
