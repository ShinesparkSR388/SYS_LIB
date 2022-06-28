/*
 Source Server Type    : SQL Server
 Source Catalog        : DB_SYS
 Source Schema         : dbo
 Date: 16/06/2022 15:51:11
*/

----------------------------
--***FOREIGN KEY TABLES***--
----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[OUTPUTS]') AND type IN ('U','PK','F'))
	DROP TABLE [dbo].[OUTPUTS]
GO

IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[STOCK]') AND type IN ('U','PK','F'))
	DROP TABLE [dbo].[STOCK]
GO

IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[INPUTS]') AND type IN ('U','PK','F'))
	DROP TABLE [dbo].[INPUTS]
GO

IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[PRODUCTS]') AND type IN ('U','PK','F'))
	DROP TABLE [dbo].[PRODUCTS]
GO
-- ----------------------------
-- Table structure for PROVIDER
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[PROVIDER]') AND type IN ('U','PK','F'))
	DROP TABLE [dbo].[PROVIDER]
GO

CREATE TABLE [dbo].[PROVIDER] (
  [IdProveedor] int primary key IDENTITY(1,1) NOT NULL,
  [Tipo] int NOT NULL default(0),
  [Descripcion] varchar(100) COLLATE Modern_Spanish_CI_AS  NULL,
  [Dui] numeric(18,0) default (0),
  [Nit] numeric(18,0) default (0),
  [FechaRegistro] varchar(100) DEFAULT getdate() NULL
)
GO

ALTER TABLE [dbo].[PROVIDER] SET (LOCK_ESCALATION = TABLE)
GO
-- ----------------------------
-- Table structure for PRODUCTS
-- ----------------------------

CREATE TABLE [dbo].[PRODUCTS] (
  [IdProducto] int primary key IDENTITY(1,1) NOT NULL,
  [Descripcion] varchar(100) COLLATE Modern_Spanish_CI_AS  NOT NULL,
  [IdProveedor] int foreign key references PROVIDER(IdProveedor) NOT NULL,
  [UnidadPaquete] int NOT NULL default(0),
  [PrecioPaquete] float (30) NOT NULL DEFAULT (0),
  [FechaRegistro] varchar(100) DEFAULT getdate() NOT NULL
)
GO

ALTER TABLE [dbo].[PRODUCTS] SET (LOCK_ESCALATION = TABLE)
GO
-- ----------------------------
-- Table structure for STOCK
-- ----------------------------

CREATE TABLE [dbo].[STOCK] (
  [IdItem] int primary key IDENTITY(1,1) NOT NULL,
  [IdProducto] int foreign key references PRODUCTS(IdProducto),
  [Descripcion] varchar (100),
  [Unidades] int NOT NULL default (0),
  [Paquetes] int NOT NULL,
  [UnidadPaquete] int NOT NULL,
  [PrecioPaquete] float (30) DEFAULT (0),
  [FechaRegistro] varchar(100) DEFAULT getdate() NOT NULL
)
GO

ALTER TABLE [dbo].[STOCK] SET (LOCK_ESCALATION = TABLE)
GO

-- ----------------------------
-- Table structure for INPUTS
-- ----------------------------

CREATE TABLE [dbo].[INPUTS] (
  [IdEntrada] int primary key IDENTITY(1,1) NOT NULL,
  [IdProveedor] int foreign key references PROVIDER(IdProveedor),
  [IdProducto] int foreign key references PRODUCTS(IdProducto),
  [Descripcion] varchar(100) COLLATE Modern_Spanish_CI_AS NOT NULL default(0),
  [Paquetes] int NOT NULL,
  [UnidadPaquete] int NOT NULL,
  [PrecioPaquete] float (30) default(0),
  [PrecioTotal] float (30) default(0),
  [FechaRegistro] varchar(100) DEFAULT getdate() NULL
)
GO

ALTER TABLE [dbo].[INPUTS] SET (LOCK_ESCALATION = TABLE)
GO
-- ----------------------------
-- Table structure for OUTPUTS
-- ----------------------------

CREATE TABLE [dbo].[OUTPUTS] (
  [IdVenta] int primary key IDENTITY(1,1) NOT NULL,
  [IdProducto] int foreign key references PRODUCTS(IdProducto),
  [Descripcion] varchar(100) COLLATE Modern_Spanish_CI_AS NULL,
  [Unidades] int NOT NULL default(0),
  [Cajas] int NOT NULL default(0),
  [PrecioTotal] float (30) default(0),
  [FechaRegistro] varchar(100) DEFAULT getdate() NULL
)
GO

ALTER TABLE [dbo].[OUTPUTS] SET (LOCK_ESCALATION = TABLE)
GO
-- ----------------------------
-- Table structure for LOGS
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[LOGS]') AND type IN ('U','PK','F'))
	DROP TABLE [dbo].[LOGS]
GO

CREATE TABLE [dbo].[LOGS] (
  [Nlog] int primary key IDENTITY(1,1) NOT NULL,
  [Descripcion] varchar(100) COLLATE Modern_Spanish_CI_AS  NULL,
  [FechaRegistro] datetime DEFAULT getdate() NULL
)
GO

ALTER TABLE [dbo].[LOGS] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for USERS
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[USERS]') AND type IN ('U','PK','F'))
	DROP TABLE [dbo].[USERS]
GO

CREATE TABLE [dbo].[USERS] (
  [IdUsuario] int IDENTITY(1,1) NOT NULL,
  [Tipo] int NULL,
  [User] varchar(100) COLLATE Modern_Spanish_CI_AS  NULL,
  [Clave] varchar(60) COLLATE Modern_Spanish_CI_AS  NULL,
)
GO

ALTER TABLE [dbo].[USERS] SET (LOCK_ESCALATION = TABLE)
GO
