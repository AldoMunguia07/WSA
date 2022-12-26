USE tempdb
GO

--DROP DATABASE AWS_DB
-- Crear la base de datos

CREATE DATABASE AWS_DB
GO

USE AWS_DB
GO

--TABLAS

CREATE TABLE Cliente
(
	Cliente_Id INT NOT NULL IDENTITY,
	Cliente VARCHAR(70) NOT NULL,

	CONSTRAINT PK_Cliente_Cliente_Id
		PRIMARY KEY CLUSTERED (cliente_Id)
);
GO

CREATE TABLE Conductor
(
	Conductor_Id INT NOT NULL IDENTITY,
	Conductor VARCHAR(70) NOT NULL,

	CONSTRAINT PK_Conductor_Conductor_Id
		PRIMARY KEY CLUSTERED (Conductor_Id)
);
GO

CREATE TABLE Proveedor
(
	Proveedor_Id INT NOT NULL IDENTITY,
	Proveedor VARCHAR(70) NOT NULL,

	CONSTRAINT PK_Proveedor_Proveedor_Id
		PRIMARY KEY CLUSTERED (Proveedor_Id)
);
GO

CREATE TABLE Producto
(
	Producto_Id INT NOT NULL IDENTITY,
	Descripcion VARCHAR(80) NOT NULL,
	Precio DECIMAL(6,2) NOT NULL

	CONSTRAINT PK_Producto_Producto_Id
		PRIMARY KEY CLUSTERED (Producto_Id)
);
GO

CREATE TABLE Tipo_Usuario
(
	Tipo_Usuario_Id INT NOT NULL IDENTITY,
	Tipo_Usuario VARCHAR(25) NOT NULL

	CONSTRAINT PK_Tipo_Usuario_Tipo_Usuario_Id
		PRIMARY KEY CLUSTERED (Tipo_Usuario_Id)

);

CREATE TABLE Usuario
(
	Usuario_Id INT NOT NULL IDENTITY,
	Nombre_Usuario VARCHAR(80) NOT NULL,
	Usuario VARCHAR(30) NOT NULL,
	Contrasena VARBINARY(MAX) NOT NULL,
	Tipo_Usuario_Id INT NOT NULL,
	Activo BIT NOT NULL

	CONSTRAINT PK_Usuario_Usuario_Id
		PRIMARY KEY CLUSTERED (Usuario_Id),

	CONSTRAINT FK_Usuario$Existe$Tipo_Usuario
		FOREIGN KEY (Tipo_Usuario_Id) REFERENCES Tipo_Usuario(Tipo_Usuario_Id),
);
GO

CREATE TABLE Bitacora
(
	Bitacora_Id INT NOT NULL IDENTITY,
	Usuario_Id INT NOT NULL,
	Usuario_PC VARCHAR(70) NOT NULL,
	Tipo_Accion VARCHAR(25) NOT NULL,
	Accion VARCHAR(200) NOT NULL,
	Fecha DATETIME NOT NULL

	CONSTRAINT PK_Bitacora_Bitacora_Id
		PRIMARY KEY CLUSTERED (Bitacora_ID),

	CONSTRAINT FK_Bitacora$Existe$Usuario
		FOREIGN KEY (Usuario_Id) REFERENCES Usuario(Usuario_Id),

);
GO

CREATE TABLE Barco
(
	Barco_Id INT NOT NULL IDENTITY,
	Descripcion VARCHAR(70) NOT NULL

	CONSTRAINT PK_Barco_Barco_Id
		PRIMARY KEY CLUSTERED (Barco_Id)

);
GO

CREATE TABLE Boleta
(
	Boleta_Id INT NOT NULL IDENTITY,
	Fecha_Entrada DATETIME NOT NULL,
	Fecha_Salida DATETIME NULL,
	Placa_Cabezal VARCHAR(10) NULL,
	Placa_Rastra VARCHAR(10) NULL,
	Conductor_Id INT NOT NULL,
	Cliente_Id INT NULL,
	Producto_Id INT NOT NULL,
	Peso_Ingreso FLOAT NOT NULL,
	Unidades_Peso_Ingreso VARCHAR(4) NOT NULL,
	Cia_Transportista VARCHAR(25) NULL,
	Envio_N VARCHAR(50) NULL,
	Peso_Salida FLOAT NULL,
	Unidades_Peso_Salida VARCHAR(4) NULL,
	Barco_Id INT NOT NULL,
	Usuario_Id INT NOT NULL,
	Estado CHAR(1) NOT NULL,
	Observaciones VARCHAR(200) NULL


	CONSTRAINT PK_Boleta_Boleta_Id
		PRIMARY KEY CLUSTERED (Boleta_Id),

	CONSTRAINT FK_Boleta$Existe$Conductor
		FOREIGN KEY (Conductor_Id) REFERENCES Conductor(Conductor_Id),

	CONSTRAINT FK_Boleta$Existe$Cliente
		FOREIGN KEY (Cliente_Id) REFERENCES Cliente(Cliente_Id),


	CONSTRAINT FK_Boleta$Existe$Producto
		FOREIGN KEY (Producto_Id) REFERENCES Producto(Producto_Id),

	CONSTRAINT FK_Boleta$Existe$Usuario
		FOREIGN KEY (Usuario_Id) REFERENCES Usuario(Usuario_Id),

	CONSTRAINT FK_Boleta$Existe$Barco
		FOREIGN KEY (Barco_Id) REFERENCES Barco(Barco_Id)

);
GO

CREATE TABLE Encabezado_Boleta
(
	Encabezado_Boleta_Id INT NOT NULL IDENTITY,
	Empresa VARCHAR(70) NOT NULL,
	Direccion VARCHAR(70) NOT NULL,
	Telefono VARCHAR(20) NULL


	CONSTRAINT PK_Encabezado_Boleta_Encabezado_Boleta_Id
		PRIMARY KEY CLUSTERED (Encabezado_Boleta_Id)

);
GO

CREATE TABLE Indicador
(
	Indicador_Id INT NOT NULL IDENTITY,
	Port_Name VARCHAR(70) NOT NULL,
	Baud_Rate INT NOT NULL,
	Data_Bits INT NOT NULL,
	Parity VARCHAR(40) NOT NULL,	
	Stop_Bit VARCHAR(40) NOT NULL,
	Maximo INT NOT NULL,
	Minimo INT NOT NULL,
	Posicion_Signo_Mas INT NOT NULL




	CONSTRAINT PK_Indicador_Indicador_Id
		PRIMARY KEY CLUSTERED (Indicador_Id)

);
GO


--INSERTS
INSERT INTO Tipo_Usuario VALUES('ADMINISTRADOR');
INSERT INTO Tipo_Usuario VALUES('OPERADOR');


INSERT INTO Usuario VALUES('ADMIN', 'ADMIN', ENCRYPTBYPASSPHRASE('WAS_ALG_ENCRYPT','ADMIN1234'), 1, 1);
GO

--PROCEDMIENTOS ALMACENADOS

CREATE PROCEDURE sp_Cliente
@Cliente_Id INT = NULL,
@Cliente VARCHAR(70) = NULL,
@valorBuscado VARCHAR(80)  = NULL,
@accion VARCHAR(50)

