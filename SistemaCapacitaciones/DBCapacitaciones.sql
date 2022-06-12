/*
 Navicat Premium Data Transfer

 Source Server         : conexionsqlserver
 Source Server Type    : SQL Server
 Source Server Version : 14002037
 Source Host           : LAPTOP-E:1433
 Source Catalog        : DBCapacitaciones
 Source Schema         : dbo

 Target Server Type    : SQL Server
 Target Server Version : 14002037
 File Encoding         : 65001

 Date: 05/06/2022 21:53:57
*/


-- ----------------------------
-- Table structure for Area
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Area]') AND type IN ('U'))
	DROP TABLE [dbo].[Area]
GO

CREATE TABLE [dbo].[Area] (
  [IdArea] int  NOT NULL,
  [Area] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [Descripcion] varchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL
)
GO

ALTER TABLE [dbo].[Area] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of Area
-- ----------------------------
INSERT INTO [dbo].[Area] ([IdArea], [Area], [Descripcion]) VALUES (N'1', N'Administrador', N'Area de administraciones')
GO

INSERT INTO [dbo].[Area] ([IdArea], [Area], [Descripcion]) VALUES (N'2', N'Misiones', N'Area de misiones')
GO

INSERT INTO [dbo].[Area] ([IdArea], [Area], [Descripcion]) VALUES (N'3', N'Capacitaciones', N'Area de capacitaciones')
GO


-- ----------------------------
-- Table structure for Cargo
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Cargo]') AND type IN ('U'))
	DROP TABLE [dbo].[Cargo]
GO

CREATE TABLE [dbo].[Cargo] (
  [IdCargo] int  NOT NULL,
  [Cargo] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [Descripcion] varchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL
)
GO

ALTER TABLE [dbo].[Cargo] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of Cargo
-- ----------------------------
INSERT INTO [dbo].[Cargo] ([IdCargo], [Cargo], [Descripcion]) VALUES (N'1', N'Administrador', N'Administrador de sistemas')
GO

INSERT INTO [dbo].[Cargo] ([IdCargo], [Cargo], [Descripcion]) VALUES (N'2', N'Encargado', N'Encargado de dicha area')
GO

INSERT INTO [dbo].[Cargo] ([IdCargo], [Cargo], [Descripcion]) VALUES (N'3', N'Equipo', N'Parte de dicha area')
GO


-- ----------------------------
-- Table structure for Empleados
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Empleados]') AND type IN ('U'))
	DROP TABLE [dbo].[Empleados]
GO

CREATE TABLE [dbo].[Empleados] (
  [IdEmpleado] int  NOT NULL,
  [IdArea] int  NOT NULL,
  [IdCargo] int  NOT NULL,
  [Nombre] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [Apellido] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [Direccion] varchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [Fechanacimiento] date  NOT NULL,
  [NumCelular] varchar(9) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [DUI] varchar(10) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [NIT] varchar(17) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL
)
GO

ALTER TABLE [dbo].[Empleados] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of Empleados
-- ----------------------------
INSERT INTO [dbo].[Empleados] ([IdEmpleado], [IdArea], [IdCargo], [Nombre], [Apellido], [Direccion], [Fechanacimiento], [NumCelular], [DUI], [NIT]) VALUES (N'1', N'1', N'1', N'Edgar Antonio', N'Campos Zelaya', N'San Jorge', N'2000-10-14', N'1242-6467', N'13432365-7', N'1213-343142-231-1')
GO

INSERT INTO [dbo].[Empleados] ([IdEmpleado], [IdArea], [IdCargo], [Nombre], [Apellido], [Direccion], [Fechanacimiento], [NumCelular], [DUI], [NIT]) VALUES (N'2', N'2', N'2', N'Moises Abraham', N'Viera Viera', N'San Miguel', N'2000-07-22', N'1313-1763', N'45235656-3', N'123-220700-232-4')
GO

INSERT INTO [dbo].[Empleados] ([IdEmpleado], [IdArea], [IdCargo], [Nombre], [Apellido], [Direccion], [Fechanacimiento], [NumCelular], [DUI], [NIT]) VALUES (N'3', N'3', N'3', N'Leidy Yajaira', N'Hernandez Vasquez', N'San Miguel', N'2000-12-21', N'4657-8688', N'25327834-9', N'132-211200-389-2')
GO


-- ----------------------------
-- Table structure for Usuario
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Usuario]') AND type IN ('U'))
	DROP TABLE [dbo].[Usuario]
GO

CREATE TABLE [dbo].[Usuario] (
  [IdUsuario] int  IDENTITY(1,1) NOT NULL,
  [IdEmpleado] int  NOT NULL,
  [Usuario] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [Contraseña] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL
)
GO

ALTER TABLE [dbo].[Usuario] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of Usuario
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Usuario] ON
GO

INSERT INTO [dbo].[Usuario] ([IdUsuario], [IdEmpleado], [Usuario], [Contraseña]) VALUES (N'1', N'1', N'admin', N'admin')
GO

