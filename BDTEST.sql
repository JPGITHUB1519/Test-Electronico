USE [master]
GO
/****** Object:  Database [DBTEST]    Script Date: 06/03/2016 13:58:31 ******/
CREATE DATABASE [DBTEST] ON  PRIMARY 
( NAME = N'DBTEST', FILENAME = N'c:\Archivos de programa\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\DBTEST.mdf' , SIZE = 2304KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'DBTEST_log', FILENAME = N'c:\Archivos de programa\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\DBTEST_log.LDF' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [DBTEST] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DBTEST].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DBTEST] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [DBTEST] SET ANSI_NULLS OFF
GO
ALTER DATABASE [DBTEST] SET ANSI_PADDING OFF
GO
ALTER DATABASE [DBTEST] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [DBTEST] SET ARITHABORT OFF
GO
ALTER DATABASE [DBTEST] SET AUTO_CLOSE ON
GO
ALTER DATABASE [DBTEST] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [DBTEST] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [DBTEST] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [DBTEST] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [DBTEST] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [DBTEST] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [DBTEST] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [DBTEST] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [DBTEST] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [DBTEST] SET  ENABLE_BROKER
GO
ALTER DATABASE [DBTEST] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [DBTEST] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [DBTEST] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [DBTEST] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [DBTEST] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [DBTEST] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [DBTEST] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [DBTEST] SET  READ_WRITE
GO
ALTER DATABASE [DBTEST] SET RECOVERY SIMPLE
GO
ALTER DATABASE [DBTEST] SET  MULTI_USER
GO
ALTER DATABASE [DBTEST] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [DBTEST] SET DB_CHAINING OFF
GO
USE [DBTEST]
GO
/****** Object:  Table [dbo].[preguntas]    Script Date: 06/03/2016 13:58:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[preguntas](
	[idpregunta] [int] NOT NULL,
	[pregunta] [varchar](500) NOT NULL,
	[valor] [int] NOT NULL,
 CONSTRAINT [PK__pregunta__E816D0E63B75D760] PRIMARY KEY CLUSTERED 
(
	[idpregunta] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[carrera]    Script Date: 06/03/2016 13:58:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[carrera](
	[idcarrera] [varchar](3) NOT NULL,
	[nombre_carrera] [varchar](50) NULL,
 CONSTRAINT [PK_carrera] PRIMARY KEY CLUSTERED 
(
	[idcarrera] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[usuario_administrador]    Script Date: 06/03/2016 13:58:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[usuario_administrador](
	[nombre_usuario] [varchar](50) NOT NULL,
	[password] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[nombre_usuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[spinsertar_carrera]    Script Date: 06/03/2016 13:58:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[spinsertar_carrera]

@idcarrera varchar(3),
@nombre_carrera varchar(50)

as 

INSERT INTO carrera VALUES (@idcarrera,  @nombre_carrera)
GO
/****** Object:  StoredProcedure [dbo].[speliminar_usuario]    Script Date: 06/03/2016 13:58:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[speliminar_usuario]

@nombre_usuario varchar(50)

as 

delete from usuario_administrador where nombre_usuario = @nombre_usuario
GO
/****** Object:  StoredProcedure [dbo].[spinsertar_usuario]    Script Date: 06/03/2016 13:58:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spinsertar_usuario]

@nombre_usuario varchar(50),
@password varchar(20)

as 

INSERT INTO carrera VALUES (@nombre_usuario, @password)
GO
/****** Object:  StoredProcedure [dbo].[spmostrar_carrera]    Script Date: 06/03/2016 13:58:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spmostrar_carrera]

as 

select * from carrera
GO
/****** Object:  StoredProcedure [dbo].[spmostrar_preguntas]    Script Date: 06/03/2016 13:58:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spmostrar_preguntas]

as

select * from preguntas
GO
/****** Object:  StoredProcedure [dbo].[speditar_carrera]    Script Date: 06/03/2016 13:58:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[speditar_carrera]

@idcarrera int,
@nombre_carrera varchar(50)

as 

UPDATE CARRERA SET idcarrera = @idcarrera, nombre_carrera = @nombre_carrera where idcarrera = @idcarrera
GO
/****** Object:  StoredProcedure [dbo].[speditar_usuario]    Script Date: 06/03/2016 13:58:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[speditar_usuario]

@nombre_usuario varchar(50),
@password varchar(20)

as 

update usuario_administrador set nombre_usuario = @nombre_usuario, password = @password where nombre_usuario = @nombre_usuario
GO
/****** Object:  StoredProcedure [dbo].[speliminar_carrera]    Script Date: 06/03/2016 13:58:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[speliminar_carrera]

@idcarrera varchar(3)

as

delete from carrera where idcarrera = @idcarrera
GO
/****** Object:  StoredProcedure [dbo].[speliminar_preguntas]    Script Date: 06/03/2016 13:58:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[speliminar_preguntas]

@idpregunta int

as

delete  from preguntas where idpregunta = @idpregunta
GO
/****** Object:  StoredProcedure [dbo].[SPACTPREGUNTAS]    Script Date: 06/03/2016 13:58:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SPACTPREGUNTAS]
@idpregunta int,
@pregunta varchar(500),
@valor int

 AS 
 SET NOCOUNT ON
 IF @idpregunta = 0
BEGIN  
	  SELECT @idpregunta = MAX(idpregunta) FROM preguntas
	  IF @idpregunta IS NULL SET @idpregunta = 0
	  SET @idpregunta = @idpregunta + 1  
END

IF NOT EXISTS(SELECT idpregunta FROM preguntas WHERE idpregunta = @idpregunta)
	INSERT INTO preguntas(idpregunta, pregunta, valor) VALUES (@idpregunta, @pregunta, @valor)
ELSE
	UPDATE preguntas SET idpregunta = @idpregunta, pregunta = @pregunta, valor = @valor WHERE idpregunta = @idpregunta
 SELECT idpregunta, pregunta, valor FROM preguntas WHERE idpregunta = @idpregunta
GO
/****** Object:  StoredProcedure [dbo].[spbuscar_carrera_nombre]    Script Date: 06/03/2016 13:58:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[spbuscar_carrera_nombre]

@textobuscar varchar(50)

as 

select * from carrera where nombre_carrera like @textobuscar + '%'
GO
/****** Object:  StoredProcedure [dbo].[SPACTUSUARIO]    Script Date: 06/03/2016 13:58:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPACTUSUARIO]

@nombre_usuario varchar(50),
@password varchar(20)

--- cuerpo---
AS

SET NOCOUNT ON


IF NOT EXISTS(SELECT nombre_usuario FROM usuario_administrador WHERE nombre_usuario = @nombre_usuario)
	
	INSERT INTO usuario_administrador(nombre_usuario, password) VALUES (@nombre_usuario, @password);
	
ELSE 

	
	UPDATE usuario_administrador SET nombre_usuario = @nombre_usuario, password = @password WHERE nombre_usuario = @nombre_usuario

SELECT * FROM usuario_administrador WHERE nombre_usuario = @nombre_usuario
GO
/****** Object:  StoredProcedure [dbo].[spbuscar_preguntas_nombre]    Script Date: 06/03/2016 13:58:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[spbuscar_preguntas_nombre]

@pregunta varchar(500)

as

select * from preguntas where pregunta like @pregunta + '%'
GO
/****** Object:  StoredProcedure [dbo].[spbuscar_usuario_nombre]    Script Date: 06/03/2016 13:58:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[spbuscar_usuario_nombre]

@textobuscar varchar(50)

as 

select nombre_usuario from usuario_administrador where nombre_usuario like @textobuscar + '%'
GO
/****** Object:  Table [dbo].[estudiante]    Script Date: 06/03/2016 13:58:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[estudiante](
	[matricula] [varchar](7) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[idcarrera] [varchar](3) NOT NULL,
	[tomo_examen] [bit] NULL,
 CONSTRAINT [PK__estudian__30962D14023D5A04] PRIMARY KEY CLUSTERED 
(
	[matricula] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[SPACTCARRERA]    Script Date: 06/03/2016 13:58:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SPACTCARRERA]

@idcarrera varchar(3),
@nombre_carrera varchar(50)

--- cuerpo---
AS

SET NOCOUNT ON


IF NOT EXISTS(SELECT idcarrera FROM carrera WHERE idcarrera = @idcarrera)
	
	INSERT INTO carrera(idcarrera, nombre_carrera) VALUES (@idcarrera, @nombre_carrera);
	
ELSE 

	
	UPDATE carrera SET idcarrera = @idcarrera, nombre_carrera = @nombre_carrera WHERE idcarrera = @idcarrera

SELECT * FROM carrera WHERE idcarrera = @idcarrera
GO
/****** Object:  Table [dbo].[respuestas]    Script Date: 06/03/2016 13:58:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[respuestas](
	[idrespuesta] [int] NOT NULL,
	[idpregunta] [int] NOT NULL,
	[respuesta] [varchar](500) NOT NULL,
	[iscorrect] [bit] NOT NULL,
 CONSTRAINT [PK__respuest__34C520FD37A5467C] PRIMARY KEY CLUSTERED 
(
	[idrespuesta] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[spmostrar_usuario]    Script Date: 06/03/2016 13:58:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[spmostrar_usuario]

as 

select * from usuario_administrador
GO
/****** Object:  StoredProcedure [dbo].[SPACTESTUDIANTE]    Script Date: 06/03/2016 13:58:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SPACTESTUDIANTE]

@matricula varchar(7),
@nombre varchar(50),
@idcarrera varchar(3),
@tomoexamen bit

--- cuerpo---
AS

SET NOCOUNT ON


IF NOT EXISTS(SELECT matricula FROM estudiante WHERE matricula = @matricula)
	
	INSERT INTO estudiante(matricula, nombre, idcarrera, tomo_examen) VALUES (@matricula, @nombre, @idcarrera, @tomoexamen);
	
ELSE 

	UPDATE estudiante SET matricula = matricula, nombre = @nombre, idcarrera = @idcarrera WHERE matricula = matricula

SELECT * FROM estudiante WHERE matricula = @matricula
GO
/****** Object:  StoredProcedure [dbo].[SPMOSTRAR_RESPUESTAS]    Script Date: 06/03/2016 13:58:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SPMOSTRAR_RESPUESTAS]



as

select * from respuestas
GO
/****** Object:  StoredProcedure [dbo].[SPMOSTRAR_PREGUNTAS_RESPUESTAS]    Script Date: 06/03/2016 13:58:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SPMOSTRAR_PREGUNTAS_RESPUESTAS]

@pregunta varchar(500)

as 

select preguntas.idpregunta, preguntas.pregunta, respuestas.idrespuesta, respuestas.respuesta, preguntas.valor, respuestas.iscorrect from preguntas 
inner join respuestas on preguntas.idpregunta = respuestas.idpregunta
where preguntas.pregunta like @pregunta + '%'
GO
/****** Object:  Table [dbo].[examen]    Script Date: 06/03/2016 13:58:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[examen](
	[idexamen] [int] IDENTITY(1,1) NOT NULL,
	[matricula] [varchar](7) NOT NULL,
	[calificacion] [int] NOT NULL,
	[fecha] [date] NOT NULL,
	[calificacion_letra] [char](1) NOT NULL,
 CONSTRAINT [PK__examen__CCA25DB96754599E] PRIMARY KEY CLUSTERED 
(
	[idexamen] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[spbuscar_respuestas_nombre]    Script Date: 06/03/2016 13:58:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spbuscar_respuestas_nombre]

@textobuscar varchar(500)

as

select * from respuestas where respuesta like @textobuscar + '%'
GO
/****** Object:  StoredProcedure [dbo].[spbuscar_estudiante_nombre]    Script Date: 06/03/2016 13:58:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[spbuscar_estudiante_nombre]

@textobuscar varchar(50)

as

select * from estudiante where nombre like @textobuscar + '%'
GO
/****** Object:  StoredProcedure [dbo].[SPACTRESPUESTAS]    Script Date: 06/03/2016 13:58:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SPACTRESPUESTAS]
@idrespuesta int,
@idpregunta int,
@respuesta varchar(500),
@iscorrect bit

 AS 
 SET NOCOUNT ON
 IF @idrespuesta = 0
BEGIN  
	  SELECT @idrespuesta = MAX(idrespuesta) FROM respuestas
	  IF @idrespuesta IS NULL SET @idrespuesta = 0
	  SET @idrespuesta = @idrespuesta + 1  
END

IF NOT EXISTS(SELECT idrespuesta FROM respuestas WHERE idrespuesta = @idrespuesta)
	INSERT INTO respuestas(idrespuesta, idpregunta, respuesta, iscorrect) VALUES (@idrespuesta, @idpregunta, @respuesta, @iscorrect)
ELSE
	UPDATE respuestas SET idrespuesta = @idrespuesta, idpregunta = @idpregunta, respuesta = @respuesta, iscorrect = @iscorrect WHERE idrespuesta = @idrespuesta
 SELECT idrespuesta, idpregunta, respuesta, iscorrect FROM respuestas WHERE idrespuesta = @idrespuesta
GO
/****** Object:  StoredProcedure [dbo].[speliminar_estudiante]    Script Date: 06/03/2016 13:58:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[speliminar_estudiante]

@matricula varchar(7)

as

delete from estudiante where matricula = @matricula
GO
/****** Object:  StoredProcedure [dbo].[SPEDITARRESPUESTA]    Script Date: 06/03/2016 13:58:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCeDURE [dbo].[SPEDITARRESPUESTA]

@idrespuesta int,
@idpregunta int,
@respuesta varchar(500)

AS

	UPDATE respuestas SET idpregunta = @idpregunta, respuesta = @respuesta


SELECT * FROM respuestas WHERE idrespuesta = @idrespuesta
GO
/****** Object:  StoredProcedure [dbo].[speditar_estudiante]    Script Date: 06/03/2016 13:58:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[speditar_estudiante]

@matricula varchar(7),
@nombre varchar(50),
@idcarrera varchar(3)


as

update estudiante set matricula = @matricula, nombre = @nombre, idcarrera =  @idcarrera where matricula = @matricula
GO
/****** Object:  StoredProcedure [dbo].[spmostrar_estudiante]    Script Date: 06/03/2016 13:58:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spmostrar_estudiante]

as

select * from estudiante
GO
/****** Object:  StoredProcedure [dbo].[SPINSERTARRESPUESTAS]    Script Date: 06/03/2016 13:58:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCeDURE [dbo].[SPINSERTARRESPUESTAS]

@idpregunta int,
@respuesta varchar(500)

AS

	INSERT INTO respuestas(idpregunta,respuesta) VALUES (@idpregunta, @respuesta);
GO
/****** Object:  StoredProcedure [dbo].[spinsertar_estudiante]    Script Date: 06/03/2016 13:58:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spinsertar_estudiante]

@matricula varchar(7),
@nombre varchar(50),
@idcarrera varchar(3),
@tomo_examen bit

as

insert into estudiante values (@matricula, @nombre, @idcarrera, @tomo_examen)
GO
/****** Object:  StoredProcedure [dbo].[SPELIMINAR_RESPUESTA]    Script Date: 06/03/2016 13:58:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SPELIMINAR_RESPUESTA]

@idrespuesta int

as

delete from respuestas where idrespuesta = @idrespuesta
GO
/****** Object:  StoredProcedure [dbo].[sptomar_examen]    Script Date: 06/03/2016 13:58:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sptomar_examen]

@matricula varchar(7)

as

update estudiante set tomo_examen = 1 where matricula = @matricula
GO
/****** Object:  StoredProcedure [dbo].[sptodos_datos_examen]    Script Date: 06/03/2016 13:58:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sptodos_datos_examen]

@matricula varchar(7)

as

select estudiante.matricula, estudiante.nombre, carrera.nombre_carrera,
		examen.idexamen, examen.calificacion, examen.fecha, examen.calificacion_letra
		
from estudiante inner join carrera on estudiante.idcarrera = carrera.idcarrera
inner join examen on estudiante.matricula = examen.matricula

where estudiante.matricula = @matricula
GO
/****** Object:  StoredProcedure [dbo].[spcontar_calificaciones]    Script Date: 06/03/2016 13:58:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spcontar_calificaciones]

as

select COUNT(*) as cantidad, calificacion_letra from examen group by calificacion_letra
GO
/****** Object:  StoredProcedure [dbo].[SPACTEXAMEN]    Script Date: 06/03/2016 13:58:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SPACTEXAMEN]

@matricula varchar(7),
@calificacion int,
@calificacion_letra char(1)

as

insert into examen(matricula,calificacion, fecha, calificacion_letra) values (@matricula,@calificacion, GETDATE(), @calificacion_letra)
GO
/****** Object:  ForeignKey [FK__estudiant__idcar__0425A276]    Script Date: 06/03/2016 13:58:37 ******/
ALTER TABLE [dbo].[estudiante]  WITH CHECK ADD  CONSTRAINT [FK__estudiant__idcar__0425A276] FOREIGN KEY([idcarrera])
REFERENCES [dbo].[carrera] ([idcarrera])
GO
ALTER TABLE [dbo].[estudiante] CHECK CONSTRAINT [FK__estudiant__idcar__0425A276]
GO
/****** Object:  ForeignKey [FK__respuesta__idpre__403A8C7D]    Script Date: 06/03/2016 13:58:37 ******/
ALTER TABLE [dbo].[respuestas]  WITH CHECK ADD  CONSTRAINT [FK__respuesta__idpre__403A8C7D] FOREIGN KEY([idpregunta])
REFERENCES [dbo].[preguntas] ([idpregunta])
GO
ALTER TABLE [dbo].[respuestas] CHECK CONSTRAINT [FK__respuesta__idpre__403A8C7D]
GO
/****** Object:  ForeignKey [FK__examen__matricul__693CA210]    Script Date: 06/03/2016 13:58:37 ******/
ALTER TABLE [dbo].[examen]  WITH CHECK ADD  CONSTRAINT [FK__examen__matricul__693CA210] FOREIGN KEY([matricula])
REFERENCES [dbo].[estudiante] ([matricula])
GO
ALTER TABLE [dbo].[examen] CHECK CONSTRAINT [FK__examen__matricul__693CA210]
GO