AS
BEGIN
	IF @accion = 'insertar'
	BEGIN
		INSERT INTO Cliente VALUES (@Cliente)
	END
	ELSE IF @accion = 'modificar'
	BEGIN
		UPDATE Cliente SET Cliente = @Cliente WHERE Cliente_Id = @Cliente_Id
	END
	ELSE IF @accion = 'mostrar'
	BEGIN
		SELECT Cliente_Id 'Código del cliente', Cliente FROM Cliente
	END
	ELSE IF @accion = 'buscar'
	BEGIN
		SELECT Cliente_Id 'Código del cliente', Cliente 
		FROM Cliente 
		WHERE CONCAT(Cliente_Id, ' ', Cliente) LIKE CONCAT('%', @valorBuscado,'%')
	END

END
GO

CREATE PROCEDURE sp_Producto
@Producto_Id INT = NULL,
@Descripcion VARCHAR(80) = NULL,
@Precio DECIMAL(6, 2) = NULL,
@valorBuscado VARCHAR(80)  = NULL,
@accion VARCHAR(50)

AS
BEGIN
	IF @accion = 'insertar'
	BEGIN
		INSERT INTO Producto VALUES (@Descripcion, @Precio)
	END
	ELSE IF @accion = 'modificar'
	BEGIN
		UPDATE Producto SET Descripcion = @Descripcion, Precio = @Precio WHERE Producto_Id = @Producto_Id
	END
	ELSE IF @accion = 'mostrar'
	BEGIN
		SELECT Producto_Id 'Código del producto', Descripcion 'Descripción', Precio FROM Producto
	END
	ELSE IF @accion = 'buscar'
	BEGIN
		SELECT Producto_Id 'Código del producto', Descripcion 'Descripción', Precio
		FROM Producto 
		WHERE CONCAT(Producto_Id, ' ', Descripcion) LIKE CONCAT('%', @valorBuscado,'%')
	END
END
GO

CREATE PROCEDURE sp_Proveedor
@Proveedor_Id INT = NULL,
@Proveedor VARCHAR(70) = NULL,
@valorBuscado VARCHAR(80)  = NULL,
@accion VARCHAR(50)

AS
BEGIN
	IF @accion = 'insertar'
	BEGIN
		INSERT INTO Proveedor VALUES (@Proveedor)
	END
	ELSE IF @accion = 'modificar'
	BEGIN
		UPDATE Proveedor SET Proveedor = @Proveedor WHERE Proveedor_Id = @Proveedor_Id
	END
	ELSE IF @accion = 'mostrar'
	BEGIN
		SELECT Proveedor_Id 'Código del proveedor', Proveedor FROM Proveedor
	END
	ELSE IF @accion = 'buscar'
	BEGIN
		SELECT Proveedor_Id 'Código del proveedor', Proveedor
		FROM Proveedor 
		WHERE CONCAT(Proveedor_Id, ' ', Proveedor) LIKE CONCAT('%', @valorBuscado,'%')
	END

END
GO

CREATE PROCEDURE sp_Conductor
@Conductor_Id INT = NULL,
@Conductor VARCHAR(70) = NULL,
@valorBuscado VARCHAR(80)  = NULL,
@accion VARCHAR(50)

AS
BEGIN
	IF @accion = 'insertar'
	BEGIN
		INSERT INTO Conductor VALUES (@Conductor)
	END
	ELSE IF @accion = 'modificar'
	BEGIN
		UPDATE Conductor SET Conductor = @Conductor WHERE Conductor_Id = @Conductor_Id
	END
	ELSE IF @accion = 'mostrar'
	BEGIN
		SELECT Conductor_Id 'Código del conductor', Conductor FROM Conductor
	END
	ELSE IF @accion = 'buscar'
	BEGIN
		SELECT Conductor_Id 'Código del conductor', Conductor
		FROM Conductor 
		WHERE CONCAT(Conductor_Id, ' ', Conductor) LIKE CONCAT('%', @valorBuscado,'%')
	END

END
GO

CREATE PROCEDURE sp_Barco
@Barco_Id INT = NULL,
@Descripcion VARCHAR(70) = NULL,
@valorBuscado VARCHAR(80)  = NULL,
@accion VARCHAR(50)

AS
BEGIN
	IF @accion = 'insertar'
	BEGIN
		INSERT INTO Barco VALUES (@Descripcion)
	END
	ELSE IF @accion = 'modificar'
	BEGIN
		UPDATE Barco SET Descripcion = @Descripcion WHERE Barco_Id = @Barco_Id
	END
	ELSE IF @accion = 'mostrar'
	BEGIN
		SELECT Barco_Id 'Código del barco', Descripcion FROM Barco
	END
	ELSE IF @accion = 'buscar'
	BEGIN
		SELECT Barco_Id 'Código del barco', Descripcion 
		FROM Barco 
		WHERE CONCAT(Barco_Id, ' ', Descripcion) LIKE CONCAT('%', @valorBuscado,'%')
	END

END
GO


CREATE PROCEDURE sp_Usuario
@Usuario_Id INT = NULL,
@Nombre_Usuario VARCHAR(80) = NULL,
@Usuario VARCHAR(30) = NULL,
@Contrasena VARCHAR(50) = NULL,
@Tipo_Usuario_Id INT = NULL,
@Activo BIT  = NULL,
@valorBuscado VARCHAR(80)  = NULL,
@accion VARCHAR(50)

