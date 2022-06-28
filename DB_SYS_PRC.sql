--********************* --------------------- *********************
--********************* procedure structures for PROVIDER**********
--********************* --------------------- *********************
-- ----------------------------
-- procedure structure for get_Provider
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[get_Provider]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[get_Provider]
GO

CREATE PROCEDURE [dbo].[get_Provider]
as
begin
 select [IdProveedor],[Tipo],[Descripcion],[Dui],[Nit],[FechaRegistro] from [dbo].[PROVIDER]
end
GO
-- ----------------------------
-- procedure structure for reg_Provider
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[reg_Provider]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[reg_Provider]
GO

CREATE PROCEDURE [dbo].[reg_Provider](

@Tipo int,
@Descripcion varchar(100),
@Dui numeric(18,0),
@Nit numeric(18,0),
@FechaRegistro varchar(100),
@Resultado bit output
)as
BEGIN TRY
SET @Resultado = 0
IF (@Dui = 0)
BEGIN
	INSERT INTO [dbo].[PROVIDER] ([Tipo],[Descripcion],[Nit],[FechaRegistro]) VALUES (@Tipo, @Descripcion, @Nit, @FechaRegistro)
	SET @Resultado = 1
END	
IF (@Nit = 0)
BEGIN
	INSERT INTO [dbo].[PROVIDER] ([Tipo],[Descripcion],[Dui],[FechaRegistro]) VALUES (@Tipo, @Descripcion, @Dui, @FechaRegistro)
	SET @Resultado = 1
END
PRINT @Resultado	
END TRY
BEGIN CATCH
SET @Resultado = 0
END CATCH

GO
-- ----------------------------
-- procedure structure for upd_Provider
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[upd_Provider]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[upd_Provider]
GO

CREATE PROCEDURE [dbo].[upd_Provider](
@IdProveedor int,
@Tipo int,
@Descripcion varchar(100),
@Dui numeric(18,0),
@Nit numeric(18,0),
@Resultado bit output
)
as
BEGIN
	SET @Resultado = 0
BEGIN
	IF (@Dui = 0)
		update [dbo].[PROVIDER] set 
		Tipo = @Tipo,
		Descripcion = @Descripcion,
		Nit = @Nit,
		Dui = 0
		where IdProveedor = @IdProveedor
		SET @Resultado = 1
END
BEGIN
	IF (@Nit = 0)
		update [dbo].[PROVIDER] set 
		Tipo = @Tipo,
		Descripcion = @Descripcion,
		Dui = @Dui,
		Nit = 0
		where IdProveedor = @IdProveedor
		SET @Resultado = 1
END
end
GO
-- ----------------------------
-- procedure structure for del_Provider
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[del_Provider]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[del_Provider]
GO

CREATE PROCEDURE [dbo].[del_Provider](
@IdProveedor int,
@Resultado bit output
)
as
SET @Resultado = 1
BEGIN
	
	IF EXISTS (SELECT * FROM [dbo].[PROVIDER] WHERE IdProveedor = @IdProveedor)
		DELETE FROM [dbo].[PROVIDER] WHERE IdProveedor = @IdProveedor
	ELSE
		SET @Resultado = 0

