USE [master]
GO
/****** Object:  Database [nutricion]    Script Date: 11/10/2022 7:47:01 p. m. ******/
CREATE DATABASE [nutricion]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'nutricion', FILENAME = N'C:\Users\je-nn\nutricion.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'nutricion_log', FILENAME = N'C:\Users\je-nn\nutricion_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [nutricion] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [nutricion].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [nutricion] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [nutricion] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [nutricion] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [nutricion] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [nutricion] SET ARITHABORT OFF 
GO
ALTER DATABASE [nutricion] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [nutricion] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [nutricion] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [nutricion] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [nutricion] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [nutricion] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [nutricion] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [nutricion] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [nutricion] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [nutricion] SET  DISABLE_BROKER 
GO
ALTER DATABASE [nutricion] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [nutricion] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [nutricion] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [nutricion] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [nutricion] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [nutricion] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [nutricion] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [nutricion] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [nutricion] SET  MULTI_USER 
GO
ALTER DATABASE [nutricion] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [nutricion] SET DB_CHAINING OFF 
GO
ALTER DATABASE [nutricion] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [nutricion] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [nutricion] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [nutricion] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [nutricion] SET QUERY_STORE = OFF
GO
USE [nutricion]
GO
/****** Object:  Table [dbo].[Caracterizacion]    Script Date: 11/10/2022 7:47:01 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Caracterizacion](
	[IdCaracterizacion] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](70) NOT NULL,
	[apellido] [varchar](70) NOT NULL,
	[tipo_identificacion] [varchar](70) NOT NULL,
	[numero_dentificacion] [nvarchar](50) NOT NULL,
	[pais_origen] [varchar](70) NOT NULL,
	[genero] [varchar](70) NOT NULL,
	[fecha_nacimiento] [varchar](70) NOT NULL,
	[edad] [int] NOT NULL,
	[estado_civil] [varchar](70) NOT NULL,
	[numero_hijos] [int] NOT NULL,
	[direccion_residencia] [varchar](70) NOT NULL,
	[barrio_residencia] [varchar](70) NOT NULL,
	[tiempo_permanencia] [varchar](70) NOT NULL,
	[telefono_contacto] [int] NOT NULL,
	[contacto_emergencia] [int] NOT NULL,
	[nivel_escolaridad] [varchar](70) NOT NULL,
	[ocupacion] [varchar](70) NOT NULL,
	[EPS] [varchar](70) NOT NULL,
	[regimen] [varchar](70) NOT NULL,
	[email] [varchar](70) NOT NULL,
	[convenio] [varchar](70) NOT NULL,
	[antecedente_medicos] [varchar](70) NOT NULL,
 CONSTRAINT [PK_db.Caracterización] PRIMARY KEY CLUSTERED 
(
	[IdCaracterizacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 11/10/2022 7:47:01 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[USUARIO] [varchar](50) NOT NULL,
	[PASSWORD] [varchar](100) NOT NULL,
	[NOMBRE_COMPLETO] [varchar](70) NOT NULL,
	[CORREO] [varchar](70) NOT NULL,
	[ESTADO] [bit] NOT NULL,
	[FECHA] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Usuarios] ADD  DEFAULT ((1)) FOR [ESTADO]
GO
ALTER TABLE [dbo].[Usuarios] ADD  DEFAULT (getdate()) FOR [FECHA]
GO
/****** Object:  StoredProcedure [dbo].[sp_listar]    Script Date: 11/10/2022 7:47:01 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_listar]
as
select * from Caracterizacion
GO
USE [master]
GO
ALTER DATABASE [nutricion] SET  READ_WRITE 
GO