AS
DECLARE @password VARBINARY(max)
BEGIN
	IF @accion = 'insertar'
	BEGIN
		SET @password = (ENCRYPTBYPASSPHRASE('WAS_ALG_ENCRYPT',@Contrasena));
		INSERT INTO Usuario VALUES (@Nombre_Usuario, @Usuario,@password, @Tipo_Usuario_Id, @Activo)
	END
	ELSE IF @accion = 'modificar'
	BEGIN
		SET @password = (ENCRYPTBYPASSPHRASE('WAS_ALG_ENCRYPT',@Contrasena));
		UPDATE Usuario SET Nombre_Usuario = @Nombre_Usuario, Usuario = @Usuario, Contrasena = @password, Tipo_Usuario_Id = @Tipo_Usuario_Id, Activo = @Activo
		WHERE Usuario_Id = @Usuario_Id
	END
	ELSE IF @accion = 'mostrar'
	BEGIN
		SELECT u.Usuario_Id 'Código de usuario',  u.Nombre_Usuario Nombre, u.Usuario, tu.Tipo_Usuario 'Tipo de usuario', u.Activo, CONVERT(VARCHAR,DECRYPTBYPASSPHRASE('WAS_ALG_ENCRYPT',u.Contrasena)) Contrasena, u.Tipo_Usuario_Id
		FROM Usuario u JOIN Tipo_Usuario tu
		ON U.Tipo_Usuario_Id = tu.Tipo_Usuario_Id
	END
	ELSE IF @accion = 'buscar'
	BEGIN
		SELECT u.Usuario_Id 'Código de usuario',  u.Nombre_Usuario Nombre, u.Usuario, Tipo_Usuario 'Tipo de usuario', Activo, CONVERT(VARCHAR,DECRYPTBYPASSPHRASE('WAS_ALG_ENCRYPT',u.Contrasena)) Contrasena, u.Tipo_Usuario_Id
		FROM Usuario u JOIN Tipo_Usuario tu
		ON U.Tipo_Usuario_Id = tu.Tipo_Usuario_Id
		WHERE CONCAT(u.Usuario_Id , ' ', u.Nombre_Usuario,' ', u.Usuario, ' ',tu.Tipo_Usuario, ' ', u.Activo) LIKE CONCAT('%', @valorBuscado,'%')
	END
	ELSE IF @accion = 'CargarTipoUsuario'
	BEGIN
		SELECT * FROM Tipo_Usuario
	END
	ELSE IF @accion = 'existeUsuario'
	BEGIN
		SELECT Usuario FROM Usuario WHERE Usuario = @Usuario
	END
	ELSE IF @accion = 'obtenerUsuario'
	BEGIN
		SELECT u.Usuario_Id, u.Nombre_Usuario, u.Usuario, CONVERT(VARCHAR,DECRYPTBYPASSPHRASE('WAS_ALG_ENCRYPT',u.Contrasena)) Contrasena, tp.Tipo_Usuario_Id,  tp.Tipo_Usuario, Activo
		FROM Usuario u JOIN Tipo_Usuario tp
		ON u.Tipo_Usuario_Id = tp.Tipo_Usuario_Id
		WHERE Usuario = @Usuario
	END
	ELSE IF @accion = 'obtenerUsuarioPorId'
	BEGIN
		SELECT u.Usuario_Id, u.Nombre_Usuario, u.Usuario, CONVERT(VARCHAR,DECRYPTBYPASSPHRASE('WAS_ALG_ENCRYPT',u.Contrasena)) Contrasena, tp.Tipo_Usuario_Id,  tp.Tipo_Usuario, Activo
		FROM Usuario u JOIN Tipo_Usuario tp
		ON u.Tipo_Usuario_Id = tp.Tipo_Usuario_Id
		WHERE Usuario_Id = @Usuario_Id
	END
	ELSE IF @accion = 'bitacoraInicioSesion'
	BEGIN
		INSERT INTO Bitacora VALUES(@Usuario_Id,SYSTEM_USER, 'Inicio de sesión',CONCAT('Inicio de sesión del usuario ', @Usuario,  ' con código ', @Usuario_Id),  GETDATE()); 
	END
	ELSE IF @accion = 'bitacoraCierreSesion'
	BEGIN
		INSERT INTO Bitacora VALUES(@Usuario_Id,SYSTEM_USER, 'Cierre de sesión',CONCAT('Cierre de sesión del usuario ', @Usuario,  ' con código ', @Usuario_Id),  GETDATE()); 
	END

END
GO


