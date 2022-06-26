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
		update PROVIDER set 
		Tipo = @Tipo,
		Descripcion = @Descripcion,
		Nit = @Nit,
		Dui = 0
		where IdProveedor = @IdProveedor
		SET @Resultado = 1
END
BEGIN
	IF (@Nit = 0)
		update PROVIDER set 
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
--********************* procedure structures for PRODUCTS**********
--********************* --------------------- *********************
EXEC reg_Provider 1,'2',12313,0,'123123123',0
EXEC get_Provider
EXEC del_Provider 1,0
EXEC del_Provider 2,0
EXEC del_Provider 3,0