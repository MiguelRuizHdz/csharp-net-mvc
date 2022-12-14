USE [master]
GO
/****** Object:  Database [agencia]    Script Date: 01/12/2022 07:43:33 a. m. ******/
CREATE DATABASE [agencia]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'agencia', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\agencia.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'agencia_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\agencia_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [agencia] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [agencia].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [agencia] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [agencia] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [agencia] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [agencia] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [agencia] SET ARITHABORT OFF 
GO
ALTER DATABASE [agencia] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [agencia] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [agencia] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [agencia] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [agencia] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [agencia] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [agencia] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [agencia] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [agencia] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [agencia] SET  ENABLE_BROKER 
GO
ALTER DATABASE [agencia] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [agencia] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [agencia] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [agencia] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [agencia] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [agencia] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [agencia] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [agencia] SET RECOVERY FULL 
GO
ALTER DATABASE [agencia] SET  MULTI_USER 
GO
ALTER DATABASE [agencia] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [agencia] SET DB_CHAINING OFF 
GO
ALTER DATABASE [agencia] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [agencia] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [agencia] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [agencia] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'agencia', N'ON'
GO
ALTER DATABASE [agencia] SET QUERY_STORE = OFF
GO
USE [agencia]
GO
/****** Object:  Table [dbo].[Automovil]    Script Date: 01/12/2022 07:43:33 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Automovil](
	[AutomovilId] [int] IDENTITY(1,1) NOT NULL,
	[Marca] [varchar](100) NOT NULL,
	[Modelo] [varchar](100) NOT NULL,
	[Anio] [int] NOT NULL,
	[Precio] [decimal](18, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[AutomovilId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 01/12/2022 07:43:33 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[ClienteId] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[Direccion] [varchar](100) NOT NULL,
	[Telefono] [varchar](100) NOT NULL,
	[Correo_Electronico] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[ClienteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Renta]    Script Date: 01/12/2022 07:43:33 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Renta](
	[RentaId] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [datetime] NULL,
	[AutomovilId] [int] NOT NULL,
	[VendedorId] [int] NOT NULL,
	[ClienteId] [int] NOT NULL,
	[Dias] [int] NOT NULL,
	[Precio] [decimal](18, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[RentaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vendedor]    Script Date: 01/12/2022 07:43:33 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vendedor](
	[VendedorId] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[Direccion] [varchar](100) NOT NULL,
	[Telefono] [varchar](100) NOT NULL,
	[Correo_Electronico] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[VendedorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Renta]  WITH CHECK ADD FOREIGN KEY([AutomovilId])
REFERENCES [dbo].[Automovil] ([AutomovilId])
GO
ALTER TABLE [dbo].[Renta]  WITH CHECK ADD FOREIGN KEY([ClienteId])
REFERENCES [dbo].[Cliente] ([ClienteId])
GO
ALTER TABLE [dbo].[Renta]  WITH CHECK ADD FOREIGN KEY([VendedorId])
REFERENCES [dbo].[Vendedor] ([VendedorId])
GO
/****** Object:  StoredProcedure [dbo].[AutomovilActualiza]    Script Date: 01/12/2022 07:43:33 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/****** Object: StoredProcedure [dbo].[AutomovilActualiza] Script Date: 
27/8/2022 08:22:07 ******/
CREATE PROCEDURE [dbo].[AutomovilActualiza]
@AutomovilId int, @Marca VARCHAR(100), @Modelo Varchar(100), @Anio int, @Precio Decimal(18,2)
AS
BEGIN
UPDATE [dbo].[Automovil]
    SET [Marca] = @Marca
    ,[Modelo] = @Modelo
    ,[Anio] = @Anio
    ,[Precio] = @Precio
    WHERE AutomovilId = @AutomovilId
END
GO
/****** Object:  StoredProcedure [dbo].[AutomovilConsulta]    Script Date: 01/12/2022 07:43:33 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/****** Object: StoredProcedure [dbo].[AutomovilConsulta] Script Date: 27/8/2022 
08:22:07 ******/
CREATE PROCEDURE [dbo].[AutomovilConsulta]
AS
BEGIN
 SELECT [AutomovilId],
        [Marca],
        [Modelo],
        [Anio],
        [Precio]
FROM [dbo].[Automovil]
END
GO
/****** Object:  StoredProcedure [dbo].[AutomovilConsultaXId]    Script Date: 01/12/2022 07:43:33 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


/****** Object: StoredProcedure [dbo].[AutomovilConsultaXId] Script Date: 
27/8/2022 08:22:07 ******/
CREATE PROCEDURE [dbo].[AutomovilConsultaXId]
@AutomovilId int
AS
BEGIN
 SELECT [AutomovilId],
       [Marca],
       [Modelo],
       [Anio],
       [Precio]
 FROM [dbo].[Automovil]
 WHERE AutomovilId = @AutomovilId
END
GO
/****** Object:  StoredProcedure [dbo].[AutomovilElimina]    Script Date: 01/12/2022 07:43:33 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/****** Object: StoredProcedure [dbo].[AutomovilElimina] Script Date: 27/8/2022 
08:22:07 ******/
CREATE PROCEDURE [dbo].[AutomovilElimina]
@AutomovilId INT
AS
BEGIN
    DELETE FROM [dbo].[Automovil]
    WHERE AutomovilId = @AutomovilId
END
GO
/****** Object:  StoredProcedure [dbo].[AutomovilInserta]    Script Date: 01/12/2022 07:43:33 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/****** Object: StoredProcedure [dbo].[AutomovilInserta] Script Date: 27/8/2022 
08:22:07 ******/
CREATE PROCEDURE [dbo].[AutomovilInserta]
@Marca VARCHAR(100), @Modelo VARCHAR(100), @Anio INT, @Precio Decimal(18,2)
AS
BEGIN
    INSERT INTO [dbo].[Automovil]
        ([Marca],
        [Modelo],
        [Anio],
        [Precio])
        VALUES
        (@Marca,
        @Modelo,
        @Anio,
        @Precio)
END
GO
USE [master]
GO
ALTER DATABASE [agencia] SET  READ_WRITE 
GO