/*CREATE PROCEDURE sp_Boleta
	@Boleta_Id INT = NULL,
	@Fecha_Entrada DATETIME = NULL,
	@Fecha_Salida DATETIME = NULL,
	@Placa_Cabezal VARCHAR(10) = NULL,
	@Placa_Rastra VARCHAR(10) = NULL,
	@Conductor_Id INT = NULL,
	@Cliente_Id INT = NULL,
	@Proveedor_Id INT = NULL,
	@Producto_Id INT = NULL,
	@Peso_Ingreso FLOAT = NULL,
	@Unidades_Peso_Ingreso VARCHAR(4) = NULL,
	@Cia_Transportista VARCHAR(25) = NULL,
	@Envio_N VARCHAR(50) = NULL,
	@Peso_Salida FLOAT = NULL,
	@Unidades_Peso_Salida VARCHAR(4) = NULL,
	@Barco_Id INT = NULL,
	@Usuario_Id INT = NULL,
	@Estado CHAR(1) = NULL,
	@Observaciones VARCHAR(200) = NULL,
	@valorBuscado VARCHAR(80)  = NULL,
	@accion VARCHAR(50)


AS
BEGIN
	IF @accion = 'insertarEntrada'
		BEGIN
			
			INSERT INTO Boleta(Fecha_Entrada, Placa_Cabezal, Placa_Rastra, Conductor_Id, Cliente_Id, Producto_Id, Peso_Ingreso, 
			Unidades_Peso_Ingreso, Cia_Transportista, Envio_N, Barco_Id, Usuario_Id, Estado, Observaciones) 
			VALUES(@Fecha_Entrada, @Placa_Cabezal, @Placa_Rastra, @Conductor_Id, @Cliente_Id, @Producto_Id, @Peso_Ingreso, @Unidades_Peso_Ingreso,
			@Cia_Transportista, @Envio_N, @Barco_Id, @Usuario_Id, @Estado, @Observaciones)
		END
	ELSE IF @accion = 'mostrarEntradas'
		BEGIN
			SELECT b.Boleta_Id 'Código de boleta', b.Fecha_Entrada 'Fecha de entrada', b.Placa_Cabezal 'Placa del cabezal', b.Placa_Rastra 'Placa de la rastra', c.Conductor_Id 'Código del conductor', c.Conductor,
			cl.Cliente, CONCAT(b.Peso_Ingreso,' ',b.Unidades_Peso_Ingreso) 'Peso de ingreso', b.Barco_Id 'Código del barco', bc.Descripcion 'Barco', b.Estado, u.Nombre_Usuario Usuario, b.Observaciones
			FROM Boleta b JOIN Conductor c
			ON b.Conductor_Id = c.Conductor_Id
			JOIN Producto p ON b.Producto_Id = p.Producto_Id
			JOIN Cliente cl ON b.Cliente_Id = cl.Cliente_Id
			JOIN Barco bc ON b.Barco_Id = bc.Barco_Id
			JOIN Usuario u ON b.Usuario_Id = u.Usuario_Id
			WHERE Estado = 'P'
			ORDER BY Boleta_Id DESC
			
		END
	ELSE IF @accion = 'cagarFormSalida'
		BEGIN
			SELECT b.Fecha_Entrada, b.Fecha_Salida, b.Conductor_Id, c.Conductor, b.Placa_Cabezal, b.Placa_Rastra, b.Cia_Transportista, b.Envio_N, b.Cliente_Id, cl.Cliente, b.Producto_Id,
			p.Descripcion Descripcion_Producto, b.Barco_Id, bc.Descripcion Descripcion_Barco, b.Peso_Ingreso, b.Peso_Salida, ((b.Peso_Ingreso - b.Peso_Salida) * -1) Peso_Neto, b.Observaciones
			FROM Boleta b JOIN Conductor c
			ON b.Conductor_Id = c.Conductor_Id
			JOIN Cliente cl ON b.Cliente_Id = cl.Cliente_Id
			JOIN Producto p ON b.Producto_Id = p.Producto_Id
			JOIN Barco bc ON b.Barco_Id = bc.Barco_Id
			WHERE Boleta_Id = @Boleta_Id
			
		END
	ELSE IF @accion = 'anularEntrada'
		BEGIN
			UPDATE Boleta SET  Estado = @Estado, Observaciones = @Observaciones WHERE Boleta_Id = @Boleta_Id
		END
	ELSE IF @accion = 'mostrarAnuladas'
		BEGIN
			SELECT b.Boleta_Id 'Código de boleta', b.Fecha_Entrada 'Fecha de entrada', b.Placa_Cabezal 'Placa del cabezal', b.Placa_Rastra 'Placa de la rastra', c.Conductor_Id 'Código del conductor', c.Conductor,
			cl.Cliente, CONCAT(b.Peso_Ingreso,' ',b.Unidades_Peso_Ingreso) 'Peso de ingreso', b.Barco_Id 'Código del barco', bc.Descripcion 'Barco', b.Estado, u.Nombre_Usuario Usuario, b.Observaciones
			FROM Boleta b JOIN Conductor c
			ON b.Conductor_Id = c.Conductor_Id
			JOIN Producto p ON b.Producto_Id = p.Producto_Id
			JOIN Cliente cl ON b.Cliente_Id = cl.Cliente_Id
			JOIN Barco bc ON b.Barco_Id = bc.Barco_Id
			JOIN Usuario u ON b.Usuario_Id = u.Usuario_Id
			WHERE Estado = 'A'
			ORDER BY Boleta_Id DESC
			
		END
	ELSE IF @accion = 'insertarSalida'
		BEGIN
			UPDATE Boleta SET Fecha_Salida = @Fecha_Salida, Peso_Salida = @Peso_Salida, Unidades_Peso_Salida = @Unidades_Peso_Salida, Estado = @Estado, Observaciones = @Observaciones WHERE Boleta_Id = @Boleta_Id
		END
	ELSE IF @accion = 'mostrarSalidas'
		BEGIN
			SELECT b.Boleta_Id 'Código de boleta', b.Fecha_Entrada 'Fecha de entrada', b.Fecha_Salida 'Fecha de salida', b.Placa_Cabezal 'Placa del cabezal', b.Placa_Rastra 'Placa de la rastra', c.Conductor_Id 'Código del conductor', c.Conductor,
			cl.Cliente, CONCAT(b.Peso_Ingreso,' ',b.Unidades_Peso_Ingreso) 'Peso de ingreso', CONCAT(b.Peso_Salida,' ',b.Unidades_Peso_Salida) 'Peso de salida', CONCAT(((b.Peso_Ingreso - b.Peso_Salida) * -1), ' ',b.Unidades_Peso_Salida) 'Peso neto', 
			b.Barco_Id 'Código del barco', bc.Descripcion 'Barco', b.Estado, u.Nombre_Usuario Usuario, b.Observaciones
			FROM Boleta b JOIN Conductor c
			ON b.Conductor_Id = c.Conductor_Id
			JOIN Producto p ON b.Producto_Id = p.Producto_Id
			JOIN Cliente cl ON b.Cliente_Id = cl.Cliente_Id
			JOIN Barco bc ON b.Barco_Id = bc.Barco_Id
			JOIN Usuario u ON b.Usuario_Id = u.Usuario_Id
			WHERE b.Estado = 'C'
			ORDER BY Boleta_Id DESC
			
		END
	ELSE IF @accion = 'buscarConductor'
		BEGIN
			SELECT * FROM Conductor WHERE Conductor_Id = @Conductor_Id
			
		END
	ELSE IF @accion = 'buscarCliente'
		BEGIN
			SELECT * FROM Cliente WHERE Cliente_Id = @Cliente_Id
			
		END
	ELSE IF @accion = 'buscarProducto'
		BEGIN
			SELECT * FROM Producto WHERE Producto_Id = @Producto_Id
			
		END
	ELSE IF @accion = 'buscarBarco'
		BEGIN
			SELECT * FROM Barco WHERE Barco_Id = @Barco_Id
			
		END
	ELSE IF @accion = 'datosBoleta'
		BEGIN
			SELECT b.Boleta_Id, b.Fecha_Entrada, b.Fecha_Salida, b.Placa_Cabezal, b.Placa_Rastra, c.Conductor_Id, c.Conductor, cl.Cliente, p.Descripcion Producto, CONCAT(b.Peso_Ingreso,' ',b.Unidades_Peso_Ingreso) Peso_Ingreso, 
			CONCAT(b.Peso_Salida,' ',b.Unidades_Peso_Salida) Peso_Salida, CONCAT(((b.Peso_Ingreso - b.Peso_Salida) * -1), ' ',b.Unidades_Peso_Salida) Peso_Neto, b.Barco_Id, bc.Descripcion Barco , b.Estado, u.Nombre_Usuario Usuario, 
			b.Observaciones
			FROM Boleta b JOIN Conductor c
			ON b.Conductor_Id = c.Conductor_Id
			JOIN Producto p ON b.Producto_Id = p.Producto_Id
			JOIN Cliente cl ON b.Cliente_Id = cl.Cliente_Id
			JOIN Barco bc ON b.Barco_Id = bc.Barco_Id
			JOIN Usuario u ON b.Usuario_Id = u.Usuario_Id
			WHERE b.Boleta_Id = @Boleta_Id
			
			
		END

END
GO*/

CREATE PROCEDURE sp_Database
@Ruta VARCHAR(70) = NULL,
@accion VARCHAR(50)

AS
BEGIN
	IF @accion = 'realizarBackup'
	BEGIN
		BACKUP DATABASE AWS_DB TO DISK=@Ruta 
	END


END
GO

CREATE PROCEDURE sp_Encabezado_Boleta
@Encabezado_Boleta_Id INT = NULL,
@Empresa VARCHAR(70) = NULL,
@Direccion VARCHAR(70) = NULL,
@Telefono VARCHAR(70) = NULL,
@accion VARCHAR(50)

AS
BEGIN
	IF @accion = 'insertar'
	BEGIN
		INSERT INTO Encabezado_Boleta VALUES (@Empresa, @Direccion, @Telefono)
	END
	ELSE IF @accion = 'modificar'
	BEGIN
		UPDATE Encabezado_Boleta SET Empresa = @Empresa, Direccion = @Direccion, Telefono = @Telefono   WHERE  Encabezado_Boleta_Id = @Encabezado_Boleta_Id
	END
	ELSE IF @accion = 'obtenerEncabezado'
	BEGIN
		SELECT TOP (1) * FROM Encabezado_Boleta
	END

END
GO

CREATE PROCEDURE sp_Indicador
@Indicador_Id INT = NULL,
@Port_Name VARCHAR(40) = NULL,
@Baud_Rate INT = NULL,
@Data_Bits INT = NULL,
@Parity VARCHAR(40) = NULL,
@Stop_Bit VARCHAR(40) = NULL,
@Maximo INT = NULL,
@Minimo INT = NULL,
@Posicion_Signo_Mas INT = NULL,
@accion VARCHAR(50)

AS
BEGIN
	IF @accion = 'insertar'
	BEGIN
		INSERT INTO Indicador VALUES (@Port_Name, @Baud_Rate, @Data_Bits, @Parity, @Stop_Bit, @Maximo, @Minimo, @Posicion_Signo_Mas)
	END
	ELSE IF @accion = 'modificar'
	BEGIN
		UPDATE Indicador SET Port_Name = @Port_Name, Baud_Rate = @Baud_Rate, Data_Bits = @Data_Bits, Parity = @Parity, Stop_Bit = @Stop_Bit, Maximo = @Maximo,
		Minimo = @Minimo, Posicion_Signo_Mas = @Posicion_Signo_Mas
		WHERE  Indicador_Id = @Indicador_Id
	END
	ELSE IF @accion = 'obtenerIndicador'
	BEGIN
		SELECT TOP (1) * FROM Indicador
	END

