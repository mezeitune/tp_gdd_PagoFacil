--SELECT * FROM GD2C2017.INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE'
--use GD2C2017;
--select * from gd_esquema.Maestra;

USE [GD2C2017]
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON

GO
if exists (select * from dbo.sysobjects where id =
object_id(N'[SERVOMOTOR].[cambiarTotalDelasFacturasPorModificacionItem]') and OBJECTPROPERTY(id, N'IsTrigger') = 1)
drop trigger [SERVOMOTOR].[cambiarTotalDelasFacturasPorModificacionItem]


GO
if exists (select * from dbo.sysobjects where id =
object_id(N'[SERVOMOTOR].[FUNCIONES_ROLES]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [SERVOMOTOR].[FUNCIONES_ROLES]

GO
if exists (select * from dbo.sysobjects where id =
object_id(N'[SERVOMOTOR].[FUNCIONALIDADES]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [SERVOMOTOR].[FUNCIONALIDADES]

GO
if exists (select * from dbo.sysobjects where id =
object_id(N'[SERVOMOTOR].[ROLES_USUARIOS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [SERVOMOTOR].[ROLES_USUARIOS]

GO
if exists (select * from dbo.sysobjects where id =
object_id(N'[SERVOMOTOR].[ROLES]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [SERVOMOTOR].[ROLES]

GO
if exists (select * from dbo.sysobjects where id =
object_id(N'[SERVOMOTOR].[FACTURAS_DEVOLUCIONES]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [SERVOMOTOR].[FACTURAS_DEVOLUCIONES]


GO
if exists (select * from dbo.sysobjects where id =
object_id(N'[SERVOMOTOR].[SUCURSALES_USUARIOS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [SERVOMOTOR].[SUCURSALES_USUARIOS]



GO
if exists (select * from dbo.sysobjects where id =
object_id(N'[SERVOMOTOR].[USUARIOS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [SERVOMOTOR].[USUARIOS]


GO
if exists (select * from dbo.sysobjects where id =
object_id(N'[SERVOMOTOR].[ITEMS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [SERVOMOTOR].[ITEMS]




GO
if exists (select * from dbo.sysobjects where id =
object_id(N'[SERVOMOTOR].[FACTURAS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [SERVOMOTOR].[FACTURAS]

GO
if exists (select * from dbo.sysobjects where id =
object_id(N'[SERVOMOTOR].[RENDICIONES]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [SERVOMOTOR].[RENDICIONES]

GO
if exists (select * from dbo.sysobjects where id =
object_id(N'[SERVOMOTOR].[PAGOS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [SERVOMOTOR].[PAGOS]


GO
if exists (select * from dbo.sysobjects where id =
object_id(N'[SERVOMOTOR].[EMPRESAS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [SERVOMOTOR].[EMPRESAS]


GO
if exists (select * from dbo.sysobjects where id =
object_id(N'[SERVOMOTOR].[CLIENTES]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [SERVOMOTOR].[CLIENTES]





GO
if exists (select * from dbo.sysobjects where id =
object_id(N'[SERVOMOTOR].[MEDIOS_DE_PAGO]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [SERVOMOTOR].[MEDIOS_DE_PAGO]




GO
if exists (select * from dbo.sysobjects where id =
object_id(N'[SERVOMOTOR].[SUCURSALES]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [SERVOMOTOR].[SUCURSALES]



GO
if exists (select * from dbo.sysobjects where id =
object_id(N'[SERVOMOTOR].[RUBROS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [SERVOMOTOR].[RUBROS]

GO
if exists (select * from dbo.sysobjects where id =
object_id(N'[SERVOMOTOR].[DEVOLUCIONES]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [SERVOMOTOR].[DEVOLUCIONES]



GO
if exists (select * from dbo.sysobjects where id =
object_id(N'[SERVOMOTOR].[obtenerFechaDeHoy]') AND type in (N'FN', N'IF',N'TF', N'FS', N'FT'))
drop function [SERVOMOTOR].[obtenerFechaDeHoy]



GO
if exists (select * from dbo.sysobjects where id =
object_id(N'[SERVOMOTOR].[crearTablaFecha]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [SERVOMOTOR].[crearTablaFecha]

GO
if exists (select * from dbo.sysobjects where id =
object_id(N'[SERVOMOTOR].[FECHA]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [SERVOMOTOR].[FECHA]


GO
if exists (select * from dbo.sysobjects where id =
object_id(N'[SERVOMOTOR].[EncriptarSHA1]') AND type in (N'FN', N'IF',N'TF', N'FS', N'FT'))
drop function [SERVOMOTOR].[EncriptarSHA1]

GO
if exists (select * from dbo.sysobjects where id =
object_id(N'[SERVOMOTOR].[datetime_is_between]') AND type in (N'FN', N'IF',N'TF', N'FS', N'FT'))
drop function [SERVOMOTOR].[datetime_is_between]

GO
if exists (select * from dbo.sysobjects where id =
object_id(N'[SERVOMOTOR].[datetime_between]') AND type in (N'FN', N'IF',N'TF', N'FS', N'FT'))
drop function [SERVOMOTOR].[datetime_between]




GO
if exists (select * from dbo.sysobjects where id =
object_id(N'[SERVOMOTOR].[LoginAdministrador]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [SERVOMOTOR].[LoginAdministrador]

GO
if exists (select * from dbo.sysobjects where id =
object_id(N'[SERVOMOTOR].[AgregarFuncionalidadARol]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [SERVOMOTOR].[AgregarFuncionalidadARol]

GO
IF  EXISTS (SELECT * FROM sys.schemas WHERE name = N'SERVOMOTOR')
DROP SCHEMA [SERVOMOTOR]
GO

CREATE SCHEMA [SERVOMOTOR] AUTHORIZATION [gd]
GO

--//////////////////////////////////////////////



--//////////// Creacion de tablas //////////////

--Rol: Si el estado es 0, se encuentra inactivo, si es 1 activo.
--Esta tabla contiene código, nombre y estado del rol (activo/inactivo)
CREATE TABLE [SERVOMOTOR].[ROLES](
	[ID_ROL] [tinyint] IDENTITY,
	[NOMBRE] [varchar](30) UNIQUE NOT NULL, 
	[ESTADO] [bit] DEFAULT 1,
 CONSTRAINT [PK_ROLES] PRIMARY KEY CLUSTERED 
(
	[ID_ROL] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

GO


--Tabla Funcionalidad: Contiene los códigos, nombres de cada funcionalidad. 
CREATE TABLE [SERVOMOTOR].[FUNCIONALIDADES](
	[ID_FUNC] [tinyint] IDENTITY,
	[NOMBRE] [varchar] (60) UNIQUE NOT NULL,
CONSTRAINT [PK_FUNCIONALIDADES] PRIMARY KEY CLUSTERED 
(
	[ID_FUNC] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

GO


--Tabla Funciones por rol: Contiene las funcionalidades habilitadas para cada rol del sistema.
CREATE TABLE [SERVOMOTOR].[FUNCIONES_ROLES](
	[ID_ROL] [tinyint] NOT NULL,
	[ID_FUNC] [tinyint] NOT NULL,
 CONSTRAINT [PK_FUNCIONES_ROLES] PRIMARY KEY CLUSTERED 
(
	[ID_ROL] ASC,
	[ID_FUNC] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

GO


ALTER TABLE [SERVOMOTOR].[FUNCIONES_ROLES]  WITH CHECK ADD  CONSTRAINT [FK_FUNCIONES_ROLES_ROLES] FOREIGN KEY([ID_ROL])
REFERENCES [SERVOMOTOR].[ROLES] ([ID_ROL])

GO

ALTER TABLE [SERVOMOTOR].[FUNCIONES_ROLES]  WITH CHECK ADD  CONSTRAINT [FK_FUNCIONES_ROLES_FUNCIONALIDADES] FOREIGN KEY([ID_FUNC])
REFERENCES [SERVOMOTOR].[FUNCIONALIDADES] ([ID_FUNC])

GO

-- Tabla Sucursales: 
CREATE TABLE [SERVOMOTOR].[SUCURSALES](
	[COD_POSTAL] [varchar] (20) NOT NULL,
	[NOMBRE] [varchar] (50) UNIQUE NOT NULL,
	[DIRECCION] [varchar] (50) UNIQUE,
	[ESTADO_HABILITACION] [bit] DEFAULT 1,
 CONSTRAINT [PK_SUCURSALES] PRIMARY KEY CLUSTERED 
(
	[COD_POSTAL] 
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

GO
-- Tabla Usuarios: 
CREATE TABLE [SERVOMOTOR].[USUARIOS](
	[ID_USUARIO] [tinyint] IDENTITY,
	[USERNAME] [varchar] (20) UNIQUE,
	[PASSWORD] [varchar] (70) NOT NULL,
	[HABILITADO] [bit] DEFAULT 1,
	[CANT_INT_FALL] [tinyint] DEFAULT 0,
 CONSTRAINT [PK_USUARIOS] PRIMARY KEY CLUSTERED 
(
	[ID_USUARIO] 
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]


GO

--Tabla roles por usuario: tiene los roles para cada usuario del sistema
CREATE TABLE [SERVOMOTOR].[ROLES_USUARIOS](
	[ID_ROL] [tinyint] NOT NULL,
	[ID_USUARIO] [tinyint] NOT NULL,
	-- [ESTADO] [bit] DEFAULT 1,
 CONSTRAINT [PK_ROLES_USUARIOS] PRIMARY KEY CLUSTERED 
(
	[ID_ROL] ASC,
	[ID_USUARIO] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

GO


ALTER TABLE [SERVOMOTOR].[ROLES_USUARIOS]  WITH CHECK ADD  CONSTRAINT [FK_ROLES_USUARIOS_ROL] FOREIGN KEY([ID_ROL])
REFERENCES [SERVOMOTOR].[ROLES] ([ID_ROL])

GO

ALTER TABLE [SERVOMOTOR].[ROLES_USUARIOS]  WITH CHECK ADD  CONSTRAINT [FK_ROLES_USUARIOS_USUARIO] FOREIGN KEY([ID_USUARIO])
REFERENCES [SERVOMOTOR].[USUARIOS] ([ID_USUARIO])


--Tabla roles por SUCURSALES: tiene los SUCURSALES PARA CADA USUARIO
CREATE TABLE [SERVOMOTOR].[SUCURSALES_USUARIOS](
	[ID_USUARIO] [tinyint] NOT NULL,
	[COD_POSTAL] [varchar](20) NOT NULL,
 CONSTRAINT [PK_SUCURSALES_USUARIOS] PRIMARY KEY CLUSTERED 
(
	[ID_USUARIO] ASC,
	[COD_POSTAL] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

GO


ALTER TABLE [SERVOMOTOR].[SUCURSALES_USUARIOS]  WITH CHECK ADD  CONSTRAINT [FK_SUCURSALES_USUARIOS_USUARIO] FOREIGN KEY([ID_USUARIO])
REFERENCES [SERVOMOTOR].[USUARIOS] ([ID_USUARIO])

GO

ALTER TABLE [SERVOMOTOR].[SUCURSALES_USUARIOS]  WITH CHECK ADD  CONSTRAINT [FK_SUCURSALES_USUARIOS_SUCURSAL] FOREIGN KEY([COD_POSTAL])
REFERENCES [SERVOMOTOR].[SUCURSALES] ([COD_POSTAL])
-- Tabla RUBROS: 
CREATE TABLE [SERVOMOTOR].[RUBROS](
	[ID_RUBRO] [tinyint] IDENTITY,
	[DESCRIPCION] [varchar] (20) UNIQUE,
 CONSTRAINT [PK_RUBROS] PRIMARY KEY CLUSTERED 
(
	[ID_RUBRO] 
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]


-- Tabla EMPRESAS: 
CREATE TABLE [SERVOMOTOR].[EMPRESAS](
	[CUIT] [varchar] (50) NOT NULL,
	[NOMBRE] [varchar] (255) NOT NULL,
	[DIRECCION] [varchar] (255) NOT NULL,
	[ID_RUBRO] [tinyint] ,
	[ESTADO_ACTIVACION] [bit] DEFAULT 1,
 CONSTRAINT [PK_EMPRESAS] PRIMARY KEY CLUSTERED 
(
	[CUIT] 
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

ALTER TABLE [SERVOMOTOR].[EMPRESAS]  WITH CHECK ADD  CONSTRAINT [FK_EMPRESAS_RUBRO] FOREIGN KEY([ID_RUBRO])
REFERENCES [SERVOMOTOR].[RUBROS] ([ID_RUBRO])

-- Tabla Medios de pago: 
CREATE TABLE [SERVOMOTOR].[MEDIOS_DE_PAGO](
	[ID_MEDPAGO] [tinyint] IDENTITY,
	[TIPO_MEDPAGO] [varchar] (20) UNIQUE,
 CONSTRAINT [PK_MEDPAGO] PRIMARY KEY CLUSTERED 
(
	[ID_MEDPAGO] 
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]


-- Tabla CLIENTES: 
CREATE TABLE [SERVOMOTOR].[CLIENTES](
	[DNI] [varchar](255) NOT NULL,
	[NOMBRE] [varchar] (255) NOT NULL,
	[APELLIDO] [varchar] (255) NOT NULL,
	[MAIL] [varchar] (255) NOT NULL,
	[TELEFONO] [varchar] (255) NULL,
	[CALLE] [varchar] (255) NOT NULL,
	[PISO] [varchar] (255) NULL,
	[DEPTO] [varchar] (255) NULL,
	[LOCALIDAD] [varchar] (255) NULL,
	[FECHA_NACIMIENTO] [datetime] NOT NULL,
	[COD_POSTAL_CLIENTE] [varchar] (255) NOT NULL,
	[ESTADO_HABILITACION] [bit] DEFAULT 1,
 CONSTRAINT [PK_CLIENTES] PRIMARY KEY CLUSTERED 
(
	[DNI] 
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]


--Tabla PAGOS
CREATE TABLE [SERVOMOTOR].[PAGOS](
	[NUMERO_PAGO] [numeric](18,0) IDENTITY NOT NULL,
	[FECHA_COBRO] [datetime] NOT NULL,
	[FECHA_VENCIMIENTO] [datetime] DEFAULT GETDATE(),
	[IMPORTE] [varchar] (255) NOT NULL,
	[COD_POSTAL] [varchar](20) NOT NULL,
	[ID_MEDPAGO] [tinyint] NOT NULL,
	[DNI_CLIENTE] [varchar](255)  NOT NULL,
	[CUIT_EMPRESA] [varchar](50)  NOT NULL,
 CONSTRAINT [PK_PAGOS] PRIMARY KEY CLUSTERED 
(
	[NUMERO_PAGO] 
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

GO


ALTER TABLE [SERVOMOTOR].[PAGOS]  WITH CHECK ADD  CONSTRAINT [FK_PAGOS_SUCURSAL] FOREIGN KEY([COD_POSTAL])
REFERENCES [SERVOMOTOR].[SUCURSALES] ([COD_POSTAL])

ALTER TABLE [SERVOMOTOR].[PAGOS]  WITH CHECK ADD  CONSTRAINT [FK_PAGOS_MEDPAGO] FOREIGN KEY([ID_MEDPAGO])
REFERENCES [SERVOMOTOR].[MEDIOS_DE_PAGO] ([ID_MEDPAGO])


ALTER TABLE [SERVOMOTOR].[PAGOS]  WITH CHECK ADD  CONSTRAINT [FK_PAGOS_DNICLI] FOREIGN KEY([DNI_CLIENTE])
REFERENCES [SERVOMOTOR].[CLIENTES] ([DNI])

ALTER TABLE [SERVOMOTOR].[PAGOS]  WITH CHECK ADD  CONSTRAINT [FK_PAGOS_CUITEMP] FOREIGN KEY([CUIT_EMPRESA])
REFERENCES [SERVOMOTOR].[EMPRESAS] ([CUIT])


-- Tabla DEVOLUCIONEs: 
CREATE TABLE [SERVOMOTOR].[DEVOLUCIONES](
	[ID_DEVOLUCION] [tinyint] IDENTITY,
	[MOTIVO_DEVOLUCION] [varchar] (255) UNIQUE,
 CONSTRAINT [PK_FACTURA_DEVOLUCION] PRIMARY KEY CLUSTERED 
(
	[ID_DEVOLUCION] 
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]



-- Tabla RENDICIONES: 
CREATE TABLE [SERVOMOTOR].[RENDICIONES](
	[ID_RENDICION] [tinyint] IDENTITY,
	[FECHA_COBRO] [datetime] NOT NULL,
	[PORCENTAJE_COMISION]  [tinyint] NOT NULL DEFAULT 30,
	[CANTIDAD_FACTURAS_RENDIDAS] [tinyint] NOT NULL,
	[PRECIO_COMISION] [numeric] (7,2) NOT NULL DEFAULT 60,
	[TOTAL_RENDIDO] [numeric] (7,2) NOT NULL,
	[ESTADO] [varchar] (20) NOT NULL DEFAULT 'rendida' ,
	[CUIT_EMPRESA] [varchar] (50),
 CONSTRAINT [PK_RENDICIONES] PRIMARY KEY CLUSTERED 
(
	[ID_RENDICION] 
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]


ALTER TABLE [SERVOMOTOR].[RENDICIONES]  WITH CHECK ADD  CONSTRAINT [FK_RENDICIONES_EMPRESA] FOREIGN KEY([CUIT_EMPRESA])
REFERENCES [SERVOMOTOR].[EMPRESAS] ([CUIT])





-- Tabla FACTURAS: 
CREATE TABLE [SERVOMOTOR].[FACTURAS](
	[NUMERO_FACTURA] [varchar](20) NOT NULL,
	[FECHA_ALTA] [datetime] NOT NULL,
	[FECHA_VENCIMIENTO] [datetime] NOT NULL,
	[DNI_CLIENTE] [varchar](255) NOT NULL,
	[CUIT_EMPRESA] [varchar] (50) NOT NULL,
	[TOTAL] [numeric] (7,2) NOT NULL,
	[ESTADO] [varchar] (20) NOT NULL,
	[NUMERO_PAGO][numeric](18,0),
	[ID_RENDICION] [tinyint] ,
 CONSTRAINT [PK_FACTURAS] PRIMARY KEY CLUSTERED 
(
	[NUMERO_FACTURA] 
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

ALTER TABLE [SERVOMOTOR].[FACTURAS]  WITH CHECK ADD  CONSTRAINT [FK_FACTURAS_CLIENTE] FOREIGN KEY([DNI_CLIENTE])
REFERENCES [SERVOMOTOR].[CLIENTES] ([DNI])

ALTER TABLE [SERVOMOTOR].[FACTURAS]  WITH CHECK ADD  CONSTRAINT [FK_FACTURAS_EMPRESA] FOREIGN KEY([CUIT_EMPRESA])
REFERENCES [SERVOMOTOR].[EMPRESAS] ([CUIT])

ALTER TABLE [SERVOMOTOR].[FACTURAS]  WITH CHECK ADD  CONSTRAINT [FK_FACTURAS_PAGOS] FOREIGN KEY([NUMERO_PAGO])
REFERENCES [SERVOMOTOR].[PAGOS] ([NUMERO_PAGO])

ALTER TABLE [SERVOMOTOR].[FACTURAS]  WITH CHECK ADD  CONSTRAINT [FK_FACTURAS_RENDICION] FOREIGN KEY([ID_RENDICION])
REFERENCES [SERVOMOTOR].[RENDICIONES] ([ID_RENDICION])


--Tabla FActuras por devolucion.
CREATE TABLE [SERVOMOTOR].[FACTURAS_DEVOLUCIONES](
	[NUMERO_FACTURA] [varchar] (20) NOT NULL,
	[ID_DEVOLUCION] [tinyint] NOT NULL,
 CONSTRAINT [PK_FACTURAS_DEVOLUCIONESm] PRIMARY KEY CLUSTERED 
(
	[NUMERO_FACTURA] ,
	[ID_DEVOLUCION] 
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

GO


ALTER TABLE [SERVOMOTOR].[FACTURAS_DEVOLUCIONES]  WITH CHECK ADD  CONSTRAINT [FK_FACTURA_FACTURA_DEVOLUCIONES] FOREIGN KEY([NUMERO_FACTURA])
REFERENCES [SERVOMOTOR].[FACTURAS] ([NUMERO_FACTURA])


ALTER TABLE [SERVOMOTOR].[FACTURAS_DEVOLUCIONES]  WITH CHECK ADD  CONSTRAINT [FK_DEVOLUCION_FACTURA_DEVOLUCIONES] FOREIGN KEY([ID_DEVOLUCION])
REFERENCES [SERVOMOTOR].[DEVOLUCIONES] ([ID_DEVOLUCION])

-- Tabla ITEMS: 
CREATE TABLE [SERVOMOTOR].[ITEMS](
	[ID_ITEM] [tinyint] IDENTITY,
	[DESCRIPCION] [varchar] (20) NOT NULL,
	[MONTO] [varchar] (20) NOT NULL,
	[CANTIDAD] [tinyint] NOT NULL,
	[NUMERO_FACTURA] [varchar](20) NOT NULL,
 CONSTRAINT [PK_ITEMS] PRIMARY KEY CLUSTERED 
(
	[ID_ITEM] 
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]


ALTER TABLE [SERVOMOTOR].[ITEMS]  WITH CHECK ADD  CONSTRAINT [FK_ITEMS_PAGO] FOREIGN KEY([NUMERO_FACTURA])
REFERENCES [SERVOMOTOR].[FACTURAS] ([NUMERO_FACTURA])


--Crea tabla para la fecha del sistema
CREATE TABLE [SERVOMOTOR].[FECHA]([HOY] [datetime])

GO

CREATE FUNCTION [SERVOMOTOR].obtenerFechaDeHoy()
RETURNS datetime
AS 
	begin
	return (select top 1 * from [SERVOMOTOR].[FECHA])
	end
GO

CREATE PROCEDURE [SERVOMOTOR].crearTablaFecha
	@fecha datetime
AS
	DELETE FROM [SERVOMOTOR].[FECHA]

	insert into [SERVOMOTOR].[FECHA] values (@fecha)
GO

--//////////////////////////////////////////////

GO

CREATE FUNCTION SERVOMOTOR.EncriptarSHA1 (@numero VARCHAR(16))
RETURNS nvarchar(4000)
AS
BEGIN
	--DECLARE @hash nvarchar(4000)
	--SET @hash = CONVERT(nvarchar(4000),@numero);
	RETURN HASHBYTES('SHA1', @numero);
END

--SELECT SERVOMOTOR.EncriptarSHA1('w23e') AS [ALGO]

GO

--//////////// Migración de tabla maestra /////////////
-- Inserta los clientes en la tabla clientes

INSERT INTO [SERVOMOTOR].[CLIENTES]
(	
		DNI,
		NOMBRE,
		APELLIDO,
		MAIL,
		CALLE,
		FECHA_NACIMIENTO,
		COD_POSTAL_CLIENTE
	)
SELECT DISTINCT (cast([Cliente-Dni] as int))   , [Cliente-Nombre], [Cliente-Apellido], [Cliente_Mail], [Cliente_Direccion] ,cast([Cliente-Fecha_Nac] as datetime) , [Cliente_Codigo_Postal] FROM gd_esquema.Maestra
	

INSERT INTO [SERVOMOTOR].[RUBROS]
(	
		DESCRIPCION
)
SELECT DISTINCT [Rubro_Descripcion]   FROM gd_esquema.Maestra

INSERT INTO [SERVOMOTOR].[SUCURSALES]
(	
		COD_POSTAL,
		NOMBRE,
		DIRECCION
)
SELECT DISTINCT cast([Sucursal_Codigo_Postal] as varchar) ,[Sucursal_Nombre],[Sucursal_Dirección]  FROM gd_esquema.Maestra WHERE  [Sucursal_Codigo_Postal]  IS NOT NULL

INSERT INTO [SERVOMOTOR].[MEDIOS_DE_PAGO]
(	
		TIPO_MEDPAGO
)
SELECT DISTINCT [FormaPagoDescripcion]   FROM gd_esquema.Maestra where FormaPagoDescripcion is not null
	

INSERT INTO [SERVOMOTOR].[EMPRESAS] 
	(	CUIT , 
		NOMBRE ,   
		DIRECCION , 
		ID_RUBRO 
	)
SELECT  DISTINCT Empresa_Cuit , 
		Empresa_Nombre,  
		Empresa_Direccion , 
		Empresa_Rubro 		
FROM gd_esquema.Maestra

SET IDENTITY_INSERT [SERVOMOTOR].[PAGOS]  ON
INSERT INTO [SERVOMOTOR].[PAGOS] 
	(	NUMERO_PAGO , 
		FECHA_COBRO ,
		IMPORTE,
		COD_POSTAL,
		ID_MEDPAGO,
		DNI_CLIENTE,
		CUIT_EMPRESA
	)
SELECT  DISTINCT Pago_nro  , 
		Pago_Fecha,  
		Total , 
		Sucursal_Codigo_Postal,
		(SELECT M.ID_MEDPAGO FROM [SERVOMOTOR].[MEDIOS_DE_PAGO] M WHERE M.TIPO_MEDPAGO = FormaPagoDescripcion),		
		[Cliente-Dni],
		[Empresa_cuit]				 		
FROM gd_esquema.Maestra where Pago_nro is not null

SET IDENTITY_INSERT [SERVOMOTOR].[PAGOS]  OFF

/*
INSERT INTO [SERVOMOTOR].[RENDICIONES] 
	(	ID_RENDICION , 
		FECHA_COBRO ,
		CANTIDAD_FACTURAS_RENDIDAS,
		TOTAL_RENDIDO,
		CUIT_EMPRESA
	)
SELECT  DISTINCT Rendicion_Nro , 
		Rendicion_Fecha,  
		Total , 
		Sucursal_Codigo_Postal,
		(SELECT M.ID_MEDPAGO FROM [SERVOMOTOR].[MEDIOS_DE_PAGO] M WHERE M.TIPO_MEDPAGO = FormaPagoDescripcion),		
		[Cliente-Dni]				 		
FROM gd_esquema.Maestra where Rendicion_nro is not null


*/

-- Insert de usuario invitado y un administrador
-- el hash de la contraseña w23e está previamente calculado
DECLARE @Password VARCHAR(70)
--SET @Password = 'c6a9b01aeca5e5314845a9b00373f1d1cbe06b93'
SET @Password = 'e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7'
INSERT INTO SERVOMOTOR.USUARIOS (USERNAME,PASSWORD,HABILITADO,CANT_INT_FALL)
	VALUES ('Invitado','',1,0),
		   ('admin',@Password,1,0),
		   ('usuarioX',@Password,1,0),
		   ('jorge256',@Password,1,0),
		   ('Alguien',@Password,1,0)

GO

INSERT INTO SERVOMOTOR.DEVOLUCIONES(MOTIVO_DEVOLUCION) VALUES ('Error de cobro')
INSERT INTO SERVOMOTOR.DEVOLUCIONES(MOTIVO_DEVOLUCION) VALUES ('Cliente retrotrajo pago')



INSERT INTO SERVOMOTOR.ROLES(NOMBRE) VALUES ('Administrador')
INSERT INTO SERVOMOTOR.ROLES(NOMBRE) VALUES ('Cobrador')

INSERT INTO SERVOMOTOR.FUNCIONALIDADES(NOMBRE) VALUES ('ABM Rol')
INSERT INTO SERVOMOTOR.FUNCIONALIDADES(NOMBRE) VALUES ('ABM Cliente')
INSERT INTO SERVOMOTOR.FUNCIONALIDADES(NOMBRE) VALUES ('ABM Empresa')
INSERT INTO SERVOMOTOR.FUNCIONALIDADES(NOMBRE) VALUES ('Listado Estadístico')

GO

/**************************** <<STORED PROCEDURE PARA ROLES Y FUNCIONALIDADES>> ******************************/

CREATE PROCEDURE SERVOMOTOR.AgregarFuncionalidadARol(@nombrerol NVARCHAR(100), @funcionalidad nvarchar(100)) AS
BEGIN
	INSERT INTO SERVOMOTOR.FUNCIONES_ROLES (ID_ROL,ID_FUNC)
		VALUES ((SELECT ID_ROL FROM SERVOMOTOR.ROLES WHERE NOMBRE = @nombrerol),
		        (SELECT ID_FUNC FROM SERVOMOTOR.FUNCIONALIDADES WHERE NOMBRE = @funcionalidad))
END

GO

--////Ver bien que funcionalidades tiene cada rol
EXEC SERVOMOTOR.AgregarFuncionalidadARol @nombrerol = 'Administrador', @funcionalidad = 'ABM Rol'
EXEC SERVOMOTOR.AgregarFuncionalidadARol @nombrerol = 'Administrador', @funcionalidad = 'ABM Cliente'
EXEC SERVOMOTOR.AgregarFuncionalidadARol @nombrerol = 'Administrador', @funcionalidad = 'Listado Estadístico'

EXEC SERVOMOTOR.AgregarFuncionalidadARol @nombrerol = 'Cobrador', @funcionalidad = 'ABM Cliente'


GO

--//////////// Creacion de stored procedures y funciones /////////////


--**************** LOGIN *************

-----------------------------Login---------------------------
CREATE PROCEDURE [SERVOMOTOR].LoginAdministrador
(@Usuario VARCHAR(20), @ContraseniaIngresada VARCHAR(70))
AS
BEGIN
	DECLARE @Contrasenia VARCHAR(70),
			@CantidadIntentos TINYINT,
			@ExisteUsuario BIT

	SELECT @ExisteUsuario = COUNT(*) 
		FROM SERVOMOTOR.USUARIOS
		WHERE USERNAME = @Usuario
	

	IF @ExisteUsuario = 0
	BEGIN
		RAISERROR('El nombre de usuario ingresado no existe.', 16, 1)
		RETURN
	END

	SELECT @Contrasenia = PASSWORD, @CantidadIntentos = CANT_INT_FALL
		FROM SERVOMOTOR.USUARIOS
		WHERE USERNAME = @Usuario

	IF @CantidadIntentos = 3
	BEGIN
		RAISERROR('Ha ingresado la contraseña 3 veces de forma incorrecta. Contáctese con un administrador para reestablecer su cuenta.', 16, 1)
		RETURN
	END
	--[SERVOMOTOR].EncriptarSHA1(
	--IF (SELECT SERVOMOTOR.EncriptarSHA1(@ContraseniaIngresada) as [resultado]) <> @Contrasenia
	IF @ContraseniaIngresada <> @Contrasenia
	BEGIN
		RAISERROR('Contraseña incorrecta.', 16, 1)
		
		UPDATE SERVOMOTOR.USUARIOS 
			SET CANT_INT_FALL = CANT_INT_FALL + 1
			WHERE USERNAME = @Usuario

		SELECT @CantidadIntentos = CANT_INT_FALL
			FROM SERVOMOTOR.USUARIOS
			WHERE USERNAME = @Usuario
		
		IF @CantidadIntentos = 3
		BEGIN
			RAISERROR('Ha ingresado la contraseña 3 veces de forma incorrecta. Contáctese con un administrador para reestablecer su cuenta.', 16, 1)
		END
		RETURN
	END

	UPDATE SERVOMOTOR.USUARIOS 
		SET CANT_INT_FALL = 0
		WHERE USERNAME = @Usuario
END



GO

--**************** MANEJO DE FECHAS *************


-------------------------------Fecha entre dos fechas----------------------------------------------
CREATE FUNCTION [SERVOMOTOR].datetime_between

 (@fecha DATETIME, @fecha1 DATETIME, @fecha2 DATETIME)

RETURNS smallint

AS

BEGIN
	if(datediff(minute, '1900-01-01 00:00:00.0000000', @fecha) between datediff(minute, '1900-01-01 00:00:00.0000000', @fecha1) and datediff(minute, '1900-01-01 00:00:00.0000000', @fecha2))
	begin
		return 1
	end
	
	return 0
END
GO
-------------------------------Saber si un datetime esta entre otros dos datetime------------------------
CREATE FUNCTION [SERVOMOTOR].datetime_is_between
 (@fecha DATETIME, @fecha1 DATETIME, @fecha2 DATETIME)

RETURNS smallint

AS

BEGIN
	if(@fecha1 <= @fecha2)
		begin
			if([SERVOMOTOR].datetime_between(@fecha, @fecha1, @fecha2) = 1)
				begin
					return 1
				end
		end
	else
		begin
			if([SERVOMOTOR].datetime_between(@fecha, @fecha2, @fecha1) = 1)
				begin
					return 1
				end
		end

	return 0
END

/**************************** <<TRIGGERS>> ******************************/
GO
CREATE TRIGGER cambiarTotalDelasFacturasPorModificacionItem ON [SERVOMOTOR].ITEMS
AFTER UPDATE
AS BEGIN

	UPDATE [SERVOMOTOR].FACTURAS
				SET Total=SumDetalle.Total
	FROM [SERVOMOTOR].FACTURAS F
	JOIN    (SELECT NUMERO_FACTURA, SUM(MONTO*CANTIDAD) AS Total
				  FROM [SERVOMOTOR].ITEMS
				  GROUP BY NUMERO_FACTURA) AS SumDetalle
	ON     F.NUMERO_FACTURA=SumDetalle.NUMERO_FACTURA
	JOIN  (SELECT NUMERO_FACTURA FROM Inserted
				UNION
				SELECT NUMERO_FACTURA FROM Deleted) AS Modificados
	ON F.NUMERO_FACTURA=Modificados.NUMERO_FACTURA

END


