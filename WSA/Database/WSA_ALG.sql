USE tempdb
GO

--DROP DATABASE WSA_ALG
-- Crear la base de datos

CREATE DATABASE WSA_ALG
GO

USE WSA_ALG
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
	Placa_Cabezal VARCHAR(10) NOT NULL,
	Placa_Rastra VARCHAR(10) NOT NULL,
	Conductor_Id INT NOT NULL,
	Cliente_Id INT NULL,
	Proveedor_Id INT NULL,
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

	CONSTRAINT FK_Boleta$Existe$Proveedor
		FOREIGN KEY (Proveedor_Id) REFERENCES Proveedor(Proveedor_Id),

	CONSTRAINT FK_Boleta$Existe$Producto
		FOREIGN KEY (Producto_Id) REFERENCES Producto(Producto_Id),

	CONSTRAINT FK_Boleta$Existe$Usuario
		FOREIGN KEY (Usuario_Id) REFERENCES Usuario(Usuario_Id),

	CONSTRAINT FK_Boleta$Existe$Barco
		FOREIGN KEY (Barco_Id) REFERENCES Barco(Barco_Id)

);
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

END
GO

ALTER PROCEDURE sp_Boleta
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
			cl.Cliente, CONCAT(b.Peso_Ingreso,' ',b.Unidades_Peso_Ingreso) 'Peso de ingreso', b.Barco_Id 'Código del barco', bc.Descripcion 'Barco', b.Estado, b.Observaciones
			FROM Boleta b JOIN Conductor c
			ON b.Conductor_Id = c.Conductor_Id
			JOIN Producto p ON b.Producto_Id = p.Producto_Id
			JOIN Cliente cl ON b.Cliente_Id = cl.Cliente_Id
			JOIN Barco bc ON b.Barco_Id = bc.Barco_Id
			WHERE Estado = 'P'
			
		END
	ELSE IF @accion = 'cagarFormSalida'
		BEGIN
			SELECT b.Fecha_Entrada, b.Conductor_Id, c.Conductor, b.Placa_Cabezal, b.Placa_Rastra, b.Cia_Transportista, b.Envio_N, b.Cliente_Id, cl.Cliente, b.Producto_Id,
			p.Descripcion Descripcion_Producto, b.Barco_Id, bc.Descripcion Descripcion_Barco, b.Peso_Ingreso, b.Observaciones
			FROM Boleta b JOIN Conductor c
			ON b.Conductor_Id = c.Conductor_Id
			JOIN Cliente cl ON b.Cliente_Id = cl.Cliente_Id
			JOIN Producto p ON b.Producto_Id = p.Producto_Id
			JOIN Barco bc ON b.Barco_Id = bc.Barco_Id
			WHERE Boleta_Id = @Boleta_Id
			
		END
	IF @accion = 'insertarSalida'
		BEGIN
			UPDATE Boleta SET Fecha_Salida = @Fecha_Salida, Peso_Salida = @Peso_Salida, Unidades_Peso_Salida = @Unidades_Peso_Salida, Estado = @Estado, Observaciones = @Observaciones WHERE Boleta_Id = @Boleta_Id
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

END
GO