END
GO

CREATE PROCEDURE sp_Boleta
	@Boleta_Id INT = NULL,
	@Fecha_Entrada DATETIME = NULL,
	@Fecha_Salida DATETIME = NULL,
	@Placa_Cabezal VARCHAR(10) = NULL,
	@Placa_Rastra VARCHAR(10) = NULL,
	@Conductor_Id INT = NULL,
	@Cliente_Id INT = NULL,
	@Proveedor_Id INT = NULL,
	@Producto_Id INT = NULL,
	@Peso_Ingreso FLOAT = NULL,
	@Unidades_Peso_Ingreso VARCHAR(4) = NULL,
	@Cia_Transportista VARCHAR(25) = NULL,
	@Envio_N VARCHAR(50) = NULL,
	@Peso_Salida FLOAT = NULL,
	@Unidades_Peso_Salida VARCHAR(4) = NULL,
	@Barco_Id INT = NULL,
	@Usuario_Id INT = NULL,
	@Estado CHAR(1) = NULL,
	@Observaciones VARCHAR(200) = NULL,
	@valorBuscado VARCHAR(80)  = NULL,
	@fechaInicio DATETIME = NULL,	@fechaFinal DATETIME = NULL,
	@accion VARCHAR(50)


AS
BEGIN
	IF @accion = 'insertarEntrada'
		BEGIN
			
			INSERT INTO Boleta(Fecha_Entrada, Placa_Cabezal, Placa_Rastra, Conductor_Id, Cliente_Id, Producto_Id, Peso_Ingreso, 
			Unidades_Peso_Ingreso, Cia_Transportista, Envio_N, Barco_Id, Usuario_Id, Estado, Observaciones) 
			VALUES(@Fecha_Entrada, @Placa_Cabezal, @Placa_Rastra, @Conductor_Id, @Cliente_Id, @Producto_Id, @Peso_Ingreso, @Unidades_Peso_Ingreso,
			@Cia_Transportista, @Envio_N, @Barco_Id, @Usuario_Id, @Estado, @Observaciones)
		END
	ELSE IF @accion = 'mostrarEntradas'
		BEGIN
			SELECT b.Boleta_Id 'Código de boleta', b.Fecha_Entrada 'Fecha de entrada', b.Placa_Cabezal 'Placa del cabezal', b.Placa_Rastra 'Placa de la rastra', c.Conductor_Id 'Código del conductor', c.Conductor,
			cl.Cliente, p.Descripcion Prodcuto, CONCAT(b.Peso_Ingreso,' ',b.Unidades_Peso_Ingreso) 'Peso de ingreso', b.Barco_Id 'Código del barco', bc.Descripcion 'Barco', b.Estado, u.Nombre_Usuario Usuario, b.Observaciones
			FROM Boleta b JOIN Conductor c
			ON b.Conductor_Id = c.Conductor_Id
			JOIN Producto p ON b.Producto_Id = p.Producto_Id
			JOIN Cliente cl ON b.Cliente_Id = cl.Cliente_Id
			JOIN Barco bc ON b.Barco_Id = bc.Barco_Id
			JOIN Usuario u ON b.Usuario_Id = u.Usuario_Id
			WHERE Estado = 'P'
			ORDER BY Boleta_Id DESC
			
		END
	ELSE IF @accion = 'cagarFormSalida'
		BEGIN
			SELECT b.Fecha_Entrada, b.Fecha_Salida, b.Conductor_Id, c.Conductor, b.Placa_Cabezal, b.Placa_Rastra, b.Cia_Transportista, b.Envio_N, b.Cliente_Id, cl.Cliente, b.Producto_Id,
			p.Descripcion Descripcion_Producto, b.Barco_Id, bc.Descripcion Descripcion_Barco, b.Peso_Ingreso, b.Peso_Salida, ((b.Peso_Ingreso - b.Peso_Salida) * -1) Peso_Neto, b.Observaciones
			FROM Boleta b JOIN Conductor c
			ON b.Conductor_Id = c.Conductor_Id
			JOIN Cliente cl ON b.Cliente_Id = cl.Cliente_Id
			JOIN Producto p ON b.Producto_Id = p.Producto_Id
			JOIN Barco bc ON b.Barco_Id = bc.Barco_Id
			WHERE Boleta_Id = @Boleta_Id
			
		END
	IF @accion = 'insertarSalida'
		BEGIN
			UPDATE Boleta SET Fecha_Salida = @Fecha_Salida, Placa_Cabezal = @Placa_Cabezal, Placa_Rastra = @Placa_Rastra, Conductor_Id = @Conductor_Id, Cliente_Id = @Cliente_Id, Producto_Id = @Producto_Id, Cia_Transportista = @Cia_Transportista,
			Envio_N = @Envio_N, Peso_Salida = @Peso_Salida, Unidades_Peso_Salida = @Unidades_Peso_Salida, Barco_Id = @Barco_Id, Estado = @Estado, Observaciones = @Observaciones 
			
			WHERE Boleta_Id = @Boleta_Id
		END
	ELSE IF @accion = 'mostrarSalidas'
		BEGIN
			SELECT b.Boleta_Id 'Código de boleta', b.Fecha_Entrada 'Fecha de entrada', b.Fecha_Salida 'Fecha de salida', b.Placa_Cabezal 'Placa del cabezal', b.Placa_Rastra 'Placa de la rastra', c.Conductor_Id 'Código del conductor', c.Conductor,
			cl.Cliente, p.Descripcion Producto, CONCAT(b.Peso_Ingreso,' ',b.Unidades_Peso_Ingreso) 'Peso de ingreso', CONCAT(b.Peso_Salida,' ',b.Unidades_Peso_Salida) 'Peso de salida', CONCAT(((b.Peso_Ingreso - b.Peso_Salida) * -1), ' ',b.Unidades_Peso_Salida) 'Peso neto', 
			b.Barco_Id 'Código del barco', bc.Descripcion 'Barco', b.Estado, u.Nombre_Usuario Usuario, b.Observaciones
			FROM Boleta b JOIN Conductor c
			ON b.Conductor_Id = c.Conductor_Id
			JOIN Producto p ON b.Producto_Id = p.Producto_Id
			JOIN Cliente cl ON b.Cliente_Id = cl.Cliente_Id
			JOIN Barco bc ON b.Barco_Id = bc.Barco_Id
			JOIN Usuario u ON b.Usuario_Id = u.Usuario_Id
			WHERE b.Estado = 'C'
			ORDER BY Boleta_Id DESC
			
		END
	ELSE IF @accion = 'buscarSalidas'
		BEGIN
			SELECT b.Boleta_Id 'Código de boleta', b.Fecha_Entrada 'Fecha de entrada', b.Fecha_Salida 'Fecha de salida', b.Placa_Cabezal 'Placa del cabezal', b.Placa_Rastra 'Placa de la rastra', c.Conductor_Id 'Código del conductor', c.Conductor,
			cl.Cliente, p.Descripcion Producto, CONCAT(b.Peso_Ingreso,' ',b.Unidades_Peso_Ingreso) 'Peso de ingreso', CONCAT(b.Peso_Salida,' ',b.Unidades_Peso_Salida) 'Peso de salida', CONCAT(((b.Peso_Ingreso - b.Peso_Salida) * -1), ' ',b.Unidades_Peso_Salida) 'Peso neto', 
			b.Barco_Id 'Código del barco', bc.Descripcion 'Barco', b.Estado, u.Nombre_Usuario Usuario, b.Observaciones
			FROM Boleta b JOIN Conductor c
			ON b.Conductor_Id = c.Conductor_Id
			JOIN Producto p ON b.Producto_Id = p.Producto_Id
			JOIN Cliente cl ON b.Cliente_Id = cl.Cliente_Id
			JOIN Barco bc ON b.Barco_Id = bc.Barco_Id
			JOIN Usuario u ON b.Usuario_Id = u.Usuario_Id
			WHERE b.Estado = 'C' AND CONVERT(DATE, B.Fecha_Salida) BETWEEN @fechaInicio and @fechaFinal AND 
			CONCAT(b.Boleta_Id, ' ', b.Conductor_Id, ' ', b.Placa_Rastra,' ' ,b.Placa_Cabezal,' ' ,c.Conductor_Id,' ' ,c.Conductor,' ' ,Cliente,' ',p.Descripcion, ' ',bc.Barco_Id ,' ',bc.Descripcion, ' ', u.Nombre_Usuario, ' ', u.Usuario, ' ', b.Observaciones) LIKE CONCAT('%',@valorBuscado,'%')
			ORDER BY Boleta_Id DESC
			
		END
	ELSE IF @accion = 'anularEntrada'
		BEGIN
			UPDATE Boleta SET  Estado = @Estado, Observaciones = @Observaciones WHERE Boleta_Id = @Boleta_Id
		END
	ELSE IF @accion = 'mostrarAnuladas'
		BEGIN
			SELECT b.Boleta_Id 'Código de boleta', b.Fecha_Entrada 'Fecha de entrada', b.Placa_Cabezal 'Placa del cabezal', b.Placa_Rastra 'Placa de la rastra', c.Conductor_Id 'Código del conductor', c.Conductor,
			cl.Cliente, p.Descripcion Producto, CONCAT(b.Peso_Ingreso,' ',b.Unidades_Peso_Ingreso) 'Peso de ingreso', b.Barco_Id 'Código del barco', bc.Descripcion 'Barco', b.Estado, u.Nombre_Usuario Usuario, b.Observaciones
			FROM Boleta b JOIN Conductor c
			ON b.Conductor_Id = c.Conductor_Id
			JOIN Producto p ON b.Producto_Id = p.Producto_Id
			JOIN Cliente cl ON b.Cliente_Id = cl.Cliente_Id
			JOIN Barco bc ON b.Barco_Id = bc.Barco_Id
			JOIN Usuario u ON b.Usuario_Id = u.Usuario_Id
			WHERE Estado = 'A'
			ORDER BY Boleta_Id DESC

		END
	ELSE IF @accion = 'buscarAnuladas'
		BEGIN
			SELECT b.Boleta_Id 'Código de boleta', b.Fecha_Entrada 'Fecha de entrada', b.Placa_Cabezal 'Placa del cabezal', b.Placa_Rastra 'Placa de la rastra', c.Conductor_Id 'Código del conductor', c.Conductor,
			cl.Cliente, p.Descripcion Producto, CONCAT(b.Peso_Ingreso,' ',b.Unidades_Peso_Ingreso) 'Peso de ingreso', b.Barco_Id 'Código del barco', bc.Descripcion 'Barco', b.Estado, u.Nombre_Usuario Usuario, b.Observaciones
			FROM Boleta b JOIN Conductor c
			ON b.Conductor_Id = c.Conductor_Id
			JOIN Producto p ON b.Producto_Id = p.Producto_Id
			JOIN Cliente cl ON b.Cliente_Id = cl.Cliente_Id
			JOIN Barco bc ON b.Barco_Id = bc.Barco_Id
			JOIN Usuario u ON b.Usuario_Id = u.Usuario_Id
			WHERE Estado = 'A'AND CONVERT(DATE, B.Fecha_Entrada) BETWEEN @fechaInicio and @fechaFinal AND 
			CONCAT(b.Boleta_Id, ' ', b.Conductor_Id, ' ', b.Placa_Rastra,' ' ,b.Placa_Cabezal,' ' ,c.Conductor_Id,' ' ,c.Conductor,' ' ,Cliente,' ',p.Descripcion, ' ',bc.Barco_Id ,' ',bc.Descripcion, ' ', u.Nombre_Usuario, ' ', u.Usuario, ' ', b.Observaciones) LIKE CONCAT('%',@valorBuscado,'%')
			ORDER BY Boleta_Id DESC
		END
	ELSE IF @accion = 'buscarConductor'
		BEGIN
			SELECT * FROM Conductor WHERE Conductor_Id = @Conductor_Id
			
		END
	ELSE IF @accion = 'buscarCliente'
		BEGIN
			SELECT * FROM Cliente WHERE Cliente_Id = @Cliente_Id
			
		END
	ELSE IF @accion = 'buscarProducto'
		BEGIN
			SELECT * FROM Producto WHERE Producto_Id = @Producto_Id
			
		END
	ELSE IF @accion = 'buscarBarco'
		BEGIN
			SELECT * FROM Barco WHERE Barco_Id = @Barco_Id
			
		END
	ELSE IF @accion = 'ultimaBoleta'
		BEGIN
			SELECT MAX(Boleta_Id) Boleta_Id FROM Boleta
			
		END

