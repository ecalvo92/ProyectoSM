USE [master]
GO

CREATE DATABASE [SM_DB]
GO

USE [SM_DB]
GO

CREATE TABLE [dbo].[Usuario](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Identificacion] [varchar](15) NOT NULL,
	[Contrasenna] [varchar](15) NOT NULL,
	[Nombre] [varchar](250) NOT NULL,
	[Correo] [varchar](100) NOT NULL,
	[Estado] [bit] NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

SET IDENTITY_INSERT [dbo].[Usuario] ON 
GO
INSERT [dbo].[Usuario] ([Id], [Identificacion], [Contrasenna], [Nombre], [Correo], [Estado]) VALUES (1, N'304590415', N'90415', N'Eduardo Calvo Castillo', N'ecalvo90415@ufide.ac.cr', 1)
GO
INSERT [dbo].[Usuario] ([Id], [Identificacion], [Contrasenna], [Nombre], [Correo], [Estado]) VALUES (2, N'304590416', N'90416', N'Eduardo Calvo Castillo', N'ecalvo90416@ufide.ac.cr', 1)
GO
SET IDENTITY_INSERT [dbo].[Usuario] OFF
GO

CREATE PROCEDURE [dbo].[IniciarSesion]
	@Identificacion varchar(15),
	@Contrasenna varchar(15)
AS
BEGIN

	SELECT	Id,Identificacion,Nombre,Correo,Estado
	FROM	dbo.Usuario
	WHERE	Identificacion = @Identificacion
		AND Contrasenna = @Contrasenna
		AND Estado = 1
	
END
GO

CREATE PROCEDURE [dbo].[RegistrarCuenta]
	@Identificacion varchar(15),
	@Contrasenna varchar(15),
	@Nombre varchar(250),
	@Correo varchar(100)
AS
BEGIN
	
	INSERT INTO dbo.Usuario (Identificacion,Contrasenna,Nombre,Correo,Estado)
	VALUES (@Identificacion,@Contrasenna,@Nombre,@Correo,1)

END
GO