end
GO
-- ----------------------------
-- procedure structure for search_Provider
-- ----------------------------
IF EXISTS (SELECt * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[search_Provider]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[search_Provider]
GO

CREATE PROCEDURE [dbo].[search_Provider](
@IdProveedor int
)
AS
BEGIN
	SELECT * FROM [dbo].[PROVIDER] WHERE IdProveedor = @IdProveedor
END
GO

--********************* --------------------- *********************
--********************* procedure structures for USERS ************
--********************* --------------------- *********************

-------------------------------
-- procedure structure for val_User
-- ----------------------------

IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[val_User]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[val_User]
GO

CREATE PROCEDURE [dbo].[val_User](
@Usuario varchar (100),
@Pass varchar (100),
@Resultado bit output
)
AS
SET @Resultado = 0
BEGIN
	IF EXISTS (SELECT * FROM USERS WHERE [User] = @Usuario AND [Clave] = @Pass)
		SET @Resultado = 1;
PRINT @Resultado
END
GO
-------------------------------
-- procedure structure for reg_User
-- ----------------------------

IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[reg_User]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[reg_User]
GO

CREATE PROCEDURE [dbo].[reg_User](
@Usuario varchar (100),
@Pass varchar (100),
@Tipo int,
@Resultado bit output
)
AS
SET @Resultado = 1
BEGIN
	IF EXISTS (SELECT * FROM USERS WHERE [User] = @Usuario)
		SET @Resultado = 0;
END
BEGIN
	IF (@Resultado = 1)
		INSERT INTO [dbo].[USERS] ([User],[Clave],[Tipo]) VALUES (@Usuario,@Pass,@Tipo)

END	
GO
EXEC reg_User 'user','123',1,1
EXEC reg_User 'admin','123',1,1
EXEC reg_User '','',1,1

--********************* --------------------- *********************
--********************* procedure structures for PRODUCTS *********
--********************* --------------------- *********************
-- ----------------------------
-- procedure structure for get_Products
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[get_Products]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[get_Products]
GO

CREATE PROCEDURE [dbo].[get_Products]
as
begin
 select [IdProducto],[Descripcion],[IdProveedor],[UnidadPaquete],[PrecioPaquete],[FechaRegistro] from [dbo].[PRODUCTS]
end
GO
-- ----------------------------
-- procedure structure for search_Products
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[search_Products]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[search_Products]
GO

CREATE PROCEDURE [dbo].[search_Products]
(
@Nombre varchar(100)
)
AS
begin
 select [IdProducto],[Descripcion],[IdProveedor],[UnidadPaquete],[PrecioPaquete],[FechaRegistro] from [dbo].[PRODUCTS] WHERE Descripcion = @Nombre
END
GO
-- ----------------------------
-- procedure structure for reg_Products
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[reg_Products]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[reg_Products]
GO

CREATE PROCEDURE [dbo].[reg_Products]
(
@Descripcion varchar (100),
@IdProveedor int,
@UnidadPaquete int,
@PrecioPaquete int,
@FechaRegistro varchar (100),
@Result bit output
)
AS
SET @Result = 0
BEGIN TRY
	INSERT INTO [dbo].[PRODUCTS] ([Descripcion],[IdProveedor],[UnidadPaquete],[PrecioPaquete],[FechaRegistro]) VALUES (@Descripcion,@IdProveedor,@UnidadPaquete,@PrecioPaquete,@FechaRegistro)
END TRY
BEGIN CATCH
	SET @Result = 1
END CATCH
GO
-- ----------------------------
-- procedure structure for upd_Products
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[upd_Products]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[upd_Products]
GO

CREATE PROCEDURE [dbo].[upd_Products]
(
@IdProducto int,
@IdProveedor int,
@Descripcion varchar (100),
@UnidadPaquete int,
@PrecioPaquete int,
@Result bit output
)
AS
SET @Result = 0
BEGIN TRY
	UPDATE [dbo].[PRODUCTS] SET
	[Descripcion] = @Descripcion,
	[IdProveedor] = @IdProveedor,
	[UnidadPaquete] = @UnidadPaquete,
	[PrecioPaquete] = @PrecioPaquete
	WHERE [IdProducto] = @IdProducto
END TRY
BEGIN CATCH
	SET @Result = 1
END CATCH
GO
--********************* --------------------- *********************
--********************* procedure structures for INPUT**********
--********************* --------------------- *********************
-- ----------------------------
-- procedure structure for reg_Input
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[reg_Input]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[reg_Input]
GO

CREATE PROCEDURE [dbo].[reg_Input]
(
@IdProveedor int ,
@IdProducto int ,
@Descripcion varchar(100),
@Paquetes int ,
@UnidadPaquete int ,
@PrecioPaquete float (30),
@PrecioTotal float (30),
@FechaRegistro varchar(100),
@Result bit output
)
AS
SET @Result = 0
BEGIN TRY

	INSERT INTO [dbo].[INPUTS] ([IdProveedor],[IdProducto],[Descripcion],[Paquetes],[UnidadPaquete],[PrecioPaquete],[PrecioTotal],[FechaRegistro]) VALUES (@IdProveedor,@IdProducto,@Descripcion,@Paquetes,@UnidadPaquete,@PrecioPaquete,@PrecioTotal,@FechaRegistro)
END TRY
BEGIN CATCH
	SET @Result = 1
END CATCH
GO
--********************* --------------------- *********************
--********************* procedure structures for STOCK**********
--********************* --------------------- *********************
-- ----------------------------
-- procedure structure for get_Stock
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[get_Stock]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[get_Stock]
GO

CREATE PROCEDURE [dbo].[get_Stock]
as
begin
 select * from [dbo].[STOCK]
end
GO
-- ----------------------------
-- procedure structure for reg_Stock
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[reg_Stock]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[reg_Stock]
GO

CREATE PROCEDURE [dbo].[reg_Stock]
(
@IdProducto int ,
@Descripcion varchar(100),
@Paquetes int ,
@UnidadPaquete int ,
@PrecioPaquete float (30),
@FechaRegistro varchar(100),
@Result bit output
)
AS
SET @Result = 0
IF EXISTS (SELECT * FROM [dbo].[STOCK] WHERE IdProducto = @IdProducto)
	BEGIN TRY
			update [dbo].[STOCK] SET
			Paquetes = Paquetes + @Paquetes
			WHERE IdProducto = @IdProducto
			PRINT 5
	END TRY
	BEGIN CATCH
		SET @Result = 1
		PRINT @Result
	END CATCH
ELSE
	BEGIN TRY
		INSERT INTO [dbo].[STOCK] ([IdProducto],[Descripcion],[Paquetes],[UnidadPaquete],[PrecioPaquete],[FechaRegistro]) VALUES (@IdProducto,@Descripcion,@Paquetes,@UnidadPaquete,@PrecioPaquete,@FechaRegistro)
	END TRY
	BEGIN CATCH
		SET @Result = 1
		PRINT @Result
	END CATCH
GO
-- ----------------------------
-- procedure structure for upd_Stock
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[upd_Stock]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[upd_Stock]
GO

CREATE PROCEDURE [dbo].[upd_Stock]
(
@IdProducto int ,
@Paquetes int ,
@Unidades int,
@Result bit output
)
AS
SET @Result = 0
IF EXISTS (SELECT * FROM [dbo].[STOCK] WHERE IdProducto = @IdProducto)
	BEGIN TRY
			update [dbo].[STOCK] SET
			Paquetes = Paquetes + @Paquetes
			WHERE IdProducto = @IdProducto
	END TRY
	BEGIN CATCH
		SET @Result = 1
		PRINT @Result
	END CATCH
GO
-- ----------------------------
-- procedure structure for upd_new_Stock
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[upd_new_Stock]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[upd_new_Stock]
GO

CREATE PROCEDURE [dbo].[upd_new_Stock]
(
@IdProducto int ,
@Paquetes int ,
@Unidades int,
@Result bit output
)
AS
SET @Result = 0
IF EXISTS (SELECT * FROM [dbo].[STOCK] WHERE IdProducto = @IdProducto)
	BEGIN TRY
			update [dbo].[STOCK] SET
			Paquetes = @Paquetes,
			Unidades = @Unidades
			WHERE IdProducto = @IdProducto
	END TRY
	BEGIN CATCH
		SET @Result = 1
		PRINT @Result
	END CATCH
GO
--********************* --------------------- *********************
--********************* procedure structures for OUTPUTS**********
--********************* --------------------- *********************
-- ----------------------------
-- procedure structure for reg_Output
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[reg_Output]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[reg_Output]
GO

CREATE PROCEDURE [dbo].[reg_Output]
(
@IdProducto int ,
@Descripcion varchar(100),
@Unidades int ,
@Paquetes int ,
@PrecioTotal float (30),
@FechaRegistro varchar(100),
@Result bit output
)
AS
SET @Result = 0
BEGIN TRY

	INSERT INTO [dbo].[OUTPUTS] ([IdProducto],[Descripcion],[Unidades],[Cajas],[PrecioTotal],[FechaRegistro]) VALUES (@IdProducto,@Descripcion,@Unidades,@Paquetes,@PrecioTotal,@FechaRegistro)
END TRY
BEGIN CATCH
	SET @Result = 1
END CATCH
GO
-- ----------------------------
-- procedure structure for del_Output
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[del_Output]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[del_Output]
GO

CREATE PROCEDURE [dbo].[del_Output]
(
@IdProducto int ,
@Result bit output
)
AS
SET @Result = 0
BEGIN TRY
	DELETE FROM [dbo].[OUTPUTS] WHERE IdProducto = @IdProducto
END TRY
BEGIN CATCH
	SET @Result = 1
END CATCH
GO
SELECT * FROM INPUTS
SELECT * FROM PRODUCTS

SELECT * FROM OUTPUTS
SELECT * FROM STOCK