END
GO

CREATE PROCEDURE sp_Bitacora@value SQL_VARIANT = NULL,@key SYSNAME = NULL,@buscado VARCHAR(80)  = NULL,@fechaInicio DATETIME = NULL,@fechaFinal DATETIME = NULL,@accion nvarchar(50)ASBEGIN
	IF @accion = 'Usuario_Id'		BEGIN		EXEC sp_set_session_context @key, @value		END
	ELSE IF @accion = 'mostrar'		BEGIN
			SELECT b.Bitacora_Id 'Código de registro', CONVERT(DATE, b.Fecha) Fecha, CONVERT(VARCHAR, b.Fecha, 8) Hora, u.Usuario, B.Usuario_PC 'PC', UPPER(b.Tipo_Accion) 'Tipo', UPPER(b.Accion) Accion
			FROM Bitacora b JOIN Usuario u
			ON u.Usuario_Id = b.Usuario_Id
		    WHERE CONVERT(DATE, b.Fecha) BETWEEN @fechaInicio and @fechaFinal and CONCAT(u.Usuario_Id, ' ', u.Usuario, ' ', b.Tipo_Accion,' ' ,b.accion) LIKE CONCAT('%',@buscado,'%')
			ORDER BY b.Bitacora_Id DESC
		END

END
GO