INSERT INTO [dbo].[Usuario] ([IdUsuario], [IdEmpleado], [Usuario], [Contraseña]) VALUES (N'2', N'2', N'moi01', N'1234')
GO

INSERT INTO [dbo].[Usuario] ([IdUsuario], [IdEmpleado], [Usuario], [Contraseña]) VALUES (N'3', N'3', N'lei1', N'1234')
GO

SET IDENTITY_INSERT [dbo].[Usuario] OFF
GO


-- ----------------------------
-- procedure structure for logueo
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[logueo]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[logueo]
GO

CREATE PROCEDURE [dbo].[logueo]
@usuario varchar(20),
@clave varchar(20)
AS
BEGIN
select Area.IdArea, Empleados.Nombre, Usuario.Usuario, Usuario.Contraseña 
from Empleados INNER JOIN Area ON Area.IdArea = Empleados.IdEmpleado
INNER JOIN Usuario ON Usuario.IdUsuario = Empleados.IdEmpleado
where usuario=@usuario and contraseña=@clave
END
GO


-- ----------------------------
-- procedure structure for ListarIdEmpleado
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[ListarIdEmpleado]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[ListarIdEmpleado]
GO

CREATE PROCEDURE [dbo].[ListarIdEmpleado]
AS
BEGIN
	SELECT * FROM Empleados 
END
GO


-- ----------------------------
-- procedure structure for AddUsuario
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[AddUsuario]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[AddUsuario]
GO

CREATE PROCEDURE [dbo].[AddUsuario]
@IdEmpleado INT,
@Usuario VARCHAR(20),
@Pass VARCHAR(20)
AS
BEGIN
	INSERT INTO Usuario (IdEmpleado, Usuario, Contraseña) VALUES (@IdEmpleado, @Usuario, @Pass)
END
GO


-- ----------------------------
-- procedure structure for ListarUsuarios
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[ListarUsuarios]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[ListarUsuarios]
GO

CREATE PROCEDURE [dbo].[ListarUsuarios]
AS
BEGIN
	Select IdUsuario, Empleados.IdEmpleado, Empleados.Nombre, Usuario, Contraseña 
from Usuario
INNER JOIN Empleados ON Usuario.IdEmpleado=Empleados.IdEmpleado
END
GO


-- ----------------------------
-- procedure structure for UpUsuario
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[UpUsuario]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[UpUsuario]
GO

CREATE PROCEDURE [dbo].[UpUsuario]
@IdUsuario INT,
@IdEmpleado INT,
@Usuario VARCHAR(20),
@Pass VARCHAR(20)
AS
BEGIN
	UPDATE Usuario set IdEmpleado=@IdEmpleado, Usuario=@Usuario, Contraseña=@Pass WHERE IdUsuario=@IdUsuario
END
GO


-- ----------------------------
-- procedure structure for KillUsuario
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[KillUsuario]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[KillUsuario]
GO

CREATE PROCEDURE [dbo].[KillUsuario]
@IdUsuario INT
AS
BEGIN
	DELETE Usuario WHERE IdUsuario=@IdUsuario
END
GO


-- ----------------------------
-- Primary Key structure for table Area
-- ----------------------------
ALTER TABLE [dbo].[Area] ADD CONSTRAINT [PK__Area__2FC141AABC92514A] PRIMARY KEY CLUSTERED ([IdArea])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table Cargo
-- ----------------------------
ALTER TABLE [dbo].[Cargo] ADD CONSTRAINT [PK__Cargo__6C9856253194F7D6] PRIMARY KEY CLUSTERED ([IdCargo])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table Empleados
-- ----------------------------
ALTER TABLE [dbo].[Empleados] ADD CONSTRAINT [PK__Empleado__CE6D8B9E923C3A9C] PRIMARY KEY CLUSTERED ([IdEmpleado])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for Usuario
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[Usuario]', RESEED, 9)
GO


-- ----------------------------
-- Primary Key structure for table Usuario
-- ----------------------------
ALTER TABLE [dbo].[Usuario] ADD CONSTRAINT [PK__Usuario__5B65BF97A0CA010A] PRIMARY KEY CLUSTERED ([IdUsuario])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Foreign Keys structure for table Empleados
-- ----------------------------
ALTER TABLE [dbo].[Empleados] ADD CONSTRAINT [IdArea] FOREIGN KEY ([IdArea]) REFERENCES [dbo].[Area] ([IdArea]) ON DELETE CASCADE ON UPDATE CASCADE
GO

ALTER TABLE [dbo].[Empleados] ADD CONSTRAINT [IdCargo] FOREIGN KEY ([IdCargo]) REFERENCES [dbo].[Cargo] ([IdCargo]) ON DELETE CASCADE ON UPDATE CASCADE
GO


-- ----------------------------
-- Foreign Keys structure for table Usuario
-- ----------------------------
ALTER TABLE [dbo].[Usuario] ADD CONSTRAINT [IdEmpleado] FOREIGN KEY ([IdEmpleado]) REFERENCES [dbo].[Empleados] ([IdEmpleado]) ON DELETE CASCADE ON UPDATE CASCADE
GO