CREATE PROCEDURE sp_ComboBox@accion nvarchar(50)ASBEGIN
	IF @accion = 'ComboBoxEstadoBoleta'	BEGIN		SELECT '%' Identificador, 'TODAS LAS BOLETAS' Estado		UNION		SELECT 'A' Identificador, 'ANULADAS' Estado		UNION		SELECT 'C' Identificador, 'CERRADAS' Estado		UNION		SELECT 'P' Identificador, 'EN PROCESO' Estado	END

END
GO

--PROCEDMIENTOS ALMACENADOS REPORTES
CREATE PROCEDURE sp_Datos_Boleta
	@Boleta_Id INT = NULL
AS
BEGIN
	
	SELECT b.Boleta_Id, b.Fecha_Entrada, b.Fecha_Salida, b.Placa_Cabezal, b.Placa_Rastra, c.Conductor_Id, c.Conductor, cl.Cliente, p.Descripcion Producto, CONCAT(b.Peso_Ingreso,' ',b.Unidades_Peso_Ingreso) Peso_Ingreso, 
	CONCAT(b.Peso_Salida,' ',b.Unidades_Peso_Salida) Peso_Salida, CONCAT(((b.Peso_Ingreso - b.Peso_Salida) * -1), ' ',b.Unidades_Peso_Salida) Peso_Neto, b.Barco_Id, bc.Descripcion Barco , b.Estado, u.Nombre_Usuario Usuario, 
	b.Observaciones
	FROM Boleta b JOIN Conductor c
	ON b.Conductor_Id = c.Conductor_Id
	JOIN Producto p ON b.Producto_Id = p.Producto_Id
	JOIN Cliente cl ON b.Cliente_Id = cl.Cliente_Id
	JOIN Barco bc ON b.Barco_Id = bc.Barco_Id
	JOIN Usuario u ON b.Usuario_Id = u.Usuario_Id
	WHERE b.Boleta_Id = @Boleta_Id
END
GO

CREATE PROCEDURE sp_Datos_Boleta_Entrada
	@Boleta_Id INT = NULL
AS
BEGIN
	
	SELECT b.Boleta_Id, b.Fecha_Entrada, b.Placa_Cabezal, b.Placa_Rastra, c.Conductor_Id, c.Conductor, cl.Cliente, p.Descripcion Producto, 
	CONCAT(b.Peso_Ingreso,' ',b.Unidades_Peso_Ingreso) Peso_Ingreso, b.Barco_Id, bc.Descripcion Barco , b.Estado, u.Nombre_Usuario Usuario, 
	b.Observaciones
	FROM Boleta b JOIN Conductor c
	ON b.Conductor_Id = c.Conductor_Id
	JOIN Producto p ON b.Producto_Id = p.Producto_Id
	JOIN Cliente cl ON b.Cliente_Id = cl.Cliente_Id
	JOIN Barco bc ON b.Barco_Id = bc.Barco_Id
	JOIN Usuario u ON b.Usuario_Id = u.Usuario_Id
	WHERE b.Boleta_Id = @Boleta_Id
END
GO

CREATE PROCEDURE sp_Obtener_Encabezado_Boleta
AS
BEGIN
	
	SELECT TOP (1) * FROM Encabezado_Boleta
			
END
GO

CREATE PROCEDURE sp_Reporte_Mostrar_Boletas
	@buscado VARCHAR(80)  = NULL,	@fechaInicio DATETIME = NULL,	@fechaFinal DATETIME = NULL,
	@estado VARCHAR(10) = NULL
AS
BEGIN
	
	SELECT b.Boleta_Id, b.Fecha_Entrada, b.Fecha_Salida, b.Placa_Cabezal, b.Placa_Rastra, c.Conductor,
			cl.Cliente, p.Descripcion Producto, CONCAT(b.Peso_Ingreso,' ',b.Unidades_Peso_Ingreso) Peso_Ingreso, CONCAT(b.Peso_Salida,' ',b.Unidades_Peso_Salida) Peso_Salida, CONCAT(((b.Peso_Ingreso - b.Peso_Salida) * -1), ' ',b.Unidades_Peso_Salida) Peso_Neto, 
			bc.Descripcion Barco, b.Estado, u.Nombre_Usuario Usuario, b.Observaciones, @fechaInicio fechaInicio, @fechaFinal fechaFinal
			FROM Boleta b JOIN Conductor c
			ON b.Conductor_Id = c.Conductor_Id
			JOIN Producto p ON b.Producto_Id = p.Producto_Id
			JOIN Cliente cl ON b.Cliente_Id = cl.Cliente_Id
			JOIN Barco bc ON b.Barco_Id = bc.Barco_Id
			JOIN Usuario u ON b.Usuario_Id = u.Usuario_Id
			WHERE b.Estado LIKE CONCAT('%',@estado,'%')  AND CONVERT(DATE, B.Fecha_Entrada) BETWEEN @fechaInicio and @fechaFinal AND 
			CONCAT(b.Boleta_Id, ' ', b.Conductor_Id, ' ', b.Placa_Rastra,' ' ,b.Placa_Cabezal,' ' ,c.Conductor_Id,' ' ,c.Conductor,' ' ,Cliente,' ',p.Descripcion, ' ',bc.Barco_Id ,' ',bc.Descripcion, ' ', u.Nombre_Usuario, ' ', u.Usuario) LIKE CONCAT('%',@buscado,'%')
			ORDER BY Boleta_Id DESC
			
END
GO

CREATE PROCEDURE sp_Reporte_Bitacora
	@buscado VARCHAR(80)  = NULL,	@fechaInicio DATETIME = NULL,	@fechaFinal DATETIME = NULL
AS
BEGIN
	
	SELECT b.Bitacora_Id , CONVERT(DATE, b.Fecha) Fecha, CONVERT(VARCHAR, b.Fecha, 8) Hora, u.Usuario, B.Usuario_PC 'PC', UPPER(b.Tipo_Accion) 'Tipo', UPPER(b.Accion) Accion,
			@fechaInicio fechaInicio, @fechaFinal fechaFinal
			FROM Bitacora b JOIN Usuario u
			ON u.Usuario_Id = b.Usuario_Id
		    WHERE CONVERT(DATE, b.Fecha) BETWEEN @fechaInicio and @fechaFinal and CONCAT(u.Usuario_Id, ' ', u.Usuario, ' ', b.Tipo_Accion,' ' ,b.accion) LIKE CONCAT('%',@buscado,'%')
			ORDER BY b.Bitacora_Id DESC
			
END
GO





--TRIGGERS PARA BITACORA



-- TABLA DE BARCO

CREATE TRIGGER Insertar_Barco
ON Barco AFTER INSERT
AS
BEGIN
declare @id sql_variant
	set @id = (select SESSION_CONTEXT(N'user_id'));
	INSERT INTO Bitacora
	select cast(@id as int), 
SYSTEM_USER,'Insertar',
CONCAT('Inserción del barco ', Descripcion,  ' con código ', Barco_Id),
GETDATE()
from inserted
END
GO

CREATE TRIGGER Modificar_Barco
ON Barco AFTER UPDATE
AS
BEGIN
declare @id sql_variant
	set @id = (select SESSION_CONTEXT(N'user_id'));
	INSERT INTO Bitacora
select cast(@id as int), 
SYSTEM_USER,'Modificar',
CONCAT('Modificación del barco ', Descripcion,  ' con código ', Barco_Id),
GETDATE()
from inserted
END
GO


-- TABLA DE CLIENTE

CREATE TRIGGER Insertar_Cliente
ON Cliente AFTER INSERT
AS
BEGIN
declare @id sql_variant
	set @id = (select SESSION_CONTEXT(N'user_id'));
	INSERT INTO Bitacora
	select cast(@id as int), 
SYSTEM_USER,'Insertar',
CONCAT('Inserción del cliente ', Cliente,  ' con código ', Cliente_Id),
GETDATE()
from inserted
END
GO

CREATE TRIGGER Modificar_Cliente
ON Cliente AFTER UPDATE
AS
BEGIN
declare @id sql_variant
	set @id = (select SESSION_CONTEXT(N'user_id'));
	INSERT INTO Bitacora
select cast(@id as int), 
SYSTEM_USER,'Modificar',
CONCAT('Modificación del cliente ', Cliente,  ' con código ', Cliente_Id),
GETDATE()
from inserted
END
GO

-- TABLA DE BOLETA

CREATE TRIGGER Insertar_Boleta
ON Boleta AFTER INSERT
AS
BEGIN
declare @id sql_variant
	set @id = (select SESSION_CONTEXT(N'user_id'));
	INSERT INTO Bitacora
	select cast(@id as int), 
SYSTEM_USER,'Insertar',
CONCAT('Ingreso de vehículo con número de boleta ', Boleta_Id),
GETDATE()
from inserted
END
GO

CREATE TRIGGER Modificar_Boleta
ON Boleta AFTER UPDATE
AS
BEGIN
declare @id sql_variant
	set @id = (select SESSION_CONTEXT(N'user_id'));
	IF (Select Estado from inserted) = 'C'
	BEGIN
	INSERT INTO Bitacora
		select cast(@id as int), 
		SYSTEM_USER,'Modificar',
		CONCAT('Salida de vehículo con número de boleta ', Boleta_Id),
		GETDATE()
		from inserted
	END
	ELSE IF (Select Estado from inserted) = 'A'
	BEGIN
	INSERT INTO Bitacora
		select cast(@id as int), 
		SYSTEM_USER,'Anular',
		CONCAT('Anulación de boleta ', Boleta_Id),
		GETDATE()
		from inserted
	END
END
GO

-- TABLA DE CONDUCTOR

CREATE TRIGGER Insertar_Conductor
ON Conductor AFTER INSERT
AS
BEGIN
declare @id sql_variant
	set @id = (select SESSION_CONTEXT(N'user_id'));
	INSERT INTO Bitacora
	select cast(@id as int), 
SYSTEM_USER,'Insertar',
CONCAT('Inserción del conductor ', Conductor,  ' con código ', Conductor_Id),
GETDATE()
from inserted
END
GO

CREATE TRIGGER Modificar_Conductor
ON Conductor AFTER UPDATE
AS
BEGIN
declare @id sql_variant
	set @id = (select SESSION_CONTEXT(N'user_id'));
	INSERT INTO Bitacora
select cast(@id as int), 
SYSTEM_USER,'Modificar',
CONCAT('Modificación del conductor ', Conductor,  ' con código ', Conductor_Id),
GETDATE()
from inserted
END
GO

-- TABLA DE ENCABEZADO_BOLETA

CREATE TRIGGER Insertar_Encabezado_Boleta
ON Encabezado_Boleta AFTER INSERT
AS
BEGIN
declare @id sql_variant
	set @id = (select SESSION_CONTEXT(N'user_id'));
	INSERT INTO Bitacora
	select cast(@id as int), 
SYSTEM_USER,'Insertar',
CONCAT('Inserción de encabezado de boleta: Empresa - ', Empresa, ', Direccion - ', Direccion),
GETDATE()
from inserted
END
GO

CREATE TRIGGER Modificar_Encabezado_Boleta
ON Encabezado_Boleta AFTER UPDATE
AS
BEGIN
declare @id sql_variant
	set @id = (select SESSION_CONTEXT(N'user_id'));
	INSERT INTO Bitacora
select cast(@id as int), 
SYSTEM_USER,'Modificar',
CONCAT('Modificación de encabezado de boleta: Empresa - ', Empresa, ', Direccion - ', Direccion),
GETDATE()
from inserted
END
GO

-- TABLA DE INDICADOR

CREATE TRIGGER Insertar_Idicador
ON Indicador AFTER INSERT
AS
BEGIN
declare @id sql_variant
	set @id = (select SESSION_CONTEXT(N'user_id'));
	INSERT INTO Bitacora
	select cast(@id as int), 
SYSTEM_USER,'Indicador',
CONCAT('Inserción de configuración de indicador con puerto ', Port_Name),
GETDATE()
from inserted
END
GO

CREATE TRIGGER Modificar_Indicador
ON Indicador AFTER UPDATE
AS
BEGIN
declare @id sql_variant
	set @id = (select SESSION_CONTEXT(N'user_id'));
	INSERT INTO Bitacora
select cast(@id as int), 
SYSTEM_USER,'Modificar',
CONCAT('Modificación de configuración de indicador con puerto ', Port_Name),
GETDATE()
from inserted
END
GO

-- TABLA DE PRODUCTO

CREATE TRIGGER Insertar_Producto
ON Producto AFTER INSERT
AS
BEGIN
declare @id sql_variant
	set @id = (select SESSION_CONTEXT(N'user_id'));
	INSERT INTO Bitacora
	select cast(@id as int), 
SYSTEM_USER,'Insertar',
CONCAT('Inserción del producto ', Descripcion,  ' con código ', Producto_Id),
GETDATE()
from inserted
END
GO

CREATE TRIGGER Modificar_Producto
ON Producto AFTER UPDATE
AS
BEGIN
declare @id sql_variant
	set @id = (select SESSION_CONTEXT(N'user_id'));
	INSERT INTO Bitacora
select cast(@id as int), 
SYSTEM_USER,'Modificar',
CONCAT('Modificación del producto ', Descripcion,  ' con código ', Producto_Id),
GETDATE()
from inserted
END
GO

-- TABLA DE USUARIO

CREATE TRIGGER Insertar_Usuario
ON Usuario AFTER INSERT
AS
BEGIN
declare @id sql_variant
	set @id = (select SESSION_CONTEXT(N'user_id'));
	INSERT INTO Bitacora
	select cast(@id as int), 
SYSTEM_USER,'Insertar',
CONCAT('Inserción del usuario ', Usuario,  ' con código ', Usuario_Id),
GETDATE()
from inserted
END
GO

CREATE TRIGGER Modificar_Usuario
ON Usuario AFTER UPDATE
AS
BEGIN
declare @id sql_variant
	set @id = (select SESSION_CONTEXT(N'user_id'));
	INSERT INTO Bitacora
select cast(@id as int), 
SYSTEM_USER,'Modificar',
CONCAT('Modificación del usuario ', Usuario,  ' con código ', Usuario_Id),
GETDATE()
from inserted
END
GO